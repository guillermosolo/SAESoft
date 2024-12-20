using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AddIncentivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.CreateTable(
                name: "EvaluacionAsistencia",
                columns: table => new
                {
                    IdEvaluacionAsistencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradoPonderado = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionAsistencia", x => x.IdEvaluacionAsistencia);
                });

            migrationBuilder.CreateTable(
                name: "Evaluaciones",
                columns: table => new
                {
                    IdEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    finalizado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluaciones", x => x.IdEvaluacion);
                });

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    IdFirma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModulo = table.Column<int>(type: "int", nullable: false),
                    puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.IdFirma);
                    table.ForeignKey(
                        name: "FK_Firmas_Modulos_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulos",
                        principalColumn: "IdModulo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GrupoDeptoIncentivo",
                columns: table => new
                {
                    IdGrupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoDeptoIncentivo", x => x.IdGrupo);
                });

            migrationBuilder.CreateTable(
                name: "PorcentajeEvaluacion",
                columns: table => new
                {
                    IdPorcentajeEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PorcentajeEvaluacion", x => x.IdPorcentajeEvaluacion);
                });

            migrationBuilder.CreateTable(
                name: "PuntajeAsistencia",
                columns: table => new
                {
                    IdPuntajeAsistencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Minimo = table.Column<int>(type: "int", nullable: false),
                    Maximo = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntajeAsistencia", x => x.IdPuntajeAsistencia);
                });

            migrationBuilder.CreateTable(
                name: "DeptoIncentivo",
                columns: table => new
                {
                    IdDepto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdGrupo = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptoIncentivo", x => x.IdDepto);
                    table.ForeignKey(
                        name: "FK_DeptoIncentivo_GrupoDeptoIncentivo_IdGrupo",
                        column: x => x.IdGrupo,
                        principalTable: "GrupoDeptoIncentivo",
                        principalColumn: "IdGrupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeptoIncentivo_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpIncentivos",
                columns: table => new
                {
                    IdEmpIncentivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "Date", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "Date", nullable: true),
                    BaseCalculo = table.Column<decimal>(type: "money", nullable: false),
                    IdDepto = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpIncentivos", x => x.IdEmpIncentivo);
                    table.ForeignKey(
                        name: "FK_EmpIncentivos_DeptoIncentivo_IdDepto",
                        column: x => x.IdDepto,
                        principalTable: "DeptoIncentivo",
                        principalColumn: "IdDepto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    IdAsistencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvaluacion = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    Tardanza = table.Column<int>(type: "int", nullable: false),
                    Permiso = table.Column<int>(type: "int", nullable: false),
                    Ausente = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.IdAsistencia);
                    table.ForeignKey(
                        name: "FK_Asistencia_EmpIncentivos_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "EmpIncentivos",
                        principalColumn: "IdEmpIncentivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asistencia_Evaluaciones_IdEvaluacion",
                        column: x => x.IdEvaluacion,
                        principalTable: "Evaluaciones",
                        principalColumn: "IdEvaluacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionesDetalle",
                columns: table => new
                {
                    IdEvaluacionDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvaluacion = table.Column<int>(type: "int", nullable: false),
                    IdDepto = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    BaseCalculo = table.Column<decimal>(type: "money", nullable: false),
                    Asistencia = table.Column<int>(type: "int", nullable: false),
                    Actitud = table.Column<int>(type: "int", nullable: false),
                    Cooperacion = table.Column<int>(type: "int", nullable: false),
                    Extra = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DiasProporcional = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesDetalle", x => x.IdEvaluacionDetalle);
                    table.ForeignKey(
                        name: "FK_EvaluacionesDetalle_DeptoIncentivo_IdDepto",
                        column: x => x.IdDepto,
                        principalTable: "DeptoIncentivo",
                        principalColumn: "IdDepto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluacionesDetalle_EmpIncentivos_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "EmpIncentivos",
                        principalColumn: "IdEmpIncentivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluacionesDetalle_Evaluaciones_IdEvaluacion",
                        column: x => x.IdEvaluacion,
                        principalTable: "Evaluaciones",
                        principalColumn: "IdEvaluacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialIncentivos",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDepto = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "Date", nullable: false),
                    BaseCalculo = table.Column<decimal>(type: "money", nullable: false),
                    Autorizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idEvaluacion = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialIncentivos", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_HistorialIncentivos_DeptoIncentivo_IdDepto",
                        column: x => x.IdDepto,
                        principalTable: "DeptoIncentivo",
                        principalColumn: "IdDepto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistorialIncentivos_EmpIncentivos_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "EmpIncentivos",
                        principalColumn: "IdEmpIncentivo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suspensiones",
                columns: table => new
                {
                    IdSuspension = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDepto = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "Date", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "Date", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspensiones", x => x.IdSuspension);
                    table.ForeignKey(
                        name: "FK_Suspensiones_DeptoIncentivo_IdDepto",
                        column: x => x.IdDepto,
                        principalTable: "DeptoIncentivo",
                        principalColumn: "IdDepto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suspensiones_EmpIncentivos_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "EmpIncentivos",
                        principalColumn: "IdEmpIncentivo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdEmpleado",
                table: "Asistencia",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdEvaluacion",
                table: "Asistencia",
                column: "IdEvaluacion");

            migrationBuilder.CreateIndex(
                name: "IX_DeptoIncentivo_IdGrupo",
                table: "DeptoIncentivo",
                column: "IdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_DeptoIncentivo_IdUsuario",
                table: "DeptoIncentivo",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EmpIncentivos_Codigo",
                table: "EmpIncentivos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpIncentivos_IdDepto",
                table: "EmpIncentivos",
                column: "IdDepto");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDetalle_IdDepto",
                table: "EvaluacionesDetalle",
                column: "IdDepto");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDetalle_IdEmpleado",
                table: "EvaluacionesDetalle",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDetalle_IdEvaluacion",
                table: "EvaluacionesDetalle",
                column: "IdEvaluacion");

            migrationBuilder.CreateIndex(
                name: "IX_Firmas_IdModulo",
                table: "Firmas",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialIncentivos_IdDepto",
                table: "HistorialIncentivos",
                column: "IdDepto");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialIncentivos_IdEmpleado",
                table: "HistorialIncentivos",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensiones_IdDepto",
                table: "Suspensiones",
                column: "IdDepto");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensiones_IdEmpleado",
                table: "Suspensiones",
                column: "IdEmpleado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "EvaluacionAsistencia");

            migrationBuilder.DropTable(
                name: "EvaluacionesDetalle");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "HistorialIncentivos");

            migrationBuilder.DropTable(
                name: "PorcentajeEvaluacion");

            migrationBuilder.DropTable(
                name: "PuntajeAsistencia");

            migrationBuilder.DropTable(
                name: "Suspensiones");

            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "EmpIncentivos");

            migrationBuilder.DropTable(
                name: "DeptoIncentivo");

            migrationBuilder.DropTable(
                name: "GrupoDeptoIncentivo");
        }
    }
}
