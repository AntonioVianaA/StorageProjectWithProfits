using EcommerceA.DAL;
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

        public static List<Estoque> RetornaEstoque()
        {
            return ctx.Estoque.Include("Ingrediente").ToList();
        }
    }
}