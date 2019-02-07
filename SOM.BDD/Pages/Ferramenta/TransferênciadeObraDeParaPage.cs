using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System.Threading;


namespace SOM.BDD.Pages.Ferramenta
{
    public class TransferênciadeObraDeParaPage : PageBase
    {
        private Element btnSalvar;

        public TransferênciadeObraDeParaPage(IBrowser browser, string transferenciaObraUrl) : base(browser)
        {
            TransferenciaObraUrl = transferenciaObraUrl;

            TituloObraDe = Element.Css("input[ng-model='Form.TituloObraDe']");
            TituloObraPara = Element.Css("input[ng-model='Form.TituloObraPara']");
            BtnConfirmar = Element.Xpath("//button[@class='confirm']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
            btnSalvar = Element.Css("a[ng-click='Salvar()']");
            CheckBoxExcluirDDADe = Element.Css("label[for='FalecidoDominioPublicoId']");
        }

        public Element BtnConfirmar { get; private set; }
        public TransferênciadeObraDeParaPage TelaTransferênciadeObraDeParaPage { get; private set; }
        public Element TituloObraDe { get; private set; }
        public Element TituloObraPara { get; private set; }
        public string TransferenciaObraUrl { get; private set; }
        public Element ElementeMensagem { get; private set; }
        public Element CheckBoxExcluirDDADe { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(TransferenciaObraUrl);
        }

        public void TransferenciaAutor(string ObraDe, string ObraPara)
        {
            Thread.Sleep(1500);
            if (ObraDe != "" && ObraDe != " ")
                AutomatedActions.SendDataATM(Browser, TituloObraDe, ObraDe);
            Thread.Sleep(6000);
            KeyboardActions.Tab(Browser, TituloObraDe);
            KeyboardActions.Tab(Browser, TituloObraDe);
            Thread.Sleep(2000);
            if (ObraPara != "" && ObraPara != " ")
                AutomatedActions.SendDataATM(Browser, TituloObraPara, ObraPara);
            Thread.Sleep(6000);
            KeyboardActions.Tab(Browser, TituloObraPara);
            KeyboardActions.Tab(Browser, TituloObraPara);
        }

        public void TransferenciaAutorVisivel(string ObraDe, string ObraPara)
        {
            Thread.Sleep(1500);
            if (ObraDe != "" && ObraDe != " ")
                AutomatedActions.SendDataATM(Browser, TituloObraDe, ObraDe);
            Thread.Sleep(7000);
            var CampoObraDe = Element.Xpath("//a/strong[text()= '" + ObraDe + "']");
            ElementExtensions.IsElementVisible(CampoObraDe, Browser);
            KeyboardActions.Tab(Browser, TituloObraDe);
            KeyboardActions.Tab(Browser, TituloObraDe);
            Thread.Sleep(2000);
            if (ObraPara != "" && ObraPara != " ")
                AutomatedActions.SendDataATM(Browser, TituloObraPara, ObraPara);
            Thread.Sleep(7000);
            var CampoObraPara = Element.Xpath("//a/strong[text()= '" + ObraPara + "']");
            ElementExtensions.IsElementVisible(CampoObraPara, Browser);
            KeyboardActions.Tab(Browser, TituloObraPara);
            KeyboardActions.Tab(Browser, TituloObraPara);
        }

        public void SalvarTransferencia()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, btnSalvar);
        }

        public void TransferenciaDePara()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnConfirmar);
        }

        public void ConfirmarTransferencia()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnConfirmar);
            Thread.Sleep(4000);
            MouseActions.ClickATM(Browser, BtnConfirmar);
        }

        public void ValidarDadosAlterados(string MensagemDeAlteração)
        {   
            Assert.AreEqual(MensagemDeAlteração, ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser));
            Thread.Sleep(2000);
        }

        public void ValidarCampos()
        {
            Thread.Sleep(1500);
            var TituloObraDe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.TituloObraDe']");
            var TituloObraPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.TituloObraPara']");


            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(TituloObraDe, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(TituloObraPara, Browser));

        }
        public void ValidarCampoObraDe()
        {
            Thread.Sleep(1500);
            var TituloObraDe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.TituloObraDe']");
            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(TituloObraDe, Browser));
        }

        public void ValidarCampoObraPara()
        {
            Thread.Sleep(1500);
            var TituloObraPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.TituloObraPara']");
            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(TituloObraPara, Browser));
        }

        public void ConfirmarExclusãoObraDe()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, CheckBoxExcluirDDADe);
            Thread.Sleep(1500);
        }

        public void ValidarAlerta(string Mensagem)
        {
            var textAlerta = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textAlerta, "textContent", Browser));
        }
    }
}