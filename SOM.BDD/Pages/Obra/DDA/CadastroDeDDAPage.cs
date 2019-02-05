using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.FrameworkActions;
using Framework.Core.Helpers;

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
        public Element BtnPais { get; private set; }

        //Alterar DDA Contato
        public Element btnEditarDDA { get; private set; }
        public Element ElementeMensagem { get; private set; }
        public Element EditTelefone { get; private set; }
        public Element btEditarContato { get; private set; }
        public Element btatualizarContato { get; private set; }
        public Element SalvarEditContato { get; private set; }

        //Alterar DDA 
        public Element BtnSalvarEdtDDA { get; private set; }
        public Element btnCancelarEdtDDA { get; private set; }
        public Element MsgdeCancelamento { get; private set; }
        public Element BtEditarContatoAtualizar { get; private set; }
        public Element BtnSalvarEnderecoDDAAlterado { get; private set; }
        public Element AlterarPais { get; private set; }


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
            BtnSalvarEnderecoDDAAlterado = Element.Css("a[ng-click='salvarEndereco(true)']");
            BtnPais = Element.Css("div[placeholder='Selecione'] span[ng-click='$select.activate()']");

            //Alterar DDA Contato
            btnEditarDDA = Element.Css("div[ng-repeat='item in DDADados.Contatos'] span[uib-tooltip='Editar']");
            btEditarContato = Element.Class("td[align='center'] span[uib-tooltip='Editar']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
            EditTelefone = Element.Xpath("//h5[text()='Contatos']/../..//input[@ng-model='ContatoEditar.ItemContato.Valor']");
            btatualizarContato = Element.Css("div[class='col-md-12'] div[ng-click='adicionarItemContato(true)']");
            SalvarEditContato = Element.Css("a[ng-click='editarContato(true)']");

            //Alterar DDA
            BtnSalvarEdtDDA = Element.Css("a[uib-tooltip='Salvar']");
            btnCancelarEdtDDA = Element.Css("a[ng-click='voltarLista()']");
            MsgdeCancelamento = Element.Xpath("//h2[text()='Deseja cancelar?']/..//button[@class='confirm']");
            BtEditarContatoAtualizar = Element.Css("div[class='panel-body ng-scope'] div[ng-click='editarItemContato(true)']");
            AlterarPais = Element.Css("div[ng-model='Endereco.Pais.selected'] span[ng-click='$select.activate()']");
        }

        public static string DDA { get; set; }

        public string DDACadastrado
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr(); }
        }


        public string GetDDA()
        {
            return DDA;
        }

        private void SetDDA(string nome)
        {
            DDA = nome;
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastroDeDDAUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void CadastrarDDA(string NomeFantasia, string NomeCompleto, string CPF, string Associacao, string Administrador, string DataNascimento)
        {
            if (NomeFantasia != "" && NomeFantasia != " ")
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
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpTipoContato);
            PreencherContato(Contato);
            if (RecebeAutorizacao != "Não")
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

        public void AlterarEnderecoDDA(string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposEndereco);
            AutomatedActions.SendData(Browser, InpLogradouro, Logradouro);
            AutomatedActions.SendData(Browser, InpBairro, Bairro);
            AutomatedActions.SendData(Browser, InpCidade, Cidade);
            SelecionarUF(UF);
            PreencherCEP(CEP);
            MouseActions.ClickATM(Browser, BtnSalvarEnderecoDDAAlterado);
        }

        public void AlterarEnderecoInternacionalDDA(string Pais, string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposEndereco);
            AlterarEnderecoPais(Pais);
            AutomatedActions.SendData(Browser, InpLogradouro, Logradouro);
            AutomatedActions.SendData(Browser, InpBairro, Bairro);
            AutomatedActions.SendData(Browser, InpCidade, Cidade);
            SelecionarUF(UF);
            PreencherCEP(CEP);
            MouseActions.ClickATM(Browser, BtnSalvarEnderecoDDAAlterado);
        }

        public void CadastrarEnderecoInternacionalDDA(string Pais, string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposEndereco);
            SelecionarPais(Pais);
            AutomatedActions.SendData(Browser, InpLogradouro, Logradouro);
            AutomatedActions.SendData(Browser, InpBairro, Bairro);
            AutomatedActions.SendData(Browser, InpCidade, Cidade);
            SelecionarUF(UF);
            PreencherCEP(CEP);
            MouseActions.ClickATM(Browser, BtnSalvarEnderecoDDA);
        }
        private void SelecionarPais(string Valor)
        {
            MouseActions.ClickATM(Browser, BtnPais);
            var selecionarPais = Element.Xpath("//div[text()='" + Valor + "']");
            MouseActions.ClickATM(Browser, selecionarPais);
        }

        private void AlterarEnderecoPais(string Valor)
        {
            MouseActions.ClickATM(Browser, AlterarPais);
            var selecionarPais = Element.Xpath("//div[text()='" + Valor + "']");
            MouseActions.ClickATM(Browser, selecionarPais);
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

        public void SalvarDDAAlterado()
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarEdtDDA);
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
            Thread.Sleep(2000);
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
            if (ValidarPopUps == "Sim")
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

        public void CadastroDeDDAAleatorio()
        {
            SetDDA(DDACadastrado);
            string NomeDDA = GetDDA();

            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeDDA);
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            PreencherCNPJ();
            SelecionarAssociacao("UBEM");
            MouseActions.ClickATM(Browser, ChckAdministrador);
            //AutomatedActions.SendData(Browser, InpDataNascimento, "10/10/1992");
            CadastrarContatoDDA();
            MouseActions.ClickATM(Browser, ElementeMensagem);
            MouseActions.ClickATM(Browser, BtnSalvarDDA);
        }

        public void CadastroDeDDAAleatorioComEndereço()
        {
            SetDDA(DDACadastrado);
            string NomeDDA = GetDDA();

            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeDDA);
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            PreencherCNPJ();
            SelecionarAssociacao("UBEM");
            MouseActions.ClickATM(Browser, ChckAdministrador);
        }

        public void CadastroContatoTelefone(string Contato)
        {
            SetDDA(DDACadastrado);
            string NomeDDA = GetDDA();

            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeDDA);
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            PreencherCNPJ();
            SelecionarAssociacao("UBEM");
            MouseActions.ClickATM(Browser, ChckAdministrador);
            CadastrarContatoTelefoneDDA(Contato);
        }

        public void CadastroContatoEmail(string Contato)
        {
            SetDDA(DDACadastrado);
            string NomeDDA = GetDDA();

            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeDDA);
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            PreencherCNPJ();
            SelecionarAssociacao("UBEM");
            MouseActions.ClickATM(Browser, ChckAdministrador);
            CadastrarContatoEmailDDA(Contato);
        }

        public void CadastroContatoCelular(string Contato)
        {
            SetDDA(DDACadastrado);
            string NomeDDA = GetDDA();

            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeDDA);
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            PreencherCNPJ();
            SelecionarAssociacao("UBEM");
            MouseActions.ClickATM(Browser, ChckAdministrador);
            CadastrarContatoCelularDDA(Contato);

        }

        public void EditarDDA(string NomeFantasia, string NomeCompleto, string CPF, string Associacao, string Administrador, string DataNascimento)
        {
            SetDDA(DDACadastrado);
            NomeFantasia = GetDDA();

            CadastrarDDA(NomeFantasia, NomeCompleto, CPF, Associacao, Administrador, DataNascimento);
        }

        public void CancelarDDAalterado()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, btnCancelarEdtDDA);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, MsgdeCancelamento);
        }

        public void PreencherCNPJ()
        {
            var cnpj = Element.Css("input[id='optionsRadios2']");
            ElementExtensions.IsElementVisible(cnpj, Browser);
            MouseActions.ClickATM(Browser, cnpj);

            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpCPF);
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, InpCPF, "30.253.090/0001-93");
        }

        public void CadastrarContatoDDA()
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            SelecionarTipoContatoDeDDA("E-mail");
            AutomatedActions.SendDataATM(Browser, InpTipoContato, "razevedo@inmetrics.com.br");
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
            MouseActions.ClickATM(Browser, BtnSalvarContatoDDA);
        }

        public void CadastrarContatoTelefoneDDA(string Contato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            Thread.Sleep(2000);
            SelecionarTipoContatoDeDDA("Telefone");
            MouseActions.ClickATM(Browser, InpTipoContato);
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpTipoContato, Contato);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
            MouseActions.ClickATM(Browser, BtnSalvarContatoDDA);
        }

        public void CadastrarContatoEmailDDA(string Contato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            Thread.Sleep(2000);
            SelecionarTipoContatoDeDDA("E-mail");
            MouseActions.ClickATM(Browser, InpTipoContato);
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpTipoContato, Contato);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
            MouseActions.ClickATM(Browser, BtnSalvarContatoDDA);
        }

        public void CadastrarContatoEmBrancoDDA(string Contato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            Thread.Sleep(2000);
            SelecionarTipoContatoDeDDA("E-mail");
            MouseActions.ClickATM(Browser, InpTipoContato);
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpTipoContato, Contato);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
        }

        public void CadastrarContatoCelularDDA(string Contato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            Thread.Sleep(2000);
            SelecionarTipoContatoDeDDA("Celular");
            MouseActions.ClickATM(Browser, InpTipoContato);
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpTipoContato, Contato);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
            MouseActions.ClickATM(Browser, BtnSalvarContatoDDA);
        }

        public void EditarDDAContatoCelular(string Contato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            MouseActions.ClickATM(Browser, btnEditarDDA);
            Thread.Sleep(2000);
            SelecionarTipoContatoDeDDA("Telefone");
            MouseActions.ClickATM(Browser, EditTelefone);
            AutomatedActions.SendData(Browser, EditTelefone, Contato);
            MouseActions.ClickATM(Browser, btatualizarContato);
            MouseActions.ClickATM(Browser, SalvarEditContato);

        }

        public void ExcluirContatoNoCadastroDDA()
        {
            var btExcluir = Element.Css("span[uib-tooltip='Excluir']");
            MouseActions.ClickATM(Browser, btExcluir);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            Thread.Sleep(1500);
        }

        public void EditarDDAContatoEmail(string Contato)
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            MouseActions.ClickATM(Browser, btnEditarDDA);
            Thread.Sleep(2000);
            var EdiContatoCadastrado = Element.Css("div[style='width:80px'] span[uib-tooltip='Editar']");
            MouseActions.ClickATM(Browser, EdiContatoCadastrado);
            Thread.Sleep(2000);
            SelecionarTipodeContatoEdi("Email");
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, EditTelefone, Contato);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtEditarContatoAtualizar);

        }
        public void EditarDDAcomFlag()
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            MouseActions.ClickATM(Browser, btnEditarDDA);
            Thread.Sleep(2000);
            var EdiContatoCadastrado = Element.Css("div[style='width:80px'] span[uib-tooltip='Editar']");
            MouseActions.ClickATM(Browser, EdiContatoCadastrado);
            Thread.Sleep(2000);
            SelecionarTipodeContatoEdi("Email");
            Thread.Sleep(2000);
            AutomatedActions.SendDataATM(Browser, EditTelefone, "teste@teste.com");
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtEditarContatoAtualizar);

        }
        private void SelecionarTipodeContatoEdi(string Valor)
        {
            var SelectEditContato = Element.Css("div[class='form-group'] select[ng-model='ContatoEditar.ItemContato.TipoContato.selected']");
            MouseActions.ClickATM(Browser, SelectEditContato);
            MouseActions.SelectElementATM(Browser, SelectEditContato, Valor);
        }

        public void ValidarDadosAlterados(string MensagemDeAlteração)
        {
            Assert.AreEqual(MensagemDeAlteração, ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser));
            Thread.Sleep(2000);
        }

        private void SelecionarTipoContatoDeDDA(string TipoContato)
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

        public void SelecionarDDA(string DDA)
        {
            var nomeDDA = Element.Xpath("//tbody//div[contains (., '" + DDA + "')]");
            MouseActions.DoubleClickATM(Browser, nomeDDA);
        }

    }
}