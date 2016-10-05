using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Carro
    {
        public int CarroId { get; set; }

        [Required(ErrorMessage = "Modelo é obrigatório")]
        [StringLength(maximumLength:150,ErrorMessage = "Máximo de 150")]
        public string Modelo { get; set; }

        [Range(minimum:1990,maximum:2017,ErrorMessage = "Ano inválido")]
        public int Ano { get; set; }

        //Relacionamento com marca
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }
    }
}