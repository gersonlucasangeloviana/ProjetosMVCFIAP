using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Igreja
    {
        //O EF já sabe que ele é a chave primária        
        public int IgrejaId { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        //Relacionamento One-to-One
        public Padre Padre { get; set; }
        public int PadreId { get; set; }

        //Relacionamento One-to-Many
        public virtual List<Missa> Missas { get; set; }

    }
}