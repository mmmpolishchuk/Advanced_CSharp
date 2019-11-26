namespace Homework_8.EntityFramework.Migrations._25._11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMovieEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Genre = c.String(),
                    Year = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
