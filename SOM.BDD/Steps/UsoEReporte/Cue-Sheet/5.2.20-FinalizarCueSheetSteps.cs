using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.UsoEReporte.Cue_Sheet;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Cue_Sheet
{
    [Binding]
    public sealed class FinalizarCueSheetSteps
    {
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public FinalizarCueSheetSteps()
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

        [When(@"finalizo a Cue-Sheet")]
        public void QuandoFinalizoACue_Sheet()
        {
            TelaCadastrarCueSheetPage.FinalizarCueSheet();
            TelaCadastrarCueSheetPage.ValidarPopup("Cue-sheet finalizada com sucesso!");
        }

        [Then(@"visualizo o Status da Cue-Sheet como Finalizada ""(.*)""")]
        public void EntaoVisualizoOStatusDaCue_SheetComoFinalizada(string Status)
        {
            TelaCadastrarCueSheetPage.ValidarStatusDaCueSheet(Status);
        }

        [Then(@"visualizo o Status da Cue-Sheet como parcialmente validada ""(.*)""")]
        public void EntaoVisualizoOStatusDaCue_SheetComoParcialmenteValidada(string Status)
        {
            TelaCadastrarCueSheetPage.ValidarStatusDaCueSheet(Status);
        }

        [When(@"reinicio a Cue-Sheet")]
        public void QuandoReinicioACue_Sheet()
        {
            TelaCadastrarCueSheetPage.ReiniciarCueSheet();
        }

        [Then(@"visualizo o Status da Cue-Sheet como Validada ""(.*)""")]
        public void EntaoVisualizoOStatusDaCue_SheetComoValidada(string Status)
        {
            TelaCadastrarCueSheetPage.ValidarStatusDaCueSheet(Status);
        }

    }
}
