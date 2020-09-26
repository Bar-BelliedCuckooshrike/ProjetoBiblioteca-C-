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
        
        public static bool CadastrarUsuario(Usuario usuario)
        {
            if (BuscarCPF(usuario.Cpf) == null)
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Usuario BuscarCPF(string cpf) => ctx.Usuarios.Find(cpf);

        public static Usuario BuscarSenha(string senha) => 
            ctx.Usuarios.FirstOrDefault(x => x.senha.Equals(senha)); //Expressão Lambda: (x => x.senha.Equals(senha);

        //public static List<Usuario> FiltrarPorUsuario(String cpf) =>
        //  ctx.Usuarios.Where(x => x.Cpf == cpf).ToList(); isso é como o WHERE no MySql
    }
}
