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
    [Description("Pessoa Jurídica.")]
    public class PessoaJuridica: Pessoa, ICloneable
    {
        #region PessoaJuridica: Construtores

        public PessoaJuridica()
        {
            //Cnpj = string.Empty;
            //NomeFantasia = string.Empty;
            //RazaoSocial = string.Empty;
            //IE = string.Empty;
            //IM = string.Empty;
        }

        #endregion

        #region PessoaJuridica: Propriedades

        private string cnpj;
        public string Cnpj
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        private string nomeFantasia;
        public string NomeFantasia
        {
            get { return this.nomeFantasia; }
            set { this.nomeFantasia = value; }
        }

        private string razaoSocial;
        public string RazaoSocial
        {
            get { return this.razaoSocial; }
            set { this.razaoSocial = value; }
        }

        private string iE;
        public string IE
        {
            get { return this.iE; }
            set { this.iE = value; }
        }

        private string iM;
        public string IM
        {
            get { return this.iM; }
            set { this.iM = value; }
        }

        #endregion

        #region PessoaJuridica: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is PessoaJuridica))
                return false;

            PessoaJuridica OtherJuridica = (PessoaJuridica)obj;
            return this.GetHashCode() == OtherJuridica.GetHashCode();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();

            //int hash = 0;

            //if (RazaoSocial != null)
            //    hash ^= RazaoSocial.GetHashCode();

            //if (Cnpj != null)
            //    hash ^= Cnpj.GetHashCode();

            //return hash;
        }

        public override string ToString()
        {
            return this.NomeFantasia;
        }

        #endregion

        #region PessoaJuridica: ICloneable Members

        public new object Clone()
        {
            PessoaJuridica pf = new PessoaJuridica()
            {
                NomeFantasia = (string)this.NomeFantasia.Clone(),
                RazaoSocial = (string)this.RazaoSocial.Clone(),
                IM = (string)this.IM.Clone(),
                IE = (string)this.IE.Clone(),
                Observacao = (string)this.Observacao.Clone(),
                Email = (string)this.Email.Clone(),
                Cnpj = (string)this.Cnpj.Clone(),
                ID = (int)this.ID,
            };

            return pf;

        }
        #endregion

    }
}
