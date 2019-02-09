using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using System;
using Framework.Core.Helpers;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.Obra;

namespace SOM.BDD.Pages.UsoEReporte.Cue_Sheet
{
    public class CadastrarCueSheetPage : PageBase
    {
        private string CadastroDeCueSheet { get; }

        private string PageTitle => "SOM | Cue-Sheet";

        //Cadastro de cue-sheet
        public Element InpProduto { get; private set; }
        public Element InpEpisodio { get; private set; }
        public Element InpCapitulo { get; private set; }
        public Element InpDataExibicao { get; private set; }
        public Element SlctMidia { get; private set; }
        public Element SlctRebatidaReprise { get; private set; }
        public Element BtnSalvarCueSheet { get; private set; }
        public Element BtnCancelarCriacaoDeCueSheet { get; private set; }
        public Element BtnLiberarCueSheet { get; private set; }
        public Element BtnDuplicarCueSheet { get; private set; }
        public Element BtnReabrirCueSheet { get; private set; }
        public Element BtnFinalizarCueSheet { get; private set; }
        public Element BtnReiniciarCueSheet { get; private set; }

        public CadastrarCueSheetPage(IBrowser browser, string cadastroDeCueSheet) : base(browser)
        {
            CadastroDeCueSheet = cadastroDeCueSheet;

            //Cadastro de cue-sheet
            InpProduto = Element.Css("input[ng-model='DscProduto']");
            InpEpisodio = Element.Css("input[ng-model='CueSheetDados.DscEpisodio']");
            InpCapitulo = Element.Css("input[ng-model='CueSheetDados.Capitulo']");
            InpDataExibicao = Element.Css("input[ng-model='CueSheetDados.DataExibicao']");
            SlctMidia = Element.Css("select[ng-model='CueSheetDados.Midia.selected']");
            SlctRebatidaReprise = Element.Css("select[ng-model='CueSheetDados.RepriseRebatida.selected']");
            BtnSalvarCueSheet = Element.Css("a[ng-click='salvarCueSheet()']");
            BtnCancelarCriacaoDeCueSheet = Element.Css("a[ng-click='voltarLista()']");
            BtnLiberarCueSheet = Element.Css("a[ng-click='LiberarCueSheet()']");
            BtnDuplicarCueSheet = Element.Css("a[uib-tooltip='Duplicar Cue-Sheet']");
            BtnReabrirCueSheet = Element.Css("a[ng-click='ReabrirCueSheet()']");
            BtnFinalizarCueSheet = Element.Css("a[uib-tooltip='Finalizar Cue-Sheet']");
            BtnReiniciarCueSheet = Element.Css("a[uib-tooltip='Reiniciar Cue-Sheet']");
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastroDeCueSheet);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void AbrirItemDeCueSheet(string TituloObra)
        {
            if(TituloObra != "" && TituloObra != " ")
            {
                if (TituloObra == "Aleatório")
                    MouseActions.DoubleClickATM(Browser, Element.Xpath("//td[text()='" + CadastrarObraEComposicaoPage.Obra + "']"));
                else
                    MouseActions.DoubleClickATM(Browser, Element.Xpath("//td[text()='" + TituloObra + "']"));
            }
        }

        public void ClicarDuplicarCueSheet()
        {
            ElementExtensions.IsElementVisible(BtnDuplicarCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnDuplicarCueSheet);
        }
        
        public void CadastrarCueSheet(string Produto, string Episodio, string Capitulo, string DataExibicao, string Midias, string RepriseRebatida)
        {
            PreencherDadosDaCueSheet(Produto, Episodio, Capitulo, DataExibicao, Midias, RepriseRebatida);

            MouseActions.ClickATM(Browser, BtnSalvarCueSheet);
        }

        public void CadastrarCueSheetRandomica(string Produto, string Episodio, string Capitulo, string DataExibicao, string Midias, string RepriseRebatida)
        {
            Produto = CadastroDeProdutoPage.Produto;
            Episodio = CadastroDeProdutoPage.Episodio;

            PreencherDadosDaCueSheet(Produto, Episodio, Capitulo, DataExibicao, Midias, RepriseRebatida);

            MouseActions.ClickATM(Browser, BtnSalvarCueSheet);
        }

