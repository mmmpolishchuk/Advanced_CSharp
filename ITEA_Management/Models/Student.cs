using System;using System.Collections.Generic;using System.ComponentModel.DataAnnotations;using System.ComponentModel.DataAnnotations.Schema;using System.Linq;using System.Threading.Tasks;namespace ITEA_Management.Models{    public class Student    {        public int Id { get; set; }        [StringLength(30, MinimumLength = 2), Display(Name = "Name"), Required]        public string FirstName { get; set; }        [StringLength(30, MinimumLength = 2), Display(Name = "Surname"), Required]        public string LastName { get; set; }

        [DataType(DataType.Date), Display(Name = "Date of entry")]        public DateTime StartDate { get; set; }        public int Mark { get; set; }

        [Display(Name = "Current ID of course")]

        [ForeignKey("Course")]
        public int CurrentCourseId { get; set; }        public Course CurrentCourse { get; set; }

    }}