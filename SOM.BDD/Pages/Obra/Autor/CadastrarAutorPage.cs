using Framework.Core.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Obra
{
    public class CadastrarAutorPage : PageBase
    {
        private string CadastroAutorUrl { get; }

        private string PageTitle => "SOM | Cadastro de Autor";

        //*************CADASTRAR AUTOR*****************
        private Element NameArtistico { get; set; }
        private Element NameCompleto { get; set; }
        private Element ContratadoSim { get; set; }
        private Element Falecido70 { get; set; }
        private Element DtaContratacaoInicio { get; set; }
        private Element DtaContratacaoFim { get; set; }
        private Element AnodoFalecimento { get; set; }
        private Element Observacao { get; set; }
        private Element AbaEndereco { get; set; }
        private Element CadastroLogadouro { get; set; }
        private Element CadastroBairro { get; set; }
        private Element CadastroCidade { get; set; }
        private Element CadastroCEP { get; set; }
        private Element ContatoNome { get; set; }
        private Element TipodeContato { get; set; }
        private Element ContatoTelefone { get; set; }
        private Element SalvarEndereço { get; set; }
        private Element SalvarContato { get; set; }
        private Element ElementeMensagem { get; set; }
        private Element BtSalvar { get; set; }
        private Element AbaContato { get; set; }
        private Element ValidarConteudo { get; set; }
        private Element AtivarAutorCadastrado { get; set; }
        private Element BotaoConfirmarAtivacao { get; set; }
        private Element ValidarMsgAutorIgual { get; set; }
        private Element BotaoConfirmarAutorIgual { get; set; }
        private Element BotaoCadastrarNovoContato { get; set; }
        private Element BotaoAbaContatos { get; set; }
        private Element BotaoAbaAddEndereço { get; set; }

        //***************CONSULTA DE BUSCA E EXCLUSÃO AUTOR*******************
        private Element CampoAutor { get; set; }
        private Element BuscarAutor { get; set; }
        private Element BtnConfirmarExclusao { get; set; }

        public CadastrarAutorPage(IBrowser browser, string cadastroAutorUrl) : base(browser)
        {
            CadastroAutorUrl = cadastroAutorUrl;

            //*************CADASTRAR AUTOR*****************
             NameArtistico = Element.Css("div[ng-class='classAutor'] input[ng-model='AutorDados.NomeArtistico']");
             NameCompleto = Element.Css("div[class='col-md-4'] input[ng-model='AutorDados.NomeCompleto']");
             ContratadoSim = Element.Css("div[ng-controller='AutorController'] div[class='col-sm-4'] label[for='contratadoId']");
             Falecido70 = Element.Css("div[class='onoffswitch'] input[id='FalecidoDominioPublicoId']");
             DtaContratacaoInicio = Element.Css("div[class='col-sm-2'] input[placeholder='Início']");
             DtaContratacaoFim = Element.Css("div[class='col-sm-2'] input[placeholder='Fim']");
             AnodoFalecimento = Element.Css("div[class='col-sm-4'] input[ng-model='AutorDados.DataFalecimento']");
             Observacao = Element.Css("textarea[ng-model='AutorDados.Observacao']");
             AbaEndereco = Element.Xpath("//h5[text()='Endereços']/..//i");
             CadastroLogadouro = Element.Css("input[ng-model='Endereco.Logradouro']");
             CadastroBairro = Element.Css("input[ng-model='Endereco.Bairro']");
             CadastroCidade = Element.Css("input[ng-model='Endereco.Cidade']");
             CadastroCEP = Element.Css("input[ng-model='Endereco.CEP']");
             ContatoNome = Element.Css("div[ng-if='PesquisaContato == false'] input[ng-model='Contato.Nome']");
             TipodeContato = Element.Css("div[ng-if='PesquisaContato == false'] select[ng-model='Contato.ItemContato.TipoContato.selected']");
             ContatoTelefone = Element.Css("div[ng-if='PesquisaContato == false'] input[ng-model='Contato.ItemContato.Valor']");
             SalvarEndereço = Element.Css("a[ng-click='salvarEndereco(false)']");
             SalvarContato = Element.Css("a[ng-click='salvarContato(false)']");
             ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
             BtSalvar = Element.Css("a[ng-click='salvarAutor(false, true)']");
             AbaContato = Element.Xpath("//h5[text()='Contatos']/..//i");
             ValidarConteudo = Element.Css("div[class='contact-box'] strong");
             AtivarAutorCadastrado = Element.Css("");
             BotaoConfirmarAtivacao = Element.Xpath("//h2[text()='Deseja ativar?']/..//button[@class='confirm']");
             ValidarMsgAutorIgual = Element.Css("p[style='display: block;']");
             BotaoConfirmarAutorIgual = Element.Css("div[class='sa-button-container'] button[class='confirm']");
             BotaoCadastrarNovoContato = Element.Css("div[ng-if='!editarIContato']");
             BotaoAbaContatos = Element.Css("div[class='ng-isolate-scope'] li[class='abaContatoClick uib-tab ng-isolate-scope active']");
             BotaoAbaAddEndereço = Element.Css("div[ng-if='PesquisaEndereco == false'] li[class='uib-tab ng-scope ng-isolate-scope'] a");

            //***************CONSULTA DE BUSCA E EXCLUSÃO AUTOR*******************
             CampoAutor = Element.Css("input[placeholder='Buscar autor']");
             BuscarAutor = Element.Css("a[uib-tooltip='Pesquisar']");
             BtnConfirmarExclusao = Element.Xpath("//h2[text()='Deseja excluir?']/..//button[@class='confirm']");
        }


        public override void Navegar()
        {
            Browser.Abrir(CadastroAutorUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle), $"A pagina de cadastro de Autor não estava visivel. Expected=>{PageTitle}." +
                $"Actual=>{Browser.PageSource(PageTitle)}");
        }
        
        internal void CadastroAutor(string NomeAutor, string NomeCompleto)
        {
            ElementExtensions.IsClickable(NameArtistico, Browser);
            AutomatedActions.SendDataATM(Browser, NameArtistico, NomeAutor);
            ElementExtensions.IsClickable(NameCompleto, Browser);
            AutomatedActions.SendDataATM(Browser, NameCompleto, NomeCompleto);
        }

        internal void InformarAnoFalecimento(string AnoFalecimento)
        {
            AutomatedActions.SendDataATM(Browser, AnodoFalecimento, AnoFalecimento);
            KeyboardActions.Tab(Browser, AnodoFalecimento);
        }

        internal void AbaCadastroEndereço()
        {
            ElementExtensions.IsClickable(AbaEndereco, Browser);
            MouseActions.ClickATM(Browser, AbaEndereco);
        }

        internal void CadastrarEndereco(string Logradouro, string Bairro, string Cidade, string CEP, string Salvar)
        {
            ElementExtensions.EsperarElemento(CadastroLogadouro, Browser);
            AutomatedActions.SendDataATM(Browser, CadastroLogadouro, Logradouro);
            //CadastroLogadouro.SendKeys(Logradouro);
            AutomatedActions.SendDataATM(Browser, CadastroBairro, Bairro);
            //CadastroBairro.SendKeys(Bairro);
            AutomatedActions.SendDataATM(Browser, CadastroCidade, Cidade);
            //CadastroCidade.SendKeys(Cidade);
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, CadastroCEP);
            //CadastroCEP.Click();
            Thread.Sleep(1000);
            AutomatedActions.SendDataATM(Browser, CadastroCEP, CEP);
            //CadastroCEP.SendKeys(CEP);
            Thread.Sleep(1000);
            if (Salvar != "")
            {
                MouseActions.ClickATM(Browser, SalvarEndereço);
                //SalvarEndereço.Click();
            }
          
        }

        internal void BtnADDEndereço()
        {
            MouseActions.ClickATM(Browser, BotaoAbaAddEndereço);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //BotaoAbaAddEndereço.Click();
        }

        internal void ValidarMensagemEndereco(string Logradouro)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            //string ValidarMsg1 = ValidarConteudo.GetAttribute("textContent");
            string ValidarMsg1 = ElementExtensions.GetValorAtributo(ValidarConteudo, "textContent", Browser);
            Assert.AreEqual(Logradouro, ValidarMsg1);

            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"));
        }

        internal void ValidarConteudoContato(string Nome)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            string ValidarMsg1 = ElementExtensions.GetValorAtributo(ValidarConteudo, "textContent", Browser);
            Assert.AreEqual(Nome, ValidarMsg1);
        }

        internal void AbadeContato()
        {
            ElementExtensions.IsClickable(AbaContato, Browser);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            MouseActions.ClickATM(Browser, AbaContato);
            //AbaContato.Click();
           
        }
        internal void CadastrarContato(string Nome, string Contato, string Telefone)
        {
            Thread.Sleep(1000);
            AutomatedActions.SendDataATM(Browser, ContatoNome, Nome);
            //ContatoNome.Clear();
            //ContatoNome.SendKeys(Nome);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            MouseActions.ClickATM(Browser, TipodeContato);
            //TipodeContato.Click();
            SelecionarContato(Contato);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, ContatoTelefone);
            AutomatedActions.SendDataATM(Browser, ContatoTelefone, Telefone);
            //ContatoTelefone.Click();
            //ContatoTelefone.SendKeys(Telefone);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        internal void CadastrarMaisContato(string Contato, string Telefone)
        {
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, TipodeContato);
            SelecionarContato(Contato);
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, ContatoTelefone);
            AutomatedActions.SendDataATM(Browser, ContatoTelefone, Telefone);
        }

        internal void btSalvarCadastro(string SalvarC)
        {
            if (SalvarC != "")
            {
                MouseActions.ClickATM(Browser, SalvarContato);
            }
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"));
        }
        public void ValidarMensagemContato(string MensagemDeContato)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string popUp = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            Assert.AreEqual(MensagemDeContato, ElementExtensions.GetValorAtributo(Element.Css(popUp), "textContent", Browser));

        }

        private void SelecionarContato(string Contato)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //var selectContato = new SelectElement(TipodeContato);
            switch (Contato)
            {
                case "Celular":
                    {
                        MouseActions.SelectElementATMByValue(Browser, TipodeContato, "2");
                        //selectContato.SelectByValue("2");
                        break;
                    }
                case "Email":
                    {
                        MouseActions.SelectElementATMByValue(Browser, TipodeContato, "1");
                        //selectContato.SelectByValue("1");
                        break;
                    }
                case "Telefone":
                    {
                        MouseActions.SelectElementATMByValue(Browser, TipodeContato, "0");
                        //selectContato.SelectByValue("0");
                        break;
                    }
            }
        }

        public void ClicarSalvarCadastroDoAutor()
        {
            MouseActions.ClickATM(Browser, Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"));
            //Driver.FindElement(By.CssSelector("div[id='toast-container'] div[class='ng-binding ng-scope']")).Click();

            Thread.Sleep(2000);
            //Assert.IsTrue(BtSalvar.Enabled);
            MouseActions.ClickATM(Browser, BtSalvar);
            //BtSalvar.Click();
            
            Thread.Sleep(2000);
        }

        internal void ValidarCadastroAutor()
        {
            //Thread.Sleep(5000);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            MouseActions.ClickATM(Browser, BtSalvar);
            //BtSalvar.Click();

            //Thread.Sleep(2000);
            try
            {
                ElementExtensions.Esperar(BotaoConfirmarAtivacao, Browser, 2000);
                MouseActions.ClickATM(Browser, BotaoConfirmarAtivacao);
            }
            catch
            {

            }
            //BotaoConfirmarAtivacao.Click();
        }
        internal void BotaoSalvar()
        {
            Thread.Sleep(5000);
            MouseActions.ClickATM(Browser, BtSalvar);
            //BtSalvar.Click();
        }

        internal void ValidarBotaoFiltro()
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ElementExtensions.IsElementVisible(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
            //Assert.IsTrue(Driver.FindElement(By.CssSelector("a[ng-click='ShowHideFiltro()']")).Displayed);
        }

        internal void ValidarcampoAutor()
        {
            MouseActions.ClickATM(Browser, BtSalvar);
            ElementExtensions.IsElementVisible(Element.Css("div[ng-class='classAutor'][class='has-error']"), Browser);
        }
        internal void ValidarCamposDeEndereço()
        {
            ElementExtensions.IsElementVisible(Element.Css("div[class='form-group has-error'][ng-class='classAuEndLogradouro']"), Browser);
            ElementExtensions.IsElementVisible(Element.Css("div[class='form-group has-error'][ng-class='classAuEndBairro']"), Browser);
            ElementExtensions.IsElementVisible(Element.Css("div[class='form-group has-error'][ng-class='classAuEndCidade']"), Browser);
            ElementExtensions.IsElementVisible(Element.Css("div[class='form-group has-error'][ng-class='classAuEndCEP']"), Browser);
        }

        internal void ValidarCampoContato()
        {
            ElementExtensions.IsElementVisible(Element.Css("div[class='form-group has-error'][ng-class='classConNome']"), Browser);
        }

        internal void ValidarContatoAutor(string nomeContato, string SalvarC)
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, AbaContato);
            ElementExtensions.IsClickable(ContatoNome, Browser);
            AutomatedActions.SendDataATM(Browser, ContatoNome, nomeContato);
            if (SalvarC != "")
            {
                MouseActions.ClickATM(Browser, SalvarContato);
            }

        }
        internal void ValidarMensagem(string Mensagem)
        {
            string ValidarMsg = ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser);
            Assert.AreEqual(Mensagem, ValidarMsg);
        }

        internal void ValidarAutorIgual(string MensagemIgual)
        {
            ElementExtensions.IsElementVisible(Element.Css("div[class='sweet-alert showSweetAlert visible']"), Browser);
            
            string MensagemAutor = ElementExtensions.GetValorAtributo(ValidarMsgAutorIgual, "textContent", Browser);
            Assert.AreEqual(MensagemIgual, MensagemAutor);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BotaoConfirmarAutorIgual);
            
        }

        public void ConsultaSimplesAutor(string NomeAutor)
        {
            AutomatedActions.SendDataATM(Browser, CampoAutor, NomeAutor);
            MouseActions.ClickATM(Browser, BuscarAutor);

            string nomedoAutor = "//table[@id='DataTables_Table_0']//div[text()='" + NomeAutor + "']";
            Assert.AreEqual(NomeAutor, ElementExtensions.GetValorAtributo(Element.Xpath(nomedoAutor), "textContent", Browser));

        }

        internal void CadastrarCampoVazio(string NomeAutor)
        {
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, NameArtistico, NomeAutor);
        }
        internal void AddNovoContato()
        {
            MouseActions.ClickATM(Browser, BotaoCadastrarNovoContato);
        }


        public void ValidarResultadoDaConsultaDeAutor(string NomeAutor, string NomeCompleto, string Contratado, string Falecido)
        {
            ValidarAutor(NomeAutor, NomeCompleto, Contratado, Falecido);
        }

        private void ValidarAutor(string Valor, string Valor2, string Valor3, string Valor4)
        {
            var linha = "0";
            var tr = 1;

            while (linha != Valor)
            {
                linha = ElementExtensions.GetValorAtributo(Element.Xpath("//*[@id='DataTables_Table_0']/tbody/tr[" + tr + "]/td[1]/div"), "textContent", Browser);

                if (linha == Valor)
                {
                    Assert.AreEqual(Valor, linha);

                    var coluna2 = ElementExtensions.GetValorAtributo(Element.Xpath("//*[@id='DataTables_Table_0']/tbody/tr[" + tr + "]/td[2]/div"), "textContent", Browser);
                    var coluna3 = ElementExtensions.GetValorAtributo(Element.Xpath("//*[@id='DataTables_Table_0']/tbody/tr[" + tr + "]/td[3]/div"), "textContent", Browser);
                    var coluna4 = ElementExtensions.GetValorAtributo(Element.Xpath("//*[@id='DataTables_Table_0']/tbody/tr[" + tr + "]/td[4]/div"), "textContent", Browser);

                    if(coluna2 == Valor2 && coluna3 == Valor3 && coluna4 == Valor4)
                    {
                        Assert.AreEqual(Valor2, coluna2);
                        Assert.AreEqual(Valor3, coluna3);
                        Assert.AreEqual(Valor4, coluna4);
                    }
                    else
                    {
                        throw new ArgumentException("O Autor pesquisado não se encontra na tabela de resultados.");
                    }
                }
                else
                {
                    if (tr == 11)
                    {
                        throw new ArgumentException("O Autor pesquisado não se encontra na tabela de resultados.");
                    }
                }
                tr = tr + 1;
            }
        }

    }
}
