using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AddHistorialImportacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportHistorial",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdImport = table.Column<int>(type: "int", nullable: false),
                    IdImportStatus = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportHistorial", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_ImportHistorial_ImportStatus_IdImportStatus",
                        column: x => x.IdImportStatus,
                        principalTable: "ImportStatus",
                        principalColumn: "IdImportStatus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImportHistorial_Importaciones_IdImport",
                        column: x => x.IdImport,
                        principalTable: "Importaciones",
                        principalColumn: "IdImport",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 211, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 17, 16, 58, 57, 213, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 1, 17, 16, 58, 57, 212, DateTimeKind.Local).AddTicks(302), "o2hcc4/eUDQFsJqw5leZaCup9I/b6qlu9POX+DuZGzVOCACAXmU5cDX5s/Ou5apGGZOqh9HKlJQdzUVAzoeZ7oT0p+zz" });

            migrationBuilder.CreateIndex(
                name: "IX_ImportHistorial_IdImport",
                table: "ImportHistorial",
                column: "IdImport");

            migrationBuilder.CreateIndex(
                name: "IX_ImportHistorial_IdImportStatus",
                table: "ImportHistorial",
                column: "IdImportStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportHistorial");

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 1, 16, 13, 31, 30, 70, DateTimeKind.Local).AddTicks(2897), "lB9KWtprLXoh6a8yqzSEMD5iKY48UltZP/o3oLHgNvcZWTsATSB7+/7IzQicfFkO4omzpIKOuRFLlan/XCovpWNBlXZe" });
        }
    }
}
