using TechTalk.SpecFlow;
using SOM.BDD.Pages.Produto;
using Framework.Core.Interfaces;
using System.Configuration;
using SOM.BDD.Steps.Produto;

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
                
        //[When(@"faco uma busca e excluo um produto ""(.*)"" com sucesso ""(.*)""")]
        //public void QuandoFacoUmaBuscaEExcluoUmProdutoComSucesso(string Nome, string Mensagem)
        //{
        //    DadoQueTenhaFeitoUmaBuscaPeloProduto(Nome);
        //    QuandoExcluoOProduto(Nome);
        //    EntaoVisualizoAMensagemDeExclusaoDoProduto(Nome, Mensagem);
        //}

        [Given(@"que tenha feito uma busca pelo produto")]
        public void DadoQueTenhaFeitoUmaBuscaPeloProduto()
        {
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
        }

        [When(@"excluo o produto")]
        public void QuandoExcluoOProduto()
        {
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
        }

        [Then(@"visualizo a mensagem ""(.*)"" de exclusao do produto")]
        public void EntaoVisualizoAMensagemDeExclusaoDoProduto(string Mensagem)
        {
            TelaExclusaoDeProdutoPage.ExclusaoDeProduto(Mensagem);
        }

        [When(@"excluo o produto ""(.*)""")]
        public void QuandoExcluoOProduto(string Nome)
        {
            TelaExclusaoDeProdutoPage.ExcluirProduto(Nome);
        }

        [Then(@"visualizo a mensagem ""(.*)"" de exclusao do produto ""(.*)""")]
        public void EntaoVisualizoAMensagemDeExclusaoDoProduto(string Mensagem, string Nome)
        {
            TelaExclusaoDeProdutoPage.ValidarExclusaoDeProduto(Nome, Mensagem);
        }

    }
}
