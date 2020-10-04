using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Livraria.GUI.ViewModel;
using System.Configuration;

namespace Livraria.GUI
{
    public partial class FormInserir : Form
    {
        #region FormInserir: Construtores

        public FormInserir()
        {
            InitializeComponent();
        }

        #endregion

        #region FormInserir: Propriedades

        public string Title
        {
            get
            {
                return this.Text;
            }

            set
            {
                this.Text = value;
                groupBox1.Text = value;
                DefinirView();
            }
        }

        private Variation _variacao;
        public Variation Variacao
        {
            get { return _variacao; }
            set
            {
                _variacao = value;
                this.Title = value.ToString();
            }
        }

        ucUserControlBase uc_Base = null;

        public bool foiModificado { get; private set; }
        #endregion

        #region FormInserir: Construtores

        public FormInserir(Variation variation)
        {
            InitializeComponent();
            this.Variacao = variation;
        }

        #endregion

        #region FormInserir: Métodos publicos

        #endregion

        #region FormInserir: Métodos privados

        private void DefinirView()
        {
            switch (this.Variacao)
            {

                case Variation.Bairro: uc_Base = new ucBairro();
                    break;
                case Variation.Cidade: uc_Base = new ucCidade();
                    break;
                case Variation.Endereco: uc_Base = new ucEndereco();
                    break;
                case Variation.PessoaFisica: uc_Base = new ucPessoaFisica();
                    break;
                case Variation.PessoaJuridica: uc_Base = new ucPessoaJuridica();
                    break;
                case Variation.Telefone: uc_Base = new ucTelefone();
                    break;
                case Variation.UnidadeFederativa: uc_Base = new ucUnidadeFederativa();
                    break;
                case Variation.Nenhum:
                    break;

                case Variation.Produto: uc_Base = new ucProduto();
                    break;
                case Variation.ItemDeVenda: uc_Base = new ucItemDeVenda();
                    break;
                case Variation.Venda: uc_Base = new ucVenda();
                    break;
                default:
                    break;
            }

            uc_Base.Location = new Point(10, 15);

            this.Size = uc_Base.DefinirTamanhoDoForm();
            this.groupBox1.Size = uc_Base.DefinirTamanhoDoContainer();
            this.groupBox1.Controls.Add(uc_Base);

        }

        #endregion

        #region FormInserir: Eventos

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                switch (this.Variacao)
                {

                    case Variation.Bairro:
                        Modelo.Bairro bairro = (Modelo.Bairro)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(bairro);
                        break;

                    case Variation.Cidade: uc_Base = new ucCidade();
                        Modelo.Cidade cidade = (Modelo.Cidade)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(cidade);
                        break;

                    case Variation.Endereco: uc_Base = new ucEndereco();
                        Modelo.Endereco endereco = (Modelo.Endereco)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(endereco);
                        break;

                    case Variation.PessoaFisica: uc_Base = new ucPessoaFisica();
                        Modelo.PessoaFisica pessoaFisica = (Modelo.PessoaFisica)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(pessoaFisica);
                        break;

                    case Variation.PessoaJuridica: uc_Base = new ucPessoaJuridica();
                        Modelo.PessoaJuridica pessoaJuridica = (Modelo.PessoaJuridica)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(pessoaJuridica);
                        break;

                    case Variation.Telefone: uc_Base = new ucTelefone();
                        Modelo.Telefone telefone = (Modelo.Telefone)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(telefone);
                        break;

                    case Variation.UnidadeFederativa: uc_Base = new ucUnidadeFederativa();
                        Modelo.UnidadeFederativa unidadeFederativa = (Modelo.UnidadeFederativa)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(unidadeFederativa);
                        break;

                    case Variation.Produto: uc_Base = new ucProduto();
                        Modelo.Produto produto = (Modelo.Produto)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(produto);
                        break;

                    case Variation.ItemDeVenda: uc_Base = new ucItemDeVenda();
                        Modelo.ItemDeVenda itemDeVenda = (Modelo.ItemDeVenda)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(itemDeVenda);
                        break;

                    case Variation.Venda: uc_Base = new ucVenda();
                        Modelo.Venda venda = (Modelo.Venda)((ucUserControlBase)this.groupBox1.Controls[0]).ObterVariacao();
                        controller.Inserir(venda);
                        break;

                    case ViewModel.Variation.Nenhum:
                        break;

                    default:
                        break;
                }
            }
            MessageBox.Show(this.Title + " concluído com sucesso.");
            foiModificado = true;
            this.Close();
        }

        #endregion

    }
}
