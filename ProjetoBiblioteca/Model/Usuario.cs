using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.Model
{
    class Usuario
    {
        public Usuario()
        {
            CriadoEm = DateTime.Now;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string senha { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
