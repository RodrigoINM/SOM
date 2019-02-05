using Framework.Core.Interfaces;
using Framework.IoC;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Obra.Autor;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Hooks
{
    [Binding]
    public class FeatureHook
    {
        private static IBrowser Browser;

        public CadastrarAutorPage TelaCadastro { get; private set; }
        public ExclusaoDeAutorPage TelaExclusaDeAutorPage { get; private set; }

        public FeatureHook()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastro = new CadastrarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroAutorUrl"]);
            TelaExclusaDeAutorPage = new ExclusaoDeAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeAutorUrl"]);
        }

        [BeforeScenario]
        public static void Before()
        {
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/c taskkill /im chrome.exe /f";
            //Process.Start(startInfo);

            //startInfo.Arguments = "/c taskkill /im chromedriver.exe /f";
            //Process.Start(startInfo);

            Browser = BrowserBuilder.ObterBrowser(
                         ScenarioContext.Current.ScenarioInfo.Tags.FirstOrDefault(f => f == "chrome" || f == "firefox" || f == "ie"));

            Thread.Sleep(1000);
            Browser.Iniciar();

            ScenarioContext.Current.Add("browser", Browser);
        }

        public static void FinalizarDriver()
        {
            Browser.Finalizar();
        }

        public static void FecharDriver()
        {
            Browser.Fechar();
        }

        [AfterScenario]
        public void ExcluirMassas()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("excluirAutor"))
            {
                TelaExclusaDeAutorPage.Navegar();
                TelaCadastro.ConsultaSimplesAutor("Teste de Autor INM");
                TelaExclusaDeAutorPage.ExcluirAutor("Teste de Autor INM");
                TelaExclusaDeAutorPage.ValidarExclusaoDoAutor("Teste de Autor INM");
            }
            FecharDriver();
        }

        [AfterFeature("kill_Driver")]
        public static void MatarDriver()
        {
            Browser.KillDriver();
            //Browser.KillChrome();
        }
    }
}
