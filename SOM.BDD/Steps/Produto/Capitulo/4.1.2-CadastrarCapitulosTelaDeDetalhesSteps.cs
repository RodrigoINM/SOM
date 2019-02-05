using Framework.Core.Interfaces;
using SOM.BDD.Pages.Produto;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Capitulo
{
    [Binding]
    public sealed class CadastrarCapitulosTelaDeDetalhesSteps
    {
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public CadastrarCapitulosTelaDeDetalhesSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
        }

        [Given(@"que esteja na tela de detalhes de um produto cadastrado no sistema")]
        public void DadoQueEstejaNaTelaDeDetalhesDeUmProdutoCadastradoNoSistema()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            Thread.Sleep(2000);
        }

        [When(@"cadastro um novo capitulo através da tela de detalhes do produto ""(.*)""")]
        public void QuandoCadastroUmNovoCapituloAtravesDaTelaDeDetalhesDoProduto(string Capitulo)
        {
            TelaCadastroDeProdutoPage.CadastrarCapitulo(Capitulo);
            Thread.Sleep(2000);
        }

        [Then(@"visualizo o capitulo cadastrado no produto com sucesso ""(.*)""")]
        public void EntaoVisualizoOCapituloCadastradoNoProdutoComSucesso(string Capitulo)
        {
            TelaCadastroDeProdutoPage.ValidarCapituloCadastrado(Capitulo);
        }

        [When(@"cadastrado capitulos em lote através da tela de detalhes do produto ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastradoCapitulosEmLoteAtravesDaTelaDeDetalhesDoProduto(string Capitulo, string GeracaoLote, string QuantidadeCapitulos)
        {
            TelaCadastroDeProdutoPage.CadastroDeCapituloEmLote(Capitulo, GeracaoLote, QuantidadeCapitulos, "");
        }

        [When(@"tento cadastrar um capitulo sem preencher os campos obrigatórios")]
        public void QuandoTentoCadastrarUmCapituloSemPreencherOsCamposObrigatorios()
        {
            TelaCadastroDeProdutoPage.CadastroDeCapituloEmLote("", "", "", "");
        }

        [Then(@"visualizo o campo obrigatório para cadastro de capitulo em destaque")]
        public void EntaoVisualizoOCampoObrigatorioParaCadastroDeCapituloEmDestaque()
        {
            TelaCadastroDeProdutoPage.ValidarCamposObrigatoriosParaCadastroDeCapitulo("Capítulo");
        }

        [When(@"cancelo o cadastro de um novo capitulo na tela de detalhes do produto")]
        public void QuandoCanceloOCadastroDeUmNovoCapituloNaTelaDeDetalhesDoProduto()
        {
            TelaCadastroDeProdutoPage.CancelarCadastrDeCapitulo();
        }

        [Then(@"eu visualizo a tela de detalhes do produto sem o capitulo criado com sucesso")]
        public void EntaoEuVisualizoATelaDeDetalhesDoProdutoSemOCapituloCriadoComSucesso()
        {
            TelaCadastroDeProdutoPage.ValidarNomeProdutoDetalhes(CadastroDeProdutoPage.Produto);
        }

    }
}
