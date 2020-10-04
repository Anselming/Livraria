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
    [Description("Endereço completo.")]
    public class Endereco:  ICloneable
    {
        public Endereco()
        {
            //EnderecoValue = string.Empty;
            //Bairro = new Bairro();
            //CEP = string.Empty;
            //Logradouro = new TipoLogradouro();
        }

        [Browsable(false)]
        public int ID
        {
            get;
            set;
        }

        private string descricao;
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        [Browsable(false)]
        public int BairroId
        {
            get;
            set;
        }
        public virtual Bairro Bairro { get; set; }

        private string cep;
        public string CEP
        {
            get { return this.cep; }
            set { this.cep = value; }
        }

        [Browsable(false)]
        public virtual List<PessoaFisica> Fisicas { get; set; }
        [Browsable(false)]
        public virtual List<PessoaJuridica> Juridica { get; set; }

        [Browsable(false)]
        public int TipoLogradouroId
        {
            get;
            set;
        }
        public virtual TipoLogradouro TipoLogradouro { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (TipoLogradouro != null)
                sb.Append(TipoLogradouro.ToString());

            if (Descricao != null)
                sb.AppendFormat(" {0}", Descricao);

            if (Bairro != null)
                sb.AppendFormat(" {0}", Bairro.ToString());

            if (CEP != null)
                sb.AppendFormat(" {0}", CEP.ToString());

            return sb.ToString();

        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Endereco))
                return false;

            Endereco OtherEndereco = (Endereco)obj;
            return (this.GetHashCode() == OtherEndereco.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public object Clone()
        {
            Endereco e = new Endereco()
            {
                Bairro = (Bairro)this.Bairro.Clone(),
                CEP = (string)this.CEP.Clone(),
                Descricao = (string)this.Descricao.Clone(),
                TipoLogradouro = this.TipoLogradouro,
            };

            return e;
        }
    }
}
