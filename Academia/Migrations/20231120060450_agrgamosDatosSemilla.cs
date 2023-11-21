using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Academia.Migrations
{
    /// <inheritdoc />
    public partial class agrgamosDatosSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "inscriptos",
                columns: new[] { "Id", "Edad", "Nombre" },
                values: new object[,]
                {
                    { 1, 21, "Sofia" },
                    { 2, 21, "Lara" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
