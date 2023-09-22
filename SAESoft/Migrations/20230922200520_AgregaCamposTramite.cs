using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaCamposTramite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_Nombres_IdTipo",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Tramites");

            migrationBuilder.AddColumn<DateTime>(
                name: "Cita",
                table: "Tramites",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInteresado",
                table: "Tramites",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroSolicitud",
                table: "Tramites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "mostrar",
                table: "TiposDocumento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "HistorialTramites",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTramite = table.Column<int>(type: "int", nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialTramites", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_HistorialTramites_AdminStatuses_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "AdminStatuses",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistorialTramites_Tramites_IdTramite",
                        column: x => x.IdTramite,
                        principalTable: "Tramites",
                        principalColumn: "IdTramite",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tramites_IdInteresado",
                table: "Tramites",
                column: "IdInteresado");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialTramites_IdStatus",
                table: "HistorialTramites",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialTramites_IdTramite",
                table: "HistorialTramites",
                column: "IdTramite");

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_Familiares_IdInteresado",
                table: "Tramites",
                column: "IdInteresado",
                principalTable: "Familiares",
                principalColumn: "IdFamiliar");

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_TiposDocumento_IdTipo",
                table: "Tramites",
                column: "IdTipo",
                principalTable: "TiposDocumento",
                principalColumn: "IdTipoDocumento",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_Familiares_IdInteresado",
                table: "Tramites");

            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_TiposDocumento_IdTipo",
                table: "Tramites");

            migrationBuilder.DropTable(
                name: "HistorialTramites");

            migrationBuilder.DropIndex(
                name: "IX_Tramites_IdInteresado",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "Cita",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "IdInteresado",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "NumeroSolicitud",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "mostrar",
                table: "TiposDocumento");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Tramites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_Nombres_IdTipo",
                table: "Tramites",
                column: "IdTipo",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
