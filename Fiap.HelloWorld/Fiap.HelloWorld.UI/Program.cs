using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma PessoaFisica
            PessoaFisica pf = new PessoaFisica("Ash, da cidade de Pallet", "123");
            pf.Nome = "Ash, da cidade de Pallet";
            Console.WriteLine(pf.Nome);

            //Instanciar uma PessoaJuridica
            PessoaJuridica pj = new PessoaJuridica("Fiap")
            {
                Nome = "Fiap",
                DataFundacao = DateTime.Now
            };

            Console.ReadLine();
        }
    }
}
