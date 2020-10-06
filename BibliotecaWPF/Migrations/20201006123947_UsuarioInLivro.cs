using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaWPF.Migrations
{
    public partial class UsuarioInLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Livros_EstanteId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Livros_estanteId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_estanteId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "estanteId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EstanteGenero",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Livros",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    EstanteGenero = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estantes_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_usuarioId",
                table: "Livros",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estantes_usuarioId",
                table: "Estantes",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Estantes_EstanteId",
                table: "Livros",
                column: "EstanteId",
                principalTable: "Estantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Usuarios_usuarioId",
                table: "Livros",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Estantes_EstanteId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Usuarios_usuarioId",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Estantes");

            migrationBuilder.DropIndex(
                name: "IX_Livros_usuarioId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "estanteId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstanteGenero",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_estanteId",
                table: "Usuarios",
                column: "estanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Livros_EstanteId",
                table: "Livros",
                column: "EstanteId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Livros_estanteId",
                table: "Usuarios",
                column: "estanteId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
