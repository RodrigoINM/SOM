using Framework.Core.PageObjects;
using System;
using System.Threading.Tasks;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Pagamento.Tabela_de_Preço
{
    public class CadastroDeTabelaDePrecosPage : PageBase
    {
        public string CadastroDeTabelaDePrecoUrl { get; }
        public string ConsultaDeTabelaDePrecoUrl { get; }

        private string PageTitle => "SOM | Tabela de Preço";

        //Cadastro de Tabela de Preço
        public Element InpNome { get; private set; }
        public Element InpInicioVigencia { get; private set; }
        public Element InpFimVigencia { get; private set; }
        public Element SlctMidias { get; private set; }
        public Element BtnSalvarTabela { get; private set; }
        public Element BtnCancelarCadastro { get; private set; }
        public Element ChckPadrao { get; private set; }

        //Filtro de Tabela de Preço
        public Element BtnShowFiltro { get; private set; }
        public Element InpFiltroNomeTabela { get; private set; }
        public Element InpFiltroInicioVigencia { get; private set; }
        public Element InpFiltroFimVigencia { get; private set; }
        public Element SlctFiltroMidias { get; private set; }
        public Element SlctPadrao { get; private set; }
        public Element BtnPesquisar { get; private set; }
        public Element BtnLimparCamposDoFiltro { get; private set; }

        //Edição de Tabela de Preço
        public Element BtnEditarTabelaDePreco { get; private set; }

        //Edição de Fator da Tabela de Preço
        public Element BtnSalvarFator { get; private set; }
        

        public CadastroDeTabelaDePrecosPage(IBrowser browser, string cadastroDeTabelaDePrecoUrl, string consultaDeTabelaDePrecoUrl) : base(browser)
        {
            CadastroDeTabelaDePrecoUrl = cadastroDeTabelaDePrecoUrl;
            ConsultaDeTabelaDePrecoUrl = consultaDeTabelaDePrecoUrl;

            //Cadastro de Tabela de Preço
            InpNome = Element.Css("input[ng-model='TabelaPrecoDados.Descricao']");
            InpInicioVigencia = Element.Css("input[ng-model='TabelaPrecoDados.DataInicioVigencia']");
            InpFimVigencia = Element.Css("input[ng-model='TabelaPrecoDados.DataFimVigencia']");
            SlctMidias = Element.Css("div[ng-model='TabelaPrecoDados.ListaMidiaTabelaPreco']");
            BtnSalvarTabela = Element.Css("a[uib-tooltip='Salvar']");
            BtnCancelarCadastro = Element.Css("a[ng-click='voltarLista()']");
            ChckPadrao = Element.Css("input[ng-model='TabelaPrecoDados.Padrao']");

            //Filtro de Tabela de Preço
            BtnShowFiltro = Element.Css("a[ng-click='ShowHideFiltro()']");
            InpFiltroNomeTabela = Element.Css("div[ng-class='classNomeTabela'] input[ng-model='TabelaPrecoFiltros.Nome']");
            InpFiltroInicioVigencia = Element.Css("input[ng-model='TabelaPrecoFiltros.InicioVigencia']");
            InpFiltroFimVigencia = Element.Css("input[ng-model='TabelaPrecoFiltros.FimVigencia']");
            SlctFiltroMidias = Element.Css("div[ng-model='TabelaPrecoFiltros.ListaMidiaTabelaPreco']");
            SlctPadrao = Element.Css("select[ng-model='TabelaPrecoFiltros.PadraoS.selected']");
            BtnPesquisar = Element.Css("button[ng-click='GetAllTabelaPreco(false)']");
            BtnLimparCamposDoFiltro = Element.Css("a[ng-click='LimparCampos()']");

            //Edição de Tabela de Preço
            BtnEditarTabelaDePreco = Element.Css("i[class='fa fa-edit pull-right editartabelapreco']");

            //Edição de Fator da Tabela de Preço
            BtnSalvarFator = Element.Css("a[ng-click='salvarFator()']");
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastroDeTabelaDePrecoUrl);
        }

        public void NavegarConsultaDeTabelaDePreco()
        {
            Browser.Abrir(ConsultaDeTabelaDePrecoUrl);
        }

        public void Refresh()
        {
            Browser.RefreshPage();
        }

        public void SelecionarMidias(string Midia)
        {
            MouseActions.ClickATM(Browser, SlctMidias);
            MouseActions.ClickATM(Browser, Element.Xpath("//div[text()='" + Midia + "']"));
        }

        public void SelecionarFiltroDeMidias(string Midia)
        {
            MouseActions.ClickATM(Browser, SlctFiltroMidias);
            MouseActions.ClickATM(Browser, Element.Xpath("//div[text()='" + Midia + "']"));
        }

        public void EditarTabelaDePreco()
        {
            ElementExtensions.IsElementVisible(BtnEditarTabelaDePreco, Browser);
            MouseActions.ClickATM(Browser, BtnEditarTabelaDePreco);
        }

        public void CadastrarTabelaDePreco(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            if (Nome != "" && Nome != " ")
                AutomatedActions.SendDataATM(Browser, InpNome, Nome);
            if (InicioVigencia != "" && InicioVigencia != " ")
                AutomatedActions.SendData(Browser, InpInicioVigencia, InicioVigencia);
            if (FimVigencia != "" && FimVigencia != " ")
                AutomatedActions.SendData(Browser, InpFimVigencia, FimVigencia);
            if (Midia != "" && Midia != " ")
                SelecionarMidias(Midia);
        }

        public void CancelarCadastroDeTabelaDePreco()
        {
            try
            {
                ElementExtensions.IsElementVisible(BtnCancelarCadastro, Browser);
                MouseActions.ClickATM(Browser, BtnCancelarCadastro);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnCancelarCadastro, Browser);
                MouseActions.ClickATM(Browser, BtnCancelarCadastro);
            }
        }

        public void SalvarCadastroDeTabelaDePreco()
        {
            MouseActions.ClickATM(Browser, BtnSalvarTabela);
        }

        public void ValidarTelaDeBusca()
        {
            Assert.IsTrue(ElementExtensions.IsElementVisible(BtnShowFiltro, Browser));
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void ValidarPopupSucesso(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            Thread.Sleep(1000);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorCss(Element.Css(popUpSucesso), Browser));
            Thread.Sleep(2000);
        }

        public void ValidarPopupCritica(string Mensagem)
        {
            var texto = Element.Css("p[style='display: block;']");
            ElementExtensions.IsElementVisible(texto, Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorCss(texto, Browser));
        }

        public void ValidarCamposObrigatorios()
        {
            var nome = Element.Css("div[ng-class='classNomeTabela'][class='has-error']");
            var inicioVigencia = Element.Css("div[ng-class='classInicioVigencia'][class='has-error']");
            var fimVigencia = Element.Css("div[ng-class='classFimVigencia'][class='has-error']");

            Assert.IsTrue(ElementExtensions.IsElementVisible(nome, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(inicioVigencia, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(fimVigencia, Browser));
        }

        public void PesquisarPorTabelaDePreco(string Nome, string InicioVigencia, string FimVigencia, string Midias, string Padrao)
        {
            MouseActions.ClickATM(Browser, BtnShowFiltro);

            if (Nome != "" && Nome != " ")
                AutomatedActions.SendDataATM(Browser, InpFiltroNomeTabela, Nome);
            if (InicioVigencia != "" && InicioVigencia != " ")
                AutomatedActions.SendData(Browser, InpFiltroInicioVigencia, InicioVigencia);
            if (FimVigencia != "" && FimVigencia != " ")
                AutomatedActions.SendData(Browser, InpFiltroFimVigencia, FimVigencia);
            if (Midias != "" && Midias != " ")
                SelecionarFiltroDeMidias(Midias);
            if (Padrao != "" && Padrao != " ")
                MouseActions.SelectElementATM(Browser, SlctPadrao, Padrao);

            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        public void SelecionarTabelaDePreco(string Valor)
        {
            MouseActions.DoubleClickATM(Browser, Element.Xpath("//div[text()='" + Valor + "']"));
        }

        public void SelecionarAbaGeneroNacionalInternacional(string Genero, string Nacionalidade)
        {
            var btnShowCamposNacional = Element.Xpath("//h5[text()='" + Nacionalidade + "']/../..//a[@ng-click='showhide()']");
            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsClickable(btnShowCamposNacional, Browser);
                MouseActions.ClickATM(Browser, btnShowCamposNacional);
            }
            catch
            {
                ElementExtensions.IsClickable(btnShowCamposNacional, Browser);
                MouseActions.ClickATM(Browser, btnShowCamposNacional);
            }

            SelecionarAbaTabelaDePreco(Genero, Nacionalidade);
        }

        public void SelecionarAbaTabelaDePreco(string Genero, string Nacionalidade)
        {
            var aba = Element.Xpath("//div[@ng-if='Pesquisa" + Nacionalidade + " == false']//uib-tab-heading[contains (., '" + Genero + "')]");
            try
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, aba);
            }
            catch
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, aba);
            }
        }

        public void PreencherTabelaDePrecoValorInvalido(string Valor, string Genero, string Sincronismo, string Nacionalidade)
        {
            var campo = Element.Css("input[genero='" + Genero + "'][sincronismo='" + Sincronismo + "'][onchange='AddItem" + Nacionalidade + "(this)']");
            KeyboardActions.ControlA(Browser, campo);
            AutomatedActions.SendData(Browser, campo, Valor);
            KeyboardActions.Tab(Browser, campo);
        }

        public void ValidarValorInvalidoTabelaDePreco(string Valor, string Genero, string Sincronismo, string Nacionalidade)
        {
            var campo = Element.Css("input[genero='" + Genero + "'][sincronismo='" + Sincronismo + "'][onchange='AddItem" + Nacionalidade + "(this)']");
            var valorCampo = ElementExtensions.GetValorCss(campo, Browser);
            Assert.AreNotEqual(Valor, valorCampo);
        }

        public void AlterarTabelaDePreco(string Genero, string Nacionalidade, string Abertura, string AberturaPontual, string Adorno, 
            string AoVivoAdorno, string AoVivoFundo, string AoVivoFundoJornalismo, string AoVivoPerformance, string Encerramento, 
            string EncerramentoPontual, string Fundo, string FundoJornalismo, string Performance, string Tema)
        {
            PreencherTabelaDePrecoManual(Abertura, Genero, "ABERTURA", Nacionalidade);
            PreencherTabelaDePrecoManual(AberturaPontual, Genero, "ABERTURA PONTUAL", Nacionalidade);
            PreencherTabelaDePrecoManual(Adorno, Genero, "ADORNO", Nacionalidade);
            PreencherTabelaDePrecoManual(AoVivoAdorno, Genero, "AO VIVO ADORNO", Nacionalidade);
            PreencherTabelaDePrecoManual(AoVivoFundo, Genero, "AO VIVO FUNDO", Nacionalidade);
            PreencherTabelaDePrecoManual(AoVivoFundoJornalismo, Genero, "AO VIVO FUNDO EM JORNALISMO", Nacionalidade);
            PreencherTabelaDePrecoManual(AoVivoPerformance, Genero, "AO VIVO PERFORMANCE", Nacionalidade);
            PreencherTabelaDePrecoManual(Encerramento, Genero, "ENCERRAMENTO", Nacionalidade);
            PreencherTabelaDePrecoManual(EncerramentoPontual, Genero, "ENCERRAMENTO PONTUAL", Nacionalidade);
            PreencherTabelaDePrecoManual(Fundo, Genero, "FUNDO", Nacionalidade);
            PreencherTabelaDePrecoManual(FundoJornalismo, Genero, "FUNDO EM JORNALISMO", Nacionalidade);
            PreencherTabelaDePrecoManual(Performance, Genero, "PERFORMANCE", Nacionalidade);
            PreencherTabelaDePrecoManual(Tema, Genero, "TEMA", Nacionalidade);
            SalvarTabelaDePreco(Nacionalidade);
        }

        public void PreencherTabelaDePreco(string Genero, string Nacionalidade)
        {
            CamposTabelaDePreco(Genero, "ABERTURA", Nacionalidade);
            CamposTabelaDePreco(Genero, "ABERTURA PONTUAL", Nacionalidade);
            CamposTabelaDePreco(Genero, "ADORNO", Nacionalidade);
            CamposTabelaDePreco(Genero, "AO VIVO ADORNO", Nacionalidade);
            CamposTabelaDePreco(Genero, "AO VIVO FUNDO", Nacionalidade);
            CamposTabelaDePreco(Genero, "AO VIVO FUNDO EM JORNALISMO", Nacionalidade);
            CamposTabelaDePreco(Genero, "AO VIVO PERFORMANCE", Nacionalidade);
            CamposTabelaDePreco(Genero, "ENCERRAMENTO", Nacionalidade);
            CamposTabelaDePreco(Genero, "ENCERRAMENTO PONTUAL", Nacionalidade);
            CamposTabelaDePreco(Genero, "FUNDO", Nacionalidade);
            CamposTabelaDePreco(Genero, "FUNDO EM JORNALISMO", Nacionalidade);
            CamposTabelaDePreco(Genero, "PERFORMANCE", Nacionalidade);
            CamposTabelaDePreco(Genero, "TEMA", Nacionalidade);
            SalvarTabelaDePreco(Nacionalidade);
        }

        public void SalvarTabelaDePreco(string Nacionalidade)
        {
            MouseActions.ClickATM(Browser, Element.Css("i[ng-click='salvarItem" + Nacionalidade + "()']"));
        }

        public void PreencherTabelaDePrecoManual(string Valor, string Genero, string Sincronismo, string Nacionalidade)
        {
            PreencherTabelaDePrecoValorInvalido(Valor, Genero, Sincronismo, Nacionalidade);
        }

        private void CamposTabelaDePreco(string Genero, string Sincronismo, string Nacionalidade)
        {
            var campo = Element.Css("input[genero='" + Genero + "'][sincronismo='" + Sincronismo + "'][onchange='AddItem" + Nacionalidade + "(this)']");
            KeyboardActions.ControlA(Browser, campo);
            AutomatedActions.SendData(Browser, campo, Convert.ToString(FakeHelpers.RandomNumber(100)));
            KeyboardActions.Tab(Browser, campo);
        }

        public void CadastrarFatorDaTabelaDePreco(string Midia, string Fator)
        {
            var BtnAdicionarFator = Element.Css("i[uib-tooltip='Novo']");
            MouseActions.ClickATM(Browser, BtnAdicionarFator);

            var InpMidia = Element.Css("input[ng-model='FatorDados.DscMidia']");
            AutomatedActions.SendDataATM(Browser, InpMidia, Midia);
            MouseActions.ClickATM(Browser, Element.Xpath("//strong[text()='" + Midia + "']"));


            var InpFator = Element.Css("input[ng-model='FatorDados.Valor']");
            ElementExtensions.IsElementVisible(InpFator, Browser);
            if (Fator == "Fator")
                AutomatedActions.SendData(Browser, InpFator, Convert.ToString(FakeHelpers.RandomNumber(10)));
            else
                AutomatedActions.SendData(Browser, InpFator, Fator);
            KeyboardActions.Tab(Browser, InpFator);

            MouseActions.ClickATM(Browser, BtnSalvarFator);
        }

        public void ExcluirFatorDaTabelaDePreco(string Fator)
        {
            var fatorAlt = Element.Xpath("//strong[text()='" + " " + Fator + "']/../../..//i[@ng-click='excluirFatorTbPreco(item)']");
            try
            {
                MouseActions.ClickATM(Browser, fatorAlt);
            }
            catch
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, fatorAlt);
            }

            ElementExtensions.IsElementVisible(Element.Xpath("//h2[contains (., 'Tem certeza que deseja excluir o fator cadastrado para')]"), Browser);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, Element.Css("button[class='confirm']"));
        }

        public void AlterarFatorDaTabelaDePreco(string Fator, string Valor)
        {
            var fatorAlt = Element.Xpath("//strong[contains (., '" + Fator + "')]/../../..//i[@ng-click='ModalFatorTbPreco(item)']");
            try
            {
                MouseActions.ClickATM(Browser, fatorAlt);
            }
            catch
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, fatorAlt);
            }

            var InpFator = Element.Css("input[ng-model='FatorDados.Valor']");
            ElementExtensions.IsElementVisible(InpFator, Browser);
            Thread.Sleep(2000);
            KeyboardActions.ControlA(Browser, InpFator);
            if(Valor == "Valor")
                AutomatedActions.SendData(Browser, InpFator, Convert.ToString(FakeHelpers.RandomNumber(10)));
            else
                AutomatedActions.SendData(Browser, InpFator, Valor);
            KeyboardActions.Tab(Browser, InpFator);

            MouseActions.ClickATM(Browser, BtnSalvarFator);
        }

        public void ValidarTabelaDePrecos(string Valor)
        {
            if(Valor != "" && Valor != " ")
            {
                var textoTabelaDePreco = Element.Xpath("//div[text()='" + Valor + "']");
                Assert.IsTrue(ElementExtensions.IsElementVisible(textoTabelaDePreco, Browser));
            }
        }

        public void ValidarDadosNaoEncontradosNaBusca(string Mensagem)
        {
            var textoTabelaDePrecoNaoEncontrada = ElementExtensions.GetTexto(Element.Css("td[class='dataTables_empty']"), Browser);
            Assert.AreEqual(Mensagem, textoTabelaDePrecoNaoEncontrada);
        }
      
        public void LimparCamposDeBusca()
        {
            MouseActions.ClickATM(Browser, BtnShowFiltro);
            MouseActions.ClickATM(Browser, BtnLimparCamposDoFiltro);
        }

        public void ValidarCamposDeBuscaEmBranco()
        {
            var campoNome = ElementExtensions.GetValue(InpFiltroNomeTabela, Browser);
            var campoInicioVigencia = ElementExtensions.GetValue(InpFiltroInicioVigencia, Browser);
            var campoFimVigencia = ElementExtensions.GetValue(InpFiltroFimVigencia, Browser);
            var campoMidia = ElementExtensions.GetTexto(SlctFiltroMidias, Browser);

            Assert.AreEqual("", campoNome);
            Assert.AreEqual("", campoInicioVigencia);
            Assert.AreEqual("", campoFimVigencia);
            Assert.AreEqual("", campoMidia);
        }
    }
}