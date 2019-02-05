
using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Obra.Autor;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD
{
    [Binding]
    public class CadastrarAutorSteps
    {
        public CadastrarAutorPage TelaCadastro { get; set; }
        public ExclusaoDeAutorPage TelaExclusaDeAutorPage { get; private set; }
        public AlterarAutorPage TelaAlterarAutor { get; private set; }

        public CadastrarAutorSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastro = new CadastrarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroAutorUrl"]);
            TelaExclusaDeAutorPage = new ExclusaoDeAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeAutorUrl"]);
            TelaAlterarAutor = new AlterarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeAutorUrl"]);
        }

        [When(@"cadastro um novo autor")]
        public void QuandoCadastroUmNovoAutor()
        {
            DadoQueEstejaNaTelaDeCadastroAutor();
            QuandoCadastroUmNovoAutorComOsCamposE("TESTE INM", "TESTE INM COMPLETO");
            QuandoInformoOsDadosDeEnderecoE("Novo Logadouro", "Teste01", "Cidade01", "21210170");
            QuandoInformoOsDadosDeContatoE("NovoTeste", "Telefone", "2133445566");
            TelaCadastro.ValidarCadastroAutor();
        }

        [Given(@"que esteja na tela de cadastro Autor")]
        public void DadoQueEstejaNaTelaDeCadastroAutor()
        {
            TelaCadastro.Navegar();
        }

        [When(@"cadastro um novo autor com os campos ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmNovoAutorComOsCamposE(string NomeAutor, string NomeCompleto)
        {
            TelaCadastro.CadastroAutor(NomeAutor, NomeCompleto);
        }
        
        [When(@"informo os dados de endereco: ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoInformoOsDadosDeEnderecoE(string Logradouro, string Bairro, string Cidade, string CEP)
        {
            TelaCadastro.AbaCadastroEndereço();
            TelaCadastro.CadastrarEndereco(Logradouro, Bairro, Cidade, CEP, "Sim");
            TelaCadastro.ValidarMensagemEndereco(Logradouro);
        }
        
        [When(@"informo os dados de contato: ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoInformoOsDadosDeContatoE(string Nome, string Contato, string Telefone)
        {
            TelaCadastro.AbadeContato();
            TelaCadastro.CadastrarContato(Nome, Contato, Telefone);
            TelaCadastro.btSalvarCadastro("Sim");
        }

        [Then(@"visualizo a ""(.*)"" do Autor cadastrado com sucesso para o ""(.*)""")]
        public void EntaoVisualizoADoAutorCadastradoComSucessoParaO(string Mensagem, string NomeAutor)
        {
            TelaCadastro.ValidarCadastroAutor();
            TelaCadastro.ValidarMensagem(Mensagem);
            //TelaCadastro.ConsultaSimplesAutor(NomeAutor);
            //TelaExclusaDeAutorPage.ExcluirAutor(NomeAutor);
        }

        //TESTE DE CADASTRO COM CAMPO EM BRANCO//
        [When(@"tento cadastrar um autor sem informar o ""(.*)""")]
        public void QuandoTentoCadastrarUmAutorSemInformarO(string NomeAutor)
        {
            TelaCadastro.CadastrarCampoVazio(NomeAutor);
        }

        [Then(@"visualizo o campo em destaque do cadastro de autor")]
        public void EntaoVisualizoOCampoEmDestaqueDoCadastroDeAutor()
        {
            TelaCadastro.ValidarcampoAutor();
        }

        //TESTE DE CADASTRO IGUAL//
        [When(@"cadastro um autor com ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmAutorComE(string NomeAutor, string NomeCompleto)
        {
            TelaCadastro.CadastroAutor(NomeAutor, NomeCompleto);
            TelaCadastro.ValidarCadastroAutor();
            TelaCadastro.ValidarBotaoFiltro();
        }

        [When(@"tento cadastrar um novo autor com os mesmos dados de ""(.*)"" e ""(.*)""")]
        public void QuandoTentoCadastrarUmNovoAutorComOsMesmosDadosDeE(string NomeAutor, string NomeCompleto)
        {
            DadoQueEstejaNaTelaDeCadastroAutor();
            TelaCadastro.CadastroAutor(NomeAutor, NomeCompleto);
        }

        [Then(@"visualizo a ""(.*)"" que ja existe um autor ""(.*)"" cadastrados com esses dados")]
        public void EntaoVisualizoAQueJaExisteUmAutorCadastradosComEssesDados(string MensagemIgual, string NomeAutor)
        {
            TelaCadastro.BotaoSalvar();
            TelaCadastro.ValidarAutorIgual(MensagemIgual);
            //TelaAlterarAutor.Navegar();
            //TelaCadastro.ConsultaSimplesAutor(NomeAutor);
            //TelaExclusaDeAutorPage.ExcluirAutor(NomeAutor);
        }

        //TESTE COM CAMPOS DE ENDEREÇO EM DESTAQUE//
        [When(@"realizo um cadastro de autor com os campos ""(.*)"" e ""(.*)""")]
        public void QuandoRealizoUmCadastroDeAutorComOsCamposE(string NomeAutor, string NomeCompleto)
        {
            QuandoCadastroUmNovoAutorComOsCamposE(NomeAutor, NomeCompleto);
        }

        [When(@"tento adicionar um endereco sem preencher os campos ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoTentoAdicionarUmEnderecoSemPreencherOsCamposE(string Logradouro, string Bairro, string Cidade, string CEP)
        {
            TelaCadastro.AbaCadastroEndereço();
            TelaCadastro.CadastrarEndereco(Logradouro, Bairro, Cidade, CEP, "Sim");
        }

        [Then(@"visualizo os campos em destaque")]
        public void EntaoVisualizoOsCamposEmDestaque()
        {
            TelaCadastro.ValidarCamposDeEndereço();
        }

        //TESTE COM CAMPOS DE CONTATO EM DESTAQUE//
        [When(@"cadastro um novo autor com ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmNovoAutorComE(string NomeAutor, string NomeCompleto)
        {
            QuandoCadastroUmNovoAutorComOsCamposE(NomeAutor, NomeCompleto);
        }

        [When(@"tento adicionar um contato sem preencher o campos ""(.*)""")]
        public void QuandoTentoAdicionarUmContatoSemPreencherOCampos(string NomeContato)
        {
            TelaCadastro.ValidarContatoAutor(NomeContato,"Sim");
        }

        [Then(@"visualizo o campo Nome da aba de contato em destaque")]
        public void EntaoVisualizoOCampoNomeDaAbaDeContatoEmDestaque()
        {
            TelaCadastro.ValidarCampoContato();
        }

        //TESTE COM TIPOS DE CONTATOS//
        [When(@"cadastro um autor preenchendo os campos de ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmAutorPreenchendoOsCamposDeE(string NomeAutor, string NomeCompleto)
        {
            QuandoCadastroUmNovoAutorComOsCamposE(NomeAutor, NomeCompleto);
        }

        [When(@"incluir um novo contato com ""(.*)"",""(.*)"" e ""(.*)""")]
        public void QuandoIncluirUmNovoContatoComE(string Nome, string Contato, string Telefone)
        {
            TelaCadastro.AbadeContato();
            TelaCadastro.CadastrarContato(Nome, Contato, Telefone);
            TelaCadastro.btSalvarCadastro("Sim");
        }

        [Then(@"visualizo a ""(.*)"" com sucesso")]
        public void EntaoVisualizoAComSucesso(string MensagemDeContato)
        {
            TelaCadastro.ValidarMensagemContato(MensagemDeContato);
        }

        //CADASTRAR MAIS DE UM CONTATO//
        [Given(@"que no cadastramento de um novo autor preencho os campo ""(.*)"" e ""(.*)""")]
        public void DadoQueNoCadastramentoDeUmNovoAutorPreenchoOsCampoE(string NomeAutor, string NomeCompleto)
        {
            QuandoCadastroUmNovoAutorComOsCamposE(NomeAutor, NomeCompleto);
        }

        [When(@"incluir um contato com ""(.*)"",""(.*)"" e ""(.*)""")]
        public void QuandoIncluirUmContatoComE(string Nome, string Contato, string Telefone)
        {
            TelaCadastro.AbadeContato();
            TelaCadastro.CadastrarContato(Nome, Contato, Telefone);
        }

        [When(@"incluir mais um contato ""(.*)"" e ""(.*)""")]
        public void QuandoIncluirMaisUmContatoE(string Contato, string Telefone)
        {
            TelaCadastro.AddNovoContato();
            TelaCadastro.CadastrarMaisContato(Contato, Telefone);
            TelaCadastro.AddNovoContato();
        }


        [Then(@"visualizo os ""(.*)"" cadastrados com sucesso na aba de contatos do autor")]
        public void EntaoVisualizoOsCadastradosComSucessoNaAbaDeContatosDoAutor(string Nome)
        {
            TelaCadastro.btSalvarCadastro("Sim");
            TelaCadastro.ValidarConteudoContato(Nome);
        }

        //CADASTRAR MAIS ENDEREÇOS//
        [Given(@"que no cadastro de um autor preencho os seguintes campos ""(.*)"" e ""(.*)""")]
        public void DadoQueNoCadastroDeUmAutorPreenchoOsSeguintesCamposE(string NomeAutor, string NomeCompleto)
        {
            QuandoCadastroUmNovoAutorComOsCamposE(NomeAutor, NomeCompleto);
        }

        [When(@"incluir um novo endereco informando os campos ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoIncluirUmNovoEnderecoInformandoOsCamposE(string Logradouro, string Bairro, string Cidade, string CEP)
        {
            TelaCadastro.AbaCadastroEndereço();
            TelaCadastro.CadastrarEndereco(Logradouro, Bairro, Cidade, CEP, "Sim");
            TelaCadastro.BtnADDEndereço();

        }

        [When(@"incluir mais um endereco informando os campos ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoIncluirMaisUmEnderecoInformandoOsCamposE(string Logradouro, string Bairro, string Cidade, string CEP)
        {

            TelaCadastro.CadastrarEndereco(Logradouro, Bairro, Cidade, CEP, "Sim");
        }

        [Then(@"visualizo os endereços ""(.*)"" e ""(.*)"" cadastrados com sucesso")]
        public void EntaoVisualizoOsEnderecosECadastradosComSucesso(string Logradouro, string p1)
        {
            TelaCadastro.ValidarMensagemEndereco(Logradouro);
        }
        //ANO FALECIMENTO 70 ANOS//
        [When(@"crio um Autor informando ""(.*)"" e ""(.*)""")]
        public void QuandoCrioUmAutorInformandoE(string NomeAutor, string NomeCompleto)
        {
            QuandoCadastroUmNovoAutorComOsCamposE(NomeAutor, NomeCompleto);
        }

        [When(@"preencho o campo de Ano Falecimento ""(.*)"" igual a (.*) anos")]
        public void QuandoPreenchoOCampoDeAnoFalecimentoIgualAAnos(string AnoFalecimento, int p1)
        {
            TelaCadastro.InformarAnoFalecimento(AnoFalecimento);
        }

        [Then(@"visualizo o ano de falecimento do autor cadastrado como não")]
        public void EntaoVisualizoOAnoDeFalecimentoDoAutorCadastradoComoNao()
        {
            TelaCadastro.ValidarCadastroAutor();
            TelaCadastro.ConsultaSimplesAutor("Teste de Autor INM");
            TelaCadastro.ValidarResultadoDaConsultaDeAutor("Teste de Autor INM", "Teste de Autor INM Completo", "Não", "Não");
        }

        //ANO FALECIMENTO ACIMA DE 70 ANOS//
        [When(@"preencho o campo de Ano Falecimento ""(.*)"" acima de (.*) anos")]
        public void QuandoPreenchoOCampoDeAnoFalecimentoAcimaDeAnos(string AnoFalecimento, int p1)
        {
            TelaCadastro.InformarAnoFalecimento(AnoFalecimento);
        }

        [Then(@"visualizo o ano de falecimento do autor cadastrado como sim")]
        public void EntaoVisualizoOAnoDeFalecimentoDoAutorCadastradoComoSim()
        {
            TelaCadastro.ValidarCadastroAutor();
            TelaCadastro.ConsultaSimplesAutor("Teste de Autor INM");
            TelaCadastro.ValidarResultadoDaConsultaDeAutor("Teste de Autor INM", "Teste de Autor INM Completo", "Não", "Sim");
        }

    }

}

