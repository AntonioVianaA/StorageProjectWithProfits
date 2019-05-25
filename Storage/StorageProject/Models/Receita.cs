using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Receitas")]
    class Receita
    {
        public Receita()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int ReceitaId { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Preparo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Rendimento { get; set; }
        public DateTime CriadoEm { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime TempoPreparo { get; set; }
    }
}