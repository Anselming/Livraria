using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Livraria.GUI.ViewModel;
using Livraria.Modelo;
using System.Configuration;

namespace Livraria.GUI
{
    public partial class FormLivraria : Form
    {
        #region FormLivraria: Construtores

        public FormLivraria()
        {
            InitializeComponent();
        }

        public FormLivraria(Variation variation)
        {
            InitializeComponent();
            Variacao = variation;
        }

        #endregion

        #region FormLivraria: Propriedades

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

        public string Title
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        private List<object> _bind;
        public List<object> Bind
        {
            get
            {
                if (_bind == null)
                    _bind = new List<object>();
                return _bind;
            }
            set
            {
                _bind = value;
                dgv_dados.DataSource = _bind;
            }
        }

        #endregion

        #region FormLivraria: Métodos Públicos

        #endregion

        #region FormLivraria: Métodos Privados

        private void _Atualizar()
        {
            using (Controller controller = new Controller())
            {
                switch (Variacao)
                {
                    case Variation.Nenhum:
                        break;

                    case Variation.Bairro:
                        Bind = controller.ObterTodos<Modelo.Bairro>().Cast<Object>().ToList();
                        break;

                    case Variation.Cidade:
                        Bind = controller.ObterTodos<Modelo.Cidade>().Cast<Object>().ToList();
                        break;

                    case Variation.Endereco:
                        Bind = controller.ObterTodos<Modelo.Endereco>().Cast<Object>().ToList();
                        break;

                    case Variation.PessoaFisica:
                        Bind = controller.ObterTodos<Modelo.PessoaFisica>().Cast<Object>().ToList();
                        break;

                    case Variation.PessoaJuridica:
                        Bind = controller.ObterTodos<Modelo.PessoaJuridica>().Cast<Object>().ToList();
                        break;

                    case Variation.Telefone:
                        Bind = controller.ObterTodos<Modelo.Telefone>().Cast<Object>().ToList();
                        break;

                    case Variation.UnidadeFederativa:
                        Bind = controller.ObterTodos<Modelo.UnidadeFederativa>().Cast<Object>().ToList();
                        break;

                    case Variation.Venda:
                        Bind = controller.ObterTodos<Modelo.Venda>().Cast<Object>().ToList();
                        break;

                    case Variation.ItemDeVenda:
                        Bind = controller.ObterTodos<Modelo.ItemDeVenda>().Cast<Object>().ToList();
                        break;

                    case Variation.Produto:
                        Bind = controller.ObterTodos<Modelo.Produto>().Cast<Object>().ToList();
                        break;

                    default:
                        break;
                }
            }
            pg_dado.SelectedObject = null;
        }

        #endregion

        #region FormLivraria: Eventos

        private void FormLivraria_Load(object sender, EventArgs e)
        {
            _Atualizar();
        }



        object ActualItem = null;
        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView thisDataGrid = (DataGridView)sender;

            var item = thisDataGrid.CurrentRow.DataBoundItem;
            pg_dado.SelectedObject = item;
            pg_dado.ExpandAllGridItems();

            ActualItem = ((ICloneable)item).Clone();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormInserir form_inserir = new FormInserir(this.Variacao);
            form_inserir.ShowDialog();
            _Atualizar();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (pg_dado.SelectedObject == null)
                return;

            using (Controller controller = new Controller())
            {
                switch (Variacao)
                {
                    case Variation.Nenhum:
                        break;

                    case Variation.Bairro:
                        controller.Excluir((Modelo.Bairro)ActualItem);
                        break;
                    
                    case Variation.Cidade:
                        controller.Excluir((Modelo.Cidade)ActualItem);
                        break;

                    case Variation.Endereco:
                        controller.Excluir((Modelo.Endereco)ActualItem);
                        break;

                    case Variation.PessoaFisica:
                        controller.Excluir((Modelo.PessoaFisica)ActualItem);
                        break;

                    case Variation.PessoaJuridica:
                        controller.Excluir((Modelo.PessoaJuridica)ActualItem);
                        break;
                    
                    case Variation.Telefone:
                        controller.Excluir<Modelo.Telefone>((Modelo.Telefone)ActualItem);
                        break;
                    
                    case Variation.UnidadeFederativa:
                        controller.Excluir<Modelo.UnidadeFederativa>((Modelo.UnidadeFederativa)ActualItem);
                        break;

                    case Variation.Venda:
                        controller.Excluir<Modelo.Venda>((Modelo.Venda)ActualItem);
                        break;

                    case Variation.ItemDeVenda:
                        controller.Excluir<Modelo.ItemDeVenda>((Modelo.ItemDeVenda)ActualItem);
                        break;

                    case Variation.Produto:
                        controller.Excluir<Modelo.Produto>((Modelo.Produto)ActualItem);
                        break;
                    
                    default:
                        break;
                }
            }
            _Atualizar();
            MessageBox.Show("Item Excluído com sucesso.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pg_dado.SelectedObject == null)
                return;

            object itemModificadoNoGrid = pg_dado.SelectedObject;
            using (Controller controller = new Controller())
            {
                switch (Variacao)
                {
                    case Variation.Nenhum:
                        break;

                    case Variation.Bairro:
                        controller.Alterar((Modelo.Bairro)ActualItem, (Modelo.Bairro)itemModificadoNoGrid);
                        break;

                    case Variation.Cidade:
                        controller.Alterar((Modelo.Cidade)ActualItem, (Modelo.Cidade)itemModificadoNoGrid);
                        break;

                    case Variation.Endereco:
                        controller.Alterar((Modelo.Endereco)ActualItem, (Modelo.Endereco)itemModificadoNoGrid);
                        break;

                    case Variation.PessoaFisica:
                        controller.Alterar((Modelo.PessoaFisica)ActualItem, (Modelo.PessoaFisica)itemModificadoNoGrid);
                        break;

                    case Variation.PessoaJuridica:
                        controller.Alterar((Modelo.PessoaJuridica)ActualItem, (Modelo.PessoaJuridica)itemModificadoNoGrid);
                        break;

                    case Variation.Telefone:
                        controller.Alterar((Modelo.Telefone)ActualItem, (Modelo.Telefone)itemModificadoNoGrid);
                        break;

                    case Variation.UnidadeFederativa:
                        controller.Alterar<Modelo.UnidadeFederativa>((Modelo.UnidadeFederativa)ActualItem, (Modelo.UnidadeFederativa)itemModificadoNoGrid);
                        break;

                    case Variation.Venda:
                        controller.Alterar<Modelo.Venda>((Modelo.Venda)ActualItem, (Modelo.Venda)itemModificadoNoGrid);
                        break;

                    case Variation.ItemDeVenda:
                        controller.Alterar<Modelo.ItemDeVenda>((Modelo.ItemDeVenda)ActualItem, (Modelo.ItemDeVenda)itemModificadoNoGrid);
                        break;

                    case Variation.Produto:
                        controller.Alterar<Modelo.Produto>((Modelo.Produto)ActualItem, (Modelo.Produto)itemModificadoNoGrid);
                        break;

                    default:
                        break;
                }
            }
            _Atualizar();
            MessageBox.Show("Item Alterado com sucesso.");
        }

        #endregion

    }
}
