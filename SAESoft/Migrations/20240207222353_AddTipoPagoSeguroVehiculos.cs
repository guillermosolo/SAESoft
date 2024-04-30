using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AddTipoPagoSeguroVehiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Contado",
                table: "SegurosVehiculos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Cuotas",
                table: "SegurosVehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Modelo",
                table: "SegurosVehiculos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contado",
                table: "SegurosVehiculos");

            migrationBuilder.DropColumn(
                name: "Cuotas",
                table: "SegurosVehiculos");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "SegurosVehiculos");
        }
    }
}
