using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Nac.MVC.Web.Models
{
    public class Avaliacao
    {
        public int AvaliacaoId { get; set; }
        public string Tema { get; set; }
        public DateTime Data { get; set; }
        public bool Sistema { get; set; }

        //Relacionamento
        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }
    }
}