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
    public sealed class AlterarItemCueSheetSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }

        public AlterarItemCueSheetSteps()
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

        [When(@"alterar o Titulo do item cadastrado na Cue-Sheet ""(.*)"", ""(.*)""")]
        public void QuandoAlterarOTituloDoItemCadastradoNaCue_Sheet(string Obra, string Obra2)
        {
            TelaCadastrarCueSheetPage.AbrirItemDeCueSheet(Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetRandomico(Obra2, "", "", "");
        }
        
        [When(@"alterar dados do item cadastrado na Cue-Sheet ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlterarDadosDoItemCadastradoNaCue_Sheet(string Obra, string Obra2, string Utilizacao, string Sincronismo, string Tempo, string Interprete)
        {
            TelaCadastrarCueSheetPage.AbrirItemDeCueSheet(Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetRandomico(Obra2, Utilizacao, Sincronismo, Tempo);
        }

        [When(@"alterar o Interprete do item cadastrado na Cue-Sheet cadastrando um novo ""(.*)""")]
        public void QuandoAlterarOInterpreteDoItemCadastradoNaCue_SheetCadastrandoUmNovo(string Obra)
        {
            TelaCadastrarCueSheetPage.AbrirItemDeCueSheet(Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarNovoInterprete();
        }

        [Then(@"visualizo uma mensagem de item alterado com sucesso ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeItemAlteradoComSucesso(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarPopup(Mensagem);
        }

        [When(@"aprovo um item da Cue-Sheet ""(.*)""")]
        public void QuandoAprovoUmItemDaCue_Sheet(string Obra)
        {
            if(Obra == "Aleatório")
            {
                Obra = CadastrarObraEComposicaoPage.Obra;
                TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Obra);
            }
            else
                TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Obra);
        }

        [Then(@"não consigo mais editar o item aprovado da Cue-Sheet ""(.*)""")]
        public void EntaoNaoConsigoMaisEditarOItemAprovadoDaCue_Sheet(string Obra)
        {
            if (Obra == "Aleatório")
            {
                Obra = CadastrarObraEComposicaoPage.Obra;
                TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Obra, "", "", "", "");
            }
            else
                TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Obra, "", "", "", "");
        }

    }
}
