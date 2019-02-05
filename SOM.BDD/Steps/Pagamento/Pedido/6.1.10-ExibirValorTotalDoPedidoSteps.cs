using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using SOM.BDD.Pages.Produto;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido
{
    [Binding]
    public sealed class ExibirValorTotalDoPedidoSteps
    {
        public PedidoPage TelaPedidoPage { get; private set; }
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }

        public ExibirValorTotalDoPedidoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
            TelaCriarPedidoManualmentePage = new CriarPedidoManualmentePage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDePedidoUrl"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaAlterarItemPedidoPage = new AlterarItemPedidoPage((IBrowser)browser);
        }

        [Given(@"que tenha um pedido previamente cadastrado no sistema")]
        public void DadoQueTenhaUmPedidoPreviamenteCadastradoNoSistema()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL", "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapituloProduto();
            Thread.Sleep(2000);
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "1");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "2");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaCriarPedidoManualmentePage.Navegar();
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(CadastrarObraEComposicaoPage.Obra, "10/10/2018", "10", "GLOBONEWS", "ABERTURA");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
        }

        [Given(@"que esteja na aba de pagamento")]
        public void DadoQueEstejaNaAbaDePagamento()
        {
            TelaPedidoPage.AcessarAbaPagamento();
        }

        [When(@"seleciono um item do pedido")]
        public void QuandoSelecionoUmItemDoPedido()
        {
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(CadastrarObraEComposicaoPage.Autor);
        }
        
        [Then(@"visualizo o valor total do item selecionado")]
        public void EntaoVisualizoOValorTotalDoItemSelecionado()
        {
            TelaPedidoPage.ValidarValorTotalUmItemSelecionado();
        }

        //Soma de itens na busca por pedido
        [When(@"seleciono dois itens do pedido")]
        public void QuandoSelecionoDoisItensDoPedido()
        {
            TelaPedidoPage.SelecionarDoisItensDePedido(CadastrarObraEComposicaoPage.Autor, CadastrarObraEComposicaoPage.Autor2);
        }
        
        [Then(@"visualizo o valor total da soma dos itens selecionados")]
        public void EntaoVisualizoOValorTotalDaSomaDosItensSelecionados()
        {
            TelaPedidoPage.ValidarValorTotalDoisItensSelecionados();
        }

        //Subtração de itens na busca por pedido
        [When(@"seleciono todos os itens do pedido")]
        public void QuandoSelecionoTodosOsItensDoPedido()
        {
            TelaPedidoPage.SelecionarDoisItensDePedido(CadastrarObraEComposicaoPage.Autor, CadastrarObraEComposicaoPage.Autor2);
            TelaPedidoPage.ValidarValorTotalDoisItensSelecionados();
        }

        [When(@"retiro da selecao um item")]
        public void QuandoRetiroDaSelecaoUmItem()
        {
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(CadastrarObraEComposicaoPage.Autor);
        }

        [Then(@"visualizo o valor total menos o valor do item nao selecionado")]
        public void EntaoVisualizoOValorTotalMenosOValorDoItemNaoSelecionado()
        {
            TelaPedidoPage.ValidarValorTotalUmItemSelecionado();
        }

        //Soma de itens na busca por pedido
        [Given(@"realizo uma consulta pelo numero do pedido")]
        public void DadoRealizoUmaConsultaPeloNumeroDoPedido()
        {
            TelaPedidoPage.RealizarBuscaPorPedido();
        }

        [When(@"seleciono todos os itens do pedido na aba de pagamento")]
        public void QuandoSelecionoTodosOsItensDoPedidoNaAbaDePagamento()
        {
            TelaPedidoPage.SelecionarDoisItensDePedidoNaTelaDeBusca();
        }

        [Then(@"visualizo o valor total da soma dos itens selecionados no resultado da busca")]
        public void EntaoVisualizoOValorTotalDaSomaDosItensSelecionadosNoResultadoDaBusca()
        {
            TelaPedidoPage.ValidarValorTotalDoisItensSelecionadosNaTelaDeBusca();
        }

        //Subtração de itens na busca por pedido
        [When(@"retiro da selecao um item do pedido")]
        public void QuandoRetiroDaSelecaoUmItemDoPedido()
        {
            TelaPedidoPage.SelecionarUmItemDePedidoNaTelaDeBusca();
            TelaPedidoPage.SelecionarUmItemDePedidoNaTelaDeBusca();
        }

        [Then(@"visualizo o valor total menos o valor do item não selecionado no resultado da busca")]
        public void EntaoVisualizoOValorTotalMenosOValorDoItemNaoSelecionadoNoResultadoDaBusca()
        {
            TelaPedidoPage.ValidarValorTotalUmItemSelecionadoNaTelaDeBusca();
        }

    }
}
