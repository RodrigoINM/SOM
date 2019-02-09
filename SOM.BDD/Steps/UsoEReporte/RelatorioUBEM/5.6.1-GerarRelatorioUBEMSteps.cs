using Framework.Core.Interfaces;
using SOM.BDD.Helpers;
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

        [Then(@"posso baixar o relatorio UBEM e verificar se as informacoes de ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" estao sendo exibidas corretamente para a ""(.*)"" ""(.*)"" ""(.*)"" escolhidos")]
        public void EntaoPossoBaixarORelatorioUBEMEVerificarSeAsInformacoesDeEstaoSendoExibidasCorretamenteParaAEscolhidos(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise, string Associacao, string Mes, string Ano, string TituloPlanilha)
        {
            TelaRelatorioUbemPage.DownloadRelatorioUbemMensal();
            TelaRelatorioUbemPage.ValidarRelatorioUbem(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano, TituloPlanilha);
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

        //[Then(@"gero o relatorio e verifico se as informacoes de ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" estao sendo exibidas corretamente para a ""(.*)"" ""(.*)"" ""(.*)"" escolhidos")]
        //public void EntaoGeroORelatorioEVerificoSeAsInformacoesDeEstaoSendoExibidasCorretamenteParaAEscolhidos(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
        //    string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise, string Associacao, string Mes, string Ano)
        //{
        //    TelaRelatorioUbemPage.DownloadRelatorioUbem();
        //    TelaRelatorioUbemPage.ValidarRelatorioUbem(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
        //        Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
        //    TelaRelatorioUbemPage.ExcluirRelatorio(Associacao, Mes, Ano);
        //}

        [Then(@"gero o relatorio e verifico se as informacoes de ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" estao sendo exibidas corretamente para a ""(.*)"" ""(.*)"" ""(.*)"" escolhidos")]
        public void EntaoGeroORelatorioEVerificoSeAsInformacoesDeEstaoSendoExibidasCorretamenteParaAEscolhidos(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise, string Associacao, string Mes, string Ano, string TituloPlanilha)
        {
            TelaRelatorioUbemPage.DownloadRelatorioUbem();
            TelaRelatorioUbemPage.ValidarRelatorioUbem(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano, TituloPlanilha);
        }

        [When(@"faco um filtro para um periodo complemento ""(.*)"" ""(.*)"" e associacao ""(.*)""")]
        public void QuandoFacoUmFiltroParaUmPeriodoComplementoEAssociacao(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Complemento", Mes, Ano, "", "", "");
        }

        [When(@"faco um filtro para um periodo ""(.*)"" ""(.*)"" , associacao ""(.*)"" e DDA")]
        public void QuandoFacoUmFiltroParaUmPeriodoAssociacaoEDDA(string Mes, string Ano, string Associacao)
        {
            TelaRelatorioUbemPage.FiltrarRelatorioUbem(Associacao, "Mensal", Mes, Ano, "", "SOM E LUZ", "");
        }


    }
}
