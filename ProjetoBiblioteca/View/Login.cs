using ProjetoBiblioteca.DAL;
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
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("\nSenha: ");
            string senha = Console.ReadLine();

            if (UsuarioDAL.UsuarioCPFbuscar(cpf))
            {
                if (UsuarioDAL.BuscarSenhaUsuario(senha))
                {

                }
            }


        }
    }
}