        private void PreencherDadosDaCueSheet(string Produto, string Episodio, string Capitulo, string DataExibicao, string Midias, string RepriseRebatida)
        {
            if (Produto != "")
            {
                AutomatedActions.SendDataATM(Browser, InpProduto, Produto);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + Produto + "']"));
            }
            if (Episodio != "")
            {
                AutomatedActions.SendData(Browser, InpEpisodio, Episodio);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + Episodio + "']"));
            }
            if (Capitulo != "")
            {
                AutomatedActions.SendDataATM(Browser, InpCapitulo, Capitulo);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + Capitulo + "']"));
            }
            if (DataExibicao != "")
                AutomatedActions.SendData(Browser, InpDataExibicao, DataExibicao);
            if (Midias != "")
                MouseActions.SelectElementATM(Browser, SlctMidia, Midias);
            if (RepriseRebatida != "" && RepriseRebatida != " ")
                MouseActions.SelectElementATM(Browser, SlctRebatidaReprise, RepriseRebatida);
        }

        public void ValidarPopUpsDeCriticaDaCueSheet(string MensagemCritica, string Mensagem)
        {
            var texto = Element.Css("p[style='display: block;']");
            Assert.AreEqual(MensagemCritica, ElementExtensions.GetValorAtributo(texto, "textContent", Browser));

            Thread.Sleep(2000);
            var BtnConfirmar = Element.Css("button[class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);

            try
            {
                Thread.Sleep(2000);
                var textoCritica = Element.Css("p[style='display: block;']");
                Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textoCritica, "textContent", Browser));
            }
            catch
            {
                Thread.Sleep(2000);
                var textoCritica = Element.Css("p[style='display: block;']");
                Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textoCritica, "textContent", Browser));
            }
        }

        public void ValidarDuplicidadeDeCueSheet(string MensagemCritica, string Mensagem)
        {
            var texto = Element.Css("p[style='display: block;']");
            Assert.AreEqual(MensagemCritica, ElementExtensions.GetValorAtributo(texto, "textContent", Browser));

            Thread.Sleep(2000);
            var BtnConfirmar = Element.Css("button[class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);

            var textoCritica = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textoCritica, "textContent", Browser));
        }

        public void ValidarPopupSemImportacao(string MensagemCritica, string Mensagem)
        {
            ValidarAlerta(MensagemCritica);

            Thread.Sleep(2000);
            var BtnConfirmar = Element.Css("button[class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);
            ValidarPopup(Mensagem);
        }

        public void ValidarPopup(string Mensagem)
        {
            var textoSucesso = Element.Css("div[ng-class='config.message']");
            try
            {
                textoSucesso.IsElementVisible(Browser);
                Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textoSucesso, "textContent", Browser));
            }
            catch
            {
                Thread.Sleep(2000);
                textoSucesso.IsElementVisible(Browser);
                Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textoSucesso, "textContent", Browser));
            }
        }

        public void ValidarStatusDaCueSheet(string Status)
        {
            var textStatus = Element.Xpath("//span[text()='" + Status + "']");
            ElementExtensions.IsElementVisible(textStatus, Browser);
        }

        public void ValidarBotaoLiberarCueSheet()
        {
            ElementExtensions.IsElementVisible(BtnLiberarCueSheet, Browser);
        }

        public void ValidarAlerta(string Mensagem)
        {
            var texto = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(texto, "textContent", Browser));
        }

        public void ValidarCueSheetRandomicaCadastrada(string Produto, string DataExibicao, string Episodio, string Capitulo, string Midia)
        {
            ValidarDadosDaCueSheet("Produto", CadastroDeProdutoPage.Produto);
            ValidarDadosDaCueSheet("Data de Exibição", DataExibicao);
            ValidarDadosDaCueSheet("Episódio", CadastroDeProdutoPage.Episodio);
            ValidarDadosDaCueSheet("Capítulo", Capitulo);
            ValidarDadosDaCueSheet("Mídia", Midia);
        }

        public void ValidarCueSheetCadastrada(string Produto, string DataExibicao, string Episodio, string Capitulo, string Midia)
        {
            ValidarDadosDaCueSheet("Produto", Produto);
            ValidarDadosDaCueSheet("Data de Exibição", DataExibicao);
            ValidarDadosDaCueSheet("Episódio", Episodio);
            ValidarDadosDaCueSheet("Capítulo", Capitulo);
            ValidarDadosDaCueSheet("Mídia", Midia);
        }

        private void ValidarDadosDaCueSheet(string Campo, string Valor)
        {
            if (Valor != "" && Valor != " ")
            {
                var text = Element.Xpath("//b[text()='" + Campo + ":']/../span");
                Assert.AreEqual(Valor, ElementExtensions.GetValorAtributo(text, "textContent", Browser));
            }
        }

        public void ValidarCapituloObrigatorio()
        {
            var capitulo = Element.Css("div[ng-class='classCapitulo'][class='has-error']");
            Assert.IsTrue(ElementExtensions.IsClickable(capitulo, Browser));
        }

        public void ValidarArquivoDeImportacaoObrigatorio()
        {
            var texto = Element.Css("p[style='display: block;']");
            Assert.AreEqual("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", ElementExtensions.GetValorAtributo(texto, "textContent", Browser));

            Thread.Sleep(2000);
            var BtnCancelar = Element.Css("button[class='cancel']");
            MouseActions.ClickATM(Browser, BtnCancelar);

            var arquivoDeImportacao = Element.Css("div[ng-class='classArquivoItemCueSheet'][class='has-error']");
            Assert.IsTrue(ElementExtensions.IsClickable(arquivoDeImportacao, Browser));
        }

        public void LiberarCueSheet()
        {
            ElementExtensions.IsElementVisible(BtnLiberarCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnLiberarCueSheet);
        }

        public void ReabrirCueSheet()
        {
            Browser.RefreshPage();
            ElementExtensions.IsElementVisible(BtnReabrirCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnReabrirCueSheet);
        }

        public void FinalizarCueSheet()
        {
            Browser.RefreshPage();
            ElementExtensions.IsElementVisible(BtnFinalizarCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnFinalizarCueSheet);
            ValidarAlerta("Esta cue-sheet terá seu status alterado para Finalizada e não poderá mais sofrer alterações. Deseja prosseguir?");

            Thread.Sleep(2000);
            var BtnConfirmar = Element.Css("button[class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);
        }

        public void ReiniciarCueSheet()
        {
            Browser.RefreshPage();
            ElementExtensions.IsElementVisible(BtnReiniciarCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnReiniciarCueSheet);
            ValidarAlerta("Você está reiniciando a cue-sheet. Deseja prosseguir?");

            Thread.Sleep(2000);
            var BtnConfirmar = Element.Css("button[class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);
        }

        public void DuplicarCueSheet(string RepriseRebatida)
        {
            ClicarDuplicarCueSheet();

            if(RepriseRebatida != "" && RepriseRebatida != " ")
            {
                var SlctRepriseRebatida = Element.Css("select[ng-model='CueSheetDados.RepriseRebatida.selected']");
                ElementExtensions.IsElementVisible(SlctRepriseRebatida, Browser);
                MouseActions.SelectElementATM(Browser, SlctRepriseRebatida, RepriseRebatida);
            }

            var BtnSalvarDuplicarCueSheet = Element.Css("a[ng-click='duplicarCueSheet()']");
            ElementExtensions.IsElementVisible(BtnSalvarDuplicarCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnSalvarDuplicarCueSheet);
        }

        public void ValidarCamposBloqueadosParaDuplicarCueSheet()
        {
            ElementExtensions.IsElementVisible(Element.Xpath("//h2[text()='Duplicar Cue-Sheet']"), Browser);

            var campoProduto = Element.Css("input[ng-disabled='desabilitarProduto']");
            var campoEpisodio = Element.Css("input[ng-disabled='desabilitarProdutoEpisodio']");

            ElementExtensions.IsElementVisible(campoProduto, Browser);
            ElementExtensions.IsElementVisible(campoEpisodio, Browser);
        }

        public void ValidarValoresDaCueSheetADuplicarRandomica(string Produto, string Episodio, string Capitulo, string Midia,
            string Dia, string Mes, string Ano, string RepriseRebatida)
        {
            Produto = CadastroDeProdutoPage.Produto;
            Episodio = CadastroDeProdutoPage.Episodio;

            ElementExtensions.IsElementVisible(Element.Xpath("//h2[text()='Duplicar Cue-Sheet']"), Browser);

            var campoProduto = Element.Css("input[ng-disabled='desabilitarProduto']").GetValorAtributo("value", Browser);
            var campoEpisodio = Element.Css("input[ng-disabled='desabilitarProdutoEpisodio']").GetValorAtributo("value", Browser);
            var campoCapitulo = Element.Css("input[ng-model='CueSheetDados.Capitulo']").GetValorAtributo("value", Browser);
            var campoDataExibicao = Element.Css("input[ng-model='CueSheetDados.DataExibicao']").GetValorAtributo("value", Browser);
            string DataExibicao = Ano + "-" + Mes + "-" + Dia;
            var campoMidia = ElementExtensions.GetValorCss(Element.Css("select[ng-model='CueSheetDados.Midia.selected']"), Browser).Replace("Selecione...", "");

            Assert.AreEqual(Produto, campoProduto);
            Assert.AreEqual(Episodio, campoEpisodio);
            Assert.AreEqual(Capitulo, campoCapitulo);
            Assert.AreEqual(DataExibicao, campoDataExibicao);
            Assert.AreEqual(Midia, campoMidia);
        }

        public void ValidarRepriseRebatida(string RepriseRebatida)
        {
            var textRepriseRebatida = Element.Css("div[ng-if='CueSheet.RepriseRebatida']").GetValorCss(Browser).Replace(" 1", "");
            Assert.AreEqual(RepriseRebatida, textRepriseRebatida);
        }

        public void ValidarPorcentagelDeAprovacaoDaCueSheet(string Porcentagem)
        {
            Thread.Sleep(2000);
            var valorPorcentagem = Element.Xpath("//span[contains(., '" + Porcentagem + "')]");
            valorPorcentagem.IsElementVisible(Browser);
        }

        public void ValidarPendenciaItemCueSheet(string Valor)
        {
            var Pendencia = Element.Css("span[data-uib-tooltip-html='ItemPendenciatooltip']");
            //MouseActions.MouseMoveToElementSML(Browser, Pendencia);
            //var textoPendencia = Element.Xpath("//div[@ng-bind-html='contentExp()']//div[contains(., '" + Valor +"')]");
            Pendencia.IsElementVisible(Browser);
        }

        public void ValidarItensAprovados(string Valor)
        {
            var itemAprovado = Element.Xpath("//td[text()='" + Valor + "']/..//span[text()='Aprovado']");
            itemAprovado.IsElementVisible(Browser);
        }
    }
}
