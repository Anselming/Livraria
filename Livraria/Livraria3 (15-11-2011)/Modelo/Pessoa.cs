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
    [Description("Pessoa.")]
    [System.Xml.Serialization.XmlInclude(typeof(PessoaFisica))]
    [System.Xml.Serialization.XmlInclude(typeof(PessoaJuridica))]
    public class Pessoa : ModeloBase, ICloneable
    {
        #region Pessoa: Construtores

        public Pessoa()
        {
            //Email = string.Empty;
            //Observacao = string.Empty;
            //Endereco = new List<Endereco>();
            //Telefone = new List<Telefone>();

        }
        #endregion

        #region Pessoa: Propriedades

        private string email;
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        private string observacao;
        public string Observacao
        {
            get { return this.observacao; }
            set { this.observacao = value; }
        }

        [Category("Relacionamentos"), Browsable(true)]
        public List<Endereco> Enderecos { get; set; }

        [Category("Relacionamentos"), Browsable(true)]
        public List<Telefone> Telefones { get; set; }

        #endregion

        #region Pessoa: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Pessoa))
                return false;

            Pessoa OtherPessoa = (Pessoa)obj;
            return this.GetHashCode() == OtherPessoa.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (Email != null)
                hash ^= Email.GetHashCode();

            return hash;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Email != null)
                sb.Append(Email.ToString());

            return sb.ToString();
        }

        #endregion

        #region Pessoa: ICloneable Members

        public object Clone()
        {
            Pessoa p = new Pessoa()
            {
                Email = (string)this.Email.Clone(),
                Observacao = (string)this.Observacao.Clone(),
                ID = (int)this.ID,
            };

            return p;

        }

        #endregion

    }
}
