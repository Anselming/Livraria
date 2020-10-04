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
    public partial class ucItemDeVenda : ucUserControlBase
    {
        #region ucItemDeVenda: Construtores

        public ucItemDeVenda()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucItemDeVenda: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(380, 200);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(320, 90);
        }

        public override object ObterVariacao()
        {
            Modelo.Produto produto = (Modelo.Produto)cmb_Produto.SelectedItem;
            string quantidade = ttb_Quantidade.Text;

            Modelo.ItemDeVenda itemVenda = new Modelo.ItemDeVenda()
            {
                ProdutoVendido = produto,
                Quantidade = int.Parse(quantidade),
            };

            return itemVenda;
        }

        public override void Atualizar()
        {
            using (Controller controller = new Controller())
            {
                // Obtem os bairros
                IList<Modelo.Produto> listaDeProdutos;
                listaDeProdutos = controller.ObterTodos<Modelo.Produto>();

                cmb_Produto.DataSource = listaDeProdutos;
                cmb_Produto.DisplayMember = "Nome";
                cmb_Produto.ValueMember = "Nome";

            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FormInserir form_ItemVenda = new FormInserir(Variation.Produto);
            form_ItemVenda.ShowDialog();
            Atualizar();
        }

        #region ucItemDeVenda: Eventos

        #endregion

    }
}
