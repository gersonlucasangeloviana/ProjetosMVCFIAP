using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Fiel
    {
        public int FielId { get; set; }
        public string Nome { get; set; }
        
        //Relacionamento many-to-many
        //virtual -> fetch = LAZY (não carrega o relacionamento na busca)
        public virtual List<Missa> Missas { get; set; }
    }
}