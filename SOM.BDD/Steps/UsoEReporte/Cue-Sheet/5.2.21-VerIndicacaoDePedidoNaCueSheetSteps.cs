using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Cue_Sheet
{
    [Binding]
    public sealed class VerIndicacaoDePedidoNaCueSheetSteps
    {
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public VerIndicacaoDePedidoNaCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaGerarPedidosDePagamentoCueSheetPage = new GerarPedidosDePagamentoCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"],
                ConfigurationManager.AppSettings["DetalheDaCueSheetUrl"]);
            TelaAlterarItemPedidoPage = new AlterarItemPedidoPage((IBrowser)browser);
            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
        }

        [When(@"acesso o icone do pedido na Cue-Sheet")]
        public void QuandoAcessoOIconeDoPedidoNaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AcessarPedidoDeCueSheet(CadastrarObraEComposicaoPage.Obra);
        }

        [Then(@"visualizo a tela de detalhes do pedido cadastrado com sucesso")]
        public void EntaoVisualizoATelaDeDetalhesDoPedidoCadastradoComSucesso()
        {
            TelaAlterarItemPedidoPage.ValidarStatusAutorizacao("Pendente", CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.TrocarParaPrimeiraAba();
        }

    }
}
