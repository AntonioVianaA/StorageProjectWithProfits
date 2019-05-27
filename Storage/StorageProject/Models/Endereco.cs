using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cep { get; set; }
        public string Pais { get; set; }
        public int Numero { get; set; }

    }
}