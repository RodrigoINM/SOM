using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.DDA;
using System.Configuration;
using TechTalk.SpecFlow;


namespace SOM.BDD.Steps.Obra.DDA
{
    [Binding]
    public class ConsultaDeDDASteps
    {
        public CadastroDeDDAPage TelaCadastroDDA { get; private set; }
        public ConsultaDeDDAPage TelaConsultaDeDDAPage { get; private set; }
        public ExclusaoDeDDAPage TelaExclusaoDeDDAPage { get; private set; }
        public CadastroDeDDASteps CadastroDeDDASteps { get; private set; }

        public ConsultaDeDDASteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDDA = new CadastroDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeDDAUrl"]);
            TelaExclusaoDeDDAPage = new ExclusaoDeDDAPage((IBrowser)browser);
            TelaConsultaDeDDAPage = new ConsultaDeDDAPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeDDAUrl"]);
            CadastroDeDDASteps = new CadastroDeDDASteps();
        }
        
        [Given(@"que esteja com a tela de Busca de DDA aberta")]
        public void DadoQueEstejaComATelaDeBuscaDeDDAAberta()
        {
            TelaConsultaDeDDAPage.Navegar();
        }
        
        [Then(@"visualizo os dados do DDA no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDoDDANoResultadoDaBusca(string NOMEFANTASIA, string NOMECOMPLETO, string CPF, string ASSOCIACAO, string TIPO)
        {
            TelaConsultaDeDDAPage.ValidarResultadoDaConsultaDeDDA(NOMEFANTASIA, NOMECOMPLETO, CPF, ASSOCIACAO, TIPO);
            TelaExclusaoDeDDAPage.ExcluirCadastroDDA(NOMEFANTASIA);
        }

        //Busca avançada por Nome Fantasia com sucesso
        [When(@"faço uma busca avançada por nome fantasia de DDA ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorNomeFantasiaDeDDA(string NomeFantasia)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, "", "", "");
        }

        [When(@"faço uma busca avançada por DDA ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorDDA(string NomeFantasia, string NomeCompleto, string Tipo, string Associacao)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, NomeCompleto, Tipo, Associacao);
        }

        [When(@"faço uma busca avançada por nome fantasia e tipo de DDA ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorNomeFantasiaETipoDeDDA(string NomeFantasia, string Tipo)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, "", Tipo, "");
        }

        [When(@"faço uma busca avançada por nome fantasia e associação ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorNomeFantasiaEAssociacao(string NomeFantasia, string Associacao)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, "", "", Associacao);
        }

        [When(@"faço uma busca avançada por nome fantasia e nome completo ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorNomeFantasiaENomeCompleto(string NomeFantasia, string NomeCompleto)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, NomeCompleto, "", "");
        }

        [When(@"faço uma busca avançada por um DDA que não esteja cadastrado no sistema ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorUmDDAQueNaoEstejaCadastradoNoSistema(string NomeFantasia)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, "", "", "");
        }

        [Then(@"visualizo uma mensagem de dados não encontrados no resultado da busca ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeDadosNaoEncontradosNoResultadoDaBusca(string Mensagem)
        {
            TelaConsultaDeDDAPage.ValidarDadosNaoEncontrados(Mensagem);
        }

        [When(@"faço uma busca avançada de DDA por dados não relacionados entre si ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaDeDDAPorDadosNaoRelacionadosEntreSi(string NomeFantasia, string NomeCompleto)
        {
            TelaConsultaDeDDAPage.ConsultaAvancadaDeDDA(NomeFantasia, NomeCompleto, "", "");
        }

        //Gerar relatório DDA em Excel com sucesso
        [When(@"faço download do relatório em excel do resultado da busca")]
        public void QuandoFacoDownloadDoRelatorioEmExcelDoResultadoDaBusca()
        {
            TelaConsultaDeDDAPage.BaixarRelatorioExcelDeDDA();
        }

        [Then(@"visualizo o download da planilha excel com resultado da busca por DDA ""(.*)""")]
        public void EntaoVisualizoODownloadDaPlanilhaExcelComResultadoDaBuscaPorDDA(string NOMEFANTASIA)
        {
            TelaExclusaoDeDDAPage.ExcluirCadastroDDA(NOMEFANTASIA);
            TelaConsultaDeDDAPage.ExcluirRelatorioExcelDeDDA();
        }

        //Gerar relatório DDA em PDF com sucesso
        [When(@"faço download do relatório em pdf do resultado da busca")]
        public void QuandoFacoDownloadDoRelatorioEmPdfDoResultadoDaBusca()
        {
            TelaConsultaDeDDAPage.BaixarRelatorioPdfDeDDA();
        }



        [Then(@"visualizo o download da planilha pdf com resultado da busca por DDA ""(.*)""")]
        public void EntaoVisualizoODownloadDaPlanilhaPdfComResultadoDaBuscaPorDDA(string NOMEFANTASIA)
        {
            TelaExclusaoDeDDAPage.ExcluirCadastroDDA(NOMEFANTASIA);
            TelaConsultaDeDDAPage.ExcluirRelatorioPdfDeDDA();
        }

    }
}
