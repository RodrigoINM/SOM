using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System.Threading;
using System;

namespace SOM.BDD.Pages.UsoEReporte.Painel_de_Exibição
{
    public class PaineldeExibiçãoPage : PageBase
    {

        public PaineldeExibiçãoPage(IBrowser browser, string painelExibicaoUrl) : base(browser)
        {
            PainelExibicaoUrl = painelExibicaoUrl;

            //          CAMPO DE GENERO          
            DramaturgiaSemanal = Element.Xpath("//span[text()='DRAMATURGIA SEMANAL']/..//../a");
            DramaturgiaDiaria = Element.Xpath("//span[text()='DRAMATURGIA DIÁRIA']/..//../a");
            Esporte = Element.Xpath("//span[text()='ESPORTE']/..//../a");
            Jornalismo = Element.Xpath("//span[text()='JORNALISMO']/..//../a");
            VariedadeDiaria = Element.Xpath("//span[text()='VARIEDADE DIÁRIA']/..//../a");
            VariedadeSemanal = Element.Xpath("//span[text()='VARIEDADE SEMANAL']/..//../a");

            inpperiodo = Element.Css("input[ng-model='PainelExibicaoFiltros.periodoPainelExibicao']");
            btnPesquisar = Element.Css("button[ng-disabled='Pesquisa']");



        }

        public PaineldeExibiçãoPage TelaPaineldeExibiçãoPage { get; private set; }
        public string PainelExibicaoUrl { get; private set; }
        public Element DramaturgiaSemanal { get; private set; }
        public Element DramaturgiaDiaria { get; private set; }
        public Element Esporte { get; private set; }
        public Element Jornalismo { get; private set; }
        public Element VariedadeDiaria { get; private set; }
        public Element VariedadeSemanal { get; private set; }
        public Element inpperiodo { get; private set; }
        public Element btnPesquisar { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(PainelExibicaoUrl);
        }

