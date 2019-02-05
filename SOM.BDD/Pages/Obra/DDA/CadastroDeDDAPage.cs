using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.FrameworkActions;

namespace SOM.BDD.Pages.Obra.DDA
{
    public class CadastroDeDDAPage : PageBase
    {
        private string CadastroDeDDAUrl { get; }

        private string PageTitle => "SOM | Cadastro de DDA";

        //Elementos cadastro de DDA
        private Element InpNomeFantasia { get; set; }
        private Element InpNomeCompleto { get; set; }
        private Element InpCPF { get; set; }
        private Element SlctAssociacaoDDA { get; set; }
        private Element ChckAdministrador { get; set; }
        private Element InpDataNascimento { get; set; }
        private Element BtnSalvarDDA { get; set; }

        //Elementos cadastro de contato de DDA
        private Element BtnShowCamposContato { get; set; }
        private Element InpNomeContato { get; set; }
        private Element TextAreaObservacao { get; set; }
        private Element InpTipoContato { get; set; }
        private Element SlctTipoContato { get; set; }
        private Element ChckRecebeAutorizacao { get; set; }
        private Element BtnAdicionarContatoDDA { get; set; }
        private Element BtnSalvarContatoDDA { get; set; }

        //Exclusao de DDA
        private Element BtnConfirmarExclusao { get; set; }
        private Element MsgDadosNaoEncontrados { get; set; }
        private Element BtnConfirmarAtivacao { get; set; }
        
        //Elementos cadastro de endereço de DDA
        public Element BtnShowCamposEndereco { get; private set; }
        public Element InpLogradouro { get; private set; }
        public Element InpBairro { get; private set; }
        public Element InpCidade { get; private set; }
        public Element SlctUF { get; private set; }
        public Element InpCEP { get; private set; }
        public Element BtnSalvarEnderecoDDA { get; private set; }

        public CadastroDeDDAPage(IBrowser browser, string cadastroDeDDAUrl) : base(browser)
        {
            CadastroDeDDAUrl = cadastroDeDDAUrl;

            //Elementos cadastro de DDA
            InpNomeFantasia = Element.Css("input[ng-model='DDADados.Nome']");
            InpNomeCompleto = Element.Css("input[ng-model='DDADados.RazaoSocial']");
            InpCPF = Element.Css("input[ng-model='DDADados.NumeroDocumento']");
            SlctAssociacaoDDA = Element.Css("select[ng-model='DDADados.Associacao']");
            ChckAdministrador = Element.Css("div[class='onoffswitch'] label[for='grupoEditorialId']");
            InpDataNascimento = Element.Css("input[ng-model='DDADados.DataNascimento']");
            BtnSalvarDDA = Element.Css("a[class='btn btn-link collapsed cadastrardda']");

            //Elementos cadastro de contato de DDA
            BtnShowCamposContato = Element.Xpath("//h5[text()='Contatos']/..//a");
            InpNomeContato = Element.Xpath("//h5[text()='Contatos']/../..//input[@ng-model='Contato.Nome']");
            TextAreaObservacao = Element.Xpath("//h5[text()='Contatos']/../..//textarea[@ng-model='Contato.Observacao']");
            InpTipoContato = Element.Xpath("//h5[text()='Contatos']/../..//input[@ng-model='Contato.ItemContato.Valor']");
            SlctTipoContato = Element.Xpath("//h5[text()='Contatos']/../..//select[@ng-model='Contato.ItemContato.TipoContato.selected']");
            ChckRecebeAutorizacao = Element.Css("div[class='onoffswitch'] label[for='FalecidoDominioPublicoId']");
            BtnAdicionarContatoDDA = Element.Css("div[ng-click='adicionarItemContato(false)'] i");
            BtnSalvarContatoDDA = Element.Css("a[ng-click='salvarContato(false)']");

            //Exclusao de DDA
            BtnConfirmarExclusao = Element.Xpath("//h2[text()='Deseja excluir?']/..//button[@class='confirm']");
            MsgDadosNaoEncontrados = Element.Css("td[class='dataTables_empty']");
            BtnConfirmarAtivacao = Element.Xpath("//h2[text()='Deseja ativar?']/..//button[@class='confirm']");

            //Elementos cadastro de endereço de DDA
            BtnShowCamposEndereco = Element.Xpath("//h5[text()='Endereços']/..//a");
            InpLogradouro = Element.Css("input[ng-model='Endereco.Logradouro']");
            InpBairro = Element.Css("input[ng-model='Endereco.Bairro']");
            InpCidade = Element.Css("input[ng-model='Endereco.Cidade']");
            SlctUF = Element.Css("div[ng-model='Endereco.UF.selected'] i[class='caret pull-right']");
            InpCEP = Element.Css("input[ng-model='Endereco.CEP']");
            BtnSalvarEnderecoDDA = Element.Css("a[ng-click='salvarEndereco(false)']");
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastroDeDDAUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void CadastrarDDA(string NomeFantasia, string NomeCompleto, string CPF, string Associacao, string Administrador, string DataNascimento)
        {
            if(NomeFantasia != "" && NomeFantasia != " ")
                PreencherNomeFantasia(NomeFantasia);
            if (NomeCompleto != "" && NomeCompleto != " ")
                PreencherNomeCompleto(NomeCompleto);
            if (CPF != "" && CPF != " ")
                PreencherCPF(CPF);
            if (Associacao != "" && Associacao != " ")
                SelecionarAssociacao(Associacao);
            if (Administrador == "Sim")
            {
                MarcarCheckboxAdministrador();
            }
            if (DataNascimento != "" && DataNascimento != " ")
                PreencherDataNascimento(DataNascimento);
        }

        public void CadastrarContatoDDA(string NomeContato, string TipoContato, string Contato, string RecebeAutorizacao)
        {
            PreencherNomeContato(NomeContato);
            SelecionarTipoContato(TipoContato);
            PreencherContato(Contato);
            if(RecebeAutorizacao != "Não")
            {
                MarcarRecebeAutorizacao();
            }
            AdicionarContatoDDA();
            SalvarContatoDDA();
        }

        public void CadastrarEnderecoDDA(string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposEndereco);
            AutomatedActions.SendData(Browser, InpLogradouro, Logradouro);
            AutomatedActions.SendData(Browser, InpBairro, Bairro);
            AutomatedActions.SendData(Browser, InpCidade, Cidade);
            SelecionarUF(UF);
            PreencherCEP(CEP);
            MouseActions.ClickATM(Browser, BtnSalvarEnderecoDDA);
        }

