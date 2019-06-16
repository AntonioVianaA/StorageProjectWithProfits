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
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Range(1, 1000, ErrorMessage = "Qunatidade mínima de 1 e máxima 1000")]
        public Ingrediente Ingrediente { get; set; }
        public int QuantEstoque { get; set; }
        public bool Situacao { get; set; }



    }
}