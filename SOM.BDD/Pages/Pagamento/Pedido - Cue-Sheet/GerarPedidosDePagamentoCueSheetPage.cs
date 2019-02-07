﻿using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System;
using Framework.Core.Extensions.ElementExtensions;
using System.Threading;
using Framework.Core.Helpers;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.Obra;

namespace SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet
{
    public class GerarPedidosDePagamentoCueSheetPage : PageBase
    {
        private string ConsultaDeCueSheetUrl { get; }

        private string DetalheDaCueSheetUrl { get; }

        private string PageTitle => "SOM | Cue-Sheet";

        private string PageTitleDetalheDaCueSheet => "SOM | Detalhe Cue-Sheet";

        //Adicionar novo item de cue-sheet
        private Element BtnAdicionarItemCueSheet { get; }
        private Element BtnOpenObraFonograma { get; }
        private Element BtnSalvarItemCueSheet { get; }
        private Element InpTituloObra { get; }
        private Element SlctUtilizacao { get; }
        private Element SlctSincronismo { get; }
        private Element InpTempo { get; }
        private Element InpInterprete { get; }

        //Cadastro de Interprete
        public Element BtnCadastrarInterprete { get; private set; }
        public Element InpNomeInterprete { get; private set; }
        public Element BtnSalvarCadastroDeInterprete { get; private set; }

        //Gerar pedido
        private Element BtnAprovarItens { get; }
        private Element BtnGerarPedidos { get; }
        private Element BtnSalvarPedidos { get; }

        //Pop up mensagem de status
        private Element PopUpStatus { get; }

        //Excluir item cue-sheet
        private Element BtnExcluirItemCueSheet { get; }
        private Element BtnConfirmarExclusao { get; }

        //Alterar item aprovado de cue-sheet
        private Element BtnRevogarAprovacao { get; }

        //Icones
        private Element IconObservacao { get; }
        private Element IconPedido { get; }

        private Element BtnVoltarListaCueSheet { get; }
        

        public GerarPedidosDePagamentoCueSheetPage(IBrowser browser, string consultaDeCueSheetUrl, string detalheDaCueSheetUrl) : base(browser)
        {
            ConsultaDeCueSheetUrl = consultaDeCueSheetUrl;
            DetalheDaCueSheetUrl = detalheDaCueSheetUrl;

            //Adicionar novo item de cue-sheet
            BtnAdicionarItemCueSheet = Element.Css("a[ng-click='AdicionarItemCueSheet()']");
            BtnOpenObraFonograma = Element.Css("button[ng-click='OpenObraFonogramaModal()']");
            BtnSalvarItemCueSheet = Element.Css("a[ng-click='salvarItemCueSheet()']");
            InpTituloObra = Element.Css("input[ng-model='ItemCueSheetDados.TituloObra']");
            SlctUtilizacao = Element.Css("div[ng-model='ItemCueSheetDados.TipoUtilizacaoSelected'] i[class='caret pull-right']");
            SlctSincronismo = Element.Css("div[ng-model='ItemCueSheetDados.TipoSincronismoSelected'] i[class='caret pull-right']");
            InpTempo = Element.Css("input[id='tempo']");
            InpInterprete = Element.Css("input[id='novoAutoComplete']");

            //Cadastro de Interprete
            BtnCadastrarInterprete = Element.Css("button[ng-click='CadastrarInterprete()']");
            InpNomeInterprete = Element.Css("input[ng-model='Interprete.Nome']");
            BtnSalvarCadastroDeInterprete = Element.Css("button[ng-click='cadastrarInterprete()']");

            //Gerar pedido
            BtnAprovarItens = Element.Css("a[ng-click='AprovarItens()']");
            BtnGerarPedidos = Element.Css("a[ng-click='gerarPedido()']");
            BtnSalvarPedidos = Element.Css("a[ng-click='salvarPedido()']");

            //Pop up mensagem de status
            PopUpStatus = Element.Css("div[class='ng-binding ng-scope']");

            //Excluir item cue-sheet
            BtnExcluirItemCueSheet = Element.Css("a[ng-click='ExcluirItens()']");
            BtnConfirmarExclusao = Element.Css("button[class='confirm']");

            //Alterar item aprovado de cue-sheet
            BtnRevogarAprovacao = Element.Css("a[ng-click='RevogarItens()']");

            //Icones
            IconObservacao = Element.Css("i[class='fa fa-info']");
            IconPedido = Element.Css("span i[class='fa fa-paypal']");

            BtnVoltarListaCueSheet = Element.Css("a[ng-click='voltarListaDetalheCueSheet()']");
        }

