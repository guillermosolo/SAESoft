using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AddMontoMoraImportaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "Importaciones",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Mora",
                table: "Importaciones",
                type: "money",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 1, 26, 7, 58, 17, 427, DateTimeKind.Local).AddTicks(4973), "zV7J4Wbwq51MWMhry3f9Fzl6Rhe9rFgzdMrRGGfjfNJ/JAJGyo5M2wRUKK1+6z1CT2p8kHDonH6a/S2hMm0Hh2GAuPU=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Importaciones");

            migrationBuilder.DropColumn(
                name: "Mora",
                table: "Importaciones");

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 14, 39, 47, 874, DateTimeKind.Local).AddTicks(4613), "lg6uHMI/s0Esil/kNj/fVrUs3TtOxMLMj+hW8g/g0wa4EUkiy/Ojpnm6S6fgbpUlZ3kVumAH6ePH6D3xtu54CfpeJKI9" });
        }
    }
}
