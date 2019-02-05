using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    public class CadastroDeDDASteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

        public CadastroDeDDASteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
        }
        
        [Given(@"que estou com a tela Novo Cadastro de DDA")]
        public void DadoQueEstouComATelaNovoCadastroDeDDA()
        {
            TelaCadastroDDA.Navegar();
        }

        //Cadastro de DDA com sucesso
        [When(@"cadastro um novo DDA ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoDDA(string NOMEFANTASIA, string NOMECOMPLETO, string CPF, string ASSOCIACAO, string ADMINISTRADOR, string DATANASCIMENTO)
        {
            TelaCadastroDDA.CadastrarDDA(NOMEFANTASIA, NOMECOMPLETO, CPF, ASSOCIACAO, ADMINISTRADOR, DATANASCIMENTO);
        }

        [When(@"cadastro o contato do DDA ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroOContatoDoDDA(string NOMECONTATO, string TIPOCONTATO, string CONTATO, string AUTORIZACAO)
        {
            TelaCadastroDDA.CadastrarContatoDDA(NOMECONTATO, TIPOCONTATO, CONTATO, AUTORIZACAO);
            TelaCadastroDDA.ValidarContatoDDA(NOMECONTATO);
        }

        [Then(@"visualizo a mensagem de cadastro de DDA com sucesso ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeCadastroDeDDAComSucesso(string NOMEFANTASIA, string MENSAGEM)
        {
            TelaCadastroDDA.ValidarCadastroDeDDA();
            TelaConsultaDeDDAPage.ConsultaSimplesDeDDA(NOMEFANTASIA);
            TelaExclusaoDeDDAPage.ExcluirCadastroDDA(NOMEFANTASIA);
        }

        //Cadastro de DDA sem Contato para autorização
        [Then(@"visualizo uma mensagem de critica ao salvar a obra sem o contato ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeCriticaAoSalvarAObraSemOContato(string MENSAGEM)
        {
            TelaCadastroDDA.SalvarDDASemContato(MENSAGEM, "Não");
        }

        //Cadastrar DDA sem preenchimento de campo obrigatório
        [When(@"cadastro um DDA sem preenchimento dos campos dos campos obrigatorios ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmDDASemPreenchimentoDosCamposDosCamposObrigatorios(string NOMEFANTASIA, string NOMECOMPLETO, string CPF, string ASSOCIACAO, string ADMINISTRADOR, string DATANASCIMENTO)
        {
            TelaCadastroDDA.CadastrarDDA(NOMEFANTASIA, NOMECOMPLETO, CPF, ASSOCIACAO, ADMINISTRADOR, DATANASCIMENTO);
        }

        [Then(@"visualizo os campos obrigatorios em destaque")]
        public void EntaoVisualizoOsCamposObrigatoriosEmDestaque()
        {
            TelaCadastroDDA.ValidarCamposObrigatoriosDeDDA();
        }

    }
}
