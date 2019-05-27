using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    [Table("Ingrediente")]
    public class Ingrediente
    {


        [Key]
        public int IngredienteID { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime Validade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public double Preco { get; set; }

    }
}