using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Obra.Autor;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD
{
    [Binding]
    public class AlterarAutorSteps
    {
        public AlterarAutorPage TelaAlterarAutor { get; private set; }
        public CadastrarAutorPage TelaCadastrarAutor { get; private set; }
        public CadastrarAutorSteps CadastrarAutorSteps { get; private set; }

        public AlterarAutorSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarAutor = new CadastrarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroAutorUrl"]);
            TelaAlterarAutor = new AlterarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeAutorUrl"]);
            CadastrarAutorSteps = new CadastrarAutorSteps();
            
        }

        [Given(@"que tenha um Autor previamente cadastrado")]
        public void DadoQueTenhaUmAutorPreviamenteCadastrado()
        {
            CadastrarAutorSteps.QuandoCadastroUmNovoAutor();
        }

        [When(@"faco uma busca por ""(.*)""")]
        public void QuandoFacoUmaBuscaPor(string NomeDeAlterarAutor)
        {
            TelaAlterarAutor.Navegar();
            TelaAlterarAutor.ConsultaSimplesDoAutor(NomeDeAlterarAutor);
            TelaAlterarAutor.DuploClick(NomeDeAlterarAutor);
        }

        [When(@"altero os dados ""(.*)"", ""(.*)"" do autor")]
        public void QuandoAlteroOsDadosDoAutor(string NomeAutor, string NomeCompleto)
        {
            TelaCadastrarAutor.CadastroAutor(NomeAutor, NomeCompleto);
        }

        [Then(@"a ""(.*)"" e apresentada conforme alteracao do ""(.*)""")]
        public void EntaoAEApresentadaConformeAlteracaoDo(string Mensagem, string NomeArtistico)
        {
            TelaAlterarAutor.ValidarAltAutor(Mensagem);
            QuandoFacoUmaBuscaPor(NomeArtistico);
            QuandoAlteroOsDadosDoAutor("Teste Automatizado", "Teste de Sistemas");
            TelaAlterarAutor.ValidarAltAutor(Mensagem);
            QuandoFacoUmaBuscaPor("Teste Automatizado");
        }
    }
}
