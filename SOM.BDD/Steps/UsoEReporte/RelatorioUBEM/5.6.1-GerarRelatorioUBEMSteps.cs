using Framework.Core.Interfaces;
using SOM.BDD.Pages.UsoEReporte.RelatorioUBEM;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.RelatorioUBEM
{
    [Binding]
    public class GerarRelatorioUBEMSteps
    {
        public GerarRelatorioUBEM TelaRelatorioUbemPage { get; private set; }

        public GerarRelatorioUBEMSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaRelatorioUbemPage = new GerarRelatorioUBEM((IBrowser)browser,
                ConfigurationManager.AppSettings["RelatorioUBEMUrl"]);
        }

        [Given(@"que possua um periodo que tenha sido fechado")]
        public void DadoQuePossuaUmPeriodoQueTenhaSidoFechado()
        {
            TelaRelatorioUbemPage.VerificarPeriodoFechadoUbem();
        }

        [Given(@"que esteja na tela de Relatorio Ubem")]
        public void DadoQueEstejaNaTelaDeRelatorioUbem()
        {
            TelaRelatorioUbemPage.Navegar();
        }

        [When(@"faco um filtro para um periodo ""(.*)"" ""(.*)"" que ainda nao possua fechamento")]
        public void QuandoFacoUmFiltroParaUmPeriodoQueAindaNaoPossuaFechamento(string Mes, string Ano)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem("UBEM", "Mensal", Mes, Ano, "", "", "");
        }

        [When(@"faco um filtro para um periodo ""(.*)"" ""(.*)"" e associacao ""(.*)""")]
        public void QuandoFacoUmFiltroParaUmPeriodoEAssociacao(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Mensal", Mes, Ano, "", "", "");
        }

        [Then(@"posso baixar o relatorio UBEM e verificar se as informacoes de ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" estao sendo exibidas corretamente para a ""(.*)"", ""(.*)"", ""(.*)"" escolhidos")]
        public void EntaoPossoBaixarORelatorioUBEMEVerificarSeAsInformacoesDeEstaoSendoExibidasCorretamenteParaAEscolhidos(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise, string TituloRelatorio, string Associacao, string Mes, string Ano)
        {
            TelaRelatorioUbemPage.DownloadRelatorioUbemMensal();
            TelaRelatorioUbemPage.ValidarRelatorioUbem(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, TituloRelatorio, Associacao, Mes, Ano);
        }

        [Then(@"realizo o download do relatorio UBEM com sucesso para a ""(.*)"" ""(.*)"" ""(.*)"" escolhidos")]
        public void EntaoRealizoODownloadDoRelatorioUBEMComSucessoParaAEscolhidos(string Associacao, string Mes, string Ano)
        {
            TelaRelatorioUbemPage.DownloadRelatorioUbem();
            TelaRelatorioUbemPage.ExcluirRelatorio(Associacao, Mes, Ano);
        }

        [Then(@"visualizo o link de download do relatorio de fechamento UBEM com sucesso ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EntaoVisualizoOLinkDeDownloadDoRelatorioDeFechamentoUBEMComSucesso(string Associacao, string Mes, string Ano)
        {
            TelaRelatorioUbemPage.DownloadRelatorioUbemMensal();
            TelaRelatorioUbemPage.ExcluirRelatorio(Associacao, Mes, Ano);
        }

        [Then(@"visualizo a mensagem de que não existe fechamento UBEM para o periodo selecionado ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueNaoExisteFechamentoUBEMParaOPeriodoSelecionado(string Mensagem)
        {
            TelaRelatorioUbemPage.ValidarMensagemFechamentoInexistente(Mensagem);
        }

        [Then(@"gero o relatorio UBEM e verifica se as informacoes de ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" estao sendo exibidas corretamente para a ""(.*)"" ""(.*)"" ""(.*)"" escolhidos")]
        public void EntaoGeroORelatorioUBEMEVerificaSeAsInformacoesDeEstaoSendoExibidasCorretamenteParaAEscolhidos(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise, string TituloRelatorio, string Associacao, string Mes, string Ano)
        {
            TelaRelatorioUbemPage.DownloadRelatorioUbem();
            TelaRelatorioUbemPage.ValidarRelatorioUbem(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, TituloRelatorio, Associacao, Mes, Ano);
        }

        [When(@"faco um filtro complemento para um periodo ""(.*)"" ""(.*)"" e associacao ""(.*)""")]
        public void QuandoFacoUmFiltroComplementoParaUmPeriodoEAssociacao(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Complemento", Mes, Ano, "", "", "");
        }

        [When(@"faco um filtro para um periodo ""(.*)"" ""(.*)"" associacao ""(.*)"" e DDA")]
        public void QuandoFacoUmFiltroParaUmPeriodoAssociacaoEDDA(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Mensal", Mes, Ano, "", "HELEN PRODUCOES", "");
        }

        [When(@"faco um filtro complemento para um periodo ""(.*)"" ""(.*)"" associacao ""(.*)"" e DDA")]
        public void QuandoFacoUmFiltroComplementoParaUmPeriodoAssociacaoEDDA(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Complemento", Mes, Ano, "", "HELEN PRODUCOES", "");
        }

        [When(@"faco um filtro para um periodo sem associação ""(.*)"" ""(.*)"" associacao ""(.*)"" e DDA")]
        public void QuandoFacoUmFiltroParaUmPeriodoSemAssociacaoAssociacaoEDDA(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Mensal", Mes, Ano, "", "EMI SONGS", "");
        }

        [When(@"faco um filtro sem informar o periodo ""(.*)"" ""(.*)""")]
        public void QuandoFacoUmFiltroSemInformarOPeriodo(string Mes, string Ano)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem("UBEM", "Mensal", Mes, Ano, "", "", "");
        }

        [Then(@"visualizo o campo Periodo em destaque para preenchimento")]
        public void EntaoVisualizoOCampoPeriodoEmDestaqueParaPreenchimento()
        {
            TelaRelatorioUbemPage.ValidarPeriodoEmdestaque();
        }

        [Then(@"valido o historico do reletorio UBEM")]
        public void EntaoValidoOHistoricoDoReletorioUBEM()
        {
            TelaRelatorioUbemPage.ValidarHistorico();
        }

        [When(@"faco um filtro para um periodo ""(.*)"" ""(.*)"" associacao ""(.*)"" e produto")]
        public void QuandoFacoUmFiltroParaUmPeriodoAssociacaoEProduto(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Mensal", Mes, Ano, "JORNAL NACIONAL", "", "");
        }

        [When(@"faco um filtro com complemento para um periodo ""(.*)"" ""(.*)"" associacao ""(.*)"" e produto")]
        public void QuandoFacoUmFiltroComComplementoParaUmPeriodoAssociacaoEProduto(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Complemento", Mes, Ano, "JORNAL NACIONAL", "", "");
        }

        [When(@"seleciono a flag de sim")]
        public void QuandoSelecionoAFlagDeSim()
        {
            TelaRelatorioUbemPage.SelecionarFlag();
        }

    }
}

