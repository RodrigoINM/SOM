using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
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

    }
}
