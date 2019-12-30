using ITEA_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Data
{
    public class ITEA_Context : DbContext
    {
        public ITEA_Context()
        {
            
        }
        public ITEA_Context(DbContextOptions<ITEA_Context> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCourses> TeacherCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
             .HasOne<Course>(s => s.CurrentCourse)
             .WithMany(g => g.CurrentStudents)
             .HasForeignKey(s => s.CurrentCourseId);


            modelBuilder.Entity<TeacherCourses>()
             .HasKey(tc => new { tc.CourseId, tc.TeacherId });


            modelBuilder.Entity<Teacher>(table =>
            {
                table.HasKey(x => x.Id);

                table.Property<int>("OfficeId");            // Adding shadow property

                table.HasOne(x => x.Office)
                     .WithMany(x => x.Teachers)
                     .HasForeignKey("OfficeId")             // Use shadow property
                     .HasPrincipalKey(x => x.OfficeId)      // Pointer to OfficeId
                     .OnDelete(DeleteBehavior.Cascade);
            });

           
        }
    }
}
