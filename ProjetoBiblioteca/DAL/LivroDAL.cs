using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBiblioteca.DAL
{
    class LivroDAL
    {
        public static Context ctx = new Context();

        public static List<Livro> FiltrarPorGenero(String genero) =>
            ctx.Livros.Where(x => x.Genero == genero).ToList();

       // public static Livro buscarNome(Li)

        public static void RemoverLivro(Livro livro)
        {
            if (true)
            {
                ctx.Livros.Remove(livro);
                ctx.SaveChanges(); 
            }
        }

        public static void AlterarLivro(Livro livro)
        {

        }
    }
}
