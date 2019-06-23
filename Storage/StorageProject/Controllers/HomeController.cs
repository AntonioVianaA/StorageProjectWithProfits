using StorageProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {

            string a = User.Identity.Name;
            ViewBag.Usuario = UsuarioDAO.BuscarUserLoginString(a);
            return View();
        }
    }
}