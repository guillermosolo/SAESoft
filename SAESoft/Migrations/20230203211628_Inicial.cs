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
                name: "ImportStatus",
                columns: table => new
                {
                    IdImportStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orden = table.Column<long>(type: "bigint", nullable: false),
                    Via = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportStatus", x => x.IdImportStatus);
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
                    IdForwarder = table.Column<int>(type: "int", nullable: true),
                    IdDestino = table.Column<int>(type: "int", nullable: true),
                    ETA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdTerminal = table.Column<int>(type: "int", nullable: true),
                    IdAduana = table.Column<int>(type: "int", nullable: false),
                    IdAlmacenadora = table.Column<int>(type: "int", nullable: true),
                    Consolidado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdImportStatus = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "money", nullable: true),
                    Mora = table.Column<decimal>(type: "money", nullable: true),
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
                        name: "FK_Importaciones_ImportStatus_IdImportStatus",
                        column: x => x.IdImportStatus,
                        principalTable: "ImportStatus",
                        principalColumn: "IdImportStatus",
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
                        principalColumn: "IdNombre");
                    table.ForeignKey(
                        name: "FK_Importaciones_Nombres_IdForwarder",
                        column: x => x.IdForwarder,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre");
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
                        principalColumn: "IdNombre");
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
                    Cabezal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Furgon = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    IdPoliza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBL = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdModalidad = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { 1, "ST", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4471), null, 1, null, "ADUANA SANTO TOMAS DE CASTILLA", "M" },
                    { 2, "PQ", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4475), null, 1, null, "ADUANA PUERTO QUETZAL", "M" },
                    { 3, "PB", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4477), null, 1, null, "ADUANA PUERTO BARRIOS", "M" },
                    { 4, "TU", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4478), null, 1, null, "ADUANA TECUN UMAN", "T" },
                    { 5, "EC", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4480), null, 1, null, "ADUANA EL CARMEN", "T" },
                    { 6, "LM", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4482), null, 1, null, "ADUANA LA MESILLA", "T" },
                    { 7, "MM", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4484), null, 1, null, "ADUANA MELCHOR DE MENCOS", "T" },
                    { 8, "EF", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4486), null, 1, null, "ADUANA EL FLORIDO", "T" },
                    { 9, "AV", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4487), null, 1, null, "ADUANA DE VEHICULOS", "T" },
                    { 10, "CH", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4490), null, 1, null, "ADUANA CHAMPERICO", "M" },
                    { 11, "PA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4491), null, 1, null, "ADUANA PEDRO DE ALVARADO", "T" },
                    { 12, "VN", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4493), null, 1, null, "ADUANA VALLE NUEVO", "T" },
                    { 13, "SC", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4495), null, 1, null, "ADUANA SAN CRISTOBAL", "T" },
                    { 14, "AC", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4497), null, 1, null, "ADUANA AGUA CALIENTE", "T" },
                    { 15, "LE", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4498), null, 1, null, "ADUANA LA ERMITA", "T" },
                    { 16, "CB", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4500), null, 1, null, "ADUANA EL CEIBO", "T" },
                    { 17, "SE", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4502), null, 1, null, "ADUANA SANTA ELENA", "A" },
                    { 18, "CA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4505), null, 1, null, "ADUANA CENTRAL DE AVIACION", "A" },
                    { 19, "EA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4506), null, 1, null, "ADUANA EXPRESS AEREO", "A" },
                    { 20, "CG", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4508), null, 1, null, "ADUANA CENTRAL DE GUATEMALA", "T" },
                    { 21, "FP", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4515), null, 1, null, "ADUANA FARDOS POSTALES", "C" },
                    { 22, "S1", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4516), null, 1, null, "ADUANA PUERTO ACAJUTLA", "M" },
                    { 23, "S2", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4518), null, 1, null, "ADUANA PUERTO DE COTUCO", "M" },
                    { 24, "H1", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4520), null, 1, null, "ADUANA PUERTO CORTES", "M" },
                    { 25, "N1", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4521), null, 1, null, "ADUANA PUERTO CORINTO", "M" },
                    { 26, "N2", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4523), null, 1, null, "ADUANA PEÑAS BLANCAS", "T" },
                    { 27, "G1", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4524), null, 1, null, "ADUANA ALMACENADORA INTEGRADA", "T" },
                    { 28, "G2", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4526), null, 1, null, "ADUANA ALMINTER", "T" },
                    { 29, "G3", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4528), null, 1, null, "ADUANA ALPASA", "T" },
                    { 30, "G4", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4529), null, 1, null, "ADUANA ALSERSA", "T" },
                    { 31, "G5", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4531), null, 1, null, "ADUANA CEALSA", "T" },
                    { 32, "G6", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4533), null, 1, null, "ADUANA ALMAGUATE", "T" },
                    { 33, "G7", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4534), null, 1, null, "ADUANA ALCORSA", "T" },
                    { 34, "G8", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4537), null, 1, null, "ADUANA CENTRALSA", "T" },
                    { 35, "H6", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4539), null, 1, null, "ADUANA INTEGRADA CORINTO", "T" },
                    { 36, "H7", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4541), null, 1, null, "ADUANA INTEGRADA AGUA CALIENTE", "T" },
                    { 37, "H8", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4542), null, 1, null, "ADUANA INTEGRADA EL FLORIDO", "T" }
                });

            migrationBuilder.InsertData(
                table: "ImportStatus",
                columns: new[] { "IdImportStatus", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Via", "orden" },
                values: new object[,]
                {
                    { 1, "Ingreso Inicial", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4617), null, 1, null, "M", 1L },
                    { 2, "Entrega de Datos a Digitador", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4620), null, 1, null, "M", 2L },
                    { 3, "Elaborar Póliza", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4622), null, 1, null, "M", 3L },
                    { 4, "Enviar Póliza a Puerto", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4624), null, 1, null, "M", 4L },
                    { 5, "ATC y Aduana", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4625), null, 1, null, "M", 5L },
                    { 6, "Documentos a Transportista", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4628), null, 1, null, "M", 6L },
                    { 7, "Llegada a Fábrica", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4629), null, 1, null, "M", 7L },
                    { 8, "Salida de Fábrica", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4632), null, 1, null, "M", 8L },
                    { 9, "Finalizado", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4633), null, 1, null, "M", 9L },
                    { 10, "Ingreso Inicial", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4636), null, 1, null, "A", 1L },
                    { 11, "Entrega de Datos a Digitador", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4638), null, 1, null, "A", 2L },
                    { 12, "Elaborar Póliza", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4639), null, 1, null, "A", 3L },
                    { 13, "Enviar Póliza Aeropuerto", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4641), null, 1, null, "A", 4L },
                    { 14, "Llegada a Fabrica", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4643), null, 1, null, "A", 5L },
                    { 15, "Finalizado", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4645), null, 1, null, "A", 6L },
                    { 16, "Ingreso Inicial", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4646), null, 1, null, "T", 1L },
                    { 17, "Entrega de Datos a Digitador", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4648), null, 1, null, "T", 2L },
                    { 18, "Elaborar Póliza", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4650), null, 1, null, "T", 3L },
                    { 19, "Enviar Póliza", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4652), null, 1, null, "T", 4L },
                    { 20, "Llegada a Almacenadora", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4653), null, 1, null, "T", 5L },
                    { 21, "Llegada a Fabrica", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4655), null, 1, null, "T", 6L },
                    { 22, "Finalizado", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4656), null, 1, null, "T", 7L },
                    { 23, "Cambio ETA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4658), null, 1, null, "O", 0L },
                    { 24, "Cambio Destino", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4660), null, 1, null, "O", 0L }
                });

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "IdModulo", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9187), null, true, 1, null, "MENÚ PRINCIPAL" },
                    { 2, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9190), null, true, 1, null, "ADMINISTRACIÓN DEL SISTEMA" },
                    { 3, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9192), null, true, 1, null, "IMPORTACIONES" }
                });

            migrationBuilder.InsertData(
                table: "Revisiones",
                columns: new[] { "IdRevision", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod" },
                values: new object[,]
                {
                    { 1, "SGAIA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3829), null, 1, null },
                    { 2, "DIPAFRONT", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3835), null, 1, null },
                    { 3, "MAGA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3836), null, 1, null },
                    { 4, "RAYOS X", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3838), null, 1, null },
                    { 5, "SELECTIVO ROJO", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3839), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRol", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(7207), null, true, 1, null, "Super Admin" },
                    { 2, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(7225), null, true, 1, null, "Digitador Importaciones" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "IdShipper", "Aereo", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Maritimo", "Nombre", "Terrestre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4053), null, 1, null, true, "ANTEX KNITTING MILLS", true },
                    { 2, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4057), null, 1, null, true, "BOHOTEX CO, LTD", true },
                    { 3, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4059), null, 1, null, false, "BROS MACAO COMERCIAL", false },
                    { 4, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4061), null, 1, null, true, "CHAKIM SRL", true },
                    { 5, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4063), null, 1, null, false, "CHINA JUNYE TEXTILE", false },
                    { 6, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4069), null, 1, null, true, "COLOR & TOUCH VINA CO.,LTD", true },
                    { 7, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4071), null, 1, null, false, "DAP AMERICA INC", false },
                    { 8, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4072), null, 1, null, true, "DONGGUAN TEXWINCA", true },
                    { 9, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4074), null, 1, null, true, "HENIX FAR EAST", true },
                    { 10, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4077), null, 1, null, false, "JUNGWOO VINA", false },
                    { 11, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4079), null, 1, null, false, "KAN HIM PIECE", false },
                    { 12, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4081), null, 1, null, false, "KEER AMERICA", false },
                    { 13, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4082), null, 1, null, false, "MAINETTI EASTERN CHINA", false },
                    { 14, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4084), null, 1, null, false, "MANH DAT MANUFACTURE", false },
                    { 15, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4086), null, 1, null, false, "NICE DYEING FACTORY", false },
                    { 16, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4088), null, 1, null, false, "OAK HNI", false },
                    { 17, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4090), null, 1, null, false, "OCEAN NETWORK EXPRESS", false },
                    { 18, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4092), null, 1, null, false, "PACIFIC TEXTILES", false },
                    { 19, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4094), null, 1, null, false, "PARKDALE MILLS", false },
                    { 20, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4097), null, 1, null, false, "PHU BAI SPINNING MILL", false },
                    { 21, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4099), null, 1, null, false, "PT TOKAI TEXPRINT", false },
                    { 22, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4100), null, 1, null, false, "PT. WIN TEXTILE", false },
                    { 23, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4102), null, 1, null, false, "S&H GLOBAL, S.A.", false },
                    { 24, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4104), null, 1, null, false, "SAE-A DOMINICANA", false },
                    { 25, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4106), null, 1, null, false, "SAE-A EINS", false },
                    { 26, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4107), null, 1, null, false, "SAE-A SPINNING, S.A.", false },
                    { 27, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4109), null, 1, null, true, "SAE-A TRADING", true },
                    { 28, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4111), null, 1, null, false, "SAMIL VINA", false },
                    { 29, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4113), null, 1, null, false, "SEJIN SILICONE USA", false },
                    { 30, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4115), null, 1, null, false, "SEWANG VINA", false },
                    { 31, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4116), null, 1, null, false, "SHAOXING QIONGHUA TRADING CO.,LTD", false },
                    { 32, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4118), null, 1, null, false, "SUNG BU VINA", false },
                    { 33, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4120), null, 1, null, false, "SUNGPIL KANG", false },
                    { 34, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4123), null, 1, null, false, "VN JUNGWOO CHINA", false },
                    { 35, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4124), null, 1, null, false, "YAMATO USA", false },
                    { 36, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4127), null, 1, null, false, "YANG JI INTERNATIONAL", false },
                    { 37, true, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4129), null, 1, null, false, "YKK VIETNAM", false },
                    { 38, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4130), null, 1, null, true, "ACHROMA", true },
                    { 39, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4132), null, 1, null, true, "ALVANON HK LTD", true },
                    { 40, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4134), null, 1, null, true, "ALPINE", true },
                    { 41, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4136), null, 1, null, true, "BRAND ID HK", true },
                    { 42, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4137), null, 1, null, true, "BROS EASTERN CO", true },
                    { 43, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4139), null, 1, null, true, "AVERY DENNISON", true },
                    { 44, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4141), null, 1, null, true, "CENTURY INTERNATIONAL", true },
                    { 45, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4142), null, 1, null, true, "BUHLER QUALITY YARNS CORP", true },
                    { 46, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4144), null, 1, null, true, "COLOR SOLUTION", true },
                    { 47, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4146), null, 1, null, true, "CONG TY TNHH", true },
                    { 48, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4148), null, 1, null, true, "CRYSTAL TOWN LIMITED", true },
                    { 49, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4149), null, 1, null, true, "CS CENTRAL AMERICA S.A. DE C.V.", true },
                    { 50, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4151), null, 1, null, true, "DAEIL GAGONG", true },
                    { 51, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4153), null, 1, null, true, "DAESONG LABTECH", true },
                    { 52, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4154), null, 1, null, true, "DATACOLOR TECHNOLOGY", true },
                    { 53, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4157), null, 1, null, true, "DESERT EMPIRE", true },
                    { 54, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4159), null, 1, null, true, "DESICCA, LLCS", true },
                    { 55, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4160), null, 1, null, true, "DETAILTEX", true },
                    { 56, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4162), null, 1, null, true, "DICKS SPORTING", true },
                    { 57, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4164), null, 1, null, true, "DONG HING LABEL", true },
                    { 58, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4165), null, 1, null, true, "DURKOPP ADLER", true },
                    { 59, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4167), null, 1, null, true, "DYSTAR LP DBA COLOR", true },
                    { 60, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4169), null, 1, null, true, "E TEXTINT CORP", true },
                    { 61, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4171), null, 1, null, true, "FAVORABLE TECHNOLOGY", true },
                    { 62, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4172), null, 1, null, true, "EMBSENSE TEXTILE", true },
                    { 63, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4174), null, 1, null, true, "FINE LINE TECHNO", true },
                    { 64, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4176), null, 1, null, true, "EMSIG MANUFACTURING", true },
                    { 65, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4177), null, 1, null, true, "FLASH GLOBAL GSC", true },
                    { 66, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4186), null, 1, null, true, "FRANCIA HELENA YATE", true },
                    { 67, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4188), null, 1, null, true, "FREUDENBERG", true },
                    { 68, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4190), null, 1, null, true, "GAP INTERNATIONAL", true },
                    { 69, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4192), null, 1, null, true, "HASBUN SILHY", true },
                    { 70, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4194), null, 1, null, true, "HANSAE INTERNATIONAL", true },
                    { 72, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4196), null, 1, null, true, "HHH VIETNAM CO LTD", true },
                    { 73, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4198), null, 1, null, true, "INVISIN", true },
                    { 74, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4199), null, 1, null, true, "JD LINK INC", true },
                    { 80, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4201), null, 1, null, true, "KEUN YONG MACHINERY", true },
                    { 81, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4203), null, 1, null, true, "KWIN VIET HAN CO., LTD", true },
                    { 82, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4205), null, 1, null, true, "LECTRA SYSTEMES S,A", true },
                    { 83, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4206), null, 1, null, true, "LONG JIA HAO", true },
                    { 84, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4208), null, 1, null, true, "M TO M COMPORATION", true },
                    { 85, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4209), null, 1, null, true, "MAINETTI VIETNAM", true },
                    { 86, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4211), null, 1, null, true, "MARUWA CO., LTD", true },
                    { 87, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4213), null, 1, null, true, "MEI SHENG ", true },
                    { 88, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4215), null, 1, null, true, "NEMTEX S.A. DE C.V.", true },
                    { 89, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4216), null, 1, null, true, "NEXGEN PACKAGING", true },
                    { 90, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4218), null, 1, null, true, "OAK HNF", true },
                    { 91, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4221), null, 1, null, true, "OCTANES", true },
                    { 92, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4222), null, 1, null, true, "OPTIMER BRANDS", true },
                    { 93, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4224), null, 1, null, true, "ORDELY INDUSTRIAL", true },
                    { 94, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4226), null, 1, null, true, "PAXAR CHINA LIMITED", true },
                    { 95, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4227), null, 1, null, true, "PETTENATI CENTRO", true },
                    { 96, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4354), null, 1, null, true, "PRIDE PERFORMANCE", true },
                    { 97, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4356), null, 1, null, true, "PT ANYTAPE INDO", true },
                    { 98, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4357), null, 1, null, true, "R-PAC VIETNAM", true },
                    { 99, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4359), null, 1, null, true, "S&S INDUSTRIES, S DE R.L", true },
                    { 100, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4361), null, 1, null, true, "SAE A TECHNOTEX", true },
                    { 101, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4363), null, 1, null, true, "SAE-A SPINNING, S.R.L", true },
                    { 102, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4364), null, 1, null, true, "SAE-A TEXTUFIL", true },
                    { 104, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4366), null, 1, null, true, "SAE-A VIETNAM", true },
                    { 105, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4368), null, 1, null, true, "SHINING LABELS", true },
                    { 106, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4370), null, 1, null, true, "SILVER PRINTING", true },
                    { 107, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4371), null, 1, null, true, "SML DOMINICANA", true },
                    { 108, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4374), null, 1, null, true, "SML HONG KONG ", true },
                    { 109, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4375), null, 1, null, true, "SML VIETNAM", true },
                    { 110, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4381), null, 1, null, true, "SOJI COLORWORKS", true },
                    { 111, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4383), null, 1, null, true, "STAPROS INDUSTRIAL", true },
                    { 112, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4384), null, 1, null, true, "SUNLINE", true },
                    { 113, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4386), null, 1, null, true, "SWISSTEX DIRECT", true },
                    { 114, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4388), null, 1, null, true, "SYNIGENCE TRADING", true },
                    { 115, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4390), null, 1, null, true, "TEXHONG ", true },
                    { 116, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4392), null, 1, null, true, "UNITED TEXTILES OF AMERICA S. DE R.L. DE C.V.", true },
                    { 117, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4393), null, 1, null, true, "UTEXA", true },
                    { 118, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4395), null, 1, null, true, "WHA IL VINA", true },
                    { 119, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4397), null, 1, null, true, "WILSON GARMENT", true },
                    { 120, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4398), null, 1, null, true, "ZABIN INDUSTRIES", true },
                    { 121, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4400), null, 1, null, true, "ZHAOQING SHIRFERLY", true },
                    { 122, false, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4402), null, 1, null, true, "ZHEJIANG JIAYE", true }
                });

            migrationBuilder.InsertData(
                table: "Terminales",
                columns: new[] { "IdTerminal", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre", "Via" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4579), null, 1, null, "TCQ", "M" },
                    { 2, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4583), null, 1, null, "TPQ", "M" },
                    { 3, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4584), null, 1, null, "STC", "M" },
                    { 4, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4586), null, 1, null, "PB", "M" },
                    { 5, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4587), null, 1, null, "TEA", "A" },
                    { 6, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4590), null, 1, null, "TCU", "A" },
                    { 7, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(4591), null, 1, null, "TDL", "A" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "IdGrupo", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3632), null, 3, 1, null, "EMPRESA" },
                    { 2, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3638), null, 3, 1, null, "FORWARDER" },
                    { 3, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3640), null, 3, 1, null, "DESTINO" },
                    { 4, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3642), null, 3, 1, null, "MODALIDAD" },
                    { 5, new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3643), null, 3, 1, null, "ALMACENADORA" }
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "IdPermiso", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9222), null, 1, 1, null, "VER.ADMINISTRACION SISTEMA" },
                    { 2, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9226), null, 1, 1, null, "VER.IMPORTACIONES" },
                    { 11, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9227), null, 2, 1, null, "VER.USUARIOS" },
                    { 12, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9229), null, 2, 1, null, "CREAR.USUARIOS" },
                    { 13, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9230), null, 2, 1, null, "MODIFICAR.USUARIOS" },
                    { 14, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9239), null, 2, 1, null, "ELIMINAR.USUARIOS" },
                    { 15, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9240), null, 2, 1, null, "VER.ROLES" },
                    { 16, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9242), null, 2, 1, null, "CREAR.ROLES" },
                    { 17, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9243), null, 2, 1, null, "MODIFICAR.ROLES" },
                    { 18, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9246), null, 2, 1, null, "ELIMINAR.ROLES" },
                    { 19, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9248), null, 2, 1, null, "VER.PERMISOS" },
                    { 20, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9249), null, 2, 1, null, "CREAR.PERMISOS" },
                    { 21, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9251), null, 2, 1, null, "MODIFICAR.PERMISOS" },
                    { 22, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9252), null, 2, 1, null, "ELIMINAR.PERMISOS" },
                    { 23, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9254), null, 2, 1, null, "VER.MODULOS" },
                    { 24, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9255), null, 2, 1, null, "CREAR.MODULOS" },
                    { 25, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9257), null, 2, 1, null, "MODIFICAR.MODULOS" },
                    { 26, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9261), null, 2, 1, null, "ELIMINAR.MODULOS" },
                    { 27, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9262), null, 3, 1, null, "VER.DASHBOARD" },
                    { 28, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9263), null, 3, 1, null, "VER.MARITIMO" },
                    { 29, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9265), null, 3, 1, null, "CREAR.MARITIMO" },
                    { 30, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9266), null, 3, 1, null, "MODIFICAR.MARITIMO" },
                    { 31, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9268), null, 3, 1, null, "ELIMINAR.MARITIMO" },
                    { 32, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9270), null, 3, 1, null, "VER.AEREO" },
                    { 33, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9271), null, 3, 1, null, "CREAR.AEREO" },
                    { 34, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9272), null, 3, 1, null, "MODIFICAR.AEREO" },
                    { 35, new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9274), null, 3, 1, null, "ELIMINAR.AEREO" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Activo", "Apellidos", "Email", "FechaCreacion", "FechaUltimaMod", "IdRol", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres", "Password", "UserName" },
                values: new object[] { 1, true, "Admin", "sa@sae-a.com", new DateTime(2023, 2, 3, 15, 16, 28, 281, DateTimeKind.Local).AddTicks(9011), null, 1, 1, null, "Super", "aCbg3cCuyX/IGYKYxEc4oKauwDF9jI8HtsOlfN2J8EH8c+iweRHGTm1RgTK1oajSUREQVwNXQ1ttouiZDwL1LZG1WQ9+dVCr", "sa" });

            migrationBuilder.InsertData(
                table: "Nombres",
                columns: new[] { "IdNombre", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdGrupo", "IdUsuarioCreacion", "IdUsuarioMod" },
                values: new object[,]
                {
                    { 1, "SEABOARD", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3681), null, 1, 1, null },
                    { 2, "ONE LINE ", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3684), null, 1, 1, null },
                    { 3, "CROWLEY", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3686), null, 1, 1, null },
                    { 4, "MAERSK", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3688), null, 1, 1, null },
                    { 5, "EVERGREEN", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3689), null, 1, 1, null },
                    { 6, "HYUNDAI", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3692), null, 1, 1, null },
                    { 7, "CHIQUITA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3694), null, 1, 1, null },
                    { 8, "WAN HAI", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3695), null, 1, 1, null },
                    { 9, "HMM GLOBAL", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3697), null, 1, 1, null },
                    { 10, "ATLANTIC", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3700), null, 1, 1, null },
                    { 11, "SEALAND", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3701), null, 1, 1, null },
                    { 12, "CMA CGM", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3703), null, 1, 1, null },
                    { 13, "EXPEDITORS", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3704), null, 1, 1, null },
                    { 14, "YANG MIN", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3706), null, 1, 1, null },
                    { 15, "TRANSPORTES TRANSREYES", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3707), null, 1, 1, null },
                    { 16, "CENTRASERVI S.A. DE C.V", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3709), null, 1, 1, null },
                    { 17, "TRANSPORTES LOS ROBLES", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3710), null, 1, 1, null },
                    { 18, "LOGISTRANS S.A.", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3713), null, 1, 1, null },
                    { 19, "TRANSPORTES VILLEDA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3714), null, 1, 1, null },
                    { 20, "INTERNATIONAL CARGO", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3716), null, 1, 1, null },
                    { 21, "CROWLEY LOGISTIC", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3717), null, 1, 1, null },
                    { 22, "BLUE LOGISTC ", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3719), null, 2, 1, null },
                    { 23, "DHL", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3720), null, 2, 1, null },
                    { 24, "DONGSUE", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3722), null, 2, 1, null },
                    { 25, "AVIANCA ", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3724), null, 2, 1, null },
                    { 26, "TACA INTERNACIONAL", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3725), null, 2, 1, null },
                    { 27, "FEDEX", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3727), null, 2, 1, null },
                    { 28, "BODEGA ACCESORIOS", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3728), null, 3, 1, null },
                    { 29, "BODEGA DE STOCKS", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3730), null, 3, 1, null },
                    { 30, "BODEGA DE HILO PALIN", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3732), null, 3, 1, null },
                    { 31, "CENTEXSA 2", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3733), null, 3, 1, null },
                    { 32, "HANAH TRADING", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3735), null, 3, 1, null },
                    { 33, "CENTEXSA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3737), null, 3, 1, null },
                    { 34, "JS TEXTILES", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3739), null, 3, 1, null },
                    { 35, "J.W.TEXTILES", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3741), null, 3, 1, null },
                    { 36, "JJ TRADING", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3742), null, 3, 1, null },
                    { 37, "K&H", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3744), null, 3, 1, null },
                    { 38, "KNITOPIA , S.A.", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3745), null, 3, 1, null },
                    { 39, "KOA MODAS", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3747), null, 3, 1, null },
                    { 40, "K.P TEXTILE", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3748), null, 3, 1, null },
                    { 41, "PANTEX", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3750), null, 3, 1, null },
                    { 42, "S&G", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3751), null, 3, 1, null },
                    { 43, "SAE-A TEXPIA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3753), null, 3, 1, null },
                    { 44, "SAE-A TEXPIA 2", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3754), null, 3, 1, null },
                    { 45, "SAE-A TEXPÍA 3", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3756), null, 3, 1, null },
                    { 46, "TEXSION", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3758), null, 3, 1, null },
                    { 47, "TEXTILES CHANG WOO", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3759), null, 3, 1, null },
                    { 48, "WINNERS", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3761), null, 3, 1, null },
                    { 49, "MI", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3763), null, 4, 1, null },
                    { 50, "ID", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3765), null, 4, 1, null },
                    { 51, "MA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3767), null, 4, 1, null },
                    { 52, "DV", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3769), null, 4, 1, null },
                    { 53, "DI", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3770), null, 4, 1, null },
                    { 54, "MQ", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3772), null, 4, 1, null },
                    { 55, "DS", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3774), null, 4, 1, null },
                    { 56, "ALMAGUATE", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3776), null, 5, 1, null },
                    { 57, "ALSERSA", new DateTime(2023, 2, 3, 15, 16, 28, 282, DateTimeKind.Local).AddTicks(3778), null, 5, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PermisoRol",
                columns: new[] { "PermisosIdPermiso", "RolesIdRol" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
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
                    { 27, 2 },
                    { 28, 1 },
                    { 28, 2 },
                    { 29, 1 },
                    { 30, 1 },
                    { 30, 2 },
                    { 31, 1 },
                    { 32, 1 },
                    { 32, 2 },
                    { 33, 1 },
                    { 34, 1 },
                    { 34, 2 },
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
                name: "IX_Importaciones_IdImportStatus",
                table: "Importaciones",
                column: "IdImportStatus");

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
                name: "IX_ImportHistorial_IdImport",
                table: "ImportHistorial",
                column: "IdImport");

            migrationBuilder.CreateIndex(
                name: "IX_ImportHistorial_IdImportStatus",
                table: "ImportHistorial",
                column: "IdImportStatus");

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
                name: "ImportHistorial");

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
                name: "ImportStatus");

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
