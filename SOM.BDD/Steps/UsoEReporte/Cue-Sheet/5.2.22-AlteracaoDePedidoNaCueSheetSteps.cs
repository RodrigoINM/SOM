using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.UsoEReporte.Cue_Sheet;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Cue_Sheet
{
    [Binding]
    public sealed class AlteracaoDePedidoNaCueSheetSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public AlteracaoDePedidoNaCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCueSheetPage = new CadastrarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCueSheet"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaGerarPedidosDePagamentoCueSheetPage = new GerarPedidosDePagamentoCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"],
                ConfigurationManager.AppSettings["DetalheDaCueSheetUrl"]);
            TelaAlterarItemPedidoPage = new AlterarItemPedidoPage((IBrowser)browser);
            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
        }

        [Given(@"que tenha gerado um pedido para o item cadastrado na Cue-Sheet")]
        public void DadoQueTenhaGeradoUmPedidoParaOItemCadastradoNaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", CadastrarObraEComposicaoPage.Obra, "Sim");
        }

        [Given(@"que tenha acessado os detalhes do pedido gerado na Cue-Sheet")]
        public void DadoQueTenhaAcessadoOsDetalhesDoPedidoGeradoNaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AcessarPedidoDeCueSheet(CadastrarObraEComposicaoPage.Obra);
        }

        [When(@"volto para a tela da Cue-Sheet e altero o titulo da obra do item da Cue-Sheet")]
        public void QuandoVoltoParaATelaDaCue_SheetEAlteroOTituloDaObraDoItemDaCue_Sheet()
        {
            TelaPedidoPage.TrocarParaPrimeiraAbaSemFecharUltimaAba();
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemAAlterar(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetRandomico("TESTE INMETRICS", "BK – BACKGROUND", "ABERTURA", "");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado("TESTE INMETRICS", "12", "BK – BACKGROUND", "ABERTURA", "Não");
        }

        [When(@"volto para a tela de detalhes do pedido anterior")]
        public void QuandoVoltoParaATelaDeDetalhesDoPedidoAnterior()
        {
            TelaPedidoPage.TrocarAbaBrowser();
        }

        [Then(@"visualizo que o pedido anterior foi cancelado com sucesso")]
        public void EntaoVisualizoQueOPedidoAnteriorFoiCanceladoComSucesso()
        {
            TelaPedidoPage.ValidarStatusDePedido("Cancelado");
        }

        [When(@"volto para a tela da Cue-Sheet e altero o sincronismo do item da Cue-Sheet")]
        public void QuandoVoltoParaATelaDaCue_SheetEAlteroOSincronismoDoItemDaCue_Sheet()
        {
            TelaPedidoPage.TrocarParaPrimeiraAbaSemFecharUltimaAba();
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemAAlterar(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetRandomico("", "", "ADORNO", "");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, "12", "BK – BACKGROUND", "ADORNO", "Não");
        }

        [When(@"volto para a tela da Cue-Sheet e altero o item da Cue-Sheet para Reprise")]
        public void QuandoVoltoParaATelaDaCue_SheetEAlteroOItemDaCue_SheetParaReprise()
        {
            TelaPedidoPage.TrocarParaPrimeiraAbaSemFecharUltimaAba();
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemAAlterar(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetParaReprise();
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, "12", "BK – BACKGROUND", "ABERTURA", "Não");
        }

        [Given(@"que tenha um produto do tipo Jornalismo cadastrado no sistema")]
        public void DadoQueTenhaUmProdutoDoTipoJornalismoCadastradoNoSistema()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Jornalismo", "JORNALISMO",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
        }

        [When(@"volto para a tela da Cue-Sheet e altero o item da Cue-Sheet para Fair Use")]
        public void QuandoVoltoParaATelaDaCue_SheetEAlteroOItemDaCue_SheetParaFairUse()
        {
            TelaPedidoPage.TrocarParaPrimeiraAbaSemFecharUltimaAba();
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemAAlterar(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetParaReprise();
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, "12", "BK – BACKGROUND", "ABERTURA", "Não");
        }

        [When(@"volto para a tela da Cue-Sheet e excluo o item da Cue-Sheet")]
        public void QuandoVoltoParaATelaDaCue_SheetEExcluoOItemDaCue_Sheet()
        {
            TelaPedidoPage.TrocarParaPrimeiraAbaSemFecharUltimaAba();
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(CadastrarObraEComposicaoPage.Obra);
        }

        [When(@"cadastro um novo item na Cue-Sheet")]
        public void QuandoCadastroUmNovoItemNaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheetSemFonograma("TESTE INMETRICS", "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", "MARCELLE MENDONCA");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado("TESTE INMETRICS", "12", "BK – BACKGROUND", "ABERTURA", "Não");
        }

        [When(@"gero um novo pedido para o item de Cue-Sheet cadastrado")]
        public void QuandoGeroUmNovoPedidoParaOItemDeCue_SheetCadastrado()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet("TESTE INMETRICS");
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", "TESTE INMETRICS", "Sim");
        }

        [Given(@"que tenha um item da Cue-Sheet com pedido enviado para pagamento")]
        public void DadoQueTenhaUmItemDaCue_SheetComPedidoEnviadoParaPagamento()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AcessarPedidoDeCueSheet(CadastrarObraEComposicaoPage.Obra);
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

        [Then(@"visualizo que o pedido anterior não foi cancelado")]
        public void EntaoVisualizoQueOPedidoAnteriorNaoFoiCancelado()
        {
            TelaPedidoPage.ValidarStatusDePedido("Em andamento");
        }

    }
}
