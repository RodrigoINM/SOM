using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta.Midia;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta.Midia
{
    [Binding]
    public class BuscarMídiaSteps
    {
        public AlterarMidiaPage TelaAlterarMidiaPage { get; private set; }

        public BuscarMídiaSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaAlterarMidiaPage = new AlterarMidiaPage((IBrowser)browser,
                ConfigurationManager.AppSettings["AlterarMidiaUrl"]);
        }

        [When(@"realizo uma pesquisa sem preencher o campo buscar midia")]
        public void QuandoRealizoUmaPesquisaSemPreencherOCampoBuscarMidia()
        {
            TelaAlterarMidiaPage.BuscaSimples();
        }

        [Then(@"visualizo a grid com os campos Midia, Ar e Ativa preenchidos com todas as mídias\.")]
        public void EntaoVisualizoAGridComOsCamposMidiaArEAtivaPreenchidosComTodasAsMidias_()
        {
            TelaAlterarMidiaPage.ValidarCamposPesquisarMidia();
        }

        [When(@"realizo uma busca preenchendo o campo ""(.*)""")]
        public void QuandoRealizoUmaBuscaPreenchendoOCampo(string NomeMidia)
        {
            TelaAlterarMidiaPage.BuscarMidia(NomeMidia);
        }

        [Then(@"visualizo a mensagem de dados encontrados ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDadosEncontrados(string Mensagem)
        {
            TelaAlterarMidiaPage.ValidarDadosNaoEncontrados(Mensagem);
        }

        [When(@"realizo uma busca com filtro Ativa")]
        public void QuandoRealizoUmaBuscaComFiltroAtiva()
        {
            TelaAlterarMidiaPage.BuscaAtiva();
        }

        [When(@"realizo uma busca selecionando o campo Ar ""(.*)""")]
        public void QuandoRealizoUmaBuscaSelecionandoOCampoAr(string FiltroAr)
        {
            TelaAlterarMidiaPage.BuscarFiltroAr(FiltroAr);
        }



    }
}
