using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Tabela_de_Preço;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Tabela_de_Preço
{
    [Binding]
    public class TabelasDePrecoFatoresSteps
    {
        public CadastroDeTabelaDePrecosPage TelaCadastroDeTabelaDePrecosPage { get; private set; }

        public TabelasDePrecoFatoresSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeTabelaDePrecosPage = new CadastroDeTabelaDePrecosPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeTabelaDePrecoUrl"],
                ConfigurationManager.AppSettings["ConsultaDeTabelaDePrecoUrl"]);
        }

        [Given(@"que estou na tela de detalhes da tabela de preço desejada ""(.*)""")]
        public void DadoQueEstouNaTelaDeDetalhesDaTabelaDePrecoDesejada(string Nome)
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Nome, "", "", "", "");
            TelaCadastroDeTabelaDePrecosPage.SelecionarTabelaDePreco(Nome);
        }

        [When(@"cadastro um novo fator para a tabela de preço ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoFatorParaATabelaDePreco(string Midia, string Fator)
        {
            TelaCadastroDeTabelaDePrecosPage.CadastrarFatorDaTabelaDePreco(Midia, Fator);
        }

        [Then(@"visualizo a mensagem de fator incluido com sucesso na tabela de preço ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeFatorIncluidoComSucessoNaTabelaDePreco(string Mensagem, string Midia)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
            TelaCadastroDeTabelaDePrecosPage.ExcluirFatorDaTabelaDePreco(Midia);
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso("Fator excluído com sucesso");
        }

        [When(@"excluo o fator cadastrado ""(.*)""")]
        public void QuandoExcluoOFatorCadastrado(string Midia)
        {
            TelaCadastroDeTabelaDePrecosPage.ExcluirFatorDaTabelaDePreco(Midia);
        }

        [Then(@"visualizo a mensagem de fator excluido com sucesso na tabela de preço ""(.*)""")]
        public void EntaoVisualizoAMensagemDeFatorExcluidoComSucessoNaTabelaDePreco(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
        }

        [When(@"cadastro um fator igual ao já existente ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmFatorIgualAoJaExistente(string Midia, string Fator)
        {
            TelaCadastroDeTabelaDePrecosPage.Refresh();
            TelaCadastroDeTabelaDePrecosPage.CadastrarFatorDaTabelaDePreco(Midia, Fator);
        }

        [Then(@"visualizo a mensagem de que já existe um fator para essa midia na tabela de preço ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueJaExisteUmFatorParaEssaMidiaNaTabelaDePreco(string Mensagem, string Midia)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica(Mensagem);
            TelaCadastroDeTabelaDePrecosPage.Refresh();
            TelaCadastroDeTabelaDePrecosPage.ExcluirFatorDaTabelaDePreco(Midia);
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso("Fator excluído com sucesso");
        }

        [Then(@"visualizo a mensagem de erro ao tentar incluir um fator com valor muito alto na tabela de preço ""(.*)""")]
        public void EntaoVisualizoAMensagemDeErroAoTentarIncluirUmFatorComValorMuitoAltoNaTabelaDePreco(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica(Mensagem);
        }

        [Then(@"visualizo a mensagem de erro ao tentar incluir um fator com valor negativo na tabela de preço ""(.*)""")]
        public void EntaoVisualizoAMensagemDeErroAoTentarIncluirUmFatorComValorNegativoNaTabelaDePreco(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica(Mensagem);
        }

    }
}
