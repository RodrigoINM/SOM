using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;

namespace SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet
{
    public class ConsultarCueSheetPage : PageBase
    {
        private string ConsultaDeCueSheetUrl { get; }

        private string PageTitle => "SOM | Cue-Sheet";

        public Element BtnFiltros { get; private set; }
        public Element InpProduto { get; private set; }
        public Element SlctEpisodio { get; private set; }
        public Element SlctCapitulo { get; private set; }
        public Element InpDataInicial { get; private set; }
        public Element InpDataFinal { get; private set; }
        public Element SlctMidia { get; private set; }
        public Element SlctStatus { get; private set; }
        public Element SlctRepriseRebatida { get; private set; }
        public Element BtnPesquisar { get; private set; }

        //Filtro de obras e fonogramas
        public Element BtnBuscarObrasEFonogramas { get; private set; }
        public Element InpObraEFonograma { get; private set; }
        public Element BtnPesquisarObraEFonograma { get; private set; }

        public ConsultarCueSheetPage(IBrowser browser, string consultaDeCueSheetUrl) : base(browser)
        {
            ConsultaDeCueSheetUrl = consultaDeCueSheetUrl;

            BtnFiltros = Element.Css("a[ng-click='ShowHideFiltro()']");
            InpProduto = Element.Css("input[ng-model='CueSheetFiltros.DscProduto']");
            SlctEpisodio = Element.Css("div[ng-model='CueSheetFiltros.DscEpisodio'] i[class='caret pull-right']");
            SlctCapitulo = Element.Css("div[ng-model='CueSheetFiltros.Capitulo'] i[class='caret pull-right']");
            InpDataInicial = Element.Css("input[ng-model='CueSheetFiltros.DataExibicao']");
            InpDataFinal = Element.Css("input[ng-model='CueSheetFiltros.DataExibicaoFim']");
            SlctMidia = Element.Css("select[ng-model='CueSheetFiltros.Midia.selected']");
            SlctStatus = Element.Css("select[ng-model='CueSheetFiltros.StatusS.selected']");
            SlctRepriseRebatida = Element.Css("select[ng-model='CueSheetFiltros.RepriseRebatidaS.selected']");
            BtnPesquisar = Element.Css("button[ng-click='GetAllCueSheet(false)']");

            //Filtro de obras e fonogramas
            BtnBuscarObrasEFonogramas = Element.Css("button[ng-click='OpenObraFonogramaModal()']");
            InpObraEFonograma = Element.Css("input[ng-model='ObraFonogramaNome']");
            BtnPesquisarObraEFonograma = Element.Css("a[ng-click='carregarObrasFonogramasSelecionados()']");
        }

