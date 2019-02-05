using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    class AlteraçãodeDDAContatoSteps
        {
            public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
            public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
            public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

            public AlteraçãodeDDAContatoSteps()
            {
                var browser = ScenarioContext.Current["browser"];

                TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                    ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
                TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
                TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                    ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
            }
        [Given(@"que tenho um DDA cadastrado")]
        public void DadoQueTenhoUmDDACadastrado()
        {
            TelaCadastroDDA.CadastroDeDDAAleatorio();
            TelaConsultaDeDDAPage.ConsultaSimplesDeDDA(CadastroDeDDAPage.DDA);
            TelaCadastroDDA.SelecionarDDA(CadastroDeDDAPage.DDA);

        }

        [Given(@"altero o telefone ""(.*)""")]
        public void DadoAlteroOTelefone(string Contato)
        {
            TelaCadastroDDA.EditarDDAContatoCelular(Contato);
        }

        [Then(@"visualizo a mensagem do DDA alterado com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDoDDAAlteradoComSucesso(string MensagemDeAlteração)
        {
            TelaCadastroDDA.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Given(@"altero o email ""(.*)""")]
        public void DadoAlteroOEmail(string Contato)
        {
            TelaCadastroDDA.EditarDDAContatoEmail(Contato);
        }

        [Given(@"altero o a flag")]
        public void DadoAlteroOAFlag()
        {
            TelaCadastroDDA.EditarDDAcomFlag();
        }

    }
}


