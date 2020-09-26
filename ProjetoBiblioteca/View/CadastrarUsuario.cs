<<<<<<< HEAD
﻿using ProjetoBiblioteca.DAL;
using ProjetoBiblioteca.Model;
=======
﻿using ProjetoBiblioteca.Model;
>>>>>>> 9618c617a94abd971c4de925e307422be3bbb7b2
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
<<<<<<< HEAD

            if (UsuarioDAL.BuscarCPF(u.Cpf))
            {
                UsuarioDAL.CadastrarUsuario(u);
            }
=======
>>>>>>> 9618c617a94abd971c4de925e307422be3bbb7b2
        }
    }
}
