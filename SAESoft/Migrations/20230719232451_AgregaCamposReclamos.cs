using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaCamposReclamos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdResidencia",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdSeguroMedico",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdContrato",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdResidencia",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroMedico",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "MontoReal",
                table: "Reclamos");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtrosGastos",
                table: "Reclamos",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Reclamos",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Deducible",
                table: "Reclamos",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddColumn<decimal>(
                name: "Coaseguro",
                table: "Reclamos",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRecibir",
                table: "Reclamos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdMoneda",
                table: "Reclamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoCheque",
                table: "Reclamos",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MontosNoCubiertos",
                table: "Reclamos",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Timbres",
                table: "Reclamos",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoDoc",
                table: "AdminStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Ultimo",
                table: "AdminStatuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "HistorialReclamos",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReclamo = table.Column<int>(type: "int", nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialReclamos", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_HistorialReclamos_AdminStatuses_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "AdminStatuses",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistorialReclamos_Reclamos_IdReclamo",
                        column: x => x.IdReclamo,
                        principalTable: "Reclamos",
                        principalColumn: "IdReclamo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Simbolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.IdMoneda);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_IdMoneda",
                table: "Reclamos",
                column: "IdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdResidencia",
                table: "Familiares",
                column: "IdResidencia",
                unique: true,
                filter: "[IdResidencia] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdSeguroMedico",
                table: "Familiares",
                column: "IdSeguroMedico",
                unique: true,
                filter: "[IdSeguroMedico] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdContrato",
                table: "Empleados",
                column: "IdContrato",
                unique: true,
                filter: "[IdContrato] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados",
                column: "IdPermisoTrabajo",
                unique: true,
                filter: "[IdPermisoTrabajo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdResidencia",
                table: "Empleados",
                column: "IdResidencia",
                unique: true,
                filter: "[IdResidencia] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroMedico",
                table: "Empleados",
                column: "IdSeguroMedico",
                unique: true,
                filter: "[IdSeguroMedico] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados",
                column: "IdSeguroVehiculo",
                unique: true,
                filter: "[IdSeguroVehiculo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AdminStatuses_IdTipoDoc",
                table: "AdminStatuses",
                column: "IdTipoDoc");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialReclamos_IdReclamo",
                table: "HistorialReclamos",
                column: "IdReclamo");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialReclamos_IdStatus",
                table: "HistorialReclamos",
                column: "IdStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminStatuses_TiposDocumento_IdTipoDoc",
                table: "AdminStatuses",
                column: "IdTipoDoc",
                principalTable: "TiposDocumento",
                principalColumn: "IdTipoDocumento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Monedas_IdMoneda",
                table: "Reclamos",
                column: "IdMoneda",
                principalTable: "Monedas",
                principalColumn: "IdMoneda",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminStatuses_TiposDocumento_IdTipoDoc",
                table: "AdminStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Monedas_IdMoneda",
                table: "Reclamos");

            migrationBuilder.DropTable(
                name: "HistorialReclamos");

            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_IdMoneda",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdResidencia",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdSeguroMedico",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdContrato",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdResidencia",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroMedico",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_AdminStatuses_IdTipoDoc",
                table: "AdminStatuses");

            migrationBuilder.DropColumn(
                name: "Coaseguro",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "FechaRecibir",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "IdMoneda",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "MontoCheque",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "MontosNoCubiertos",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "Timbres",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "IdTipoDoc",
                table: "AdminStatuses");

            migrationBuilder.DropColumn(
                name: "Ultimo",
                table: "AdminStatuses");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtrosGastos",
                table: "Reclamos",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Reclamos",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Deducible",
                table: "Reclamos",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoReal",
                table: "Reclamos",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2023, 6, 30, 8, 46, 25, 231, DateTimeKind.Local).AddTicks(7118), "3H+TzvkvGb2MSKoWxcxKKszq6ByFefpm/IQV+K2vTUIB6kwIHxNBCf3A0h7w0prGhX66dg8DFaJ+sRBSTwDUg82W4n8=" });

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdResidencia",
                table: "Familiares",
                column: "IdResidencia");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdSeguroMedico",
                table: "Familiares",
                column: "IdSeguroMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdContrato",
                table: "Empleados",
                column: "IdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados",
                column: "IdPermisoTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdResidencia",
                table: "Empleados",
                column: "IdResidencia");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroMedico",
                table: "Empleados",
                column: "IdSeguroMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados",
                column: "IdSeguroVehiculo");
        }
    }
}
