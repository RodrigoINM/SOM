using Framework.Core.Interfaces;
using SOM.BDD.Pages.Produto.Capitulo;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Capitulo
{
    [Binding]
    public sealed class CadastrarCapituloSteps
    {
        public CadastrarCapituloPage TelaCadastrarCapituloPage { get; private set; }

        public CadastrarCapituloSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCapituloPage = new CadastrarCapituloPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCapituloUrl"],
                ConfigurationManager.AppSettings["ConsultaDeCapituloUrl"]);
        }

        [Given(@"que esteja na tela de cadastro de capitulos")]
        public void DadoQueEstejaNaTelaDeCadastroDeCapitulos()
        {
            TelaCadastrarCapituloPage.Navegar();
        }

        [When(@"cadastro um novo capitulo para o produto existente ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoCapituloParaOProdutoExistente(string Produto, string Capitulo)
        {
            TelaCadastrarCapituloPage.CadastrarCapitulo(Produto, Capitulo, "", "", "");
        }

        [Then(@"visualizo a mensagem de capitulo cadastrado com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeCapituloCadastradoComSucesso(string Mensagem)
        {
            TelaCadastrarCapituloPage.ValidarPopUpSucesso(Mensagem);
        }

        [When(@"cancelo o cadastro de um novo capitulo para o produto existente ""(.*)"", ""(.*)""")]
        public void QuandoCanceloOCadastroDeUmNovoCapituloParaOProdutoExistente(string Produto, string Capitulo)
        {
            TelaCadastrarCapituloPage.CancelarCadastrarCapitulo(Produto, Capitulo, "", "", "");
        }

        [Then(@"visualizo a tela de busca de capitulo com sucesso")]
        public void EntaoVisualizoATelaDeBuscaDeCapituloComSucesso()
        {
            TelaCadastrarCapituloPage.ValidarTelaDeConsultaDeCapitulos();
        }

        [When(@"tento cadastrar um capítulo sem preencher os campos obrigatórios")]
        public void QuandoTentoCadastrarUmCapituloSemPreencherOsCamposObrigatorios()
        {
            TelaCadastrarCapituloPage.CadastrarCapitulo("", "", "", "", "");
        }

        [Then(@"visualizo os campos obrigatórios de cadastro de capítulo em destaque")]
        public void EntaoVisualizoOsCamposObrigatoriosDeCadastroDeCapituloEmDestaque()
        {
            TelaCadastrarCapituloPage.ValidarCamposObrigatorios("Produto");
            TelaCadastrarCapituloPage.ValidarCamposObrigatorios("Capítulo");
        }
        
        [When(@"cadastro capitulos em lote para o produto existente ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroCapitulosEmLoteParaOProdutoExistente(string Produto, string Capitulo, string GeracaoLote, string QuantidadeCapitulos)
        {
            TelaCadastrarCapituloPage.CadastrarCapitulo(Produto, Capitulo, GeracaoLote, QuantidadeCapitulos, "");
        }

    }
}
