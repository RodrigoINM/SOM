using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra.Catálogo_de_Editoras;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra.Catálogo_de_Editoras
{
    [Binding]
    public class CatálogodeEditoraSteps
    {
        public CatálogodeEditoraPage TelaCatálogodeEditoraPage { get; private set; }

        public CatálogodeEditoraSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCatálogodeEditoraPage = new CatálogodeEditoraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CatalogoEditorasUrl"]);
        }

        [Given(@"a tela de de Catálogo de editora esteja aberto")]
        public void DadoATelaDeDeCatalogoDeEditoraEstejaAberto()
        {
            TelaCatálogodeEditoraPage.Navegar();
        }

        [When(@"faço um upload de um arquivo válido  ""(.*)""")]
        public void QuandoFacoUmUploadDeUmArquivoValido(string Arquivo)
        {
            TelaCatálogodeEditoraPage.RealizarUploadDeArquivo(Arquivo);
        }

        [When(@"visualizo a grid com as seguintes colunas, na aba de Itens Válidos: ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoVisualizoAGridComAsSeguintesColunasNaAbaDeItensValidosE(string Linha, string Titulo, string Composicao, string Nacionalidade, string DominioPublico, string Tipo)
        {
            TelaCatálogodeEditoraPage.ValidarGrid(Linha, Titulo, Composicao, Nacionalidade, DominioPublico, Tipo);
            TelaCatálogodeEditoraPage.Importar();
        }

        [Then(@"salvo a importação do catálogo e visualizo a mensagem ""(.*)""")]
        public void EntaoSalvoAImportacaoDoCatalogoEVisualizoAMensagem(string MensagemDeAlteração)
        {
            TelaCatálogodeEditoraPage.ValidarMsg(MensagemDeAlteração);
        }

        [When(@"faço um upload de um arquivo ""(.*)""")]
        public void QuandoFacoUmUploadDeUmArquivo(string Arquivo)
        {
            TelaCatálogodeEditoraPage.RealizarUploadDeArquivo(Arquivo);
        }

        [Then(@"visualizo a mensagem de importação incorreta ""(.*)""")]
        public void EntaoVisualizoAMensagemDeImportacaoIncorreta(string Mensagem)
        {
            TelaCatálogodeEditoraPage.AquivoInvalido(Mensagem);
        }

        [When(@"clico para fazer o dowload no template")]
        public void QuandoClicoParaFazerODowloadNoTemplate()
        {
            TelaCatálogodeEditoraPage.BaixarTeplate();
        }

        [Then(@"visualizo o download com sucesso")]
        public void EntaoVisualizoODownloadComSucesso()
        {
            TelaCatálogodeEditoraPage.CaminhoRelatorioParaExclusao();
        }

        [When(@"faço um upload de um ""(.*)"" com Autor não cadastrado")]
        public void QuandoFacoUmUploadDeUmComAutorNaoCadastrado(string Arquivo)
        {
            TelaCatálogodeEditoraPage.RealizarUploadDeArquivo(Arquivo);
        }

        [Then(@"visualizo, na aba Itens Inválidos, o erro ""(.*)""")]
        public void EntaoVisualizoNaAbaItensInvalidosOErro(string Autor)
        {
            TelaCatálogodeEditoraPage.ValidarAutorinexixtente(Autor);
        }

        [When(@"faço um upload de um ""(.*)"" com DDA não cadastrado")]
        public void QuandoFacoUmUploadDeUmComDDANaoCadastrado(string Arquivo)
        {
            TelaCatálogodeEditoraPage.RealizarUploadDeArquivo(Arquivo);
        }

        [Then(@"visualizo, na aba Itens Inválidos, o erro de DDA ""(.*)""")]
        public void EntaoVisualizoNaAbaItensInvalidosOErroDeDDA(string Autor)
        {
            TelaCatálogodeEditoraPage.ValidarAutorinexixtente(Autor);
        }

        [When(@"faço um upload de um ""(.*)"" com em branco")]
        public void QuandoFacoUmUploadDeUmComEmBranco(string Arquivo)
        {
            TelaCatálogodeEditoraPage.RealizarUploadDeArquivo(Arquivo);
        }

        [Then(@"visualizo, na aba Itens Inválidos, o erro de campos em branco ""(.*)""")]
        public void EntaoVisualizoNaAbaItensInvalidosOErroDeCamposEmBranco(string Autor)
        {
            TelaCatálogodeEditoraPage.ValidarAutorinexixtente(Autor);
        }

        [When(@"faço um upload sem nenhum Arquivo")]
        public void QuandoFacoUmUploadSemNenhumArquivo()
        {
            TelaCatálogodeEditoraPage.BaixarAquivoVazio();
        }

        [Then(@"visualizo a mesagem de erro da importação ""(.*)""")]
        public void EntaoVisualizoAMesagemDeErroDaImportacao(string Mensagem)
        {
            TelaCatálogodeEditoraPage.AquivoInvalido(Mensagem);
        }

        [Then(@"confirmo o cancelamento do Upload do aquivo\.")]
        public void EntaoConfirmoOCancelamentoDoUploadDoAquivo_()
        {
            TelaCatálogodeEditoraPage.CancelarUpload();
        }

        [When(@"visualizo a grid com colunas, na aba de Itens Válidos: ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoVisualizoAGridComColunasNaAbaDeItensValidosE(string Linha, string Titulo, string Composicao, string Nacionalidade, string DominioPublico, string Tipo)
        {
            TelaCatálogodeEditoraPage.ValidarGrid(Linha, Titulo, Composicao, Nacionalidade, DominioPublico, Tipo);
        }

    }
}
