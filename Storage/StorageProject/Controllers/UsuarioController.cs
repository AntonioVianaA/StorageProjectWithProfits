﻿using StorageProject.DAL;
using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StorageProject.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {

            if (Request.IsAuthenticated)
            {
                string a = User.Identity.Name;
                ViewBag.Usuario = UsuarioDAO.BuscarUserLoginString(a);
              
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
        //public ActionResult AlterarImagem(int? id, HttpPostedFileBase fupImagem)
        //{
        //    Usuario u = UsuarioDAO.BuscarUsuarioId(id);
        //    string caminho = System.IO.Path.Combine(Server.MapPath("~/Images/"), fupImagem.FileName);
        //    fupImagem.SaveAs(caminho);
        //    u.Imagem = fupImagem.FileName;
        //    UsuarioDAO.AlterarUsuario(u);
        //    return View("Index", "Usuario");
        //}

        public ActionResult AlterarImagem(int? id, HttpPostedFileBase fupImagem/*, Usuario usuario*/)
        {
            if (ModelState.IsValid)
            {
                Usuario u = UsuarioDAO.BuscarUsuarioId(id);

                string caminho = System.IO.Path.Combine(Server.MapPath("~/Images/"), fupImagem.FileName);
                fupImagem.SaveAs(caminho);
                u.Imagem = fupImagem.FileName;

                UsuarioDAO.AlterarUsuario(u);
                return RedirectToAction("Index", "Usuario");
            }
            return RedirectToAction("Index", "Usuario");
        }



        [HttpPost]
        public ActionResult Cadastrar(HttpPostedFileBase fupImagem ,Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Imagem = "semimagem.jpeg";

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
                FormsAuthentication.SetAuthCookie(usuario.Username, false);
                

                return RedirectToAction("index", "Home");
            }
            ModelState.AddModelError("", "Login ou senha incorretos!");
            return View();
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Usuario");
        }
    }
}