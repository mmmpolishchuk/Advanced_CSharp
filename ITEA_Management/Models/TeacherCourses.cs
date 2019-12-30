using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Models
{
    public class TeacherCourses
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
