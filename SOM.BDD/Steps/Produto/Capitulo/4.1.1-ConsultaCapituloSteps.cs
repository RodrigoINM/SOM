using Framework.Core.Interfaces;
using SOM.BDD.Pages.Produto.Capitulo;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Capitulo
{
    [Binding]
    public sealed class ConsultaCapituloSteps
    {
        public CadastrarCapituloPage TelaCadastrarCapituloPage { get; private set; }

        public ConsultaCapituloSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCapituloPage = new CadastrarCapituloPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCapituloUrl"],
                ConfigurationManager.AppSettings["ConsultaDeCapituloUrl"]);
        }

        [Given(@"que esteja na tela de consulta de capitulos")]
        public void DadoQueEstejaNaTelaDeConsultaDeCapitulos()
        {
            TelaCadastrarCapituloPage.NavegarConsultaDeCapitulos();
        }

        [When(@"faço uma busca de capítulo por nome do Produto ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCapituloPorNomeDoProduto(string Produto)
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos(Produto, "", "", "");
        }

        [When(@"faço uma busca de capítulo por episodio ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCapituloPorEpisodio(string Episodio)
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos("", Episodio, "", "");
        }
        
        [When(@"faço uma busca de capítulo por capitulo inicial e final ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeCapituloPorCapituloInicialEFinal(string CapituloInicio, string CapituloFim)
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos("", "", CapituloInicio, CapituloFim);
        }

        [When(@"faço um busca por capitulo sem preencher nenhum campo da consulta")]
        public void QuandoFacoUmBuscaPorCapituloSemPreencherNenhumCampoDaConsulta()
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos("", "", "", "");
        }

        [When(@"faço um busca por capitulo informando um produto que não foi cadastrado no sistema ""(.*)""")]
        public void QuandoFacoUmBuscaPorCapituloInformandoUmProdutoQueNaoFoiCadastradoNoSistema(string Produto)
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos(Produto, "", "", "");
        }

        [When(@"faço um busca por capitulo informando um produto e um episodio que não são associados ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmBuscaPorCapituloInformandoUmProdutoEUmEpisodioQueNaoSaoAssociados(string Produto, string Episodio)
        {
            TelaCadastrarCapituloPage.ConsultaDeCapitulos(Produto, Episodio, "", "");
        }

        [Then(@"visualizo uma mensagem de critica pedindo para informar ao menos um produto ou episodio ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeCriticaPedindoParaInformarAoMenosUmProdutoOuEpisodio(string Mensagem)
        {
            TelaCadastrarCapituloPage.ValidarMensagemDeCritica(Mensagem);
        }

        [Then(@"visualizo os dados do produto e capítulo cadastrados no sistema no resultado da busca ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDoProdutoECapituloCadastradosNoSistemaNoResultadoDaBusca(string NomeProduto, string Episodio, string Capitulo)
        {
            TelaCadastrarCapituloPage.ValidarConsultaDePedido(NomeProduto, Episodio, Capitulo);
        }

        [Then(@"visualizo uma mensagem que não existe dados cadastrados no resultado da busca por capítulo ""(.*)""")]
        public void EntaoVisualizoUmaMensagemQueNaoExisteDadosCadastradosNoResultadoDaBuscaPorCapitulo(string Mensagem)
        {
            TelaCadastrarCapituloPage.ValidarDadosNaoEncontrados(Mensagem);
        }

    }
}
