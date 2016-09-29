using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.DataAccess;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private FiapMotorsContext _context;

        //ctor -> tab tab (Construtor)
        public MarcaRepository(FiapMotorsContext context)
        {
            _context = context;
        }

        public void Cadastrar(Marca marca)
        {
            _context.Marcas.Add(marca);
        }

        public List<Marca> Listar()
        {
            return _context.Marcas.ToList();
        }
    }
}