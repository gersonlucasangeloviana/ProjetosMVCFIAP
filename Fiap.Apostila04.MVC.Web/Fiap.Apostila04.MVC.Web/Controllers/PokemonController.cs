using Fiap.Apostila04.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila04.MVC.Web.Controllers
{
    public class PokemonController : Controller
    {
        //Simular o Banco de Dados
        private static List<Pokemon> _lista = new List<Pokemon>();

        [HttpGet]        
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pokemon pokemon)
        {
            _lista.Add(pokemon);
            TempData["msg"] = "Cadastrado!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passa a lista para a view
            return View(_lista);
        }
    }
}