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
    public sealed class PagarParaAdministradorSteps
    {
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public PagarParaAdministradorSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCriarPedidoManualmentePage = new CriarPedidoManualmentePage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDePedidoUrl"]);
            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
            TelaAlterarItemPedidoPage = new AlterarItemPedidoPage((IBrowser)browser);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
        }

        [Given(@"que tenha um pedido previamente cadastrado no sistema com apenas um autor e DDA na composição ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmPedidoPreviamenteCadastradoNoSistemaComApenasUmAutorEDDANaComposicao(string Autor, string DDA)
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicao(Autor, DDA, "100");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL", "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapituloProduto();
            Thread.Sleep(2000);
            TelaCriarPedidoManualmentePage.Navegar();
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(CadastrarObraEComposicaoPage.Obra, "10/10/2018", "10", "GLOBONEWS", "ABERTURA");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
        }

        [When(@"informo que o pagamento será feito ao Administrador do DDA do pedido ""(.*)""")]
        public void QuandoInformoQueOPagamentoSeraFeitoAoAdministradorDoDDADoPedido(string Autor)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Autor);
            TelaPedidoPage.PagarAoAdministrador("Sim");
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes("Sim");
            TelaPedidoPage.ValidarPopupSucesso("Itens do pedido atualizados com sucesso!");
        }

        [Then(@"visualizo o item do pedido marcado para pagamento ao administrador com sucesso ""(.*)""")]
        public void EntaoVisualizoOItemDoPedidoMarcadoParaPagamentoAoAdministradorComSucesso(string Autor)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes(Autor);
            TelaPedidoPage.ValidarDadosDePedidoAbaPagamentoDetalhes("Sim");
        }

        [Given(@"nenhum item do pedido possui DDA com administrador")]
        public void DadoNenhumItemDoPedidoPossuiDDAComAdministrador()
        {
            
        }

        [Then(@"nao visualizo a opcao de pagar para o administrador ""(.*)""")]
        public void EntaoNaoVisualizoAOpcaoDePagarParaOAdministrador(string Autor)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Autor);
        }

    }
}
