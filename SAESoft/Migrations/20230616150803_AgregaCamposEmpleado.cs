using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaCamposEmpleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Empleados",
                type: "char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "Empleados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdPuesto",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdPuesto",
                table: "Empleados",
                column: "IdPuesto");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Nombres_IdPuesto",
                table: "Empleados",
                column: "IdPuesto",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Nombres_IdPuesto",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdPuesto",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaBaja",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdPuesto",
                table: "Empleados");
        }
    }
}
