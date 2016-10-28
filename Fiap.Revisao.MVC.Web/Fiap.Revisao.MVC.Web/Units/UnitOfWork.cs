using Fiap.Revisao.MVC.Web.DataAccess;
using Fiap.Revisao.MVC.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.Units
{
    public class UnitOfWork : IDisposable
    {
        private BibliotecaContext _context = new BibliotecaContext();

        private ILivroRepository _livroRepository;

        public ILivroRepository LivroRepository
        {
            get
            {
                if (_livroRepository == null)
                {
                    _livroRepository = new LivroRepository(_context);
                }
                return _livroRepository;
            }
        }

        private IEditoraRepository _editoraRepository;

        public IEditoraRepository EditoraRepository
        {
            get
            {
                if (_editoraRepository == null)
                {
                    _editoraRepository = new EditoraRepository(_context);
                }
                return _editoraRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        public void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}