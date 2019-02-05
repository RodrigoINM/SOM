using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta.Midia;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta.Midia
{
    [Binding]
    public class AlterarMidiaSteps
    {
        public AlterarMidiaPage TelaAlterarMidiaPage { get; private set; }

        public AlterarMidiaSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaAlterarMidiaPage = new AlterarMidiaPage((IBrowser)browser,
                ConfigurationManager.AppSettings["AlterarMidiaUrl"]);
        }

        [Given(@"que esteja na tela consultar mídia")]
        public void DadoQueEstejaNaTelaConsultarMidia()
        {
            TelaAlterarMidiaPage.Navegar();
        }

        [When(@"altero uma midia cadastrada, limpando o nome ""(.*)""")]
        public void QuandoAlteroUmaMidiaCadastradaLimpandoONome(string NomeMidia)
        {
            TelaAlterarMidiaPage.BuscaInativo("novo t");
            TelaAlterarMidiaPage.AlterarNomeMidia(NomeMidia);
            TelaAlterarMidiaPage.SalvarAlteracaoMidia();
        }

        [Then(@"visualizo o campo Midia Nome em destaque para preenchimento\.")]
        public void EntaoVisualizoOCampoMidiaNomeEmDestaqueParaPreenchimento_()
        {
            TelaAlterarMidiaPage.ValidarCampoNomeMidia();
        }


    }
}
