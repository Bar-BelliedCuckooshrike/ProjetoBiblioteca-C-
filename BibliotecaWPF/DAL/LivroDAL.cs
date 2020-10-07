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
        public static Usuario usuario = new Usuario();

        //metodo que cadastra livro no banco
        public static bool CadastrarLivro(Livro livro) //recebe o livro
        {

            if (buscarISBN(livro.Isbn) == null)
            {
              
                ctx.Livros.Add(livro);
                ctx.SaveChanges();
                
                return true;
            }
            return false;
        }


        //busca livros por codigo de barra
        public static Livro buscarISBN(string isbn) =>
            ctx.Livros.FirstOrDefault(x => x.Isbn == isbn);


        //pega a lista de livros no banco
        public static List<Livro> ListarLivros() => ctx.Livros.ToList();
    }







}
