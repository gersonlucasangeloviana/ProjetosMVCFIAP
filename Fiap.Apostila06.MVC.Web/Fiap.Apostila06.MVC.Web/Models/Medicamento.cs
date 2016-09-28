using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Apostila06.MVC.Web.Models
{
    public class Medicamento
    {
        public int MedicamentoId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        public string Tarja { get; set; }

        [Column("dt_validade")]
        public DateTime DataValidade { get; set; }

        public decimal Valor { get; set; }

        public bool Generico { get; set; }
    }
}