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
    [Description("Pessoa.")]
    public class Pessoa
    {
        public Pessoa()
        {
            //Email = string.Empty;
            //Observacao = string.Empty;
            //Endereco = new List<Endereco>();
            //Telefone = new List<Telefone>();
        }

        public int ID
        {
            get;
            set;
        }

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

        public virtual List<Endereco> Enderecos { get; set; }
        public virtual List<Telefone> Telefones { get; set; }
    }

}
