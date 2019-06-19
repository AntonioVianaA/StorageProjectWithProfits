using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Key]
        public int UsuarioID { get; set; }

        public Produto Produto { get; set; }
        public Historico Historico { get; set; }
        public Endereco Endereco { get; set; }
        [Display(Name = "Nome do usuário")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "Sobrenome do usuário")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Sobrenome { get; set; }
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }
        [Display(Name = "Username do usuário")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(8, ErrorMessage = "Mínimo de 8 caracteres!")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "As senhas nâo coincidem!")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(11, ErrorMessage = "Mínimo de 11 caracteres!")]
        public string Cpf { get; set; }

        
        public string Imagem { get; set; }


        public DateTime DataCadastro { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
