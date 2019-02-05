using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Cue_Sheet
{
    [Binding]
    public class BuscarCueSheetSteps
    {
        public ConsultarCueSheetPage TelaConsultarCueSheetPage { get; private set; }

        public BuscarCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaConsultarCueSheetPage = new ConsultarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"]);
        }

        [Given(@"que esteja na tela de consulta de Cue-Sheet")]
        public void DadoQueEstejaNaTelaDeConsultaDeCue_Sheet()
        {
            TelaConsultarCueSheetPage.Navegar();
        }

        [When(@"faço uma busca rápida de Cue-Sheet sem preencher nenhum filtro")]
        public void QuandoFacoUmaBuscaRapidaDeCue_SheetSemPreencherNenhumFiltro()
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet("", "", "", "TV", "", "", "", "");
        }

        [Then(@"visualizo as Cue-Sheets cadastradas no resultado da busca com sucesso")]
        public void EntaoVisualizoAsCue_SheetsCadastradasNoResultadoDaBuscaComSucesso()
        {
            TelaConsultarCueSheetPage.ValidarCueSheet("TV");
        }

        [When(@"faço uma busca de Cue-Sheet por Produto ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorProduto(string Produto)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, "", "", "", "", "", "", "");
        }
        
        [Then(@"visualizo os dados da Cue-Sheet no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDaCue_SheetNoResultadoDaBusca(string Midia, string Produto, string Episodio, string Capitulo, 
            string DataExibicao, string RepriseRebatida, string QtdItens, string Status, string Aprovacao)
        {
            TelaConsultarCueSheetPage.ValidarCueSheet(Midia);
            TelaConsultarCueSheetPage.ValidarCueSheet(Produto);
            TelaConsultarCueSheetPage.ValidarCueSheet(Episodio);
            TelaConsultarCueSheetPage.ValidarCueSheet(Capitulo);
            TelaConsultarCueSheetPage.ValidarCueSheet(DataExibicao);
            TelaConsultarCueSheetPage.ValidarCueSheet(RepriseRebatida);
            TelaConsultarCueSheetPage.ValidarCueSheet(QtdItens);
            TelaConsultarCueSheetPage.ValidarCueSheet(Status);
            TelaConsultarCueSheetPage.ValidarCueSheet(Aprovacao);
        }

        [When(@"faço uma busca de Cue-Sheet por Produto e Episodio ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorProdutoEEpisodio(string Produto, string Episodio)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, Episodio, "", "", "", "", "", "");
        }

        [When(@"faço uma busca de Cue-Sheet por Produto, Episodio e Capítulo ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorProdutoEpisodioECapitulo(string Produto, string Episodio, string Capitulo)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, Episodio, Capitulo, "", "", "", "", "");
        }

        [When(@"faço uma busca de Cue-Sheet por Mídia e Produto ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorMidiaEProduto(string Midia, string Produto)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, "", "", Midia, "", "", "", "");
        }

        [When(@"faço uma busca de Cue-Sheet por Data de Exibição Inicial e Produto ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorDataDeExibicaoInicialEProduto(string DataExibicao, string Produto)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, "", "", "", DataExibicao, "", "", "");
        }

        [When(@"faço uma busca de Cue-Sheet por Data de Exibição Final e Produto ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorDataDeExibicaoFinalEProduto(string DataExibicao, string Produto)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, "", "", "", "", DataExibicao, "", "");
        }

        [When(@"faço uma busca de Cue-Sheet por Status, Produto e Episodio ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorStatusProdutoEEpisodio(string FiltroStatus, string Produto, string Episodio)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, Episodio, "", "", "", "", FiltroStatus, "");
        }

        [When(@"faço uma busca de Cue-Sheet por Reprise/Rebatida ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorRepriseRebatida(string FiltroRepriseRebatida, string Produto, string Episodio)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, Episodio, "", "", "", "", "", FiltroRepriseRebatida);
        }

        [When(@"faço uma busca de Cue-Sheet por Produto e Data de Exibição não associados entre si ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorProdutoEDataDeExibicaoNaoAssociadosEntreSi(string Produto, string DataExibicao)
        {
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet(Produto, "", "", "", DataExibicao, "", "", "");
        }

        [Then(@"visualizo a mensagem de que não foram encontradas Cue-Sheets com os dados informados na busca ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueNaoForamEncontradasCue_SheetsComOsDadosInformadosNaBusca(string Mensagem)
        {
            TelaConsultarCueSheetPage.ValidarDadosNaoEncontrados(Mensagem);
        }

        [When(@"faço uma busca de Cue-Sheet por Episódio sem informar o Produto ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCue_SheetPorEpisodioSemInformarOProduto(string Episodio)
        {
            TelaConsultarCueSheetPage.ConsultaDeEpisodioSemProduto(Episodio);
        }

        [Then(@"visualizo que o campo Episódio é limpo automaticamente ao clicar em pesquisar")]
        public void EntaoVisualizoQueOCampoEpisodioELimpoAutomaticamenteAoClicarEmPesquisar()
        {
            TelaConsultarCueSheetPage.ValidarCampoEpisodioEmBranco();
        }

    }
}
