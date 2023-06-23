using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregarAñosResidenciaPersonas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AñosResidencia",
                table: "Familiares",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AñosResidencia",
                table: "Empleados",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AñosResidencia",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "AñosResidencia",
                table: "Empleados");
        }
    }
}
