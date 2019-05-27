using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Produtos")]
    public class Produto
    {

        [Key]
        public int ProdutoId { get; set; }
        public bool Status { get; set; }
        public double Preco { get; set; }
        public DateTime TempoLevado { get; set; }
        //public double QuantidadeReceita { get; set; }
        public int Porcoes { get; set; }
        //public DateTime Adicionado { get; set; }
    }
}