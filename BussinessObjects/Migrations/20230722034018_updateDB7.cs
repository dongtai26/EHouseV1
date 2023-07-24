using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class updateDB7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantWebLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantIpnUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantReturnUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecretKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDestinations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesSortIndex = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDestinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentRefId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredAmoun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentDestinationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentLastMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Merchants_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentDestinations_PaymentDestinationId",
                        column: x => x.PaymentDestinationId,
                        principalTable: "PaymentDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentNotifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentRefId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MerchantId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiResDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentNotifications_Payments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSignatures",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SignValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignAlgo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignOwn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSignatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSignatures_Payments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransactions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TranMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranPayload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_Payments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDestinations_ParentId",
                table: "PaymentDestinations",
                column: "ParentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentNotifications_ParentId",
                table: "PaymentNotifications",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MerchantId",
                table: "Payments",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentDestinationId",
                table: "Payments",
                column: "PaymentDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSignatures_ParentId",
                table: "PaymentSignatures",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_ParentId",
                table: "PaymentTransactions",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDestinations_Payments_ParentId",
                table: "PaymentDestinations",
                column: "ParentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDestinations_Payments_ParentId",
                table: "PaymentDestinations");

            migrationBuilder.DropTable(
                name: "PaymentNotifications");

            migrationBuilder.DropTable(
                name: "PaymentSignatures");

            migrationBuilder.DropTable(
                name: "PaymentTransactions");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "PaymentDestinations");
        }
    }
}
