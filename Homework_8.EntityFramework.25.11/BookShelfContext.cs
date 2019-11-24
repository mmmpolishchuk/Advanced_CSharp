using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using EntityFrameworkLesson.Models;

namespace Homework_8.EntityFramework._25._11
{
    public class BookShelfContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
