using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Tipo de Endereço.")]
    public class TipoEndereco : ICloneable
    {
        //Comercial,
        //Residencial,
        //Cobranca,
        //Entrega

        [Browsable(false)]
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

        public object Clone()
        {
            TipoEndereco e = new TipoEndereco()
            {
                Descricao = (string)this.Descricao.Clone()
            };

            return e;
        }
    }
}
