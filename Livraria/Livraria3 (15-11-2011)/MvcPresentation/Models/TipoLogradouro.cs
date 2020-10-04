using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo
{    
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Tipo de Logradouro.")]
    public class TipoLogradouro :  ICloneable
    {
        //[Description("Avenida")]
        //Avenida,

        //[Description("Rua")]
        //Rua,

        //[Description("Estrada")]
        //Estrada,

        //[Description("Praça")]
        //Praca,

        //[Description("Travessa")]
        //Travessa
        
        public int ID
        {
            get;
            set;
        }

        private string desc;
        public string Descricao
        {
            get { return this.desc; }
            set { this.desc = value; }
        }

        // public virtual List<Endereco> Enderecos { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            if (Descricao != null)
                sb.AppendFormat(" {0}", Descricao);

            return sb.ToString();

        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TipoLogradouro))
                return false;

            TipoLogradouro OtherTipoLogradouro = (TipoLogradouro)obj;
            return this.GetHashCode() == OtherTipoLogradouro.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
        public object Clone()
        {
            TipoLogradouro e = new TipoLogradouro()
            {
                Descricao = (string)this.Descricao.Clone()
            };

            return e;
        }
    }
}
