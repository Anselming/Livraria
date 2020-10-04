using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Livraria.GUI.Controls
{
    public partial class AdicionarRemover : UserControl
    {
        #region AdicionarRemover: Propriedades

        private IList<object> valores;
        public IList<object> Valores
        {
            get { return valores; }
            set { valores = value; this.Refresh(); }
        }

        private int _idPessoa = 0;
        public int idPessoa
        {
            get { return _idPessoa; }
            set { _idPessoa = value; }
        }

        #endregion

        #region AdicionarRemover: Construtores

        public AdicionarRemover()
        {
            _InitializeComponent();
        }
        public AdicionarRemover(IList<object> valores)
        {
            _InitializeComponent();
            this.Valores = valores;
        }
        public void _InitializeComponent()
        {
            InitializeComponent();
            Refresh();
        }
        #endregion

        #region AdicionarRemover: Overrides

        public override void Refresh()
        {
            //base.Refresh();
            if (Valores != null)
                ckb_NaoInseridos.Items.AddRange(Valores.ToArray());
        }

        #endregion

        #region AdicionarRemover: Eventos

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            List<object> itensSelecionados = new List<object>();

            for (int i = ckb_NaoInseridos.CheckedIndices.Count; i > 0; i--)
            {
                int item = ckb_NaoInseridos.CheckedIndices[i - 1];
                object itemSelecionado = ckb_NaoInseridos.Items[item];
                ckb_NaoInseridos.Items.RemoveAt(item);
                itensSelecionados.Add(itemSelecionado);
            }
            ckb_Inseridos.Items.AddRange(itensSelecionados.ToArray());
        }
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            List<object> itensSelecionados = new List<object>();

            for (int i = ckb_Inseridos.CheckedIndices.Count; i > 0; i--)
            {
                int item = ckb_Inseridos.CheckedIndices[i - 1];
                object itemSelecionado = ckb_Inseridos.Items[item];
                ckb_Inseridos.Items.RemoveAt(item);
                itensSelecionados.Add(itemSelecionado);
            }
            ckb_NaoInseridos.Items.AddRange(itensSelecionados.ToArray());
        }

        #endregion

        #region AdicionarRemover: Métodos publicos

        public List<object> ObterItensSelecionados()
        {
            List<object> itensSelecionados = new List<object>();

            for (int i = ckb_Inseridos.CheckedIndices.Count; i > 0; i--)
            {
                int item = ckb_Inseridos.CheckedIndices[i - 1];
                object itemSelecionado = ckb_Inseridos.Items[item];
                ckb_Inseridos.Items.RemoveAt(item);
                itensSelecionados.Add(itemSelecionado);
            }

            return itensSelecionados;
        }
        public List<T> ObterItensSelecionados<T>()
        {
            List<object> itensSelecionados = new List<object>();

            foreach (var item in ckb_Inseridos.Items)
            {
                itensSelecionados.Add(item);
            }

            return itensSelecionados.Cast<T>().ToList();
        }
        public void Limpar()
        {
            if (this.Valores != null)
                this.Valores.Clear();

            ckb_NaoInseridos.Items.Clear();
            ckb_Inseridos.Items.Clear();
        }

        #endregion

    }
}
