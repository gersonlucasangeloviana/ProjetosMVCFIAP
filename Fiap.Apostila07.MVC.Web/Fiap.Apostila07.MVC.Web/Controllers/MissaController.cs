using Fiap.Apostila07.MVC.Web.DataAccess;
using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila07.MVC.Web.Controllers
{
    public class MissaController : Controller
    {
        private IgrejaContext _context = new IgrejaContext();

        [HttpGet]
        public ActionResult Buscar(int codigoIgreja)
        {
            //Pesquisar a missa pelo código da igreja
            var lista = _context.Missas
                .Include("Igreja").Where(m => m.IgrejaId == codigoIgreja).ToList();
            CarregarIgrejas();
            // Configura a página que será retornada e passa a lista
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarIgrejas();
            return View();
        }

        private void CarregarIgrejas()
        {
            //Buscar todas as igrejas cadastradas
            var igrejas = _context.Igrejas.ToList();
            //Passar para a view o objeto para preencher o select
            ViewBag.opcoes = new SelectList(igrejas, "IgrejaId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Missa missa)
        {
            _context.Missas.Add(missa);
            _context.SaveChanges();
            TempData["msg"] = "Missa registrada";
            //Chama a action Cadastrar
            return RedirectToAction("Cadastrar");
        }

        //Listagem de Missas
        //mvcaction4 -> tab tab
        [HttpGet]
        public ActionResult Listar()
        {
            CarregarIgrejas(); //Carrega as informações para o select
            //Busca no banco todas as missas
            var lista = _context.Missas.Include("Igreja").ToList();
            //Passa a lista para a view 
            return View(lista);
        }

    }
}