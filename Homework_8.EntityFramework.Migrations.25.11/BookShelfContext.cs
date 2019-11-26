using System.Data.Entity;
using EntityFrameworkLesson.Models;

namespace Homework_8.EntityFramework.Migrations._25._11
{
    public class BookShelfContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }

    }
}
