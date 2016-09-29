using Fiap.Apostila08.MVC.Web.DataAccess;
using Fiap.Apostila08.MVC.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {
        private FiapMotorsContext _context = new FiapMotorsContext();

        private IMarcaRepository _marcaRepository;

        public IMarcaRepository MarcaRepository
        {
            get
            {
                if (_marcaRepository == null)
                {
                    _marcaRepository = new MarcaRepository(_context);
                }
                return _marcaRepository;
            }
        }

        //propfull -> tab tab
        private ICarroRepository _carroRepository;

        public ICarroRepository CarroRepository
        {
            get
            {
                if (_carroRepository == null)
                {
                    _carroRepository = new CarroRepository(_context);
                }
                return _carroRepository;
            }            
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                _context.Dispose(); //Libera o recurso
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //Finaliza o UnitOfWork
        }
    }
}