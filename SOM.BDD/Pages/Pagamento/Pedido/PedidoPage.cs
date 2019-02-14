using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using SOM.BDD.Pages.Obra;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.IO;

namespace SOM.BDD.Pages.Pagamento.Pedido
{
    public class PedidoPage : PageBase
    {
        public string ConsultaDePedidoUrl { get; }

        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }

        public Element AbaAutorizacao { get; private set; }
        public Element AbaPagamento { get; private set; }

        //Busca simples de Pedido
        public Element InpBuscaDePedido { get; private set; }
        public Element BtnBuscaSimplesDePedido { get; private set; }

        public Element BtnRegistrarAutorizacao { get; private set; }
        public Element BtnEnviarAutorizacao { get; private set; }
        public Element BtnCancelarItemDePedido { get; private set; }

        //Busca avançada de pedido
        public Element InpNumeroPedido { get; private set; }
        public Element InpProduto { get; private set; }
        public Element InpDataInicial { get; private set; }
        public Element InpDataFinal { get; private set; }
        public Element InpObra { get; private set; }
        public Element InpAutor { get; private set; }
        public Element InpDDA { get; private set; }
        public Element InpSincronismo { get; private set; }
        public Element InpMidiasAutorizadas { get; private set; }
        public Element InpMidiaADebitar { get; private set; }
        public Element InpStatus { get; private set; }
        public Element InpValorNegociado { get; private set; }
        public Element InpStatusPav { get; private set; }
        public Element BtnShowFiltro { get; private set; }
        public Element BtnPesquisar { get; private set; }

        //Cadastrar DNI
        public Element BtnCadastrarDNI { get; private set; }

        public PedidoPage(IBrowser browser, string consultaDePedidoUrl) : base(browser)
        {
            ConsultaDePedidoUrl = consultaDePedidoUrl;

            AbaAutorizacao = Element.Xpath("//*[text()='AUTORIZAÇÃO']");
            AbaPagamento = Element.Xpath("//*[text()='PAGAMENTO']");

            //Busca simples de Pedido
            InpBuscaDePedido = Element.Css("input[placeholder='Buscar por Número do Pedido']");
            BtnBuscaSimplesDePedido = Element.Css("a[uib-tooltip='Pesquisar']");

            BtnRegistrarAutorizacao = Element.Css("a[uib-tooltip='Registrar Autorizacao']");
            BtnEnviarAutorizacao = Element.Css("a[uib-tooltip='Enviar Autorização']");
            BtnCancelarItemDePedido = Element.Css("div[class='tab-pane ng-scope active'] a[uib-tooltip='Cancelar itens de pedido']");

            //Busca avançada de pedido
            InpNumeroPedido = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.Numero']");
            InpProduto = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.DscProduto']");
            InpDataInicial = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.DataExibicao']");
            InpDataFinal = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.DataExibicaoFim']");
            InpObra = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.Obra']");
            InpAutor = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.Autor']");
            InpDDA = Element.Css("div[id='filtroTela'] input[ng-model='PedidoFiltros.DDA']");
            InpSincronismo = Element.Css("div[id='filtroTela'] div[id='TipoSincronismoMulti_chosen']");
            InpMidiasAutorizadas = Element.Css("div[id='filtroTela'] div[id='MidiaAutorizadaMulti_chosen']");
            InpMidiaADebitar = Element.Css("div[id='filtroTela'] div[id='MidiaDebitarMulti_chosen']");
            InpStatus = Element.Css("div[id='filtroTela'] div[id='StatusMulti_chosen']");
            InpValorNegociado = Element.Css("div[id='filtroTela'] div[id='ValorNegMulti_chosen']");
            InpStatusPav = Element.Css("div[id='filtroTela'] div[id='StatusPAVMulti_chosen']");
            BtnShowFiltro = Element.Css("a[ng-click='ShowHideFiltro()']");
            BtnPesquisar = Element.Css("button[uib-tooltip='Pesquisar']");

            //Cadastrar DNI
            BtnCadastrarDNI = Element.Css("a[ng-click='CriarMidiasDNI()']");
        }


        public override void Navegar()
        {
            Browser.Abrir(ConsultaDePedidoUrl);
        }

        public void CadastrarDNI(string Confirmar)
        {
            ClicarCadastroDeDNI();
            ValidarMensagemDeAlerta("Serão gerados os itens para pagamento da DNI, deseja prosseguir?");

            var BtnConfirmar = Element.Css("button[class='confirm']");
            var BtnCancelar = Element.Css("button[class='cancel']");

            if (Confirmar == "Sim")
                MouseActions.ClickATM(Browser, BtnConfirmar);
            if (Confirmar == "Não")
                MouseActions.ClickATM(Browser, BtnCancelar);
        }

