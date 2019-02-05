using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Threading;
using SOM.BDD.Pages.Produto;

namespace SOM.BDD.Pages.Ferramenta.Midia
{
    public class CadastrarMidiaPage : PageBase
    {
        private string CadastrarMidiaUrl { get; }

        public CadastrarMidiaPage TelaCadastrarMidiaPage { get; private set; }

        // Cadastrar Mídia
        public Element CampoNomeMidia { get; private set; }
        public Element BtSalvar { get; private set; }
        public Element BtAtivar { get; private set; }
        public Element BtCancelar { get; private set; }

        public CadastrarMidiaPage(IBrowser browser, string cadastrarMidiaUrl) : base(browser)
        {
            CadastrarMidiaUrl = cadastrarMidiaUrl;

            // Cadastrar Mídia
            CampoNomeMidia = Element.Css("div[class='col-md-4'] input[ng-model='MidiaDados.Nome']");
            BtSalvar = Element.Css("a[uib-tooltip='Salvar']");
            BtAtivar = Element.Css("input[ng-model='MidiaDados.MidiaAtivar']");
            BtCancelar = Element.Css("a[uib-tooltip='Cancelar']");

        }

        public override void Navegar()
        {
            Browser.Abrir(CadastrarMidiaUrl);
        }

        public void CadastrarMidia(string Midia)
        {
            Thread.Sleep(1500);
            AutomatedActions.SendData(Browser, CampoNomeMidia, Midia);
            MouseActions.ClickATM(Browser, BtSalvar);
        }

        public void MensagemMidia(string Mensagem)
        {
            Thread.Sleep(1500);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css("p[style='display: block;']"), "textContent", Browser));
        }

        public void CadastrarMidiaAtivo(string Midia)
        {
            Thread.Sleep(1500);
            AutomatedActions.SendData(Browser, CampoNomeMidia, Midia);
        }

        public void CadastrarMidiaAtiva()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtCancelar);
        }
    }
}
