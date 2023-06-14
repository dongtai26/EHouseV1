using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussinessObjects.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ConId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractCreatedDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractApproveDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    LessorId = table.Column<int>(type: "int", nullable: false),
                    LesseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ConId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenIdentification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UId);
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
                name: "UserRoles",
                columns: table => new
                {
                    UId = table.Column<int>(type: "int", nullable: false),
                    RId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RId",
                        column: x => x.RId,
                        principalTable: "Roles",
                        principalColumn: "RId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
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

            migrationBuilder.CreateTable(
                name: "HouseRents",
                columns: table => new
                {
                    Hoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<float>(type: "real", nullable: false),
                    AirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    WaterHeater = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false),
                    WashingMachine = table.Column<bool>(type: "bit", nullable: false),
                    Bed = table.Column<bool>(type: "bit", nullable: false),
                    Parking = table.Column<bool>(type: "bit", nullable: false),
                    Refrigerator = table.Column<bool>(type: "bit", nullable: false),
                    Restroom = table.Column<bool>(type: "bit", nullable: false),
                    ElectricityPrice = table.Column<float>(type: "real", nullable: false),
                    WaterPrice = table.Column<float>(type: "real", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentPrice = table.Column<float>(type: "real", nullable: false),
                    HouseStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseRents", x => x.Hoid);
                    table.ForeignKey(
                        name: "FK_HouseRents_Posts_PId",
                        column: x => x.PId,
                        principalTable: "Posts",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    IId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.IId);
                    table.ForeignKey(
                        name: "FK_Images_Posts_PId",
                        column: x => x.PId,
                        principalTable: "Posts",
                        principalColumn: "PId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PId",
                table: "Comments",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UId",
                table: "Comments",
                column: "UId");

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
                name: "IX_HouseRents_PId",
                table: "HouseRents",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PId",
                table: "Images",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PId",
                table: "Notifications",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UId",
                table: "Notifications",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UId",
                table: "Posts",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RId",
                table: "UserRoles",
                column: "RId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UId",
                table: "UserRoles",
                column: "UId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "HouseRents");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
