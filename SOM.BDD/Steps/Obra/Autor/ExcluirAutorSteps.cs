using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.Autor;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD
{
    [Binding]
    public class ExcluirAutorSteps
    {
        public ExclusaoDeAutorPage TelaExclusaDeAutorPage { get; private set; }
        public AlterarAutorPage TelaAlterarAutorPage { get; private set; }

        public ExcluirAutorSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaExclusaDeAutorPage = new ExclusaoDeAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeAutorUrl"]);
            TelaAlterarAutorPage = new AlterarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeAutorUrl"]);
        }
        
        [Given(@"que faço uma busca por ""(.*)""")]
        public void DadoQueFacoUmaBuscaPor(string NomeArtistico)
        {
            TelaAlterarAutorPage.ConsultaSimplesDoAutor(NomeArtistico);
        }

        [When(@"faco a exclusao do autor ""(.*)""")]
        public void QuandoFacoAExclusaoDoAutor(string NomeArtistico)
        {
            TelaExclusaDeAutorPage.ExcluirAutor(NomeArtistico);
        }


        [Then(@"visualizo a ""(.*)"" de exclusao com sucesso")]
        public void EntaoVisualizoADeExclusaoComSucesso(string MensagemDeExcluir)
        {
            TelaExclusaDeAutorPage.ValidarPopUpExclusaoAutorSucesso(MensagemDeExcluir);
        }

    }
}
