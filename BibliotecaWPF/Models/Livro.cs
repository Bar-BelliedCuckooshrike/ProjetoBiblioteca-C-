using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotecaWPF.Models
{
    [Table("Livros")]
    class Livro : BaseModel
    {
        public string TituloLivro { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public string Isbn { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string Genero { get; set; }
        public Usuario usuario { get; set; }

        public string usuariolog { get; set; }
    }
}
