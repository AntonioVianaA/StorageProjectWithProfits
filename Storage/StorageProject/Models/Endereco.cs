using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public int EnderecoID { get; set; }
        public string Rua { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public String Estado { get; set; }
        public string Pais { get; set; }
        public int Numero { get; set; }

    }
}