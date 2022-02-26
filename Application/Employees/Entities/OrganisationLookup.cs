using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Application.Employees.Entities
{
    public class OrganisationLookup
    {
        public EmployeesLookup Manager { get; set; }

        public List<EmployeesLookup> Children {get; set;}
    }
}