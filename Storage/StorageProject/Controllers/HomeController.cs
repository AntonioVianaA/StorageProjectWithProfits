using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
       
        // GET: Home
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                ViewBag.Usuario = User.Identity.Name;
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }
    }
}