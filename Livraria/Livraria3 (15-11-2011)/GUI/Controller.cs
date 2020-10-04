using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Livraria.Utilitario;

namespace Livraria.GUI
{
    public class Controller: IDisposable
    {
        #region Controller: Propriedades e Atributos



        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Controller: Métodos Internos

        internal void Inserir<T>(T item)
            where T : Modelo.ModeloBase
        {
            Livraria.Dominio.Contract.Livraria<T> livraria = new Dominio.Contract.Livraria<T>();
            livraria.Inserir(item);
        }

        internal List<T> ObterTodos<T>()
            where T : Modelo.ModeloBase
        {
            Livraria.Dominio.Contract.Livraria<T> livraria = new Dominio.Contract.Livraria<T>();
            return livraria.SelecionarTodos();
        }

        internal List<T> ObterTodos<T>(Predicate<T> selector)
            where T : Modelo.ModeloBase
        {
            Livraria.Dominio.Contract.Livraria<T> livraria = new Dominio.Contract.Livraria<T>();
            return livraria.SelecionarTodos(selector);
        }

        internal void Excluir<T>(T item)
            where T : Modelo.ModeloBase
        {
            Livraria.Dominio.Contract.Livraria<T> livraria = new Dominio.Contract.Livraria<T>();
            livraria.Remover(item);
        }

        internal void Alterar<T>(T item_antigo, T item_novo)
            where T : Modelo.ModeloBase
        {
            Livraria.Dominio.Contract.Livraria<T> livraria = new Dominio.Contract.Livraria<T>();
            livraria.Alterar(item_antigo, item_novo);
        }

        #endregion

        #region Controller: Outros

        internal IList<Utilitario.EnumItem> ObterEnumerados<T>()
        {
            T enumeracao = default(T);
            Enum enumeracaoParametro = enumeracao as Enum;

            return enumeracaoParametro.ObterDescricoes();
        }

        internal bool CodeFirst()
        {
            return Livraria.Dominio.DominioBase.CodeFirst();
        }

        #endregion

    }
}
