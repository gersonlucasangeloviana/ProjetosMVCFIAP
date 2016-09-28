using Fiap.Apostila06.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila06.MVC.Web.DataAccess
{
    public class FarmaciaContext : DbContext
    {
        public DbSet<Medicamento> Medicamentos { get; set; }
    }
}