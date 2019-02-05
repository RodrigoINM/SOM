using Framework.Core.Interfaces;
using System.Configuration;
using TechTalk.SpecFlow;
using SOM.BDD.Pages.Produto;
using System.Threading;

namespace SOM.BDD.Steps.Produto
{
    [Binding]
    public sealed class ConsultaDeProdutoSteps
    {
        public ConsultaDeProdutoPage TelaConsultaDeProdutoPage { get; private set; }
        public ExclusaoDeProdutoPage TelaExclusaoDeProdutoPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public ConsultaDeProdutoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaExclusaoDeProdutoPage = new ExclusaoDeProdutoPage((IBrowser)browser);
            TelaConsultaDeProdutoPage = new ConsultaDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["BuscaProdutoUrl"]);
        }

        [Given(@"que esteja com a tela busca por Produto aberta")]
        public void DadoQueEstejaComATelaBuscaPorProdutoAberta()
        {
            TelaConsultaDeProdutoPage.Navegar();
        }

        [Given(@"que eu tenha um produto cadastrado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueEuTenhaUmProdutoCadastrado(string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto(GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            Thread.Sleep(2000);
        }

        [When(@"faço uma busca simples pelo produto")]
        public void QuandoFacoUmaBuscaSimplesPeloProduto()
        {
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
        }

        [Then(@"visualizo os campos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)"" no detalhe do produto")]
        public void EntaoVisualizoOsCamposENoDetalheDoProduto(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
            TelaCadastroDeProdutoPage.ValidarDadosProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
        }

        [When(@"faço uma busca avançada por Produto")]
        public void QuandoFacoUmaBuscaAvancadaPorProduto()
        {
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaAvancadaDeProduto("", "");
        }

        [When(@"faço uma busca avançada por Produto e Episódio ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorProdutoEEpisodio(string Nome, string Episodio)
        {
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaAvancadaDeProdutoInexistentes(Nome, Episodio);
        }

        [When(@"faço uma busca avançada por Produto e Episódio")]
        public void QuandoFacoUmaBuscaAvancadaPorProdutoEEpisodio()
        {
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaAvancadaDeProduto("", "");
        }

        [When(@"faço uma busca avançada por Produto e Gênero Original ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorProdutoEGeneroOriginal(string GeneroOriginal)
        {
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaAvancadaDeProduto(GeneroOriginal, "");
        }

        [When(@"faço uma busca avançada por Produto e Direitos Musicais ""(.*)""")]
        public void QuandoFacoUmaBuscaAvancadaPorProdutoEDireitosMusicais(string DireitosMusicais)
        {
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaAvancadaDeProduto("", DireitosMusicais);
        }
        
        [Then(@"visualizo o produto no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void EntaoVisualizoOProdutoNoResultadoDaBuscaE(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.ValidarDadosProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
            TelaExclusaoDeProdutoPage.ExclusaoDeProduto("Registro excluído com sucesso.");
        }

        [Then(@"visualizo o produto no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void EntaoVisualizoOProdutoNoResultadoDaBuscaE(string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.ValidarDadosProduto(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
            TelaExclusaoDeProdutoPage.ExclusaoDeProduto("Registro excluído com sucesso.");
        }

        [Then(@"visualizo o produto no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void EntaoVisualizoOProdutoNoResultadoDaBuscaE(string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.ValidarDadosProduto(TelaCadastroDeProdutoPage.GetProduto(), Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaConsultaDeProdutoPage.Navegar();
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
            TelaExclusaoDeProdutoPage.ExclusaoDeProduto("Registro excluído com sucesso.");
        }

        [Then(@"visualizo a ""(.*)"" de dados nao encontrados na busca pelo produto informado")]
        public void EntaoVisualizoADeDadosNaoEncontradosNaBuscaPeloProdutoInformado(string Mensagem)
        {
            TelaConsultaDeProdutoPage.ValidarDadosNaoEncontradosProduto(Mensagem);
        }

    }
}
