using TechTalk.SpecFlow;
using SOM.BDD.Pages.Produto;
using Framework.Core.Interfaces;
using System.Configuration;
using SOM.BDD.Steps.Produto;
using System.Threading;

namespace SOM.BDD.Steps.Produto
{
    [Binding]
    public sealed class ExclusaoDeProdutoSteps
    {
        public ExclusaoDeProdutoPage TelaExclusaoDeProdutoPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public ConsultaDeProdutoPage TelaConsultaDeProdutoPage { get; private set; }
        public CadastroDeProdutoSteps CadastroDeProdutoSteps { get; set; }

        public ExclusaoDeProdutoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaExclusaoDeProdutoPage = new ExclusaoDeProdutoPage((IBrowser)browser);
            TelaConsultaDeProdutoPage = new ConsultaDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["BuscaProdutoUrl"]);
            CadastroDeProdutoSteps = new CadastroDeProdutoSteps();
        }

        [Given(@"que tenha um produto cadastrado no sistema sem possuir um capitulo relacionado")]
        public void DadoQueTenhaUmProdutoCadastradoNoSistemaSemPossuirUmCapituloRelacionado()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            Thread.Sleep(2000);
        }

        [Given(@"que tenha feito uma busca pelo produto")]
        public void DadoQueTenhaFeitoUmaBuscaPeloProduto()
        {
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
        }

        [When(@"excluo o produto")]
        public void QuandoExcluoOProduto()
        {
            TelaExclusaoDeProdutoPage.ExcluirProdutoCadastrado(CadastroDeProdutoPage.Produto, "Sim");
        }

        [Then(@"visualizo a mensagem ""(.*)"" de exclusao do produto")]
        public void EntaoVisualizoAMensagemDeExclusaoDoProduto(string Mensagem)
        {
            TelaExclusaoDeProdutoPage.ValidarProdutoExcluido(Mensagem);
        }
        
        [Then(@"visualizo a mensagem ""(.*)"" de exclusao do produto ""(.*)""")]
        public void EntaoVisualizoAMensagemDeExclusaoDoProduto(string Mensagem, string Nome)
        {
            TelaExclusaoDeProdutoPage.ValidarExclusaoDeProduto(Nome, Mensagem);
        }

        [When(@"cancelo a exclusão do produto")]
        public void QuandoCanceloAExclusaoDoProduto()
        {
            TelaExclusaoDeProdutoPage.ExcluirProdutoCadastrado(CadastroDeProdutoPage.Produto, "Não");
        }

        [Then(@"visualizo o produto no resultado da busca com sucesso")]
        public void EntaoVisualizoOProdutoNoResultadoDaBuscaComSucesso()
        {
            TelaExclusaoDeProdutoPage.ValidarProdutoNaGridDeResultado(CadastroDeProdutoPage.Produto);
        }

    }
}
