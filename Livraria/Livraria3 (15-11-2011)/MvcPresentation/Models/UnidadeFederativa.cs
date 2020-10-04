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
    [Description("Indica uma Unidade Federativa.")]
    public class UnidadeFederativa :  ICloneable
    {
        public UnidadeFederativa()
        {
            //Nome = string.Empty;
            //Sigla = string.Empty;
        }

        public int ID
        {
            get;
            set;
        }

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private string sigla;
        public string Sigla
        {
            get { return this.sigla; }
            set { this.sigla = value; }
        }

        // public virtual List<Cidade> Cidades { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Nome, Sigla);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is UnidadeFederativa))
                return false;

            UnidadeFederativa OtherUF = (UnidadeFederativa)obj;
            return this.GetHashCode() == OtherUF.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (Nome != null)
                hash ^= Nome.GetHashCode();

            if (Sigla != null)
                hash ^= Sigla.GetHashCode();

            return hash;
        }

        public object Clone()
        {
            UnidadeFederativa uf = new UnidadeFederativa()
            {
                Nome = (string)this.Nome.Clone(),
                Sigla = (string)this.Sigla.Clone(),
            };
            return uf;
        }
    }
}
