using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee 
    {
        [Key]
        public int EmployeeId { get; set; } 

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public int EmployeeNumber { get; set; }

        public string Salary { get; set; }
        public int? ManagerId {get; set;}

        public int? Parent { get; set; }

        public int RoleDescriptionId { get; set; }
    }
}