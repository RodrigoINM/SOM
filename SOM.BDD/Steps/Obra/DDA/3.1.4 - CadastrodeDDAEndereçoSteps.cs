using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    class CadastrodeDDAEndereçoSteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

        public CadastrodeDDAEndereçoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
        }

        [When(@"cadastro um DDA com os campos de endereço ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmDDAComOsCamposDeEnderecoE(string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            TelaCadastroDDA.CadastroDeDDAAleatorioComEndereço();
            TelaCadastroDDA.CadastrarEnderecoDDA(Logradouro, Bairro, Cidade, UF, CEP);
        }

        [Then(@"visualizo a mensagem de endereço de DDA ""(.*)""")]
        public void EntaoVisualizoAMensagemDeEnderecoDeDDA(string MensagemDeAlteração)
        {
            TelaCadastroDDA.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [When(@"cancelo o cadasto de Endereço")]
        public void QuandoCanceloOCadastoDeEndereco()
        {
            TelaCadastroDDA.ExcluirContatoNoCadastroDDA();
        }

        [When(@"cadastro um DDA com os campos de endereço internacional ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmDDAComOsCamposDeEnderecoInternacionalE(string Pais, string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            TelaCadastroDDA.CadastroDeDDAAleatorioComEndereço();
            TelaCadastroDDA.CadastrarEnderecoInternacionalDDA(Pais, Logradouro, Bairro, Cidade, UF, CEP);
        }

        [When(@"cadastro um novo endereço preenchendo os campos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmNovoEnderecoPreenchendoOsCamposE(string Pais, string Logradouro, string Bairro, string Cidade, string UF, string CEP)
        {
            TelaCadastroDDA.CadastroDeDDAAleatorioComEndereço();
            TelaCadastroDDA.CadastrarEnderecoInternacionalDDA(Pais, Logradouro, Bairro, Cidade, UF, CEP);
        }

    }
}
