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
    public partial class ucUnidadeFederativa : ucUserControlBase
    {
        #region ucUnidadeFederativa: Construtores

        public ucUnidadeFederativa()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucUnidadeFederativa: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(420, 200);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return base.DefinirTamanhoDoContainer();
        }

        public override object ObterVariacao()
        {
            string nome = ttb_Nome.Text;
            string sigla = ttb_Sigla.Text;

            Modelo.UnidadeFederativa unidadeFederativa = new Modelo.UnidadeFederativa()
            {
                Nome = nome,
                Sigla = sigla
            };

            return unidadeFederativa;
        }

        #endregion
    }
}
