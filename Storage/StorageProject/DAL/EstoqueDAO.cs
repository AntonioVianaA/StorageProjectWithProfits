using StorageProject.DAL;
using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageProject.DAL
{
    public class EstoqueDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarIngrediente(Ingrediente ingrediente)
        {
            Estoque estoque = new Estoque();
            estoque.Ingrediente = ingrediente;
            ctx.Estoque.Add(estoque);
            ctx.SaveChanges();
        }

        public static Estoque BuscarIngredientePorId(int? id)
        {
            return ctx.Estoque.FirstOrDefault(x => x.Ingrediente.IngredienteID == id);
        }

        //public static Estoque BuscarIngredientePorId(int id)
        //{
        //    return ctx.Estoque.Include("Ingrediente").FirstOrDefault(x => x.Ingrediente.IngredienteID == id);
        //}

        public static void RemoverEstoque(Estoque e)
        {

            ctx.Estoque.Remove(e);
            ctx.SaveChanges();
        }

        public static Estoque RetornaIngredienteTeste(Ingrediente e)
        {
            return ctx.Estoque.FirstOrDefault(x => x.Ingrediente.IngredienteID.Equals(e.IngredienteID));
        }

        //Provavelmente tera q corrigir
        public static List<Estoque> RetornaEstoque()
        {
            //parada de sessao aq
            return ctx.Estoque.Include("Ingrediente").ToList();
        } 

        public static void RemoverProduto(Estoque e)
        {
            ctx.Estoque.Remove(e);
            ctx.SaveChanges();
        }
    }
}