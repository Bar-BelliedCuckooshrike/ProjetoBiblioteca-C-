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
    }
}
