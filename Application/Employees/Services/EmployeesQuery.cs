using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Employees.Entities;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Employees.Services
{
    public class EmployeesQuery
    {
        private readonly DataContext context;

        public EmployeesQuery(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<EmployeesLookup>> GetEmployeesAsync()
        {   
            return await (from employee in this.context.Employees
                          join roleDescription in this.context.RoleDescriptions on employee.RoleDescriptionId equals roleDescription.Id
                          select new EmployeesLookup()
                          {
                              Name = employee.Name,
                              Surname = employee.Surname,
                              BirthDate = employee.BirthDate,
                              EmployeeNumber = employee.EmployeeNumber,
                              Salary = employee.Salary,
                              ManagerId = employee.ManagerId,
                              
                              RoleDescriptionType = roleDescription.RoleDescriptionType
                          }).ToListAsync().ConfigureAwait(false);
        }
        public async Task<EmployeesLookup> GetEmployeeByEmployeeNumberAsync(int employeeNumber)
        {
              return await (from employee in this.context.Employees
                          join roleDescription in this.context.RoleDescriptions on employee.RoleDescriptionId equals roleDescription.Id
                          where employee.EmployeeNumber == employeeNumber
                          select new EmployeesLookup()
                          {
                              Name = employee.Name,
                              Surname = employee.Surname,
                              BirthDate = employee.BirthDate,
                              EmployeeNumber = employee.EmployeeNumber,
                              Salary = employee.Salary,
                              RoleDescriptionType = roleDescription.RoleDescriptionType,
                              EmployeeId = employee.EmployeeId,
                          }).FirstOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<List<OrganisationLookup>> GetOrganisationalStructureAsync()
        {
            List<OrganisationLookup> structure = new List<OrganisationLookup>();
            var employees = await this.GetEmployeesAsync().ConfigureAwait(false);
            var managers = employees.FindAll(c => c.ManagerId == null);
            foreach(var manager in managers)
            {
                var children  = await this.GetChildren(manager.EmployeeNumber).ConfigureAwait(false);
                structure.Add(new OrganisationLookup()
                {
                    Manager = manager,
                    Children = children,
                });
            }
            return structure;
        }

        private async Task<List<EmployeesLookup>> GetChildren(int empId) 
        {
              return await (from employee in this.context.Employees
                            join roleDescription in this.context.RoleDescriptions on employee.RoleDescriptionId equals roleDescription.Id
                            where employee.Parent == empId
                             select new EmployeesLookup()
                          {
                              Name = employee.Name,
                              Surname = employee.Surname,
                              BirthDate = employee.BirthDate,
                              EmployeeNumber = employee.EmployeeNumber,
                              Salary = employee.Salary,
                              ManagerId = employee.ManagerId,
                              
                              RoleDescriptionType = roleDescription.RoleDescriptionType
                          }).ToListAsync().ConfigureAwait(false);
        }
    }
}