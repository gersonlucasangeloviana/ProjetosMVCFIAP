using Fiap.Nac.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Nac.MVC.Web.DataAccess
{
    public class EscolaContext : DbContext
    {
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}