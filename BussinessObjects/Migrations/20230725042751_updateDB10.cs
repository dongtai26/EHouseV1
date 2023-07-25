using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class updateDB10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseAddresses");

            migrationBuilder.DropTable(
                name: "Locations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LId);
                });

            migrationBuilder.CreateTable(
                name: "HouseAddresses",
                columns: table => new
                {
                    HouseAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_Id = table.Column<int>(type: "int", nullable: false),
                    Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseAddresses", x => x.HouseAddressId);
                    table.ForeignKey(
                        name: "FK_HouseAddresses_HouseRents_House_Id",
                        column: x => x.House_Id,
                        principalTable: "HouseRents",
                        principalColumn: "HoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HouseAddresses_Locations_Location_Id",
                        column: x => x.Location_Id,
                        principalTable: "Locations",
                        principalColumn: "LId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseAddresses_House_Id",
                table: "HouseAddresses",
                column: "House_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HouseAddresses_Location_Id",
                table: "HouseAddresses",
                column: "Location_Id");
        }
    }
}
