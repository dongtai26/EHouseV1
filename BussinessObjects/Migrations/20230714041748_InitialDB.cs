using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
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
                    table.PrimaryKey("PK_Locations", x => x.LId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RId = table.Column<int>(type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenIdentification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RId",
                        column: x => x.RId,
                        principalTable: "Roles",
                        principalColumn: "RId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdId);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessees",
                columns: table => new
                {
                    LesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessees", x => x.LesId);
                    table.ForeignKey(
                        name: "FK_Lessees_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessors",
                columns: table => new
                {
                    LeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessors", x => x.LeId);
                    table.ForeignKey(
                        name: "FK_Lessors_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCreatedDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PId);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    TId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jwt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.TId);
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HouseRents",
                columns: table => new
                {
                    HoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseRentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<float>(type: "real", nullable: false),
                    AirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    WaterHeater = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false),
                    WashingMachine = table.Column<bool>(type: "bit", nullable: false),
                    Bed = table.Column<int>(type: "int", nullable: false),
                    Parking = table.Column<bool>(type: "bit", nullable: false),
                    Refrigerator = table.Column<bool>(type: "bit", nullable: false),
                    Restroom = table.Column<int>(type: "int", nullable: false),
                    Kitchen = table.Column<bool>(type: "bit", nullable: false),
                    ElectricityPrice = table.Column<float>(type: "real", nullable: false),
                    WaterPrice = table.Column<float>(type: "real", nullable: false),
                    RentPrice = table.Column<float>(type: "real", nullable: false),
                    HouseStatus = table.Column<bool>(type: "bit", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseRents", x => x.HoId);
                    table.ForeignKey(
                        name: "FK_HouseRents_Lessors_LeId",
                        column: x => x.LeId,
                        principalTable: "Lessors",
                        principalColumn: "LeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CId);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PId",
                        column: x => x.PId,
                        principalTable: "Posts",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NoId);
                    table.ForeignKey(
                        name: "FK_Notifications_Posts_PId",
                        column: x => x.PId,
                        principalTable: "Posts",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    PIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostImageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostImageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.PIId);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_PId",
                        column: x => x.PId,
                        principalTable: "Posts",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ConId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractCreatedDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractApproveDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoId = table.Column<int>(type: "int", nullable: false),
                    AdId = table.Column<int>(type: "int", nullable: true),
                    LeId = table.Column<int>(type: "int", nullable: true),
                    LesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ConId);
                    table.ForeignKey(
                        name: "FK_Contracts_Admins_AdId",
                        column: x => x.AdId,
                        principalTable: "Admins",
                        principalColumn: "AdId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_HouseRents_HoId",
                        column: x => x.HoId,
                        principalTable: "HouseRents",
                        principalColumn: "HoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Lessees_LesId",
                        column: x => x.LesId,
                        principalTable: "Lessees",
                        principalColumn: "LesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Lessors_LeId",
                        column: x => x.LeId,
                        principalTable: "Lessors",
                        principalColumn: "LeId",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "HouseImages",
                columns: table => new
                {
                    PIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseImageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseImages", x => x.PIId);
                    table.ForeignKey(
                        name: "FK_HouseImages_HouseRents_HoId",
                        column: x => x.HoId,
                        principalTable: "HouseRents",
                        principalColumn: "HoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Hid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConId = table.Column<int>(type: "int", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Hid);
                    table.ForeignKey(
                        name: "FK_Histories_Contracts_ConId",
                        column: x => x.ConId,
                        principalTable: "Contracts",
                        principalColumn: "ConId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Histories_Posts_PId",
                        column: x => x.PId,
                        principalTable: "Posts",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Histories_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UId",
                table: "Admins",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PId",
                table: "Comments",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UId",
                table: "Comments",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_AdId",
                table: "Contracts",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_HoId",
                table: "Contracts",
                column: "HoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_LeId",
                table: "Contracts",
                column: "LeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_LesId",
                table: "Contracts",
                column: "LesId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_ConId",
                table: "Histories",
                column: "ConId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_PId",
                table: "Histories",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UId",
                table: "Histories",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseAddresses_House_Id",
                table: "HouseAddresses",
                column: "House_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HouseAddresses_Location_Id",
                table: "HouseAddresses",
                column: "Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HouseImages_HoId",
                table: "HouseImages",
                column: "HoId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseRents_LeId",
                table: "HouseRents",
                column: "LeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessees_UId",
                table: "Lessees",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessors_UId",
                table: "Lessors",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PId",
                table: "Notifications",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UId",
                table: "Notifications",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PId",
                table: "PostImages",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UId",
                table: "Posts",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RId",
                table: "Users",
                column: "RId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UId",
                table: "UserTokens",
                column: "UId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "HouseAddresses");

            migrationBuilder.DropTable(
                name: "HouseImages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "HouseRents");

            migrationBuilder.DropTable(
                name: "Lessees");

            migrationBuilder.DropTable(
                name: "Lessors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
