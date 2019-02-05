using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta.Midia;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta.Midia
{
    [Binding]
    public class CadastrarMidiaSteps
    {
        public CadastrarMidiaPage TelaCadastrarMidiaPage { get; private set; }

        public CadastrarMidiaSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarMidiaPage = new CadastrarMidiaPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarMidiaUrl"]);

        }

        [Given(@"que esteja na tela de cadastrar midia")]
        public void DadoQueEstejaNaTelaDeCadastrarMidia()
        {
            TelaCadastrarMidiaPage.Navegar();
        }

        [When(@"cadastrar um Mídia preenchendo o campo ""(.*)""")]
        public void QuandoCadastrarUmMidiaPreenchendoOCampo(string Midia)
        {
            TelaCadastrarMidiaPage.CadastrarMidia(Midia);
        }

        [Then(@"visualizo a mensagem de Midia já cadastrada ""(.*)""")]
        public void EntaoVisualizoAMensagemDeMidiaJaCadastrada(string Mensagem)
        {
            TelaCadastrarMidiaPage.MensagemMidia(Mensagem);
        }

        [When(@"cadastrar uma Mídia preenchendo o campo ""(.*)""")]
        public void QuandoCadastrarUmaMidiaPreenchendoOCampo(string Midia)
        {
            TelaCadastrarMidiaPage.CadastrarMidiaAtivo(Midia);
        }

        [Then(@"seleciono o campo ativar midia")]
        public void EntaoSelecionoOCampoAtivarMidia()
        {
            TelaCadastrarMidiaPage.CadastrarMidiaAtiva();
        }


    }
}
