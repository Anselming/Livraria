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
    public class Cidade : ModeloBase, ICloneable
    {
        #region Cidade: Construtores

        public Cidade()
        {
        }

        #endregion

        #region Cidade: Propriedades

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        [Category("Relacionamentos"), Browsable(false)]
        public List<Bairro> Bairros { get; set; }

        [Category("Relacionamentos"), Browsable(false)]
        public int UfId
        {
            get;
            set;
        }

        [Category("Relacionamentos"), Browsable(true)]
        public UnidadeFederativa UF
        { 
            get; 
            set; 
        }

        #endregion

        #region Cidade: Overrides

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

        #endregion

        #region Cidade: ICloneable Members

        public object Clone()
        {
            Cidade c = new Cidade()
            {
                Nome = (string)this.Nome.Clone(),
                UF = (UnidadeFederativa)this.UF.Clone(),
                ID = (int)this.ID,
                UfId = (int)this.UfId,
                Bairros = (List<Bairro>)this.Bairros,
            };

            return c;
        }

        #endregion

    }
}
