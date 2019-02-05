using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    class CadastrodeDDAContatoSteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

        public CadastrodeDDAContatoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
        }

        [When(@"cadastro um novo DDA com o contato telefone ""(.*)""")]
        public void QuandoCadastroUmNovoDDAComOContatoTelefone(string Contato)
        {
            TelaCadastroDDA.CadastroContatoTelefone(Contato);
        }

        [Then(@"visualizo a mensagem de cadastro de contato do DDA com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeCadastroDeContatoDoDDAComSucesso(string MensagemDeAlteração)
        {
            TelaCadastroDDA.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [When(@"cadastro um novo DDA com o contato Email ""(.*)""")]
        public void QuandoCadastroUmNovoDDAComOContatoEmail(string Contato)
        {
            TelaCadastroDDA.CadastroContatoEmail(Contato);
        }

        [When(@"cadastro um novo DDA com o contato Celular ""(.*)""")]
        public void QuandoCadastroUmNovoDDAComOContatoCelular(string Contato)
        {
            TelaCadastroDDA.CadastroContatoCelular(Contato);
        }

        [When(@"cancelo o cadasto de contato de email")]
        public void QuandoCanceloOCadastoDeContatoDeEmail()
        {
            TelaCadastroDDA.ExcluirContatoNoCadastroDDA();
        }

        [Then(@"ao salvar, visualizo a mensagem de cadastro de contato do DDA com sucesso ""(.*)""")]
        public void EntaoAoSalvarVisualizoAMensagemDeCadastroDeContatoDoDDAComSucesso(string MensagemDeAlteração)
        {
            TelaCadastroDDA.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [When(@"cadastro um novo DDA com o contato em branco ""(.*)""")]
        public void QuandoCadastroUmNovoDDAComOContatoEmBranco(string Contato)
        {
            TelaCadastroDDA.CadastrarContatoEmBrancoDDA(Contato);
        }

    }

}
