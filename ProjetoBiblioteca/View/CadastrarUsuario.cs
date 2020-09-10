using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.View
{
    class CadastrarUsuario
    {
        public static void cadastrarUser()
        {
            Usuario user = new Usuario();
            Console.WriteLine("CADASTRAR USUÁRIO");
            Console.WriteLine("Nome: ");
            user.Nome = Console.ReadLine();
            Console.WriteLine("\nCpf: ");
            user.Cpf = Console.ReadLine();
        }
    }
}
