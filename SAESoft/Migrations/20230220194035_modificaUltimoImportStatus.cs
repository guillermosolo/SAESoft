using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class modificaUltimoImportStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ultimo",
                table: "ImportStatus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 172,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 251,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 264,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 272,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 282,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 296,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 312,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 322,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 340,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 346,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 349,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 372,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 375,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 379,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9800), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9803), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9804), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9806), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9807), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9810), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9811), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9813), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9814), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9818), true });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9819), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9821), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9822), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9824), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9825), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9827), true });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9828), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9831), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9832), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9834), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9835), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9837), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9838), true });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9840), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9841), false });

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 26,
                columns: new[] { "FechaCreacion", "ultimo" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9843), false });

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 40, 34, 343, DateTimeKind.Local).AddTicks(4422), "Z9oP5H4kmryZIPnOxdDtB7Ry2+hOR6+iGNhJg2vFSU1WJR5gRbS0vTSg+eWVnb6n/kSiQgPktXpRd++PTAib76q9hD3lWA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ultimo",
                table: "ImportStatus");

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 172,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 251,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 264,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 272,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 282,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 296,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 312,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 322,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 340,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 346,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 349,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 372,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 375,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 379,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 20, 10, 20, 55, 379, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 20, 55, 378, DateTimeKind.Local).AddTicks(7587), "7OiAA0FNXwR60cBN00W85ji/4UpU/6Xtl9y+Cd09voxty0kMm5uoWlFwAHpAYTVYO5UUyUjAA7WU4vZhNP3EIY1HS5kt" });
        }
    }
}
