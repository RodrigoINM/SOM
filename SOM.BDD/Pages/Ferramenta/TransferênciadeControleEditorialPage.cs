using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Threading;
using SOM.BDD.Pages.Ferramenta;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Ferramenta
{
    public class TransferênciadeControleEditorialPage : PageBase
    {

        private string TransferenciaControleEditorialUrl { get; }

        public TransferênciadeControleEditorialPage TelaTransferênciadeControleEditorialPage { get; private set; }
        public Element NomeAutorDe { get; private set; }
        public Element NomeAutorPara { get; private set; }
        public Element NomeDDADe { get; private set; }
        public Element NomeDDAPara { get; private set; }
        public Element btnSalvar { get; private set; }
        public Element BtnConfirmarTransferencia { get; private set; }
        public Element ElementeMensagem { get; private set; }

        public TransferênciadeControleEditorialPage(IBrowser browser, string transferenciaControleEditorialUrl) : base(browser)
        {
            TransferenciaControleEditorialUrl = transferenciaControleEditorialUrl;

            NomeAutorDe = Element.Css("input[ng-model='Form.NomeAutorDe']");
            NomeAutorPara = Element.Css("input[ng-model='Form.NomeAutorPara']");
            NomeDDADe = Element.Css("input[ng-model='Form.NomeDDADe']");
            NomeDDAPara = Element.Css("input[ng-model='Form.NomeDDAPara']");
            btnSalvar = Element.Css("a[ng-click='Salvar()']");
            BtnConfirmarTransferencia = Element.Xpath("//h2[text()='De/Para de Controle Editorial']/..//button[@class='confirm']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
        }


        public override void Navegar()
        {
            Browser.Abrir(TransferenciaControleEditorialUrl);
        }

        public void TransferenciaCE(string AutorDe, string AutorPara, string DDDADe, string DDAPara)
        {
            Thread.Sleep(1500);
            if (AutorDe != "" && AutorDe != " ")
                AutomatedActions.SendDataATM(Browser, NomeAutorDe, AutorDe);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, NomeAutorDe);
            Thread.Sleep(2000);
            if (AutorPara != "" && AutorPara != " ")
                AutomatedActions.SendDataATM(Browser, NomeAutorPara, AutorPara);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, NomeAutorPara);
            Thread.Sleep(2000);
            if (DDDADe != "" && DDDADe != " ")
                AutomatedActions.SendDataATM(Browser, NomeDDADe, DDDADe);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, NomeDDADe);
            Thread.Sleep(2000);
            if (DDAPara != "" && DDAPara != " ")
                AutomatedActions.SendDataATM(Browser, NomeDDAPara, DDAPara);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, NomeDDAPara);
        }

        public void ValidarCamposTransferenciaCE()
        {
            Thread.Sleep(1500);
            var NomeAutorDe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorDe']");
            var NomeAutorPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorPara']");
            var NomeDDADe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeDDADe']");
            var NomeDDAPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeDDAPara']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorDe, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorPara, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeDDADe, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeDDAPara, Browser));
        }

        public void ValidarCampoAutor()
        {
            Thread.Sleep(1500);
            var NomeAutorDe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorDe']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorDe, Browser));
        }

        public void SalvarTransferencia()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, btnSalvar);
        }

        public void ConfirmarTranferencia()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnConfirmarTransferencia);
        }

        public void ValidarPopup(string Mensagem)
        {
            try
            {
                Thread.Sleep(3000);
                ElementExtensions.IsElementVisible(ElementeMensagem,Browser);
                Assert.AreEqual(Mensagem, ElementExtensions.GetTexto(ElementeMensagem, Browser));
            }
            catch
            {
                Thread.Sleep(3000);
                ElementExtensions.IsElementVisible(ElementeMensagem, Browser);
                Assert.AreEqual(Mensagem, ElementExtensions.GetTexto(ElementeMensagem, Browser));
            }
        }

        public void MensagemAutorDeValidação(string Mensagem)
        {
            Thread.Sleep(1500);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css("p[style='display: block;']"), "textContent", Browser));
        }
    }
}

