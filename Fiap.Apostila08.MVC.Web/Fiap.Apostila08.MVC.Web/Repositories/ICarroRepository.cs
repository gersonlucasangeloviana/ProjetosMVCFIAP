using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public interface ICarroRepository
    {
        void Cadastrar(Carro carro);
        void Atualizar(Carro carro);
        void Remover(int id);
        Carro Consultar(int id);
        List<Carro> Listar();
        List<Carro> BuscarPor(Expression<Func<Carro,bool>> filtro);
    }
}
