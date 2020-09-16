using ProjetoBiblioteca.View;
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
                Console.WriteLine("[1] - Cadastrar Usuário");
                Console.WriteLine("[2] - Fazer login");
                Console.WriteLine("[0] - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        CadastrarUsuario.cadastrarUser();
                        break;

                    case 2:
                        Login.LoginUsuario();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                }
            } while (op != 0);

        }
    }
}
