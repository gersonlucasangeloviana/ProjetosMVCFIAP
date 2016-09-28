using Fiap.Apostila03.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila03.MVC.Web.Controllers
{
    public class UsuarioController : Controller
    {       
        [HttpGet] //Abre a página com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            TempData["msg"] = "Usuário cadastrado!";
            return View("Resultado",usuario);
        }
    }
}