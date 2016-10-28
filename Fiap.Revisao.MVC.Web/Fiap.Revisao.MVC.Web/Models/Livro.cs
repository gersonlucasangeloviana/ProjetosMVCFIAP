using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.Models
{
    public class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public Status Status { get; set; }

        public Editora Editora { get; set; }
        public int EditoraId { get; set; }

    }
}