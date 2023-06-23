using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregarSeguroMedico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSeguroMedico",
                table: "Familiares",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSeguroMedico",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SegurosMedicos",
                columns: table => new
                {
                    IdMedico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certificado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carnet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegurosMedicos", x => x.IdMedico);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdSeguroMedico",
                table: "Familiares",
                column: "IdSeguroMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroMedico",
                table: "Empleados",
                column: "IdSeguroMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_SegurosMedicos_IdSeguroMedico",
                table: "Empleados",
                column: "IdSeguroMedico",
                principalTable: "SegurosMedicos",
                principalColumn: "IdMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_SegurosMedicos_IdSeguroMedico",
                table: "Familiares",
                column: "IdSeguroMedico",
                principalTable: "SegurosMedicos",
                principalColumn: "IdMedico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_SegurosMedicos_IdSeguroMedico",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_SegurosMedicos_IdSeguroMedico",
                table: "Familiares");

            migrationBuilder.DropTable(
                name: "SegurosMedicos");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdSeguroMedico",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroMedico",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdSeguroMedico",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "IdSeguroMedico",
                table: "Empleados");
        }
    }
}
