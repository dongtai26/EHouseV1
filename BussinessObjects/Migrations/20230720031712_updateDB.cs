using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StatusAdminId",
                table: "Contracts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StatusLessorId",
                table: "Contracts",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusAdminId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "StatusLessorId",
                table: "Contracts");
        }
    }
}
