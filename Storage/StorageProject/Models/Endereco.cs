using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Endereco")]
    class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public int Numero { get; set; }

    }
}