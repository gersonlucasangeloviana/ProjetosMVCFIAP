using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila03.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abre a tela com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Realiza o cadastro com as informações do form
        public ActionResult Cadastrar(string nome, string cpf)
        {
            //Enviando informações para a view
            TempData["msg"] = "Pessoa cadastrada!";
            ViewBag.churros = nome;
            ViewBag.guarana = cpf;
            return View("Resultado");//Devolve a página Resultado.cshtml
            //return Content(nome + " " + cpf);
        }
    }
}