using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Migrations
{
    /// <inheritdoc />
    public partial class agregamosRitmoAInscripto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Edad",
                table: "inscriptos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RitmoId",
                table: "inscriptos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Edad", "RitmoId" },
                values: new object[] { "21", null });

            migrationBuilder.UpdateData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Edad", "RitmoId" },
                values: new object[] { "21", null });

            migrationBuilder.CreateIndex(
                name: "IX_inscriptos_RitmoId",
                table: "inscriptos",
                column: "RitmoId");

            migrationBuilder.AddForeignKey(
                name: "FK_inscriptos_Ritmos_RitmoId",
                table: "inscriptos",
                column: "RitmoId",
                principalTable: "Ritmos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inscriptos_Ritmos_RitmoId",
                table: "inscriptos");

            migrationBuilder.DropIndex(
                name: "IX_inscriptos_RitmoId",
                table: "inscriptos");

            migrationBuilder.DropColumn(
                name: "RitmoId",
                table: "inscriptos");

            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "inscriptos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Edad",
                value: 21);

            migrationBuilder.UpdateData(
                table: "inscriptos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Edad",
                value: 21);
        }
    }
}
