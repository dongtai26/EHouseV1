using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class updateDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PostStatus",
                table: "Posts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AdId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AdId",
                table: "Posts",
                column: "AdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Admins_AdId",
                table: "Posts",
                column: "AdId",
                principalTable: "Admins",
                principalColumn: "AdId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Admins_AdId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AdId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AdId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "PostStatus",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
