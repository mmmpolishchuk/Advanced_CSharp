using Microsoft.EntityFrameworkCore.Migrations;

namespace ITEA_Management.Migrations
{
    public partial class _Added_Attributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date of entry",
                table: "Students",
                newName: "StartDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Students",
                newName: "Date of entry");
        }
    }
}
