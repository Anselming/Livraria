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
    [Description("Bairro de uma Cidade.")]
    public class Bairro : ICloneable
    {
        
        public Bairro()
        {
            //Nome = string.Empty;
            //Cidade = new Cidade();
        }

        //[Key, Column(Order = 1)]
     
        public  int ID
        {
            get;
            set;
        }

        //[StringLength(50)]
       // [Key, Column(Order = 1)]
        public  string Nome
        {
            get;
            set;
        }

        [Browsable(false)]
        public int CidadeId
        {
            get;
            set;
        }
        public virtual Cidade Cidade { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Bairro))
                return false;

            Bairro Otherbairro = (Bairro)obj;
            return this.GetHashCode() == Otherbairro.GetHashCode();
        }

        public override int GetHashCode()
        {
            int hash = 0;

            if (Cidade != null)
                hash ^= Cidade.GetHashCode();

            if (Nome != null)
                hash ^= Nome.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Nome != null)
                sb.Append(Nome);

            if (Cidade != null)
                sb.AppendFormat(", ({0})",Cidade.ToString());

            return this.Nome;
        }

        public object Clone()
        {
            Bairro b = new Bairro()
            {
                Cidade = (Cidade)this.Cidade.Clone(),
                Nome = (string)this.Nome.Clone(),
            };

            return b;
        }
    }
}
