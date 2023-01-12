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
                    { 1, "ST", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8388), null, 1, null, "ADUANA SANTO TOMAS DE CASTILLA", "M" },
                    { 2, "PQ", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8392), null, 1, null, "ADUANA PUERTO QUETZAL", "M" },
                    { 3, "PB", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8394), null, 1, null, "ADUANA PUERTO BARRIOS", "M" },
                    { 4, "TU", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8395), null, 1, null, "ADUANA TECUN UMAN", "T" },
                    { 5, "EC", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8397), null, 1, null, "ADUANA EL CARMEN", "T" },
                    { 6, "LM", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8399), null, 1, null, "ADUANA LA MESILLA", "T" },
                    { 7, "MM", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8401), null, 1, null, "ADUANA MELCHOR DE MENCOS", "T" },
                    { 8, "EF", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8402), null, 1, null, "ADUANA EL FLORIDO", "T" },
                    { 9, "AV", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8404), null, 1, null, "ADUANA DE VEHICULOS", "T" },
                    { 10, "CH", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8406), null, 1, null, "ADUANA CHAMPERICO", "M" },
                    { 11, "PA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8408), null, 1, null, "ADUANA PEDRO DE ALVARADO", "T" },
                    { 12, "VN", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8409), null, 1, null, "ADUANA VALLE NUEVO", "T" },
                    { 13, "SC", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8411), null, 1, null, "ADUANA SAN CRISTOBAL", "T" },
                    { 14, "AC", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8413), null, 1, null, "ADUANA AGUA CALIENTE", "T" },
                    { 15, "LE", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8414), null, 1, null, "ADUANA LA ERMITA", "T" },
                    { 16, "CB", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8416), null, 1, null, "ADUANA EL CEIBO", "T" },
                    { 17, "SE", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8418), null, 1, null, "ADUANA SANTA ELENA", "A" },
                    { 18, "CA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8420), null, 1, null, "ADUANA CENTRAL DE AVIACION", "A" },
                    { 19, "EA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8421), null, 1, null, "ADUANA EXPRESS AEREO", "A" },
                    { 20, "CG", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8424), null, 1, null, "ADUANA CENTRAL DE GUATEMALA", "T" },
                    { 21, "FP", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8426), null, 1, null, "ADUANA FARDOS POSTALES", "C" },
                    { 22, "S1", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8427), null, 1, null, "ADUANA PUERTO ACAJUTLA", "M" },
                    { 23, "S2", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8429), null, 1, null, "ADUANA PUERTO DE COTUCO", "M" },
                    { 24, "H1", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8431), null, 1, null, "ADUANA PUERTO CORTES", "M" },
                    { 25, "N1", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8432), null, 1, null, "ADUANA PUERTO CORINTO", "M" },
                    { 26, "N2", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8434), null, 1, null, "ADUANA PEÑAS BLANCAS", "T" },
                    { 27, "G1", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8435), null, 1, null, "ADUANA ALMACENADORA INTEGRADA", "T" },
                    { 28, "G2", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8437), null, 1, null, "ADUANA ALMINTER", "T" },
                    { 29, "G3", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8439), null, 1, null, "ADUANA ALPASA", "T" },
                    { 30, "G4", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8440), null, 1, null, "ADUANA ALSERSA", "T" },
                    { 31, "G5", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8442), null, 1, null, "ADUANA CEALSA", "T" },
                    { 32, "G6", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8450), null, 1, null, "ADUANA ALMAGUATE", "T" },
                    { 33, "G7", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8452), null, 1, null, "ADUANA ALCORSA", "T" },
                    { 34, "G8", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8454), null, 1, null, "ADUANA CENTRALSA", "T" },
                    { 35, "H6", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8455), null, 1, null, "ADUANA INTEGRADA CORINTO", "T" },
                    { 36, "H7", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8457), null, 1, null, "ADUANA INTEGRADA AGUA CALIENTE", "T" },
                    { 37, "H8", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8459), null, 1, null, "ADUANA INTEGRADA EL FLORIDO", "T" }
                });

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "IdModulo", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4673), null, true, 1, null, "MENÚ PRINCIPAL" },
                    { 2, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4677), null, true, 1, null, "ADMINISTRACIÓN DEL SISTEMA" },
                    { 3, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4679), null, true, 1, null, "IMPORTACIONES" }
                });

            migrationBuilder.InsertData(
                table: "Revisiones",
                columns: new[] { "IdRevision", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod" },
                values: new object[,]
                {
                    { 1, "SGAIA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8028), null, 1, null },
                    { 2, "DIPAFRONT", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8033), null, 1, null },
                    { 3, "MAGA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8041), null, 1, null },
                    { 4, "RAYOS X", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8043), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRol", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[] { 1, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(3155), null, true, 1, null, "Super Admin" });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "IdShipper", "Aereo", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Maritimo", "Nombre", "Terrestre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8063), null, 1, null, true, "ANTEX KNITTING MILLS", true },
                    { 2, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8066), null, 1, null, true, "BOHOTEX CO, LTD", true },
                    { 3, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8068), null, 1, null, false, "BROS MACAO COMERCIAL", false },
                    { 4, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8070), null, 1, null, true, "CHAKIM SRL", true },
                    { 5, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8072), null, 1, null, false, "CHINA JUNYE TEXTILE", false },
                    { 6, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8075), null, 1, null, true, "COLOR & TOUCH VINA CO.,LTD", true },
                    { 7, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8077), null, 1, null, false, "DAP AMERICA INC", false },
                    { 8, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8080), null, 1, null, true, "DONGGUAN TEXWINCA", true },
                    { 9, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8081), null, 1, null, true, "HENIX FAR EAST", true },
                    { 10, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8084), null, 1, null, false, "JUNGWOO VINA", false },
                    { 11, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8086), null, 1, null, false, "KAN HIM PIECE", false },
                    { 12, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8087), null, 1, null, false, "KEER AMERICA", false },
                    { 13, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8089), null, 1, null, false, "MAINETTI EASTERN CHINA", false },
                    { 14, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8091), null, 1, null, false, "MANH DAT MANUFACTURE", false },
                    { 15, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8093), null, 1, null, false, "NICE DYEING FACTORY", false },
                    { 16, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8094), null, 1, null, false, "OAK HNI", false },
                    { 17, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8096), null, 1, null, false, "OCEAN NETWORK EXPRESS", false },
                    { 18, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8099), null, 1, null, false, "PACIFIC TEXTILES", false },
                    { 19, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8101), null, 1, null, false, "PARKDALE MILLS", false },
                    { 20, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8102), null, 1, null, false, "PHU BAI SPINNING MILL", false },
                    { 21, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8108), null, 1, null, false, "PT TOKAI TEXPRINT", false },
                    { 22, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8109), null, 1, null, false, "PT. WIN TEXTILE", false },
                    { 23, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8111), null, 1, null, false, "S&H GLOBAL, S.A.", false },
                    { 24, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8113), null, 1, null, false, "SAE-A DOMINICANA", false },
                    { 25, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8114), null, 1, null, false, "SAE-A EINS", false },
                    { 26, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8116), null, 1, null, false, "SAE-A SPINNING, S.A.", false },
                    { 27, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8118), null, 1, null, true, "SAE-A TRADING", true },
                    { 28, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8119), null, 1, null, false, "SAMIL VINA", false },
                    { 29, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8121), null, 1, null, false, "SEJIN SILICONE USA", false },
                    { 30, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8123), null, 1, null, false, "SEWANG VINA", false },
                    { 31, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8124), null, 1, null, false, "SHAOXING QIONGHUA TRADING CO.,LTD", false },
                    { 32, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8126), null, 1, null, false, "SUNG BU VINA", false },
                    { 33, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8128), null, 1, null, false, "SUNGPIL KANG", false },
                    { 34, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8131), null, 1, null, false, "VN JUNGWOO CHINA", false },
                    { 35, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8132), null, 1, null, false, "YAMATO USA", false },
                    { 36, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8134), null, 1, null, false, "YANG JI INTERNATIONAL", false },
                    { 37, true, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8136), null, 1, null, false, "YKK VIETNAM", false },
                    { 38, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8139), null, 1, null, true, "ACHROMA", true },
                    { 39, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8140), null, 1, null, true, "ALVANON HK LTD", true },
                    { 40, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8142), null, 1, null, true, "ALPINE", true },
                    { 41, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8144), null, 1, null, true, "BRAND ID HK", true },
                    { 42, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8145), null, 1, null, true, "BROS EASTERN CO", true },
                    { 43, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8147), null, 1, null, true, "AVERY DENNISON", true },
                    { 44, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8149), null, 1, null, true, "CENTURY INTERNATIONAL", true },
                    { 45, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8150), null, 1, null, true, "BUHLER QUALITY YARNS CORP", true },
                    { 46, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8152), null, 1, null, true, "COLOR SOLUTION", true },
                    { 47, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8154), null, 1, null, true, "CONG TY TNHH", true },
                    { 48, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8156), null, 1, null, true, "CRYSTAL TOWN LIMITED", true },
                    { 49, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8158), null, 1, null, true, "CS CENTRAL AMERICA S.A. DE C.V.", true },
                    { 50, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8160), null, 1, null, true, "DAEIL GAGONG", true },
                    { 51, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8161), null, 1, null, true, "DAESONG LABTECH", true },
                    { 52, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8163), null, 1, null, true, "DATACOLOR TECHNOLOGY", true },
                    { 53, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8165), null, 1, null, true, "DESERT EMPIRE", true },
                    { 54, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8168), null, 1, null, true, "DESICCA, LLCS", true },
                    { 55, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8170), null, 1, null, true, "DETAILTEX", true },
                    { 56, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8171), null, 1, null, true, "DICKS SPORTING", true },
                    { 57, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8173), null, 1, null, true, "DONG HING LABEL", true },
                    { 58, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8175), null, 1, null, true, "DURKOPP ADLER", true },
                    { 59, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8176), null, 1, null, true, "DYSTAR LP DBA COLOR", true },
                    { 60, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8178), null, 1, null, true, "E TEXTINT CORP", true },
                    { 61, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8180), null, 1, null, true, "FAVORABLE TECHNOLOGY", true },
                    { 62, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8182), null, 1, null, true, "EMBSENSE TEXTILE", true },
                    { 63, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8183), null, 1, null, true, "FINE LINE TECHNO", true },
                    { 64, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8185), null, 1, null, true, "EMSIG MANUFACTURING", true },
                    { 65, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8187), null, 1, null, true, "FLASH GLOBAL GSC", true },
                    { 66, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8190), null, 1, null, true, "FRANCIA HELENA YATE", true },
                    { 67, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8192), null, 1, null, true, "FREUDENBERG", true },
                    { 68, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8194), null, 1, null, true, "GAP INTERNATIONAL", true },
                    { 69, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8195), null, 1, null, true, "HASBUN SILHY", true },
                    { 70, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8198), null, 1, null, true, "HANSAE INTERNATIONAL", true },
                    { 72, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8199), null, 1, null, true, "HHH VIETNAM CO LTD", true },
                    { 73, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8201), null, 1, null, true, "INVISIN", true },
                    { 74, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8203), null, 1, null, true, "JD LINK INC", true },
                    { 80, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8204), null, 1, null, true, "KEUN YONG MACHINERY", true },
                    { 81, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8206), null, 1, null, true, "KWIN VIET HAN CO., LTD", true },
                    { 82, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8208), null, 1, null, true, "LECTRA SYSTEMES S,A", true },
                    { 83, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8210), null, 1, null, true, "LONG JIA HAO", true },
                    { 84, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8218), null, 1, null, true, "M TO M COMPORATION", true },
                    { 85, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8220), null, 1, null, true, "MAINETTI VIETNAM", true },
                    { 86, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8221), null, 1, null, true, "MARUWA CO., LTD", true },
                    { 87, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8223), null, 1, null, true, "MEI SHENG ", true },
                    { 88, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8225), null, 1, null, true, "NEMTEX S.A. DE C.V.", true },
                    { 89, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8227), null, 1, null, true, "NEXGEN PACKAGING", true },
                    { 90, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8228), null, 1, null, true, "OAK HNF", true },
                    { 91, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8230), null, 1, null, true, "OCTANES", true },
                    { 92, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8233), null, 1, null, true, "OPTIMER BRANDS", true },
                    { 93, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8235), null, 1, null, true, "ORDELY INDUSTRIAL", true },
                    { 94, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8236), null, 1, null, true, "PAXAR CHINA LIMITED", true },
                    { 95, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8238), null, 1, null, true, "PETTENATI CENTRO", true },
                    { 96, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8240), null, 1, null, true, "PRIDE PERFORMANCE", true },
                    { 97, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8241), null, 1, null, true, "PT ANYTAPE INDO", true },
                    { 98, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8243), null, 1, null, true, "R-PAC VIETNAM", true },
                    { 99, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8245), null, 1, null, true, "S&S INDUSTRIES, S DE R.L", true },
                    { 100, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8246), null, 1, null, true, "SAE A TECHNOTEX", true },
                    { 101, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8248), null, 1, null, true, "SAE-A SPINNING, S.R.L", true },
                    { 102, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8250), null, 1, null, true, "SAE-A TEXTUFIL", true },
                    { 104, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8288), null, 1, null, true, "SAE-A VIETNAM", true },
                    { 105, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8290), null, 1, null, true, "SHINING LABELS", true },
                    { 106, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8292), null, 1, null, true, "SILVER PRINTING", true },
                    { 107, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8293), null, 1, null, true, "SML DOMINICANA", true },
                    { 108, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8295), null, 1, null, true, "SML HONG KONG ", true },
                    { 109, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8298), null, 1, null, true, "SML VIETNAM", true },
                    { 110, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8300), null, 1, null, true, "SOJI COLORWORKS", true },
                    { 111, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8301), null, 1, null, true, "STAPROS INDUSTRIAL", true },
                    { 112, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8303), null, 1, null, true, "SUNLINE", true },
                    { 113, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8305), null, 1, null, true, "SWISSTEX DIRECT", true },
                    { 114, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8306), null, 1, null, true, "SYNIGENCE TRADING", true },
                    { 115, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8308), null, 1, null, true, "TEXHONG ", true },
                    { 116, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8310), null, 1, null, true, "UNITED TEXTILES OF AMERICA S. DE R.L. DE C.V.", true },
                    { 117, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8312), null, 1, null, true, "UTEXA", true },
                    { 118, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8313), null, 1, null, true, "WHA IL VINA", true },
                    { 119, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8315), null, 1, null, true, "WILSON GARMENT", true },
                    { 120, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8317), null, 1, null, true, "ZABIN INDUSTRIES", true },
                    { 121, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8318), null, 1, null, true, "ZHAOQING SHIRFERLY", true },
                    { 122, false, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8320), null, 1, null, true, "ZHEJIANG JIAYE", true }
                });

            migrationBuilder.InsertData(
                table: "Terminales",
                columns: new[] { "IdTerminal", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre", "Via" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8494), null, 1, null, "TCQ", "M" },
                    { 2, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8500), null, 1, null, "TPQ", "M" },
                    { 3, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8502), null, 1, null, "STC", "M" },
                    { 4, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8503), null, 1, null, "PB", "M" },
                    { 5, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8505), null, 1, null, "TEA", "A" },
                    { 6, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8507), null, 1, null, "TCU", "A" },
                    { 7, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(8509), null, 1, null, "TDL", "A" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "IdGrupo", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7851), null, 3, 1, null, "EMPRESA" },
                    { 2, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7861), null, 3, 1, null, "FORWARDER" },
                    { 3, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7863), null, 3, 1, null, "DESTINO" },
                    { 4, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7865), null, 3, 1, null, "MODALIDAD" },
                    { 5, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7866), null, 3, 1, null, "ALMACENADORA" }
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "IdPermiso", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4704), null, 1, 1, null, "VER.ADMINISTRACION SISTEMA" },
                    { 2, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4707), null, 1, 1, null, "VER.IMPORTACIONES" },
                    { 11, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4709), null, 2, 1, null, "VER.USUARIOS" },
                    { 12, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4710), null, 2, 1, null, "CREAR.USUARIOS" },
                    { 13, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4712), null, 2, 1, null, "MODIFICAR.USUARIOS" },
                    { 14, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4716), null, 2, 1, null, "ELIMINAR.USUARIOS" },
                    { 15, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4717), null, 2, 1, null, "VER.ROLES" },
                    { 16, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4718), null, 2, 1, null, "CREAR.ROLES" },
                    { 17, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4720), null, 2, 1, null, "MODIFICAR.ROLES" },
                    { 18, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4723), null, 2, 1, null, "ELIMINAR.ROLES" },
                    { 19, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4725), null, 2, 1, null, "VER.PERMISOS" },
                    { 20, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4726), null, 2, 1, null, "CREAR.PERMISOS" },
                    { 21, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4728), null, 2, 1, null, "MODIFICAR.PERMISOS" },
                    { 22, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4729), null, 2, 1, null, "ELIMINAR.PERMISOS" },
                    { 23, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4731), null, 2, 1, null, "VER.MODULOS" },
                    { 24, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4732), null, 2, 1, null, "CREAR.MODULOS" },
                    { 25, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4733), null, 2, 1, null, "MODIFICAR.MODULOS" },
                    { 26, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4736), null, 2, 1, null, "ELIMINAR.MODULOS" },
                    { 27, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4737), null, 3, 1, null, "VER.DASHBOARD" },
                    { 28, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4739), null, 3, 1, null, "VER.MARITIMO" },
                    { 29, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4740), null, 3, 1, null, "CREAR.MARITIMO" },
                    { 30, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4742), null, 3, 1, null, "MODIFICAR.MARITIMO" },
                    { 31, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4744), null, 3, 1, null, "ELIMINAR.MARITIMO" },
                    { 32, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4746), null, 3, 1, null, "VER.AEREO" },
                    { 33, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4747), null, 3, 1, null, "CREAR.AEREO" },
                    { 34, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4748), null, 3, 1, null, "MODIFICAR.AEREO" },
                    { 35, new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4750), null, 3, 1, null, "ELIMINAR.AEREO" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Activo", "Apellidos", "Email", "FechaCreacion", "FechaUltimaMod", "IdRol", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres", "Password", "UserName" },
                values: new object[] { 1, true, "Admin", "sa@sae-a.com", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(4612), null, 1, 1, null, "Super", "AZqF2tSu19dzj4jwTAvTvL57W5xqu0bh5ChHw5mo3/LUFu3zNJO00b5lbDggx4s7FOCqnxGqQqQgtf+6kr7t26/Dc4QT9hNfCuGav8GO", "sa" });

            migrationBuilder.InsertData(
                table: "Nombres",
                columns: new[] { "IdNombre", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdGrupo", "IdUsuarioCreacion", "IdUsuarioMod" },
                values: new object[,]
                {
                    { 1, "SEABOARD", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7899), null, 1, 1, null },
                    { 2, "ONE LINE ", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7903), null, 1, 1, null },
                    { 3, "CROWLEY", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7904), null, 1, 1, null },
                    { 4, "MAERSK", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7906), null, 1, 1, null },
                    { 5, "EVERGREEN", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7907), null, 1, 1, null },
                    { 6, "HYUNDAI", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7910), null, 1, 1, null },
                    { 7, "CHIQUITA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7911), null, 1, 1, null },
                    { 8, "WAN HAI", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7913), null, 1, 1, null },
                    { 9, "HMM GLOBAL", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7914), null, 1, 1, null },
                    { 10, "ATLANTIC", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7917), null, 1, 1, null },
                    { 11, "SEALAND", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7919), null, 1, 1, null },
                    { 12, "CMA CGM", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7920), null, 1, 1, null },
                    { 13, "EXPEDITORS", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7922), null, 1, 1, null },
                    { 14, "YANG MIN", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7924), null, 1, 1, null },
                    { 15, "TRANSPORTES TRANSREYES", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7925), null, 1, 1, null },
                    { 16, "CENTRASERVI S.A. DE C.V", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7926), null, 1, 1, null },
                    { 17, "TRANSPORTES LOS ROBLES", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7928), null, 1, 1, null },
                    { 18, "LOGISTRANS S.A.", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7930), null, 1, 1, null },
                    { 19, "TRANSPORTES VILLEDA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7932), null, 1, 1, null },
                    { 20, "INTERNATIONAL CARGO", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7933), null, 1, 1, null },
                    { 21, "CROWLEY LOGISTIC", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7934), null, 1, 1, null },
                    { 22, "BLUE LOGISTC ", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7936), null, 2, 1, null },
                    { 23, "DHL", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7937), null, 2, 1, null },
                    { 24, "DONGSUE", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7939), null, 2, 1, null },
                    { 25, "AVIANCA ", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7940), null, 2, 1, null },
                    { 26, "TACA INTERNACIONAL", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7941), null, 2, 1, null },
                    { 27, "FEDEX", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7943), null, 2, 1, null },
                    { 28, "BODEGA ACCESORIOS", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7944), null, 3, 1, null },
                    { 29, "BODEGA DE STOCKS", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7945), null, 3, 1, null },
                    { 30, "BODEGA DE HILO PALIN", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7948), null, 3, 1, null },
                    { 31, "CENTEXSA 2", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7949), null, 3, 1, null },
                    { 32, "HANAH TRADING", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7950), null, 3, 1, null },
                    { 33, "CENTEXSA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7952), null, 3, 1, null },
                    { 34, "JS TEXTILES", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7954), null, 3, 1, null },
                    { 35, "J.W.TEXTILES", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7956), null, 3, 1, null },
                    { 36, "JJ TRADING", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7957), null, 3, 1, null },
                    { 37, "K&H", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7958), null, 3, 1, null },
                    { 38, "KNITOPIA , S.A.", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7960), null, 3, 1, null },
                    { 39, "KOA MODAS", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7961), null, 3, 1, null },
                    { 40, "K.P TEXTILE", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7963), null, 3, 1, null },
                    { 41, "PANTEX", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7965), null, 3, 1, null },
                    { 42, "S&G", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7967), null, 3, 1, null },
                    { 43, "SAE-A TEXPIA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7968), null, 3, 1, null },
                    { 44, "SAE-A TEXPIA 2", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7970), null, 3, 1, null },
                    { 45, "SAE-A TEXPÍA 3", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7971), null, 3, 1, null },
                    { 46, "TEXSION", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7972), null, 3, 1, null },
                    { 47, "TEXTILES CHANG WOO", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7974), null, 3, 1, null },
                    { 48, "WINNERS", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7975), null, 3, 1, null },
                    { 49, "MI", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7977), null, 4, 1, null },
                    { 50, "ID", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7979), null, 4, 1, null },
                    { 51, "MA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7980), null, 4, 1, null },
                    { 52, "DV", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7981), null, 4, 1, null },
                    { 53, "DI", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7983), null, 4, 1, null },
                    { 54, "MQ", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7984), null, 4, 1, null },
                    { 55, "DS", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7986), null, 4, 1, null },
                    { 56, "ALMAGUATE", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7987), null, 5, 1, null },
                    { 57, "ALSERSA", new DateTime(2023, 1, 12, 14, 38, 15, 337, DateTimeKind.Local).AddTicks(7989), null, 5, 1, null }
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
