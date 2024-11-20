using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablasAdministracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Nombres_EmpresaIdNombre",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Empleados_EmpleadoIdEmpleado",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Nombres_TipoIdNombre",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Contratos_ContratoIdContrato",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Nombres_DepartamentoIdNombre",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Residencias_ResidenciaIdResidencia",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Empleados_EmpleadoIdEmpleado",
                table: "Familiares");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Nombres_ParentescoIdNombre",
                table: "Familiares");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_AdminStatuses_StatusIdStatus",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Empleados_EmpleadoIdEmpleado",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Familiares_FamiliarIdFamiliar",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Nombres_TipoReclamoIdNombre",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Residencias_Nombres_TipoIdNombre",
                table: "Residencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_AdminStatuses_StatusIdStatus",
                table: "Tramites");

            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_Empleados_EmpleadoIdEmpleado",
                table: "Tramites");

            migrationBuilder.DropIndex(
                name: "IX_Tramites_EmpleadoIdEmpleado",
                table: "Tramites");

            migrationBuilder.DropIndex(
                name: "IX_Tramites_StatusIdStatus",
                table: "Tramites");

            migrationBuilder.DropIndex(
                name: "IX_Residencias_TipoIdNombre",
                table: "Residencias");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_EmpleadoIdEmpleado",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_FamiliarIdFamiliar",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_StatusIdStatus",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_TipoReclamoIdNombre",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_EmpleadoIdEmpleado",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_ParentescoIdNombre",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_ContratoIdContrato",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DepartamentoIdNombre",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_EmpleadoIdEmpleado",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_TipoIdNombre",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_EmpresaIdNombre",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "EmpleadoIdEmpleado",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "StatusIdStatus",
                table: "Tramites");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Residencias");

            migrationBuilder.DropColumn(
                name: "TipoIdNombre",
                table: "Residencias");

            migrationBuilder.DropColumn(
                name: "EmpleadoIdEmpleado",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "FamiliarIdFamiliar",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "StatusIdStatus",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "TipoReclamoIdNombre",
                table: "Reclamos");

            migrationBuilder.DropColumn(
                name: "EmpleadoIdEmpleado",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "ParentescoIdNombre",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "ContratoIdContrato",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DepartamentoIdNombre",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EmpleadoIdEmpleado",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "TipoIdNombre",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "EmpresaIdNombre",
                table: "Contratos");

            migrationBuilder.RenameColumn(
                name: "ResidenciaIdResidencia",
                table: "Empleados",
                newName: "IdPuesto");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_ResidenciaIdResidencia",
                table: "Empleados",
                newName: "IX_Empleados_IdPuesto");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Familiares",
                type: "char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdResidencia",
                table: "Familiares",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdResidencia",
                table: "Empleados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdContrato",
                table: "Empleados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Empleados",
                type: "char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "Empleados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Empleados",
                type: "char(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdPermisoTrabajo",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSeguroVehiculo",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdEmpleado",
                table: "Documentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdFamiliar",
                table: "Documentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DepartamentosInternos",
                columns: table => new
                {
                    IdDepto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentosInternos", x => x.IdDepto);
                    table.ForeignKey(
                        name: "FK_DepartamentosInternos_Nombres_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermisosTrabajo",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    Resolucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosTrabajo", x => x.IdPermiso);
                    table.ForeignKey(
                        name: "FK_PermisosTrabajo_Nombres_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SegurosVehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAseguradora = table.Column<int>(type: "int", nullable: false),
                    Poliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prima = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Deducible = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegurosVehiculos", x => x.IdVehiculo);
                    table.ForeignKey(
                        name: "FK_SegurosVehiculos_Nombres_IdAseguradora",
                        column: x => x.IdAseguradora,
                        principalTable: "Nombres",
                        principalColumn: "IdNombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumento",
                columns: table => new
                {
                    IdTipoDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumento", x => x.IdTipoDocumento);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tramites_IdEmpleado",
                table: "Tramites",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Tramites_IdStatus",
                table: "Tramites",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Tramites_IdTipo",
                table: "Tramites",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Residencias_IdTipo",
                table: "Residencias",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_IdEmpleado",
                table: "Reclamos",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_IdPaciente",
                table: "Reclamos",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_IdStatus",
                table: "Reclamos",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_IdTipo",
                table: "Reclamos",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdEmpleado",
                table: "Familiares",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdParentesco",
                table: "Familiares",
                column: "IdParentesco");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_IdResidencia",
                table: "Familiares",
                column: "IdResidencia");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdContrato",
                table: "Empleados",
                column: "IdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdDepto",
                table: "Empleados",
                column: "IdDepto");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados",
                column: "IdPermisoTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdResidencia",
                table: "Empleados",
                column: "IdResidencia");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados",
                column: "IdSeguroVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_IdEmpleado",
                table: "Documentos",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_IdFamiliar",
                table: "Documentos",
                column: "IdFamiliar");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_IdTipo",
                table: "Documentos",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_IdEmpresa",
                table: "Contratos",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_DepartamentosInternos_IdEmpresa",
                table: "DepartamentosInternos",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosTrabajo_IdTipo",
                table: "PermisosTrabajo",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_SegurosVehiculos_IdAseguradora",
                table: "SegurosVehiculos",
                column: "IdAseguradora");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Nombres_IdEmpresa",
                table: "Contratos",
                column: "IdEmpresa",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Empleados_IdEmpleado",
                table: "Documentos",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Familiares_IdFamiliar",
                table: "Documentos",
                column: "IdFamiliar",
                principalTable: "Familiares",
                principalColumn: "IdFamiliar");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_TiposDocumento_IdTipo",
                table: "Documentos",
                column: "IdTipo",
                principalTable: "TiposDocumento",
                principalColumn: "IdTipoDocumento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Contratos_IdContrato",
                table: "Empleados",
                column: "IdContrato",
                principalTable: "Contratos",
                principalColumn: "IdContrato");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_DepartamentosInternos_IdDepto",
                table: "Empleados",
                column: "IdDepto",
                principalTable: "DepartamentosInternos",
                principalColumn: "IdDepto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Nombres_IdPuesto",
                table: "Empleados",
                column: "IdPuesto",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_PermisosTrabajo_IdPermisoTrabajo",
                table: "Empleados",
                column: "IdPermisoTrabajo",
                principalTable: "PermisosTrabajo",
                principalColumn: "IdPermiso");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Residencias_IdResidencia",
                table: "Empleados",
                column: "IdResidencia",
                principalTable: "Residencias",
                principalColumn: "IdResidencia");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_SegurosVehiculos_IdSeguroVehiculo",
                table: "Empleados",
                column: "IdSeguroVehiculo",
                principalTable: "SegurosVehiculos",
                principalColumn: "IdVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Empleados_IdEmpleado",
                table: "Familiares",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Nombres_IdParentesco",
                table: "Familiares",
                column: "IdParentesco",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Residencias_IdResidencia",
                table: "Familiares",
                column: "IdResidencia",
                principalTable: "Residencias",
                principalColumn: "IdResidencia");

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_AdminStatuses_IdStatus",
                table: "Reclamos",
                column: "IdStatus",
                principalTable: "AdminStatuses",
                principalColumn: "IdStatus",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Empleados_IdEmpleado",
                table: "Reclamos",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Familiares_IdPaciente",
                table: "Reclamos",
                column: "IdPaciente",
                principalTable: "Familiares",
                principalColumn: "IdFamiliar");

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Nombres_IdTipo",
                table: "Reclamos",
                column: "IdTipo",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Residencias_Nombres_IdTipo",
                table: "Residencias",
                column: "IdTipo",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_AdminStatuses_IdStatus",
                table: "Tramites",
                column: "IdStatus",
                principalTable: "AdminStatuses",
                principalColumn: "IdStatus",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_Empleados_IdEmpleado",
                table: "Tramites",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_Nombres_IdTipo",
                table: "Tramites",
                column: "IdTipo",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Nombres_IdEmpresa",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Empleados_IdEmpleado",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Familiares_IdFamiliar",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_TiposDocumento_IdTipo",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Contratos_IdContrato",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_DepartamentosInternos_IdDepto",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Nombres_IdPuesto",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_PermisosTrabajo_IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Residencias_IdResidencia",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_SegurosVehiculos_IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Empleados_IdEmpleado",
                table: "Familiares");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Nombres_IdParentesco",
                table: "Familiares");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Residencias_IdResidencia",
                table: "Familiares");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_AdminStatuses_IdStatus",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Empleados_IdEmpleado",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Familiares_IdPaciente",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamos_Nombres_IdTipo",
                table: "Reclamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Residencias_Nombres_IdTipo",
                table: "Residencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_AdminStatuses_IdStatus",
                table: "Tramites");

            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_Empleados_IdEmpleado",
                table: "Tramites");

            migrationBuilder.DropForeignKey(
                name: "FK_Tramites_Nombres_IdTipo",
                table: "Tramites");

            migrationBuilder.DropTable(
                name: "DepartamentosInternos");

            migrationBuilder.DropTable(
                name: "PermisosTrabajo");

            migrationBuilder.DropTable(
                name: "SegurosVehiculos");

            migrationBuilder.DropTable(
                name: "TiposDocumento");

            migrationBuilder.DropIndex(
                name: "IX_Tramites_IdEmpleado",
                table: "Tramites");

            migrationBuilder.DropIndex(
                name: "IX_Tramites_IdStatus",
                table: "Tramites");

            migrationBuilder.DropIndex(
                name: "IX_Tramites_IdTipo",
                table: "Tramites");

            migrationBuilder.DropIndex(
                name: "IX_Residencias_IdTipo",
                table: "Residencias");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_IdEmpleado",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_IdPaciente",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_IdStatus",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Reclamos_IdTipo",
                table: "Reclamos");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdEmpleado",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdParentesco",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_IdResidencia",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdContrato",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdDepto",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdResidencia",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_IdEmpleado",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_IdFamiliar",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_IdTipo",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_IdEmpresa",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "IdResidencia",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaBaja",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdPermisoTrabajo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdSeguroVehiculo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdFamiliar",
                table: "Documentos");

            migrationBuilder.RenameColumn(
                name: "IdPuesto",
                table: "Empleados",
                newName: "ResidenciaIdResidencia");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_IdPuesto",
                table: "Empleados",
                newName: "IX_Empleados_ResidenciaIdResidencia");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoIdEmpleado",
                table: "Tramites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusIdStatus",
                table: "Tramites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Residencias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoIdNombre",
                table: "Residencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoIdEmpleado",
                table: "Reclamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FamiliarIdFamiliar",
                table: "Reclamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusIdStatus",
                table: "Reclamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoReclamoIdNombre",
                table: "Reclamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoIdEmpleado",
                table: "Familiares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentescoIdNombre",
                table: "Familiares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdResidencia",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdContrato",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContratoIdContrato",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoIdNombre",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdEmpleado",
                table: "Documentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoIdEmpleado",
                table: "Documentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoIdNombre",
                table: "Documentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaIdNombre",
                table: "Contratos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tramites_EmpleadoIdEmpleado",
                table: "Tramites",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Tramites_StatusIdStatus",
                table: "Tramites",
                column: "StatusIdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Residencias_TipoIdNombre",
                table: "Residencias",
                column: "TipoIdNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_EmpleadoIdEmpleado",
                table: "Reclamos",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_FamiliarIdFamiliar",
                table: "Reclamos",
                column: "FamiliarIdFamiliar");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_StatusIdStatus",
                table: "Reclamos",
                column: "StatusIdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_TipoReclamoIdNombre",
                table: "Reclamos",
                column: "TipoReclamoIdNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_EmpleadoIdEmpleado",
                table: "Familiares",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_ParentescoIdNombre",
                table: "Familiares",
                column: "ParentescoIdNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ContratoIdContrato",
                table: "Empleados",
                column: "ContratoIdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentoIdNombre",
                table: "Empleados",
                column: "DepartamentoIdNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_EmpleadoIdEmpleado",
                table: "Documentos",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_TipoIdNombre",
                table: "Documentos",
                column: "TipoIdNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_EmpresaIdNombre",
                table: "Contratos",
                column: "EmpresaIdNombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Nombres_EmpresaIdNombre",
                table: "Contratos",
                column: "EmpresaIdNombre",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Empleados_EmpleadoIdEmpleado",
                table: "Documentos",
                column: "EmpleadoIdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Nombres_TipoIdNombre",
                table: "Documentos",
                column: "TipoIdNombre",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Contratos_ContratoIdContrato",
                table: "Empleados",
                column: "ContratoIdContrato",
                principalTable: "Contratos",
                principalColumn: "IdContrato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Nombres_DepartamentoIdNombre",
                table: "Empleados",
                column: "DepartamentoIdNombre",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Residencias_ResidenciaIdResidencia",
                table: "Empleados",
                column: "ResidenciaIdResidencia",
                principalTable: "Residencias",
                principalColumn: "IdResidencia",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Empleados_EmpleadoIdEmpleado",
                table: "Familiares",
                column: "EmpleadoIdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Nombres_ParentescoIdNombre",
                table: "Familiares",
                column: "ParentescoIdNombre",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_AdminStatuses_StatusIdStatus",
                table: "Reclamos",
                column: "StatusIdStatus",
                principalTable: "AdminStatuses",
                principalColumn: "IdStatus",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Empleados_EmpleadoIdEmpleado",
                table: "Reclamos",
                column: "EmpleadoIdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Familiares_FamiliarIdFamiliar",
                table: "Reclamos",
                column: "FamiliarIdFamiliar",
                principalTable: "Familiares",
                principalColumn: "IdFamiliar",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamos_Nombres_TipoReclamoIdNombre",
                table: "Reclamos",
                column: "TipoReclamoIdNombre",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Residencias_Nombres_TipoIdNombre",
                table: "Residencias",
                column: "TipoIdNombre",
                principalTable: "Nombres",
                principalColumn: "IdNombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_AdminStatuses_StatusIdStatus",
                table: "Tramites",
                column: "StatusIdStatus",
                principalTable: "AdminStatuses",
                principalColumn: "IdStatus",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tramites_Empleados_EmpleadoIdEmpleado",
                table: "Tramites",
                column: "EmpleadoIdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
