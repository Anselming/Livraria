using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Características do Produto.")]
    public class Produto : ModeloBase, ICloneable
    {
        #region Produto: Construtores

        public Produto()
        { 
        
        }

        #endregion

        #region Produto: Propriedades

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Valor { get; set; }

        #endregion

        #region Produto: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Produto))
                return false;

            Produto OtherProduto = (Produto)obj;
            return this.GetHashCode() == OtherProduto.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (Nome != null)
                hash ^= Nome.GetHashCode();

            if (Descricao != null)
                hash ^= Descricao.GetHashCode();

            if (Valor != null)
                hash ^= Valor.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Nome != null)
                sb.Append(Nome);

            if (Descricao != null)
                sb.AppendFormat(", {0}", Descricao.ToString());

            sb.AppendFormat(", ({0} R$)", Valor.ToString());

            
            return sb.ToString();
        }

        #endregion

        #region Produto: ICloneable Members

        public object Clone()
        {
            Produto p = new Produto()
            {
                Nome = (string)this.Nome.Clone(),
                Descricao = (string)this.Descricao.Clone(),
                Valor = this.Valor,
                ID = this.ID,
            };

            return p;
        }

        #endregion
    }
}
