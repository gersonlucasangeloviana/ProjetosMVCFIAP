using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.MVC.Web.Controllers
{
    public class EditoraController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Editora editora)
        {
            _unit.EditoraRepository.Cadastrar(editora);
            _unit.Salvar();
            TempData["msg"] = "Editora cadastrada!";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}