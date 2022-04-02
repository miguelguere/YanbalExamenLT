




using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Data.Migrations
{
    public partial class ps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Clientes",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 1, 12, 58, 763, DateTimeKind.Utc).AddTicks(5155),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2022, 4, 1, 20, 8, 16, 267, DateTimeKind.Local).AddTicks(412));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Clientes",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 1, 20, 8, 16, 267, DateTimeKind.Local).AddTicks(412),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2022, 4, 2, 1, 12, 58, 763, DateTimeKind.Utc).AddTicks(5155));
        }
    }
}
