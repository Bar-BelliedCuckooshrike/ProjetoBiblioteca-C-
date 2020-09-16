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
        
        public static void CadastrarUsuario(Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
        }

        public static Usuario BuscarCPF(string cpf) => ctx.Usuarios.Find(cpf);

        public static Usuario BuscarSenha(string senha) => 
            ctx.Usuarios.FirstOrDefault(x => x.senha.Equals(senha)); //Expressão Lambda: (x => x.senha.Equals(senha);
    }
}
