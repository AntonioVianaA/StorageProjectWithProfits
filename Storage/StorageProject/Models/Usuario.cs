using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Model
{
    [Table("Usuario")]
    public class Usuario
    {

        [Key]
        public int UsuarioID { get; set; }
        //public ProdutoFinal Produto { get; set; }
        //public Historico Historico { get; set; }
        //public Endereco Endereco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(8, ErrorMessage = "Mínimo de 8 caracteres!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(11, ErrorMessage = "Mínimo de 11 caracteres!")]
        public string Cpf { get; set; }

        
        public string Imagem { get; set; }


        public DateTime DataCadastro { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
