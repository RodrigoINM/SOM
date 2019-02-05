using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta
{
    [Binding]
    public class TransferênciadeControleEditorialSteps
    {
        public TransferênciadeControleEditorialPage TelaTransferênciadeControleEditorialPage { get; private set; }

        public TransferênciadeControleEditorialSteps()
         {
             var browser = ScenarioContext.Current["browser"];

             TelaTransferênciadeControleEditorialPage = new TransferênciadeControleEditorialPage((IBrowser)browser,
                ConfigurationManager.AppSettings["TransferenciaControleEditorialUrl"]);
         }

        [Given(@"a tela Transferência de Controle Editorial \(De/Para\) esteja aberta")]
        public void DadoATelaTransferenciaDeControleEditorialDeParaEstejaAberta()
        {
            TelaTransferênciadeControleEditorialPage.Navegar();
        }

        [When(@"realizo uma Transferência sem preencher os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaSemPreencherOsCamposNomeAutorDeNomeAutorParaNomeAutorDeNomeDDADeNomeDDAParaE(string AutorDe, string AutorPara, string DDDADe, string DDAPara)
        {
            TelaTransferênciadeControleEditorialPage.TransferenciaCE(AutorDe, AutorPara, DDDADe, DDAPara);
            TelaTransferênciadeControleEditorialPage.SalvarTransferencia();
        }


        [Then(@"visualizo os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara em destaque para preenchimento\.")]
        public void EntaoVisualizoOsCamposNomeAutorDeNomeAutorParaNomeAutorDeNomeDDADeNomeDDAParaEmDestaqueParaPreenchimento_()
        {
            TelaTransferênciadeControleEditorialPage.ValidarCamposTransferenciaCE();
        }


        [Then(@"visualizo a mensagem de confirmação de trasnferencia de Controle Editorial ""(.*)""")]
        public void EntaoVisualizoAMensagemDeConfirmacaoDeTrasnferenciaDeControleEditorial(string Mensagem)
        {
            TelaTransferênciadeControleEditorialPage.ConfirmarTranferencia();
            TelaTransferênciadeControleEditorialPage.ValidarPopup(Mensagem);
            TelaTransferênciadeControleEditorialPage.TransferenciaCE("WILL HOLLAND", "RICARDO LEAO", "DECK", "A DESCO");
            TelaTransferênciadeControleEditorialPage.SalvarTransferencia();
            TelaTransferênciadeControleEditorialPage.ConfirmarTranferencia();
            TelaTransferênciadeControleEditorialPage.ValidarPopup(Mensagem);
        }

        [Then(@"visualizo a mensagem que o autor não possue obras no DDA informado ""(.*)""")]
        public void EntaoVisualizoAMensagemQueOAutorNaoPossueObrasNoDDAInformado(string Mensagem)
        {
            TelaTransferênciadeControleEditorialPage.MensagemAutorDeValidação(Mensagem);
        }

        [Then(@"visualizo a mensagem de operação cancelada ""(.*)""")]
        public void EntaoVisualizoAMensagemDeOperacaoCancelada(string Mensagem)
        {
            TelaTransferênciadeControleEditorialPage.MensagemAutorDeValidação(Mensagem);
        }

        [Then(@"visualizo a campo AutorDe em destaque para preenchimento")]
        public void EntaoVisualizoACampoAutorDeEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeControleEditorialPage.ValidarCampoAutor();
        }

    }
}
