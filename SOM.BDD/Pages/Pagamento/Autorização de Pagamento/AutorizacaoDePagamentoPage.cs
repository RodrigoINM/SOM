using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.FrameworkActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
