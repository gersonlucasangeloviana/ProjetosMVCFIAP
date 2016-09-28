using Fiap.Apostila06.MVC.Web.DataAccess;
using Fiap.Apostila06.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila06.MVC.Web.Controllers
{
    public class MedicamentoController : Controller
    {
        //Contexto que gerencia as entidades
        private FarmaciaContext _context = new FarmaciaContext();

        [HttpGet]
        public ActionResult Filtrar(string nomeBusca)
        {
            //Faz o filtro
            var listaFiltrada = _context.Medicamentos
                .Where(m => m.Nome.Contains(nomeBusca)).ToList();
            //Devolve para a tela de lista com a lista filtrada
            return View("Listar",listaFiltrada);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            //Busca a entidade no banco
            var m = _context.Medicamentos.Find(id);
            //Remove a entidade 
            _context.Medicamentos.Remove(m);
            //Salva as alterações
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Medicamento removido";
            //Retornar para a listagem
            return RedirectToAction("Listar");
        }

        [HttpGet] //Abre a tela do formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Cadastrar no banco de dados
        public ActionResult Cadastrar(Medicamento medicamento)
        {
            //Cadastra no banco de dados
            _context.Medicamentos.Add(medicamento);
            _context.SaveChanges();
            //Mensagem para a view
            TempData["mensagem"] = "Cadastrado com sucesso!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passa a lista para a view
            return View(_context.Medicamentos.ToList());
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            //buscar o cara no banco (contexto)
            var cara = _context.Medicamentos.Find(id);
            //Devolver o cara pra view
            return View(cara);
        }

        [HttpPost]
        public ActionResult Atualizar(Medicamento medicamento)
        {
            //Mudar o estado da entidade para modificado
            _context.Entry(medicamento).State = 
                            System.Data.Entity.EntityState.Modified;
            //Salva as aterações no banco de dados
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Medicamento Atualizado";
            //Retornar para a tela de listagem
            return RedirectToAction("Listar");
        }
        
    }
}