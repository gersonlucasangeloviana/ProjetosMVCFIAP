using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila04.MVC.Web.Models
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public int Cp { get; set; }
        public DateTime DataCaptura { get; set; }
        public bool Raro { get; set; }
        public decimal Preco { get; set; }
    }
}