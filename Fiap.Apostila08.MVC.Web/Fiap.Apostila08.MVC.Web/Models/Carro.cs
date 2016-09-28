using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        //Relacionamento com marca
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }
    }
}