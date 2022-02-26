using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Organisation
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
         public int ReportingLine { get; set; }
        public int RoleDescriptionId {get; set;}
    }
}