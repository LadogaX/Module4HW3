using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    public class EmployeeProjectEntity
    {
        public int EmployeeProjectId { get; set; }
        public double Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeId { get; set; }

        public ProjectEntity Project { get; set; }
        public int ProjectId { get; set; }
    }
}
