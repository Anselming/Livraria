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
    public partial class ucVenda : ucUserControlBase
    {
        #region ucVenda: Construtores

        public ucVenda()
        {
            InitializeComponent();
            Atualizar();

        }

        #endregion

        #region ucVenda: Overrides


        public override Size DefinirTamanhoDoForm()
        {
            return new Size(580, 340);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(540, 255);
        }

        public override object ObterVariacao()
        {
            if (rdb_TipoDePessoa1.Checked)
            {
                Modelo.Venda venda = new Modelo.Venda();
                venda.ItensVendidos = adicionarRemover_ItensDeVenda.ObterItensSelecionados<Modelo.ItemDeVenda>();

                Modelo.PessoaFisica valor = (Modelo.PessoaFisica)cmb_Cliente.SelectedItem;
                venda.Cliente = valor;
                return venda;
            }
            else
            {
                Modelo.Venda venda = new Modelo.Venda();
                venda.ItensVendidos = adicionarRemover_ItensDeVenda.ObterItensSelecionados<Modelo.ItemDeVenda>();

                Modelo.PessoaJuridica valor = (Modelo.PessoaJuridica)cmb_Cliente.SelectedItem;
                venda.Cliente = valor;
                return venda;
            }
            
        }

        private void Atualizar(bool atualizarOControleAdicionarRemover)
        {
            if (atualizarOControleAdicionarRemover)
            {
                Atualizar();
            }
            else
            {
                using (Controller c = new Controller())
                {
                    FormInserir form_MaisCliente = default(FormInserir);
                    if (rdb_TipoDePessoa1.Checked)
                    {
                        IList<Modelo.PessoaFisica> listaPessoasFisicas = c.ObterTodos<Modelo.PessoaFisica>();
                        cmb_Cliente.DataSource = listaPessoasFisicas;
                        cmb_Cliente.DisplayMember = "Nome";
                        cmb_Cliente.ValueMember = "Nome";

                    }
                    else
                    {
                        IList<Modelo.PessoaJuridica> listaPessoasJuridicas = c.ObterTodos<Modelo.PessoaJuridica>();
                        cmb_Cliente.DataSource = listaPessoasJuridicas;
                        cmb_Cliente.DisplayMember = "Nome";
                        cmb_Cliente.ValueMember = "Nome";

                    }
                }
            }
        }
        public override void Atualizar()
        {
            using (Controller c = new Controller())
            {
                adicionarRemover_ItensDeVenda.Limpar();
                adicionarRemover_ItensDeVenda.Valores = c.ObterTodos<Modelo.ItemDeVenda>().Cast<object>().ToList();


                FormInserir form_MaisCliente = default(FormInserir);
                if (rdb_TipoDePessoa1.Checked)
                {
                    IList<Modelo.PessoaFisica> listaPessoasFisicas = c.ObterTodos<Modelo.PessoaFisica>();
                    cmb_Cliente.DataSource = listaPessoasFisicas;
                    cmb_Cliente.DisplayMember = "Nome";
                    cmb_Cliente.ValueMember = "Nome";

                }
                else
                {
                    IList<Modelo.PessoaJuridica> listaPessoasJuridicas = c.ObterTodos<Modelo.PessoaJuridica>();
                    cmb_Cliente.DataSource = listaPessoasJuridicas;
                    cmb_Cliente.DisplayMember = "Nome";
                    cmb_Cliente.ValueMember = "Nome";

                }

            }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FormInserir form_ItemVenda = new FormInserir(Variation.ItemDeVenda);
            form_ItemVenda.ShowDialog();

            if (form_ItemVenda.foiModificado)
                Atualizar(true);
        }

        private void btn_MaisCliente_Click(object sender, EventArgs e)
        {
            FormInserir form_MaisCliente = default(FormInserir);
            if (rdb_TipoDePessoa1.Checked)
            {
                form_MaisCliente = new FormInserir(Variation.PessoaFisica);
            }
            else
            {
                form_MaisCliente = new FormInserir(Variation.PessoaJuridica);
            }

            form_MaisCliente.ShowDialog();

            if (form_MaisCliente.foiModificado)
                Atualizar(false);
        }

        private void rdb_TipoDePessoa1_CheckedChanged(object sender, EventArgs e)
        {
            Atualizar(false);
        }

        private void rdb_TipoDePessoa2_CheckedChanged(object sender, EventArgs e)
        {
            Atualizar(false);
        }

        #region ucVenda: Eventos

        #endregion

    }
}
