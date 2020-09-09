using System;

namespace ProjetoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.WriteLine("-----MINHA BIBLIOTECA-----\n");
                Console.WriteLine("Selecione uma opção: \n");
                Console.WriteLine("[1] - Fazer login");
                Console.WriteLine("[0] - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("[1] - Cadastrar um livro");
                        Console.WriteLine("[2] - Listar livros");
                        Console.WriteLine("[3] - Editar estante");
                        Console.WriteLine("[4] - Editar livros");
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                }
            } while (op != 0);

        }
    }
}
