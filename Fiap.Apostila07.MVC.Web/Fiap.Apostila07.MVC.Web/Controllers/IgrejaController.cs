using Fiap.Apostila07.MVC.Web.DataAccess;
using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila07.MVC.Web.Controllers
{
    public class IgrejaController : Controller
    {
        private IgrejaContext _context = new IgrejaContext();

        //Listar as igrejas
        [HttpGet]
        public ActionResult Listar()
        {
            //Busca todas as igrejas
            //include -> carrega o relacionamento
            var lista = _context.Igrejas.Include("Padre").ToList();
            //Passa a lista para a tela
            return View(lista);
        }


        [HttpGet] //Abre a tela com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Cadastrar as informações no banco
        public ActionResult Cadastrar(Igreja igreja)
        {
            //Cadastra no banco de dados
            _context.Igrejas.Add(igreja);
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Igreja cadastrada";
            return View();
        }
    }
}