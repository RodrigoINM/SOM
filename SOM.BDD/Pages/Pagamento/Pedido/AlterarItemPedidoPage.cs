using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System;
using Framework.Core.Extensions.ElementExtensions;
using System.Threading;
using Framework.Core.Helpers;
using SOM.BDD.Pages.Obra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOM.BDD.Pages.Produto;

namespace SOM.BDD.Pages.Pagamento.Pedido
{
    public class AlterarItemPedidoPage : PageBase
    {
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        //Edição de item de pedido
        public Element InpValorPagamento { get; private set; }
        public Element SlctMoeda { get; private set; }
        public Element InpTaxaConversao { get; private set; }
        public Element BtnSalvarEdicaoPedido { get; private set; }

        //Registrar autorização
        public Element BtnRegistrarAutorizacao { get; private set; }
        public Element BtnConfirmar { get; private set; }
        public Element BtnCancelar { get; private set; }

        //Realizar pagamento
        public Element BtnRealizarPagamento { get; private set; }
        public Element BtnRegistrarPagamentoAoAdiministrador { get; private set; }
        public Element BtnRemoverPagamentoAoAdministrador { get; private set; }
        public Element BtnCancelarItemDePedido { get; private set; }
        public Element TextJustificativa { get; private set; }
        public Element BtnSalvarJustificativa { get; private set; }

        public Element BtnAdicionarDNI { get; private set; }
        public Element BtnEnviarAutorizacao { get; private set; }
        

        public AlterarItemPedidoPage(IBrowser browser) : base(browser)
        {
            //Edição de item de pedido
            InpValorPagamento = Element.Css("input[ng-model='ItemPedidoDados.Valor']");
            SlctMoeda = Element.Css("select[ng-model='ItemPedidoDados.Moeda']");
            InpTaxaConversao = Element.Css("input[ng-model='ItemPedidoDados.TaxaDeConversao']");
            BtnSalvarEdicaoPedido = Element.Css("button[uib-tooltip='Salvar']");

            //Registrar autorização
            BtnRegistrarAutorizacao = Element.Css("a[uib-tooltip='Registrar Autorizacao']");
            BtnConfirmar = Element.Css("button[class='confirm']");
            BtnCancelar = Element.Css("button[class='cancel']");

            //Realizar pagamento
            BtnRealizarPagamento = Element.Css("a[uib-tooltip='Realizar Pagamento']");
            BtnRegistrarPagamentoAoAdiministrador = Element.Css("a[uib-tooltip='Registrar pagamento ao Administrador']");
            BtnRemoverPagamentoAoAdministrador = Element.Css("a[uib-tooltip='Remover registro de pagamento ao Administrador']");
            BtnCancelarItemDePedido = Element.Css("div[class='tab-pane ng-scope active'] a[uib-tooltip='Cancelar itens de pedido']");
            TextJustificativa = Element.Css("textarea[ng-model='ItemPedidoDados.Justificativa']");
            BtnSalvarJustificativa = Element.Css("button[ng-click='SalvarCancelamentoPedido()']");

            BtnAdicionarDNI = Element.Css("a[uib-tooltip='Cadastrar Itens DNI']");
            BtnEnviarAutorizacao = Element.Css("a[uib-tooltip='Enviar Autorização']");
        }

        public override void Navegar()
        {
            throw new NotImplementedException();
        }

        private void SelecionarMoedaPedido(string Valor)
        {
            if(Valor != "" && Valor != " ")
                MouseActions.SelectElementATM(Browser, SlctMoeda, Valor);
        }

        public void SelecionarItemParaEditar(string Valor)
        {
            //var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + CadastrarObraEComposicaoPage.Autor + "']");
            var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Valor + "']");
            MouseActions.DoubleClickATM(Browser, item);
        }

        public void EditarItemDePedido(string ValorPagamento, string Moeda, string TaxaConversao, string Autor)
        {
            SelecionarItemParaEditar(Autor);
            KeyboardActions.ShiftHome(Browser, InpValorPagamento);
            KeyboardActions.Backspace(Browser, InpValorPagamento);
            AutomatedActions.SendData(Browser, InpValorPagamento, ValorPagamento);
            SelecionarMoedaPedido(Moeda);
            KeyboardActions.ShiftHome(Browser, InpTaxaConversao);
            KeyboardActions.Backspace(Browser, InpTaxaConversao);
            AutomatedActions.SendData(Browser, InpTaxaConversao, TaxaConversao);
        }

        public void SalvarEdicaoPedido()
        {
            MouseActions.ClickATM(Browser, BtnSalvarEdicaoPedido);
        }