        public void ExcluirGeneroMusical()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, DramaturgiaSemanal);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, DramaturgiaDiaria);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, Esporte);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, Jornalismo);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, VariedadeDiaria);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, VariedadeSemanal);
        }

        public void SalvarPesquisa()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, btnPesquisar);
        }

        public void ValidarCampoGenero()
        {
            Thread.Sleep(1500);
            var Campogenero = Element.Css("div[class='has-error'] ul[class='select2-choices']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Campogenero, Browser));
        }

        public void ExcluirMidia()
        {
            Thread.Sleep(1500);
            var MidiaTv = Element.Xpath("//span[text()='TV']/..//../a");
            MouseActions.ClickATM(Browser, MidiaTv);
        }

        public void ValidarCampoMidia()
        {
            Thread.Sleep(1500);
            var CampoMidia = Element.Css("div[ng-class='classMidias'] ul[class='select2-choices']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(CampoMidia, Browser));
        }

        public void ValidarResultadoTV()
        {
            Thread.Sleep(2000);
            var ResultadoTv = Element.Xpath("//h5[text()='TV']/../div");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoTv, Browser));
        }

        public void ValidarResultadoViva()
        {
            Thread.Sleep(2000);
            var ResultadoViva = Element.Xpath("//h5[text()='CANAL VIVA']/../div");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoViva, Browser));
        }

        public void ValidarResultaGloboPlay()
        {
            Thread.Sleep(2000);
            var ResultadoGloboPlay = Element.Xpath("//h5[text()='GLOBOPLAY']/../div");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoGloboPlay, Browser));
        }

        public void ValidarResultainternet()
        {
            Thread.Sleep(2000);
            var ResultadoGloboPlay = Element.Xpath("//h5[text()='INTERNET']/../div");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoGloboPlay, Browser));
        }

        public void ValidarResultadoMultishow()
        {
            Thread.Sleep(2000);
            var ResultadoMULTSHOW = Element.Xpath("//h5[text()='MULTSHOW']/../div");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoMULTSHOW, Browser));
        }

        public void ValidarResultadoSpot()
        {
            Thread.Sleep(2000);
            var ResultadoSport = Element.Xpath("//li[@ng-repeat='itemGenero in itemMidia.TabelaExibicaoViewGenero']//a[contains(., 'ESPORTE')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoSport, Browser));
        }

        public void ValidarResultadoDramatugiaDiaria()
        {
            Thread.Sleep(2000);
            var ResultadoDramatugiaDiaria = Element.Xpath("//li[@ng-repeat='itemGenero in itemMidia.TabelaExibicaoViewGenero']//a[contains(., 'DRAMATURGIA')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoDramatugiaDiaria, Browser));
        }

        public void SelecionarPeriodo(string periodo, string ano)
        {
            Thread.Sleep(2000);
            //MouseActions.ClickATM(Browser, inpperiodo);
            //Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, inpperiodo, periodo);
            //Thread.Sleep(2000);
            //MouseActions.ClickATM(Browser, inpperiodo);
            KeyboardActions.Tab(Browser, inpperiodo);
            //Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, inpperiodo, ano);

        }

        public void PeriodoemBranco()
        {
            Thread.Sleep(2000);
            KeyboardActions.Backspace(Browser, inpperiodo);
            KeyboardActions.Tab(Browser, inpperiodo);
            KeyboardActions.Backspace(Browser, inpperiodo);
        }
        
        public void PeriodoEmdestaque()
        {
            Thread.Sleep(1500);
            var periododestaque = Element.Css("div[class='has-error'] label");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(periododestaque, Browser));
        }

        public void SelecionarMidia(string Midia)
        {
            Thread.Sleep(1500);
            var CampMidia = Element.Css("div[ng-model='PainelExibicaoFiltros.MidiasS'] input");
            MouseActions.ClickATM(Browser, CampMidia);
            Thread.Sleep(1500);
            var SlMidia = Element.Xpath("//ul[@repeat='item in listaMidias']//div[text()='" + Midia + "']");
            MouseActions.ClickATM(Browser, SlMidia);
        }

        public void SelecionarGenero(string genero)
        {
            Thread.Sleep(1500);
            var CampoGenero = Element.Css("div[ng-model='PainelExibicaoFiltros.GeneroDireitoMusicaisS'] input");
            MouseActions.ClickATM(Browser, CampoGenero);
            Thread.Sleep(1500);
            var SlGenero = Element.Xpath("//ul[@repeat='item in listaGeneroDireitoMusicais']//div[text()='" + genero + "']");
            MouseActions.ClickATM(Browser, SlGenero);
        }

        public void ValidarResultadoJornalismo()
        {
            Thread.Sleep(2000);
            var ResultadoDramatugiaDiaria = Element.Xpath("//li[@ng-repeat='itemGenero in itemMidia.TabelaExibicaoViewGenero']//a[contains(., 'JORNALISMO')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoDramatugiaDiaria, Browser));
        }

        public void ValidarResultadoVariedadeDiaria()
        {
            Thread.Sleep(2000);
            var ResultadoDramatugiaDiaria = Element.Xpath("//li[@ng-repeat='itemGenero in itemMidia.TabelaExibicaoViewGenero']//a[contains(., 'VARIEDADE DIÁRIA')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoDramatugiaDiaria, Browser));
        }

        public void ValidarResultadoVariedadesemanal()
        {
            Thread.Sleep(2000);
            var ResultadoDramatugiaDiaria = Element.Xpath("//li[@ng-repeat='itemGenero in itemMidia.TabelaExibicaoViewGenero']//a[contains(., 'VARIEDADE SEMANAL')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(ResultadoDramatugiaDiaria, Browser));
        }

        public void ValidarAzul()
        {
            Thread.Sleep(2000);
            var Azul = Element.Css("div[class='panel-body ng-scope'] td[class='painelExibicaoItem AzulPainelExibicaoItem']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Azul, Browser));
        }

        public void ValidarAmarelo()
        {
            Thread.Sleep(2000);
            var Amarelo = Element.Css("div[class='panel-body ng-scope'] td[class='painelExibicaoItem AmareloPainelExibicaoItem']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Amarelo, Browser));
        }

        public void ValidarVerde()
        {
            Thread.Sleep(2000);
            var Verde = Element.Css("div[class='panel-body ng-scope'] td[class='painelExibicaoItem VerdePainelExibicaoItem']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Verde, Browser));
        }

        public void ValidarCinza()
        {
            Thread.Sleep(2000);
            var Cinza = Element.Css("div[class='panel-body ng-scope'] td[class='painelExibicaoItem CinzaPainelExibicaoItem']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Cinza, Browser));
        }

        public void ValidarVermelho()
        {
            Thread.Sleep(2000);
            var Vermelho = Element.Css("div[class='panel-body ng-scope'] td[class='painelExibicaoItem VermelhoPainelExibicaoItem']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Vermelho, Browser));
        }

        public void ValidarLaranja()
        {
            Thread.Sleep(2000);
            var Laranja = Element.Css("div[class='panel-body ng-scope'] td[class='painelExibicaoItem LaranjaPainelExibicaoItem']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(Laranja, Browser));
        }
    }
}
