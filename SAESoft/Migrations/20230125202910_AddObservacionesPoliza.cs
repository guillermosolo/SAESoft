using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AddObservacionesPoliza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Polizas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 14, 29, 9, 952, DateTimeKind.Local).AddTicks(5433), "H3wKT/axusWFRNMMg3Bjnj54BjLdZFSkhZtt8iFdDGaWkvE36y9Ooth17GRtb3T0YM/XJNjaAVlYNxFJ/aKhfS0UKRWhL9k0FvEMW6sZ" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Polizas");

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 10, 1, 33, 520, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 10, 1, 33, 519, DateTimeKind.Local).AddTicks(6104), "qyJddJNGl+lZDqMPbMX0RNdrWHXJQIvvzCRoPgB59Q/lD+xxKeUh9eDBqg+Qc6rQF3aWBW7LOnZkEVlTq8kaJdaIGHWNciNRWdo9q7fKQA==" });
        }
    }
}
