using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Ingredientes_Receitas")]
    public class Ingredientes_Receita
    {

        [Key]
        public int Ingredientes_ReceitaId { get; set; }
        public double Quantidade { get; set; }
    }
}