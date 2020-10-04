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
    public partial class ucProduto : ucUserControlBase
    {
        #region ucProduto: Construtores

        public ucProduto()
        {
            InitializeComponent();
        }

        #endregion

        #region ucProduto: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(380, 250);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(320, 130);
        }

        public override object ObterVariacao()
        {
            string nome = ttb_Nome.Text;
            string descricao = ttb_Descricao.Text;
            string valor = ttb_ValorUnitario.Text;

            Modelo.Produto produto = new Modelo.Produto()
            {
                Nome = nome,
                Descricao = descricao,
                Valor = decimal.Parse(valor),
            };

            return produto;
        }

        #endregion

        #region ucProduto: Eventos

        #endregion
    }
}
