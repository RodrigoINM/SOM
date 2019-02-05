using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    public class ExclusaoDeDDASteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

        public ExclusaoDeDDASteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
        }
        
        [Given(@"que tenha um DDA cadastrado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmDDACadastrado(string NOMEFANTASIA, string NOMECOMPLETO, string CPF, string ASSOCIACAO, string ADMINISTRADOR, 
            string DATANASCIMENTO, string NOMECONTATO, string TIPOCONTATO, string CONTATO, string AUTORIZACAO)
        {
            TelaCadastroDDA.Navegar();
            TelaCadastroDDA.CadastrarDDA(NOMEFANTASIA, NOMECOMPLETO, CPF, ASSOCIACAO, ADMINISTRADOR, DATANASCIMENTO);
            TelaCadastroDDA.CadastrarContatoDDA(NOMECONTATO, TIPOCONTATO, CONTATO, AUTORIZACAO);
            TelaCadastroDDA.ValidarContatoDDA(NOMECONTATO);
            TelaCadastroDDA.ValidarCadastroDeDDA();
        }

        [When(@"faco uma busca simples por DDA ""(.*)""")]
        public void QuandoFacoUmaBuscaSimplesPorDDA(string NOMEFANTASIA)
        {
            TelaConsultaDeDDAPage.ConsultaSimplesDeDDA(NOMEFANTASIA);
        }

        [Then(@"visualizo a mensagem de DDA excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDDAExcluidoComSucesso(string Mensagem)
        {
            TelaExclusaoDeDDAPage.ValidarPopUpExclusaoDDASucesso(Mensagem);
        }

        [When(@"excluo o DDA ""(.*)""")]
        public void QuandoExcluoODDA(string NOMEFANTASIA)
        {
            TelaExclusaoDeDDAPage.ExcluirCadastroDDA(NOMEFANTASIA);
        }

        [When(@"cancelo a exclusão um DDA com ""(.*)""")]
        public void QuandoCanceloAExclusaoUmDDACom(string NOMEFANTASIA)
        {
            TelaExclusaoDeDDAPage.CancelarExclusaoDDA(NOMEFANTASIA);
        }

        [Then(@"visualizo o DDA no resultado da busca com sucesso ""(.*)""")]
        public void EntaoVisualizoODDANoResultadoDaBuscaComSucesso(string NOMEFANTASIA)
        {
            TelaConsultaDeDDAPage.ValidarResultadoDaConsultaDeDDA(NOMEFANTASIA, "", "", "", "");
            TelaExclusaoDeDDAPage.ExcluirCadastroDDA(NOMEFANTASIA);
        }

        //Exclusão de Endereço com sucesso
        [Given(@"que tenha um DDA cadastrado com endereço completo ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmDDACadastradoComEnderecoCompleto(string NOMEFANTASIA, string NOMECOMPLETO, string CPF, string ASSOCIACAO, string ADMINISTRADOR, 
            string DATANASCIMENTO, string LOGRADOURO, string BAIRRO, string CIDADE, string UF, string CEP)
        {
            TelaCadastroDDA.Navegar();
            TelaCadastroDDA.CadastrarDDA(NOMEFANTASIA, NOMECOMPLETO, CPF, ASSOCIACAO, ADMINISTRADOR, DATANASCIMENTO);
            TelaCadastroDDA.CadastrarEnderecoDDA(LOGRADOURO, BAIRRO, CIDADE, UF, CEP);
            TelaCadastroDDA.ValidarEnderecoDeDDA(LOGRADOURO);
        }

        [When(@"excluo um endereço do DDA ""(.*)""")]
        public void QuandoExcluoUmEnderecoDoDDA(string p0)
        {
            TelaExclusaoDeDDAPage.ExcluirEnderecoDeDDA();
        }

        [Then(@"visualizo a mensagem de endereço excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeEnderecoExcluidoComSucesso(string Mensagem)
        {
            TelaExclusaoDeDDAPage.ValidarPopUpExclusaoDDASucesso(Mensagem);
        }

        //Exclusão de Contato com sucesso
        [Given(@"que tenha um DDA cadastrado com um contato ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmDDACadastradoComUmContato(string NOMEFANTASIA, string NOMECOMPLETO, string CPF, string ASSOCIACAO, string ADMINISTRADOR,
            string DATANASCIMENTO, string NOMECONTATO, string TIPOCONTATO, string CONTATO, string AUTORIZACAO)
        {
            TelaCadastroDDA.Navegar();
            TelaCadastroDDA.CadastrarDDA(NOMEFANTASIA, NOMECOMPLETO, CPF, ASSOCIACAO, ADMINISTRADOR, DATANASCIMENTO);
            TelaCadastroDDA.CadastrarContatoDDA(NOMECONTATO, TIPOCONTATO, CONTATO, AUTORIZACAO);
            TelaCadastroDDA.ValidarContatoDDA(NOMECONTATO);
        }

        [When(@"excluo um contato do DDA ""(.*)""")]
        public void QuandoExcluoUmContatoDoDDA(string p0)
        {
            TelaExclusaoDeDDAPage.ExcluirContatoDeDDA();
        }

        [Then(@"visualizo a mensagem de contato excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeContatoExcluidoComSucesso(string Mensagem)
        {
            TelaExclusaoDeDDAPage.ValidarPopUpExclusaoDDASucesso(Mensagem);
        }

        //Exclusão de Contato que recebe autorização
        [Then(@"visualizo uma mesnagem de critica ao tentar salvar a obra sem o contato ""(.*)""")]
        public void EntaoVisualizoUmaMesnagemDeCriticaAoTentarSalvarAObraSemOContato(string Mensagem)
        {
            TelaCadastroDDA.SalvarDDASemContato(Mensagem, "Sim");
        }

    }
}