        public override void Navegar()
        {
            Browser.Abrir(ConsultaDeCueSheetUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }
        
        public void NavegarTelaDePedidoCueSheet()
        {
            Browser.RefreshPage();
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnGerarPedidos);
            Assert.IsTrue(Browser.PageSource("SOM | Gerar Pedido Cue-Sheet"));
        }

        public void ValidarItemCueSheetRandomicoCadastrado(string Titulo, string Tempo, string Utilizacao, string Sincronismo, string Pedido)
        {
            Titulo = CadastrarObraEComposicaoPage.Obra;

            ValidarPedidoCadastrado(Titulo, Tempo, Utilizacao, Sincronismo, Pedido);
        }

        public void ValidarPedidoCadastrado(string Titulo, string Tempo, string Utilizacao, string Sincronismo, string Pedido)
        {
            Thread.Sleep(1500);
            var tr = 1;

            try
            {
                tr = Validacao(Titulo, Tempo, Utilizacao, Sincronismo, Pedido, tr);
            }
            catch
            {
                tr = Validacao(Titulo, Tempo, Utilizacao, Sincronismo, Pedido, tr);
                //throw new ArgumentException("O item não existe na cue-sheet.");
            }

        }

        private int Validacao(string Titulo, string Tempo, string Utilizacao, string Sincronismo, string Pedido, int tr)
        {
            while (tr <= 10)
            {
                var valorTitulo = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]/td[3]"), "textContent", Browser);
                var valorTempo = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]/td[8]"), "textContent", Browser);
                var valorUtilizacao = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]/td[10]"), "textContent", Browser);
                var valorSincronismo = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]/td[11]"), "textContent", Browser);
                var valorPedido = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]/td[12]//span[1]"), "textContent", Browser);

                if (Titulo == valorTitulo)
                {
                    if (valorTempo == Tempo)
                    {
                        if (valorUtilizacao == Utilizacao)
                        {
                            if (valorSincronismo == Sincronismo)
                            {
                                Assert.AreEqual(Titulo, valorTitulo);
                                Assert.AreEqual(Tempo, valorTempo);
                                Assert.AreEqual(Utilizacao, valorUtilizacao);
                                Assert.AreEqual(Sincronismo, valorSincronismo);

                                if (Pedido == "Sim")
                                {
                                    Thread.Sleep(1500);
                                    ElementExtensions.IsElementVisible(Element.Xpath("//tr[" + tr + "]/td[12]//a"), Browser);
                                }
                                tr = 11;
                            }
                        }
                    }

                }
                tr = tr + 1;
            }

            return tr;
        }

        private void SelecionarObraFonograma(string Fonograma, string TituloObra)
        {
            MouseActions.ClickATM(Browser, BtnOpenObraFonograma);
            if (Fonograma != "")
                MouseActions.DoubleClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarFonograma(item)']/td[text()='" + Fonograma + "']"));
            if(TituloObra != "")
                MouseActions.DoubleClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarObra(item)']/td[text()='" + TituloObra + "']"));
        }

        private void SelecionarObra(string TituloObra, string AutorDDA)
        {
            MouseActions.ClickATM(Browser, BtnOpenObraFonograma);
            if (TituloObra != "")
            {
                var element = Element.Xpath("//td[text()='" + TituloObra + "']/..//span[contains(., '" + AutorDDA + "')][@class='ng-scope']");
                MouseActions.DoubleClickATM(Browser, element);
            }
        }

        private void SelecionarUtilizacao(string Utilizacao)
        {
            MouseActions.ClickATM(Browser, SlctUtilizacao);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/div[text()='" + Utilizacao + "']"));
        }

        private void SelecionarSincronismo(string Sincronismo)
        {
            MouseActions.ClickATM(Browser, SlctSincronismo);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/div[text()='" + Sincronismo + "']"));
        }

        private void SelecionarInterprete(string Interprete)
        {
            AutomatedActions.SendDataATM(Browser, InpInterprete, Interprete);
            MouseActions.ClickATM(Browser, Element.Xpath("//li[text()='" + Interprete + "']"));
        }

        public void CadasTrarItemCueSheetRandomico(string TituloObra, string Utilizacao, string Sincronismo, string Tempo, string Interprete)
        {
            TituloObra = CadastrarObraEComposicaoPage.Obra;

            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnAdicionarItemCueSheet);

            AutomatedActions.SendData(Browser, InpTituloObra, TituloObra);
            SelecionarObraFonograma("", TituloObra);
            SelecionarUtilizacao(Utilizacao);
            SelecionarSincronismo(Sincronismo);
            AutomatedActions.SendData(Browser, InpTempo, Tempo);

            MouseActions.ClickATM(Browser, BtnCadastrarInterprete);
            AutomatedActions.SendDataATM(Browser, InpNomeInterprete, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeInterprete);
            Thread.Sleep(2000);

            try
            {
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
            }
            catch
            {
                Thread.Sleep(2000);
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
            }

            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemCueSheet, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemCueSheet, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
            }

            Assert.IsTrue(ElementExtensions.IsElementVisible(PopUpStatus, Browser));
        }

        public void CadastrarItemCueSheet(string TituloObra, string Utilizacao, string Sincronismo, string Tempo)
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnAdicionarItemCueSheet);
            
            AutomatedActions.SendData(Browser, InpTituloObra, TituloObra);
            SelecionarObraFonograma("", TituloObra);
            SelecionarUtilizacao(Utilizacao);
            SelecionarSincronismo(Sincronismo);
            AutomatedActions.SendData(Browser, InpTempo, Tempo);

            MouseActions.ClickATM(Browser, BtnCadastrarInterprete);
            AutomatedActions.SendDataATM(Browser, InpNomeInterprete, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeInterprete);
            Thread.Sleep(2000);

            try
            {
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
            }
            catch
            {
                Thread.Sleep(2000);
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
            }

            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemCueSheet, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemCueSheet, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
            }

            Assert.IsTrue(ElementExtensions.IsElementVisible(PopUpStatus, Browser));
            //Assert.AreEqual("Registro salvo com sucesso.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
        }

        public void GerarPedidoParaItemCueSheet(string Valor)
        {
            MouseActions.ClickATM(Browser, Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']"));
            MouseActions.ClickATM(Browser, BtnAprovarItens);
            Assert.AreEqual("Item aprovado com sucesso.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
            MouseActions.ClickATM(Browser, BtnGerarPedidos);
        }

        public void ValidarItemAprovadoEGerarPedido(string Titulo, string Tempo, string Tipo, string Modaidade, string Sincronismo, string Selecionada)
        {
            var linhaSelecionada = "";
            if(Selecionada == "Sim")
            {
                linhaSelecionada = " selected";
                Assert.AreEqual(Titulo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Titulo + "']"), "textContent", Browser));
                Assert.AreEqual(Tempo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Tempo + "']"), "textContent", Browser));
                Assert.AreEqual(Tipo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Tipo + "']"), "textContent", Browser));
                Assert.AreEqual(Modaidade, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Modaidade + "']"), "textContent", Browser));
                Assert.AreEqual(Sincronismo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Sincronismo + "']"), "textContent", Browser));
            }
            else
            {
                Assert.AreEqual(Titulo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Titulo + "']"), "textContent", Browser));
                Assert.AreEqual(Tempo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Tempo + "']"), "textContent", Browser));
                Assert.AreEqual(Tipo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Tipo + "']"), "textContent", Browser));
                Assert.AreEqual(Modaidade, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Modaidade + "']"), "textContent", Browser));
                Assert.AreEqual(Sincronismo, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Sincronismo + "']"), "textContent", Browser));

                MouseActions.ClickATM(Browser, Element.Xpath("//tr[@class='ng-scope" + linhaSelecionada + "']/td[text()='" + Titulo + "']"));
            }

            MouseActions.ClickATM(Browser, BtnSalvarPedidos);
        }

        public void ExcluirItemCueSheet(string Valor)
        {
            try
            {
                Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']").IsElementVisible(Browser);
                MouseActions.ClickATM(Browser, Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']"));
            }
            catch
            {
                Thread.Sleep(2000);
                Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']").IsElementVisible(Browser);
                MouseActions.ClickATM(Browser, Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']"));
            }
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnExcluirItemCueSheet);
            Assert.IsTrue(ElementExtensions.IsElementVisible(Element.Xpath("//h2[contains (., 'Exclusão de Item de Cue-Sheet')]"), Browser));
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            Thread.Sleep(1500);
            Assert.AreEqual("Registros excluídos com sucesso.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
        }

        public void SelecionarItemAAlterar(string Valor)
        {
            MouseActions.DoubleClickATM(Browser, Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']"));
            Thread.Sleep(1500);
            ElementExtensions.IsElementVisible(BtnRevogarAprovacao, Browser);
            MouseActions.ClickATM(Browser, BtnRevogarAprovacao);
            Assert.AreEqual("A aprovação foi revogada e o item liberado para edição.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
            MouseActions.DoubleClickATM(Browser, Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']"));
        }

        public void CadastrarNovoInterprete()
        {
            CadastroDeInterprete();

            try
            {
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
                MouseActions.ClickATM(Browser, interprete);
            }
            catch
            {
                Thread.Sleep(2000);
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
                MouseActions.ClickATM(Browser, interprete);
            }

            MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
        }

        public void AlterarItemDeCueSheetRandomico(string TituloObra, string Utilizacao, string Sincronismo, string Tempo)
        {
            if (TituloObra == "Aleatório")
            {
                TituloObra = CadastrarObraEComposicaoPage.Obra;
                PreencherItemDeCueSheetObra(TituloObra, Utilizacao, Sincronismo, Tempo);
            }
            else
                PreencherItemDeCueSheetObra(TituloObra, Utilizacao, Sincronismo, Tempo);

            MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
        }

        public void AlterarItemDeCueSheet(string TituloObra, string Utilizacao, string Sincronismo, string Tempo)
        {
            PreencherItemDeCueSheet(TituloObra, Utilizacao, Sincronismo, Tempo);

            MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
        }

        private void PreencherItemDeCueSheetObra(string TituloObra, string Utilizacao, string Sincronismo, string Tempo)
        {
            if (TituloObra != "")
                AutomatedActions.SendDataATM(Browser, InpTituloObra, TituloObra);
            if (TituloObra != "")
                SelecionarObraFonograma("", TituloObra);
            if (Utilizacao != "")
                SelecionarUtilizacao(Utilizacao);
            if (Sincronismo != "")
                SelecionarSincronismo(Sincronismo);
            if (Tempo != "")
                AutomatedActions.SendData(Browser, InpTempo, Tempo);
        }

        private void PreencherItemDeCueSheet(string TituloObra, string Utilizacao, string Sincronismo, string Tempo)
        {
            if (TituloObra != "")
                AutomatedActions.SendDataATM(Browser, InpTituloObra, TituloObra);
            if (TituloObra != "")
                SelecionarObraFonograma(TituloObra, "");
            if (Utilizacao != "")
                SelecionarUtilizacao(Utilizacao);
            if (Sincronismo != "")
                SelecionarSincronismo(Sincronismo);
            if (Tempo != "")
                AutomatedActions.SendData(Browser, InpTempo, Tempo);
        }

        public void AprovarItemDeCueSheet(string Valor)
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, Element.Xpath("//td[@class='Bloco Materia'][text()='" + Valor + "']"));
            MouseActions.ClickATM(Browser, BtnAprovarItens);
            Assert.AreEqual("Item aprovado com sucesso.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
        }

        public void NavegarTelaDegeracaoDePedidos()
        {
            Browser.RefreshPage();
            Thread.Sleep(1500);
            ElementExtensions.IsElementVisible(BtnGerarPedidos, Browser);
            MouseActions.ClickATM(Browser, BtnGerarPedidos);
            Assert.IsTrue(Browser.PageSource("SOM | Gerar Pedido Cue-Sheet"));
        }

        public void VoltarParaListaCueSheet()
        {
            Thread.Sleep(2000);
            ElementExtensions.IsElementVisible(BtnVoltarListaCueSheet, Browser);
            MouseActions.ClickATM(Browser, BtnVoltarListaCueSheet);
            Thread.Sleep(2000);
        }

        public void GerarPedidoParaItemDeCueSheet(string Selecionar, string Valor, string Salvar)
        {
            NavegarTelaDegeracaoDePedidos();
            Thread.Sleep(1500);
            if (Selecionar == "Sim")
            {
                MouseActions.ClickATM(Browser, Element.Xpath("//td[text()='" + Valor + "']"));                
            }
            if(Salvar == "Sim")
                MouseActions.ClickATM(Browser, BtnSalvarPedidos);
            Assert.AreEqual("Pedidos gerados com sucesso.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
            Thread.Sleep(2000);
        }

        public void ValidarPedidoNaTelaDePedido(string Titulo, string Tempo, string Tipo, string Modaidade, string Sincronismo, string Selecionada)
        {
            var linhaSelecionada = "";
            if (Selecionada == "Sim")
            {
                linhaSelecionada = " selected";
                ValidarLinha(Titulo, linhaSelecionada);
                ValidarLinha(Tempo, linhaSelecionada);
                ValidarLinha(Tipo, linhaSelecionada);
                ValidarLinha(Modaidade, linhaSelecionada);
                ValidarLinha(Sincronismo, linhaSelecionada);
            }
            else
            {
                ValidarLinha(Titulo, linhaSelecionada);
                ValidarLinha(Tempo, linhaSelecionada);
                ValidarLinha(Tipo, linhaSelecionada);
                ValidarLinha(Modaidade, linhaSelecionada);
                ValidarLinha(Sincronismo, linhaSelecionada);
            }
        }

        private void ValidarLinha(string Valor, string Valor2)
        {
            if(Valor != "")
                Assert.AreEqual(Valor, ElementExtensions.GetValorAtributo(Element.Xpath("//tr[@class='ng-scope" + Valor2 + "']/td[text()='" + Valor + "']"), "textContent", Browser));
        }

        public void ValidarIconObservacao()
        {
            Assert.IsTrue(ElementExtensions.IsElementVisible(IconObservacao, Browser));
        }

        public void ValidarIconPedido()
        {
            Assert.IsTrue(ElementExtensions.IsElementVisible(IconPedido, Browser));
        }

        public void CadastroDeInterprete()
        {
            MouseActions.ClickATM(Browser, Element.Css("button[ng-click='CadastrarInterprete()']"));
            AutomatedActions.SendDataATM(Browser, InpNomeInterprete, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeInterprete);
            Thread.Sleep(2000);
        }

        public void NavegarPara(string Link)
        {
            string linkCueSheet = "http://jbhbftssr004:8080/som/#/usoReporte/Detalhe/" + Link + "";
            Browser.Abrir(linkCueSheet);
            Assert.IsTrue(Browser.PageSource(PageTitleDetalheDaCueSheet));
        }

        public void CadastrarItemCueSheetSemFonograma(string TituloObra, string Utilizacao, string Sincronismo, string Tempo, string Interprete, string AutorDDA)
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnAdicionarItemCueSheet);

            AutomatedActions.SendData(Browser, InpTituloObra, TituloObra);
            SelecionarObra(TituloObra, AutorDDA);
            SelecionarUtilizacao(Utilizacao);
            SelecionarSincronismo(Sincronismo);
            SelecionarInterprete(Interprete);
            AutomatedActions.SendData(Browser, InpTempo, Tempo);

            MouseActions.ClickATM(Browser, BtnSalvarItemCueSheet);
            Assert.AreEqual("Registro salvo com sucesso.", ElementExtensions.GetValorAtributo(PopUpStatus, "textContent", Browser));
        }

    }
}