        private void PreencherCEP(string CEP)
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpCEP);
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpCEP, CEP);
        }

        public void ValidarEnderecoDeDDA(string Logradouro)
        {
            ValidarPopUpSucesso();
            Assert.AreEqual(Logradouro, ElementExtensions.GetValorAtributo(Element.Css("div[ng-repeat='item in DDADados.Enderecos'] div[class='contact-box'] strong"), "textContent", Browser));
        }

        public void ValidarContatoDDA(string NomeContato)
        {
            ValidarPopUpSucesso();
            Assert.AreEqual(NomeContato, ElementExtensions.GetValorAtributo(Element.Css("div[ng-repeat='item in DDADados.Contatos'] div[class='contact-box'] strong"), "textContent", Browser));
        }

        private void ValidarPopUpSucesso()
        {
            ElementExtensions.EsperarElemento(Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"), Browser);
            Assert.AreEqual("Registro salvo com sucesso.", ElementExtensions.GetValorAtributo(Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"), "textContent", Browser));
            Thread.Sleep(1000);
        }

        public void ValidarCadastroDeDDA()
        {
            ClicarSalvarCadastroDeDDA();
            ElementExtensions.EsperarElemento(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
        }

        private void SalvarContatoDDA()
        {
            MouseActions.ClickATM(Browser, BtnSalvarContatoDDA);
        }

        private void AdicionarContatoDDA()
        {
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
        }

        private void MarcarRecebeAutorizacao()
        {
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
        }

        private void PreencherContato(string Contato)
        {
            AutomatedActions.SendDataATM(Browser, InpTipoContato, Contato);
        }

        private void PreencherNomeContato(string NomeContato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, NomeContato);
        }

        private void SelecionarUF(string Valor)
        {
            MouseActions.ClickATM(Browser, SlctUF);
            var selecionarUf = Element.Xpath("//div[text()='" + Valor + "']");
            MouseActions.ClickATM(Browser, selecionarUf);
        }

        private void SelecionarTipoContato(string TipoContato)
        {
            switch (TipoContato)
            {
                case "Celular":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipoContato, "2");
                        break;
                    }
                case "E-mail":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipoContato, "1");
                        break;
                    }
                case "Telefone":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipoContato, "0");
                        break;
                    }
            }
        }

        private void PreencherDataNascimento(string DataNascimento)
        {
            AutomatedActions.SendData(Browser, InpDataNascimento, DataNascimento);
        }

        private void MarcarCheckboxAdministrador()
        {
            MouseActions.ClickATM(Browser, ChckAdministrador);
        }

        private void PreencherCPF(string CPF)
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpCPF);
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, InpCPF, CPF);
        }

        private void PreencherNomeCompleto(string NomeCompleto)
        {
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, NomeCompleto);
        }

        private void PreencherNomeFantasia(string NomeFantasia)
        {
            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeFantasia);
        }

        public void ClicarSalvarCadastroDeDDA()
        {
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"));

            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarDDA);

            try
            {
                Thread.Sleep(1500);
                ElementExtensions.IsElementVisible(BtnConfirmarAtivacao, Browser);
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnConfirmarAtivacao);
            }
            catch
            {
                
            }
        }

        public void SalvarDDASemContato(string Mensagem, string ValidarPopUps)
        {
            if(ValidarPopUps == "Sim")
            {
                Thread.Sleep(1000);
                MouseActions.ClickATM(Browser, Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"));

                Thread.Sleep(1000);
                MouseActions.ClickATM(Browser, Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"));
            }

            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarDDA);

            var textAlerta = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textAlerta, "textContent", Browser));
        }

        private void SelecionarAssociacao(string Associacao)
        {
            switch (Associacao)
            {
                case "UBEM":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacaoDDA, "UBEM");
                        break;
                    }
                case "SEM ASSOCIAÇÃO":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacaoDDA, "SemAssociacao");
                        break;
                    }
            }
        }

        public void ValidarCamposObrigatoriosDeDDA()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarDDA);
            var nomeFantasia = Element.Css("div[ng-class='classDDANome'][class='form-group has-error']");
            var nomeCompleto = Element.Css("div[ng-class='classDDARazao'][class='form-group ng-scope has-error']");
            var erroCpf = Element.Css("div[ng-class='classDDANumeroDocumento'][class='ng-scope has-error']");
            var associacao = Element.Css("div[ng-class='classAssociacao'][class='has-error']");

            Thread.Sleep(1500);
            Assert.IsTrue(ElementExtensions.IsElementVisible(nomeFantasia, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(nomeCompleto, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(erroCpf, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(associacao, Browser));
        }

    }
}
