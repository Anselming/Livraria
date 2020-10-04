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

namespace Livraria.Modelo
{
    public class Context : DbContext
    {
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<UnidadeFederativa> UFs { get; set; }
        public DbSet<PessoaFisica> Fisicas { get; set; }
        public DbSet<PessoaJuridica> Juridicas { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }
        public DbSet<TipoLogradouro> Logradouro { get; set; }

        public Context()
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["Livraria"].ConnectionString;
            //this.Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Entity<PessoaFisica>().HasKey(r => r.ID);
            modelBuilder.Entity<PessoaJuridica>().HasKey(r => r.ID);
            modelBuilder.Entity<Endereco>().HasKey(r => r.ID);
            modelBuilder.Entity<Telefone>().HasKey(r => r.ID);

            modelBuilder.Entity<PessoaFisica>().HasMany(t => t.Telefones).WithMany(p => p.Fisicas).Map(m => { m.MapLeftKey("FisicaID"); m.MapRightKey("TelefoneID"); m.ToTable("TelefoneFisica"); });
            modelBuilder.Entity<PessoaJuridica>().HasMany(t => t.Telefones).WithMany(p => p.Juridica).Map(m => { m.MapLeftKey("JuridicaID"); m.MapRightKey("TelefoneID"); m.ToTable("TelefoneJuridica"); });

            modelBuilder.Entity<PessoaFisica>().HasMany(t => t.Enderecos).WithMany(p => p.Fisicas).Map(m => { m.MapLeftKey("FisicaID"); m.MapRightKey("EnderecosID"); m.ToTable("EnderecosFisica"); });
            modelBuilder.Entity<PessoaJuridica>().HasMany(t => t.Enderecos).WithMany(p => p.Juridica).Map(m => { m.MapLeftKey("JuridicaID"); m.MapRightKey("EnderecosID"); m.ToTable("EnderecosJuridica"); });

            

            //modelBuilder.Entity<Cidade>().HasKey(r => r.CidadeId);
            //modelBuilder.Entity<Bairro>().HasRequired(d => d.Cidade).WithMany().HasForeignKey(d => d.CidadeId).WillCascadeOnDelete();
            //modelBuilder.Configurations.Add(new BairroMap());
        }

    }

    //public class BairroMap : EntityTypeConfiguration<Bairro>
    //{
    //    public BairroMap()
    //    {
    //        Property(t => t.Nome).HasMaxLength(235);
    //        //HasRequired(p => p.Cidade).WithMany(c => c.Bairros).HasForeignKey(p => p.CidadeID);
    //    }
    //}
}
