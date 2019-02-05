using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido
{
    [Binding]
    public sealed class CriarItensParaDNISteps
    {
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }

        public CriarItensParaDNISteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCriarPedidoManualmentePage = new CriarPedidoManualmentePage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDePedidoUrl"]);
            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
        }

        [When(@"cadastrar um item de DNI para o pedido")]
        public void QuandoCadastrarUmItemDeDNIParaOPedido()
        {
            TelaPedidoPage.CadastrarDNI("Sim");
            TelaPedidoPage.ValidarPopupSucesso("Itens para pagamento da DNI gerados com sucesso.");
        }

        [Then(@"visualizo os novos itens de DNI cadastrados no detalhe do pedido com sucesso")]
        public void EntaoVisualizoOsNovosItensDeDNICadastradosNoDetalheDoPedidoComSucesso()
        {
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes("DNI");
        }

        [When(@"cancelo o cadastro de um item de DNI para o pedido")]
        public void QuandoCanceloOCadastroDeUmItemDeDNIParaOPedido()
        {
            TelaPedidoPage.CadastrarDNI("Não");
        }

        [Then(@"visualizo apenas o item do pedido na tela de detalhes")]
        public void EntaoVisualizoApenasOItemDoPedidoNaTelaDeDetalhes()
        {
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes(CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes("100%");
            TelaPedidoPage.ValidarDadosDePedidoAbaAutorizacaoDetalhes("GLOBONEWS");
        }

        [Given(@"que o pedido já possua itens de DNI cadastrados")]
        public void DadoQueOPedidoJaPossuaItensDeDNICadastrados()
        {
            TelaPedidoPage.CadastrarDNI("Sim");
            TelaPedidoPage.ValidarPopupSucesso("Itens para pagamento da DNI gerados com sucesso.");
        }

        [When(@"tento cadastrar novos itens de DNI para o pedido")]
        public void QuandoTentoCadastrarNovosItensDeDNIParaOPedido()
        {
            TelaPedidoPage.CadastrarDNI("Sim");
        }

        [Then(@"visualizo uma mensagem de que o peido já possui itens de DNI cadastrados ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeQueOPeidoJaPossuiItensDeDNICadastrados(string Mensagem)
        {
            TelaPedidoPage.ValidarMensagemDeAlerta(Mensagem);
        }

    }
}
