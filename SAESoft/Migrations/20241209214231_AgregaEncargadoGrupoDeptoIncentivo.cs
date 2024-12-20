using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class AgregaEncargadoGrupoDeptoIncentivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "GrupoDeptoIncentivo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GrupoDeptoIncentivo_IdUsuario",
                table: "GrupoDeptoIncentivo",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoDeptoIncentivo_Usuarios_IdUsuario",
                table: "GrupoDeptoIncentivo",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrupoDeptoIncentivo_Usuarios_IdUsuario",
                table: "GrupoDeptoIncentivo");

            migrationBuilder.DropIndex(
                name: "IX_GrupoDeptoIncentivo_IdUsuario",
                table: "GrupoDeptoIncentivo");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "GrupoDeptoIncentivo");
        }
    }
}
