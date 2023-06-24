using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class DBV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "HouseRents");

            migrationBuilder.AddColumn<int>(
                name: "LId",
                table: "HouseRents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseRents_LId",
                table: "HouseRents",
                column: "LId");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseRents_Location_LId",
                table: "HouseRents",
                column: "LId",
                principalTable: "Location",
                principalColumn: "LId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseRents_Location_LId",
                table: "HouseRents");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_HouseRents_LId",
                table: "HouseRents");

            migrationBuilder.DropColumn(
                name: "LId",
                table: "HouseRents");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "HouseRents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
