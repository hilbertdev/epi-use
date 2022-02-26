using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Employees.Any()) return;

            var employees = new List<Employee>
            {
                new Employee
                {
                    Name = "John",
                    Surname = "Smith",
                    BirthDate = new DateTime(1980,11,18),
                    EmployeeNumber = 1,
                    ManagerId = null,
                    Salary = "R700,000.00",
                    RoleDescriptionId = 1,
                },
              new Employee
                {
                    Name = "Jane",
                    Surname = "Doe",
                    BirthDate = new DateTime(1995,01,31),
                    EmployeeNumber = 2,
                    Parent = 1,
                      ManagerId = 1,
                    Salary = "R150,000.00",
                    RoleDescriptionId = 2,
                },
           new Employee
                {
                    Name = "jim",
                    Surname = "Bean",
                    BirthDate = new DateTime(1987,03,23),
                    EmployeeNumber = 3,
                    Parent = 2,
                      ManagerId = 1,
                    Salary = "R175,000.00",
                    RoleDescriptionId = 2,
                },
             new Employee
                {
                    Name = "Roger Wilco",
                    Surname = "Smith",
                    BirthDate = new DateTime(1978,12,27),
                    EmployeeNumber = 4,
                    Parent = 3,
                      ManagerId = 1,
                    Salary = "R100,000.00",
                    RoleDescriptionId = 3,
                },
                   new Employee
                {
                    Name = "Susan",
                    BirthDate = new DateTime(1986,09,20),
                    Surname = "Roe",
                    EmployeeNumber = 5,
                    Salary = "R100,000.00",
                    Parent = 3,
                    ManagerId = 1,
                    RoleDescriptionId = 3,
                },
              new Employee
                {
                    Name = "John",
                    Surname = "Did",
                    BirthDate = new DateTime(1986,08,20),
                    ManagerId = null,
                    Parent = null,
                    EmployeeNumber = 6,
                    Salary = "R750,000.00",
                    RoleDescriptionId = 1
                },
             new Employee
                {
                    Name = "Josh",
                    Surname = "Taylor",
                    BirthDate = new DateTime(1992,07,15),
                    EmployeeNumber = 7,
                    Parent = 6,
                    ManagerId = 6,
                    Salary = "R150,000.00",
                    RoleDescriptionId = 2,
                },
            new Employee
                {
                    Name = "Gilad",
                    Surname = "Mannington",
                    BirthDate = new DateTime(1997,11,20),
                    EmployeeNumber = 8,
                    Parent = 7,
                    Salary = "R110,000.00",
                    ManagerId =6,
                    RoleDescriptionId = 3,
                },
            };
            var roleDescriptions = new List<RoleDescription>()
            {
                 new RoleDescription()
                 {
                     Id = 1,
                     RoleDescriptionType = "Manager",
                     RoleDescriptionCode = "M",
                 },
                  new RoleDescription()
                 {
                     Id = 2,
                     RoleDescriptionType = "Employee",
                     RoleDescriptionCode = "E",
                 },
                  new RoleDescription()
                 {
                     Id = 3,
                     RoleDescriptionType = "Trainee",
                     RoleDescriptionCode = "T",
                 },
            };
            var organisation = new List<Organisation>()
            {
                new Organisation()
                {       
                    EmployeeId = 1,
                    ReportingLine = 0,
                    RoleDescriptionId = 1,    
                },
                new Organisation()
                {
                    EmployeeId = 2,
                    ReportingLine = 1,
                    RoleDescriptionId = 2,    
                },
                new Organisation()
                {
             
                    EmployeeId = 3,
                    ReportingLine = 2,
                    RoleDescriptionId = 2,    
                },
                new Organisation()
                {
                
                    EmployeeId = 4,
                    ReportingLine = 3,
                    RoleDescriptionId = 3,    
                },
                new Organisation()
                {
                    EmployeeId = 5,
                    ReportingLine = 3,
                    RoleDescriptionId = 3,    
                },
                new Organisation()
                {
                  
                    EmployeeId = 6,
                    ReportingLine = 0,
                    RoleDescriptionId = 1,    
                },
                new Organisation()
                {
                
                    EmployeeId = 7,
                    ReportingLine = 6,
                    RoleDescriptionId = 2,    
                },
                new Organisation()
                {
                    EmployeeId = 8,
                    ReportingLine = 7,
                    RoleDescriptionId = 3,    
                }
            };

            await context.Employees.AddRangeAsync(employees);
            await context.RoleDescriptions.AddRangeAsync(roleDescriptions);
            await context.Organisations.AddRangeAsync(organisation);
            await context.SaveChangesAsync();
        }
    }
}