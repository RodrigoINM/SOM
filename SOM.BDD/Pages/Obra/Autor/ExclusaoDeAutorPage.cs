using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;

namespace SOM.BDD.Pages.Obra.Autor
{
    public class ExclusaoDeAutorPage : PageBase
    {
        private string ConsultaDeAutorUrl { get; }

        private string PageTitle => "SOM | Autor";

        private Element BtnConfirmarExclusao { get; set; }

        public ExclusaoDeAutorPage(IBrowser browser, string consultaDeAutorUrl) : base(browser)
        {
            ConsultaDeAutorUrl = consultaDeAutorUrl;
            BtnConfirmarExclusao = Element.Xpath("//h2[text()='Deseja excluir?']/..//button[@class='confirm']");
        }

        public override void Navegar()
        {
            Browser.Abrir(ConsultaDeAutorUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle), $"A pagina de consulta de Autor não estava visivel. Expected=>{PageTitle}." +
                $"Actual=>{Browser.PageSource(PageTitle)}");
        }

        public void ExcluirAutor(string NomeArtistico)
        {
            string nomeAutorExcluir = "//table[@id='DataTables_Table_0']//div[text()='" + NomeArtistico + "']/../..//a[@uib-tooltip='Excluir']";
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, Element.Xpath(nomeAutorExcluir));
            Thread.Sleep(1500);

            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
        }

        public void ValidarExclusaoDoAutor(string NomeArtistico)
        {
            //string nomeFantasia = "//table[@id='DataTables_Table_0']//div[text()='" + NomeArtistico + "']";
            //ElementExtensions.IsNotElementVisible(Element.Xpath(nomeFantasia), Browser);
            //Actions.EsperarElementoNaoVisivel(By.XPath(nomeFantasia));
            string caminhoElemento = "//table[@dt-columns='dtColumns']//*[text()='" + NomeArtistico + "']";
            try
            {
                ElementExtensions.IsElementVisible(Element.Xpath("//table[@dt-columns='dtColumns']//*[text()='Dados não encontratos']"), Browser);
            }
            catch
            {
                ElementExtensions.IsElementVisible(Element.Xpath(caminhoElemento), Browser);
            }
        }

        public void ValidarPopUpExclusaoAutorSucesso(string MensagemDeExcluir)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //string popUpSucesso = Driver.FindElement(By.CssSelector("div[id='toast-container'] div[class='ng-binding ng-scope']")).GetAttribute("textContent");
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            //Assert.AreEqual(MensagemDeExcluir, Actions.GetValorAtributo(By.CssSelector(popUpSucesso), "textContent"));
            Assert.AreEqual(MensagemDeExcluir, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));
        }
    }
}
