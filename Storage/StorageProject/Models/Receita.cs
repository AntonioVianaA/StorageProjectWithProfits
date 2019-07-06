
using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Receita")]

public class Receita
{
    public Receita()
    {
        Ingredientes_Receita = new List<Ingredientes_Receita>();
        CadastradoEm = DateTime.Now;
    }

    [Key]
    public int ReceitaID { get; set; }
    public List<Ingredientes_Receita> Ingredientes_Receita { get; set; }
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