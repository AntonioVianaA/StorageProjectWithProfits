using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Ingredientes_Receita")]
    public class Ingredientes_Receita
    {

        [Key]
        public int Ingredientes_ReceitaID { get; set; }
        public double Quantidade { get; set; }
    }
}