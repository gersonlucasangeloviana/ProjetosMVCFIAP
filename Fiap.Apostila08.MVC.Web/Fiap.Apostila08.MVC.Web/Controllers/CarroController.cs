using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class CarroController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            _unit.CarroRepository.Remover(id);
            _unit.Salvar();
            TempData["msg"] = "Carro excluido";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Editar(Carro carro)
        {
            _unit.CarroRepository.Atualizar(carro);
            _unit.Salvar();
            TempData["msg"] = "Carro atualizado";
            return RedirectToAction("Listar");
        }

        [HttpGet] //Abre a tela com o formulário preenchido
        public ActionResult Editar(int id)
        {
            CarregarComboMarcas();
            //buscar o carro no banco
            var carro = _unit.CarroRepository.Consultar(id);
            //Passa o carro para a tela
            return View(carro);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Buscar os carros do banco de dados
            var carros = _unit.CarroRepository.Listar();
            return View(carros);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarComboMarcas();
            return View();
        }

        private void CarregarComboMarcas()
        {
            //Buscar todas as marcas
            var lista = _unit.MarcaRepository.Listar();
            //Envia os valores para o select (DropdownListFor)
            ViewBag.marcas = new SelectList(lista, "MarcaId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Carro carro)
        {
            _unit.CarroRepository.Cadastrar(carro);
            _unit.Salvar();
            TempData["msg"] = "Carro cadastrado";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}