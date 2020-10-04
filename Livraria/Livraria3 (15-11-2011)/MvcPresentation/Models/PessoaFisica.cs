using System.Collections.Generic;
using System.Text;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Livraria.Modelo
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Pessoa Física")]
    public class PessoaFisica: Pessoa
    {
        public PessoaFisica()
        {
            //Nome = string.Empty;
            //Cpf = string.Empty;
            //DataNascimento = default(DateTime);

        }
        
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private string cpf;
        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        [DataType(DataType.Date)]        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data do Evento é obrigatório")]
        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return this.dataNascimento; }
            set { this.dataNascimento = value; }
        }
    }
}
