using Fiap.Nac.MVC.Web.DataAccess;
using Fiap.Nac.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Nac.MVC.Web.Controllers
{
    public class AvaliacaoController : Controller
    {
        private EscolaContext _context = new EscolaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _context.Disciplinas.ToList();
            ViewBag.opcoes = new 
                SelectList(lista, "DisciplinaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            _context.SaveChanges();
            TempData["msg"] = "Avaliação Cadastrada";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Avaliacoes.Include("Disciplina").ToList();
            return View(lista);
        }
    }
}