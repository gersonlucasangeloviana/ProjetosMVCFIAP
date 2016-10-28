using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}