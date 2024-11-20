using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AdminImport : Migration
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

            migrationBuilder.CreateTable(
                name: "ImportStatus",
                columns: table => new
                {
                    IdImportStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orden = table.Column<long>(type: "bigint", nullable: false),
                    Via = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ultimo = table.Column<bool>(type: "bit", nullable: false),
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
                    TiempoLibre = table.Column<int>(type: "int", nullable: false),
                    Demora = table.Column<int>(type: "int", nullable: false),
                    ValorDiaExtraTL = table.Column<decimal>(type: "money", nullable: false),
                    ValorDiaExtraD = table.Column<decimal>(type: "money", nullable: false),
                    IdTerminal = table.Column<int>(type: "int", nullable: true),
                    IdAduana = table.Column<int>(type: "int", nullable: true),
                    IdAlmacenadora = table.Column<int>(type: "int", nullable: true),
                    Consolidado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdImportStatus = table.Column<int>(type: "int", nullable: false),
                    DocOriginales = table.Column<bool>(type: "bit", nullable: false),
                    IdAgente = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "IdAduana");
                    table.ForeignKey(
                        name: "FK_Importaciones_Agentes_IdAgente",
                        column: x => x.IdAgente,
                        principalTable: "Agentes",
                        principalColumn: "IdAgente");
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
                    IdPago = table.Column<int>(type: "int", nullable: true),
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
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IdModalidad = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "IdNombre");
                });

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

            migrationBuilder.InsertData(
                table: "Aduanas",
                columns: ["IdAduana", "Abreviatura", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre", "Via"],
                values: new object[,]
                {
                    { 1, "ST", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3269), null, 1, null, "ADUANA SANTO TOMAS DE CASTILLA", "M" },
                    { 2, "PQ", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3273), null, 1, null, "ADUANA PUERTO QUETZAL", "M" },
                    { 3, "PB", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3274), null, 1, null, "ADUANA PUERTO BARRIOS", "M" },
                    { 4, "TU", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3276), null, 1, null, "ADUANA TECUN UMAN", "T" },
                    { 5, "EC", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3278), null, 1, null, "ADUANA EL CARMEN", "T" },
                    { 6, "LM", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3280), null, 1, null, "ADUANA LA MESILLA", "T" },
                    { 7, "MM", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3282), null, 1, null, "ADUANA MELCHOR DE MENCOS", "T" },
                    { 8, "EF", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3284), null, 1, null, "ADUANA EL FLORIDO", "T" },
                    { 9, "AV", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3285), null, 1, null, "ADUANA DE VEHICULOS", "T" },
                    { 10, "CH", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3289), null, 1, null, "ADUANA CHAMPERICO", "M" },
                    { 11, "PA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3290), null, 1, null, "ADUANA PEDRO DE ALVARADO", "T" },
                    { 12, "VN", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3292), null, 1, null, "ADUANA VALLE NUEVO", "T" },
                    { 13, "SC", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3294), null, 1, null, "ADUANA SAN CRISTOBAL", "T" },
                    { 14, "AC", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3295), null, 1, null, "ADUANA AGUA CALIENTE", "T" },
                    { 15, "LE", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3297), null, 1, null, "ADUANA LA ERMITA", "T" },
                    { 16, "CB", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3298), null, 1, null, "ADUANA EL CEIBO", "T" },
                    { 17, "SE", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3300), null, 1, null, "ADUANA SANTA ELENA", "A" },
                    { 18, "CA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3303), null, 1, null, "ADUANA CENTRAL DE AVIACION", "A" },
                    { 19, "EA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3304), null, 1, null, "ADUANA EXPRESS AEREO", "A" },
                    { 20, "CG", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3306), null, 1, null, "ADUANA CENTRAL DE GUATEMALA", "T" },
                    { 21, "FP", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3308), null, 1, null, "ADUANA FARDOS POSTALES", "C" },
                    { 22, "S1", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3309), null, 1, null, "ADUANA PUERTO ACAJUTLA", "M" },
                    { 23, "S2", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3311), null, 1, null, "ADUANA PUERTO DE COTUCO", "M" },
                    { 24, "H1", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3313), null, 1, null, "ADUANA PUERTO CORTES", "M" },
                    { 25, "N1", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3314), null, 1, null, "ADUANA PUERTO CORINTO", "M" },
                    { 26, "N2", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3316), null, 1, null, "ADUANA PEÑAS BLANCAS", "T" },
                    { 27, "G1", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3318), null, 1, null, "ADUANA ALMACENADORA INTEGRADA", "T" },
                    { 28, "G2", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3320), null, 1, null, "ADUANA ALMINTER", "T" },
                    { 29, "G3", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3329), null, 1, null, "ADUANA ALPASA", "T" },
                    { 30, "G4", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3330), null, 1, null, "ADUANA ALSERSA", "T" },
                    { 31, "G5", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3332), null, 1, null, "ADUANA CEALSA", "T" },
                    { 32, "G6", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3333), null, 1, null, "ADUANA ALMAGUATE", "T" },
                    { 33, "G7", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3335), null, 1, null, "ADUANA ALCORSA", "T" },
                    { 34, "G8", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3338), null, 1, null, "ADUANA CENTRALSA", "T" },
                    { 35, "H6", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3339), null, 1, null, "ADUANA INTEGRADA CORINTO", "T" },
                    { 36, "H7", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3341), null, 1, null, "ADUANA INTEGRADA AGUA CALIENTE", "T" },
                    { 37, "H8", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3342), null, 1, null, "ADUANA INTEGRADA EL FLORIDO", "T" }
                });

            migrationBuilder.InsertData(
                table: "Agentes",
                columns: ["IdAgente", "Activo", "Apellidos", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres"],
                values: new object[,]
                {
                    { 172, true, "FERNANDEZ RENTERIA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3502), null, 1, null, "CESAR" },
                    { 251, true, "TOLEDO CANCINO", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3506), null, 1, null, "MARCO AURELIO" },
                    { 264, true, "ARDÓN ALARCÓN", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3509), null, 1, null, "DANIEL ABILIO" },
                    { 272, true, "PAZ MORÁN", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3507), null, 1, null, "JORGE LUIS" },
                    { 282, true, "JUAREZ ORTIZ", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3511), null, 1, null, "JORGE LUIS" },
                    { 296, true, "VILLEDA AGUILAR", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3513), null, 1, null, "WALTER VINICIO" },
                    { 312, true, "VIELMANN GIRON", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3522), null, 1, null, "OSCAR ALFONSO" },
                    { 322, true, "VELASQUEZ VISQUERRA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3524), null, 1, null, "SERGIO RODOLFO" },
                    { 340, true, "DUARTE", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3526), null, 1, null, "YADIRA" },
                    { 346, true, "VIELMANN ALDANA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3528), null, 1, null, "JOANNA NAYARITH" },
                    { 349, true, "MARROQUIN VELIZ", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3530), null, 1, null, "ELVIA LETICIA" },
                    { 372, true, "DEL ÁGUILA CHIGUICHON", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3532), null, 1, null, "ELMER ARNOLDO" },
                    { 375, true, "DERAS ORTEGA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3533), null, 1, null, "RODRIGO" },
                    { 379, true, "MATA CABRERA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3663), null, 1, null, "ALEJANDRA ISABEL" }
                });

            migrationBuilder.InsertData(
                table: "ImportStatus",
                columns: ["IdImportStatus", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Via", "orden", "ultimo"],
                values: new object[,]
                {
                    { 1, "Ingreso Inicial", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3421), null, 1, null, "M", 1L, false },
                    { 2, "Entrega de Datos a Digitador", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3425), null, 1, null, "M", 2L, false },
                    { 3, "Elaborar Póliza", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3427), null, 1, null, "M", 3L, false },
                    { 4, "Enviar Póliza a Puerto", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3429), null, 1, null, "M", 4L, false },
                    { 5, "Salida de Puerto", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3430), null, 1, null, "M", 5L, false },
                    { 6, "ATC y Aduana", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3433), null, 1, null, "M", 6L, false },
                    { 7, "Documentos a Transportista", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3434), null, 1, null, "M", 7L, false },
                    { 8, "Llegada a Fábrica", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3436), null, 1, null, "M", 8L, false },
                    { 9, "Salida de Fábrica", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3438), null, 1, null, "M", 9L, false },
                    { 10, "Finalizado", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3440), null, 1, null, "M", 10L, true },
                    { 11, "Ingreso Inicial", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3442), null, 1, null, "A", 1L, false },
                    { 12, "Entrega de Datos a Digitador", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3444), null, 1, null, "A", 2L, false },
                    { 13, "Elaborar Póliza", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3446), null, 1, null, "A", 3L, false },
                    { 14, "Enviar Póliza Aeropuerto", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3447), null, 1, null, "A", 4L, false },
                    { 15, "Llegada a Fabrica", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3449), null, 1, null, "A", 5L, false },
                    { 16, "Finalizado", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3451), null, 1, null, "A", 6L, true },
                    { 17, "Ingreso Inicial", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3453), null, 1, null, "T", 1L, false },
                    { 18, "Entrega de Datos a Digitador", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3455), null, 1, null, "T", 2L, false },
                    { 19, "Elaborar Póliza", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3457), null, 1, null, "T", 3L, false },
                    { 20, "Enviar Póliza", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3459), null, 1, null, "T", 4L, false },
                    { 21, "Llegada a Almacenadora", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3460), null, 1, null, "T", 5L, false },
                    { 22, "Llegada a Fabrica", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3462), null, 1, null, "T", 6L, false },
                    { 23, "Finalizado", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3464), null, 1, null, "T", 7L, true },
                    { 24, "Cambio ETA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3465), null, 1, null, "O", 0L, false },
                    { 25, "Cambio Destino", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3467), null, 1, null, "O", 0L, false },
                    { 26, "Ingreso de Montos Gastados", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3469), null, 1, null, "O", 0L, false },
                    { 27, "Comentario", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3470), null, 1, null, "O", 0L, false }
                });

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: ["IdModulo", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre"],
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5924), null, true, 1, null, "MENÚ PRINCIPAL" },
                    { 2, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5927), null, true, 1, null, "ADMINISTRACIÓN DEL SISTEMA" },
                    { 3, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5929), null, true, 1, null, "IMPORTACIONES" }
                });

            migrationBuilder.InsertData(
                table: "Revisiones",
                columns: ["IdRevision", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod"],
                values: new object[,]
                {
                    { 1, "SGAIA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2930), null, 1, null },
                    { 2, "DIPAFRONT", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2934), null, 1, null },
                    { 3, "MAGA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2935), null, 1, null },
                    { 4, "RAYOS X", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2937), null, 1, null },
                    { 5, "SELECTIVO ROJO", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2939), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: ["IdRol", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre"],
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5005), null, true, 1, null, "Super Admin" },
                    { 2, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5025), null, true, 1, null, "Digitador Importaciones" },
                    { 3, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5026), null, true, 1, null, "Creador Importaciones" },
                    { 4, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5028), null, true, 1, null, "Admin Importaciones" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: ["IdShipper", "Aereo", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Maritimo", "Nombre", "Terrestre"],
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2971), null, 1, null, true, "ANTEX KNITTING MILLS", true },
                    { 2, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2974), null, 1, null, true, "BOHOTEX CO, LTD", true },
                    { 3, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2976), null, 1, null, true, "BROS MACAO COMERCIAL ", false },
                    { 4, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2978), null, 1, null, true, "CHAKIM SRL", true },
                    { 5, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2979), null, 1, null, true, "CHINA JUNYE TEXTILE", false },
                    { 6, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2982), null, 1, null, true, "COLOR & TOUCH VINA CO.,LTD", true },
                    { 7, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2984), null, 1, null, true, "DAP AMERICA INC", false },
                    { 8, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2986), null, 1, null, true, "DONGGUAN TEXWINCA", true },
                    { 9, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2987), null, 1, null, true, "HENIX FAR EAST", true },
                    { 10, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2990), null, 1, null, true, "JUNGWOO VINA", false },
                    { 11, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2992), null, 1, null, true, "KAN HIM PIECE", false },
                    { 12, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2993), null, 1, null, true, "KEER AMERICA", false },
                    { 13, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2995), null, 1, null, true, "MAINETTI EASTERN CHINA", false },
                    { 14, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2997), null, 1, null, true, "MANH DAT MANUFACTURE", false },
                    { 15, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2999), null, 1, null, true, "NICE DYEING FACTORY", false },
                    { 16, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3001), null, 1, null, true, "OAK HNI", false },
                    { 17, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3003), null, 1, null, true, "OCEAN NETWORK EXPRESS", false },
                    { 18, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3005), null, 1, null, true, "PACIFIC TEXTILES", false },
                    { 19, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3007), null, 1, null, true, "PARKDALE MILLS", false },
                    { 20, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3008), null, 1, null, true, "PHU BAI SPINNING MILL", false },
                    { 21, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3010), null, 1, null, true, "PT TOKAI TEXPRINT", false },
                    { 22, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3012), null, 1, null, true, "PT. WIN TEXTILE", false },
                    { 23, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3014), null, 1, null, true, "S&H GLOBAL, S.A.", false },
                    { 24, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3015), null, 1, null, true, "SAE-A DOMINICANA", false },
                    { 25, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3017), null, 1, null, true, "SAE-A EINS", false },
                    { 26, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3019), null, 1, null, true, "SAE-A SPINNING, S.A.", false },
                    { 27, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3020), null, 1, null, true, "SAE-A TRADING", true },
                    { 28, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3022), null, 1, null, true, "SAMIL VINA", false },
                    { 29, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3024), null, 1, null, true, "SEJIN SILICONE USA", false },
                    { 30, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3025), null, 1, null, true, "SEWANG VINA", false },
                    { 31, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3027), null, 1, null, true, "SHAOXING QIONGHUA TRADING CO.,LTD", false },
                    { 32, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3030), null, 1, null, true, "SUNG BU VINA", false },
                    { 33, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3032), null, 1, null, true, "SUNGPIL KANG", false },
                    { 34, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3034), null, 1, null, true, "VN JUNGWOO CHINA", false },
                    { 35, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3036), null, 1, null, true, "YAMATO USA", false },
                    { 36, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3038), null, 1, null, true, "YANG JI INTERNATIONAL", false },
                    { 37, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3040), null, 1, null, true, "YKK VIETNAM", false },
                    { 38, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3041), null, 1, null, false, "DETAILTEX", true },
                    { 39, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3043), null, 1, null, false, "DICKS SPORTING", true },
                    { 40, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3045), null, 1, null, false, "DONG HING LABEL", true },
                    { 41, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3046), null, 1, null, false, "DURKOPP ADLER", true },
                    { 42, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3048), null, 1, null, false, "DYSTAR LP DBA COLOR", true },
                    { 43, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3050), null, 1, null, false, "E TEXTINT CORP", true },
                    { 44, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3051), null, 1, null, false, "FAVORABLE TECHNOLOGY", true },
                    { 45, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3053), null, 1, null, false, "EMBSENSE TEXTILE", true },
                    { 46, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3055), null, 1, null, false, "FINE LINE TECHNO", true },
                    { 47, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3056), null, 1, null, false, "EMSIG MANUFACTURING", true },
                    { 48, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3060), null, 1, null, false, "FLASH GLOBAL GSC", true },
                    { 49, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3061), null, 1, null, false, "FRANCIA HELENA YATE", true },
                    { 50, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3063), null, 1, null, false, "FREUDENBERG", true },
                    { 51, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3065), null, 1, null, false, "GAP INTERNATIONAL", true },
                    { 52, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3066), null, 1, null, false, "HASBUN SILHY", true },
                    { 53, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3068), null, 1, null, false, "HANSAE INTERNATIONAL", true },
                    { 55, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3070), null, 1, null, false, "HHH VIETNAM CO LTD", true },
                    { 56, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3071), null, 1, null, false, "INVISIN", true },
                    { 57, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3073), null, 1, null, false, "JD LINK INC", true },
                    { 63, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3075), null, 1, null, false, "KEUN YONG MACHINERY", true },
                    { 64, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3077), null, 1, null, false, "KWIN VIET HAN CO., LTD", true },
                    { 65, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3079), null, 1, null, false, "LECTRA SYSTEMES S,A", true },
                    { 66, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3081), null, 1, null, false, "LONG JIA HAO", true },
                    { 67, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3082), null, 1, null, false, "M TO M COMPORATION", true },
                    { 68, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3084), null, 1, null, false, "MAINETTI VIETNAM", true },
                    { 69, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3086), null, 1, null, false, "MARUWA CO., LTD", true },
                    { 70, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3088), null, 1, null, false, "MEI SHENG ", true },
                    { 71, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3090), null, 1, null, false, "NEMTEX S.A. DE C.V.", true },
                    { 72, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3093), null, 1, null, false, "NEXGEN PACKAGING", true },
                    { 73, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3094), null, 1, null, false, "OAK HNF", true },
                    { 74, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3096), null, 1, null, false, "OCTANES", true },
                    { 75, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3098), null, 1, null, false, "OPTIMER BRANDS", true },
                    { 76, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3099), null, 1, null, false, "ORDELY INDUSTRIAL", true },
                    { 77, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3101), null, 1, null, false, "PAXAR CHINA LIMITED", true },
                    { 78, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3103), null, 1, null, false, "PETTENATI CENTRO", true },
                    { 79, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3104), null, 1, null, false, "PRIDE PERFORMANCE", true },
                    { 80, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3106), null, 1, null, false, "PT ANYTAPE INDO", true },
                    { 81, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3108), null, 1, null, false, "R-PAC VIETNAM", true },
                    { 82, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3109), null, 1, null, false, "S&S INDUSTRIES, S DE R.L", true },
                    { 83, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3111), null, 1, null, false, "SAE A TECHNOTEX", true },
                    { 84, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3113), null, 1, null, false, "SAE-A SPINNING, S.R.L", true },
                    { 85, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3121), null, 1, null, false, "SAE-A TEXTUFIL", true },
                    { 87, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3123), null, 1, null, false, "SAE-A VIETNAM", true },
                    { 88, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3124), null, 1, null, false, "SHINING LABELS", true },
                    { 89, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3126), null, 1, null, false, "SILVER PRINTING", true },
                    { 90, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3128), null, 1, null, false, "SML DOMINICANA", true },
                    { 91, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3129), null, 1, null, false, "SML HONG KONG ", true },
                    { 92, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3131), null, 1, null, false, "SML VIETNAM", true },
                    { 93, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3133), null, 1, null, false, "SOJI COLORWORKS", true },
                    { 94, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3135), null, 1, null, false, "STAPROS INDUSTRIAL", true },
                    { 95, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3136), null, 1, null, false, "SUNLINE", true },
                    { 96, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3138), null, 1, null, false, "SWISSTEX DIRECT", true },
                    { 97, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3139), null, 1, null, false, "SYNIGENCE TRADING", true },
                    { 98, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3141), null, 1, null, false, "TEXHONG ", true },
                    { 99, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3143), null, 1, null, false, "UNITED TEXTILES OF AMERICA S. DE R.L. DE C.V.", true },
                    { 100, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3145), null, 1, null, false, "UTEXA", true },
                    { 101, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3147), null, 1, null, false, "WHA IL VINA", true },
                    { 102, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3148), null, 1, null, false, "WILSON GARMENT", true },
                    { 103, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3151), null, 1, null, false, "ZABIN INDUSTRIES", true },
                    { 104, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3155), null, 1, null, false, "ZHAOQING SHIRFERLY", true },
                    { 105, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3156), null, 1, null, false, "ZHEJIANG JIAYE", true },
                    { 106, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3158), null, 1, null, false, "ALVANON HK LTD", true },
                    { 107, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3160), null, 1, null, false, "ALPINE", true },
                    { 108, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3161), null, 1, null, false, "BRAND ID HK", true },
                    { 109, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3163), null, 1, null, false, "BROS EASTERN CO", true },
                    { 110, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3165), null, 1, null, false, "AVERY DENNISON", true },
                    { 111, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3166), null, 1, null, false, "CENTURY INTERNATIONAL", true },
                    { 113, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3168), null, 1, null, false, "COLOR SOLUTION", true },
                    { 114, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3169), null, 1, null, false, "CONG TY TNHH", true },
                    { 115, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3171), null, 1, null, false, "CRYSTAL TOWN LIMITED", true },
                    { 116, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3173), null, 1, null, false, "CS CENTRAL AMERICA S.A. DE C.V.   ", true },
                    { 117, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3174), null, 1, null, false, "DAEIL GAGONG", true },
                    { 118, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3176), null, 1, null, false, "DAESONG LABTECH", true },
                    { 119, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3178), null, 1, null, false, "DATACOLOR TECHNOLOGY", true },
                    { 120, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3179), null, 1, null, false, "DESERT EMPIRE", true },
                    { 121, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3182), null, 1, null, false, "DESICCA, LLCS", true },
                    { 122, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3184), null, 1, null, true, "SUZHOU SHENGHONG FIBER CO., LTD", false },
                    { 123, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3185), null, 1, null, true, "BUHLER QUALITY YARNS CORP", true },
                    { 124, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3187), null, 1, null, true, "SAMIL VINA CO., LTD", false },
                    { 125, false, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3188), null, 1, null, true, "SHAOXING KEQIAO", false },
                    { 126, true, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3190), null, 1, null, false, "ACHROMA", true }
                });

            migrationBuilder.InsertData(
                table: "Terminales",
                columns: ["IdTerminal", "FechaCreacion", "FechaUltimaMod", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre", "Via"],
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3383), null, 1, null, "TCQ", "M" },
                    { 2, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3386), null, 1, null, "TPQ", "M" },
                    { 3, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3388), null, 1, null, "STC", "M" },
                    { 4, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3390), null, 1, null, "PB", "M" },
                    { 5, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3391), null, 1, null, "TEA", "A" },
                    { 6, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3393), null, 1, null, "TCU", "A" },
                    { 7, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(3396), null, 1, null, "TDL", "A" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: ["IdGrupo", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre"],
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2728), null, 3, 1, null, "EMPRESA" },
                    { 2, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2735), null, 3, 1, null, "FORWARDER" },
                    { 3, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2738), null, 3, 1, null, "DESTINO" },
                    { 4, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2739), null, 3, 1, null, "MODALIDAD" },
                    { 5, new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2741), null, 3, 1, null, "ALMACENADORA" }
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: ["IdPermiso", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre"],
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5960), null, 1, 1, null, "VER.ADMINISTRACION SISTEMA" },
                    { 2, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5963), null, 1, 1, null, "VER.IMPORTACIONES" },
                    { 11, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5966), null, 2, 1, null, "VER.USUARIOS" },
                    { 12, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5967), null, 2, 1, null, "CREAR.USUARIOS" },
                    { 13, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5969), null, 2, 1, null, "MODIFICAR.USUARIOS" },
                    { 14, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5972), null, 2, 1, null, "ELIMINAR.USUARIOS" },
                    { 15, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5974), null, 2, 1, null, "VER.ROLES" },
                    { 16, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5976), null, 2, 1, null, "CREAR.ROLES" },
                    { 17, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5977), null, 2, 1, null, "MODIFICAR.ROLES" },
                    { 18, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5980), null, 2, 1, null, "ELIMINAR.ROLES" },
                    { 19, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5981), null, 2, 1, null, "VER.PERMISOS" },
                    { 20, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5983), null, 2, 1, null, "CREAR.PERMISOS" },
                    { 21, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5985), null, 2, 1, null, "MODIFICAR.PERMISOS" },
                    { 22, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5995), null, 2, 1, null, "ELIMINAR.PERMISOS" },
                    { 23, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5996), null, 2, 1, null, "VER.MODULOS" },
                    { 24, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5998), null, 2, 1, null, "CREAR.MODULOS" },
                    { 25, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5999), null, 2, 1, null, "MODIFICAR.MODULOS" },
                    { 26, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6002), null, 2, 1, null, "ELIMINAR.MODULOS" },
                    { 27, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6003), null, 3, 1, null, "VER.DASHBOARD" },
                    { 28, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6005), null, 3, 1, null, "VER.MARITIMO" },
                    { 29, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6006), null, 3, 1, null, "CREAR.MARITIMO" },
                    { 30, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6008), null, 3, 1, null, "MODIFICAR.MARITIMO" },
                    { 31, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6009), null, 3, 1, null, "ELIMINAR.MARITIMO" },
                    { 32, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6011), null, 3, 1, null, "VER.AEREO" },
                    { 33, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6012), null, 3, 1, null, "CREAR.AEREO" },
                    { 34, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6014), null, 3, 1, null, "MODIFICAR.AEREO" },
                    { 35, new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(6015), null, 3, 1, null, "ELIMINAR.AEREO" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: ["IdUsuario", "Activo", "Apellidos", "Email", "FechaCreacion", "FechaUltimaMod", "IdRol", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres", "Password", "UserName"],
                values: new object[,]
                {
                    { 1, true, "Admin", "sa@sae-a.com", new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5532), null, 1, 1, null, "Super", "Gx/QbJFMiYuRQmL0Xgj17890oqwfkS2JbGdNiK2/GvTMKMMpPiIC47rNVQxZrWrtrhzaN+6bhD8RDKR6fFoNC0bkHuPN1oqK7CK956x1VQ==", "sa" },
                    { 2, true, "Tobar Soto", "briansoto19@sae-a.com", new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5798), null, 3, 1, null, "Brian Aaron", "X8VOAmZVn2RXsv3WPx0zhN3TfKMVmz2AhQlxzrxrpzneyKoDIKrlnXd0wxeia4SaijKevTh5naBt1B3bNEwekJ3ta08=", "btobar" },
                    { 3, true, "Ajcuc Subuyuj", "walter277@sae-a.com", new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5831), null, 2, 1, null, "Walter Antonio", "OhSMEXVZf/HIv866w572s/+/YPQbQK5MK7/fgQ0taSCDUud5IRJypR9bHUO0n6y4aJ5wtyoyhclEq2rcord7CC9LmuPcLQ==", "wajcuc" },
                    { 4, true, "Espinoza Lopez", "sergio.e63@sae-a.com", new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5858), null, 2, 1, null, "Sergio Esteban", "bQmcajqjFAYxpLgYUSjoEk1Q3JxMyGDPipJ2MHxzZmNWCSLSfh6eFVK3kudyKSJH/kJQ2wEO2WEKFJG396po3hOM+E+4tUj2SuIZEMw=", "sespinoza" },
                    { 5, true, "Martínez Ticun", "luis@sae-a.com", new DateTime(2023, 3, 10, 9, 34, 54, 428, DateTimeKind.Local).AddTicks(5887), null, 4, 1, null, "Luis Gilberto", "Q+BKdD3DvTLoVaSB7JXaI4KESr0J6XT+eCHPyVyWD2rnRR9+wBvG7uVfuxizlOBVddoObzPLrZiE74EV7dEwZNS8nKs1", "lmartinez" }
                });

            migrationBuilder.InsertData(
                table: "Nombres",
                columns: ["IdNombre", "Descripcion", "FechaCreacion", "FechaUltimaMod", "IdGrupo", "IdUsuarioCreacion", "IdUsuarioMod"],
                values: new object[,]
                {
                    { 1, "SEABOARD", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2787), null, 1, 1, null },
                    { 2, "ONE LINE ", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2790), null, 1, 1, null },
                    { 3, "CROWLEY", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2792), null, 1, 1, null },
                    { 4, "MAERSK", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2794), null, 1, 1, null },
                    { 5, "EVERGREEN", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2795), null, 1, 1, null },
                    { 6, "HYUNDAI", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2798), null, 1, 1, null },
                    { 7, "CHIQUITA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2800), null, 1, 1, null },
                    { 8, "WAN HAI", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2802), null, 1, 1, null },
                    { 9, "HMM GLOBAL", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2804), null, 1, 1, null },
                    { 10, "ATLANTIC", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2806), null, 1, 1, null },
                    { 11, "SEALAND", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2808), null, 1, 1, null },
                    { 12, "CMA CGM", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2809), null, 1, 1, null },
                    { 13, "EXPEDITORS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2811), null, 1, 1, null },
                    { 14, "YANG MIN", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2812), null, 1, 1, null },
                    { 15, "TRANSPORTES TRANSREYES", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2814), null, 1, 1, null },
                    { 16, "CENTRASERVI S.A. DE C.V", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2815), null, 1, 1, null },
                    { 17, "TRANSPORTES LOS ROBLES", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2817), null, 1, 1, null },
                    { 18, "LOGISTRANS S.A.", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2819), null, 1, 1, null },
                    { 19, "TRANSPORTES VILLEDA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2821), null, 1, 1, null },
                    { 20, "INTERNATIONAL CARGO", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2822), null, 1, 1, null },
                    { 21, "CROWLEY LOGISTIC", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2823), null, 1, 1, null },
                    { 22, "BLUE LOGISTIC", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2825), null, 2, 1, null },
                    { 23, "DHL", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2826), null, 2, 1, null },
                    { 24, "DONGSUE", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2828), null, 2, 1, null },
                    { 25, "AVIANCA ", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2829), null, 2, 1, null },
                    { 26, "TACA INTERNACIONAL", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2832), null, 2, 1, null },
                    { 27, "FEDEX", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2833), null, 2, 1, null },
                    { 28, "BODEGA ACCESORIOS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2835), null, 3, 1, null },
                    { 29, "BODEGA DE STOCKS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2836), null, 3, 1, null },
                    { 30, "BODEGA DE HILO PALIN", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2838), null, 3, 1, null },
                    { 31, "CENTEXSA 2", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2840), null, 3, 1, null },
                    { 32, "HANAH TRADING", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2841), null, 3, 1, null },
                    { 33, "CENTEXSA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2844), null, 3, 1, null },
                    { 34, "JS TEXTILES", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2847), null, 3, 1, null },
                    { 35, "J.W.TEXTILES", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2848), null, 3, 1, null },
                    { 36, "JJ TRADING", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2850), null, 3, 1, null },
                    { 37, "K&H", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2851), null, 3, 1, null },
                    { 38, "KNITOPIA , S.A.", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2853), null, 3, 1, null },
                    { 39, "KOA MODAS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2854), null, 3, 1, null },
                    { 40, "K.P TEXTILE", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2856), null, 3, 1, null },
                    { 41, "PANTEX", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2857), null, 3, 1, null },
                    { 42, "S&G", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2859), null, 3, 1, null },
                    { 43, "SAE-A TEXPIA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2860), null, 3, 1, null },
                    { 44, "SAE-A TEXPIA 2", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2862), null, 3, 1, null },
                    { 45, "SAE-A TEXPÍA 3", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2864), null, 3, 1, null },
                    { 46, "TEXSION", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2865), null, 3, 1, null },
                    { 47, "TEXTILES CHANG WOO", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2867), null, 3, 1, null },
                    { 48, "WINNERS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2868), null, 3, 1, null },
                    { 49, "MI", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2870), null, 4, 1, null },
                    { 50, "ID", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2871), null, 4, 1, null },
                    { 51, "MA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2873), null, 4, 1, null },
                    { 52, "DV", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2874), null, 4, 1, null },
                    { 53, "DI", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2876), null, 4, 1, null },
                    { 54, "MQ", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2877), null, 4, 1, null },
                    { 55, "DS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2879), null, 4, 1, null },
                    { 56, "ALMAGUATE", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2880), null, 5, 1, null },
                    { 57, "ALSERSA", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2882), null, 5, 1, null },
                    { 58, "HAPAG-LLOYD", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2883), null, 1, 1, null },
                    { 59, "EXPEDITORS", new DateTime(2023, 3, 10, 9, 34, 54, 429, DateTimeKind.Local).AddTicks(2885), null, 2, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PermisoRol",
                columns: ["PermisosIdPermiso", "RolesIdRol"],
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
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
                    { 27, 3 },
                    { 27, 4 },
                    { 28, 1 },
                    { 28, 2 },
                    { 28, 3 },
                    { 28, 4 },
                    { 29, 1 },
                    { 29, 3 },
                    { 29, 4 },
                    { 30, 1 },
                    { 30, 2 },
                    { 30, 3 },
                    { 30, 4 },
                    { 31, 1 },
                    { 31, 4 },
                    { 32, 1 },
                    { 32, 2 },
                    { 32, 3 },
                    { 32, 4 },
                    { 33, 1 },
                    { 33, 3 },
                    { 33, 4 },
                    { 34, 1 },
                    { 34, 2 },
                    { 34, 3 },
                    { 34, 4 },
                    { 35, 1 },
                    { 35, 4 }
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
                name: "IX_Importaciones_IdAgente",
                table: "Importaciones",
                column: "IdAgente");

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
                name: "IX_Nombres_Descripcion_IdGrupo",
                table: "Nombres",
                columns: ["Descripcion", "IdGrupo"],
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nombres_IdGrupo",
                table: "Nombres",
                column: "IdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdContenedor",
                table: "Pagos",
                column: "IdContenedor",
                unique: true);

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
                name: "ImportacionRevision");

            migrationBuilder.DropTable(
                name: "ImportHistorial");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "PermisoRol");

            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Terminales");

            migrationBuilder.DropTable(
                name: "Revisiones");

            migrationBuilder.DropTable(
                name: "Contenedores");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "BL");

            migrationBuilder.DropTable(
                name: "Importaciones");

            migrationBuilder.DropTable(
                name: "Aduanas");

            migrationBuilder.DropTable(
                name: "Agentes");

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
