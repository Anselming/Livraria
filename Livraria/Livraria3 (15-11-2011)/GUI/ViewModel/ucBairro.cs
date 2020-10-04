using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Livraria.GUI.ViewModel
{
    public partial class ucBairro : ucUserControlBase
    {
        #region ucBairro: Contrutores

        public ucBairro()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucBairro: Overrides

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
            Modelo.Cidade cidade = (Modelo.Cidade)cmb_Cidade.SelectedItem;
            string nome = ttb_Nome.Text;
            int cidadeId = cidade.ID;

            Modelo.Bairro bairro = new Modelo.Bairro()
            {
                CidadeId = cidadeId,
                Nome = nome,
                Cidade = cidade,
            };

            return bairro;
        }

        public override void Atualizar()
        {
            using (Controller controller = new Controller())
            {
                IList<Modelo.Cidade> lista;
                lista = controller.ObterTodos<Modelo.Cidade>();

                cmb_Cidade.DataSource = lista;
                cmb_Cidade.DisplayMember = "Nome";
                cmb_Cidade.ValueMember = "Nome";    // ### id para o EF4

            }
        }

        #endregion

        #region ucBairro: Eventos

        private void btn_MaisCidade_Click(object sender, EventArgs e)
        {
            FormInserir form_Cidade = new FormInserir(Variation.Cidade);
            form_Cidade.ShowDialog();
            Atualizar();
        }

        #endregion
    }
}
