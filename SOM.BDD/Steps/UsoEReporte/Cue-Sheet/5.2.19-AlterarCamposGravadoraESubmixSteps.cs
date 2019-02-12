using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.UsoEReporte.Cue_Sheet;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Cue_Sheet
{
    [Binding]
    public sealed class AlterarCamposGravadoraESubmixSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public AlterarCamposGravadoraESubmixSteps()
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

        [When(@"altero a Gravadora e o Submix do item da Cue-Sheet ""(.*)"", ""(.*)""")]
        public void QuandoAlteroAGravadoraEOSubmixDoItemDaCue_Sheet(string Gravadora, string Submix)
        {
            TelaCadastrarCueSheetPage.AbrirItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarGravadoraESubmixDeItemDeCueSheet(Gravadora, Submix);
        }

        [Then(@"visualizo a Gravadora do item atualizada na grid da Cue-Sheet ""(.*)""")]
        public void EntaoVisualizoAGravadoraDoItemAtualizadaNaGridDaCue_Sheet(string Gravadora)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemDeCueSheet(Gravadora);
        }

    }
}
