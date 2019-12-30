using ITEA_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ITEA_Context context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            List<Student> students = new List<Student>
            {
                 new Student {FirstName = "Nazarii",    LastName = "Smorzhevskyi", StartDate = DateTime.Parse("2019-10-23"), CurrentCourseId= 8, Mark = 69 },
                 new Student {FirstName = "Mykhailo",   LastName = "Polishchuk",   StartDate = DateTime.Parse("2019-10-23"), CurrentCourseId= 2, Mark = 68 },
                 new Student {FirstName = "Oleh",       LastName = "Kolos",        StartDate = DateTime.Parse("2019-10-23"), CurrentCourseId= 3, Mark = 73 },
                 new Student {FirstName = "Kyrylo",     LastName = "Buryak",       StartDate = DateTime.Parse("2019-01-13"), CurrentCourseId= 3, Mark = 70 },
                 new Student {FirstName = "Mykhailo",   LastName = "Potapenko",    StartDate = DateTime.Parse("2019-10-23"), CurrentCourseId= 6, Mark = 69 },
                 new Student {FirstName = "Mykhailo",   LastName = "Ryndin",       StartDate = DateTime.Parse("2019-07-28"), CurrentCourseId= 5, Mark = 65 },
                 new Student {FirstName = "Olena",      LastName = "Kal'chenko",   StartDate = DateTime.Parse("2019-10-23"), CurrentCourseId= 2, Mark = 63 },
                 new Student {FirstName = "Yaroslav",   LastName = "Petrenko",     StartDate = DateTime.Parse("2019-02-19"), CurrentCourseId= 1, Mark = 72 },
                 new Student {FirstName = "Vadim",      LastName = "Onyschuk",     StartDate = DateTime.Parse("2019-08-03"), CurrentCourseId= 1, Mark = 72 },
                 new Student {FirstName = "Sergiy",     LastName = "Suprun",       StartDate = DateTime.Parse("2019-07-28"), CurrentCourseId= 11,Mark = 72 },
                 new Student {FirstName = "Maksym",     LastName = "Gorkun",       StartDate = DateTime.Parse("2019-01-13"), CurrentCourseId= 11,Mark = 72 },
                 new Student {FirstName = "Roman",      LastName = "Bekh",         StartDate = DateTime.Parse("2019-02-19"), CurrentCourseId= 6, Mark = 72 },
                 new Student {FirstName = "Alexandra",  LastName = "Bogata",       StartDate = DateTime.Parse("2019-07-28"), CurrentCourseId= 7, Mark = 72 },
                 new Student {FirstName = "Daria",      LastName = "Mel'nyk",      StartDate = DateTime.Parse("2019-04-03"), CurrentCourseId= 4, Mark = 72 },
                 new Student {FirstName = "Nina",       LastName = "Shevchenko",   StartDate = DateTime.Parse("2019-01-13"), CurrentCourseId= 9, Mark = 72 },
                 new Student {FirstName = "Yurii",      LastName = "Romanyuk",     StartDate = DateTime.Parse("2019-04-03"), CurrentCourseId= 9, Mark = 72 },
                 new Student {FirstName = "Ruslan",     LastName = "Boyko",        StartDate = DateTime.Parse("2019-02-19"), CurrentCourseId= 14,Mark = 72 },
                 new Student {FirstName = "Taras",      LastName = "Kyrylenko",    StartDate = DateTime.Parse("2019-04-03"), CurrentCourseId= 15,Mark = 72 },
                 new Student {FirstName = "Andriy",     LastName = "Koval",        StartDate = DateTime.Parse("2019-08-03"), CurrentCourseId= 8, Mark = 72 },
                 new Student {FirstName = "Tetyana",    LastName = "Fedorenko",    StartDate = DateTime.Parse("2019-01-13"), CurrentCourseId= 7, Mark = 72 }
            };
            students.ForEach(s => context.Students.Add(s));

            var courses = new List<Course>
            {
                 new Course{CourseId = 1,  Title="C++ Base",        Hours = 48, Lessons = 16, Price = 7000m},
                 new Course{CourseId = 2,  Title="C++ Advanced",    Hours = 51, Lessons = 17, Price = 9900m},
                 new Course{CourseId = 3,  Title="C# Base",         Hours = 36, Lessons = 12, Price = 7700m},
                 new Course{CourseId = 4,  Title="C# Advanced",     Hours = 42, Lessons = 13, Price = 9200m},
                 new Course{CourseId = 5,  Title="JS Base",         Hours = 21, Lessons = 7,  Price = 3900m},
                 new Course{CourseId = 6,  Title="JS Professional", Hours = 24, Lessons = 8,  Price = 6700m},
                 new Course{CourseId = 7,  Title="Python Base",     Hours = 30, Lessons = 10, Price = 9900m},
                 new Course{CourseId = 8,  Title="Python Advanced", Hours = 54, Lessons = 18, Price = 110000m},
                 new Course{CourseId = 9,  Title="UX Design",       Hours = 42, Lessons = 13, Price = 9900m},
                 new Course{CourseId = 11, Title="UI Design",       Hours = 48, Lessons = 15, Price = 9900m},
                 new Course{CourseId = 12, Title="Java Base",       Hours = 60, Lessons = 20, Price = 9900m},
                 new Course{CourseId = 13, Title="Java Advanced",   Hours = 42, Lessons = 13, Price = 8800m},
                 new Course{CourseId = 14, Title="HTML & CSS",      Hours = 30, Lessons = 10, Price = 3900m},
                 new Course{CourseId = 15, Title="Frontend Advanced",Hours = 39, Lessons = 13, Price = 7700m},
                 new Course{CourseId = 16, Title="DevOps Base",     Hours = 33, Lessons = 11, Price = 12600m},
                 new Course{CourseId = 17, Title="DevOps Advanced", Hours = 42, Lessons = 13, Price = 13200m}
            };
            courses.ForEach(c => context.Courses.Add(c));

            var oficces = new List<Office>
            {
                 new Office{Location="Poznyaky"},
                 new Office{Location="Beresteysʹka"},
                 new Office{Location="VDNG"},
            };
            oficces.ForEach(o => context.Offices.Add(o));

            var teachers = new List<Teacher>
            {
                 new Teacher{ FirstName="Ruslan",  LastName = "Antoshkin", OfficeId = oficces.Single(c=>c.Location == "Beresteysʹka").OfficeId, Office = new Office{Location=oficces.Where(x=>x.OfficeId == 1).ToString()} },
                 new Teacher{ FirstName="Denys", LastName = "Kovbiy", OfficeId = oficces.Single(c=>c.Location == "Beresteysʹka").OfficeId, Office = new Office{Location=oficces.Where(x=>x.OfficeId == 1).ToString() } },
                 new Teacher{ FirstName="Sergiy", LastName = "Voloshyn", OfficeId = oficces.Single(c=>c.Location == "VDNG").OfficeId},
                 new Teacher{ FirstName="Alexander",  LastName = "Svyrydenko", OfficeId = oficces.Single(c=>c.Location == "Poznyaky").OfficeId},
                 new Teacher{ FirstName="Ludmyla", LastName = "Bulygina", OfficeId = oficces.Single(c=>c.Location == "Beresteysʹka").OfficeId},
                 new Teacher{ FirstName="Denys", LastName = "Prokopiuk", OfficeId = oficces.Single(c=>c.Location == "VDNG").OfficeId},
                 new Teacher{ FirstName="Egor",  LastName = "Markevych", OfficeId = oficces.Single(c=>c.Location == "Beresteysʹka").OfficeId},
                 new Teacher{ FirstName="Alexander", LastName = "Postoyuk", OfficeId = oficces.Single(c=>c.Location == "Poznyaky").OfficeId},
                 new Teacher{ FirstName="Alexander", LastName = "Belyakov", OfficeId = oficces.Single(c=>c.Location == "Beresteysʹka").OfficeId},
                 new Teacher{ FirstName="Andriy", LastName = "Kryvolap", OfficeId = oficces.Single(c=>c.Location == "Beresteysʹka").OfficeId },
                 new Teacher{ FirstName="Lyubov", LastName = "Tymoshenko", OfficeId = oficces.Single(c=>c.Location == "Poznyaky").OfficeId},
                 new Teacher{ FirstName="Andriy", LastName = "Radionov", OfficeId = oficces.Single(c=>c.Location == "VDNG").OfficeId}
            };
            teachers.ForEach(t => context.Teachers.Add(t));

            var teacherCourses = new List<TeacherCourses>
           {
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Antoshkin" ).Id,
                    CourseId = courses.Single(i => i.Title == "C# Advanced").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Kovbiy" ).Id,
                    CourseId = courses.Single(i => i.Title == "Java Advanced").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Radionov" ).Id,
                    CourseId = courses.Single(i => i.Title == "Java Base").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Bulygina" ).Id,
                    CourseId = courses.Single(i => i.Title == "Python Base").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Voloshyn" ).Id,
                    CourseId = courses.Single(i => i.Title == "DevOps Advanced").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Prokopiuk" ).Id,
                    CourseId = courses.Single(i => i.Title == "HTML & CSS").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Markevych" ).Id,
                    CourseId = courses.Single(i => i.Title == "UI Design").CourseId
                    },
                new TeacherCourses {
                    TeacherId = teachers.Single(c => c.LastName == "Postoyuk" ).Id,
                    CourseId = courses.Single(i => i.Title == "C++ Advanced").CourseId
                    },
           };
            teacherCourses.ForEach(tc => context.TeacherCourses.Add(tc));
           
            context.SaveChanges();
        }
    }
}
