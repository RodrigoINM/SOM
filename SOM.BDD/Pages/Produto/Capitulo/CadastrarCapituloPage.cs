using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Produto.Capitulo
{
    public class CadastrarCapituloPage : PageBase
    {
        private string CadastroDeCapituloUrl { get; }
        private string ConsultaDeCapituloUrl { get; }

        public Element InpProduto { get; private set; }
        public Element InpCapitulo { get; private set; }
        public Element TxtObservacao { get; private set; }
        public Element InpQtdCapitulos { get; private set; }
        public Element BtnSalvarCapitulos { get; private set; }
        public Element BtnCancelarCadastro { get; private set; }
        public Element PopUpStatus { get; private set; }

        //Consulta de Capitulos
        public Element InpProdutoFiltro { get; private set; }
        public Element InpEpisodioFiltro { get; private set; }
        public Element InpCapituloInicio { get; private set; }
        public Element InpCapituloFinal { get; private set; }
        public Element BtnPesquisar { get; private set; }
        public Element BtnLimparCamposPesquisa { get; private set; }
        public Element BtnShowFiltros { get; private set; }

        //Exclusão de capítulo
        public Element BtnConfirmarExclusao { get; private set; }
        public Element BtnCancelarExclusao { get; private set; }

        string GeracaoEmLote = "$('input[id=\"GeracaoLote\"]').click();";

        public CadastrarCapituloPage(IBrowser browser, string cadastroDeCapituloUrl, string consultaDeCapituloUrl) : base(browser)
        {
            CadastroDeCapituloUrl = cadastroDeCapituloUrl;
            ConsultaDeCapituloUrl = consultaDeCapituloUrl;

            InpProduto = Element.Css("input[ng-model='DscProduto']");
            InpCapitulo = Element.Css("input[ng-model='CapituloDados.NumeroCapitulo']");
            TxtObservacao = Element.Css("textarea[ng-model='CapituloDados.Observacao']");
            InpQtdCapitulos = Element.Css("input[ng-model='CapituloDados.QuantidadeCapitulos']");
            BtnSalvarCapitulos = Element.Css("a[class='btn btn-link collapsed cadastrarcapitulo']");
            BtnCancelarCadastro = Element.Css("a[uib-tooltip='Cancelar']");

            PopUpStatus = Element.Css("div[class='ng-binding ng-scope']");

            //Consulta de Capitulos
            InpProdutoFiltro = Element.Css("input[ng-model='CapituloFiltros.NomeProduto']");
            InpEpisodioFiltro = Element.Css("input[ng-model='CapituloFiltros.Episodio']");
            InpCapituloInicio = Element.Css("input[ng-model='CapituloFiltros.NumeroCapituloInicial']");
            InpCapituloFinal = Element.Css("input[ng-model='CapituloFiltros.NumeroCapituloFinal']");
            BtnPesquisar = Element.Css("button[ng-click='GetAllCapitulo(false)']");
            BtnLimparCamposPesquisa = Element.Css("a[ng-click='LimparCampos()']");
            BtnShowFiltros = Element.Css("a[ng-click='ShowHideFiltro()']");

            //Exclusão de capítulo
            BtnConfirmarExclusao = Element.Css("button[class='confirm']");
            BtnCancelarExclusao = Element.Css("button[class='cancel']");
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastroDeCapituloUrl);
        }

        public void NavegarConsultaDeCapitulos()
        {
            Browser.Abrir(ConsultaDeCapituloUrl);
        }

        public void CadastrarCapitulo(string Produto, string Capitulo, string Lote, string Qtd, string Observacao)
        {
            PreencherDadosCapitulo(Produto, Capitulo, Lote, Qtd, Observacao);

            ElementExtensions.IsElementVisible(BtnSalvarCapitulos, Browser);
            MouseActions.ClickATM(Browser, BtnSalvarCapitulos);
        }

        public void CancelarCadastrarCapitulo(string Produto, string Capitulo, string Lote, string Qtd, string Observacao)
        {
            PreencherDadosCapitulo(Produto, Capitulo, Lote, Qtd, Observacao);

            ElementExtensions.IsElementVisible(BtnCancelarCadastro, Browser);
            MouseActions.ClickATM(Browser, BtnCancelarCadastro);
        }

        private void PreencherDadosCapitulo(string Produto, string Capitulo, string Lote, string Qtd, string Observacao)
        {
            if (Produto != "" && Produto != " ")
                SelecionarProduto(Produto);
            if (Capitulo != "" && Capitulo != " ")
                AutomatedActions.SendDataATM(Browser, InpCapitulo, Capitulo);
            if (Observacao != "" && Observacao != " ")
                AutomatedActions.SendDataATM(Browser, TxtObservacao, Observacao);
            if (Lote != "" && Lote != " ")
                JsActions.JavaScript(Browser, GeracaoEmLote);
            if (Qtd != "" && Qtd != " ")
                AutomatedActions.SendDataATM(Browser, InpQtdCapitulos, Qtd);
        }

        private void SelecionarProduto(string Produto)
        {
            if(Produto == "Aleatório")
            {
                AutomatedActions.SendDataATM(Browser, InpProduto, CadastroDeProdutoPage.Produto);
                var nomeProduto = Element.Xpath("//strong[contains(., '" + CadastroDeProdutoPage.Produto + "')]");
                MouseActions.ClickATM(Browser, nomeProduto);
            }
            else
            {
                AutomatedActions.SendDataATM(Browser, InpProduto, Produto);
                var nomeProduto = Element.Xpath("//strong[contains(., '" + Produto + "')]");
                MouseActions.ClickATM(Browser, nomeProduto);
            }
        }

        public void ConsultaDeCapitulos(string Produto, string Episodio, string CapituloInicio, string CapituloFinal)
        {
            ElementExtensions.IsElementVisible(BtnShowFiltros, Browser);
            MouseActions.ClickATM(Browser, BtnShowFiltros);

            if (Produto != "" && Produto != " ")
                InformarProduto(Produto);
            if (Episodio != "" && Episodio != " ")
                InformarEpisodio(Episodio);
            if (CapituloInicio != "" && CapituloInicio != " ")
                AutomatedActions.SendDataATM(Browser, InpCapituloInicio, CapituloInicio);
            if (CapituloFinal != "" && CapituloFinal != " ")
                AutomatedActions.SendDataATM(Browser, InpCapituloFinal, CapituloFinal);

            ElementExtensions.IsElementVisible(BtnPesquisar, Browser);
            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        private void InformarProduto(string Produto)
        {
            if(Produto == "Aleatório")
                AutomatedActions.SendDataATM(Browser, InpProdutoFiltro, CadastroDeProdutoPage.Produto);
            else
                AutomatedActions.SendDataATM(Browser, InpProdutoFiltro, Produto);
        }

        private void InformarEpisodio(string Episodio)
        {
            if (Episodio == "Aleatório")
                AutomatedActions.SendDataATM(Browser, InpEpisodioFiltro, CadastroDeProdutoPage.Episodio);
            else
                AutomatedActions.SendDataATM(Browser, InpEpisodioFiltro, Episodio);
        }

        public void ValidarPopUpSucesso(string Mensagem)
        {
            Assert.AreEqual(Mensagem, ElementExtensions.GetTexto(PopUpStatus, Browser));
        }

        public void ValidarTelaDeConsultaDeCapitulos()
        {
            Thread.Sleep(2000);
            var textoDeBusca = ElementExtensions.GetTexto(Element.Css("div[ng-init='Init()'] h2"), Browser);
            Assert.AreEqual("Buscar Capítulo", textoDeBusca);
        }

        public void ValidarCamposObrigatorios(string Campo)
        {
            var nomeCampo = Element.Xpath("//div[@class='has-error']//label[contains(.,'" + Campo + "')]");
            ElementExtensions.IsElementVisible(nomeCampo, Browser);
        }

        public void ValidarConsultaDePedido(string Produto, string Episodio, string Capitulo)
        {
            if (Produto == "Aleatório")
                ValidarCampo(CadastroDeProdutoPage.Produto);
            if(Produto != "Aleatório")
                ValidarCampo(Produto);
            if (Episodio == "Aleatório")
                ValidarCampo(CadastroDeProdutoPage.Episodio);
            if (Episodio != "Aleatório")
                ValidarCampo(Episodio);
            ValidarCampo(Capitulo);
        }

        private void ValidarCampo(string Valor)
        {
            var resultadoConsulta = Element.Xpath("//tbody//div[text()='" + Valor + "']");
            Assert.AreEqual(Valor, ElementExtensions.GetTexto(resultadoConsulta, Browser));
        }

        public void ValidarMensagemDeCritica(string Mensagem)
        {
            var textoPopup = ElementExtensions.GetTexto(Element.Css("p[style='display: block;']"), Browser);
            Assert.AreEqual(Mensagem, textoPopup);
        }

        public void ValidarDadosNaoEncontrados(string Mensagem)
        {
            var dadosNaoEncontrados = ElementExtensions.GetTexto(Element.Css("td[class='dataTables_empty']"), Browser);
            Assert.AreEqual(Mensagem, dadosNaoEncontrados);
        }


        //******************************EXCLUSÃO DE CAPITULO CADASTRADO********************************
        public void ExcluirCapitulo(string Produto, string Confirmar)
        {
            if(Produto == "Aleatório")
            {
                var nomeProduto = "//table[@dt-columns='dtColumns']//div[text()='" + CadastroDeProdutoPage.Produto + "']/../..//div[@uib-tooltip='Excluir']";
                MouseActions.ClickATM(Browser, Element.Xpath(nomeProduto));
            }
            else
            {
                string nomeProduto = "//table[@dt-columns='dtColumns']//div[text()='" + Produto + "']/../..//div[@uib-tooltip='Excluir']";
                MouseActions.ClickATM(Browser, Element.Xpath(nomeProduto));
            }
            
            Thread.Sleep(1500);
            if (Confirmar == "Sim")
                MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            else
                MouseActions.ClickATM(Browser, BtnCancelarExclusao);
            Thread.Sleep(1500);
        }


        public void ValidarCapituloExcluido(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));
        }

        //******************************EXCLUSÃO DE CAPITULO CADASTRADO********************************
        //******************************ALTERAÇÃO DE CAPITULO CADASTRADO********************************
        public void AlterarCapitulo(string Produto, string Capitulo, string Observacao)
        {
            if (Produto == "Aleatório")
            {
                var nomeProduto = "//table[@dt-columns='dtColumns']//div[text()='" + CadastroDeProdutoPage.Produto + "']";
                MouseActions.DoubleClickATM(Browser, Element.Xpath(nomeProduto));
            }
            else
            {
                string nomeProduto = "//table[@dt-columns='dtColumns']//div[text()='" + Produto + "']";
                MouseActions.DoubleClickATM(Browser, Element.Xpath(nomeProduto));
            }

            if (Capitulo != "" && Capitulo != " ")
                AutomatedActions.SendDataATM(Browser, InpCapitulo, Capitulo);
            if (Observacao != "" && Observacao != " ")
                AutomatedActions.SendDataATM(Browser, TxtObservacao, Observacao);

            var BtnSalvarAlteracao = Element.Css("a[ng-click='salvarCapitulo(true)']");
            ElementExtensions.IsElementVisible(BtnSalvarAlteracao, Browser);
            MouseActions.ClickATM(Browser, BtnSalvarAlteracao);
        }
    }
}
