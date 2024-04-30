using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AddIncentivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeptoIncentivo",
                columns: table => new
                {
                    IdDepto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptoIncentivo", x => x.IdDepto);
                    table.ForeignKey(
                        name: "FK_DeptoIncentivo_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "EmpIncentivos",
                columns: table => new
                {
                    IdEmpIncentivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    Asistencia = table.Column<int>(type: "int", nullable: false),
                    Actitud = table.Column<int>(type: "int", nullable: false),
                    Cooperacion = table.Column<int>(type: "int", nullable: false),
                    Extra = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioCreacion = table.Column<int>(type: "int", nullable: true),
                    FechaUltimaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioMod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesDetalle", x => x.IdEvaluacionDetalle);
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

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 10, 54, 553, DateTimeKind.Local).AddTicks(8169), "m+kdIBtc7jWNiySqGYTzLQBYEeCtZv6J6NJpn1K5eHe1L5PlhrFbXgKylKlPuae1Elc4M8+H9BKVZwmIxDqMsb6iQRuHQBQ3Bi27" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "Password" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 10, 54, 553, DateTimeKind.Local).AddTicks(8189), "F9owu62mZkOgcjx3SVZ3rcu1PeeiwrdI5wXg5/+FI5iSHRInhaOFWakB+ZrlLPPnk8Uwl5P6ZuM/3ys/eqvHkP7kH+j36KmFGQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdEmpleado",
                table: "Asistencia",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdEvaluacion",
                table: "Asistencia",
                column: "IdEvaluacion");

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
                name: "IX_EvaluacionesDetalle_IdEmpleado",
                table: "EvaluacionesDetalle",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDetalle_IdEvaluacion",
                table: "EvaluacionesDetalle",
                column: "IdEvaluacion");
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
                name: "PorcentajeEvaluacion");

            migrationBuilder.DropTable(
                name: "PuntajeAsistencia");

            migrationBuilder.DropTable(
                name: "EmpIncentivos");

            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "DeptoIncentivo");
        }
    }
}
