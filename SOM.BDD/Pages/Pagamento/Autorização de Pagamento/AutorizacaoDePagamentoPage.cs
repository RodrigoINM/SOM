using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.FrameworkActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using SOM.BDD.Helpers;
using System.IO;
using OpenQA.Selenium;
using System.Windows.Forms;

namespace SOM.BDD.Pages.Pagamento.Autorização_de_Pagamento
{
    public class AutorizacaoDePagamentoPage : PageBase
    {
        public string AutorizacaoDePagamentoUrl { get; }

        //Busca rápida
        public Element InpBuscaRapida { get; private set; }
        public Element BtnPesquisaRapida { get; private set; }

        //Busca avançada
        public Element BtnShowFiltro { get; private set; }
        public Element InpApInicial { get; private set; }
        public Element InpApFinal { get; private set; }
        public Element InpLoteInicial { get; private set; }
        public Element InpLoteFinal { get; private set; }
        public Element InpNumeroPedidoInicial { get; private set; }
        public Element InpNumeroPedidoFinal { get; private set; }
        public Element InpDDA { get; private set; }
        public Element InpAR { get; private set; }
        public Element InpDataInicialAp { get; private set; }
        public Element InpDataFinalAp { get; private set; }
        public Element BtnPesquisaAvancada { get; private set; }
        public Element BtnLimparCampos { get; private set; }

        public AutorizacaoDePagamentoPage(IBrowser browser, string autorizacaoDePagamentoUrl) : base(browser)
        {
            AutorizacaoDePagamentoUrl = autorizacaoDePagamentoUrl;

            //Busca rápida
            InpBuscaRapida = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroAPHeader']");
            BtnPesquisaRapida = Element.Css("a[ng-click='GetAllAutorizacaoPagamento()']");

            //Busca avançada
            BtnShowFiltro = Element.Css("a[ng-click='ShowHideFiltro()']");
            InpApInicial = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroAPInicial']");
            InpApFinal = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroAPFinal']");
            InpLoteInicial = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroLoteInicial']");
            InpLoteFinal = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroLoteFinal']");
            InpNumeroPedidoInicial = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroPedidoInicial']");
            InpNumeroPedidoFinal = Element.Css("input[ng-model='AutorizacaoFiltros.NumeroPedidoFinal']");
            InpDDA = Element.Css("input[ng-model='AutorizacaoFiltros.DDA']");
            InpAR = Element.Css("input[ng-model='AutorizacaoFiltros.ARProduto']");
            InpDataInicialAp = Element.Css("input[ng-model='AutorizacaoFiltros.DataGeracaoAPInicial']");
            InpDataFinalAp = Element.Css("input[ng-model='AutorizacaoFiltros.DataGeracaoAPFinal']");
            BtnPesquisaAvancada = Element.Css("button[ng-click='GetAllAutorizacaoPagamento()']");
            BtnLimparCampos = Element.Css("a[ng-click='LimparCampos()']");
        }

        public override void Navegar()
        {
            Browser.Abrir(AutorizacaoDePagamentoUrl);
        }

        public void BuscaRapidaDeAutorizacaoDePagamento(string NumeroDeAp)
        {
            ElementExtensions.IsElementVisible(InpBuscaRapida, Browser);
            AutomatedActions.SendDataATM(Browser, InpBuscaRapida, NumeroDeAp);

            MouseActions.ClickATM(Browser, BtnPesquisaRapida);
        }

        public void BuscaAvancadaDeAutorizacaoDePagamento(string ApInicial, string ApFinal, string LoteInicial, string LoteFinal,
            string NumeroPedidoInicial, string NumeroPedidoFinal, string DDA, string AR, string DataInicialAp, string DataFinalAp)
        {
            MouseActions.ClickATM(Browser, BtnShowFiltro);

            if (ApInicial != "" && ApInicial != " ")
                AutomatedActions.SendDataATM(Browser, InpApInicial, ApInicial);
            if (ApFinal != "" && ApFinal != " ")
                AutomatedActions.SendDataATM(Browser, InpApFinal, ApFinal);
            if (LoteInicial != "" && LoteInicial != " ")
                AutomatedActions.SendDataATM(Browser, InpLoteInicial, LoteInicial);
            if (LoteFinal != "" && LoteFinal != " ")
                AutomatedActions.SendDataATM(Browser, InpLoteFinal, LoteFinal);
            if (NumeroPedidoInicial != "" && NumeroPedidoInicial != " ")
                AutomatedActions.SendDataATM(Browser, InpNumeroPedidoInicial, NumeroPedidoInicial);
            if (NumeroPedidoFinal != "" && NumeroPedidoFinal != " ")
                AutomatedActions.SendDataATM(Browser, InpNumeroPedidoFinal, NumeroPedidoFinal);
            if (DDA != "" && DDA != " ")
                AutomatedActions.SendDataATM(Browser, InpDDA, DDA);
            if (AR != "" && AR != " ")
                AutomatedActions.SendDataATM(Browser, InpAR, AR);
            if (DataInicialAp != "" && DataInicialAp != " ")
                AutomatedActions.SendData(Browser, InpDataInicialAp, DataInicialAp);
            if (DataFinalAp != "" && DataFinalAp != " ")
                AutomatedActions.SendData(Browser, InpDataFinalAp, DataFinalAp);

            MouseActions.ClickATM(Browser, BtnPesquisaAvancada);
        }

