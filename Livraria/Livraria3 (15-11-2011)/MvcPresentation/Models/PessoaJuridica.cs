using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Pessoa Jurídica.")]
    public class PessoaJuridica: Pessoa
    {
        public PessoaJuridica()
        {
            //Cnpj = string.Empty;
            //NomeFantasia = string.Empty;
            //RazaoSocial = string.Empty;
            //IE = string.Empty;
            //IM = string.Empty;
        }


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
    }
}
