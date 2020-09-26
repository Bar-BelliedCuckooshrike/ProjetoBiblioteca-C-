using ProjetoBiblioteca.DAL;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.View
{
    class Login
    {
        public static void LoginUsuario()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("\nSenha: ");
            string senha = Console.ReadLine();

            if (cpf == usuario.Cpf)
            {
                if (senha == usuario.senha)
                {

                }
            }
           


        }
    }
}
