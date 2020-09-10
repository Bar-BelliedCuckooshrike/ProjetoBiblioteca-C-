using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.DAL
{
    class UsuarioDAL
    {
        private static List<Usuario> users = new List<Usuario>();
        
        public static Usuario UsuarioCPFbuscar(string cpf)
        {
            foreach (Usuario usuarioCad  in users)
            {
                if (usuarioCad.Cpf == cpf)
                {
                    return usuarioCad;
                }
            }
            return null;
        }

        public static bool CadastrarUsuario(Usuario usuario)
        {
            if (UsuarioCPFbuscar(usuario.Cpf) == null)
            {
                users.Add(usuario);
                return true;
            }
            return false;
        }
    }
}
