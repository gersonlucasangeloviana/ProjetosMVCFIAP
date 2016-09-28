using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    public class PessoaJuridica : Pessoa
    {
        //Construtor
        public PessoaJuridica(string nome):base(nome)
        {

        }

        //Propriedades
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public decimal Faturamento { get; set; }
        public DateTime DataFundacao { get; set; }

        public override void Vender()
        {
            Console.WriteLine("PJ vendendo");
        }

        //Polimorfismo -> sobrescrever o comportamento do método comprar
        public override void Comprar()
        {
            Console.WriteLine("Comprando muito..");
        }
    }
}
