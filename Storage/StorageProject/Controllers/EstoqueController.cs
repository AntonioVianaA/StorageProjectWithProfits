using PagedList;
using StorageProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Estoque
        public ActionResult Index(int? pagina)
        {
            int paginaTamanho = 8;
            int paginaNumero = (pagina ?? 1);
            return View(EstoqueDAO.RetornaEstoque().ToPagedList(paginaNumero, paginaTamanho));
        }
    }
}