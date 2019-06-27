using PagedList;
using StorageProject.DAL;
using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace StorageProject.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Estoque
        public ActionResult Index()
        {

            string a = User.Identity.Name;
            ViewBag.Usuario = UsuarioDAO.BuscarUserLoginString(a);
            ViewBag.Estoque = EstoqueDAO.RetornaEstoque();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Ingrediente ingrediente)
        {
            if (ModelState.IsValid)
            {
                if (IngredienteDAO.CadastrarIngrediente(ingrediente))
                {
                    return RedirectToAction("Index", "Estoque");
                }
                //Tratamento de erros/exceções
                return RedirectToAction("Index", "Estoque");
            }
            return RedirectToAction("Index", "Estoque");
        }

        public ActionResult Remover(int? id)
        {
            EstoqueDAO.RemoverEstoque(EstoqueDAO.BuscarIngredientePorId(id));
            IngredienteDAO.RemoverIngrediente(IngredienteDAO.BuscarIngredientePorId(id));
            return RedirectToAction("Index", "Estoque");
        }



        public ActionResult Alterar(int? id)
        {
            return View(IngredienteDAO.BuscarIngredientePorId(id));
        }

        [HttpPost]
        public ActionResult Alterar(Ingrediente ingrediente)
        {
            Ingrediente i = IngredienteDAO.BuscarIngredientePorId(ingrediente.IngredienteID);
            i.Nome = ingrediente.Nome;
            i.Descricao = ingrediente.Descricao;
            i.Preco = ingrediente.Preco;
            i.Validade = ingrediente.Validade;
            i.QuantEstoque = ingrediente.QuantEstoque;

            string variavel = "123123123";
            byte[] bytes = Encoding.Default.GetBytes(variavel);
            variavel = Encoding.UTF8.GetString(bytes);

            IngredienteDAO.AlterarIngrediente(i);
            return RedirectToAction("Index", "Estoque");
        }
    }
}