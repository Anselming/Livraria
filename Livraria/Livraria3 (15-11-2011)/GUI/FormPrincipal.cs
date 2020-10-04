using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Livraria.Modelo;
using System.Data.Entity;
using System.Configuration;

namespace Livraria.GUI
{
    public partial class FormPrincipal : Form
    {
        #region FormPrincipal: Construtores

        public FormPrincipal()
        {
            using (Controller c = new Controller())
            {
                c.CodeFirst();
            }

            InitializeComponent();
        }

        #endregion

        #region FormPrincipal: Eventos

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.Endereco);
                form_Livraria.ShowDialog();
            }
        }
        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.Cidade);
                form_Livraria.ShowDialog();
            }
        }
        private void unidadeFederativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.UnidadeFederativa);
                form_Livraria.ShowDialog();
            }
        }
        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.Bairro);
                form_Livraria.ShowDialog();
            }
        }
        private void telefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.Telefone);
                form_Livraria.ShowDialog();
            }
        }
        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.PessoaJuridica);
                form_Livraria.ShowDialog();
            }
        }
        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.PessoaFisica);
                form_Livraria.ShowDialog();
            }
        }


        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.Produto);
                form_Livraria.ShowDialog();
            }
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.Venda);
                form_Livraria.ShowDialog();
            }
        }



        #endregion

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Controller controller = new Controller())
            {
                FormLivraria form_Livraria = new FormLivraria(ViewModel.Variation.ItemDeVenda);
                form_Livraria.ShowDialog();
            }
        }


    }
}
