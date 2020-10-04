using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Objects;
using System.Data.Entity;
using Livraria.Modelo;

namespace Livraria.Repositorio.Repositorios
{
    public class RepositorioSQLServer<TRepositorio> : IRepositorio<TRepositorio>
        where TRepositorio : class
    {

        #region RepositorioSQLServer: Métodos Privados

        private IQueryable<TRepositorio> _obterIncludes(Type TRepositorioType)
        {
            if (TRepositorioType == typeof(Modelo.ItemDeVenda))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("ProdutoVendido");

            if (TRepositorioType == typeof(Modelo.Cidade))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("UF");

            if (TRepositorioType == typeof(Modelo.Bairro))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("Cidade")
                    .Include("Cidade.UF");

            if (TRepositorioType == typeof(Modelo.Endereco))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("Bairro")
                    .Include("Bairro.Cidade")
                    .Include("Bairro.Cidade.UF");


            if (TRepositorioType == typeof(Modelo.PessoaFisica))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("Telefones")
                    .Include("Enderecos");

            if (TRepositorioType == typeof(Modelo.PessoaJuridica))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("Telefones")
                    .Include("Enderecos");

            if (TRepositorioType == typeof(Modelo.Venda))
                return SqlEF4Context<TRepositorio>.Contexto.GetData
                    .Include("Cliente")
                    .Include("Cliente.Telefones")
                    .Include("Cliente.Enderecos")
                    .Include("ItensVendidos");

            return SqlEF4Context<TRepositorio>.Contexto.GetData;
        }

        #endregion

        #region RepositorioSQLServer: IRepositorio<TRepositorio> Members

        public List<TRepositorio> Selecionar()
        {
            Type TRepositorioType = typeof(TRepositorio);
            IQueryable<TRepositorio> selecionador = _obterIncludes(TRepositorioType);

            return selecionador.ToList();
        }

        public List<TRepositorio> Selecionar(Predicate<TRepositorio> selector)
        {
            return Selecionar().FindAll(selector);
        }

        public void Inserir(TRepositorio t)
        {
            SqlEF4Context<TRepositorio>.Contexto.Entry(t).State = System.Data.EntityState.Unchanged;
            SqlEF4Context<TRepositorio>.Contexto.GetData.Add(t);
            SqlEF4Context<TRepositorio>.Contexto.SaveChanges();
        }

        public void Alterar(TRepositorio t_antigo, TRepositorio t_novo)
        {
            SqlEF4Context<TRepositorio>.Contexto.Entry(t_novo).State = System.Data.EntityState.Modified;
            SqlEF4Context<TRepositorio>.Contexto.SaveChanges();
        }

        public void Excluir(TRepositorio t)
        {
            TRepositorio t_valor = Selecionar(s => (s as Modelo.ModeloBase).ID == (t as Modelo.ModeloBase).ID).First();
            SqlEF4Context<TRepositorio>.Contexto.GetData.Remove(t_valor);
            SqlEF4Context<TRepositorio>.Contexto.SaveChanges();
        }

        #endregion

    }
}
