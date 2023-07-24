using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class UpdateDB5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CId",
                table: "Notifications",
                column: "CId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Comments_CId",
                table: "Notifications",
                column: "CId",
                principalTable: "Comments",
                principalColumn: "CId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Comments_CId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_CId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "Notifications");
        }
    }
}
