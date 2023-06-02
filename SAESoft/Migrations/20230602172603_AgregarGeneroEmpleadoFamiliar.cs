using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregarGeneroEmpleadoFamiliar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Nombres_IdDepto",
                table: "Empleados");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Familiares",
                type: "char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Empleados",
                type: "char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DepartamentosInternos",
                columns: table => new
                {
                    IdDepto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentosInternos", x => x.IdDepto);
                    table.ForeignKey(
                        name: "FK_DepartamentosInternos_Nombres_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 172,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 251,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 264,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 272,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 282,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 296,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 312,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 322,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 340,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 346,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 349,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 372,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 375,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 379,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 938, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 938, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 938, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 938, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 123,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 124,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 125,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 126,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(83), "st3OdV2tObjoVz8hUg9BocgODOps0Se98DnN3OXQbWOtz/btMSRLAk2xnQ1on7H/J4QxYxWC9qbZhF335CPJlDQYCzYm9JvhjQdl" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(264), "4J5yK65T3H5r/PXIRmkEz2OEiI2MtoIooa/gKANsaAWERTY3UyVe0/igAJkSnaTR4ZRdk45uLCC5OlMY0bUK9AfoK2S5V3yL/5zL" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(292), "a/ILlvwYfjq6n5L8aWFkjj9qFKSi9h+Uan7YMM1oPJLjo9dDFw8mE/ATcmSHbzHmZsxNh/atzRhwXOGddbT9284ZR+fJassn6sHt" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(310), "z40O/r2dwxumcT20fdW7pLdXlSveIbbBx6bGkm2mB42kQM1SxoRV1tsrWJbV5+Anupho67a22wkIfpl50+juWElVLiIsNoUVcYjWkrk=" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 26, 2, 939, DateTimeKind.Local).AddTicks(326), "1qYlLD16t5fKwPsrRHMF05CUxkXgRx3S8Z0uq/HRSND00y8u28wQ5SY6p4VckdClfTzfB9CYMt90gzEDu/X+MFUQebADw0yz0Mrt10BI" });

            migrationBuilder.CreateIndex(
                name: "IX_DepartamentosInternos_IdEmpresa",
                table: "DepartamentosInternos",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_DepartamentosInternos_IdDepto",
                table: "Empleados",
                column: "IdDepto",
                principalTable: "DepartamentosInternos",
                principalColumn: "IdDepto",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_DepartamentosInternos_IdDepto",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "DepartamentosInternos");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Empleados");

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 172,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 251,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 264,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 272,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 282,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 296,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 312,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 322,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 340,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 346,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 349,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 372,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 375,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 379,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 71,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 75,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 76,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 77,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 78,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 79,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 103,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 123,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 124,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 125,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 126,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 25, 11, 50, 12, 13, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7572), "jl9/Ag/60gwoG46R9pmVsJvZ09lsKP6LJNlsQCWYHDwBmNUnqrQNlL54UDWmq+wEqoJ98Wl7aWQTzM/jNBovGn9ijEN/" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7772), "9DHZb35nUBeKMSmCMde4N4OFWeagc3gKquXcnFcwCNVHGdKeyWRST/BYhzOduJ2ua5TsJi1IxblHMhEM/pLQPeWZcl5nI4medB3VOJw=" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7796), "5lgTj0KzezRchsRMg5WHtvSFAvw/TnHwpNmQX55KFrzuQx30Nbn9d1oEN5B1TcZ9tWqncQbrXWQSocRrgO42gsCM1Y1EA6rtM3bYjiY=" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7818), "3Kbjsy/kJwtyyzebmqLTL6onwUZ7Uz9pbmiV82f757deQGV31GwG74O1j3+bV4ZjldYs9DnFkE5x3FFzd/2Bt0YT6CThjtWt40FylaRw3w==" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 50, 12, 1, DateTimeKind.Local).AddTicks(7834), "oCKcU49pS1VZG3vSTYRllgfWQCTbYVCJe8sDCuzBycgKE1HzPg3tJIC49S5xcrJg4KsO+GImLPgh0vqrMxj8KeFz1i2sbi/Syg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Nombres_IdDepto",
                table: "Empleados",
                column: "IdDepto",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
