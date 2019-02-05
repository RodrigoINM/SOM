using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Tabela_de_Preço;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Tabela_de_Preço
{
    [Binding]
    public class AlterarTabelaDePrecosSteps
    {
        public CadastroDeTabelaDePrecosPage TelaCadastroDeTabelaDePrecosPage { get; private set; }

        public AlterarTabelaDePrecosSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeTabelaDePrecosPage = new CadastroDeTabelaDePrecosPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeTabelaDePrecoUrl"],
                ConfigurationManager.AppSettings["ConsultaDeTabelaDePrecoUrl"]);
        }

        [When(@"altero os valores dos tipos de sincronização ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsValoresDosTiposDeSincronizacao(string Genero, string Abertura, string AberturaPontual, string Adorno,
            string AoVivoAdorno, string AoVivoFundo, string AoVivoFundoJornalismo, string AoVivoPerformance, string Encerramento,
            string EncerramentoPontual, string Fundo, string FundoJornalismo, string Performance, string Tema)
        {
            TelaCadastroDeTabelaDePrecosPage.AlterarTabelaDePreco(Genero, "Nacional", Abertura, AberturaPontual, Adorno,
            AoVivoAdorno, AoVivoFundo, AoVivoFundoJornalismo, AoVivoPerformance, Encerramento,
            EncerramentoPontual, Fundo, FundoJornalismo, Performance, Tema);
        }

        [Then(@"visualizo a mensagem de itens alterados com sucesso da tabela de preço ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeItensAlteradosComSucessoDaTabelaDePreco(string Genero, string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
            TelaCadastroDeTabelaDePrecosPage.SelecionarAbaTabelaDePreco(Genero, "Nacional");
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePreco(Genero, "Nacional");
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
        }

        [When(@"altero os valores dos tipos de sincronização internacional ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsValoresDosTiposDeSincronizacaoInternacional(string Genero, string Abertura, string AberturaPontual, string Adorno,
            string AoVivoAdorno, string AoVivoFundo, string AoVivoFundoJornalismo, string AoVivoPerformance, string Encerramento,
            string EncerramentoPontual, string Fundo, string FundoJornalismo, string Performance, string Tema)
        {
            TelaCadastroDeTabelaDePrecosPage.AlterarTabelaDePreco(Genero, "Internacional", Abertura, AberturaPontual, Adorno,
            AoVivoAdorno, AoVivoFundo, AoVivoFundoJornalismo, AoVivoPerformance, Encerramento,
            EncerramentoPontual, Fundo, FundoJornalismo, Performance, Tema);
        }

        [Then(@"visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeItensAlteradosComSucessoDaTabelaDePrecoInternacional(string Genero, string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
            TelaCadastroDeTabelaDePrecosPage.SelecionarAbaTabelaDePreco(Genero, "Internacional");
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePreco(Genero, "Internacional");
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
        }

        //Sair da tela sem salvar alterações de valores
        [Given(@"que estou na tela de edição da tabela de preços")]
        public void DadoQueEstouNaTelaDeEdicaoDaTabelaDePrecos()
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("UBEM - 2023", "01/01/2023", "31/12/2023", "", "Não");
            TelaCadastroDeTabelaDePrecosPage.SelecionarTabelaDePreco("UBEM - 2023");
        }

        [When(@"cancelo a alteração do nome da tabela")]
        public void QuandoCanceloAAlteracaoDoNomeDaTabela()
        {
            TelaCadastroDeTabelaDePrecosPage.EditarTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.CadastrarTabelaDePreco("Teste de Alteração", "", "", "", "");
            TelaCadastroDeTabelaDePrecosPage.CancelarCadastroDeTabelaDePreco();
        }

        //Alterar um fator com sucesso
        [Given(@"que estou na tela de detalhes da tabela de preço")]
        public void DadoQueEstouNaTelaDeDetalhesDaTabelaDePreco()
        {
            DadoQueEstouNaTelaDeEdicaoDaTabelaDePrecos();
        }

        [When(@"altero o valor do fator desejado da tabela de preço ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOValorDoFatorDesejadoDaTabelaDePreco(string Fator, string ValorFator)
        {
            TelaCadastroDeTabelaDePrecosPage.AlterarFatorDaTabelaDePreco(Fator, ValorFator);
        }

        [Then(@"visualizo que o fator da tabela de preço foi alterado com sucesso ""(.*)""")]
        public void EntaoVisualizoQueOFatorDaTabelaDePrecoFoiAlteradoComSucesso(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
        }

        //Alterar uma tabela com sucesso
        [Given(@"que estou na tela de edição de uma tabela de preço ""(.*)""")]
        public void DadoQueEstouNaTelaDeEdicaoDeUmaTabelaDePreco(string Tabela)
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Tabela, "", "", "", "");
            TelaCadastroDeTabelaDePrecosPage.SelecionarTabelaDePreco(Tabela);
        }

        [When(@"altero o nome da tabela de preço ""(.*)""")]
        public void QuandoAlteroONomeDaTabelaDePreco(string Tabela2)
        {
            TelaCadastroDeTabelaDePrecosPage.EditarTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.CadastrarTabelaDePreco(Tabela2, "", "", "", "");
            TelaCadastroDeTabelaDePrecosPage.SalvarCadastroDeTabelaDePreco();
        }

        [Then(@"visualizo a mensagem de tabela de preço alterada com sucesso ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeTabelaDePrecoAlteradaComSucesso(string Mensagem, string Tabela, string Tabela2)
        {
            try
            {
                DadoQueEstouNaTelaDeEdicaoDeUmaTabelaDePreco(Tabela2);
            }
            catch
            {
                DadoQueEstouNaTelaDeEdicaoDeUmaTabelaDePreco(Tabela2);
            }
            QuandoAlteroONomeDaTabelaDePreco(Tabela);
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
        }

        [When(@"altero o valor do tipo de sincronização ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOValorDoTipoDeSincronizacao(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.AlterarTabelaDePreco(Genero, "Nacional", Abertura, "", "", "", "", "", "", "", "", "", "", "", "");
        }

        [When(@"altero o valor do tipo de sincronização internacional ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOValorDoTipoDeSincronizacaoInternacional(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.AlterarTabelaDePreco(Genero, "Internacional", Abertura, "", "", "", "", "", "", "", "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem de itens alterados com sucesso da tabela de preço sem que sejam afetados os pedidos pendentes ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeItensAlteradosComSucessoDaTabelaDePrecoSemQueSejamAfetadosOsPedidosPendentes(string Genero, string Mensagem)
        {
            EntaoVisualizoAMensagemDeItensAlteradosComSucessoDaTabelaDePreco(Genero, Mensagem);
        }

        [Then(@"visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional sem que sejam afetados os pedidos pendentes ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeItensAlteradosComSucessoDaTabelaDePrecoInternacionalSemQueSejamAfetadosOsPedidosPendentes(string Genero, string Mensagem)
        {
            EntaoVisualizoAMensagemDeItensAlteradosComSucessoDaTabelaDePrecoInternacional(Genero, Mensagem);
        }

    }
}
