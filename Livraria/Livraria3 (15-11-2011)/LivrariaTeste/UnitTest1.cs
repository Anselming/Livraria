using Liv = Livraria.Dominio.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Livraria.Modelo;
//using Livraria.Utilitario;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaTeste
{


    /// <summary>
    ///This is a test class for LivrariaTest and is intended
    ///to contain all LivrariaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LivrariaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void Init(TestContext testContext)
        {
            new Liv.Livraria<Bairro>().Inserir(new Bairro { Nome = "Bairro1" });
            new Liv.Livraria<Cidade>().Inserir(new Cidade { Nome = "Cidade1" });
            new Liv.Livraria<Endereco>().Inserir(new Endereco { CEP = "00000-000", Descricao = "Rua1" });
            new Liv.Livraria<PessoaFisica>().Inserir(new PessoaFisica { Cpf = "000000000-00", Nome = "Nome1" });
            new Liv.Livraria<PessoaJuridica>().Inserir(new PessoaJuridica { Cnpj = "000000000/0001", RazaoSocial = "RazaoSocial1" });
            new Liv.Livraria<Telefone>().Inserir(new Telefone { Numero = "0000-0000" });
            new Liv.Livraria<UnidadeFederativa>().Inserir(new UnidadeFederativa { Sigla = "RJ" });

            new Liv.Livraria<Bairro>().Inserir(new Bairro { Nome = "Bairro2" });
            new Liv.Livraria<Cidade>().Inserir(new Cidade { Nome = "Cidade2" });
            new Liv.Livraria<Endereco>().Inserir(new Endereco { CEP = "00000-001", Descricao = "Rua2" });
            new Liv.Livraria<PessoaFisica>().Inserir(new PessoaFisica { Cpf = "000000000-01", Nome = "Nome2" });
            new Liv.Livraria<PessoaJuridica>().Inserir(new PessoaJuridica { Cnpj = "000000001/0001", RazaoSocial = "RazaoSocial2" });
            new Liv.Livraria<Telefone>().Inserir(new Telefone { Numero = "0000-0001" });
            new Liv.Livraria<UnidadeFederativa>().Inserir(new UnidadeFederativa { Sigla = "SP" });

        }
        
        
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            Liv.Livraria<Bairro> target_bairro = new Liv.Livraria<Bairro>();
            target_bairro.SelecionarTodos().ForEach(h => target_bairro.Remover(h));

            Liv.Livraria<Cidade> target_cidade = new Liv.Livraria<Cidade>();
            target_cidade.SelecionarTodos().ForEach(h => target_cidade.Remover(h));

            Liv.Livraria<Endereco> target_endereco = new Liv.Livraria<Endereco>();
            target_endereco.SelecionarTodos().ForEach(h => target_endereco.Remover(h));

            Liv.Livraria<PessoaFisica> target_PessoaFisica = new Liv.Livraria<PessoaFisica>();
            target_PessoaFisica.SelecionarTodos().ForEach(h => target_PessoaFisica.Remover(h));

            Liv.Livraria<PessoaJuridica> target_PessoaJuridica = new Liv.Livraria<PessoaJuridica>();
            target_PessoaJuridica.SelecionarTodos().ForEach(h => target_PessoaJuridica.Remover(h));

            Liv.Livraria<Telefone> target_Telefone = new Liv.Livraria<Telefone>();
            target_Telefone.SelecionarTodos().ForEach(h => target_Telefone.Remover(h));

            Liv.Livraria<UnidadeFederativa> target_UnidadeFederativa = new Liv.Livraria<UnidadeFederativa>();
            target_UnidadeFederativa.SelecionarTodos().ForEach(h => target_UnidadeFederativa.Remover(h));

        }
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Liv.Livraria Constructor
        ///</summary>
        [Priority(1), TestMethod()]
        public void LivrariaConstructorTest()
        {
            Liv.Livraria<Bairro> construtorBairro = new Liv.Livraria<Bairro>();
            Assert.IsNotNull(construtorBairro);
        }


        /// <summary>
        ///A test for InserirBairro
        ///</summary>
        [Priority(9), TestMethod()]
        public void InserirBairroTest()
        {
            Liv.Livraria<Bairro> target = new Liv.Livraria<Bairro>();
            Bairro bairro = new Bairro { Nome = "Centro" }; // TODO: Initialize to an appropriate value
            target.Inserir(bairro);
            Bairro bairro_incluido = target.SelecionarTodos(item => item.Nome == bairro.Nome).FirstOrDefault();
            Assert.IsNotNull(bairro_incluido, "teste de inclusão de bairro falhou");
        }

        /// <summary>
        ///A test for InserirCidade
        ///</summary>
        [Priority(10), TestMethod()]
        public void InserirCidadeTest()
        {
            Liv.Livraria<Cidade> target = new Liv.Livraria<Cidade>();
            Cidade cidade = new Cidade { Nome = "Rio de Janeiro" }; // TODO: Initialize to an appropriate value
            target.Inserir(cidade);
            Cidade cidade_incluida = target.SelecionarTodos(item => item.Nome == cidade.Nome).FirstOrDefault();
            Assert.IsNotNull(cidade_incluida, "teste de inclusão de cidade falhou");
        }

        /// <summary>
        ///A test for InserirEndereco
        ///</summary>
        [Priority(11), TestMethod()]
        public void InserirEnderecoTest()
        {
            Liv.Livraria<Endereco> target = new Liv.Livraria<Endereco>();
            Endereco endereco = new Endereco { CEP = "21540000", Descricao = "Rua 13 de Maio, 5" }; // TODO: Initialize to an appropriate value
            target.Inserir(endereco);
            Endereco endereco_incluido = target.SelecionarTodos(item => item.CEP == endereco.CEP && item.Descricao == endereco.Descricao).FirstOrDefault();

            Assert.IsNotNull(endereco_incluido, "teste de inclusão de endereço falhou");
        }

        /// <summary>
        ///A test for InserirPessoaFisica
        ///</summary>
        [Priority(12), TestMethod()]
        public void InserirPessoaFisicaTest()
        {
            Liv.Livraria<PessoaFisica> target = new Liv.Livraria<PessoaFisica>();
            PessoaFisica pessoaFisica = new PessoaFisica { Cpf = "12345678901", Nome = "Joao" }; // TODO: Initialize to an appropriate value
            target.Inserir(pessoaFisica);
            PessoaFisica pf_incluida = target.SelecionarTodos(item => item.Cpf == pessoaFisica.Cpf).FirstOrDefault();

            Assert.IsNotNull(pf_incluida, "teste de inclusão de pessoa fisica falhou");
        }

        /// <summary>
        ///A test for InserirPessoaJuridica
        ///</summary>
        [Priority(13), TestMethod()]
        public void InserirPessoaJuridicaTest()
        {
            Liv.Livraria<PessoaJuridica> target = new Liv.Livraria<PessoaJuridica>();
            PessoaJuridica pessoaJuridica = new PessoaJuridica { Cnpj = "01234567890" }; // TODO: Initialize to an appropriate value
            target.Inserir(pessoaJuridica);

            PessoaJuridica pj_incluida = target.SelecionarTodos(item => item.Cnpj == pessoaJuridica.Cnpj).FirstOrDefault();
            Assert.IsNotNull(pj_incluida, "teste de inclusão de pessoa juridica falhou");
        }

        /// <summary>
        ///A test for InserirTelefone
        ///</summary>
        [Priority(14), TestMethod()]
        public void InserirTelefoneTest()
        {
            Liv.Livraria<Telefone> target = new Liv.Livraria<Telefone>();
            Telefone telefone = new Telefone { Ddd = "21", Numero = "12345678" }; // TODO: Initialize to an appropriate value
            target.Inserir(telefone);

            Telefone telefone_incluido = target.SelecionarTodos(item => item.Ddd == telefone.Ddd &&
                item.Numero == telefone.Numero).FirstOrDefault();

            Assert.IsNotNull(telefone_incluido, "teste de inclusão de telefone falhou");
        }

        /// <summary>
        ///A test for InserirUnidadeFederativa
        ///</summary>
        [Priority(15), TestMethod()]
        public void InserirUnidadeFederativaTest()
        {
            Liv.Livraria<UnidadeFederativa> target = new Liv.Livraria<UnidadeFederativa>();
            UnidadeFederativa unidadeFederativa = new UnidadeFederativa { Sigla = "RJ" }; // TODO: Initialize to an appropriate value
            target.Inserir(unidadeFederativa);
            UnidadeFederativa uf_incluida = target.SelecionarTodos(item => item.Sigla == unidadeFederativa.Sigla).FirstOrDefault();
            Assert.IsNotNull(uf_incluida);
        }

        /// <summary>
        ///A test for AlterarBairro
        ///</summary>
        [Priority(2), TestMethod()]
        public void AlterarBairroTest()
        {
            Liv.Livraria<Bairro> target = new Liv.Livraria<Bairro>();
            Bairro bairro_antigo = target.SelecionarTodos()[0];

            Bairro bairro_novo = new Bairro { Nome = bairro_antigo.Nome };
            bairro_novo.Cidade = new Cidade { Nome = "Rio de Janeiro" };

            target.Alterar(bairro_antigo, bairro_novo);

            Bairro bairro_alterado = target.SelecionarTodos(item =>
                item.Nome == bairro_antigo.Nome &&
                item.Cidade.Nome == bairro_novo.Cidade.Nome).FirstOrDefault();

            Assert.IsNotNull(bairro_alterado, "Teste de alteração de bairro falhou.");
        }

        //<summary>
        //A test for AlterarCidade
        //</summary>
        [Priority(3), TestMethod()]
        public void AlterarCidadeTest()
        {
            Liv.Livraria<Cidade> target = new Liv.Livraria<Cidade>();
            Cidade cidade_antiga = target.SelecionarTodos()[0];

            Cidade cidade_nova = new Cidade { Nome = cidade_antiga.Nome };
            cidade_nova.UF = new UnidadeFederativa { Nome = "RS" };

            target.Alterar(cidade_antiga, cidade_nova);

            Cidade cidade_alterada = target.SelecionarTodos(item =>
                item.Nome == cidade_antiga.Nome &&
                item.UF.Nome == cidade_nova.UF.Nome).FirstOrDefault();

            Assert.IsNotNull(cidade_alterada, "Teste de alteração de cidade falhou.");
        }

        /// <summary>
        ///A test for AlterarEndereco
        ///</summary>
        [Priority(4), TestMethod()]
        public void AlterarEnderecoTest()
        {
            Liv.Livraria<Endereco> target = new Liv.Livraria<Endereco>();
            Endereco endereco_antigo = target.SelecionarTodos()[0];

            Endereco endereco_novo = new Endereco { CEP = endereco_antigo.CEP };
            endereco_novo.Descricao = "Av Rio Branco, 156";

            target.Alterar(endereco_antigo, endereco_novo);

            Endereco endereco_alterado = target.SelecionarTodos(item =>
                item.CEP == endereco_antigo.CEP &&
                item.Descricao == endereco_novo.Descricao).FirstOrDefault();

            Assert.IsNotNull(endereco_alterado, "Teste de alteração de endereço falhou.");
        }

        /// <summary>
        ///A test for AlterarPessoaFisica
        ///</summary>
        [Priority(5), TestMethod()]
        public void AlterarPessoaFisicaTest()
        {
            Liv.Livraria<PessoaFisica> target = new Liv.Livraria<PessoaFisica>();
            PessoaFisica pf_antiga = target.SelecionarTodos()[0];

            PessoaFisica pf_nova = new PessoaFisica { Cpf = pf_antiga.Cpf };
            pf_nova.Nome = "Joao da silva";

            target.Alterar(pf_antiga, pf_nova);

            PessoaFisica pf_alterada = target.SelecionarTodos(item =>
                item.Cpf == pf_antiga.Cpf &&
                item.Nome == pf_nova.Nome).FirstOrDefault();

            Assert.IsNotNull(pf_alterada, "Teste de alteração de pessoa fisica falhou.");
        }

        /// <summary>
        ///A test for AlterarPessoaJuridica
        ///</summary>
        [Priority(6), TestMethod()]
        public void AlterarPessoaJuridicaTest()
        {
            Liv.Livraria<PessoaJuridica> target = new Liv.Livraria<PessoaJuridica>();
            PessoaJuridica pj_antiga = target.SelecionarTodos()[0];

            PessoaJuridica pj_nova = new PessoaJuridica { Cnpj = pj_antiga.Cnpj };
            pj_nova.RazaoSocial = "Mc donalds";

            target.Alterar(pj_antiga, pj_nova);

            PessoaJuridica pf_alterada = target.SelecionarTodos(item =>
                item.Cnpj == pj_antiga.Cnpj &&
                item.RazaoSocial == pj_nova.RazaoSocial).FirstOrDefault();

            Assert.IsNotNull(pf_alterada, "Teste de alteração de pessoa juridica falhou.");
        }

        /// <summary>
        ///A test for AlterarTelefone
        ///</summary>
        [Priority(7), TestMethod()]
        public void AlterarTelefoneTest()
        {
            Liv.Livraria<Telefone> target = new Liv.Livraria<Telefone>();
            Telefone telefone_antigo = target.SelecionarTodos()[0];

            Telefone telefone_novo = new Telefone { Numero = telefone_antigo.Numero };
            telefone_novo.Ddd = "999";

            target.Alterar(telefone_antigo, telefone_novo);

            Telefone telefone_alterado = target.SelecionarTodos(item =>
                item.Numero == telefone_antigo.Numero &&
                item.Ddd == telefone_novo.Ddd).FirstOrDefault();

            Assert.IsNotNull(telefone_alterado, "Teste de alteração de telefone falhou.");
        }

        /// <summary>
        ///A test for AlterarUnidadeFederativa
        ///</summary>
        [Priority(8), TestMethod()]
        public void AlterarUnidadeFederativaTest()
        {
            Liv.Livraria<UnidadeFederativa> target = new Liv.Livraria<UnidadeFederativa>();
            UnidadeFederativa uf_antigo = target.SelecionarTodos()[0];

            UnidadeFederativa uf_novo = new UnidadeFederativa { Sigla = uf_antigo.Sigla };
            uf_novo.Nome = "São Paulo";

            target.Alterar(uf_antigo, uf_novo);

            UnidadeFederativa uf_alterado = target.SelecionarTodos(item =>
                item.Sigla == uf_antigo.Sigla &&
                item.Nome == uf_novo.Nome).FirstOrDefault();

            Assert.IsNotNull(uf_alterado, "Teste de alteração de unidade federativa falhou.");
        }


        /// <summary>
        ///A test for SelecionarTodasAsCidades
        ///</summary>
        [Priority(17), TestMethod()]
        public void SelecionarTodasAsCidadesTest()
        {
            Liv.Livraria<Cidade> target = new Liv.Livraria<Cidade>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }

        /// <summary>
        ///A test for SelecionarTodasAsPessoaJuridicas
        ///</summary>
        [Priority(18), TestMethod()]
        public void SelecionarTodasAsPessoaJuridicasTest()
        {
            Liv.Livraria<PessoaJuridica> target = new Liv.Livraria<PessoaJuridica>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }

        /// <summary>
        ///A test for SelecionarTodasAsPessoasFisicas
        ///</summary>
        [Priority(19), TestMethod()]
        public void SelecionarTodasAsPessoasFisicasTest()
        {
            Liv.Livraria<PessoaFisica> target = new Liv.Livraria<PessoaFisica>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }

        /// <summary>
        ///A test for SelecionarTodasAsUnidadesFederativas
        ///</summary>
        [Priority(20), TestMethod()]
        public void SelecionarTodasAsUnidadesFederativasTest()
        {
            Liv.Livraria<UnidadeFederativa> target = new Liv.Livraria<UnidadeFederativa>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }



        /// <summary>
        ///A test for SelecionarTodosOsBairros
        ///</summary>
        [Priority(22), TestMethod()]
        public void SelecionarTodosOsBairrosTest()
        {
            Liv.Livraria<Bairro> target = new Liv.Livraria<Bairro>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }


        /// <summary>
        ///A test for SelecionarTodosOsEnderecos
        ///</summary>
        [Priority(23), TestMethod()]
        public void SelecionarTodosOsEnderecosTest()
        {
            Liv.Livraria<Endereco> target = new Liv.Livraria<Endereco>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }


        /// <summary>
        ///A test for SelecionarTodosOsTelefones
        ///</summary>
        [Priority(24), TestMethod()]
        public void SelecionarTodosOsTelefonesTest()
        {
            Liv.Livraria<Telefone> target = new Liv.Livraria<Telefone>();
            Assert.IsTrue(target.SelecionarTodos().Count > 0);
        }

        /// <summary>
        ///A test for RemoverBairro
        ///</summary>
        [Priority(25), TestMethod()]
        public void RemoverBairroTest()
        {
            Liv.Livraria<Bairro> target = new Liv.Livraria<Bairro>(); // TODO: Initialize to an appropriate value
            Bairro bairro = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.Remover(bairro);
            Bairro bairro_excluido = target.SelecionarTodos(item => item.Nome == bairro.Nome).FirstOrDefault();
            Assert.IsNull(bairro_excluido, "teste de exclusão de bairro falhou");
        }

        /// <summary>
        ///A test for RemoverCidade
        ///</summary>
        [Priority(26), TestMethod()]
        public void RemoverCidadeTest()
        {
            Liv.Livraria<Cidade> target = new Liv.Livraria<Cidade>(); // TODO: Initialize to an appropriate value
            Cidade cidade = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.Remover(cidade);
            Cidade cidade_excluida = target.SelecionarTodos(item => item.Nome == cidade.Nome).FirstOrDefault();
            Assert.IsNull(cidade_excluida, "teste de exclusão de cidade falhou");
        }

        /// <summary>
        ///A test for RemoverEndereco
        ///</summary>
        [Priority(27), TestMethod()]
        public void RemoverEnderecoTest()
        {
            Liv.Livraria<Endereco> target = new Liv.Livraria<Endereco>(); // TODO: Initialize to an appropriate value
            Endereco endereco = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.Remover(endereco);
            Endereco endereco_excluido = target.SelecionarTodos(item => item.CEP == endereco.CEP).FirstOrDefault();
            Assert.IsNull(endereco_excluido, "teste de exclusão de endereço falhou");
        }

        /// <summary>
        ///A test for RemoverPessoaFisica
        ///</summary>
        [Priority(28), TestMethod()]
        public void RemoverPessoaFisicaTest()
        {
            Liv.Livraria<PessoaFisica> target = new Liv.Livraria<PessoaFisica>(); // TODO: Initialize to an appropriate value
            PessoaFisica pessoafisica = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.Remover(pessoafisica);
            PessoaFisica pf_excluida = target.SelecionarTodos(item => item.Cpf == pessoafisica.Cpf).FirstOrDefault();
            Assert.IsNull(pf_excluida, "teste de exclusão de pessoa física falhou");
        }

        /// <summary>
        ///A test for RemoverPessoaJuridica
        ///</summary>
        [Priority(29), TestMethod()]
        public void RemoverPessoaJuridicaTest()
        {
            Liv.Livraria<PessoaJuridica> target = new Liv.Livraria<PessoaJuridica>(); // TODO: Initialize to an appropriate value
            PessoaJuridica pessoajuridica = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.Remover(pessoajuridica);
            PessoaJuridica pj_excluida = target.SelecionarTodos(item => item.Cnpj == pessoajuridica.Cnpj).FirstOrDefault();
            Assert.IsNull(pj_excluida, "teste de exclusão de pessoa jurídica falhou");
        }

        /// <summary>
        ///A test for RemoverTelefone
        ///</summary>
        [Priority(30), TestMethod()]
        public void RemoverTelefoneTest()
        {
            Liv.Livraria<Telefone> target = new Liv.Livraria<Telefone>(); // TODO: Initialize to an appropriate value
            Telefone telefone = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.Remover(telefone);
            Telefone telefone_excluido = target.SelecionarTodos(item => item.Numero == telefone.Numero).FirstOrDefault();
            Assert.IsNull(telefone_excluido, "teste de exclusão de telefone falhou");
        }

        /// <summary>
        ///A test for RemoverUnidadeFederativa
        ///</summary>
        [Priority(31), TestMethod()]
        public void RemoverUnidadeFederativaTest()
        {
            Liv.Livraria<UnidadeFederativa> target = new Liv.Livraria<UnidadeFederativa>(); // TODO: Initialize to an appropriate value
            UnidadeFederativa uf = target.SelecionarTodos().FirstOrDefault(); // TODO: Initialize to an appropriate value
            target.SelecionarTodos(item => item.Sigla == uf.Sigla).ForEach(u => target.Remover(u));
            UnidadeFederativa uf_excluido = target.SelecionarTodos(item => item.Sigla == uf.Sigla).FirstOrDefault();
            Assert.IsNull(uf_excluido, "teste de exclusão de unidade federativa falhou");
        }
    }
}
