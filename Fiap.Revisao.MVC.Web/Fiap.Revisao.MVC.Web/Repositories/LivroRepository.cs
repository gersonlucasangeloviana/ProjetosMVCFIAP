using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.DataAccess;

namespace Fiap.Revisao.MVC.Web.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private BibliotecaContext _context;

        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
        }

        public List<Livro> Listar()
        {
            return _context.Livros.Include("Editora").ToList();
        }

        public void Reservar(int id)
        {
            var livro = _context.Livros.Find(id);
            livro.Status = Status.Reservado;
        }
    }
}