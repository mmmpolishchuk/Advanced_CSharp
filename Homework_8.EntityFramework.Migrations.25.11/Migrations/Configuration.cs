namespace Homework_8.EntityFramework.Migrations._25._11.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Homework_8.EntityFramework.Migrations._25._11.BookShelfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Homework_8.EntityFramework.Migrations._25._11.BookShelfContext";
        }

        protected override void Seed(Homework_8.EntityFramework.Migrations._25._11.BookShelfContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