        public void ValidarBuscaSolicitacaoPagamento(string Valor)
        {
            var resultadoDaBusca = Element.Xpath("//table[@id='tableAutorizacaoPagamento']//div[contains (., '" + Valor + "')]");
            Assert.IsTrue(ElementExtensions.IsElementVisible(resultadoDaBusca, Browser));
        }

        public void ValidarArquivoPDF(string InpApInicial)
        {
            Thread.Sleep(2000);
            var ClickInpAPInicial = Element.Xpath("//div[text()='" + InpApInicial + "']");
            MouseActions.ClickATM(Browser, ClickInpAPInicial);
            Thread.Sleep(3000);
            var ClickPDF = Element.Css("a[ng-click='GerarEspelhoPDF()']");
            MouseActions.ClickATM(Browser, ClickPDF);

            Thread.Sleep(25000);

            AutoItHelper.CancelarImpressao();

            Thread.Sleep(2000);
            Browser.SwitchToLastWindow();
            ValidarPDFEspelho();

        }

        public void ValidarPDFEspelho()
        {

            var ThObra = Element.Xpath("//th[text()='Obra']");
            var ThAutor = Element.Xpath("//th[text()='Autor']");
            var ThSincronismo = Element.Xpath("//th[text()='Sincronismo']");
            var ThPorcentagem = Element.Xpath("//th[text()='%']");
            var ThProduto = Element.Xpath("//th[text()='Produto']");
            var ThEpisódio = Element.Xpath("//th[text()='Episódio']");
            var ThCapítulo = Element.Xpath("//th[text()='Capítulo']");
            var ThData = Element.Xpath("//th[text()='Data de Exibição']");
            var ThAtividade = Element.Xpath("//th[text()='Atividade']");
            var ThAR = Element.Xpath("//th[text()='AR']");
            var ThAutorização = Element.Xpath("//th[text()='Autorização']");
            var ThValor = Element.Xpath("//th[text()='Valor']");

            ElementExtensions.IsElementVisible(ThObra, Browser);
            ElementExtensions.IsElementVisible(ThAutor, Browser);
            ElementExtensions.IsElementVisible(ThSincronismo, Browser);
            ElementExtensions.IsElementVisible(ThPorcentagem, Browser);
            ElementExtensions.IsElementVisible(ThProduto, Browser);
            ElementExtensions.IsElementVisible(ThEpisódio, Browser);
            ElementExtensions.IsElementVisible(ThCapítulo, Browser);
            ElementExtensions.IsElementVisible(ThData, Browser);
            ElementExtensions.IsElementVisible(ThAtividade, Browser);
            ElementExtensions.IsElementVisible(ThAR, Browser);
            ElementExtensions.IsElementVisible(ThAutorização, Browser);
            ElementExtensions.IsElementVisible(ThValor, Browser);
        }

        public void SelecionarExcel(string NumeroDaAp)
        {
            Thread.Sleep(2000);
            var ClickInpAPInicial = Element.Xpath("//div[text()='" + NumeroDaAp + "']");
            MouseActions.ClickATM(Browser, ClickInpAPInicial);
            Thread.Sleep(3000);
            var ClickExcel = Element.Css("a[ng-click='GerarEspelhoExcel()']");
            MouseActions.ClickATM(Browser, ClickExcel);
        }


