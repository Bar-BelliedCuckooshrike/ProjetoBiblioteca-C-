using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.View
{
    class CadastrarLivro
    {
        public static void cadastrarLivro()
        {
            Livro L = new Livro();

            Console.WriteLine("CADASTRAR LIVRO");
            Console.WriteLine("\nTítulo: ");
            L.TituloLivro = Console.ReadLine();
            Console.WriteLine("\nAutor: ");
            L.Autor = Console.ReadLine();
            Console.WriteLine("\nNúmero de páginas: ");
            L.NumeroPaginas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEditora: ");
            L.Editora = Console.ReadLine();
            Console.WriteLine("\nEdição: ");
            L.Edicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gênero: ");
            L.Genero = Console.ReadLine();
        }
    }
}
