using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Threading;
using SOM.BDD.Pages.Ferramenta;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Ferramenta
{
    public class TransferenciaDeAutorPage : PageBase
    {

        private string TransferenciadeAutorUrl { get; }

        public TransferenciaDeAutorPage TelaTransferenciaDeAutorPage { get; private set; }

        //Trasferência de Autor
        public Element InpNomeAutorDe { get; private set; }
        public Element InpNomeAutorPara { get; private set; }
        public Element SalvarDePara { get; private set; }
        public Element CancelarDePara { get; private set; }
        public Element ElementeMensagem { get; private set; }
        public Element CheckBoxExcluirAutor { get; private set; }

        //Cadastrar autor
        public Element BtnCadastrarAutor { get; private set; }
        public Element InpNomeArtistico { get; private set; }
        public Element InpNomeCompletoAutor { get; private set; }
        public Element BtnShowContatos { get; private set; }
        public Element InpNomeContato { get; private set; }
        public Element SlctTipoContatoAutor { get; private set; }
        public Element InpValorContatoAutor { get; private set; }
        public Element BtnAdicionarItemContato { get; private set; }
        public Element BtnSalvarContatoAutor { get; private set; }
        public Element BtnSalvarCadastroDeAutor { get; private set; }
        public Element InpDataInicioContratacao { get; private set; }
        public Element InpDataFimContratacao { get; private set; }
        public Element BtnConfirmarExclusao { get; private set; }

        public TransferenciaDeAutorPage(IBrowser browser, string transferenciadeAutorUrl) : base(browser)
        {
            TransferenciadeAutorUrl = transferenciadeAutorUrl;

            //Trasferência de Autor
            InpNomeAutorDe = Element.Css("input[ng-model='Form.NomeAutorDe']");
            InpNomeAutorPara = Element.Css("input[ng-model='Form.NomeAutorPara']");
            SalvarDePara = Element.Css("a[ng-click='Salvar()']");
            CancelarDePara = Element.Css("a[ng-click='Cancelar()']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
            CheckBoxExcluirAutor = Element.Css("label[for='FalecidoDominioPublicoId']");
            BtnConfirmarExclusao = Element.Xpath("//h2[text()='De/Para de Autor']/..//button[@class='confirm']");

        }

        public override void Navegar()
        {
            Browser.Abrir(TransferenciadeAutorUrl);
        }


        public void TranferenciaDeParaAutor(string De, string Para)
        {
            Thread.Sleep(1500);
            AutomatedActions.SendDataATM(Browser, InpNomeAutorDe, De);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, InpNomeAutorDe);
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, InpNomeAutorPara, Para);
            Thread.Sleep(5000);
            KeyboardActions.Tab(Browser, InpNomeAutorPara);
       
        }

        public void ValidarExclusãoAutorDePara()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);     
        }
        
        
        public void ConfirmarDePara()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, SalvarDePara);
            Thread.Sleep(2000);
            var BtnConfirmar = Element.Xpath("//h2[text()='De/Para de Autor']/..//button[@class='confirm']");
            MouseActions.ClickATM(Browser, BtnConfirmar);
        }

        public void SalvarAlteração()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, SalvarDePara);
        }


        public void ValidarCamposDEPARAAutor()
        {
            Thread.Sleep(1500);
            var NomeAutorDe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorDe']");
            var NomeAutorPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorPara']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorDe, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorPara, Browser));
        }

        public void ValidarDadosAlterados(string MensagemDeAlteração)
        {
            Assert.AreEqual(MensagemDeAlteração, ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser));
            Thread.Sleep(2000);
        }

        public void ValidarCamposDEAutor()
        {
            Thread.Sleep(1500);
            var NomeAutorDe = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorDe']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorDe, Browser));
        }

        public void ValidarCamposPARAAutor()
        {
            Thread.Sleep(1500);
            var NomeAutorPara = Element.Css("div[class='form-group has-error'] input[ng-model='Form.NomeAutorPara']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(NomeAutorPara, Browser));
        }

        public void ConfirmarExclusãoAutorDe()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, CheckBoxExcluirAutor);
            Thread.Sleep(1500);
        }

        public void MensagemAutorDeValidação(string Mensagem)
        {
            Thread.Sleep(1500);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css("p[style='display: block;']"), "textContent", Browser));
        }


    }
}
