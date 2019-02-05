using Framework.Core.Interfaces;
using SOM.BDD.Pages.Produto.Capitulo;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Capitulo
{
    [Binding]
    public sealed class ExcluirCapituloSteps
    {
        public CadastrarCapituloPage TelaCadastrarCapituloPage { get; private set; }

        public ExcluirCapituloSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCapituloPage = new CadastrarCapituloPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCapituloUrl"],
                ConfigurationManager.AppSettings["ConsultaDeCapituloUrl"]);
        }

        [When(@"excluo o capitulo do produto cadastrado ""(.*)""")]
        public void QuandoExcluoOCapituloDoProdutoCadastrado(string Produto)
        {
            TelaCadastrarCapituloPage.ExcluirCapitulo(Produto, "Sim");
        }

        [Then(@"visualizo a mensagem de capítulo excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeCapituloExcluidoComSucesso(string Mensagem)
        {
            TelaCadastrarCapituloPage.ValidarCapituloExcluido(Mensagem);
        }

        [When(@"cancelo a exclusão do capitulo do produto cadastrado ""(.*)""")]
        public void QuandoCanceloAExclusaoDoCapituloDoProdutoCadastrado(string Produto)
        {
            TelaCadastrarCapituloPage.ExcluirCapitulo(Produto, "Não");
        }

    }
}
