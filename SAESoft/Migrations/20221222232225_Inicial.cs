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
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Permisos",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "IdModulo", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7823), null, true, 1, null, "MENÚ PRINCIPAL" },
                    { 2, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7826), null, true, 1, null, "ADMINISTRACIÓN DEL SISTEMA" },
                    { 3, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7828), null, true, 1, null, "IMPORTACIONES" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRol", "FechaCreacion", "FechaUltimaMod", "Habilitado", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[] { 1, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(6257), null, true, 1, null, "Super Admin" });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "IdPermiso", "FechaCreacion", "FechaUltimaMod", "IdModulo", "IdUsuarioCreacion", "IdUsuarioMod", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7860), null, 1, 1, null, "VER.ADMINISTRACION SISTEMA" },
                    { 2, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7865), null, 1, 1, null, "VER.IMPORTACIONES" },
                    { 11, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7866), null, 2, 1, null, "VER.USUARIOS" },
                    { 12, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7868), null, 2, 1, null, "CREAR.USUARIOS" },
                    { 13, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7869), null, 2, 1, null, "MODIFICAR.USUARIOS" },
                    { 14, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7895), null, 2, 1, null, "ELIMINAR.USUARIOS" },
                    { 15, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7897), null, 2, 1, null, "VER.ROLES" },
                    { 16, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7898), null, 2, 1, null, "CREAR.ROLES" },
                    { 17, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7900), null, 2, 1, null, "MODIFICAR.ROLES" },
                    { 18, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7903), null, 2, 1, null, "ELIMINAR.ROLES" },
                    { 19, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7904), null, 2, 1, null, "VER.PERMISOS" },
                    { 20, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7905), null, 2, 1, null, "CREAR.PERMISOS" },
                    { 21, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7908), null, 2, 1, null, "MODIFICAR.PERMISOS" },
                    { 22, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7909), null, 2, 1, null, "ELIMINAR.PERMISOS" },
                    { 23, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7911), null, 2, 1, null, "VER.MODULOS" },
                    { 24, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7912), null, 2, 1, null, "CREAR.MODULOS" },
                    { 25, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7914), null, 2, 1, null, "MODIFICAR.MODULOS" },
                    { 26, new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7916), null, 2, 1, null, "ELIMINAR.MODULOS" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Activo", "Apellidos", "Email", "FechaCreacion", "FechaUltimaMod", "IdRol", "IdUsuarioCreacion", "IdUsuarioMod", "Nombres", "Password", "UserName" },
                values: new object[] { 1, true, "Admin", "sa@sae-a.com", new DateTime(2022, 12, 22, 17, 22, 24, 849, DateTimeKind.Local).AddTicks(7756), null, 1, 1, null, "Super", "MtbCwdmMCtjF0V9gmsikMJ2tUwY9UPuUGqHoh5XfdsKgbW4c0lhIVeQ5kJYIlGeVMQDDDoko4EZ2xgoHuM7fq6zitYjOMQ==", "sa" });

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
                    { 26, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_Nombre",
                table: "Modulos",
                column: "Nombre",
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
                name: "PermisoRol");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Modulos");
        }
    }
}
