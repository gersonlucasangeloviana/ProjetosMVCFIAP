using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.DataAccess
{
    public class FiapMotorsContext : DbContext
    {
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Carro> Carros { get; set; }
    }
}