        //
        //public void EnviarEspelho(string NumeroDaAp)
        //{
        //    Thread.Sleep(2000);
        //    var ClickInpAPInicial = Element.Xpath("//div[text()='" + NumeroDaAp + "']");
        //    MouseActions.ClickATM(Browser, ClickInpAPInicial);
        //    Thread.Sleep(3000);
        //    var ClickEspelho = Element.Css("a[ng-click='AbrirEmailComRelatorioEspelhoExcel()']");
        //    MouseActions.ClickATM(Browser, ClickEspelho);
        //    Thread.Sleep(3000);

        //    Thread.Sleep(3000);

        //}

        public void ValidarRelatorioExcel(string Lote, string NumeroDaAp, string NumeroDaLPE, string Editora, string DataDeEmissao, string Produto, string Episodio,
            string Capitulo, string DataDeExibicao, string Obra, string Autor, string Atividade, string Creditado, string Sincronismo, string Percentual, string Ar,
            string Autorizacao, string Valor, string NomePlanilha)
        {
            string teste = "EspelhoPagamento";
            {
                string file = teste;
                ValidarDownloadRelatorioExcel(file, Lote, NumeroDaAp, NumeroDaLPE, Editora, DataDeEmissao, Produto, Episodio, Capitulo, DataDeExibicao, Obra, Autor,
                    Atividade, Creditado, Sincronismo, Percentual, Ar, Autorizacao, Valor, NomePlanilha);
            }
        }

        public void ValidarDownloadRelatorioExcel(string file , string Lote, string NumeroDaAp, string NumeroDaLPE, string Editora, string DataDeEmissao, string Produto, 
            string Episodio, string Capitulo, string DataDeExibicao, string Obra, string Autor, string Atividade, string Creditado, string Sincronismo, string Percentual,
            string Ar, string Autorizacao, string Valor, string NomePlanilha)
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx";

            ValidarDadosRelatorioExcel(Lote, NumeroDaAp, NumeroDaLPE, Editora, DataDeEmissao, Produto, Episodio, Capitulo, DataDeExibicao, Obra, Autor,
                Atividade, Creditado, Sincronismo, Percentual, Ar, Autorizacao, Valor, NomePlanilha, file);

            File.Delete(originalFileName);
        }

        public void ValidarDadosRelatorioExcel(string Lote, string NumeroDaAp, string NumeroDaLPE, string Editora, string DataDeEmissao, string Produto,
            string Episodio, string Capitulo, string DataDeExibicao, string Obra, string Autor, string Atividade, string Creditado, string Sincronismo, string Percentual,
            string Ar, string Autorizacao, string Valor, string NomePlanilha, string file)
        {

            ExcelUtil.PopulateInCollection(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx", NomePlanilha);


            ValidarColuna(Lote, "LOTE");
            ValidarColuna(NumeroDaAp, "NÚMERO DA AP");
            ValidarColuna(NumeroDaLPE, "NÚMERO DA LPE");
            ValidarColuna(Editora, "EDITORA");
            ValidarColuna(DataDeEmissao, "DATA DE EMISSÃO");
            ValidarColuna(Produto, "PRODUTO");
            ValidarColuna(Episodio, "EPISÓDIO");
            ValidarColuna(Capitulo, "CAPÍTULO");
            ValidarColuna(DataDeExibicao, "DATA DE EXIBIÇÃO");
            ValidarColuna(Obra, "OBRA");
            ValidarColuna(Autor, "AUTOR");
            ValidarColuna(Atividade, "ATIVIDADE");
            ValidarColuna(Creditado, "CREDITADO");
            ValidarColuna(Sincronismo, "SINCRONISMO");
            ValidarColuna(Percentual, "PERCENTUAL");
            ValidarColuna(Ar, "AR");
            ValidarColuna(Autorizacao, "AUTORIZAÇÃO");
            ValidarColuna(Valor, "VALOR");
        }

        private void ValidarColuna(string ValorLinha, string Coluna)
        {
            if (ValorLinha != "" && ValorLinha != " ")
            {
                var linha = "0";
                var numLinha = 1;

                while (linha != ValorLinha && linha != "")
                {
                    linha = $"{ExcelUtil.ReadData(numLinha, Coluna)}";
                    if (linha == ValorLinha)
                    {
                        Assert.AreEqual(ValorLinha, linha);
                    }
                    else
                    {
                        linha = $"{ExcelUtil.ReadData(numLinha, "PROGRAMA")}";
                        if (linha == "")
                        {
                            throw new ArgumentException("Na coluna " + Coluna + " não existe o valor " + ValorLinha);
                        }
                    }
                    numLinha = numLinha + 1;
                }
            }
        }
    }
}
