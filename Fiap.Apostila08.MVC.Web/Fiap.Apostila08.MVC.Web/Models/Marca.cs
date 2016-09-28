using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set; }

        //Relacionamento
        public List<Carro> Carros { get; set; }
    }
}