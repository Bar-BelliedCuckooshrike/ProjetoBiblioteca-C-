using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoBiblioteca.Model
{
    [Table("Usuarios")]
    class Usuario
    {
        
        public Usuario()
        {
            CriadoEm = DateTime.Now;
        }

        public string Nome { get; set; }
        [Key]
        public string Cpf { get; set; }
        public string senha { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
