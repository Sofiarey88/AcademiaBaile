using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Migrations
{
    /// <inheritdoc />
    public partial class agregamosProfesoyAInscripto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Profesorid",
                table: "inscriptos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Profesorid",
                value: null);

            migrationBuilder.UpdateData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Profesorid",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_inscriptos_Profesorid",
                table: "inscriptos",
                column: "Profesorid");

            migrationBuilder.AddForeignKey(
                name: "FK_inscriptos_Profesores_Profesorid",
                table: "inscriptos",
                column: "Profesorid",
                principalTable: "Profesores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inscriptos_Profesores_Profesorid",
                table: "inscriptos");

            migrationBuilder.DropIndex(
                name: "IX_inscriptos_Profesorid",
                table: "inscriptos");

            migrationBuilder.DropColumn(
                name: "Profesorid",
                table: "inscriptos");
        }
    }
}
