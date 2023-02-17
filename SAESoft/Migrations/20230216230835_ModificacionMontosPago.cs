using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionMontosPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoAlmacenaje",
                table: "Importaciones");

            migrationBuilder.DropColumn(
                name: "MontoDemora",
                table: "Importaciones");

            migrationBuilder.AddColumn<int>(
                name: "IdPago",
                table: "Contenedores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdContenedor = table.Column<int>(type: "int", nullable: false),
                    MontoAlmacenaje = table.Column<decimal>(type: "money", nullable: false),
                    MontoDemora = table.Column<decimal>(type: "money", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_Contenedores_IdContenedor",
                        column: x => x.IdContenedor,
                        principalTable: "Contenedores",
                        principalColumn: "IdContenedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 172,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 251,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 264,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 272,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 282,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 296,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 312,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 322,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 340,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 346,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 349,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 372,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 375,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 379,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 8, 34, 507, DateTimeKind.Local).AddTicks(3735), "7ZoHt6QH/+GriN3OAvgkUdPfzVCUSVQW1+JY3EXKflcZyr+9G4W5paEG8PKGto+GHH2znyo//ZvtRpXMjqG5uex8mTVht8zs5nHU" });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdContenedor",
                table: "Pagos",
                column: "IdContenedor",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropColumn(
                name: "IdPago",
                table: "Contenedores");

            migrationBuilder.AddColumn<decimal>(
                name: "MontoAlmacenaje",
                table: "Importaciones",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoDemora",
                table: "Importaciones",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 172,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 251,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 264,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 272,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 282,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 296,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 312,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 322,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 340,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 346,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 349,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 372,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 375,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Agentes",
                keyColumn: "IdAgente",
                keyValue: 379,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 2, 10, 14, 49, 45, 329, DateTimeKind.Local).AddTicks(7729), "EAbqOYIInvU8qmiV/8zy1sXzxGuYW2OnuSu19HPygezJBbm1y2OFDt8IDhcVT16Fre6iiVPJQakdAFhqtF43kjcT+4q1bg2u" });
        }
    }
}