        public void ValidarValorTotalUmItemSelecionado(string Valor, string Autor)
        {
            var itemSelecionado = ElementExtensions.GetValorCss(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/..//td[contains (., 'R$')]"), Browser).Replace("R$ ", "");
            var valorTotal = ElementExtensions.GetValorCss(Element.Css("label"), Browser).Replace("Valor Total: R$ ", "");
            Assert.AreEqual(valorTotal, Valor);
        }

        public void EnviarAutorizacao()
        {
            try
            {
                MouseActions.ClickATM(Browser, BtnEnviarAutorizacao);
                PopupRealizarPagamento("Sim");
            }
            catch
            {
                MouseActions.ClickATM(Browser, BtnEnviarAutorizacao);
                PopupRealizarPagamento("Sim");
            }
            Browser.RefreshPage();
            Thread.Sleep(2000);
        }


        public void RegistrarAutorizacaoDeItem(string Autor)
        {
            var item = Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//td[text()='" + Autor + "']");
            MouseActions.ClickATM(Browser, item);
            Thread.Sleep(2000);
            try
            {
                MouseActions.ClickATM(Browser, BtnRegistrarAutorizacao);
            }
            catch
            {
                MouseActions.ClickATM(Browser, BtnRegistrarAutorizacao);
            }
        }

        public void ValidarPopupAutorizacaoDDA(string DDA, string Confirmar)
        {
            if(DDA != "" && DDA != " ")
            {
                var textoPopup = ElementExtensions.IsElementVisible(Element.Xpath("//p[@style='display: block;'][contains (., '" + DDA + "')]"), Browser);
                Assert.IsTrue(textoPopup);
                Thread.Sleep(2000);
            }
            else
            {
                var textoPopup = ElementExtensions.IsElementVisible(Element.Xpath("//p[@style='display: block;']"), Browser);
                Assert.IsTrue(textoPopup);
                Thread.Sleep(2000);
            }

            if (Confirmar == "Sim")
            {
                ElementExtensions.IsElementVisible(BtnConfirmar, Browser);
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnConfirmar);
            }
        }

        public void ValidarPopupSucesso(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            Thread.Sleep(2000);
            if(Mensagem != "")
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

        public void ValidarStatusAutorizacao(string Status, string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//td[text()='" + CadastrarObraEComposicaoPage.Autor + "']/../..//span[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                case "Autor2":
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//td[text()='" + CadastrarObraEComposicaoPage.Autor2 + "']/../..//span[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                default:
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropAutorizacao.lists']//td[text()='" + Autor + "']/../..//span[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
            }
        }

