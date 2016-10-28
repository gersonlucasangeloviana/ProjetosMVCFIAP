using Fiap.Revisao.MVC.Web.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.MVC.Web.Models;

namespace Fiap.Revisao.MVC.Web.Repositories
{
    public class EditoraRepository : IEditoraRepository
    {
        private BibliotecaContext _context;

        //ctor -> tab tab
        public EditoraRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Editora editora)
        {
            _context.Editoras.Add(editora);
        }

        public List<Editora> Listar()
        {
            return _context.Editoras.ToList();
        }
    }
}