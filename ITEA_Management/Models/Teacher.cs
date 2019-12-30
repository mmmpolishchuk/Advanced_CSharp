using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Display(Name = "Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Surname"), Required, StringLength(20)]
        public string LastName { get; set; }


        [Display(Name = "Office"), Required]
        public int OfficeId { get; set; }
        public Office Office { get; set; }

        [Display(Name = "Course Id")]
        public ICollection<TeacherCourses> TeacherCourses { get; set; }

    }
}
