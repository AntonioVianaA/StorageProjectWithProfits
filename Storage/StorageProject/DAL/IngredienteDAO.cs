using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageProject.DAL
{
    public class IngredienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Ingrediente BuscarIngredientePorNome(Ingrediente i)
        {
            return ctx.Ingrediente.FirstOrDefault(x => x.Nome.Equals(i.Nome));
        }

        public static bool CadastrarIngrediente(Ingrediente i)
        {
            Ingrediente ingrediente = BuscarIngredientePorNome(i);
            if (ingrediente == null)
            {
                ctx.Ingrediente.Add(i);
                ctx.SaveChanges();
                EstoqueDAO.CadastrarIngrediente(i);
                return true;
            }
            else
            {
                ingrediente.QuantEstoque += i.QuantEstoque;
                ctx.Entry(ingrediente).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
            return false;
        }

        public static Ingrediente BuscarIngredientePorId(int? id)
        {
            return ctx.Ingrediente.Find(id);
        }

        public static void RemoverIngrediente(Ingrediente i)
        {
            ctx.Ingrediente.Remove(i);
            ctx.SaveChanges();
        }

        public static void AlterarIngrediente(Ingrediente i)
        {
            ctx.Entry(i).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static List<Ingrediente> RetornaIngrediente()
        {
            return ctx.Ingrediente.ToList();
        }
    }
}