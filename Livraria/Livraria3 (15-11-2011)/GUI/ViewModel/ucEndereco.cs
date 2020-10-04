using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Livraria.Utilitario;
using System.Configuration;

namespace Livraria.GUI.ViewModel
{
    public partial class ucEndereco : ucUserControlBase
    {
        #region ucEndereco: Construtores

        public ucEndereco()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucEndereco: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(420, 230);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(380, 130);
        }

        public override object ObterVariacao()
        {
            string endereco = ttb_Endereco.Text;
            string cep = ttb_CEP.Text;
            Modelo.Bairro bairro = (Modelo.Bairro)cmb_Bairro.SelectedItem;
            Modelo.Tipos.TipoLogradouro tipoLogradouro = ((Modelo.Tipos.TipoLogradouro)Enum.Parse(typeof(Modelo.Tipos.TipoLogradouro), ((Utilitario.EnumItem)cmb_TipoEndereco.SelectedItem).Value));
            int idBairro = bairro.ID;
            //int idTipoLogradouro = tipoLogradouro.ID;

            Modelo.Endereco enderecoReturn = new Modelo.Endereco()
            {
                Descricao = endereco,
                Bairro = bairro,
                CEP = cep,
                BairroId = idBairro,
               // TipoLogradouroId = idTipoLogradouro,
                TipoLogradouro = tipoLogradouro,
            };

            return enderecoReturn;
        }

        public override void Atualizar()
        {
            using (Controller controller = new Controller())
            {
                // Obtem os bairros
                IList<Modelo.Bairro> listaBairros;
                listaBairros = controller.ObterTodos<Modelo.Bairro>();

                cmb_Bairro.DataSource = listaBairros;
                cmb_Bairro.DisplayMember = "Nome";
                cmb_Bairro.ValueMember = "Nome";

                // Obtem os tipos de endereço
                IList<Utilitario.EnumItem> listaTipoLogradouro;
                listaTipoLogradouro = controller.ObterEnumerados<Modelo.Tipos.TipoLogradouro>();

                cmb_TipoEndereco.DataSource = listaTipoLogradouro;
                cmb_TipoEndereco.DisplayMember = "Description";
                cmb_TipoEndereco.ValueMember = "Description";
               
            }
        }

        #endregion

        #region ucEndereco: Eventos

        private void btn_MaisBairro_Click(object sender, EventArgs e)
        {
            FormInserir form_Cidade = new FormInserir(Variation.Bairro);
            form_Cidade.ShowDialog();
            Atualizar();
        }

        #endregion
    }
}
