using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    public abstract class Pessoa
    {
        //construtor
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        //Fields - (Atributos)
        private string _nome;

        //Propriedades (Gets e Sets)
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Endereco { get; set; }
        public string Telefone { get; set; }

        //Métodos
        //virtual -> permite a sobrescrita do método nas classes filhas
        public virtual void Comprar()
        {
            Console.WriteLine("Pessoa comprando..");
        }

        //Método abstrato
        public abstract void Vender();

    }
}
