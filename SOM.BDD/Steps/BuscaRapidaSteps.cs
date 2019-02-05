using Framework.Core.Interfaces;
using SOM.BDD.Pages;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps
{
    [Binding]
    public class BuscaRapidaSteps
    {
        public BuscaRapidaPage TelaBuscaRapidaPage { get; private set; }

        public BuscaRapidaSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaBuscaRapidaPage = new BuscaRapidaPage((IBrowser)browser);
        }

        [When(@"faço uma consulta no menu de busca rápida ""(.*)""")]
        public void QuandoFacoUmaConsultaNoMenuDeBuscaRapida(string BuscaRapida)
        {
            TelaBuscaRapidaPage.ConsultaRapida(BuscaRapida);
        }

        [Then(@"visualizo as obras e produtos no resultado da busca rápida com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAsObrasEProdutosNoResultadoDaBuscaRapidaComSucesso(string Obra, string MensagemObra, string Produto, string MensagemProduto)
        {
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaObra(Obra);
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaObra(MensagemObra);
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaProduto(Produto);
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaProduto(MensagemProduto);
        }

        [When(@"acesso a Obra no resultado da busca rápida ""(.*)""")]
        public void QuandoAcessoAObraNoResultadoDaBuscaRapida(string Obra)
        {
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaObra(Obra);
            TelaBuscaRapidaPage.AcessarObra(Obra);
        }

        [Then(@"visualizo a tela de detalhe da obra com sucesso ""(.*)""")]
        public void EntaoVisualizoATelaDeDetalheDaObraComSucesso(string Obra)
        {
            TelaBuscaRapidaPage.ValidarDetalheDaObraProduto(Obra);
        }

        [When(@"acesso o Produto no resultado da busca rápida ""(.*)""")]
        public void QuandoAcessoOProdutoNoResultadoDaBuscaRapida(string Produto)
        {
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaProduto(Produto);
            TelaBuscaRapidaPage.AcessarProduto(Produto);
        }

        [Then(@"visualizo a tela de detalhe do Produto com sucesso ""(.*)""")]
        public void EntaoVisualizoATelaDeDetalheDoProdutoComSucesso(string Produto)
        {
            TelaBuscaRapidaPage.ValidarDetalheDaObraProduto(Produto);
        }

        [Then(@"visualizo a obra no resultado da busca rápida com sucesso ""(.*)""")]
        public void EntaoVisualizoAObraNoResultadoDaBuscaRapidaComSucesso(string Obra)
        {
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaObra(Obra);
        }

        [Then(@"visualizo o produto no resultado da busca rápida com sucesso ""(.*)""")]
        public void EntaoVisualizoOProdutoNoResultadoDaBuscaRapidaComSucesso(string Produto)
        {
            TelaBuscaRapidaPage.ValidarResultadoDaBuscaRapidaProduto(Produto);
        }

        [When(@"faço uma consulta no menu de busca rápida por um título não cadastrado no sistema ""(.*)""")]
        public void QuandoFacoUmaConsultaNoMenuDeBuscaRapidaPorUmTituloNaoCadastradoNoSistema(string BuscaRapida)
        {
            TelaBuscaRapidaPage.ConsultaRapida(BuscaRapida);
        }

        [Then(@"visualizo a mensagem de dados não encontrados na busca rápida ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDadosNaoEncontradosNaBuscaRapida(string Mensagem)
        {
            TelaBuscaRapidaPage.ValidarNenhumResultadoEncontrado(Mensagem);
        }

    }
}
