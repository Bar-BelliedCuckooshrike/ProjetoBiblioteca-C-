using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoBiblioteca.Model
{
    [Table("Estante")]
    class Estante
    {
        [Key]
        public int EstanteId { get; set; }
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; } 
    }
}
