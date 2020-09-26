using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.Model
{
    class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estante> Estantes { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb; Database=BibliotecaDB; Trusted_Connection=true");
        }
    }
}
