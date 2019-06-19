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
        public Ingrediente Ingrediente { get; set; }



    }
}