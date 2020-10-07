using BibliotecaWPF.Models;
using BibliotecaWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaWPF.DAL
{
    class UsuarioDAL
    {
        private static Context ctx = new Context();

        //busca o usuario no banco
        public static Usuario BuscarPorNome(string nome) =>
            ctx.Usuarios.FirstOrDefault(x => x.Nome == nome);

        //cadastra o usuario
        public static bool Cadastrar(Usuario usuario)
        {
            if (BuscarPorNome(usuario.Nome) == null)
            {
                ctx.Usuarios.Add(usuario); //envia o usuario
                ctx.SaveChanges(); //persiste as atualisações 
                return true;
            }
            return false;
        }

        public static Usuario buscarCPF(string cpf) =>
            ctx.Usuarios.FirstOrDefault(x => x.Cpf.Equals(cpf));

        public static Usuario buscarSenha(string senha) =>
            ctx.Usuarios.FirstOrDefault(x => x.senha.Equals(senha));

        

        public static bool Logar(string cpf, string senha)
        {
            if (buscarCPF(cpf) != null)
            {
                if (buscarSenha(senha) != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
