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
    public class TransferênciadeDDAPage : PageBase
    {
        public TransferênciadeDDAPage(IBrowser browser, string transferenciaDeDDAUrl) : base(browser)
        {
            TransferenciaDeDDAUrl = transferenciaDeDDAUrl;

            NomeDDADe = Element.Css("input[ng-model='Form.NomeDDADe']");
            NomeDDAPara = Element.Css("input[ng-model='Form.NomeDDAPara']");
            BtnSalvar = Element.Css("a[uib-tooltip='Salvar']");
            BtnConfirmarTranferencia = Element.Xpath("//h2[text()='De/Para DDA']/..//button[@class='confirm']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
            CheckBoxExcluirDDADe = Element.Css("label[for='FalecidoDominioPublicoId']");
        }

        public string TransferenciaDeDDAUrl { get; private set; }
        public TransferênciadeDDAPage TelaTransferênciadeDDAPage { get; private set; }
        public Element NomeDDADe { get; private set; }
        public Element NomeDDAPara { get; private set; }
        public Element BtnSalvar { get; private set; }
        public Element BtnConfirmarTranferencia { get; private set; }
        public Element ElementeMensagem { get; private set; }
        public Element CheckBoxExcluirDDADe { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(TransferenciaDeDDAUrl);
        }

        public void TranferenciaDDA(string De, string Para)
        {
            Thread.Sleep(1500);
            if (De != "" && De != " ")
                AutomatedActions.SendDataATM(Browser, NomeDDADe, De);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, NomeDDADe);
            Thread.Sleep(2000);
            if (Para != "" && Para != " ")
                AutomatedActions.SendDataATM(Browser, NomeDDAPara, Para);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, NomeDDAPara);
        }

        public void ConfirmarExclusãoDDADe()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, CheckBoxExcluirDDADe);
            Thread.Sleep(1500);
        }

        public void SalvarTransferencia()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvar);
        }

        public void ValidarCamposTransferenciaDDA()
        {
            Thread.Sleep(1500);
            var NomeDDADe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeDDADe']");
            var NomeDDAPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeDDAPara']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeDDADe, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeDDAPara, Browser));
        }

        public void ValidarCampoNomeDDADe()
        {
            Thread.Sleep(1500);
            var NomeDDADe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeDDADe']");
            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeDDADe, Browser));
        }

        public void ValidarCampoNomeDDAPara()
        {
            Thread.Sleep(1500);
            var NomeDDAPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeDDAPara']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeDDAPara, Browser));
        }

        public void ConfirmarTransferencia()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarTranferencia);
        }

        public void ValidarDadosAlterados(string MensagemDeAlteração)
        {
            Assert.AreEqual(MensagemDeAlteração, ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser));
            Thread.Sleep(2000);
        }

        public void ConfirmarDePara()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvar);
            Thread.Sleep(2000);
            var BtnConfirmar = Element.Xpath("//h2[text()='De/Para DDA']/..//button[@class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);
        }

        public void ValidarAlerta(string Mensagem)
        {
            var textAlerta = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textAlerta, "textContent", Browser));
        }
    }
}
