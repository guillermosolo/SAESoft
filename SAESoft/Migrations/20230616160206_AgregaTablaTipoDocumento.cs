using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablaTipoDocumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Nombres_IdTipo",
                table: "Documentos");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "DepartamentosInternos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimaMod",
                table: "DepartamentosInternos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuarioCreacion",
                table: "DepartamentosInternos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuarioMod",
                table: "DepartamentosInternos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TiposDocumento",
                columns: table => new
                {
                    IdTipoDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumento", x => x.IdTipoDocumento);
                });

            

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_TiposDocumento_IdTipo",
                table: "Documentos",
                column: "IdTipo",
                principalTable: "TiposDocumento",
                principalColumn: "IdTipoDocumento",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_TiposDocumento_IdTipo",
                table: "Documentos");

            migrationBuilder.DropTable(
                name: "TiposDocumento");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "DepartamentosInternos");

            migrationBuilder.DropColumn(
                name: "FechaUltimaMod",
                table: "DepartamentosInternos");

            migrationBuilder.DropColumn(
                name: "IdUsuarioCreacion",
                table: "DepartamentosInternos");

            migrationBuilder.DropColumn(
                name: "IdUsuarioMod",
                table: "DepartamentosInternos");

           

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Nombres_IdTipo",
                table: "Documentos",
                column: "IdTipo",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
