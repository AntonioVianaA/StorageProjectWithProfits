using StorageProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    public class HistoricoController : Controller
    {
        // GET: Historico
        public ActionResult Index()
        {
            string a = User.Identity.Name;
            ViewBag.Usuario = UsuarioDAO.BuscarUserLoginString(a);
            return View();
        }
    }
}