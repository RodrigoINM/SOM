using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Autorização_de_Pagamento;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Autorização_de_Pagamento
{
    [Binding]
    public sealed class AutorizacaoDePagamentoSteps
    {
        public AutorizacaoDePagamentoPage TelaAutorizacaoDePagamentoPage { get; private set; }

        public AutorizacaoDePagamentoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaAutorizacaoDePagamentoPage = new AutorizacaoDePagamentoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["AutorizacaoDePagamentoUrl"]);
        }

        [Given(@"que esteja na tela de Autorizacao de Pagamentos")]
        public void DadoQueEstejaNaTelaDeAutorizacaoDePagamentos()
        {
            TelaAutorizacaoDePagamentoPage.Navegar();
        }

        [When(@"faço uma busca rápida pelo número de AP ""(.*)""")]
        public void QuandoFacoUmaBuscaRapidaPeloNumeroDeAP(string AP)
        {
            TelaAutorizacaoDePagamentoPage.BuscaRapidaDeAutorizacaoDePagamento(AP);
        }

        [When(@"faço uma busca avançada de solicitações de pedidos para pagamento por AP Inicial e AP Final ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeSolicitacoesDePedidosParaPagamentoPorAPInicialEAPFinal(string APInicial, string APFinal)
        {
            TelaAutorizacaoDePagamentoPage.BuscaAvancadaDeAutorizacaoDePagamento(APInicial, APFinal, "", "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de solicitações de pedidos para pagamento por Lote Inicial e Lote Final ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeSolicitacoesDePedidosParaPagamentoPorLoteInicialELoteFinal(string LoteInicial, string LoteFinal)
        {
            TelaAutorizacaoDePagamentoPage.BuscaAvancadaDeAutorizacaoDePagamento("", "", LoteInicial, LoteFinal, "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de solicitações de pedidos para pagamento por Número Pedido Inicial e Número Pedido Final ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeSolicitacoesDePedidosParaPagamentoPorNumeroPedidoInicialENumeroPedidoFinal(string NumeroPedidoInicial, string NumeroPedidoFinal)
        {
            TelaAutorizacaoDePagamentoPage.BuscaAvancadaDeAutorizacaoDePagamento("", "", "", "", NumeroPedidoInicial, NumeroPedidoFinal, "", "", "", "");
        }

        [When(@"faço uma busca avançada de solicitações de pedidos para pagamento por DDA e Número Pedido Inicial (.*), ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeSolicitacoesDePedidosParaPagamentoPorDDAENumeroPedidoInicial(string DDA, string NumeroPedidoInicial)
        {
            TelaAutorizacaoDePagamentoPage.BuscaAvancadaDeAutorizacaoDePagamento("", "", "", "", NumeroPedidoInicial, "", DDA, "", "", "");
        }

        [When(@"faço uma busca avançada de solicitações de pedidos para pagamento por AR e Número Pedido Inicial ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeSolicitacoesDePedidosParaPagamentoPorARENumeroPedidoInicial(string AR, string NumeroPedidoInicial)
        {
            TelaAutorizacaoDePagamentoPage.BuscaAvancadaDeAutorizacaoDePagamento("", "", "", "", NumeroPedidoInicial, "", "", AR, "", "");
        }

        [When(@"faço uma busca avançada de solicitações de pedidos para pagamento por Data Inicial da Ap e Data Final da Ap ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeSolicitacoesDePedidosParaPagamentoPorDataInicialDaApEDataFinalDaAp(string DataInicialAp, string DataFinalAp, string NumeroPedidoInicial)
        {
            TelaAutorizacaoDePagamentoPage.BuscaAvancadaDeAutorizacaoDePagamento("", "", "", "", NumeroPedidoInicial, "", "", "", DataInicialAp, DataFinalAp);
        }

        [Then(@"visualizo os dados da solicitação de pagamento para pedido no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDaSolicitacaoDePagamentoParaPedidoNoResultadoDaBusca(string AP, string Lote, string LPE, string AR,
            string Midia, string Creditado, string Valor)
        {
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(AP);
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(Lote);
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(LPE);
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(AR);
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(Midia);
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(Creditado);
            TelaAutorizacaoDePagamentoPage.ValidarBuscaSolicitacaoPagamento(Valor);
        }

    }
}
