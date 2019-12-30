using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [StringLength(60, MinimumLength = 4), Required]
        public string Title { get; set; }

        public int Hours { get; set; }

        public int Lessons { get; set; }

        public decimal Price { get; set; }

        public ICollection<Student> CurrentStudents { get; set; }
        public ICollection<TeacherCourses> TeacherCourses { get; set; }
    }
}
