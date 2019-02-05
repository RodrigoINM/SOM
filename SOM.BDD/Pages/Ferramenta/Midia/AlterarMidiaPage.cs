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
    public class AlterarMidiaPage : PageBase
    {

        private string AlterarMidiaUrl { get; }

        public AlterarMidiaPage TelaCadastrarMidiaPage { get; private set; }

        private string PageTitle => "SOM | Cadastro de Obra";

        // Alteração Mídia
        public Element BtnFiltroMidia { get; private set; }
        public Element SelectInativo { get; private set; }
        public Element InpMidia { get; private set; }
        public Element btnPesquisarMidia { get; private set; }
        public Element inpNomeMidia { get; private set; }
        public Element BtnSalvarMidia { get; private set; }
        public Element BtnBuscarMidia { get; private set; }
        public Element CampoAr { get; private set; }

        public AlterarMidiaPage(IBrowser browser, string alterarMidiaUrl) : base(browser)
        {
            AlterarMidiaUrl = alterarMidiaUrl;

            // Alteração Mídia
            BtnFiltroMidia = Element.Css("a[ng-click='ShowHideFiltro()']");
            SelectInativo = Element.Css("select[ng-model='MidiaFiltros.listaAtivaS.selected']");
            InpMidia = Element.Css("input[placeholder='Buscar Mídia']");
            btnPesquisarMidia = Element.Css("button[uib-tooltip='Pesquisar']");
            inpNomeMidia = Element.Css("input[id='nome']");
            BtnSalvarMidia = Element.Css("a[uib-tooltip='Salvar']");
            BtnBuscarMidia = Element.Css("a[ng-disabled='Pesquisa']");
            CampoAr = Element.Css("input[ng-model='MidiaFiltros.AR']");
        }

        public override void Navegar()
        {
            Browser.Abrir(AlterarMidiaUrl);
        }

        public void BuscaInativo(string NomeMidia)
        {
            MouseActions.ClickATM(Browser, BtnFiltroMidia);
            MouseActions.ClickATM(Browser, SelectInativo);
            Thread.Sleep(2000);
            MouseActions.SelectElementATM(Browser, SelectInativo, "Inativo");
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, InpMidia, NomeMidia);
            MouseActions.ClickATM(Browser, btnPesquisarMidia);
            Thread.Sleep(2000);
            SelecionarMidia(NomeMidia);
        }
        public void BuscaSimples()
        {
            MouseActions.ClickATM(Browser, BtnBuscarMidia);
        }

        public void BuscaAtiva()
        {
            MouseActions.ClickATM(Browser, BtnFiltroMidia);
            Thread.Sleep(2000);
            MouseActions.SelectElementATM(Browser, SelectInativo, "Ativo");
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, btnPesquisarMidia);
        }

        public void BuscarFiltroAr(string FiltroAr)
        {
            MouseActions.ClickATM(Browser, BtnFiltroMidia);
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, CampoAr, FiltroAr);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, btnPesquisarMidia);
        }

        public void SelecionarMidia(string NomeMidia)
        {
            var nomeMidia = Element.Xpath("//tbody//div[contains (., '" + NomeMidia + "')]");
            MouseActions.DoubleClickATM(Browser, nomeMidia);
        }

        public void AlterarNomeMidia(string NomeMidia)
        {
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, inpNomeMidia, NomeMidia);
        }

        public void SalvarAlteracaoMidia()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarMidia);
        }

        public void ValidarCampoNomeMidia()
        {
            Thread.Sleep(1500);
            var ValidarNomeMidia = Element.Css("div[class='has-error'] input[ng-model='MidiaDados.Nome']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(ValidarNomeMidia, Browser));
        }

        public void ValidarCamposPesquisarMidia()
        {
            Thread.Sleep(1500);
            ElementExtensions.IsElementVisible(Element.Css("th[class='sorting_asc']"), Browser);
            Thread.Sleep(1500);
            ElementExtensions.IsElementVisible(Element.Css("th[aria-label='AR: activate to sort column ascending']"), Browser);
            Thread.Sleep(1500);
            ElementExtensions.IsElementVisible(Element.Css("th[aria-label='Ativa: activate to sort column ascending']"), Browser);
        }

        public void ValidarDadosNaoEncontrados(string Mensagem)
        {
            var mensagem = Element.Css("td[class='dataTables_empty']");

            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(mensagem, "textContent", Browser));
        }

        public void BuscarMidia(string NomeMidia)
        {
            AutomatedActions.SendDataATM(Browser, InpMidia, NomeMidia);
            MouseActions.ClickATM(Browser, BtnBuscarMidia);
        }
    }
}
