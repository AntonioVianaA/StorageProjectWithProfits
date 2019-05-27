using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Estoque")]
    public class Estoque
    {

        [Key]
        public int EstoqueID { get; set; }
        public Ingrediente ingrediente { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Range(1,1000, ErrorMessage ="Qunatidade mínima de 1 e máxima 1000")]
        public int QuantEstoque { get; set; }
        public bool Situacao { get; set; }



    }
}