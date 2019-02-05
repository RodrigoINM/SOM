using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOM.BDD.Pages.Produto
{
    public class ExclusaoDeProdutoPage : PageBase
    {

        //Excluir produto
        private Element BtnConfirmarExclusao { get; set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public Element BtnCancelarExclusao { get; private set; }

        public ExclusaoDeProdutoPage(IBrowser browser) : base(browser)
        {
            BtnConfirmarExclusao = Element.Css("button[class='confirm']");
            BtnCancelarExclusao = Element.Css("button[class='cancel']");
        }

        public override void Navegar()
        {
            throw new NotImplementedException();
        }

        public void ExcluirProduto(string Nome)
        {
            string nomeDDAExcluir = "//table[@dt-columns='dtColumns']//div[text()='" + Nome + "']/../..//div[@uib-tooltip='Excluir']";
            MouseActions.ClickATM(Browser, Element.Xpath(nomeDDAExcluir));
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            Thread.Sleep(1500);
        }

        public void ValidarExclusaoDeProduto(string Nome, string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));

            string caminhoElemento = "//table[@dt-columns='dtColumns']//*[text()='" + Nome + "']";
            try
            {
                ElementExtensions.IsElementVisible(Element.Xpath("//table[@dt-columns='dtColumns']//*[text()='Dados não encontratos']"), Browser);
            }
            catch
            {
                ElementExtensions.IsElementVisible(Element.Xpath(caminhoElemento), Browser);
            }
        }

        public void ExclusaoDeProdutoSimples(string Nome, string Mensagem)
        {
            ExcluirProduto(Nome);
            ValidarExclusaoDeProduto(Nome, Mensagem);
        }

        public void ExclusaoDeProduto(string Mensagem)
        {
            ExcluirProduto(CadastroDeProdutoPage.Produto);
            ValidarExclusaoDeProduto(CadastroDeProdutoPage.Produto, Mensagem);
        }

        public void ExcluirProdutoCadastrado(string Produto, string Confirmar)
        {
            string nomeProduto = "//table[@dt-columns='dtColumns']//div[text()='" + Produto + "']/../..//div[@uib-tooltip='Excluir']";
            MouseActions.ClickATM(Browser, Element.Xpath(nomeProduto));
            Thread.Sleep(1500);
            if(Confirmar == "Sim")
                MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            else
                MouseActions.ClickATM(Browser, BtnCancelarExclusao);
            Thread.Sleep(1500);
        }

        public void ValidarProdutoNaGridDeResultado(string Valor)
        {
            var textoProduto = Element.Xpath("//tbody//div[contains(., '" + Valor + "')]");
            try
            {
                ElementExtensions.IsElementVisible(textoProduto, Browser);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(textoProduto, Browser);
            }
        }

        public void ValidarProdutoExcluido(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));
        }
    }
}
