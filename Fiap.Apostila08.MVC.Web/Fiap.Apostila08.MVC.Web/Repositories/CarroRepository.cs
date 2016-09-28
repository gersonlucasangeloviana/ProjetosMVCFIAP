using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.DataAccess;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private FiapMotorsContext _context;

        //ctor -> tab tab (Construtor)
        public CarroRepository(FiapMotorsContext context)
        {
            this._context = context;
        }

        public void Atualizar(Carro carro)
        {
            _context.Entry(carro).State = System.Data.Entity.EntityState.Modified;
        }

        public List<Carro> BuscarPor(Expression<Func<Carro, bool>> filtro)
        {
            return _context.Carros.Where(filtro).ToList();
        }

        public void Cadastrar(Carro carro)
        {
            _context.Carros.Add(carro);
        }

        public Carro Consultar(int id)
        {
            return _context.Carros.Find(id);
        }

        public List<Carro> Listar()
        {
            return _context.Carros.ToList();
        }

        public void Remover(int id)
        {
            var carro = Consultar(id);
            _context.Carros.Remove(carro);
        }
    }
}