        public override void Navegar()
        {
            Browser.Abrir(ConsultaDeCueSheetUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        private void SelecionarProduto(string Valor)
        {
            if (Valor != "")
            {
                AutomatedActions.SendDataATM(Browser, InpProduto, Valor);
                var selecionarProduto = Element.Css("a[title='" + Valor + "']");
                MouseActions.ClickATM(Browser, selecionarProduto);
            }
        }

        private void SelecionarEpisodio(string Valor)
        {
            if (Valor != "")
            {
                MouseActions.ClickATM(Browser, SlctEpisodio);
                var selecionarEpisodio = Element.Xpath("//a/div[text()='" + Valor + "']");
                MouseActions.ClickATM(Browser, selecionarEpisodio);
            }
        }

        private void SelecionarCapitulo(string Valor)
        {
            if (Valor != "")
            {
                MouseActions.ClickATM(Browser, SlctCapitulo);
                var selecionarCapitulo = Element.Xpath("//a/div[text()='" + Valor + "']");
                MouseActions.ClickATM(Browser, selecionarCapitulo);
            }
        }

        private void SelecionarMidia(string Valor)
        {
            if (Valor != "")
            {
                MouseActions.SelectElementATM(Browser, SlctMidia, Valor);
                //switch (Valor)
                //{
                //    case "GLOBONEWS":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctMidia, "3");
                //            break;
                //        }
                //    case "GLOBOPLAY":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctMidia, "7");
                //            break;
                //        }
                //    case "SPORTV":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctMidia, "8");
                //            break;
                //        }
                //    case "TV":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctMidia, "1");
                //            break;
                //        }
                //}
            }
        }

        private void SelecionarStatus(string Status)
        {
            if(Status != "" && Status != " ")
                MouseActions.SelectElementATM(Browser, SlctStatus, Status);
        }

        private void SelecionarRepriseRebatida(string Valor)
        {
            if (Valor != "")
            {
                MouseActions.SelectElementATM(Browser, SlctRepriseRebatida, Valor);
                //switch (Valor)
                //{
                //    case "Não":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctRepriseRebatida, "0");
                //            break;
                //        }
                //    case "Reprise":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctRepriseRebatida, "1");
                //            break;
                //        }
                //    case "Rebatida":
                //        {
                //            MouseActions.SelectElementATMByValue(Browser, SlctRepriseRebatida, "2");
                //            break;
                //        }
                //}
            }
        }

        private void AbrirFiltrosAvancadosDeCueSheet()
        {
            try
            {
                var filtrosVisiveis = Element.Css("div[class='ibox-content animated fadeIn ng-hide']");
                ElementExtensions.IsElementVisible(filtrosVisiveis, Browser);
                MouseActions.ClickATM(Browser, BtnFiltros);
                //MouseActions.ClickATM(Browser, InpDataFinal);
            }
            catch
            {
                //MouseActions.ClickATM(Browser, BtnFiltros);
            }

        }

        public void ConsultaAvacadaDeCueSheet(string Produto, string Episodio, string Capitulo, string Midia, string DataInicial, string DataFinal,
            string Status, string RepriseRebatida)
        {
            AbrirFiltrosAvancadosDeCueSheet();
            SelecionarProduto(Produto);
            SelecionarEpisodio(Episodio);
            SelecionarCapitulo(Capitulo);
            SelecionarMidia(Midia);
            if(DataInicial != "")
            {
                AutomatedActions.SendData(Browser, InpDataInicial, DataInicial);
                KeyboardActions.Tab(Browser, InpDataInicial);
            }
            if(DataFinal != "")
            {
                AutomatedActions.SendData(Browser, InpDataFinal, DataFinal);
                KeyboardActions.Tab(Browser, InpDataFinal);
            }
            SelecionarStatus(Status);
            SelecionarRepriseRebatida(RepriseRebatida);
            MouseActions.ClickATM(Browser, BtnPesquisar);

            //SelecionarCueSheet(Produto);
        }

        public void SelecionarCueSheet(string Valor)
        {
            Thread.Sleep(2000);
            var selecionarCueSheet = Element.Xpath("//td/div[text()='" + Valor + "']");
            MouseActions.DoubleClickATM(Browser, selecionarCueSheet);
        }

        public void ConsultaDeEpisodioSemProduto(string Episodio)
        {
            AbrirFiltrosAvancadosDeCueSheet();

            MouseActions.ClickATM(Browser, SlctEpisodio);
            var inpEpisodio = Element.Css("div[ng-model='CueSheetFiltros.DscEpisodio'] input");
            AutomatedActions.SendData(Browser, inpEpisodio, Episodio);

            AutomatedActions.SendData(Browser, InpDataInicial, "11/11/2019");
            KeyboardActions.Tab(Browser, InpDataInicial);
            AutomatedActions.SendData(Browser, InpDataFinal, "11/11/2019");
            KeyboardActions.Tab(Browser, InpDataFinal);
           
            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        public void ConsultaDeCueSheetPorObra(string Obra, string Fonograma)
        {
            AbrirFiltrosAvancadosDeCueSheet();
            SelecionarObraFonograma(Fonograma, Obra);

            ElementExtensions.IsElementVisible(BtnPesquisarObraEFonograma, Browser);
            MouseActions.ClickATM(Browser, BtnPesquisarObraEFonograma);

            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        private void SelecionarObraFonograma(string Fonograma, string TituloObra)
        {
            MouseActions.ClickATM(Browser, BtnBuscarObrasEFonogramas);

            var btnPesquisar = Element.Css("button[ng-click='PesquisarObraFonograma()']");

            if (Fonograma != "" && Fonograma != " ")
            {
                AutomatedActions.SendData(Browser, InpObraEFonograma, Fonograma);
                MouseActions.ClickATM(Browser, btnPesquisar);
                MouseActions.ClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarFonograma(item)']/td[text()='" + Fonograma + "']"));
            }
                
            if (TituloObra != "" && TituloObra != " ")
            {
                AutomatedActions.SendData(Browser, InpObraEFonograma, TituloObra);
                MouseActions.ClickATM(Browser, btnPesquisar);
                MouseActions.ClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarObra(item)']/td[text()='" + TituloObra + "']"));
            }
        }

        public void ValidarCampoEpisodioEmBranco()
        {
            Thread.Sleep(2000);
            AbrirFiltrosAvancadosDeCueSheet();

            var inpEpisodio = Element.Css("div[ng-model='CueSheetFiltros.DscEpisodio'] input");
            Assert.AreEqual("", ElementExtensions.GetValue(inpEpisodio, Browser));
        }

        public void ValidarCueSheet(string Valor)
        {
            if(Valor != "" && Valor != " ")
            {
                var textoCueSheet = Element.Xpath("//td/div[text()='" + Valor + "']");
                try
                {
                    ElementExtensions.IsElementVisible(textoCueSheet, Browser);
                }
                catch
                {
                    Thread.Sleep(2000);
                    ElementExtensions.IsElementVisible(textoCueSheet, Browser);
                }
            }
        }

        public void ValidarDadosNaoEncontrados(string Mensagem)
        {
            var dadosNaoEncontrados = Element.Xpath("//table[@id='tableCuesheet']//tbody//td[contains (., '" + Mensagem + "')]");
            try
            {
                Assert.IsTrue(ElementExtensions.IsElementVisible(dadosNaoEncontrados, Browser), "A " + Mensagem + " não foi encontrada!");
            }
            catch
            {
                ElementExtensions.EsperarElemento(dadosNaoEncontrados, Browser);
                Assert.IsTrue(ElementExtensions.IsElementVisible(dadosNaoEncontrados, Browser), "A " + Mensagem + " não foi encontrada!");
            }
        }
    }
}
