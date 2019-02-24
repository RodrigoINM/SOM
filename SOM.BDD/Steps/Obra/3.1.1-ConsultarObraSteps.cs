using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra
{
    [Binding]
    public sealed class ConsultarObraSteps
    {
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }

        public ConsultarObraSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);
        }

        [Given(@"que esteja na tela de Obras")]
        public void DadoQueEstejaNaTelaDeObras()
        {
            TelaConsultarObraPage.Navegar();
        }

        //Consulta Avançada por Obra cadastrada no sistema
        [When(@"faço uma busca avancada por uma obra ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorUmaObra(string Titulo, string SubTitulo, string Autor, string TituloAlt, string Tipo, string DDA)
        {
            TelaConsultarObraPage.ConsultaAvancadaObra(Titulo, SubTitulo, Autor, TituloAlt, Tipo, DDA);
        }

        [Then(@"visualizo a obra cadastrada no resultado da busca com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAObraCadastradaNoResultadoDaBuscaComSucesso(string Titulo, string Autor, string DDA, string Nacionalidade, string Tipo, string DominioPublico)
        {
            TelaConsultarObraPage.ValidarObraNaGrid(Titulo, Autor, DDA, Nacionalidade, Tipo, DominioPublico);
        }

        //Consulta Simples por Obra cadastrada no sistema
        [When(@"faço uma busca simples por uma obra ""(.*)""")]
        public void QuandoFacoUmaBuscaSimplesPorUmaObra(string Titulo)
        {
            TelaConsultarObraPage.ConsultaSimplesObra(Titulo);
        }

        //Consultar detalhe de obra com fonograma
        [Then(@"visualizo a grid preenchido com os dados do fonograma ""(.*)""")]
        public void EntaoVisualizoAGridPreenchidoComOsDadosDoFonograma(string Obra)
        {
            TelaConsultarObraPage.ValidarDadosDeFonograma(Obra);
        }

    }
}
