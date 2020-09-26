using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBiblioteca.DAL
{
    class UsuarioDAL
    {
        private static Context ctx = new Context();
        
<<<<<<< HEAD
        public static bool CadastrarUsuario(Usuario usuario)
        {
            if (BuscarCPF(usuario.Cpf) == null)
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
                return true;
            }
            return false;
=======
        public static void CadastrarUsuario(Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
>>>>>>> 9618c617a94abd971c4de925e307422be3bbb7b2
        }

        public static Usuario BuscarCPF(string cpf) => ctx.Usuarios.Find(cpf);

        public static Usuario BuscarSenha(string senha) => 
            ctx.Usuarios.FirstOrDefault(x => x.senha.Equals(senha)); //Expressão Lambda: (x => x.senha.Equals(senha);
<<<<<<< HEAD

        //public static List<Usuario> FiltrarPorUsuario(String cpf) =>
        //  ctx.Usuarios.Where(x => x.Cpf == cpf).ToList(); isso é como o WHERE no MySql
=======
>>>>>>> 9618c617a94abd971c4de925e307422be3bbb7b2
    }
}
