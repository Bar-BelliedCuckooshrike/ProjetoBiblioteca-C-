using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBiblioteca.Model
{
    class Livro
    {
        public string TituloLivro { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public string Isbn { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
    }
}
