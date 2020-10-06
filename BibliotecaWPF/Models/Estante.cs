using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotecaWPF.Models
{
    [Table("Estantes")]
    class Estante : BaseModel
    {
        public Estante()
        {
            usuario = new Usuario();
            livros = new List<Livro>();
        }

        public string EstanteGenero { get; set; }
        public Usuario usuario { get; set; }
        public List<Livro> livros { get; set; }
    }
}
