using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablaPermisoTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPermisoTrabajo",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PermisosTrabajo",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    Resolucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosTrabajo", x => x.IdPermiso);
                    table.ForeignKey(
                        name: "FK_PermisosTrabajo_Nombres_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados",
                column: "IdPermisoTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosTrabajo_IdTipo",
                table: "PermisosTrabajo",
                column: "IdTipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_PermisosTrabajo_IdPermisoTrabajo",
                table: "Empleados",
                column: "IdPermisoTrabajo",
                principalTable: "PermisosTrabajo",
                principalColumn: "IdPermiso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_PermisosTrabajo_IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "PermisosTrabajo");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdPermisoTrabajo",
                table: "Empleados");

           
        }
    }
}
