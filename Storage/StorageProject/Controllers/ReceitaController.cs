using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    [Authorize]
    public class ReceitaController : Controller
    {
        // GET: Receita
        public ActionResult Index()
        {
            return View();
        }
    }
}