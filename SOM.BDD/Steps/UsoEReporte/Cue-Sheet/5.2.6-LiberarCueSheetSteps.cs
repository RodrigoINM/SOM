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
    public sealed class LiberarCueSheetSteps
    {
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public LiberarCueSheetSteps()
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

        [Given(@"que tenha um item cadastrado na cue-sheet")]
        public void DadoQueTenhaUmItemCadastradoNaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheetSemFonograma(CadastrarObraEComposicaoPage.Obra, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, "12", "BK – BACKGROUND", "ABERTURA", "Não");
        }

        [When(@"libero a cue-sheet")]
        public void QuandoLiberoACue_Sheet()
        {
            TelaCadastrarCueSheetPage.LiberarCueSheet();
        }

        [Then(@"visualizo uma mensagem de cue-sheet liberada com sucesso ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeCue_SheetLiberadaComSucesso(string Mensagem)
        {
            TelaCadastroDeProdutoPage.ValidarPopUpSucesso(Mensagem);
        }

    }
}
