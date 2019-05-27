using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        public Receita Receita { get; set; }
        public Estoque Estoque { get; set; }

        public bool Status { get; set; }
        public double Preco { get; set; }
        public DateTime TempoProducao { get; set; }
        public double QuantidadeReceita { get; set; }
        public int Porcoes { get; set; }
        public DateTime ProduzidoEm { get; set; }
    }
}