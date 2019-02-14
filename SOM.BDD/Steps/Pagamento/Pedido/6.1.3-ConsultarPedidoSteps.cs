using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Pedido;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido
{
    [Binding]
    public sealed class ConsultarPedidoSteps
    {
        public PedidoPage TelaPedidoPage { get; private set; }

        public ConsultarPedidoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
        }

        [Given(@"que esteja na tela de consulta de pedidos")]
        public void DadoQueEstejaNaTelaDeConsultaDePedidos()
        {
            TelaPedidoPage.Navegar();
        }

        [When(@"faco um busca simples por numero de pedido ""(.*)""")]
        public void QuandoFacoUmBuscaSimplesPorNumeroDePedido(string Numero)
        {
            TelaPedidoPage.BuscaSimplesDePedido(Numero);
        }

        [Then(@"visualizo os dados do pedido no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDoPedidoNoResultadoDaBusca(string Numero, string Produto, string Episodio, string Capitulo, string Obra, 
            string MidiaADebitar, string Sincronismo, string ValorTotal, string Status, string StatusPav, string Reprise)
        {
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Numero);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Produto);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Episodio);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Capitulo);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Obra);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(MidiaADebitar);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Sincronismo);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(ValorTotal);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Status);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(StatusPav);
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Reprise);
        }

        [When(@"faço uma busca avançada de pedido por obra ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorObra(string Obra)
        {
            TelaPedidoPage.BuscaAvancadaDePedido("", "", Obra, "", "", "", "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por número ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorNumero(string Numero)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por produto ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorProduto(string Produto)
        {
            TelaPedidoPage.BuscaAvancadaDePedido("", Produto, "", "", "", "", "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por periodo de exibição ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorPeriodoDeExibicao(string Produto, string DataInicial, string DataFinal)
        {
            TelaPedidoPage.BuscaAvancadaDePedido("", Produto, "", DataInicial, DataFinal, "", "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por data inicial ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorDataInicial(string Produto, string DataInicial)
        {
            TelaPedidoPage.BuscaAvancadaDePedido("", Produto, "", DataInicial, "", "", "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por autor ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorAutor(string Autor)
        {
            TelaPedidoPage.BuscaAvancadaDePedido("", "", "", "", "", Autor, "", "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por DDA ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorDDA(string DDA)
        {
            TelaPedidoPage.BuscaAvancadaDePedido("", "", "", "", "", "", DDA, "", "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por Midia a Debitar ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorMidiaADebitar(string Numero, string MidiaDebitar)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", "", MidiaDebitar, "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por Sincronismo ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorSincronismo(string Numero, string Sincronismo)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", Sincronismo, "", "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por status e numero ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorStatusENumero(string Numero, string Status)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", "", "", Status, "", "");
        }

        [When(@"faço uma busca avançada de pedido por Midia Autorizada ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorMidiaAutorizada(string Numero, string MidiaAutorizada)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", MidiaAutorizada, "", "", "", "");
        }

        [When(@"faço uma busca avançada de pedido por Valor Negociado e Número ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorValorNegociadoENumero(string Numero, string ValorNegociado)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", "", "", "", ValorNegociado, "");
        }

        [Then(@"visualizo as alterações feitas nos pedido ao acessar o historico")]
        public void EntaoVisualizoAsAlteracoesFeitasNosPedidoAoAcessarOHistorico()
        {
            TelaPedidoPage.ValidarHistoricoDePedido();
        }

        [Then(@"visualizo todos os pedidos que estejam vinculado ao produto buscado ""(.*)""")]
        public void EntaoVisualizoTodosOsPedidosQueEstejamVinculadoAoProdutoBuscado(string Produto)
        {
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Produto);
        }

        [Then(@"visualizo todos os pedidos que estejam vinculado a obra buscada ""(.*)""")]
        public void EntaoVisualizoTodosOsPedidosQueEstejamVinculadoAObraBuscada(string Obra)
        {
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Obra);
        }

        [Then(@"visualizo todos os pedidos que estejam com status buscado ""(.*)""")]
        public void EntaoVisualizoTodosOsPedidosQueEstejamComStatusBuscado(string Status)
        {
            TelaPedidoPage.ValidarDadosNaAbaDePedido(Status);
        }

        [When(@"faço uma busca avançada de pedido por status pav e numero ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorStatusPavENumero(string Numero, string StatusPav)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", "", "", "", "", StatusPav);
        }

        [Then(@"visualizo todos os pedidos que estejam com status pav buscado ""(.*)""")]
        public void EntaoVisualizoTodosOsPedidosQueEstejamComStatusPavBuscado(string StatusPav)
        {
            TelaPedidoPage.ValidarDadosNaAbaDePedido(StatusPav);
        }

        [When(@"faço uma busca avançada de pedido por um número que não existe no sistema ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDePedidoPorUmNumeroQueNaoExisteNoSistema(string Numero)
        {
            TelaPedidoPage.BuscaAvancadaDePedido(Numero, "", "", "", "", "", "", "", "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem de que não foram encontrados pedidos com os dados informados na busca ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueNaoForamEncontradosPedidosComOsDadosInformadosNaBusca(string Mensagem)
        {
            TelaPedidoPage.ValidarDadosNaoEncontrados(Mensagem);
        }

        [Then(@"visualizo o relatório de pagamento do pedido buscado")]
        public void EntaoVisualizoORelatorioDePagamentoDoPedidoBuscado()
        {
            TelaPedidoPage.ValidarRelatorioDePagamento();
        }

    }
}
