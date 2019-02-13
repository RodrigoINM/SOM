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

        [When(@"tento cadastrar um item de Cue-Sheet sem preencher o titulo da musica ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoTentoCadastrarUmItemDeCue_SheetSemPreencherOTituloDaMusica(string Titulo, string Gravadora, string Submix)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
        }

        [Then(@"visualizo o campo de Título da obra em destaque")]
        public void EntaoVisualizoOCampoDeTituloDaObraEmDestaque()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarCampoEmBranco("Título");
        }

        [Given(@"que tenha um item de Cue-Sheet cadastrado com Musica de transição ""(.*)""")]
        public void DadoQueTenhaUmItemDeCue_SheetCadastradoComMusicaDeTransicao(string Titulo)
        {
            if(Titulo == "Aleatório")
                TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemDeCueSheetComMusicaDeTransicao(CadastrarObraEComposicaoPage.Obra, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
            else
                TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemDeCueSheetComMusicaDeTransicao(Titulo, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
        }

        [When(@"tento cadastrar uma Musica de transição sem informar o Titulo")]
        public void QuandoTentoCadastrarUmaMusicaDeTransicaoSemInformarOTitulo()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarMusicaDeTransicao("", "");
        }

        [Then(@"visualizo o campo de Titulo em destaque")]
        public void EntaoVisualizoOCampoDeTituloEmDestaque()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarMusicaDeTransicaoEmBranco();
        }

    }
}
