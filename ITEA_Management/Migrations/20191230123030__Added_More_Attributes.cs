using Microsoft.EntityFrameworkCore.Migrations;

namespace ITEA_Management.Migrations
{
    public partial class _Added_More_Attributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Offices_OfficeId1",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_OfficeId1",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "OfficeId1",
                table: "Teachers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfficeId1",
                table: "Teachers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_OfficeId1",
                table: "Teachers",
                column: "OfficeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Offices_OfficeId1",
                table: "Teachers",
                column: "OfficeId1",
                principalTable: "Offices",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
