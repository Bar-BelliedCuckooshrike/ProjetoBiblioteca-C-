using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBiblioteca.Migrations
{
    public partial class GeneroAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Livros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Livros");
        }
    }
}
