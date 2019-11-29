using System.Data.Entity;

namespace Homework_10.LINQ_to_SQL._27._11.Director_Manipulating
{
    class Director_Context
    {
        public DbSet<Directors> Directors { get; set; }
    }
}
