using Framework.Core.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using Framework.Core.Interfaces;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.FrameworkActions;

namespace SOM.BDD.Pages.Obra.Autor
{
    public class AlterarAutorPage : PageBase
    {
        private string ConsultaDeAutorUrl { get; }

        private string PageTitle => "SOM | Autor";

        private Element CampoAutor { get; set; }
        private Element BuscarAutor { get; set; }
        private Element SelecionarAutor { get; set; }
        private Element BtSalvar { get; set; }
        private Element ElementeMensagem { get; set; }
        private Element BtnConfirmarExclusao { get; set; }
        private Element BotaoConfirmarAtivacao { get; set; }

        public AlterarAutorPage(IBrowser browser, string consultaDeAutorUrl) : base(browser)
        {
            ConsultaDeAutorUrl = consultaDeAutorUrl;
            CampoAutor = Element.Css("div[ng-controller='AutorController'] input[type='text']");
            BuscarAutor = Element.Xpath("(.//*[normalize-space(text()) and normalize-space(.)='Buscar mais produtos com:'])[1]/following::i[1]");
            SelecionarAutor = Element.Xpath("(.//*[normalize-space(text()) and normalize-space(.)='Contratado'])[1]/following::div[1]");
            BtSalvar = Element.Css("a[ng-click='salvarAutor(true, true)']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
            BtnConfirmarExclusao = Element.Xpath("//h2[text()='Deseja excluir?']/..//button[@class='confirm']");
            BotaoConfirmarAtivacao = Element.Xpath("//h2[text()='Deseja ativar?']/..//button[@class='confirm']");
    }

        public override void Navegar()
        {
            Browser.Abrir(ConsultaDeAutorUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        //internal void NavegarTelaAlterarAutor()
        //{
        //    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["TelaAutor"]);
        //}

        public void ConsultaSimplesDoAutor(string NomeDeAlterarAutor)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ElementExtensions.IsElementVisible(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
            //Assert.IsTrue(Driver.FindElement(By.CssSelector("a[ng-click='ShowHideFiltro()']")).Displayed);
            AutomatedActions.SendDataATM(Browser, CampoAutor, NomeDeAlterarAutor);
            //CampoAutor.Clear();
            //CampoAutor.SendKeys(NomeDeAlterarAutor);
            MouseActions.ClickATM(Browser, BuscarAutor);
            //BuscarAutor.Click();

            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            string nomeDoAutorAlterar = "//table[@dt-columns='dtColumns']//div[text()='" + NomeDeAlterarAutor + "']";
            //Assert.AreEqual(NomeDeAlterarAutor, Driver.FindElement(By.XPath(nomeDoAutorAlterar)).GetAttribute("textContent"));
            Assert.AreEqual(NomeDeAlterarAutor, ElementExtensions.GetValorAtributo(Element.Xpath(nomeDoAutorAlterar), "textContent", Browser));


        }
        internal void DuploClick(string NomeDeAlterarAutor)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            string nomeDoAutorAlterar = "//table[@dt-columns='dtColumns']//div[text()='" + NomeDeAlterarAutor + "']";

            MouseActions.DoubleClickATM(Browser, Element.Xpath(nomeDoAutorAlterar));
            //Acoes.CliqueDuplo(By.XPath(nomeDoAutorAlterar));
            //IWebElement element = Driver.FindElement(By.XPath(nomeDoAutorAlterar));
            //Actions actionsBuilder = new Actions(Driver);
            //actionsBuilder.DoubleClick(Driver.FindElement(By.XPath(nomeDoAutorAlterar))).Build().Perform();
        }

        internal void ValidarAltAutor(string Mensagem)
        {
            MouseActions.ClickATM(Browser, BtSalvar);
            //BtSalvar.Click();
            //Thread.Sleep(2000);
            //BotaoConfirmarAtivacao.Click();

            //Assert.AreEqual(Mensagem, ElementeMensagem.GetAttribute("textContent"));
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser));
            Thread.Sleep(2000);
            //BotaoConfirmarAtivacao.Click();
        }

        internal void ValidarMensagemdeAutor(string MensagemaltAutor)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            //string ValidarMsg = ElementeMensagem.GetAttribute("textContent");
            string ValidarMsg = ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser);
            Assert.AreEqual(MensagemaltAutor, ValidarMsg);

            Thread.Sleep(5000);
        }

        public void ConsultarAutorAlterado(string NomeArtistico)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ElementExtensions.IsElementVisible(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
            //Assert.IsTrue(Driver.FindElement(By.CssSelector("a[ng-click='ShowHideFiltro()']")).Displayed);
            AutomatedActions.SendDataATM(Browser, CampoAutor, NomeArtistico);
            //CampoAutor.Clear();
            //Thread.Sleep(1500);
            //CampoAutor.SendKeys(NomeArtistico);
            MouseActions.ClickATM(Browser, BuscarAutor);
            //BuscarAutor.Click();

            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            string nomedoAutor = "//table[@id='DataTables_Table_0']//div[text()='" + NomeArtistico + "']";
            //Assert.AreEqual(NomeArtistico, Driver.FindElement(By.XPath(nomedoAutor)).GetAttribute("textContent"));
            Assert.AreEqual(NomeArtistico, ElementExtensions.GetValorAtributo(Element.Xpath(nomedoAutor), "textContent", Browser));

        }
        public void ExcluirCadastroAutor(string NomeDeAlterarAutor)
        {
            Thread.Sleep(1500);
            string nomeAutorExcluir = "//table[@id='DataTables_Table_0']//div[text()='" + NomeDeAlterarAutor + "']/../..//a[@uib-tooltip='Excluir']";
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, Element.Xpath(nomeAutorExcluir));
            //Driver.FindElement(By.XPath(nomeAutorExcluir)).Click();
            Thread.Sleep(1500);

            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            //BtnConfirmarExclusao.Click();

            Thread.Sleep(1500);
        }

    }
}
