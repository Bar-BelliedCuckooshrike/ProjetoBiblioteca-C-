using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoBiblioteca.Model
{
    [Table("Livros")]

    class Livro
    {
        public string TituloLivro { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        [Key]
        public string Isbn { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
<<<<<<< HEAD
        public string Genero { get; set; }
=======
>>>>>>> 9618c617a94abd971c4de925e307422be3bbb7b2
    }
}
