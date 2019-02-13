
using Framework.Core.Interfaces;
using SOM.BDD.Pages.UsoEReporte.RelatorioECAD;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.RelatorioECAD
{
    [Binding]
    public class GerarRelatórioECADSteps
    {
        public RelatorioECADPage TelaRelatorioECADPage { get; private set; }

        public GerarRelatórioECADSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaRelatorioECADPage = new RelatorioECADPage((IBrowser)browser,
                ConfigurationManager.AppSettings["RelatorioECADUrl"]);
        }

        [Given(@"a tela de Relatorio ECAD esteja aberta")]
        public void DadoATelaDeRelatorioECADEstejaAberta()
        {
            TelaRelatorioECADPage.Navegar();
        }

        [When(@"filtro um relatorio ECAD preenchendo o campo tipo e o periodo ""(.*)"", ""(.*)"" , ""(.*)""")]
        public void QuandoFiltroUmRelatorioECADPreenchendoOCampoTipoEOPeriodo(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "", "", "");
        }

        [Then(@"visualizo que a mensagem do relatorio que não possue fechamento mensal ""(.*)""")]
        public void EntaoVisualizoQueAMensagemDoRelatorioQueNaoPossueFechamentoMensal(string Mensagem)
        {
            TelaRelatorioECADPage.ValidarMensagemFechamentoInexistente(Mensagem);
        }

        [Then(@"gero um relatorio ECAD e verifico as informações ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" estao sendo exibidas corretamente para o filtro ""(.*)"", ""(.*)"" escolhidos")]
        public void EntaoGeroUmRelatorioECADEVerificoAsInformacoesEstaoSendoExibidasCorretamenteParaOFiltroEscolhidos(string Programa, string DataExibicao, string Capitulo, string NomedoEpisodio, string Diretor, string OrdemExecucao, string TitulodaObraMusica, string TipodeMusica, string Autor, string Interprete, string Segundos, string Classificacao, string Compositores, string Editora, string Gravadora, string Submix, string NomePlanilha, string Mes, string Ano)
        {
            TelaRelatorioECADPage.DownloadRelatorioECAD();
            TelaRelatorioECADPage.ValidarRelatorioECAD(Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
            TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
        }

        [When(@"filtro um relatorio ECAD preenchendo o campo tipo periodo ""(.*)"", ""(.*)"" , ""(.*)"" e produto")]
        public void QuandoFiltroUmRelatorioECADPreenchendoOCampoTipoPeriodoEProduto(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "NOVA NOVELA", "", "");
        }

        [When(@"filtro um relatorio ECAD complemento preenchendo o campo tipo periodo ""(.*)"", ""(.*)"" , ""(.*)"" e produto")]
        public void QuandoFiltroUmRelatorioECADComplementoPreenchendoOCampoTipoPeriodoEProduto(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "ANTENA PAULISTA", "", "");
        }

        [When(@"filtro um relatorio ECAD preenchendo o campo tipo , periodo ""(.*)"", ""(.*)"" , ""(.*)"" e midia")]
        public void QuandoFiltroUmRelatorioECADPreenchendoOCampoTipoPeriodoEMidia(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "", "", "TV");
        }

        [When(@"filtro um relatorio ECAD complemento preenchendo o campo tipo periodo ""(.*)"", ""(.*)"" , ""(.*)"" e midia")]
        public void QuandoFiltroUmRelatorioECADComplementoPreenchendoOCampoTipoPeriodoEMidia(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "", "", "TV");
        }

        [When(@"filtro um relatorio ECAD preenchendo o campo tipo , periodo ""(.*)"", ""(.*)"" , ""(.*)"" e DDA")]
        public void QuandoFiltroUmRelatorioECADPreenchendoOCampoTipoPeriodoEDDA(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "", "HELEN PRODUCOES", "");
        }

        [When(@"filtro um relatorio ECAD complemento preenchendo o campo tipo periodo ""(.*)"", ""(.*)"" , ""(.*)"" e DDA")]
        public void QuandoFiltroUmRelatorioECADComplementoPreenchendoOCampoTipoPeriodoEDDA(string Tipo, string Mes, string Ano)
        {
            TelaRelatorioECADPage.FiltrarRelatorioEcad(Tipo, Mes, Ano, "", "EMI SONGS", "");
        }

        [When(@"realizo um fechamento mensal do relatório ECAD preenchendo o campo periodo ""(.*)"", ""(.*)""")]
        public void QuandoRealizoUmFechamentoMensalDoRelatorioECADPreenchendoOCampoPeriodo(string Mes, string Ano)
        {
            TelaRelatorioECADPage.SelecionarFechamento();
            TelaRelatorioECADPage.PeriodoFechamento(Mes, Ano);
        }

        [Then(@"valido o historico do reletorio ECAD")]
        public void EntaoValidoOHistoricoDoReletorioECAD()
        {
            TelaRelatorioECADPage.ValidarHistorico();
        }

        [Then(@"visualizo a mensagem de fechamento em destaque ""(.*)""")]
        public void EntaoVisualizoAMensagemDeFechamentoEmDestaque(string Mensagem)
        {
            TelaRelatorioECADPage.DestaqueMsgFechamento(Mensagem);
        }


    }
}
