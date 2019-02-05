using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra
{
    [Binding]
    public sealed class AlterarComposiçãoSteps
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public ExcluirObraPage TelaExcluirObraPage { get; private set; }

        public AlterarComposiçãoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);

            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);

            TelaExcluirObraPage = new ExcluirObraPage((IBrowser)browser);
        }

        [When(@"altero os valores de Autor, DDA , Versionista e salvo a composicao ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoAlteroOsValoresDeAutorDDAVersionistaESalvoAComposicaoE(string Autor, string DDA, string Valor)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao("Autor");
            TelaCadastrarObraEComposicaoPage.AlterarAutorComposicaoEditar(Autor);
            TelaCadastrarObraEComposicaoPage.AlterarDDDAComposicaoEditar(DDA);
            TelaCadastrarObraEComposicaoPage.MarcarVersionista(Valor);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();

        }

        [When(@"altero e salvo o percentual da composição superior ao permitido ""(.*)""")]
        public void QuandoAlteroESalvoOPercentualDaComposicaoSuperiorAoPermitido(string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao("Autor");
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Percentual, "");
        }


        [Then(@"visualizo a mensagem Percentual ""(.*)""")]
        public void EntaoVisualizoAMensagemPercentual(string Mensagem)
        {
            TelaCadastrarObraEComposicaoPage.ValidarPopupPercentualAcimaDoPermitido(Mensagem);
        }

        [When(@"altero e salvo o percentual da composição inferior ao permitido ""(.*)""")]
        public void QuandoAlteroESalvoOPercentualDaComposicaoInferiorAoPermitido(string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao("Autor");
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Percentual, "");
        }

        [When(@"altero e salvo o a duplicidade da obra")]
        public void QuandoAlteroESalvoOADuplicidadeDaObra()
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao("Autor");
            TelaCadastrarObraEComposicaoPage.CadastrarDuplicidadeParaCompositor();
        }
        
        [Then(@"visualizo o icone em destaque")]
        public void EntaoVisualizoOIconeEmDestaque()
        {
            TelaCadastrarObraEComposicaoPage.IconeDuplicidade();
        }

    }
}
