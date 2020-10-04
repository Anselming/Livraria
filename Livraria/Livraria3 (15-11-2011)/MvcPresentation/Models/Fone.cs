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
    [Description("Telefone.")]
    public class Telefone : ICloneable
    {
        #region Telefone: Construtores

        public Telefone()
        {
            //Ddd = string.Empty;
            //Numero = string.Empty;
            //Ramal = string.Empty;
        }

        #endregion

        #region Telefone: Propriedades

        private string ddd;
        public string Ddd
        {
            get { return this.ddd; }
            set { this.ddd = value; }
        }

        private string numero;
        public string Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        private string ramal;
        public string Ramal
        {
            get { return this.ramal; }
            set { this.ramal = value; }
        }

        public int ID
        {
            get;
            set;
        }

        [Category("Relacionamentos"), Browsable(false)]
        public List<PessoaFisica> Fisicas { get; set; }

        [Category("Relacionamentos"), Browsable(false)]
        public List<PessoaJuridica> Juridica { get; set; }

        #endregion

        #region Telefone: Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Telefone))
                return false;

            Telefone OtherTelefone = (Telefone)obj;
            return this.GetHashCode() == OtherTelefone.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("({0}) {0}{1}", this.Ddd, this.Numero, (string.IsNullOrEmpty(this.Ramal)) ? string.Empty : this.Ramal);
        }

        #endregion

        #region Telefone: ICloneable Members

        public object Clone()
        {
            Telefone t = new Telefone()
            {
                Ddd = (string)this.Ddd,
                Numero = (string)this.Numero,
                Ramal = (string)this.ramal,
                ID = (int)this.ID,
            };

            return t;
        }

        #endregion
    }
}
