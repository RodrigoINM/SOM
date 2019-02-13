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
    public sealed class ExcluirItemCueSheetSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }

        public ExcluirItemCueSheetSteps()
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

        [When(@"excluo um item cadastrado na Cue-Sheet ""(.*)""")]
        public void QuandoExcluoUmItemCadastradoNaCue_Sheet(string Obra)
        {
            if(Obra == "Aleatório")
                TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(CadastrarObraEComposicaoPage.Obra);
            else
                TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Obra);
        }

        [Then(@"visualizo uma mensagem de registro excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeRegistroExcluidoComSucesso(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarPopup(Mensagem);
        }

        [Given(@"que tenha dois itens cadastrados na Cue-Sheet ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaDoisItensCadastradosNaCue_Sheet(string Obra, string Obra2, string Utilizacao, string Sincronismo, string Tempo, string Interprete)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadasTrarItemCueSheetRandomico(Obra, Utilizacao, Sincronismo, Tempo, "");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra, Tempo, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Obra2, Utilizacao, Sincronismo, Tempo);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra2, Tempo, Utilizacao, Sincronismo, "Não");
        }

        [When(@"excluo os dois itens cadastrados na Cue-Sheet ""(.*)"", ""(.*)""")]
        public void QuandoExcluoOsDoisItensCadastradosNaCue_Sheet(string Obra, string Obra2)
        {
            if (Obra == "Aleatório")
                TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(CadastrarObraEComposicaoPage.Obra);
            else
                TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Obra2);
        }

        [When(@"seleciono um item e clico em excluir ""(.*)""")]
        public void QuandoSelecionoUmItemEClicoEmExcluir(string Obra)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheetPorObra(Obra);
        }

        [When(@"cancelo a exclusão do item da Cue-Sheet")]
        public void QuandoCanceloAExclusaoDoItemDaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ConfirmarExclusaoDeItem("Não");
        }

        [Then(@"visualizo os dados do item da Cue-Sheet na grid com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDoItemDaCue_SheetNaGridComSucesso(string Obra, string Utilizacao, string Sincronismo, string Tempo)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra, Tempo, Utilizacao, Sincronismo, "Não");
        }

        [When(@"seleciono os itens e clico em excluir ""(.*)"", ""(.*)""")]
        public void QuandoSelecionoOsItensEClicoEmExcluir(string Obra, string Obra2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheetPorObra(Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheetPorObra(Obra2);
        }

        [When(@"cancelo a exclusão dos itens da Cue-Sheet")]
        public void QuandoCanceloAExclusaoDosItensDaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ConfirmarExclusaoDeItem("Não");
        }

        [Then(@"visualizo os dados dos itens da Cue-Sheet na grid com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDosItensDaCue_SheetNaGridComSucesso(string Obra, string Obra2, string Utilizacao, string Sincronismo, string Tempo)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra, Tempo, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra2, Tempo, Utilizacao, Sincronismo, "Não");
        }

        [Given(@"que tenha um item aprovado ""(.*)""")]
        public void DadoQueTenhaUmItemAprovado(string Obra)
        {
            if(Obra == "Aleatório")
            {
                TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
                TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", CadastrarObraEComposicaoPage.Obra, "Sim");
            }
            else
            {
                TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Obra);
                TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", Obra, "Sim");
            }
        }


    }
}
