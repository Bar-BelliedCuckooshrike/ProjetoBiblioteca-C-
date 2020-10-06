using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaWPF.Migrations
{
    public partial class EstanteinUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Usuarios_usuarioId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Livros_livroId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_livroId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Livros_usuarioId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "livroId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "estanteId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_estanteId",
                table: "Usuarios",
                column: "estanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Livros_estanteId",
                table: "Usuarios",
                column: "estanteId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Livros_estanteId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_estanteId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "estanteId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "livroId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_livroId",
                table: "Usuarios",
                column: "livroId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_usuarioId",
                table: "Livros",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Usuarios_usuarioId",
                table: "Livros",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Livros_livroId",
                table: "Usuarios",
                column: "livroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
