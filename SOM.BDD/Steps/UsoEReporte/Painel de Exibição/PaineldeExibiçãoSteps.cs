using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta;
using SOM.BDD.Pages.UsoEReporte.Painel_de_Exibição;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Painel_de_Exibição
{
    [Binding]
    public class PaineldeExibiçãoSteps
    {
        public PaineldeExibiçãoPage TelaPaineldeExibiçãoPage { get; private set; }

        public PaineldeExibiçãoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaPaineldeExibiçãoPage = new PaineldeExibiçãoPage((IBrowser)browser,
               ConfigurationManager.AppSettings["PainelExibicaoUrl"]);
        }

        [Given(@"a tela de painel de exibição esteja aberta")]
        public void DadoATelaDePainelDeExibicaoEstejaAberta()
        {
            TelaPaineldeExibiçãoPage.Navegar();
        }

        [When(@"realizo uma busca no painel de exibição sem preencher o campo Genero Direitos Musicais")]
        public void QuandoRealizoUmaBuscaNoPainelDeExibicaoSemPreencherOCampoGeneroDireitosMusicais()
        {
            TelaPaineldeExibiçãoPage.ExcluirGeneroMusical();
            TelaPaineldeExibiçãoPage.SalvarPesquisa();
        }

        [Then(@"visualizo o campo Genero Direitos Musicais destacado para preenchimento\.")]
        public void EntaoVisualizoOCampoGeneroDireitosMusicaisDestacadoParaPreenchimento_()
        {
            TelaPaineldeExibiçãoPage.ValidarCampoGenero();
        }

        [When(@"realizo uma busca no painel de exibição sem preencher o campo Midia")]
        public void QuandoRealizoUmaBuscaNoPainelDeExibicaoSemPreencherOCampoMidia()
        {
            TelaPaineldeExibiçãoPage.ExcluirMidia();
            TelaPaineldeExibiçãoPage.SalvarPesquisa();

        }

        [Then(@"visualizo o campo Genero Midia destacado para preenchimento\.")]
        public void EntaoVisualizoOCampoGeneroMidiaDestacadoParaPreenchimento_()
        {
            TelaPaineldeExibiçãoPage.ValidarCampoMidia();
        }

        [When(@"realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano ""(.*)"", ""(.*)"" , ""(.*)"" , ""(.*)""")]
        public void QuandoRealizoUmaBuscaNoPainelDeExibicaoPreenchendoOsCamposGeneroDireitosMusicaisMidiaPeriodoEAno(string genero, string Midia, string periodo, string ano)
        {
            TelaPaineldeExibiçãoPage.ExcluirGeneroMusical();
            TelaPaineldeExibiçãoPage.SelecionarGenero(genero);
            TelaPaineldeExibiçãoPage.ExcluirMidia();
            TelaPaineldeExibiçãoPage.SelecionarMidia(Midia);
            TelaPaineldeExibiçãoPage.SelecionarPeriodo(periodo,ano);
            TelaPaineldeExibiçãoPage.SalvarPesquisa();
        }


        [Then(@"visualiso o resultado da pesquisa de Genero Direitos Musicais DRAMATURGIA DIÁRIA")]
        public void EntaoVisualisoOResultadoDaPesquisaDeGeneroDireitosMusicaisDRAMATURGIADIARIA()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoTV();
            TelaPaineldeExibiçãoPage.ValidarResultadoDramatugiaDiaria();
        }

        [Then(@"visualiso o resultado da pesquisa de Genero Direitos Musicais DRAMATURGIA SEMANAL")]
        public void EntaoVisualisoOResultadoDaPesquisaDeGeneroDireitosMusicaisDRAMATURGIASEMANAL()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoDramatugiaDiaria();
        }


        [Then(@"visualiso o resultado da pesquisa de Genero Direitos Musicais ESPORTE")]
        public void EntaoVisualisoOResultadoDaPesquisaDeGeneroDireitosMusicaisESPORTE()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoSpot();
        }

        [Then(@"visualiso o resultado da pesquisa de Genero Direitos Musicais JORNALISMO")]
        public void EntaoVisualisoOResultadoDaPesquisaDeGeneroDireitosMusicaisJORNALISMO()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoJornalismo();
        }

        [Then(@"visualiso o resultado da pesquisa de Genero Direitos Musicais VARIEDADE DIÁRIA")]
        public void EntaoVisualisoOResultadoDaPesquisaDeGeneroDireitosMusicaisVARIEDADEDIARIA()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoVariedadeDiaria();
        }

        [Then(@"visualiso o resultado da pesquisa de Genero Direitos Musicais VARIEDADE SEMANAL")]
        public void EntaoVisualisoOResultadoDaPesquisaDeGeneroDireitosMusicaisVARIEDADESEMANAL()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoVariedadesemanal();
        }

        [When(@"realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano ""(.*)"" , ""(.*)"" , ""(.*)""")]
        public void QuandoRealizoUmaBuscaNoPainelDeExibicaoPreenchendoOsCamposMidiaPeriodoEAno(string Midia, string periodo, string ano)
        {
            TelaPaineldeExibiçãoPage.ExcluirMidia();
            TelaPaineldeExibiçãoPage.SelecionarMidia(Midia);
            TelaPaineldeExibiçãoPage.SelecionarPeriodo(periodo, ano);
            TelaPaineldeExibiçãoPage.SalvarPesquisa();
        }

        [Then(@"visualiso o resultado da pesquisa de Midia TV")]
        public void EntaoVisualisoOResultadoDaPesquisaDeMidiaTV()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoTV();
        }

        [Then(@"visualiso o resultado da pesquisa do CANAL VIVA")]
        public void EntaoVisualisoOResultadoDaPesquisaDoCANALVIVA()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoViva();
        }

        [Then(@"visualiso o resultado da pesquisa do MULTSHOW")]
        public void EntaoVisualisoOResultadoDaPesquisaDoMULTSHOW()
        {
            TelaPaineldeExibiçãoPage.ValidarResultadoMultishow();
        }

        [Then(@"visualiso o resultado da pesquisa do GLOBOPLAY")]
        public void EntaoVisualisoOResultadoDaPesquisaDoGLOBOPLAY()
        {
            TelaPaineldeExibiçãoPage.ValidarResultaGloboPlay();
        }

        [Then(@"visualiso o resultado da pesquisa da INTERNET")]
        public void EntaoVisualisoOResultadoDaPesquisaDaINTERNET()
        {
            TelaPaineldeExibiçãoPage.ValidarResultainternet();
        }

        [Then(@"visualiso o resultado da pesquisa com a cue-sheet FINALIZADA na cor azul")]
        public void EntaoVisualisoOResultadoDaPesquisaComACue_SheetFINALIZADANaCorAzul()
        {
            TelaPaineldeExibiçãoPage.ValidarAzul();
        }

        [Then(@"visualiso o resultado da pesquisa com a cue-sheet PARCIALMENTE VALIDADA na cor amarela")]
        public void EntaoVisualisoOResultadoDaPesquisaComACue_SheetPARCIALMENTEVALIDADANaCorAmarela()
        {
            TelaPaineldeExibiçãoPage.ValidarAmarelo();
        }

        [Then(@"visualiso o resultado da pesquisa com a cue-sheet VALIDADA na cor Verde")]
        public void EntaoVisualisoOResultadoDaPesquisaComACue_SheetVALIDADANaCorVerde()
        {
            TelaPaineldeExibiçãoPage.ValidarVerde();
        }

        [Then(@"visualiso o resultado da pesquisa com a cue-sheet EM ABERTO na cor CINZA")]
        public void EntaoVisualisoOResultadoDaPesquisaComACue_SheetEMABERTONaCorCINZA()
        {
            TelaPaineldeExibiçãoPage.ValidarCinza();
        }

        [Then(@"visualiso o resultado da pesquisa com a cue-sheet CRIADA na cor VERMELHO")]
        public void EntaoVisualisoOResultadoDaPesquisaComACue_SheetCRIADANaCorVERMELHO()
        {
            TelaPaineldeExibiçãoPage.ValidarVermelho();
        }

        [Then(@"visualiso o resultado da pesquisa com a cue-sheet LIBERADA na cor LARANJA")]
        public void EntaoVisualisoOResultadoDaPesquisaComACue_SheetLIBERADANaCorLARANJA()
        {
            TelaPaineldeExibiçãoPage.ValidarLaranja();
        }

        [When(@"realizo uma busca com o campo periodo em branco")]
        public void QuandoRealizoUmaBuscaComOCampoPeriodoEmBranco()
        {
            TelaPaineldeExibiçãoPage.PeriodoemBranco();
            TelaPaineldeExibiçãoPage.SalvarPesquisa();
        }

        [Then(@"visualizo o campo periodo em destaque para o preenchimento")]
        public void EntaoVisualizoOCampoPeriodoEmDestaqueParaOPreenchimento()
        {
            TelaPaineldeExibiçãoPage.PeriodoEmdestaque();
        }

    }
}
