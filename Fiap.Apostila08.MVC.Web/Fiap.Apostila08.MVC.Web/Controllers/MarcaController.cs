using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class MarcaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet] //Abre a página
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Cadastra no banco de dados
        public ActionResult Cadastrar(Marca marca)
        {
            //Cadastra no banco
            _unit.MarcaRepository.Cadastrar(marca);
            _unit.Salvar();
            //Mensagem de sucesso
            TempData["msg"] = "Marca cadastrada!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();  //Fecha a conexão com o BD
            base.Dispose(disposing);
        }
    }
}