using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaWPF.Migrations
{
    public partial class CadastroLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Livros_livroId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_livroId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "livroId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "EstanteId",
                table: "Livros",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EstanteId",
                table: "Livros",
                column: "EstanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Livros_EstanteId",
                table: "Livros",
                column: "EstanteId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Livros_EstanteId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_EstanteId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "EstanteId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "livroId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_livroId",
                table: "Livros",
                column: "livroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Livros_livroId",
                table: "Livros",
                column: "livroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
