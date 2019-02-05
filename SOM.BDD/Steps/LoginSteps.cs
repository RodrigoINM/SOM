using Framework.Core.Interfaces;
using SOM.BDD.Pages;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginPage TelaLogin;

        public LoginSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaLogin = new LoginPage((IBrowser)browser,
                ConfigurationManager.AppSettings["HomeURL"]);
        }
        
        [Given(@"que esteja logado no sistema SOM")]
        public void DadoQueEstejaLogadoNoSistemaSOM()
        {
            TelaLogin.LogarNoSistema();
        }

        [Given(@"que acesse o sistema")]
        public void DadoQueAcesseOSistema()
        {
            TelaLogin.Navegar();
        }

        [When(@"logo no sistema")]
        public void QuandoLogoNoSistema()
        {
            TelaLogin.Login();
        }

        [Then(@"realizo login no sistema com sucesso")]
        public void EntaoRealizoLoginNoSistemaComSucesso()
        {
            TelaLogin.ValidarLogin();
        }

    }
}
