using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.Repositorio.Repositorios
{
    public interface IRepositorio<T> 
        where T: class
    {
        List<T> Selecionar();
        List<T> Selecionar(Predicate<T> selector);
        void Inserir(T t);
        void Alterar(T t_antigo, T t_novo);
        void Excluir(T t);
    }
}
