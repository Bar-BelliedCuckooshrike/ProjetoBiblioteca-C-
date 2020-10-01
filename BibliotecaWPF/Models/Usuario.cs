using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotecaWPF.Models
{

    [Table("Usuarios")]
    class Usuario : BaseModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string senha { get; set; }
        public Livro livro { get; set; }
    }
}
