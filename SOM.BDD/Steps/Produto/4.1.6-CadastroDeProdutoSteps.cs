using Framework.Core.Interfaces;
using System.Configuration;
using TechTalk.SpecFlow;
using SOM.BDD.Pages.Produto;
using System.Threading;

namespace SOM.BDD.Steps.Produto
{
    [Binding]
    public sealed class CadastroDeProdutoSteps
    {
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public ExclusaoDeProdutoPage TelaExclusaoDeProdutoPage { get; private set; }
        public ConsultaDeProdutoPage TelaConsultaDeProdutoPage { get; private set; }

        public CadastroDeProdutoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaExclusaoDeProdutoPage = new ExclusaoDeProdutoPage((IBrowser)browser);
            TelaConsultaDeProdutoPage = new ConsultaDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["BuscaProdutoUrl"]);
        }

        [Given(@"que esteja com a tela Cadastro de Produto aberta")]
        public void DadoQueEstejaComATelaCadastroDeProdutoAberta()
        {
            TelaCadastroDeProdutoPage.Navegar();
        }

        [When(@"cadastro um novo Produto preenchendo os campos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoCadastroUmNovoProdutoPreenchendoOsCamposE(string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.CadastroDeProduto(GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
        }
        
        [Then(@"visualizo a ""(.*)"" de cadastro de produto realizado com sucesso")]
        public void EntaoVisualizoADeCadastroDeProdutoRealizadoComSucesso(string Mensagem)
        {
            TelaCadastroDeProdutoPage.ClicarSalvarCadastroDeProduto(Mensagem);
            Thread.Sleep(2000);
        }

        [Then(@"visualizo os campos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)"" cadastrados no detalhe do produto")]
        public void EntaoVisualizoOsCamposECadastradosNoDetalheDoProduto(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
            TelaCadastroDeProdutoPage.ValidarDadosProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaConsultaDeProdutoPage.ConsultaSimplesProduto();
            TelaExclusaoDeProdutoPage.ExclusaoDeProduto("Registro excluído com sucesso.");
        }

        //Cadastrar Produto sem preenchimento de campo obrigatório
        [When(@"cadastro um Produto sem preenchimento dos campos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" ou ""(.*)""")]
        public void QuandoCadastroUmProdutoSemPreenchimentoDosCamposOu(string Nome, string Ar, string GeneroDireitosMusicais, string Atividade, string Midia)
        {
            TelaCadastroDeProdutoPage.ClicarSalvarCadastroDeProduto("");
        }

        [Then(@"visualizo os campos obrigatorios para cadastro de produto em destaque ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void EntaoVisualizoOsCamposObrigatoriosParaCadastroDeProdutoEmDestaqueE(string Nome, string Ar, string GeneroDireitosMusicais, string Atividade, string Midia)
        {
            TelaCadastroDeProdutoPage.ValidarCamposObrigatoriosCadastroDeProduto("Sim", "Sim", "Sim", "Sim", "Sim");
        }

        //Cancelar cadastro de Produto
        [When(@"cancelo o cadastro de um novo produto com todos os campos preenchidos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoCanceloOCadastroDeUmNovoProdutoComTodosOsCamposPreenchidosE(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.CadastroDeProduto(GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaCadastroDeProdutoPage.CancelarCadastroDeProduto();
        }

        [Then(@"visualizo a tela de busca de Produto")]
        public void EntaoVisualizoATelaDeBuscaDeProduto()
        {
            DadoQueEstejaComATelaCadastroDeProdutoAberta();
        }

        //Cadastrar novo Produto com informações de outro produto previamente cadastrado
        [Given(@"que tenha um produto cadastrado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmProdutoCadastrado(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastrarProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaCadastroDeProdutoPage.ClicarSalvarCadastroDeProduto("Registro salvo com sucesso.");
            Thread.Sleep(2000);
        }

        [When(@"tento cadastrar um novo Produto com as mesmas informações de um produto previamente cadastrado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" e ""(.*)""")]
        public void QuandoTentoCadastrarUmNovoProdutoComAsMesmasInformacoesDeUmProdutoPreviamenteCadastradoE(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastrarProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
        }

        [Then(@"visualizo a mensagem de que já existe um produto ativo cadastrado com esses dados ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueJaExisteUmProdutoAtivoCadastradoComEssesDados(string Nome, string Mensagem)
        {
            TelaCadastroDeProdutoPage.ValidarMensagemDeProdutoJaExistente(Mensagem);
            TelaConsultaDeProdutoPage.BuscaSimplesDeProduto(Nome);
            TelaExclusaoDeProdutoPage.ExclusaoDeProdutoSimples(Nome, "Registro excluído com sucesso.");
        }
        
    }
}
