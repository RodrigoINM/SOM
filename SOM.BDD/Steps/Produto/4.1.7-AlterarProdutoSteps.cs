using Framework.Core.Interfaces;
using SOM.BDD.Pages.Produto;
using System.Configuration; 
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto
{
    [Binding]
    public sealed class AlterarProdutoSteps
    {
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public ConsultaDeProdutoPage TelaConsultaDeProdutoPage { get; private set; }

        public AlterarProdutoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaConsultaDeProdutoPage = new ConsultaDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["BuscaProdutoUrl"]);
        }
        
        [When(@"altero os dados desse produto ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsDadosDesseProduto(string Nome, string Episodio, string GeneroOriginal, string GeneroDireitosMusicais, string AR, 
            string GradeAtual, string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.EditarProduto(Nome, Episodio, GeneroOriginal, GeneroDireitosMusicais, AR, 
                GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
            TelaCadastroDeProdutoPage.SalvarEdicaoDeProduto();
            TelaConsultaDeProdutoPage.BuscaSimplesDeProduto(CadastroDeProdutoPage.Produto);
        }

        [Then(@"visualizo os dados alterados com sucesso na tela do produto ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosAlteradosComSucessoNaTelaDoProduto(string Nome, string Episodio, string GeneroOriginal, string GeneroDireitosMusicais, string AR,
            string GradeAtual, string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.ValidarDadosProduto(CadastroDeProdutoPage.Produto, CadastroDeProdutoPage.Episodio, GeneroOriginal, GeneroDireitosMusicais, AR,
                GradeAtual, "", Atividade, AtualizaOrigem, CapituloObrigatorio);
        }

        [Given(@"que tenha cadastrado mais um produto no sistema")]
        public void DadoQueTenhaCadastradoMaisUmProdutoNoSistema()
        {
            TelaCadastroDeProdutoPage.GerarNovoProdutoEEpisodio();
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastrarProduto(CadastroDeProdutoPage.Produto2, CadastroDeProdutoPage.Episodio2, "Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            Thread.Sleep(2000);
        }

        [When(@"altero os dados desse produto para que possua os mesmos dados de um produto previamente cadastrado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsDadosDesseProdutoParaQuePossuaOsMesmosDadosDeUmProdutoPreviamenteCadastrado(string Nome, string Episodio, string GeneroOriginal, string GeneroDireitosMusicais, string AR,
            string GradeAtual, string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            TelaCadastroDeProdutoPage.EditarProduto(CadastroDeProdutoPage.Produto, CadastroDeProdutoPage.Episodio, "", "", AR,
                "", "", Atividade, "", "");
            TelaCadastroDeProdutoPage.SalvarEdicaoDeProduto();
        }

        [Then(@"visualizo uma mensagem de erro informando que já existe um produto cadastrado com essas informações ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeErroInformandoQueJaExisteUmProdutoCadastradoComEssasInformacoes(string Mensagem)
        {
            TelaCadastroDeProdutoPage.ValidarPopupDeRegistroExistente(Mensagem);
        }

    }
}
