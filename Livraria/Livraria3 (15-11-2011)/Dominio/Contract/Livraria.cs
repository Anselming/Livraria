using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Livraria.Utilitario;

namespace Livraria.Dominio.Contract
{
    public class Livraria<T> : DominioBase
        where T: Modelo.ModeloBase
    {
        public List<T> SelecionarTodos()
        {
            using (Repositorio.ServiceAgent.ServiceAgent<T> dados = new Repositorio.ServiceAgent.ServiceAgent<T>())
            {
                return dados.Repositorio.Selecionar();
            }
        }
        public List<T> SelecionarTodos(Predicate<T> selector )
        {
            using (Repositorio.ServiceAgent.ServiceAgent<T> dados = new Repositorio.ServiceAgent.ServiceAgent<T>())
            {
                return dados.Repositorio.Selecionar(selector);
            }
        }
        public void Inserir(T item)
        {
            using (Repositorio.ServiceAgent.ServiceAgent<T> dados = new Repositorio.ServiceAgent.ServiceAgent<T>())
            {
                dados.Repositorio.Inserir(item);
            }
        }
        public void Remover(T item)
        {
            using (Repositorio.ServiceAgent.ServiceAgent<T> dados = new Repositorio.ServiceAgent.ServiceAgent<T>())
            {
                dados.Repositorio.Excluir(item);
            }
        }
        public void Alterar(T item_antigo, T item_novo)
        {
            using (Repositorio.ServiceAgent.ServiceAgent<T> dados = new Repositorio.ServiceAgent.ServiceAgent<T>())
            {
                dados.Repositorio.Alterar(item_antigo, item_novo);
            }
        }

    }
}
