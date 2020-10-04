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
    public partial class ucCidade : ucUserControlBase
    {
        #region ucCidade: Construtores

        public ucCidade()
        {
            InitializeComponent();
            Atualizar();

        }

        #endregion

        #region ucCidade: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(420, 200);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(380, 80);
        }

        public override object ObterVariacao()
        {
            Modelo.UnidadeFederativa unidadeFederativa = (Modelo.UnidadeFederativa)cmb_UF.SelectedItem;
            string nome = ttb_Nome.Text;
            int ufId = unidadeFederativa.ID;

            Modelo.Cidade cidade = new Modelo.Cidade()
            {
                Nome = nome,
                UfId = ufId,
                UF = unidadeFederativa,
            };

            return cidade;
        }

        public override void Atualizar()
        {
            using (Controller controller = new Controller())
            {
                IList<Modelo.UnidadeFederativa> lista;


                lista = controller.ObterTodos<Modelo.UnidadeFederativa>();

                cmb_UF.DataSource = lista;
                cmb_UF.DisplayMember = "Nome";
                cmb_UF.ValueMember = "Nome";    // ### id para o EF4
            }

        }


        #endregion

        #region ucCidade: Eventos

        private void btn_MaisUF_Click(object sender, EventArgs e)
        {
            FormInserir form_Cidade = new FormInserir(Variation.UnidadeFederativa);
            form_Cidade.ShowDialog();
            Atualizar();
        }

        #endregion
    }
}
