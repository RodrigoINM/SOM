using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System;
using Framework.Core.Extensions.ElementExtensions;
using System.Threading;
using SOM.BDD.Pages.Obra;
using Framework.Core.Helpers;
using SOM.BDD.Pages.Produto;

namespace SOM.BDD.Pages.Pagamento.Pedido
{
    public class CriarPedidoManualmentePage : PageBase
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; set; }

        private string CadastroDePedidoUrl { get; }

        private string PageTitle => "SOM | Criar Pedido";

        //Cadastro de Interprete
        public Element BtnCadastrarInterprete { get; private set; }
        public Element InpNomeInterprete { get; private set; }
        public Element BtnSalvarCadastroDeInterprete { get; private set; }

        //Cadastro de Pedido
        public Element InpProduto { get; private set; }
        public Element InpEpisodio { get; private set; }
        public Element InpCapitulo { get; private set; }
        public Element InpTituloObra { get; private set; }
        public Element BtnBuscarTituloObra { get; private set; }
        public Element InpDataExibicao { get; private set; }
        public Element InpTempo { get; private set; }
        public Element SlctMidiaADebitar { get; private set; }
        public Element SlctSincronismo { get; private set; }
        public Element BtnSalvarPedido { get; private set; }

        public CriarPedidoManualmentePage(IBrowser browser, string cadastroDePedidoUrl) : base(browser)
        {
            CadastroDePedidoUrl = cadastroDePedidoUrl;

            //Cadastro de Interprete
            BtnCadastrarInterprete = Element.Css("button[ng-click='CadastrarInterprete()']");
            InpNomeInterprete = Element.Css("input[ng-model='Interprete.Nome']");
            BtnSalvarCadastroDeInterprete = Element.Css("button[ng-click='cadastrarInterprete()']");

            //Cadastro de Pedido
            InpProduto = Element.Css("input[ng-model='DscProduto']");
            InpEpisodio = Element.Css("input[ng-model='PedidoDados.DscEpisodio']");
            InpCapitulo = Element.Css("input[ng-model='PedidoDados.Capitulo']");
            InpTituloObra = Element.Css("input[ng-model='PedidoDados.Obra.Text']");
            BtnBuscarTituloObra = Element.Css("button[ng-click='OpenObraFonogramaModal()']");
            InpDataExibicao = Element.Css("input[ng-model='PedidoDados.DataExibicao']");
            InpTempo = Element.Css("input[id='tempo']");
            SlctMidiaADebitar = Element.Css("select[ng-model='PedidoDados.Midia']");
            SlctSincronismo = Element.Css("div[ng-model='PedidoDados.Sincronismo'] i[class='caret pull-right']");
            BtnSalvarPedido = Element.Css("a[ng-click='salvarPedido()']");
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastroDePedidoUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        private void SelecionarMidiaADebitar(string Valor)
        {
            MouseActions.SelectElementATM(Browser, SlctMidiaADebitar, Valor);
        }

        private void SelecionarSincronismo(string Valor)
        {
            try
            {
                Thread.Sleep(1500);
                MouseActions.ClickATM(Browser, SlctSincronismo);
            }
            catch
            {
                Thread.Sleep(1500);
                MouseActions.ClickATM(Browser, SlctSincronismo);
            }
            MouseActions.ClickATM(Browser, Element.Xpath("//div[text()='" + Valor + "']"));
        }

        public void SelecionarObraFonograma(string Obra)
        {
            AutomatedActions.SendData(Browser, InpTituloObra, Obra);
            MouseActions.ClickATM(Browser, BtnBuscarTituloObra);
            MouseActions.DoubleClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarObra(item)']/td[text()='" + Obra + "']"));
        }

        public void CadastroDeInterprete()
        {
            MouseActions.ClickATM(Browser, BtnCadastrarInterprete);
            AutomatedActions.SendDataATM(Browser, InpNomeInterprete, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeInterprete);
            Thread.Sleep(2000);
        }
            
        public void CadastrarPedidoManualObraDominioPublico()
        {
            AutomatedActions.SendDataATM(Browser, InpProduto, CadastroDeProdutoPage.Produto);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + CadastroDeProdutoPage.Produto + "']"));
            SelecionarObraFonograma(CadastrarObraEComposicaoPage.Obra);
        }

        public void CadastrarPedidoManual(string Obra, string DataExibicao, string Tempo, string MidiaADebitar, string Sincronismo)
        {
            AutomatedActions.SendDataATM(Browser, InpProduto, CadastroDeProdutoPage.Produto);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + CadastroDeProdutoPage.Produto + "']"));
            SelecionarObraFonograma(Obra);
            AutomatedActions.SendData(Browser, InpDataExibicao, DataExibicao);
            Thread.Sleep(1500);
            AutomatedActions.SendData(Browser, InpTempo, Tempo);
            SelecionarMidiaADebitar(MidiaADebitar);
            SelecionarSincronismo(Sincronismo);
            //CadastroDeInterprete();
            AutomatedActions.SendDataATM(Browser, InpEpisodio, CadastroDeProdutoPage.Episodio);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + CadastroDeProdutoPage.Episodio + "']"));
            AutomatedActions.SendDataATM(Browser, InpCapitulo, "01");
            MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='01']"));

            MouseActions.ClickATM(Browser, BtnSalvarPedido);
            Thread.Sleep(1500);
        }

        public void TrocarAbaBrowser()
        {
            Browser.CloseFirstWindow();
            Browser.SwitchToLastWindow();
        }

        public void ValidarPedidoCriado(string MidiaADebitar, string Sincronismo, string Status, string StatusPav, string Reprise)
        {
            Thread.Sleep(2000);
            ValidarTextoTabela(MidiaADebitar);
            ValidarTextoTabela(Sincronismo);
            ValidarStatus(Status);
            ValidarStatusPav(StatusPav);
            ValidarStatusPav(Reprise);
        }

        private void ValidarTextoTabela(string Valor)
        {
            var texto = Element.Xpath("//span[1][contains (., '" + Valor + "')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(texto, Browser));
        }

        private void ValidarStatus(string Valor)
        {
            var texto = Element.Xpath("//b[contains (., '" + Valor + "')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(texto, Browser));
        }

        private void ValidarStatusPav(string Valor)
        {
            var texto = Element.Xpath("//span[contains (., '" + Valor + "')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(texto, Browser));
        }

        public void ValidarPopupCritica(string Mensagem)
        {
            var texto = Element.Css("p[style='display: block;']");
            ElementExtensions.IsElementVisible(texto, Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(texto, "textContent", Browser));
        }

        public void ValidarPopupSucesso(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            Thread.Sleep(2000);
            if (Mensagem != "")
            {
                Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));
                Thread.Sleep(2000);
            }
            else
            {
                Assert.IsTrue(ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser));
                Thread.Sleep(2000);
            }
        }

    }
}
