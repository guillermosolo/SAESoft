using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAESoft.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProporcionalIncentivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proporcional",
                table: "EvaluacionesDetalle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Proporcional",
                table: "EvaluacionesDetalle",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
