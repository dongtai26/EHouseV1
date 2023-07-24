using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    public partial class updateDB9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "PaymentDestinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentDestinations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "PaymentDestinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "PaymentDestinations",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "PaymentDestinations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PaymentDestinations");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "PaymentDestinations");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "PaymentDestinations");
        }
    }
}
