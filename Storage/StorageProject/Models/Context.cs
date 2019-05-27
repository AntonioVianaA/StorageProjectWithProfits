
using Storage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StorageProject.Models
{
    public class Context : DbContext
    {
        public Context() : base("Storage") { }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Ingredientes_Receita> Ingredientes_Receita { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}