        public void ValidarStatusPagamento(string Status, string Autor)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/../..//span[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                case "Autor2":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor2;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/../..//span[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                default:
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/../..//span[contains (., '" + Status + "')]"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
            }
        }

        public void ValidarPagamentoAoAdministrador(string Autor, string PagamentoAdministrador)
        {
            switch (Autor)
            {
                case "Autor":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/../..//td[text()='" + PagamentoAdministrador + "']"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                case "Autor2":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor2;
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/../..//td[text()='" + PagamentoAdministrador + "']"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
                default:
                    {
                        var textoStatus = ElementExtensions.IsElementVisible(Element.Xpath("//tbody[@dnd-list='PedidoDadosDragDropPagamento.lists']//td[text()='" + Autor + "']/../..//td[text()='" + PagamentoAdministrador + "']"), Browser);
                        Assert.IsTrue(textoStatus);
                        break;
                    }
            }
            
        }

        public void RealizarPagamento()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnRealizarPagamento);
        }

        public void PopupRealizarPagamento(string Confirmar)
        {
            try
            {
                var textoPopup = ElementExtensions.IsElementVisible(Element.Xpath("//p[@style='display: block;']"), Browser);
                Assert.IsTrue(textoPopup);
                Thread.Sleep(2000);
            }
            catch
            {
                var textoPopup = ElementExtensions.IsElementVisible(Element.Xpath("//p[@style='display: block;']"), Browser);
                Assert.IsTrue(textoPopup);
                Thread.Sleep(2000);
            }

            if(Confirmar == "Sim")
            {
                ElementExtensions.IsElementVisible(BtnConfirmar, Browser);
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnConfirmar);
            }
        }

        public void ValidarCamposBloqueadosParaEdicao()
        {
            Thread.Sleep(2000);
            var inpValorPagamento = Element.Css("input[ng-model='ItemPedidoDados.Valor'][disabled='disabled']");
            var slctMoeda = Element.Css("select[ng-model='ItemPedidoDados.Moeda'][disabled='disabled']");
            var inpTaxaDeConversao = Element.Css("input[ng-model='ItemPedidoDados.TaxaDeConversao'][disabled='disabled']");

            Assert.IsTrue(ElementExtensions.IsClickable(inpValorPagamento, Browser), "Campo de valor de pagamento não está visivel.");
            Assert.IsTrue(ElementExtensions.IsClickable(slctMoeda, Browser));
            Assert.IsTrue(ElementExtensions.IsClickable(inpTaxaDeConversao, Browser));
        }

        public void PagarAoAdministrador()
        {
            ElementExtensions.IsElementVisible(BtnRegistrarPagamentoAoAdiministrador, Browser);
            MouseActions.ClickATM(Browser, BtnRegistrarPagamentoAoAdiministrador);
        }

        public void RemoverPagamentoAoAdministrador()
        {
            ElementExtensions.IsElementVisible(BtnRemoverPagamentoAoAdministrador, Browser);
            MouseActions.ClickATM(Browser, BtnRemoverPagamentoAoAdministrador);
        }

        public void CancelarItemDePedido()
        {
            ElementExtensions.IsElementVisible(BtnCancelarItemDePedido, Browser);
            MouseActions.ClickATM(Browser, BtnCancelarItemDePedido);

            AutomatedActions.SendData(Browser, TextJustificativa, "Teste");
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarJustificativa);
        }

        public void ValidarPopupItemCancelado(string Mensagem)
        {
            var Popup = Element.Css("div[ng-switch-when='trustedHtml']");
            var textoPopup = ElementExtensions.GetValorCss(Popup, Browser).Replace("Total de itens cancelados: 1Total de itens não cancelados: 0", Mensagem);
            Assert.AreEqual(Mensagem, textoPopup);
        }

        public void AdicionarDNI()
        {
            ElementExtensions.IsElementVisible(BtnAdicionarDNI, Browser);
            MouseActions.ClickATM(Browser, BtnAdicionarDNI);

            PopupRealizarPagamento("Sim");
        }

        public void ConsultaDePedido(string Valor)
        {
            var filtro = Element.Css("a[ng-click='ShowHideFiltro()']");
            try
            {
                ElementExtensions.IsElementVisible(filtro, Browser);
                MouseActions.ClickATM(Browser, filtro);
            }
            catch
            {
                ElementExtensions.IsElementVisible(filtro, Browser);
                MouseActions.ClickATM(Browser, filtro);
            }
            if(Valor == "Obra")
                ConsultaDePedidoPorObra(Valor);
            if (Valor == "Produto")
                ConsultaDePedidoPorProduto(Valor);
            var slctStatusPagamento = Element.Css("select[ng-model='PedidoFiltros.StatusPagamento']");
            MouseActions.SelectElementATM(Browser, slctStatusPagamento, "Todos");
            MouseActions.ClickATM(Browser, Element.Css("button[uib-tooltip='Pesquisar']"));
        }

        private void ConsultaDePedidoPorProduto(string Produto)
        {
            var InpConsultaProduto = Element.Css("input[ng-model='PedidoFiltros.DscProduto']");
            ElementExtensions.IsElementVisible(InpConsultaProduto, Browser);
            if (Produto == "Produto")
            {
                AutomatedActions.SendDataATM(Browser, InpConsultaProduto, CadastroDeProdutoPage.Produto);
                MouseActions.ClickATM(Browser, Element.Xpath("//strong[text()='" + CadastroDeProdutoPage.Produto + "']"));
            }
            else
            {
                AutomatedActions.SendDataATM(Browser, InpConsultaProduto, Produto);
                MouseActions.ClickATM(Browser, Element.Xpath("//strong[text()='" + Produto + "']"));
            }
        }

        private void ConsultaDePedidoPorObra(string Obra)
        {
            var InpConsultaObra = Element.Css("input[ng-model='PedidoFiltros.Obra']");
            ElementExtensions.IsElementVisible(InpConsultaObra, Browser);
            if (Obra == "Obra")
            {
                AutomatedActions.SendDataATM(Browser, InpConsultaObra, CadastrarObraEComposicaoPage.Obra);
                MouseActions.ClickATM(Browser, Element.Xpath("//strong[text()='" + CadastrarObraEComposicaoPage.Obra + "']"));
            }
            else
            {
                AutomatedActions.SendDataATM(Browser, InpConsultaObra, Obra);
                MouseActions.ClickATM(Browser, Element.Xpath("//strong[text()='" + Obra + "']"));
            }
        }

        public void AcessarPedido()
        {
            var pedido = Element.Xpath("//table[@id='tablePedido']//div[text()='" + CadastrarObraEComposicaoPage.Obra + "']");
            ElementExtensions.IsElementVisible(pedido, Browser);
            MouseActions.DoubleClickATM(Browser, pedido);
        }

    }
}
