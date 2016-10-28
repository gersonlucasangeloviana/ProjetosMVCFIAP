using Fiap.Nac.MVC.Web.DataAccess;
using Fiap.Nac.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Nac.MVC.Web.Controllers
{
    public class DisciplinaController : Controller
    {
        private EscolaContext _context = new EscolaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Disciplina disciplina)
        {
            _context.Disciplinas.Add(disciplina);
            _context.SaveChanges();
            TempData["msg"] = "Disciplina Cadastrada!";
            return View();
        }
    }
}