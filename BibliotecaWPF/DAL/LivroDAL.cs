using BibliotecaWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaWPF.DAL
{
    class LivroDAL
    {
        private static Context ctx = new Context();

        public static bool CadastrarLivro(Livro livro)
        {
            if (buscarISBN(livro.Isbn) == null)
            {
                ctx.Livros.Add(livro);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Livro buscarISBN(string isbn) =>
            ctx.Livros.FirstOrDefault(x => x.Isbn == isbn);
    }
}
