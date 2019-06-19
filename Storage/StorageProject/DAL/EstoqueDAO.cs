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
            ////parada da Sessao
            Estoque e = BuscarIngredientePorId(ingrediente.IngredienteID)/*parada da sessao*/;


            if (e == null)
            {
                estoque.Ingrediente = ingrediente;
                ctx.Estoque.Add(estoque);
            }
            else
            {
                e.Ingrediente.QuantEstoque += ingrediente.QuantEstoque;
                ctx.Entry(e).State = System.Data.Entity.EntityState.Modified;
            }
            ctx.SaveChanges();
        }

        public static Estoque BuscarIngredientePorId(int id)
        {
            return ctx.Estoque.Find(id);
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