using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejer1.Migrations
{
    /// <inheritdoc />
    public partial class NewCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Carnet",
                table: "Alunmos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Ciclo",
                table: "Alunmos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carnet",
                table: "Alunmos");

            migrationBuilder.DropColumn(
                name: "Ciclo",
                table: "Alunmos");
        }
    }
}
