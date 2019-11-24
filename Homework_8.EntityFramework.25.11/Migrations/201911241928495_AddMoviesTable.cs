namespace Homework_8.EntityFramework._25._11.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMoviesTable : DbMigration
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
            AddColumn("dbo.Movies", "Id", c => c.Int());
            AddColumn("dbo.Movies", "Name", c => c.String());
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "Year", c => c.Int());

            CreateIndex("dbo.Movies", "Id");
            CreateIndex("dbo.Movies", "Name");
            CreateIndex("dbo.Movies", "Genre");
            CreateIndex("dbo.Movies", "Year");

            AddForeignKey("dbo.Characters", "Id", "dbo.Movies", "Id");
        }


        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
