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
    public sealed class ReabrirCueSheetSteps
    {
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public ReabrirCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCueSheetPage = new CadastrarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCueSheet"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaGerarPedidosDePagamentoCueSheetPage = new GerarPedidosDePagamentoCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"],
                ConfigurationManager.AppSettings["DetalheDaCueSheetUrl"]);
        }

        [When(@"reabro a cue-sheet")]
        public void QuandoReabroACue_Sheet()
        {
            TelaCadastrarCueSheetPage.ReabrirCueSheet();
        }

        [Then(@"visualizo a mensagem de cues-cheet reaberta com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeCues_CheetReabertaComSucesso(string Mensagem)
        {
            TelaCadastroDeProdutoPage.ValidarPopUpSucesso(Mensagem);
        }

        [Given(@"que a cue-sheet esteja aberta")]
        public void DadoQueACue_SheetEstejaAberta()
        {
            TelaCadastrarCueSheetPage.ValidarStatusDaCueSheet("Em Aberto");
        }

        [Then(@"visualizo apenas o botão para liberar a cue-sheet")]
        public void EntaoVisualizoApenasOBotaoParaLiberarACue_Sheet()
        {
            TelaCadastrarCueSheetPage.ValidarBotaoLiberarCueSheet();
        }

    }
}
