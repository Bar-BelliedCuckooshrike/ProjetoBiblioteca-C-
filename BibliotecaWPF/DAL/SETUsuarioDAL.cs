using BibliotecaWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BibliotecaWPF.DAL
{
    class SETUsuarioDAL
    {
        static Usuario usuariologado = new Usuario(); //objeto global
        static List<Livro> livrosDoUsuarioGlobal = new List<Livro>();


        
        public static void UsuarioLogadoSET(Usuario usuario)
        {
            usuariologado = usuario;            
        }

        public static String UsuarioLogadoGET()
        {
            return usuariologado.Cpf;
        }

        public static List<Livro> ListaUsuarioLogadoGET()
        {
            return livrosDoUsuarioGlobal;
        }



        //-----------------------------------------------------------------------------
        public static void carregarLista(Usuario usuario,List<Livro> livros)
        {
            int i = 0;
            foreach (var name in livros)
            {

                if (usuario.Cpf == livros[i].usuariolog)
                {

                    livrosDoUsuarioGlobal.Add(livros[i]);


                }
                

                i = i + 1;
            }

        }



    }
}
