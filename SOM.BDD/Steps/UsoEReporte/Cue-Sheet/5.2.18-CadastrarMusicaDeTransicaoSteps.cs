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
    public sealed class CadastrarMusicaDeTransicaoSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public CadastrarMusicaDeTransicaoSteps()
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

        [When(@"cadastro um item de Cue-Sheet com Musica de transição ""(.*)""")]
        public void QuandoCadastroUmItemDeCue_SheetComMusicaDeTransicao(string Titulo)
        {
            if (Titulo == "Aleatório")
                TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemDeCueSheetComMusicaDeTransicao(CadastrarObraEComposicaoPage.Obra, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
            else
                TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemDeCueSheetComMusicaDeTransicao(Titulo, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
        }

        [Then(@"visualizo a Musica de Transição cadastrada com sucesso ""(.*)""")]
        public void EntaoVisualizoAMusicaDeTransicaoCadastradaComSucesso(string Titulo)
        {
            if (Titulo == "Aleatório")
                TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            else
                TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemDeCueSheet(Titulo);
        }

        [When(@"cadastro um item de Cue-Sheet com Musica de transição repetida ""(.*)""")]
        public void QuandoCadastroUmItemDeCue_SheetComMusicaDeTransicaoRepetida(string Titulo)
        {
            if (Titulo == "Aleatório")
                TelaGerarPedidosDePagamentoCueSheetPage.CadastrarMusicaDeTransicao(CadastrarObraEComposicaoPage.Obra, CadastrarObraEComposicaoPage.Autor);
            else
                TelaGerarPedidosDePagamentoCueSheetPage.CadastrarMusicaDeTransicao(Titulo, CadastrarObraEComposicaoPage.Autor);
        }

        [Then(@"visualizo um mensagem de alerta")]
        public void EntaoVisualizoUmMensagemDeAlerta()
        {
            TelaCadastrarCueSheetPage.ValidarAlerta("Ocorreu um erro ao salvar o item.");
        }

    }
}
