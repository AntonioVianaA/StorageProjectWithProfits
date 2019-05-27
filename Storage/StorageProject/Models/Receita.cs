using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Receita")]
    class Receita
    {
        public Receita()
        {
            CadastradoEm = DateTime.Now;
        }

        [Key]
        public int ReceitaId { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string ModoPreparo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Rendimento { get; set; }
        public DateTime CadastradoEm { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime TempoPreparo { get; set; }
    }
}