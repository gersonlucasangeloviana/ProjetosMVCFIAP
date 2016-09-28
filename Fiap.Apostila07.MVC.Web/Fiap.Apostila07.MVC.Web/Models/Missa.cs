using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Missa
    {
        public int MissaId { get; set; }
        public DateTime Data { get; set; }
        public string Passagem { get; set; }

        //Relacionamento Many-to-One bi-direcional
        public Igreja Igreja { get; set; }
        public int IgrejaId { get; set; }

        //Relacionamento Many-To-Many
        public List<Fiel> Fieis { get; set; }
    }
}