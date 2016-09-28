using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.DataAccess
{
    public class IgrejaContext : DbContext
    {
        public DbSet<Padre> Padres { get; set; }
        public DbSet<Missa> Missas { get; set; }
        public DbSet<Fiel> Fieis { get; set; }
        public DbSet<Igreja> Igrejas { get; set; }
    }
}