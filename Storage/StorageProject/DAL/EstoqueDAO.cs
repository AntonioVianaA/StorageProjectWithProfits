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

        public static void CadastrarIngrediente(Estoque ingrediente)
        {
            //parada da Sessao
            Estoque e = ctx.Estoque.Include("Ingrediente").FirstOrDefault(x => x.Ingrediente.IngredienteID == ingrediente.Ingrediente.IngredienteID /*parada da sessao*/);

            if (e == null)
            {
                ctx.Estoque.Add(ingrediente);
            }
            else
            {
                e.QuantEstoque += ingrediente.QuantEstoque;
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