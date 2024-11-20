using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaControlFacturasExport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacturasLocal",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NoFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoFactura = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: true),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAnulacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotaCredito = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasLocal", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_FacturasLocal_Nombres_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre");
                    table.ForeignKey(
                        name: "FK_FacturasLocal_Nombres_IdTipoFactura",
                        column: x => x.IdTipoFactura,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Licencias",
                columns: table => new
                {
                    IdLicencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumLicencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencias", x => x.IdLicencia);
                });

            migrationBuilder.CreateTable(
                name: "ComentFacsExport",
                columns: table => new
                {
                    IdComment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLicencia = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentFacsExport", x => x.IdComment);
                    table.ForeignKey(
                        name: "FK_ComentFacsExport_Licencias_IdLicencia",
                        column: x => x.IdLicencia,
                        principalTable: "Licencias",
                        principalColumn: "IdLicencia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Descargos",
                columns: table => new
                {
                    IdDescargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumDescargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLicencia = table.Column<int>(type: "int", nullable: false),
                    final = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descargos", x => x.IdDescargo);
                    table.ForeignKey(
                        name: "FK_Descargos_Licencias_IdLicencia",
                        column: x => x.IdLicencia,
                        principalTable: "Licencias",
                        principalColumn: "IdLicencia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ducas",
                columns: table => new
                {
                    IdDuca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumDuca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoDuca = table.Column<int>(type: "int", nullable: false),
                    IdLicencia = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDucaRef = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ducas", x => x.IdDuca);
                    table.ForeignKey(
                        name: "FK_Ducas_Licencias_IdLicencia",
                        column: x => x.IdLicencia,
                        principalTable: "Licencias",
                        principalColumn: "IdLicencia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ducas_Nombres_IdTipoDuca",
                        column: x => x.IdTipoDuca,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacturasExport",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NoFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoFactura = table.Column<int>(type: "int", nullable: false),
                    IdConsignatario = table.Column<int>(type: "int", nullable: false),
                    IdAduana = table.Column<int>(type: "int", nullable: true),
                    IdModalidad = table.Column<int>(type: "int", nullable: true),
                    IdExportador = table.Column<int>(type: "int", nullable: true),
                    IdLicencia = table.Column<int>(type: "int", nullable: true),
                    FechaAnulacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotaCredito = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasExport", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_FacturasExport_Aduanas_IdAduana",
                        column: x => x.IdAduana,
                        principalTable: "Aduanas",
                        principalColumn: "IdAduana");
                    table.ForeignKey(
                        name: "FK_FacturasExport_Licencias_IdLicencia",
                        column: x => x.IdLicencia,
                        principalTable: "Licencias",
                        principalColumn: "IdLicencia");
                    table.ForeignKey(
                        name: "FK_FacturasExport_Nombres_IdConsignatario",
                        column: x => x.IdConsignatario,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacturasExport_Nombres_IdExportador",
                        column: x => x.IdExportador,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre");
                    table.ForeignKey(
                        name: "FK_FacturasExport_Nombres_IdModalidad",
                        column: x => x.IdModalidad,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre");
                    table.ForeignKey(
                        name: "FK_FacturasExport_Nombres_IdTipoFactura",
                        column: x => x.IdTipoFactura,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
              name: "IX_ComentFacsExport_IdLicencia",
              table: "ComentFacsExport",
              column: "IdLicencia");

            migrationBuilder.CreateIndex(
                name: "IX_Descargos_IdLicencia",
                table: "Descargos",
                column: "IdLicencia");

            migrationBuilder.CreateIndex(
                name: "IX_Ducas_IdLicencia",
                table: "Ducas",
                column: "IdLicencia");

            migrationBuilder.CreateIndex(
                name: "IX_Ducas_IdTipoDuca",
                table: "Ducas",
                column: "IdTipoDuca");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasExport_IdAduana",
                table: "FacturasExport",
                column: "IdAduana");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasExport_IdConsignatario",
                table: "FacturasExport",
                column: "IdConsignatario");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasExport_IdExportador",
                table: "FacturasExport",
                column: "IdExportador");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasExport_IdLicencia",
                table: "FacturasExport",
                column: "IdLicencia");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasExport_IdModalidad",
                table: "FacturasExport",
                column: "IdModalidad");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasExport_IdTipoFactura",
                table: "FacturasExport",
                column: "IdTipoFactura");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasLocal_IdEmpresa",
                table: "FacturasLocal",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasLocal_IdTipoFactura",
                table: "FacturasLocal",
                column: "IdTipoFactura");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentFacsExport");

            migrationBuilder.DropTable(
                name: "Descargos");

            migrationBuilder.DropTable(
                name: "Ducas");

            migrationBuilder.DropTable(
                name: "FacturasExport");

            migrationBuilder.DropTable(
                name: "FacturasLocal");

            migrationBuilder.DropTable(
                name: "Licencias");
        }
    }
}
