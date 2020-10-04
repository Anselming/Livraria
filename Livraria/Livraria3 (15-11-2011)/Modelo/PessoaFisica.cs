using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Livraria.Utilitario;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Pessoa Física")]
    public class PessoaFisica: Pessoa, ICloneable
    {
        #region PessoaFisica: Construtores

        public PessoaFisica()
        {
            //Nome = string.Empty;
            //Cpf = string.Empty;
            //DataNascimento = default(DateTime);


        }
        #endregion

        #region PessoaFisica: Propriedades

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private string cpf;
        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return this.dataNascimento; }
            set { this.dataNascimento = value; }
        }

        #endregion

        #region PessoaFisica: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is PessoaFisica))
                return false;

            PessoaFisica OtherFisica = (PessoaFisica)obj;
            return this.GetHashCode() == OtherFisica.GetHashCode();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();

            //int hash = 0;

            //if (Nome != null)
            //    hash ^= Nome.GetHashCode();

            //if (Cpf != null)
            //    hash ^= Cpf.GetHashCode();

            //return hash;
        }

        public override string ToString()
        {
            return this.Nome;
        }

        #endregion

        #region PessoaFisica: ICloneable Members

        public new object Clone()
        {
            PessoaFisica pf = new PessoaFisica()
            {
                Nome = (string)this.Nome.Clone(),
                Observacao = (string)this.Observacao.Clone(),
                Email = (string)this.Email.Clone(),
                DataNascimento = this.DataNascimento,
                Cpf = (string)this.Cpf.Clone(),
                ID = (int)this.ID,
            };

            return pf;
        }

        #endregion
    }
}
