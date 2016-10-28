using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.MVC.Web.Controllers
{
    public class LivroController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        public ActionResult Reservar(int id)
        {
            _unit.LivroRepository.Reservar(id);
            _unit.Salvar();
            TempData["msg"] = "Livro reservado";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.LivroRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.EditoraRepository.Listar();
            ViewBag.opcoes = new SelectList(lista, "EditoraId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Livro livro)
        {
            _unit.LivroRepository.Cadastrar(livro);
            _unit.Salvar();
            TempData["msg"] = "Livro cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}