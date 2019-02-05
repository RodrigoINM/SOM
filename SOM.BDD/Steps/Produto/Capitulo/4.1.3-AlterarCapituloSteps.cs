using Framework.Core.Interfaces;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.Produto.Capitulo;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Capitulo
{
    [Binding]
    public sealed class AlterarCapituloSteps
    {
        public CadastrarCapituloPage TelaCadastrarCapituloPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        public AlterarCapituloSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCapituloPage = new CadastrarCapituloPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCapituloUrl"],
                ConfigurationManager.AppSettings["ConsultaDeCapituloUrl"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
        }

        [When(@"altero o número do capítulo do produto cadastrado ""(.*)"", ""(.*)""")]
        public void QuandoAlteroONumeroDoCapituloDoProdutoCadastrado(string NomeProduto, string Capitulo)
        {
            TelaCadastrarCapituloPage.AlterarCapitulo(NomeProduto, Capitulo, "Teste");
        }

        [Then(@"visualizo a mensagem de que o capítulo foi alterado com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueOCapituloFoiAlteradoComSucesso(string Mensagem)
        {
            TelaCadastrarCapituloPage.ValidarPopUpSucesso(Mensagem);
        }

        [Given(@"que tenha um produto cadastrado no sistema com dois capitulos cadastrados ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmProdutoCadastradoNoSistemaComDoisCapitulosCadastrados(string Capitulo1, string Capitulo2)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo(Capitulo1);
            Thread.Sleep(2000);
            TelaCadastroDeProdutoPage.CadastrarCapitulo(Capitulo2);
            Thread.Sleep(2000);
        }

        [When(@"faço uma busca de capítulo por nome do Produto e capitulos inicial e final ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCapituloPorNomeDoProdutoECapitulosInicialEFinal(string Produto, string CapituloInicio, string CapituloFinal)
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos(Produto, "", CapituloInicio, CapituloFinal);
        }

        [When(@"altero o valor de um capitulo para o mesmo valor do outro já cadastrado ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOValorDeUmCapituloParaOMesmoValorDoOutroJaCadastrado(string Capitulo1, string Capitulo2)
        {
            TelaCadastrarCapituloPage.AlterarCapitulo("Aleatório", Capitulo2, "");
        }

        [Then(@"visualizo a mensagem de que já existe um capitulo cadastrado com esses dados no produto ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueJaExisteUmCapituloCadastradoComEssesDadosNoProduto(string Mensagem)
        {
            TelaCadastrarCapituloPage.ValidarMensagemDeCritica(Mensagem);
        }

    }
}
