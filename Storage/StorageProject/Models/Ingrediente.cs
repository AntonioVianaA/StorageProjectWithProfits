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
        //public Ingrediente()
        //{
            
        //}


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
        [Range(1, 1000, ErrorMessage = "Qunatidade mínima de 1 e máxima 1000")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int QuantEstoque { get; set; }
        public bool Situacao { get; set; }

    }
}