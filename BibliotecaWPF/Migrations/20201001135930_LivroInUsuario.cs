using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaWPF.Migrations
{
    public partial class LivroInUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "livroId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_livroId",
                table: "Usuarios",
                column: "livroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Livros_livroId",
                table: "Usuarios",
                column: "livroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Livros_livroId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_livroId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "livroId",
                table: "Usuarios");
        }
    }
}
