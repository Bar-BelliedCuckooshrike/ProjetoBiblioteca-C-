using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBiblioteca.Migrations
{
    public partial class CriandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Isbn = table.Column<string>(nullable: false),
                    TituloLivro = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    NumeroPaginas = table.Column<int>(nullable: false),
                    Editora = table.Column<string>(nullable: true),
                    Edicao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Isbn);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Cpf = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "Estante",
                columns: table => new
                {
                    EstanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioCpf = table.Column<string>(nullable: true),
                    LivroIsbn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estante", x => x.EstanteId);
                    table.ForeignKey(
                        name: "FK_Estante_Livros_LivroIsbn",
                        column: x => x.LivroIsbn,
                        principalTable: "Livros",
                        principalColumn: "Isbn",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estante_Usuarios_UsuarioCpf",
                        column: x => x.UsuarioCpf,
                        principalTable: "Usuarios",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estante_LivroIsbn",
                table: "Estante",
                column: "LivroIsbn");

            migrationBuilder.CreateIndex(
                name: "IX_Estante_UsuarioCpf",
                table: "Estante",
                column: "UsuarioCpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estante");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
