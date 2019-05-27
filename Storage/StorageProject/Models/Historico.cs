using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Historico")]
    public class Historico
    {

        [Key]
        public int HistoricoID { get; set; }
        public Produto Produto { get; set; }
        public double ValorTotal { get; set; }
        public double ValorGasto { get; set; }
        public double Lucro { get; set; }

    }
}