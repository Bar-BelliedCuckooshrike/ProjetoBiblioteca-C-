using BibliotecaWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BibliotecaWPF.DAL
{
    class SETUsuarioDAL
    {
        static Usuario usuariologado = new Usuario();

        public static void UsuarioLogadoSET(Usuario usuario)
        {
            usuariologado = usuario;            
        }

        public static String UsuarioLogadoGET()
        {
            return usuariologado.Cpf;
        }
    }
}
