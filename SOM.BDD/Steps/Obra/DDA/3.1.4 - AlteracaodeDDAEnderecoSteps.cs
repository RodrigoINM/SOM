using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    class AlteracaodeDDAEnderecoSteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

        public AlteracaodeDDAEnderecoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
        }

        [Given(@"altero os campos de endereço do DDA ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void DadoAlteroOsCamposDeEnderecoDoDDAE(string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            TelaCadastroDDA.AlterarEnderecoDDA(Logradouro, Bairro, Cidade, UF, CEP);
        }

        [Then(@"visualizo a mensagem de enderço do DDA alterado com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeEndercoDoDDAAlteradoComSucesso(string MensagemDeAlteração)
        {
            TelaCadastroDDA.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Given(@"altero os campos de endereço internacional do DDA ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void DadoAlteroOsCamposDeEnderecoInternacionalDoDDAE(string Pais, string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            TelaCadastroDDA.AlterarEnderecoInternacionalDDA(Pais, Logradouro, Bairro, Cidade, UF, CEP);
        }

    }
}
