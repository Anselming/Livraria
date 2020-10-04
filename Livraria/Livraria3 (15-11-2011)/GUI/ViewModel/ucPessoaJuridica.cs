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
    public partial class ucPessoaJuridica : ucUserControlBase
    {
        #region ucPessoaJuridica: Construtores

        public ucPessoaJuridica()
        {
            InitializeComponent();
            Atualizar();
        }

        #endregion

        #region ucPessoaJuridica: Overrides

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

            // Pessoa Juridica
            string nomeFantasia = ttb_NomeFantasia.Text;
            string razaoSocial = ttb_RazaoSocial.Text;
            string CNPJ = ttb_CNPJ.Text;
            string IE = ttb_IE.Text;
            string IM = ttb_IM.Text;


            // Outros
            List<Modelo.Endereco> enderecos = AdicionarRemover_Enderecos.ObterItensSelecionados<Modelo.Endereco>();
            List<Modelo.Telefone> telefones = AdicionarRemover_Telefones.ObterItensSelecionados<Modelo.Telefone>();

            Modelo.PessoaJuridica pessoaJuridica = new Modelo.PessoaJuridica()
            {
                Email = email,
                Observacao = observacao,
                NomeFantasia = ttb_NomeFantasia.Text,
                RazaoSocial = ttb_RazaoSocial.Text,
                Cnpj = ttb_CNPJ.Text,
                IE = ttb_IE.Text,
                IM = ttb_IM.Text,
                Enderecos = enderecos,
                Telefones = telefones,
            };

            return pessoaJuridica;
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

        #region ucPessoaJuridica: Validações

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

        #region ucPessoaJuridica: Eventos

        private void ttb_Email_Leave(object sender, System.EventArgs e)
        {
            //Validação
            if (!ValidarEmail(ttb_Email.Text))
            {
                MessageBox.Show("Email inválido");
            }
        }

        #endregion

    }
}
