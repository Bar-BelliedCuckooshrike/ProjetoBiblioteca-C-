using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaWPF.Migrations
{
    public partial class CriacaoBancodeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    TituloLivro = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    NumeroPaginas = table.Column<int>(nullable: false),
                    Isbn = table.Column<string>(nullable: true),
                    Editora = table.Column<string>(nullable: true),
                    Edicao = table.Column<int>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    EstanteGenero = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: true),
                    livroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livros_Livros_livroId",
                        column: x => x.livroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Livros_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_livroId",
                table: "Livros",
                column: "livroId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_usuarioId",
                table: "Livros",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