        public void ValidarMensagemDeAlerta(string Mensagem)
        {
            var textoAlerta = ElementExtensions.GetTexto(Element.Css("p[style='display: block;']"), Browser);
            try
            {
                Thread.Sleep(2000);
                Assert.AreEqual(Mensagem, textoAlerta);
            }
            catch
            {
                Thread.Sleep(2000);
                Assert.AreEqual(Mensagem, textoAlerta);
            }
        }

        private void ClicarCadastroDeDNI()
        {
            ElementExtensions.IsElementVisible(BtnCadastrarDNI, Browser);
            MouseActions.ClickATM(Browser, BtnCadastrarDNI);
        }

        private void SelecionarMidiaAutorizada(string Valor)
        {
            var textoMidiaAutorizada = Element.Xpath("//div[@class='ng-binding ng-scope'][text()='" + Valor +"']");
            ElementExtensions.IsElementVisible(InpMidiasAutorizadas, Browser);
            ElementExtensions.IsElementVisible(textoMidiaAutorizada, Browser);
            MouseActions.ClickATM(Browser, textoMidiaAutorizada);
        }

        public void BuscaAvancadaDePedido(string NumeroPedido, string Produto, string Obra, string DataInicial, string DataFinal, string Autor,
            string DDA, string Sincronismo, string MidiasAutorizadas, string MidiaADebitar, string Status, string ValorNegociado, string StatusPav)
        {
            MouseActions.ClickATM(Browser, BtnShowFiltro);

            if (NumeroPedido != "" && NumeroPedido != " ")
                AutomatedActions.SendDataATM(Browser, InpNumeroPedido, NumeroPedido);
            if (Produto != "" && Produto != " ")
            {
                AutomatedActions.SendDataATM(Browser, InpProduto, Produto);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + Produto + "']"));
            }
            if (Obra != "" && Obra != " ")
            {
                AutomatedActions.SendDataATM(Browser, InpObra, Obra);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + Obra + "']"));
            }
            if (DataInicial != "" && DataInicial != " ")
                AutomatedActions.SendData(Browser, InpDataInicial, DataInicial);
            if (DataFinal != "" && DataFinal != " ")
                AutomatedActions.SendData(Browser, InpDataFinal, DataFinal);
            if (Autor != "" && Autor != " ")
            {
                AutomatedActions.SendDataATM(Browser, InpAutor, Autor);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + Autor + "']"));
            }
            if (DDA != "" && DDA != " ")
            {
                AutomatedActions.SendDataATM(Browser, InpDDA, DDA);
                MouseActions.ClickATM(Browser, Element.Xpath("//a/strong[text()='" + DDA + "']"));
            }
            if (Sincronismo != "" && Sincronismo != " ")
            {
                MouseActions.ClickATM(Browser, InpSincronismo);
                MouseActions.ClickATM(Browser, Element.Xpath("//li[contains(., '" + Sincronismo + "')]"));
            }
            if (MidiasAutorizadas != "" && MidiasAutorizadas != " ")
            {
                MouseActions.ClickATM(Browser, InpMidiasAutorizadas);
                MouseActions.ClickATM(Browser, Element.Xpath("//li[contains(., '" + MidiasAutorizadas + "')]"));
            }
            if (MidiaADebitar != "" && MidiaADebitar != " ")
            {
                MouseActions.ClickATM(Browser, InpMidiaADebitar);
                MouseActions.ClickATM(Browser, Element.Xpath("//li[contains(., '" + MidiaADebitar + "')]"));
            }
            if (Status != "" && Status != " ")
            {
                MouseActions.ClickATM(Browser, InpStatus);
                MouseActions.ClickATM(Browser, Element.Xpath("//li[contains(., '" + Status + "')]"));
            }
            if (ValorNegociado != "" && ValorNegociado != " ")
            {
                MouseActions.ClickATM(Browser, InpValorNegociado);
                MouseActions.ClickATM(Browser, Element.Xpath("//li[contains(., '" + ValorNegociado + "')]"));
            }
            if (StatusPav != "" && StatusPav != " ")
            {
                MouseActions.ClickATM(Browser, InpStatusPav);
                MouseActions.ClickATM(Browser, Element.Xpath("//li[contains(., '" + StatusPav + "')]"));
            }

            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        private void ExibirFiltroAvancado()
        {
            try
            {
                ElementExtensions.IsElementVisible(Element.Css("div[class='ibox-content animated fadeIn']"), Browser);
            }
            catch
            {
                MouseActions.ClickATM(Browser, BtnShowFiltro);
            }
        }

        public void AcessarAbaPagamento()
        {
            ElementExtensions.IsElementVisible(AbaPagamento, Browser);
            MouseActions.ClickATM(Browser, AbaPagamento);
        }

        public void AcessarAbaPagamentoNaTelaDeBusca()
        {
            Thread.Sleep(2000);
            var abaPagamento = Element.Xpath("//a/uib-tab-heading[text()='Pagamento']");
            ElementExtensions.IsElementVisible(abaPagamento, Browser);
            MouseActions.ClickATM(Browser, abaPagamento);
        }

        public void AcessarAbaAutorizacaoNaTelaDeBusca()
        {
            Thread.Sleep(2000);
            var abaAutorizacao = Element.Xpath("//a/uib-tab-heading[text()='Autorização']");
            ElementExtensions.IsElementVisible(abaAutorizacao, Browser);
            MouseActions.ClickATM(Browser, abaAutorizacao);
        }

        public void SelecionarUmItemDePedidoAutorização(string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//*[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                case "Autor2":
                    {
                        var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//*[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                default:
                    {
                        var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//*[text()='" + Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
            }
            
        }

        public void SelecionarUmItemDePedidoPagamento(string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//*[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                case "Autor2":
                    {
                        var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//*[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                default:
                    {
                        var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//*[text()='" + Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
            }
        }

        public void SelecionarDoisItensDePedido(string Autor1, string Autor2)
        {
            var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor1 + "']");
            var item2 = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor2 + "']");
            MouseActions.ClickAndHoldATM(Browser, item, item2);
        }

        public void ValidarValorTotalUmItemSelecionado()
        {
            var itemSelecionado = ElementExtensions.GetValorCss(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + CadastrarObraEComposicaoPage.Autor + "']/..//td[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var valorTotal = ElementExtensions.GetValorCss(Element.Css("label"), Browser).Replace("Valor Total: R$ ", "");
            Assert.AreEqual(valorTotal, itemSelecionado);
        }

        public void ValidarValorTotalDoisItensSelecionados()
        {
            var itemSelecionado = ElementExtensions.GetValorCss(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + CadastrarObraEComposicaoPage.Autor + "']/..//td[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var itemSelecionado2 = ElementExtensions.GetValorCss(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']/..//td[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var somaItensSelecionados = Convert.ToDouble(itemSelecionado) + Convert.ToDouble(itemSelecionado2);
            var valorTotal = ElementExtensions.GetValorCss(Element.Css("label"), Browser).Replace("Valor Total: R$ ", "");
            Assert.AreEqual(Convert.ToDouble(valorTotal), somaItensSelecionados);
        }
        
        public void RealizarBuscaPorPedido()
        {
            var numPedido = ElementExtensions.GetValorCss(Element.Xpath("//b[text()='Número:']/../b[@class='ng-binding']"), Browser).Replace(" ", "");
            Navegar();
            BuscaSimplesDePedido(numPedido);
        }
        
        public void BuscaSimplesDePedido(string Valor)
        {
            ElementExtensions.IsElementVisible(InpBuscaDePedido, Browser);
            AutomatedActions.SendDataATM(Browser, InpBuscaDePedido, Valor);
            MouseActions.ClickATM(Browser, BtnBuscaSimplesDePedido);
        }

        public void AbrirPedido(string Valor)
        {
            var valorTextoElementoPedido = Element.Xpath("//table[@id='tablePedido']//div[text()='" + Valor + "']");
            MouseActions.DoubleClickATM(Browser, valorTextoElementoPedido);
        }

        public void TrocarAbaBrowser()
        {
            Browser.CloseFirstWindow();
            Browser.SwitchToLastWindow();
        }

        public void TrocarParaUltimaAbaSemFecharPrimeiraAba()
        {
            Browser.SwitchToLastWindow();
        }

        public void TrocarParaPrimeiraAbaSemFecharUltimaAba()
        {
            Browser.SwitchToFirstWindow();
        }

        public void TrocarParaPrimeiraAba()
        {
            Browser.CloseLastWindow();
            Browser.SwitchToFirstWindow();
        }

        public void ValidarStatusPav(string Valor)
        {
            var statusPav = Element.Xpath("//div[@align='left']//span[contains(., '" + Valor + "')]");
            ElementExtensions.IsElementVisible(statusPav, Browser);
        }

        public void SelecionarUmItemDePedidoNaTelaDeBusca()
        {
            var abaPagamento = Element.Xpath("//uib-tab-heading[text()='Pagamento']");
            MouseActions.ClickATM(Browser, abaPagamento);

            var item = Element.Xpath("//table[@id='tablePagamento']//div[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
            MouseActions.ClickATM(Browser, item);
        }

        public void SelecionarDoisItensDePedidoNaTelaDeBusca()
        {
            var abaPagamento = Element.Xpath("//uib-tab-heading[text()='Pagamento']");
            MouseActions.ClickATM(Browser, abaPagamento);

            var item = Element.Xpath("//table[@id='tablePagamento']//div[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
            var item2 = Element.Xpath("//table[@id='tablePagamento']//div[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']");
            MouseActions.ClickAndHoldATM(Browser, item, item2);
        }

        public void ValidarValorTotalUmItemSelecionadoNaTelaDeBusca()
        {
            var itemSelecionado = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='" + CadastrarObraEComposicaoPage.Autor + "']/../..//div[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var valorTotal = ElementExtensions.GetValorCss(Element.Xpath("//label[contains (., 'Valor Total')]"), Browser).Replace("Valor Total: R$ ", "");
            Assert.AreEqual(valorTotal, itemSelecionado);
        }

        public void ValidarValorTotalDoisItensSelecionadosNaTelaDeBusca()
        {
            var itemSelecionado = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='" + CadastrarObraEComposicaoPage.Autor + "']/../..//div[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var itemSelecionado2 = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']/../..//div[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var somaItensSelecionados = Convert.ToDouble(itemSelecionado) + Convert.ToDouble(itemSelecionado2);
            var valorTotal = ElementExtensions.GetValorCss(Element.Xpath("//label[contains (., 'Valor Total')]"), Browser).Replace("Valor Total: R$ ", "");
            Assert.AreEqual(Convert.ToDouble(valorTotal), somaItensSelecionados);
        }

        public void ValidarNovosValoresParaItemDePedido(string Autor)
        {
            var itemAPagar = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='" + Autor + "']/../..//div[text()='A Pagar']/../..//div[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var itemCancelado = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='" + Autor + "']/../..//div[text()='Cancelado']/../..//div[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            Assert.AreNotEqual(itemAPagar, itemCancelado);
        }

        public void ValidarCompositorAntigoCancelado(string NovoCompositor)
        {
            switch (NovoCompositor)
            {
                case "Autor":
                    {
                        NovoCompositor = CadastrarObraEComposicaoPage.Autor;
                        var itemCancelado = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='Cancelado']/../..//td[9]"), Browser);
                        Assert.AreNotEqual(NovoCompositor, itemCancelado);
                        break;
                    }
                case "Autor2":
                    {
                        NovoCompositor = CadastrarObraEComposicaoPage.Autor2;
                        var itemCancelado = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='Cancelado']/../..//td[9]"), Browser);
                        Assert.AreNotEqual(NovoCompositor, itemCancelado);
                        break;
                    }
                default:
                    {
                        var itemCancelado = ElementExtensions.GetValorCss(Element.Xpath("//table[@id='tablePagamento']//div[text()='Cancelado']/../..//td[9]"), Browser);
                        Assert.AreNotEqual(NovoCompositor, itemCancelado);
                        break;
                    }
            }
        }

        public void ValidarStatusAutorizacaoNaTelaDeBusca(string Status, string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//table[@id='tableAutorizacao']//*[text()='" + Autor + "']/../..//div[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                case "Autor2":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor2;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//table[@id='tableAutorizacao']//*[text()='" + Autor + "']/../..//div[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                default:
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//table[@id='tableAutorizacao']//*[text()='" + Autor + "']/../..//div[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
            }
        }

        public void ValidarStatusPagamentoNaTelaDeBusca(string Status, string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//table[@id='tablePagamento']//*[text()='" + Autor + "']/../..//div[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus, "Autor ou status não encontrados!");
                        break;
                    }
                case "Autor2":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor2;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//table[@id='tablePagamento']//*[text()='" + Autor + "']/../..//div[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus, "Autor ou status não encontrados!");
                        break;
                    }
                default:
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//table[@id='tablePagamento']//*[text()='" + Autor + "']/../..//div[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus, "Autor ou status não encontrados!");
                        break;
                    }
            }
        }

        public void SelecionarUmItemDePedidoAutorizacaoNaTelaDeBusca(string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        var item = Element.Xpath("//table[@id='tableAutorizacao']//*[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                case "Autor2":
                    {
                        var item = Element.Xpath("//table[@id='tableAutorizacao']//*[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                default:
                    {
                        var item = Element.Xpath("//table[@id='tableAutorizacao']//*[text()='" + Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
            }

        }

        public void SelecionarUmItemDePedidoPagamentoNaTelaDeBusca(string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        var item = Element.Xpath("//table[@id='tablePagamento']//*[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                case "Autor2":
                    {
                        var item = Element.Xpath("//table[@id='tablePagamento']//*[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
                default:
                    {
                        var item = Element.Xpath("//table[@id='tablePagamento']//*[text()='" + Autor + "']");
                        MouseActions.ClickATM(Browser, item);
                        break;
                    }
            }
        }

        public void ValidarDadosNaoEncontrados(string Mensagem)
        {
            var dadosNaoEncontrados = Element.Xpath("//table[@id='tablePedido']//tbody//td[contains (., '" + Mensagem + "')]");
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

        public void ValidarDadosNaAbaDePedido(string Valor)
        {
            var dadosAbaPedido = Element.Xpath("//table[@id='tablePedido']//tbody//div[contains (., '" + Valor + "')]");
            try
            {
                Assert.IsTrue(ElementExtensions.IsClickable(dadosAbaPedido, Browser), "O " + Valor + " não foi encontrado!");
            }
            catch
            {
                ElementExtensions.EsperarElemento(dadosAbaPedido, Browser);
                Assert.IsTrue(ElementExtensions.IsElementVisible(dadosAbaPedido, Browser), "O " + Valor + " não foi encontrado!");
            }
        }

        public void ValidarHistoricoDePedido()
        {
            var BtnHistoricoPedido = Element.Css("a[ng-click='AbrirHistoricoConsulta()']");
            MouseActions.ClickATM(Browser, BtnHistoricoPedido);

            var nomeUsuarioLogado = ElementExtensions.GetTexto(Element.Css("li[class='nav-header'] span:nth-child(1)"), Browser);
            var nomeUsuarioNoHistorico = ElementExtensions.GetTexto(Element.Css("div[role='tablist'] div[ng-repeat='item in ListJSON']:nth-child(1) b:nth-child(1)"), Browser);
            Assert.AreEqual(nomeUsuarioLogado, nomeUsuarioNoHistorico);
        }

        public void ValidarDadosDePedidoAbaPagamentoDetalhes(string Valor)
        {
            var textoCampo = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[contains(., '" + Valor + "')]");
            ElementExtensions.IsElementVisible(textoCampo, Browser);
        }

        public void ValidarDadosDePedidoAbaAutorizacaoDetalhes(string Valor)
        {
            var textoCampo = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//td[contains(., '" + Valor + "')]");
            ElementExtensions.IsElementVisible(textoCampo, Browser);
        }

        public void PagarAoAdministrador(string Confirmar)
        {
            var BtnPagarAdministrador = Element.Css("a[ng-click='ValidaInformarPagamentoAoAdministrador()']");
            ElementExtensions.IsElementVisible(BtnPagarAdministrador, Browser);
            MouseActions.ClickATM(Browser, BtnPagarAdministrador);

            ValidarMensagemDeAlerta("Os itens selecionados serão alterados, informando que o pagamento será realizado para o administrador e não mais ao DDA. Deseja prosseguir?");

            var BtnConfirmar = Element.Css("button[class='confirm']");
            var BtnCancelar = Element.Css("button[class='cancel']");

            if (Confirmar == "Sim")
                MouseActions.ClickATM(Browser, BtnConfirmar);
            if (Confirmar == "Não")
                MouseActions.ClickATM(Browser, BtnCancelar);
        }

        public void ValidarPopupSucesso(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            Thread.Sleep(2000);
            if (Mensagem != "")
            {
                Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));
                Thread.Sleep(2000);
            }
            else
            {
                Assert.IsTrue(ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser));
                Thread.Sleep(2000);
            }
        }

        public void ValidarStatusDePedido(string Status)
        {
            Browser.RefreshPage();
            var textStatus = Element.Xpath("//b[contains(., '" + Status + "')]");
            ElementExtensions.IsElementVisible(textStatus, Browser);
        }

        public void ValidarRelatorioDePagamento()
        {
            var linkRelatorio = Element.Css("a[ng-click='GerarRelatorioPedidoPagamento()']");
            MouseActions.ClickATM(Browser, linkRelatorio);

            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + "PedidoPagamento" + ".xlsx";

            File.Delete(originalFileName);
        }
    }
}
