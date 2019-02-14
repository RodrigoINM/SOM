using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.Catálogo_de_Editoras;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.Catálogo_de_Editoras
{
    [Binding]
    public class CatálogodeEditoraSteps
    {
        public CatálogodeEditoraPage TelaCatálogodeEditoraPage { get; private set; }

        public CatálogodeEditoraSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCatálogodeEditoraPage = new CatálogodeEditoraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CatalogoEditorasUrl"]);
        }

        [Given(@"a tela de de Catálogo de editora esteja aberto")]
        public void DadoATelaDeDeCatalogoDeEditoraEstejaAberto()
        {
            TelaCatálogodeEditoraPage.Navegar();
        }


    }
}
