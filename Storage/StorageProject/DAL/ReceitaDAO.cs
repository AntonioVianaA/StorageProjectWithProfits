using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageProject.DAL
{
    public class ReceitaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarReceita(Receita receita)
        {
            //Estoque estoque = new Estoque();
            //estoque.Ingrediente = ingrediente;
            ctx.Receita.Add(receita);
            ctx.SaveChanges();
        }

        //public static List<Receita> RetornaReceitas()
        //{
        //    //parada de sessao aq
        //    return ctx.Receita.Include("Ingrediente").ToList();
        //}

        //public static List<Ingredientes_Receita> RetornarIngredientes()
        //{
        //    //return ctx.
        //}

        public static void RemoverEstoque(Estoque e)
        {

            ctx.Estoque.Remove(e);
            ctx.SaveChanges();
        }
    }
}