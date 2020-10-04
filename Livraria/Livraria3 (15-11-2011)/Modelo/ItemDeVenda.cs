using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Relação Quantidade x Produto em uma venda.")]
    public class ItemDeVenda : ModeloBase, ICloneable
    {
        #region ItemDeVenda: Construtores

        public ItemDeVenda()
        { 
        
        }

        #endregion

        #region ItemDeVenda: Propriedades

        public Produto ProdutoVendido { get; set; }
        public int Quantidade { get; set; }

        [Browsable(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public decimal CustoDecimal
        {
            get
            {
                decimal valorParcial = default(decimal);
                if (ProdutoVendido != null)
                    valorParcial = ProdutoVendido.Valor * Quantidade;
                else
                    valorParcial = 0;

                return valorParcial;
            }
        }


        [Description("Custo do produto X a quantidade")]
        [Category("Sumário")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string Custo
        {
            get { return string.Format("{0} R$", CustoDecimal); }
        }

        #endregion

        #region ItemDeVenda: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ItemDeVenda))
                return false;

            ItemDeVenda OtherItemDeVenda = (ItemDeVenda)obj;
            return this.GetHashCode() == OtherItemDeVenda.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (ProdutoVendido != null)
                hash ^= ProdutoVendido.GetHashCode();

            if (Quantidade != null)
                hash ^= Quantidade.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (ProdutoVendido != null)
                sb.Append(ProdutoVendido.Nome);

            sb.AppendFormat(", ({0} unidades)", Quantidade);


            return sb.ToString();
        }

        #endregion

        #region ItemDeVenda: ICloneable Members

        public object Clone()
        {
            ItemDeVenda i = new ItemDeVenda()
            {
                Quantidade = this.Quantidade,
                ProdutoVendido = (Produto)this.ProdutoVendido.Clone(),
                ID = this.ID,
            };

            return i;

        }

        #endregion
    }
}
