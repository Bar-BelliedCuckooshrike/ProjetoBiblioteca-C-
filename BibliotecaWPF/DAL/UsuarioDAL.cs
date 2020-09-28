using BibliotecaWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaWPF.DAL
{
    class UsuarioDAL
    {
        private static Context ctx = new Context();

        public static Usuario BuscarPorNome(string nome) =>
            ctx.Usuarios.FirstOrDefault(x => x.Nome == nome);

        public static bool Cadastrar(Usuario usuario)
        {
            if (BuscarPorNome(usuario.Nome) == null)
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
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
