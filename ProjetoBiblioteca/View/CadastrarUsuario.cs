using ProjetoBiblioteca.DAL;
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
            Usuario u = new Usuario();

            Console.WriteLine("CADASTRAR USUARIO: ");
            Console.WriteLine("\nNome: ");
            u.Nome = Console.ReadLine();
            Console.WriteLine("\nCpf: ");
            u.Cpf = Console.ReadLine();
            Console.WriteLine("\nSenha:");
            u.senha = Console.ReadLine();

            if (UsuarioDAL.BuscarCPF(u.Cpf))
            {
                UsuarioDAL.CadastrarUsuario(u);
            }
        }
    }
}
