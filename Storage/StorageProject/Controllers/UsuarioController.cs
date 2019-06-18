using StorageProject.DAL;
using StorageProject.Models;
using StorageProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (UsuarioDAO.CadastrarUsuario(usuario))
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Não é possível adicionar um usuário com o mesmo login!");
                return View(usuario);
            }
            return View(usuario);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            usuario = UsuarioDAO.BuscarUserLoginPassword(usuario);
            if (usuario != null)
            {
                Sessao.Login(usuario.Username);
                return RedirectToAction("index", "Home");
            }
            ModelState.AddModelError("", "Login ou senha incorretos!");
            return View(usuario);
        }
    }
}