using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    class AlteraçãodeDDASteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }

        public AlteraçãodeDDASteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
        }

        [When(@"altero e salvo o campo Nome Fantasia")]
        public void QuandoAlteroESalvoOCampoNomeFantasia()
        {
            TelaCadastroDDA.EditarDDA("", "", "", "", "", "");
            TelaCadastroDDA.SalvarDDAAlterado();
        }

        [Then(@"visualizo o DDA alterado")]
        public void EntaoVisualizoODDAAlterado()
        {
            TelaConsultaDeDDAPage.ConsultaSimplesDeDDA(CadastroDeDDAPage.DDA);
            TelaConsultaDeDDAPage.ValidarResultadoDaConsultaDeDDA(CadastroDeDDAPage.DDA, "","","","");
        }

        [When(@"altero e salvo o campo Razão Social ""(.*)""")]
        public void QuandoAlteroESalvoOCampoRazaoSocial(string NomeCompleto)
        {
            TelaCadastroDDA.CadastrarDDA("", NomeCompleto, "", "", "", "");
            TelaCadastroDDA.SalvarDDAAlterado();
        }

        [When(@"altero e salvo o DDA sem obras")]
        public void QuandoAlteroESalvoODDASemObras()
        {
            TelaCadastroDDA.EditarDDA("", "", "", "", "", "");
            TelaCadastroDDA.SalvarDDAAlterado();
        }

        [When(@"altero e salvo o DDA sem fonograma")]
        public void QuandoAlteroESalvoODDASemFonograma()
        {
            TelaCadastroDDA.EditarDDA("", "", "", "", "", "");
            TelaCadastroDDA.SalvarDDAAlterado();
        }

        [When(@"altero a Razão Social, e realizo o cancelamento da edição ""(.*)""")]
        public void QuandoAlteroARazaoSocialERealizoOCancelamentoDaEdicao(string NomeCompleto)
        {
            TelaCadastroDDA.CadastrarDDA("", NomeCompleto, "", "", "", "");
            TelaCadastroDDA.CancelarDDAalterado();
        }

        [Then(@"visualizo a confirmação de cancelamento de edição do DDA")]
        public void EntaoVisualizoAConfirmacaoDeCancelamentoDeEdicaoDoDDA()
        {
            TelaConsultaDeDDAPage.ValidarResultadoDaConsultaDeDDA(CadastroDeDDAPage.DDA, "", "", "", "");
        }

        [When(@"altero os campos obrigatorios de DDA e salvo")]
        public void QuandoAlteroOsCamposObrigatoriosDeDDAESalvo()
        {
            TelaCadastroDDA.EditarDDA("", "", "", "", "", "");
            TelaCadastroDDA.SalvarDDAAlterado();
        }

        [When(@"altero e salvo o campo associação do DDA ""(.*)""")]
        public void QuandoAlteroESalvoOCampoAssociacaoDoDDA(string Associacao)
        {
            TelaCadastroDDA.CadastrarDDA("", "", "", Associacao, "", "");
            TelaCadastroDDA.SalvarDDAAlterado();
        }

    }
}
