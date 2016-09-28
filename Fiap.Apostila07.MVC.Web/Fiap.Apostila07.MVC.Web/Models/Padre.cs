using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Padre
    {
        public int PadreId { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Data de Batismo")]
        public DateTime DataBatismo { get; set; }
    }
}