using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_HW3.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; }
            = new List<EmployeeProject>();
    }
}
