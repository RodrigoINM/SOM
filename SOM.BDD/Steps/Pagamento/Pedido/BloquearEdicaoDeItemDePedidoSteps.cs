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
    public sealed class BloquearEdicaoDeItemDePedidoSteps
    {
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public BloquearEdicaoDeItemDePedidoSteps()
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

        [Given(@"que tenha um pedido previamente cadastrado no sistema com apenas um autor na composição")]
        public void DadoQueTenhaUmPedidoPreviamenteCadastradoNoSistemaComApenasUmAutorNaComposicao()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
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

        [Given(@"que possua um item que esteja aguardando aprovação para pagamento")]
        public void DadoQuePossuaUmItemQueEstejaAguardandoAprovacaoParaPagamento()
        {
            TelaAlterarItemPedidoPage.RegistrarAutorizacaoDeItem(CadastrarObraEComposicaoPage.Autor);
            TelaAlterarItemPedidoPage.ValidarPopupAutorizacaoDDA("", "Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("1 item(ns) registrado(s) com sucesso.");
            TelaAlterarItemPedidoPage.ValidarStatusAutorizacao("Autorizado", CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(CadastrarObraEComposicaoPage.Autor);
            TelaAlterarItemPedidoPage.RealizarPagamento();
            TelaAlterarItemPedidoPage.PopupRealizarPagamento("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("Aguardando Aprovação", CadastrarObraEComposicaoPage.Autor);
        }

        [When(@"altero o DDA da Obra que possui um pedido que esteja aguardando aprovação")]
        public void QuandoAlteroODDADaObraQuePossuiUmPedidoQueEstejaAguardandoAprovacao()
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(CadastrarObraEComposicaoPage.Obra);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(CadastrarObraEComposicaoPage.Autor);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "Aleatório", "", "1");
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
            Thread.Sleep(3000);
        }

        [Then(@"nao visualizo o pedido aguardando aprovacao na lista de pedidos a serem afetados pela auteração")]
        public void EntaoNaoVisualizoOPedidoAguardandoAprovacaoNaListaDePedidosASeremAfetadosPelaAuteracao()
        {
            TelaPedidoPage.Navegar();
            TelaPedidoPage.BuscaAvancadaDePedido("", CadastroDeProdutoPage.Produto, CadastrarObraEComposicaoPage.Obra, "", "", "", "", "", "", "", "", "", "");
            TelaPedidoPage.AbrirPedido(CadastroDeProdutoPage.Produto);
            TelaPedidoPage.TrocarAbaBrowser();
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("Aguardando Aprovação", CadastrarObraEComposicaoPage.Autor);
        }

        [When(@"altero o Autor da Obra que possui um pedido que esteja aguardando aprovação")]
        public void QuandoAlteroOAutorDaObraQuePossuiUmPedidoQueEstejaAguardandoAprovacao()
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(CadastrarObraEComposicaoPage.Obra);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(CadastrarObraEComposicaoPage.Autor);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("Aleatório", "", "", "2");
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
            Thread.Sleep(3000);
        }

    }
}
