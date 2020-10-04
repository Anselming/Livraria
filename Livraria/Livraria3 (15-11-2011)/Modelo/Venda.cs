using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Livraria.Utilitario;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Venda.")]
    public class Venda : ModeloBase, ICloneable
    {
        #region Venda: Construtores

        public Venda()
        { 
        
        }
	    #endregion

        #region Venda: Propriedades

        public Pessoa Cliente { get; set; }
        public List<ItemDeVenda> ItensVendidos { get; set; }

        [Description("Somatório do valor de todos os produtos")]
        [Category("Sumário")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string Custo
        {
            get
            {
                return string.Format("{0} R$", CustoDecimal);
            }
        }

        [Browsable(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string CustoDecimal
        {
            get
            {
                decimal valorTotal = default(decimal);
                if (ItensVendidos != null)
                {
                    foreach (ItemDeVenda item in ItensVendidos)
                    {
                        valorTotal += item.CustoDecimal;
                    }
                }
                return string.Format("{0} R$", valorTotal);
            }
        }
        #endregion

        #region Venda: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Venda))
                return false;

            Venda OtherVenda = (Venda)obj;
            return this.GetHashCode() == OtherVenda.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (Cliente != null)
                hash ^= Cliente.GetHashCode();

            if (ItensVendidos != null)
                hash ^= ItensVendidos.GetHashCode<Modelo.ItemDeVenda>();

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Cliente != null)
                sb.Append(Cliente.ToString());

            if (ItensVendidos != null)
                sb.AppendFormat(", ({0})",ItensVendidos.ToString());


            return sb.ToString();
        }

        #endregion

        #region Venda: ICloneable Members

        public object Clone()
        {
            Venda v = new Venda()
            {
                ItensVendidos = this.ItensVendidos.CloneList(),
                ID = this.ID,
            };

            if (this.Cliente != null)
                v.Cliente = (Modelo.Pessoa)this.Cliente.Clone();

            return v;

        }

        #endregion
    }
}
