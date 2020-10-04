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
    public partial class ucPessoaFisica : ucUserControlBase
    {
        #region ucPessoaFisica: Construtores
        
        public ucPessoaFisica()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucPessoaFisica: Overrides

        public override Size DefinirTamanhoDoForm()
        {
            return new Size(420, 630);
        }

        public override Size DefinirTamanhoDoContainer()
        {
            return new Size(380, 530);
        }

        public override object ObterVariacao()
        {
            // dados gerais
            string email = ttb_Email.Text;
            string observacao = ttb_Observacao.Text;

            // Pessoa Fisica
            string nome = ttb_Nome.Text;
            string cpf = ttb_CPF.Text;
            DateTime dataDeNascimento = date_DataDeNascimento.Value;

            // Outros
            List<Modelo.Endereco> enderecos = AdicionarRemover_Enderecos.ObterItensSelecionados<Modelo.Endereco>();
            List<Modelo.Telefone> telefones = AdicionarRemover_Telefones.ObterItensSelecionados<Modelo.Telefone>();

            Modelo.PessoaFisica pessoaFisica = new Modelo.PessoaFisica()
            {
                Email = email,
                Observacao = observacao,
                Nome = nome,
                Cpf = cpf,
                DataNascimento = dataDeNascimento,
                Enderecos = enderecos,
                Telefones = telefones,
            };

            return pessoaFisica;

        }

        public override void Atualizar()
        {
            using (Controller c = new Controller())
            {
                    AdicionarRemover_Enderecos.Valores = c.ObterTodos<Modelo.Endereco>().Cast<object>().ToList();
                    AdicionarRemover_Telefones.Valores = c.ObterTodos<Modelo.Telefone>().Cast<object>().ToList();
            }
        }
        #endregion

        #region ucPessoaFisica: Eventos

        private void ttb_Email_Leave(object sender, EventArgs e)
        {
            //Validação
            if (!ValidarEmail(ttb_Email.Text))
            {
                MessageBox.Show("Email inválido");
            }

        }

        #endregion

        #region ucPessoaFisica: Validações

        public static bool ValidarEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }

        #endregion
       
    }
}
