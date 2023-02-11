using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregarAgentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAgente",
                table: "Importaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agentes",
                columns: table => new
                {
                    IdAgente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes", x => x.IdAgente);
                });

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

            migrationBuilder.InsertData(
                table: "Agentes",
                columns: new[] { "IdAgente", "Activo", "Apellidos", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres" },
                values: new object[,]
                {
                    { 172, true, "FERNANDEZ RENTERIA", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3276), null, 1, null, "CESAR" },
                    { 251, true, "TOLEDO CANCINO", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3280), null, 1, null, "MARCO AURELIO" },
                    { 264, true, "ARDÓN ALARCÓN", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3283), null, 1, null, "DANIEL ABILIO" },
                    { 272, true, "PAZ MORÁN", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3282), null, 1, null, "JORGE LUIS" },
                    { 282, true, "JUAREZ ORTIZ", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3285), null, 1, null, "JORGE LUIS" },
                    { 296, true, "VILLEDA AGUILAR", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3288), null, 1, null, "WALTER VINICIO" },
                    { 312, true, "VIELMANN GIRON", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3289), null, 1, null, "OSCAR ALFONSO" },
                    { 322, true, "VELASQUEZ VISQUERRA", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3291), null, 1, null, "SERGIO RODOLFO" },
                    { 340, true, "DUARTE", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3293), null, 1, null, "YADIRA" },
                    { 346, true, "VIELMANN ALDANA", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3295), null, 1, null, "JOANNA NAYARITH" },
                    { 349, true, "MARROQUIN VELIZ", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3297), null, 1, null, "ELVIA LETICIA" },
                    { 372, true, "DEL ÁGUILA CHIGUICHON", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3299), null, 1, null, "ELMER ARNOLDO" },
                    { 375, true, "DERAS ORTEGA", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3300), null, 1, null, "RODRIGO" },
                    { 379, true, "MATA CABRERA", new DateTime(2023, 2, 10, 14, 49, 45, 330, DateTimeKind.Local).AddTicks(3302), null, 1, null, "ALEJANDRA ISABEL" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdAgente",
                table: "Importaciones",
                column: "IdAgente");

            migrationBuilder.AddForeignKey(
                name: "FK_Importaciones_Agentes_IdAgente",
                table: "Importaciones",
                column: "IdAgente",
                principalTable: "Agentes",
                principalColumn: "IdAgente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Importaciones_Agentes_IdAgente",
                table: "Importaciones");

            migrationBuilder.DropTable(
                name: "Agentes");

            migrationBuilder.DropIndex(
                name: "IX_Importaciones_IdAgente",
                table: "Importaciones");

            migrationBuilder.DropColumn(
                name: "IdAgente",
                table: "Importaciones");

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Aduanas",
                keyColumn: "IdAduana",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "IdGrupo",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ImportStatus",
                keyColumn: "IdImportStatus",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Modulos",
                keyColumn: "IdModulo",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Nombres",
                keyColumn: "IdNombre",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "IdPermiso",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Revisiones",
                keyColumn: "IdRevision",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 41,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 42,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 43,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 44,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 45,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 46,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 47,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 48,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 49,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 50,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 51,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 52,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 53,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 54,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 55,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 56,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 57,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 58,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 59,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 60,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 61,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 62,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 63,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 64,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 65,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 66,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 67,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 68,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 69,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 70,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 72,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 73,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 74,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 80,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 81,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 82,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 83,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 84,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 85,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 86,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 87,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 88,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 89,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 90,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 91,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 92,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 93,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 94,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 95,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 96,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 97,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 98,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 99,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 101,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 102,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 104,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 105,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 106,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 107,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 108,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 109,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 110,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 111,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 112,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 113,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 114,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 115,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 116,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 117,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 118,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 119,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 120,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 121,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "IdShipper",
                keyValue: 122,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Terminales",
                keyColumn: "IdTerminal",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2023, 2, 10, 8, 29, 52, 84, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 29, 52, 83, DateTimeKind.Local).AddTicks(9532), "ovyc7bfLpMNgJp1S1FbhumCbcpq7ogdt+KPcM9vtMKAGqsZuvIAyy/7wjxF/NcTH5zxPrerfZII8AFAHVrynhPZ5OjumCpoGe6KcZw==" });
        }
    }
}
