using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido
{
    [Binding]
    public sealed class ConsultarDetalheDosItensDoPedidoSteps
    {
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public ConsultarDetalheDosItensDoPedidoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCriarPedidoManualmentePage = new CriarPedidoManualmentePage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDePedidoUrl"]);
            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
        }

        [Given(@"que esteja na tela de detalhes de um pedido criado manualmente")]
        public void DadoQueEstejaNaTelaDeDetalhesDeUmPedidoCriadoManualmente()
        {
            TelaCriarPedidoManualmentePage.Navegar();
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(CadastrarObraEComposicaoPage.Obra, "10/10/2018", "20", "GLOBONEWS", "ABERTURA");
            TelaCriarPedidoManualmentePage.ValidarPopupSucesso("");
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
        }

        [When(@"acesso a aba de pagamento na tela de detalhes do pedido")]
        public void QuandoAcessoAAbaDePagamentoNaTelaDeDetalhesDoPedido()
        {
            TelaPedidoPage.AcessarAbaPagamento();
        }

        [Then(@"visualizo os dados do pedido na aba de pagamento com sucesso")]
        public void EntaoVisualizoOsDadosDoPedidoNaAbaDePagamentoComSucesso()
        {
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes(CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes("100%");
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes("GLOBONEWS");
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes("A Pagar");
        }

        [When(@"acesso a aba de autorização na tela de detalhes do pedido")]
        public void QuandoAcessoAAbaDeAutorizacaoNaTelaDeDetalhesDoPedido()
        {
            
        }

        [Then(@"visualizo os dados do pedido na aba de autorização com sucesso")]
        public void EntaoVisualizoOsDadosDoPedidoNaAbaDeAutorizacaoComSucesso()
        {
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes(CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes("100%");
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes("GLOBONEWS");
        }

    }
}
