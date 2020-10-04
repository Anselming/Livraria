using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Livraria.GUI.ViewModel
{
    public partial class ucTelefone : ucUserControlBase
    {
        #region ucTelefone: Construtores

        public ucTelefone()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucTelefone: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(420, 200);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(385, 86);
        }

        public override object ObterVariacao()
        {
            string ddd = ttb_DDD.Text;
            string numero = ttb_Numero.Text;
            string ramal = ttb_Ramal.Text;

            Modelo.Telefone telefone = new Modelo.Telefone()
            {
                Ddd = ddd,
                Numero = numero,
                Ramal = ramal,
            };

            return telefone;
        }
        #endregion

    }
}
