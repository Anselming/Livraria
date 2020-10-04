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
    [Description("Cidade.")]
    public class Cidade :  ICloneable
    {
        public Cidade()
        {
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

        //public virtual List<Bairro> Bairros { get; set; }

        [Browsable(false)]
        public int UfId
        {
            get;
            set;
        }
        public virtual UnidadeFederativa UF
        { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Cidade))
                return false;

            Cidade OtherCidade = (Cidade)obj;
            return this.GetHashCode() == OtherCidade.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (Nome != null)
                hash ^= Nome.GetHashCode();

            if (UF != null)
                hash ^= UF.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Nome != null)
                sb.Append(Nome);

            if (UF != null)
                sb.AppendFormat(", ({0})", UF.ToString());

            return this.Nome;
        }

        public object Clone()
        {
            Cidade c = new Cidade()
            {
                Nome = (string)this.Nome.Clone(),
                UF = (UnidadeFederativa)this.UF.Clone(),
            };

            return c;
        }
    }
}
