﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //Entra na Pagina Home ao Clicar em Logar
        public ActionResult Logado() {
            return RedirectToAction("Index", "Home");
        }
    }
}