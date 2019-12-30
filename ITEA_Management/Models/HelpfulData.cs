using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Models
{
    public class HelpfulData
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}