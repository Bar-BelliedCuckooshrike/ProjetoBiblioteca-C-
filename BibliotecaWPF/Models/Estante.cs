using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotecaWPF.Models
{
    [Table("Estantes")]
    class Estante : Livro
    {
        public string EstanteGenero { get; set; }
        public Usuario usuario { get; set; }
        public Livro livro { get; set; }
    }
}
