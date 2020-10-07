using BibliotecaWPF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Documents;

namespace BibliotecaWPF.Models
{

    [Table("Usuarios")]
    class Usuario : BaseModel
    {


        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string senha { get; set; }

        
        
    }
}
