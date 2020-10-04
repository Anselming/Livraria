using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Objects;
using System.Configuration;

namespace Livraria.Repositorio.Repositorios
{
    internal class SqlEF4Context<T> : DbContext
        where T: class
    {

        #region SqlEF4Context<T>: Propriedades

        public DbSet<T> GetData
        {
            get;
            set;
        }

        private static SqlEF4Context<T> _contexto = null;
        public static SqlEF4Context<T> Contexto
        {
            get
            {
                if (_contexto == null)
                    _contexto = new SqlEF4Context<T>();

                return _contexto;
            }
        }
        #endregion

        #region SqlEF4Context<T>: Construtores

        private SqlEF4Context()
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["Livraria"].ConnectionString;
        }

        #endregion

        #region SqlEF4Context<T>: Overrides

        public static bool CodeFirst()
        {
            string tipoDePersistencia = ((string)ConfigurationManager.AppSettings["tipoPersistencia"]).Trim().ToLower();

            if (tipoDePersistencia == "banco")
            {
                bool existisDatabase = Contexto.Database.Exists();

                if (existisDatabase)
                    return false;
                else
                {
                    Contexto.Database.CreateIfNotExists();
                    return true;
                }
            }

            return false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Entity<Modelo.PessoaFisica>().HasMany(t => t.Telefones).WithMany(p => p.Fisicas).Map(m => { m.MapLeftKey("FisicaID"); m.MapRightKey("TelefoneID"); m.ToTable("TelefoneFisica"); });
            modelBuilder.Entity<Modelo.PessoaJuridica>().HasMany(t => t.Telefones).WithMany(p => p.Juridica).Map(m => { m.MapLeftKey("JuridicaID"); m.MapRightKey("TelefoneID"); m.ToTable("TelefoneJuridica"); });

            modelBuilder.Entity<Modelo.PessoaFisica>().HasMany(t => t.Enderecos).WithMany(p => p.Fisicas).Map(m => { m.MapLeftKey("FisicaID"); m.MapRightKey("EnderecosID"); m.ToTable("EnderecosFisica"); });
            modelBuilder.Entity<Modelo.PessoaJuridica>().HasMany(t => t.Enderecos).WithMany(p => p.Juridica).Map(m => { m.MapLeftKey("JuridicaID"); m.MapRightKey("EnderecosID"); m.ToTable("EnderecosJuridica"); });


            //modelBuilder.Entity<Modelo.Cidade>().HasKey(r => r.CidadeId);
            //modelBuilder.Entity<Modelo.Bairro>().HasRequired(d => d.Cidade).WithMany().HasForeignKey(d => d.CidadeId).WillCascadeOnDelete();
            //modelBuilder.Configurations.Add(new BairroMap());
        }

        #endregion

    }
}
