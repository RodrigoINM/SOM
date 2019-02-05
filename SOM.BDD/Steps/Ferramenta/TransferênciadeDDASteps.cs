using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta;
using SOM.BDD.Pages.Ferramenta.Midia;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta
{
    [Binding]
    public sealed class TransferênciadeDDASteps
    {
        public TransferênciadeDDAPage TelaTransferênciadeDDAPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }

        public TransferênciadeDDASteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaTransferênciadeDDAPage = new TransferênciadeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["TransferenciaDeDDAUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
        }

        [Given(@"que a tela Transferência de DDA \(De/Para\) esteja aberta")]
        public void DadoQueATelaTransferenciaDeDDADeParaEstejaAberta()
        {
            TelaTransferênciadeDDAPage.Navegar();
        }

        [When(@"realizo uma Transferência preenchendo os campos NomeDDADe e NomeDDAPara ""(.*)"" , ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaPreenchendoOsCamposNomeDDADeENomeDDAPara(string De, string Para)
        {
            TelaTransferênciadeDDAPage.TranferenciaDDA(De, Para);
            TelaTransferênciadeDDAPage.SalvarTransferencia();
        }

        [Then(@"visualizo a mensagem de confirmação de trasferencia de DDA ""(.*)""")]
        public void EntaoVisualizoAMensagemDeConfirmacaoDeTrasferenciaDeDDA(string MensagemDeAlteração)
        {
            TelaTransferênciadeDDAPage.ConfirmarTransferencia();
            TelaTransferênciadeDDAPage.ValidarDadosAlterados(MensagemDeAlteração);
            TelaTransferênciadeDDAPage.TranferenciaDDA("JU MEDEIROS", "AMORINA");
            TelaTransferênciadeDDAPage.SalvarTransferencia();
            TelaTransferênciadeDDAPage.ConfirmarTransferencia();
            TelaTransferênciadeDDAPage.ValidarDadosAlterados(MensagemDeAlteração);

        }

        [Then(@"visualizo os campos NomeDDADe e NomeDDAPara em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposNomeDDADeENomeDDAParaEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeDDAPage.ValidarCamposTransferenciaDDA();
        }

        [Then(@"visualizo os campos NomeDDADe em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposNomeDDADeEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeDDAPage.ValidarCampoNomeDDADe();
        }

        [Then(@"visualizo os campos NomeDDAPara em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposNomeDDAParaEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeDDAPage.ValidarCampoNomeDDAPara();
        }

        [Given(@"que a tenho um DDA disponivel para exclusão")]
        public void DadoQueATenhoUmDDADisponivelParaExclusao()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaTransferênciadeDDAPage.Navegar();
        }

        [When(@"realizo uma transferência de DDA preenchendo os campos NomeDDADe e NomeDDAPara (.*) , ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaDeDDAPreenchendoOsCamposNomeDDADeENomeDDAPara(string p0, string Para)
        {
            TelaTransferênciadeDDAPage.TranferenciaDDA(CadastrarObraEComposicaoPage.DDA, Para);
        }

        [When(@"seleciono a CheckBox de exclusão de DDADe")]
        public void QuandoSelecionoACheckBoxDeExclusaoDeDDADe()
        {
            TelaTransferênciadeDDAPage.ConfirmarExclusãoDDADe();
        }

        [Then(@"visualizo a mensagem de confirmação de exclusão de DDADe ""(.*)""")]
        public void EntaoVisualizoAMensagemDeConfirmacaoDeExclusaoDeDDADe(string MensagemDeAlteração)
        {
            TelaTransferênciadeDDAPage.ConfirmarDePara();
            TelaTransferênciadeDDAPage.ValidarDadosAlterados(MensagemDeAlteração);

        }

        [Given(@"que tenho um DDA sem obras")]
        public void DadoQueTenhoUmDDASemObras()
        {
            TelaCadastroDDA.Navegar();
            TelaCadastroDDA.CadastroDeDDAAleatorio();
            TelaTransferênciadeDDAPage.Navegar();
        }

        [When(@"realizo uma Transferência DDA sem obras preenchendo os campos NomeDDADe e NomeDDAPara ""(.*)"" , ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaDDASemObrasPreenchendoOsCamposNomeDDADeENomeDDAPara(string p0, string Para)
        {
            TelaTransferênciadeDDAPage.TranferenciaDDA(CadastroDeDDAPage.DDA, Para);
            TelaTransferênciadeDDAPage.ConfirmarDePara();
        }

        [Then(@"visualizo a mensagem de DDA não possui obras ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDDANaoPossuiObras(string Mensagem)
        {
            TelaTransferênciadeDDAPage.ValidarAlerta(Mensagem);
        }

        [Then(@"visualizo a mensagem de DDA, operação cancelada ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDDAOperacaoCancelada(string Mensagem)
        {
            TelaTransferênciadeDDAPage.ValidarAlerta(Mensagem);
        }


    }
}
