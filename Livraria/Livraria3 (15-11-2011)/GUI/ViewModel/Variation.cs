using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.GUI.ViewModel
{
    public enum Variation
    {
        Nenhum = 0,
        Bairro = 1,
        Cidade = 2,
        Endereco = 4,
        PessoaFisica = 8,
        PessoaJuridica = 16,
        Telefone = 32,
        UnidadeFederativa = 64,
        Produto = 128,
        ItemDeVenda = 256,
        Venda = 512,
    }
}
