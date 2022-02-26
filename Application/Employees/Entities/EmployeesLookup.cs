using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Employees.Entities
{
    public class EmployeesLookup
    {
        public Guid Id { get; set; } 

        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public int EmployeeNumber { get; set; }

        public string Salary { get; set; }

        public string RoleDescriptionType { get; set; }

        public int ReportingLine { get; set; }

        public int? ManagerId { get; set; }
    }
}