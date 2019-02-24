using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SOM.BDD.Pages
{
    public sealed class BuscaRapidaPage : PageBase
    {
        public Element InpBuscaRapida { get; private set; }

        public BuscaRapidaPage(IBrowser browser) : base(browser)
        {
            InpBuscaRapida = Element.Css("input[ng-model='pesquisaTexto']");
        }

        public override void Navegar()
        {
            throw new NotImplementedException();
        }

        public void ConsultaRapida(string Texto)
        {
            AutomatedActions.SendDataATM(Browser, InpBuscaRapida, Texto);
        }

        public void ValidarResultadoDaBuscaRapidaObra(string Texto)
        {
            var textoObra = Element.Xpath("//*[@ng-show='ResultsObra.length > 0']//a[contains (., '" + Texto + "')]");
            Thread.Sleep(3000);
            try
            {
                ElementExtensions.IsElementVisible(textoObra, Browser);
            }
            catch
            {
                ElementExtensions.IsElementVisible(textoObra, Browser);
            }
        }

        public void ValidarNenhumResultadoEncontrado(string Mensagem)
        {
            var textoObra = Element.Xpath("//*[@ng-show='ResultsObra.length == 0 && ResultsProduto.length == 0'][contains (., '" + Mensagem + "')]");
            Thread.Sleep(3000);
            try
            {
                ElementExtensions.IsElementVisible(textoObra, Browser);
            }
            catch
            {
                ElementExtensions.IsElementVisible(textoObra, Browser);
            }
        }

        public void ValidarResultadoDaBuscaRapidaProduto(string Texto)
        {
            var textoProduto = Element.Xpath("//*[@ng-show='ResultsProduto.length > 0']//a[contains (., '" + Texto + "')]");
            Thread.Sleep(3000);
            ElementExtensions.IsElementVisible(textoProduto, Browser);
        }

        public void AcessarObra(string Texto)
        {
            Thread.Sleep(4000);
            var textoObra = Element.Xpath("//*[@ng-show='ResultsObra.length > 0']//a[contains (., '" + Texto + "')]");
            try
            {
                ElementExtensions.IsElementVisible(textoObra, Browser);
                MouseActions.ClickATM(Browser, textoObra);
            }
            catch
            {
                ElementExtensions.IsElementVisible(textoObra, Browser);
                MouseActions.ClickATM(Browser, textoObra);
            }
        }

        public void AcessarProduto(string Texto)
        {
            Thread.Sleep(4000);
            var textoProduto = Element.Xpath("//*[@ng-show='ResultsProduto.length > 0']//a[contains (., '" + Texto + "')]");
            try
            {
                ElementExtensions.IsElementVisible(textoProduto, Browser);
                MouseActions.ClickATM(Browser, textoProduto);
            }
            catch
            {
                ElementExtensions.IsElementVisible(textoProduto, Browser);
                MouseActions.ClickATM(Browser, textoProduto);
            }
        }

        public void ValidarDetalheDaObraProduto(string Obra)
        {
            Thread.Sleep(2000);
            var nomeTexto = Element.Xpath("//h3[text()='" + Obra + "']");
            try
            {
                Thread.Sleep(3000);
                ElementExtensions.IsElementVisible(nomeTexto, Browser);
            }
            catch
            {
                Thread.Sleep(3000);
                ElementExtensions.IsElementVisible(nomeTexto, Browser);
            }
        }
    }
}
