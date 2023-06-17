using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablaSeguroVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSeguroVehiculo",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SegurosVehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAseguradora = table.Column<int>(type: "int", nullable: false),
                    poliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deducible = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegurosVehiculos", x => x.IdVehiculo);
                    table.ForeignKey(
                        name: "FK_SegurosVehiculos_Nombres_IdAseguradora",
                        column: x => x.IdAseguradora,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados",
                column: "IdSeguroVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_SegurosVehiculos_IdAseguradora",
                table: "SegurosVehiculos",
                column: "IdAseguradora");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_SegurosVehiculos_IdSeguroVehiculo",
                table: "Empleados",
                column: "IdSeguroVehiculo",
                principalTable: "SegurosVehiculos",
                principalColumn: "IdVehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_SegurosVehiculos_IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "SegurosVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdSeguroVehiculo",
                table: "Empleados");
        }
    }
}
