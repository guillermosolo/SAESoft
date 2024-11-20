using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablaNombramiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nombramientos",
                columns: table => new
                {
                    IdNombramiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(type: "int", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    Registro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Folio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Libro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expediente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cancelacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cancelado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nombramientos", x => x.IdNombramiento);
                    table.ForeignKey(
                        name: "FK_Nombramientos_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado");
                    table.ForeignKey(
                        name: "FK_Nombramientos_Nombres_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nombramientos_Nombres_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nombramientos_IdEmpleado",
                table: "Nombramientos",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Nombramientos_IdEmpresa",
                table: "Nombramientos",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Nombramientos_IdTipo",
                table: "Nombramientos",
                column: "IdTipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nombramientos");
        }
    }
}
