using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aduanas",
                columns: table => new
                {
                    IdAduana = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Via = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aduanas", x => x.IdAduana);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    IdModulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Habilitado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.IdModulo);
                });

            migrationBuilder.CreateTable(
                name: "Revisiones",
                columns: table => new
                {
                    IdRevision = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisiones", x => x.IdRevision);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Habilitado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    IdShipper = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Aereo = table.Column<bool>(type: "bit", nullable: false),
                    Maritimo = table.Column<bool>(type: "bit", nullable: false),
                    Terrestre = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.IdShipper);
                });

            migrationBuilder.CreateTable(
                name: "Terminales",
                columns: table => new
                {
                    IdTerminal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Via = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminales", x => x.IdTerminal);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    IdGrupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdModulo = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.IdGrupo);
                    table.ForeignKey(
                        name: "FK_Grupos_Modulos_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulos",
                        principalColumn: "IdModulo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdModulo = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.IdPermiso);
                    table.ForeignKey(
                        name: "FK_Permisos_Modulos_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulos",
                        principalColumn: "IdModulo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nombres",
                columns: table => new
                {
                    IdNombre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdGrupo = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nombres", x => x.IdNombre);
                    table.ForeignKey(
                        name: "FK_Nombres_Grupos_IdGrupo",
                        column: x => x.IdGrupo,
                        principalTable: "Grupos",
                        principalColumn: "IdGrupo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermisoRol",
                columns: table => new
                {
                    PermisosIdPermiso = table.Column<int>(type: "int", nullable: false),
                    RolesIdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisoRol", x => new { x.PermisosIdPermiso, x.RolesIdRol });
                    table.ForeignKey(
                        name: "FK_PermisoRol_Permisos_PermisosIdPermiso",
                        column: x => x.PermisosIdPermiso,
                        principalTable: "Permisos",
                        principalColumn: "IdPermiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermisoRol_Roles_RolesIdRol",
                        column: x => x.RolesIdRol,
                        principalTable: "Roles",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Importaciones",
                columns: table => new
                {
                    IdImport = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShipper = table.Column<int>(type: "int", nullable: false),
                    Via = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IdNaviera = table.Column<int>(type: "int", nullable: false),
                    IdForwarder = table.Column<int>(type: "int", nullable: false),
                    IdDestino = table.Column<int>(type: "int", nullable: false),
                    ETA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdTerminal = table.Column<int>(type: "int", nullable: false),
                    IdAduana = table.Column<int>(type: "int", nullable: false),
                    IdAlmacenadora = table.Column<int>(type: "int", nullable: true),
                    Consolidado = table.Column<bool>(type: "bit", nullable: false),
                    SelectivoRojo = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Importaciones", x => x.IdImport);
                    table.ForeignKey(
                        name: "FK_Importaciones_Aduanas_IdAduana",
                        column: x => x.IdAduana,
                        principalTable: "Aduanas",
                        principalColumn: "IdAduana",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Importaciones_Nombres_IdAlmacenadora",
                        column: x => x.IdAlmacenadora,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre");
                    table.ForeignKey(
                        name: "FK_Importaciones_Nombres_IdDestino",
                        column: x => x.IdDestino,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Importaciones_Nombres_IdForwarder",
                        column: x => x.IdForwarder,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Importaciones_Nombres_IdNaviera",
                        column: x => x.IdNaviera,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Importaciones_Nombres_IdTerminal",
                        column: x => x.IdTerminal,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Importaciones_Shippers_IdShipper",
                        column: x => x.IdShipper,
                        principalTable: "Shippers",
                        principalColumn: "IdShipper",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Importaciones_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "BL",
                columns: table => new
                {
                    IdBL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdImportacion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BL", x => x.IdBL);
                    table.ForeignKey(
                        name: "FK_BL_Importaciones_IdImportacion",
                        column: x => x.IdImportacion,
                        principalTable: "Importaciones",
                        principalColumn: "IdImport",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contenedores",
                columns: table => new
                {
                    IdContenedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdImportacion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenedores", x => x.IdContenedor);
                    table.ForeignKey(
                        name: "FK_Contenedores_Importaciones_IdImportacion",
                        column: x => x.IdImportacion,
                        principalTable: "Importaciones",
                        principalColumn: "IdImport",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImportacionRevision",
                columns: table => new
                {
                    ImportacionesIdImport = table.Column<int>(type: "int", nullable: false),
                    RevisionesIdRevision = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportacionRevision", x => new { x.ImportacionesIdImport, x.RevisionesIdRevision });
                    table.ForeignKey(
                        name: "FK_ImportacionRevision_Importaciones_ImportacionesIdImport",
                        column: x => x.ImportacionesIdImport,
                        principalTable: "Importaciones",
                        principalColumn: "IdImport",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImportacionRevision_Revisiones_RevisionesIdRevision",
                        column: x => x.RevisionesIdRevision,
                        principalTable: "Revisiones",
                        principalColumn: "IdRevision",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    IdPoliza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBL = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdModalidad = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizas", x => x.IdPoliza);
                    table.ForeignKey(
                        name: "FK_Polizas_BL_IdBL",
                        column: x => x.IdBL,
                        principalTable: "BL",
                        principalColumn: "IdBL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Polizas_Nombres_IdModalidad",
                        column: x => x.IdModalidad,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Aduanas",
                columns: new[] { "IdAduana", "Abreviatura", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre", "Via" },
                values: new object[,]
                {
                    { 1, "ST", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5048), null, 1, null, "ADUANA SANTO TOMAS DE CASTILLA", "M" },
                    { 2, "PQ", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5051), null, 1, null, "ADUANA PUERTO QUETZAL", "M" },
                    { 3, "PB", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5053), null, 1, null, "ADUANA PUERTO BARRIOS", "M" },
                    { 4, "TU", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5054), null, 1, null, "ADUANA TECUN UMAN", "T" },
                    { 5, "EC", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5056), null, 1, null, "ADUANA EL CARMEN", "T" },
                    { 6, "LM", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5058), null, 1, null, "ADUANA LA MESILLA", "T" },
                    { 7, "MM", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5060), null, 1, null, "ADUANA MELCHOR DE MENCOS", "T" },
                    { 8, "EF", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5062), null, 1, null, "ADUANA EL FLORIDO", "T" },
                    { 9, "AV", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5063), null, 1, null, "ADUANA DE VEHICULOS", "T" },
                    { 10, "CH", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5065), null, 1, null, "ADUANA CHAMPERICO", "M" },
                    { 11, "PA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5067), null, 1, null, "ADUANA PEDRO DE ALVARADO", "T" },
                    { 12, "VN", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5068), null, 1, null, "ADUANA VALLE NUEVO", "T" },
                    { 13, "SC", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5070), null, 1, null, "ADUANA SAN CRISTOBAL", "T" },
                    { 14, "AC", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5072), null, 1, null, "ADUANA AGUA CALIENTE", "T" },
                    { 15, "LE", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5074), null, 1, null, "ADUANA LA ERMITA", "T" },
                    { 16, "CB", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5075), null, 1, null, "ADUANA EL CEIBO", "T" },
                    { 17, "SE", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5077), null, 1, null, "ADUANA SANTA ELENA", "A" },
                    { 18, "CA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5079), null, 1, null, "ADUANA CENTRAL DE AVIACION", "A" },
                    { 19, "EA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5081), null, 1, null, "ADUANA EXPRESS AEREO", "A" },
                    { 20, "CG", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5083), null, 1, null, "ADUANA CENTRAL DE GUATEMALA", "T" },
                    { 21, "FP", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5085), null, 1, null, "ADUANA FARDOS POSTALES", "C" },
                    { 22, "S1", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5086), null, 1, null, "ADUANA PUERTO ACAJUTLA", "M" },
                    { 23, "S2", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5088), null, 1, null, "ADUANA PUERTO DE COTUCO", "M" },
                    { 24, "H1", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5089), null, 1, null, "ADUANA PUERTO CORTES", "M" },
                    { 25, "N1", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5091), null, 1, null, "ADUANA PUERTO CORINTO", "M" },
                    { 26, "N2", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5093), null, 1, null, "ADUANA PEÑAS BLANCAS", "T" },
                    { 27, "G1", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5094), null, 1, null, "ADUANA ALMACENADORA INTEGRADA", "T" },
                    { 28, "G2", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5096), null, 1, null, "ADUANA ALMINTER", "T" },
                    { 29, "G3", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5097), null, 1, null, "ADUANA ALPASA", "T" },
                    { 30, "G4", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5099), null, 1, null, "ADUANA ALSERSA", "T" },
                    { 31, "G5", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5100), null, 1, null, "ADUANA CEALSA", "T" },
                    { 32, "G6", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5102), null, 1, null, "ADUANA ALMAGUATE", "T" },
                    { 33, "G7", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5104), null, 1, null, "ADUANA ALCORSA", "T" },
                    { 34, "G8", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5111), null, 1, null, "ADUANA CENTRALSA", "T" },
                    { 35, "H6", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5113), null, 1, null, "ADUANA INTEGRADA CORINTO", "T" },
                    { 36, "H7", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5115), null, 1, null, "ADUANA INTEGRADA AGUA CALIENTE", "T" },
                    { 37, "H8", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5116), null, 1, null, "ADUANA INTEGRADA EL FLORIDO", "T" }
                });

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "IdModulo", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1367), null, true, 1, null, "MENÚ PRINCIPAL" },
                    { 2, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1370), null, true, 1, null, "ADMINISTRACIÓN DEL SISTEMA" },
                    { 3, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1372), null, true, 1, null, "IMPORTACIONES" }
                });

            migrationBuilder.InsertData(
                table: "Revisiones",
                columns: new[] { "IdRevision", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod" },
                values: new object[,]
                {
                    { 1, "SGAIA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4729), null, 1, null },
                    { 2, "DIPAFRONT", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4732), null, 1, null },
                    { 3, "MAGA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4734), null, 1, null },
                    { 4, "RAYOS X", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4735), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRol", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[] { 1, new DateTime(2023, 1, 12, 10, 21, 7, 656, DateTimeKind.Local).AddTicks(9798), null, true, 1, null, "Super Admin" });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "IdShipper", "Aereo", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Maritimo", "Nombre", "Terrestre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4765), null, 1, null, true, "ANTEX KNITTING MILLS", true },
                    { 2, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4769), null, 1, null, true, "BOHOTEX CO, LTD", true },
                    { 3, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4770), null, 1, null, false, "BROS MACAO COMERCIAL", false },
                    { 4, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4772), null, 1, null, true, "CHAKIM SRL", true },
                    { 5, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4774), null, 1, null, false, "CHINA JUNYE TEXTILE", false },
                    { 6, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4776), null, 1, null, true, "COLOR & TOUCH VINA CO.,LTD", true },
                    { 7, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4779), null, 1, null, false, "DAP AMERICA INC", false },
                    { 8, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4781), null, 1, null, true, "DONGGUAN TEXWINCA", true },
                    { 9, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4783), null, 1, null, true, "HENIX FAR EAST", true },
                    { 10, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4786), null, 1, null, false, "JUNGWOO VINA", false },
                    { 11, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4787), null, 1, null, false, "KAN HIM PIECE", false },
                    { 12, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4789), null, 1, null, false, "KEER AMERICA", false },
                    { 13, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4791), null, 1, null, false, "MAINETTI EASTERN CHINA", false },
                    { 14, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4793), null, 1, null, false, "MANH DAT MANUFACTURE", false },
                    { 15, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4794), null, 1, null, false, "NICE DYEING FACTORY", false },
                    { 16, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4796), null, 1, null, false, "OAK HNI", false },
                    { 17, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4798), null, 1, null, false, "OCEAN NETWORK EXPRESS", false },
                    { 18, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4800), null, 1, null, false, "PACIFIC TEXTILES", false },
                    { 19, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4802), null, 1, null, false, "PARKDALE MILLS", false },
                    { 20, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4804), null, 1, null, false, "PHU BAI SPINNING MILL", false },
                    { 21, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4807), null, 1, null, false, "PT TOKAI TEXPRINT", false },
                    { 22, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4808), null, 1, null, false, "PT. WIN TEXTILE", false },
                    { 23, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4810), null, 1, null, false, "S&H GLOBAL, S.A.", false },
                    { 24, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4812), null, 1, null, false, "SAE-A DOMINICANA", false },
                    { 25, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4813), null, 1, null, false, "SAE-A EINS", false },
                    { 26, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4815), null, 1, null, false, "SAE-A SPINNING, S.A.", false },
                    { 27, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4817), null, 1, null, true, "SAE-A TRADING", true },
                    { 28, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4818), null, 1, null, false, "SAMIL VINA", false },
                    { 29, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4820), null, 1, null, false, "SEJIN SILICONE USA", false },
                    { 30, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4822), null, 1, null, false, "SEWANG VINA", false },
                    { 31, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4823), null, 1, null, false, "SHAOXING QIONGHUA TRADING CO.,LTD", false },
                    { 32, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4825), null, 1, null, false, "SUNG BU VINA", false },
                    { 33, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4827), null, 1, null, false, "SUNGPIL KANG", false },
                    { 34, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4830), null, 1, null, false, "VN JUNGWOO CHINA", false },
                    { 35, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4831), null, 1, null, false, "YAMATO USA", false },
                    { 36, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4833), null, 1, null, false, "YANG JI INTERNATIONAL", false },
                    { 37, true, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4835), null, 1, null, false, "YKK VIETNAM", false },
                    { 38, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4838), null, 1, null, true, "ACHROMA", true },
                    { 39, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4840), null, 1, null, true, "ALVANON HK LTD", true },
                    { 40, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4841), null, 1, null, true, "ALPINE", true },
                    { 41, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4843), null, 1, null, true, "BRAND ID HK", true },
                    { 42, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4845), null, 1, null, true, "BROS EASTERN CO", true },
                    { 43, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4846), null, 1, null, true, "AVERY DENNISON", true },
                    { 44, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4848), null, 1, null, true, "CENTURY INTERNATIONAL", true },
                    { 45, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4850), null, 1, null, true, "BUHLER QUALITY YARNS CORP", true },
                    { 46, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4851), null, 1, null, true, "COLOR SOLUTION", true },
                    { 47, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4853), null, 1, null, true, "CONG TY TNHH", true },
                    { 48, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4856), null, 1, null, true, "CRYSTAL TOWN LIMITED", true },
                    { 49, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4857), null, 1, null, true, "CS CENTRAL AMERICA S.A. DE C.V.", true },
                    { 50, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4859), null, 1, null, true, "DAEIL GAGONG", true },
                    { 51, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4861), null, 1, null, true, "DAESONG LABTECH", true },
                    { 52, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4863), null, 1, null, true, "DATACOLOR TECHNOLOGY", true },
                    { 53, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4865), null, 1, null, true, "DESERT EMPIRE", true },
                    { 54, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4868), null, 1, null, true, "DESICCA, LLCS", true },
                    { 55, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4871), null, 1, null, true, "DETAILTEX", true },
                    { 56, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4872), null, 1, null, true, "DICKS SPORTING", true },
                    { 57, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4874), null, 1, null, true, "DONG HING LABEL", true },
                    { 58, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4876), null, 1, null, true, "DURKOPP ADLER", true },
                    { 59, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4877), null, 1, null, true, "DYSTAR LP DBA COLOR", true },
                    { 60, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4879), null, 1, null, true, "E TEXTINT CORP", true },
                    { 61, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4881), null, 1, null, true, "FAVORABLE TECHNOLOGY", true },
                    { 62, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4882), null, 1, null, true, "EMBSENSE TEXTILE", true },
                    { 63, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4884), null, 1, null, true, "FINE LINE TECHNO", true },
                    { 64, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4886), null, 1, null, true, "EMSIG MANUFACTURING", true },
                    { 65, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4887), null, 1, null, true, "FLASH GLOBAL GSC", true },
                    { 66, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4890), null, 1, null, true, "FRANCIA HELENA YATE", true },
                    { 67, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4892), null, 1, null, true, "FREUDENBERG", true },
                    { 68, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4894), null, 1, null, true, "GAP INTERNATIONAL", true },
                    { 69, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4895), null, 1, null, true, "HASBUN SILHY", true },
                    { 70, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4898), null, 1, null, true, "HANSAE INTERNATIONAL", true },
                    { 72, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4899), null, 1, null, true, "HHH VIETNAM CO LTD", true },
                    { 73, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4901), null, 1, null, true, "INVISIN", true },
                    { 74, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4903), null, 1, null, true, "JD LINK INC", true },
                    { 80, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4905), null, 1, null, true, "KEUN YONG MACHINERY", true },
                    { 81, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4907), null, 1, null, true, "KWIN VIET HAN CO., LTD", true },
                    { 82, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4909), null, 1, null, true, "LECTRA SYSTEMES S,A", true },
                    { 83, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4910), null, 1, null, true, "LONG JIA HAO", true },
                    { 84, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4912), null, 1, null, true, "M TO M COMPORATION", true },
                    { 85, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4913), null, 1, null, true, "MAINETTI VIETNAM", true },
                    { 86, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4915), null, 1, null, true, "MARUWA CO., LTD", true },
                    { 87, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4917), null, 1, null, true, "MEI SHENG ", true },
                    { 88, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4918), null, 1, null, true, "NEMTEX S.A. DE C.V.", true },
                    { 89, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4920), null, 1, null, true, "NEXGEN PACKAGING", true },
                    { 90, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4927), null, 1, null, true, "OAK HNF", true },
                    { 91, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4929), null, 1, null, true, "OCTANES", true },
                    { 92, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4931), null, 1, null, true, "OPTIMER BRANDS", true },
                    { 93, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4933), null, 1, null, true, "ORDELY INDUSTRIAL", true },
                    { 94, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4934), null, 1, null, true, "PAXAR CHINA LIMITED", true },
                    { 95, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4936), null, 1, null, true, "PETTENATI CENTRO", true },
                    { 96, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4938), null, 1, null, true, "PRIDE PERFORMANCE", true },
                    { 97, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4939), null, 1, null, true, "PT ANYTAPE INDO", true },
                    { 98, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4941), null, 1, null, true, "R-PAC VIETNAM", true },
                    { 99, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4943), null, 1, null, true, "S&S INDUSTRIES, S DE R.L", true },
                    { 100, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4944), null, 1, null, true, "SAE A TECHNOTEX", true },
                    { 101, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4946), null, 1, null, true, "SAE-A SPINNING, S.R.L", true },
                    { 102, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4947), null, 1, null, true, "SAE-A TEXTUFIL", true },
                    { 104, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4949), null, 1, null, true, "SAE-A VIETNAM", true },
                    { 105, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4951), null, 1, null, true, "SHINING LABELS", true },
                    { 106, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4953), null, 1, null, true, "SILVER PRINTING", true },
                    { 107, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4954), null, 1, null, true, "SML DOMINICANA", true },
                    { 108, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4956), null, 1, null, true, "SML HONG KONG ", true },
                    { 109, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4959), null, 1, null, true, "SML VIETNAM", true },
                    { 110, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4960), null, 1, null, true, "SOJI COLORWORKS", true },
                    { 111, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4962), null, 1, null, true, "STAPROS INDUSTRIAL", true },
                    { 112, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4964), null, 1, null, true, "SUNLINE", true },
                    { 113, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4965), null, 1, null, true, "SWISSTEX DIRECT", true },
                    { 114, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4967), null, 1, null, true, "SYNIGENCE TRADING", true },
                    { 115, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4968), null, 1, null, true, "TEXHONG ", true },
                    { 116, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4970), null, 1, null, true, "UNITED TEXTILES OF AMERICA S. DE R.L. DE C.V.", true },
                    { 117, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4972), null, 1, null, true, "UTEXA", true },
                    { 118, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4973), null, 1, null, true, "WHA IL VINA", true },
                    { 119, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4975), null, 1, null, true, "WILSON GARMENT", true },
                    { 120, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4977), null, 1, null, true, "ZABIN INDUSTRIES", true },
                    { 121, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4978), null, 1, null, true, "ZHAOQING SHIRFERLY", true },
                    { 122, false, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4980), null, 1, null, true, "ZHEJIANG JIAYE", true }
                });

            migrationBuilder.InsertData(
                table: "Terminales",
                columns: new[] { "IdTerminal", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre", "Via" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5157), null, 1, null, "TCQ", "M" },
                    { 2, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5161), null, 1, null, "TPQ", "M" },
                    { 3, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5162), null, 1, null, "STC", "M" },
                    { 4, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5164), null, 1, null, "PB", "M" },
                    { 5, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5165), null, 1, null, "TEA", "A" },
                    { 6, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5167), null, 1, null, "TCU", "A" },
                    { 7, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(5169), null, 1, null, "TDL", "A" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "IdGrupo", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4550), null, 3, 1, null, "EMPRESA" },
                    { 2, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4555), null, 3, 1, null, "FORWARDER" },
                    { 3, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4557), null, 3, 1, null, "DESTINO" },
                    { 4, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4559), null, 3, 1, null, "MODALIDAD" },
                    { 5, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4561), null, 3, 1, null, "ALMACENADORA" }
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "IdPermiso", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1400), null, 1, 1, null, "VER.ADMINISTRACION SISTEMA" },
                    { 2, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1402), null, 1, 1, null, "VER.IMPORTACIONES" },
                    { 11, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1404), null, 2, 1, null, "VER.USUARIOS" },
                    { 12, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1406), null, 2, 1, null, "CREAR.USUARIOS" },
                    { 13, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1407), null, 2, 1, null, "MODIFICAR.USUARIOS" },
                    { 14, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1411), null, 2, 1, null, "ELIMINAR.USUARIOS" },
                    { 15, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1413), null, 2, 1, null, "VER.ROLES" },
                    { 16, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1414), null, 2, 1, null, "CREAR.ROLES" },
                    { 17, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1416), null, 2, 1, null, "MODIFICAR.ROLES" },
                    { 18, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1418), null, 2, 1, null, "ELIMINAR.ROLES" },
                    { 19, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1420), null, 2, 1, null, "VER.PERMISOS" },
                    { 20, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1422), null, 2, 1, null, "CREAR.PERMISOS" },
                    { 21, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1423), null, 2, 1, null, "MODIFICAR.PERMISOS" },
                    { 22, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1424), null, 2, 1, null, "ELIMINAR.PERMISOS" },
                    { 23, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1426), null, 2, 1, null, "VER.MODULOS" },
                    { 24, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1427), null, 2, 1, null, "CREAR.MODULOS" },
                    { 25, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1429), null, 2, 1, null, "MODIFICAR.MODULOS" },
                    { 26, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1431), null, 2, 1, null, "ELIMINAR.MODULOS" },
                    { 27, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1432), null, 3, 1, null, "VER.DASHBOARD" },
                    { 28, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1434), null, 3, 1, null, "VER.MARITIMO" },
                    { 29, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1435), null, 3, 1, null, "CREAR.MARITIMO" },
                    { 30, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1437), null, 3, 1, null, "MODIFICAR.MARITIMO" },
                    { 31, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1438), null, 3, 1, null, "ELIMINAR.MARITIMO" },
                    { 32, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1440), null, 3, 1, null, "VER.AEREO" },
                    { 33, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1441), null, 3, 1, null, "CREAR.AEREO" },
                    { 34, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1443), null, 3, 1, null, "MODIFICAR.AEREO" },
                    { 35, new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1444), null, 3, 1, null, "ELIMINAR.AEREO" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Activo", "Apellidos", "Email", "FechaCreacion", "FechaUltimaMod", "IdRol", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres", "Password", "UserName" },
                values: new object[] { 1, true, "Admin", "sa@sae-a.com", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(1304), null, 1, 1, null, "Super", "wgxml8gsyZMmO7/RBQWV9r7xScXLdOULy+DrPjtU5gxaTg1+i6LZrHwKcO1HEq+9YUbWUl0WsF11s2NeXxorBZ4f1vxiXA==", "sa" });

            migrationBuilder.InsertData(
                table: "Nombres",
                columns: new[] { "IdNombre", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdGrupo", "IdUsuarioCreacion", "IdUsuarioMod" },
                values: new object[,]
                {
                    { 1, "SEABOARD", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4597), null, 1, 1, null },
                    { 2, "ONE LINE ", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4600), null, 1, 1, null },
                    { 3, "CROWLEY", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4602), null, 1, 1, null },
                    { 4, "MAERSK", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4603), null, 1, 1, null },
                    { 5, "EVERGREEN", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4605), null, 1, 1, null },
                    { 6, "HYUNDAI", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4607), null, 1, 1, null },
                    { 7, "CHIQUITA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4609), null, 1, 1, null },
                    { 8, "WAN HAI", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4610), null, 1, 1, null },
                    { 9, "HMM GLOBAL", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4612), null, 1, 1, null },
                    { 10, "ATLANTIC", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4614), null, 1, 1, null },
                    { 11, "SEALAND", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4616), null, 1, 1, null },
                    { 12, "CMA CGM", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4618), null, 1, 1, null },
                    { 13, "EXPEDITORS", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4619), null, 1, 1, null },
                    { 14, "YANG MIN", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4621), null, 1, 1, null },
                    { 15, "TRANSPORTES TRANSREYES", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4623), null, 1, 1, null },
                    { 16, "CENTRASERVI S.A. DE C.V", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4624), null, 1, 1, null },
                    { 17, "TRANSPORTES LOS ROBLES", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4626), null, 1, 1, null },
                    { 18, "LOGISTRANS S.A.", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4628), null, 1, 1, null },
                    { 19, "TRANSPORTES VILLEDA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4630), null, 1, 1, null },
                    { 20, "INTERNATIONAL CARGO", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4631), null, 1, 1, null },
                    { 21, "CROWLEY LOGISTIC", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4633), null, 1, 1, null },
                    { 22, "BLUE LOGISTC ", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4634), null, 2, 1, null },
                    { 23, "DHL", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4635), null, 2, 1, null },
                    { 24, "DONGSUE", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4637), null, 2, 1, null },
                    { 25, "AVIANCA ", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4638), null, 2, 1, null },
                    { 26, "TACA INTERNACIONAL", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4640), null, 2, 1, null },
                    { 27, "FEDEX", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4641), null, 2, 1, null },
                    { 28, "BODEGA ACCESORIOS", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4643), null, 3, 1, null },
                    { 29, "BODEGA DE STOCKS", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4644), null, 3, 1, null },
                    { 30, "BODEGA DE HILO PALIN", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4646), null, 3, 1, null },
                    { 31, "CENTEXSA 2", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4648), null, 3, 1, null },
                    { 32, "HANAH TRADING", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4649), null, 3, 1, null },
                    { 33, "CENTEXSA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4651), null, 3, 1, null },
                    { 34, "JS TEXTILES", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4653), null, 3, 1, null },
                    { 35, "J.W.TEXTILES", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4654), null, 3, 1, null },
                    { 36, "JJ TRADING", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4656), null, 3, 1, null },
                    { 37, "K&H", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4657), null, 3, 1, null },
                    { 38, "KNITOPIA , S.A.", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4659), null, 3, 1, null },
                    { 39, "KOA MODAS", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4660), null, 3, 1, null },
                    { 40, "K.P TEXTILE", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4662), null, 3, 1, null },
                    { 41, "PANTEX", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4664), null, 3, 1, null },
                    { 42, "S&G", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4666), null, 3, 1, null },
                    { 43, "SAE-A TEXPIA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4667), null, 3, 1, null },
                    { 44, "SAE-A TEXPIA 2", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4669), null, 3, 1, null },
                    { 45, "SAE-A TEXPÍA 3", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4670), null, 3, 1, null },
                    { 46, "TEXSION", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4671), null, 3, 1, null },
                    { 47, "TEXTILES CHANG WOO", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4673), null, 3, 1, null },
                    { 48, "WINNERS", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4674), null, 3, 1, null },
                    { 49, "MI", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4677), null, 4, 1, null },
                    { 50, "ID", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4678), null, 4, 1, null },
                    { 51, "MA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4680), null, 4, 1, null },
                    { 52, "DV", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4681), null, 4, 1, null },
                    { 53, "DI", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4683), null, 4, 1, null },
                    { 54, "MQ", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4684), null, 4, 1, null },
                    { 55, "DS", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4685), null, 4, 1, null },
                    { 56, "ALMAGUATE", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4687), null, 5, 1, null },
                    { 57, "ALSERSA", new DateTime(2023, 1, 12, 10, 21, 7, 657, DateTimeKind.Local).AddTicks(4688), null, 5, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PermisoRol",
                columns: new[] { "PermisosIdPermiso", "RolesIdRol" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 },
                    { 25, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 31, 1 },
                    { 32, 1 },
                    { 33, 1 },
                    { 34, 1 },
                    { 35, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aduanas_Abreviatura",
                table: "Aduanas",
                column: "Abreviatura",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aduanas_Nombre",
                table: "Aduanas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BL_IdImportacion",
                table: "BL",
                column: "IdImportacion");

            migrationBuilder.CreateIndex(
                name: "IX_BL_Numero",
                table: "BL",
                column: "Numero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contenedores_IdImportacion",
                table: "Contenedores",
                column: "IdImportacion");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_IdModulo",
                table: "Grupos",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_Nombre",
                table: "Grupos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdAduana",
                table: "Importaciones",
                column: "IdAduana");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdAlmacenadora",
                table: "Importaciones",
                column: "IdAlmacenadora");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdDestino",
                table: "Importaciones",
                column: "IdDestino");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdForwarder",
                table: "Importaciones",
                column: "IdForwarder");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdNaviera",
                table: "Importaciones",
                column: "IdNaviera");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdShipper",
                table: "Importaciones",
                column: "IdShipper");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdTerminal",
                table: "Importaciones",
                column: "IdTerminal");

            migrationBuilder.CreateIndex(
                name: "IX_Importaciones_IdUsuario",
                table: "Importaciones",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ImportacionRevision_RevisionesIdRevision",
                table: "ImportacionRevision",
                column: "RevisionesIdRevision");

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_Nombre",
                table: "Modulos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nombres_Descripcion",
                table: "Nombres",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nombres_IdGrupo",
                table: "Nombres",
                column: "IdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_PermisoRol_RolesIdRol",
                table: "PermisoRol",
                column: "RolesIdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_IdModulo",
                table: "Permisos",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Nombre",
                table: "Permisos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_IdBL",
                table: "Polizas",
                column: "IdBL");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_IdModalidad",
                table: "Polizas",
                column: "IdModalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_Numero",
                table: "Polizas",
                column: "Numero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_Descripcion",
                table: "Revisiones",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Nombre",
                table: "Roles",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_Nombre",
                table: "Shippers",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Terminales_Nombre",
                table: "Terminales",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdRol",
                table: "Usuarios",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UserName",
                table: "Usuarios",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contenedores");

            migrationBuilder.DropTable(
                name: "ImportacionRevision");

            migrationBuilder.DropTable(
                name: "PermisoRol");

            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Terminales");

            migrationBuilder.DropTable(
                name: "Revisiones");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "BL");

            migrationBuilder.DropTable(
                name: "Importaciones");

            migrationBuilder.DropTable(
                name: "Aduanas");

            migrationBuilder.DropTable(
                name: "Nombres");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Modulos");
        }
    }
}
