using Fiap.Revisao.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.DataAccess
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Editora> Editoras { get; set; }
    }
}