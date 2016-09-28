using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    public class PessoaFisica : Pessoa
    {
        //Construtor que chama o construtor do pai
        public PessoaFisica(string nome, string cpf):base(nome)
        {
            this.Cpf = cpf;
        }

        //Enum
        public Sexo Sexo { get; set; }
        public string Cpf { get; set; }
        public bool MaiorIdade { get; set; }

        //Implementação do método abstrato
        public override void Vender()
        {
            Console.WriteLine("PF vendendo...");
        }
    }
}
