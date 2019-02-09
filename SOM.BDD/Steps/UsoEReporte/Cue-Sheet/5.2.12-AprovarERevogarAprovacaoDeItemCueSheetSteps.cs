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
    public sealed class AprovarERevogarAprovacaoDeItemCueSheetSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public AprovarERevogarAprovacaoDeItemCueSheetSteps()
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

        [Then(@"visualizo o percentual de aprovação da Cue-Sheet alterado ""(.*)""")]
        public void EntaoVisualizoOPercentualDeAprovacaoDaCue_SheetAlterado(string Porcentagem)
        {
            TelaCadastrarCueSheetPage.ValidarPorcentagelDeAprovacaoDaCueSheet(Porcentagem);
        }
        
        [Given(@"que tenha um item cadastrado na Cue-Sheet sem Interprete ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmItemCadastradoNaCue_SheetSemInterprete(string Obra, string Utilizacao, string Sincronismo, string Tempo, string Interprete)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadasTrarItemCueSheetRandomico(Obra, Utilizacao, Sincronismo, Tempo, Interprete);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra, Tempo, Utilizacao, Sincronismo, "Não");
        }

        [Then(@"visualizo uma mensagem de alerta informando que o item não pode ser aprovado devido a pendencia do Interprete")]
        public void EntaoVisualizoUmaMensagemDeAlertaInformandoQueOItemNaoPodeSerAprovadoDevidoAPendenciaDoInterprete()
        {
            TelaCadastrarCueSheetPage.ValidarPendenciaItemCueSheet("");
        }

        [When(@"aprovo dois itens cadastrados na Cue-Sheet ""(.*)"", ""(.*)""")]
        public void QuandoAprovoDoisItensCadastradosNaCue_Sheet(string Obra, string Obra2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Obra2);
        }

        [Then(@"visualizo os itens aprovados na Cue-Sheet com sucesso ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsItensAprovadosNaCue_SheetComSucesso(string Obra, string Obra2)
        {
            TelaCadastrarCueSheetPage.ValidarItensAprovados(CadastrarObraEComposicaoPage.Obra);
            TelaCadastrarCueSheetPage.ValidarItensAprovados(Obra2);
        }

        [When(@"revogo a aprovação de um item da Cue-Sheet ""(.*)""")]
        public void QuandoRevogoAAprovacaoDeUmItemDaCue_Sheet(string Obra)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.RevogarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
        }

        [When(@"revogo a aprovação de dois itens da Cue-Sheet ""(.*)"", ""(.*)""")]
        public void QuandoRevogoAAprovacaoDeDoisItensDaCue_Sheet(string Obra, string Obra2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.RevogarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.RevogarItemDeCueSheet(Obra2);
        }

        //Revogar itens com pedidos em aberto
        [Given(@"que tenha uma Cue-Sheet cadastrada com dois pedidos gerados")]
        public void DadoQueTenhaUmaCue_SheetCadastradaComDoisPedidosGerados()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheetRandomica("Aleatório", "Aleatório", "01", "11/11/2018", "GLOBONEWS", "");
            TelaCadastrarCueSheetPage.ValidarPopupSemImportacao("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", "Cue-sheet cadastrada com sucesso ");
            TelaCadastrarCueSheetPage.ValidarCueSheetRandomicaCadastrada("Aleatório", "", "Aleatório", "01", "");

            TelaGerarPedidosDePagamentoCueSheetPage.CadasTrarItemCueSheetRandomico("Aleatório", "BK – BACKGROUND", "ABERTURA", "16", "");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado("Aleatório", "16", "BK – BACKGROUND", "ABERTURA", "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", CadastrarObraEComposicaoPage.Obra, "Sim");

            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet("TESTE INMETRICS", "BK – BACKGROUND", "ABERTURA", "16");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado("TESTE INMETRICS", "16", "BK – BACKGROUND", "ABERTURA", "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet("TESTE INMETRICS");
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", "TESTE INMETRICS", "Sim");
        }

        [When(@"revogo a aprovação dos dois itens com pedidos pendentes")]
        public void QuandoRevogoAAprovacaoDosDoisItensComPedidosPendentes()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.RevogarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.RevogarItemDeCueSheet("TESTE INMETRICS");
        }

        [Then(@"visualizo a mensagem que a aprovação foi revogada e os itens estão liberados para edição ""(.*)""")]
        public void EntaoVisualizoAMensagemQueAAprovacaoFoiRevogadaEOsItensEstaoLiberadosParaEdicao(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarPopup(Mensagem);
        }

        //Revogar itens enviados para pagamento
        [Given(@"que tenha um item com pedido enviado para pagamento")]
        public void DadoQueTenhaUmItemComPedidoEnviadoParaPagamento()
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
            TelaPedidoPage.TrocarParaPrimeiraAba();
        }

        [When(@"revogo o item com pedido enviado para pagamento")]
        public void QuandoRevogoOItemComPedidoEnviadoParaPagamento()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.RevogarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
        }

    }
}
