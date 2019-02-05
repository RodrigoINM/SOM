using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Tabela_de_Preço;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Tabela_de_Preço
{
    [Binding]
    public sealed class ConsultarTabelaDePrecosSteps
    {
        public CadastroDeTabelaDePrecosPage TelaCadastroDeTabelaDePrecosPage { get; private set; }

        public ConsultarTabelaDePrecosSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeTabelaDePrecosPage = new CadastroDeTabelaDePrecosPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeTabelaDePrecoUrl"],
                ConfigurationManager.AppSettings["ConsultaDeTabelaDePrecoUrl"]);
        }

        [Given(@"que esteja na tela de consulta de tabela de preço")]
        public void DadoQueEstejaNaTelaDeConsultaDeTabelaDePreco()
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
        }

        //Buscar Tabela por um campo em branco com sucesso
        [When(@"faço uma busca rápida sem preencher nenhum campo")]
        public void QuandoFacoUmaBuscaRapidaSemPreencherNenhumCampo()
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("", "", "", "", "");
        }
        
        [Then(@"visualizo uma grid com as tabelas cadastradas por ordem alfabetica no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoUmaGridComAsTabelasCadastradasPorOrdemAlfabeticaNoResultadoDaBusca(string Nome, string InicioVigencia, string FimVigencia, 
            string Midia, string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(Nome);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(InicioVigencia);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(FimVigencia);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(Midia);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(Padrao);
        }

        //Buscar por uma tabela de preço com sucesso
        [When(@"faço uma busca de tabela de preço por nome ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorNome(string Nome)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Nome, "", "", "", "");
        }

        [Then(@"visualizo os dados da tabela de preço no resultado da busca ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDaTabelaDePrecoNoResultadoDaBusca(string Nome, string InicioVigencia, string FimVigencia,
            string Midia, string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(Nome);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(InicioVigencia);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(FimVigencia);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(Midia);
            TelaCadastroDeTabelaDePrecosPage.ValidarTabelaDePrecos(Padrao);
        }

        //Buscar com informação não cadastrada
        [When(@"faço uma busca por uma tabela de preço que não está cadastrada no sistema ""(.*)""")]
        public void QuandoFacoUmaBuscaPorUmaTabelaDePrecoQueNaoEstaCadastradaNoSistema(string Nome)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Nome, "", "", "", "");
        }

        [Then(@"visualizo a mensagem de dados não encontrados no resultado da busca por tabela de preço inexistente ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDadosNaoEncontradosNoResultadoDaBuscaPorTabelaDePrecoInexistente(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarDadosNaoEncontradosNaBusca(Mensagem);
        }

        [When(@"faço uma busca de tabela de preço por nome e midia ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorNomeEMidia(string Nome, string Midia)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Nome, "", "", Midia, "");
        }

        [When(@"faço uma busca de tabela de preço por inicio e fim de vigencia ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorInicioEFimDeVigencia(string InicioVigencia, string FimVigencia)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("", InicioVigencia, FimVigencia, "", "");
        }

        [When(@"faço uma busca de tabela de preço por inicio de vigencia ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorInicioDeVigencia(string InicioVigencia)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("", InicioVigencia, "", "", "");
        }

        [When(@"faço uma busca de tabela de preço por fim de vigencia ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorFimDeVigencia(string FimVigencia)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("", "", FimVigencia, "", "");
        }

        [When(@"faço uma busca de tabela de preço por padrão ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorPadrao(string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("", "", "", "", Padrao);
        }

        [When(@"faço uma busca de tabela de preço por nome e midia não associados entre si ""(.*)"", ""(.*)""")]
        public void QuandoFacoUmaBuscaDeTabelaDePrecoPorNomeEMidiaNaoAssociadosEntreSi(string Nome, string Midia)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Nome, "", "", Midia, "");
        }

        [Then(@"visualizo a mensagem de dados não encontrados no resultado da busca por tabela de preço por campos não associados entre si ""(.*)""")]
        public void EntaoVisualizoAMensagemDeDadosNaoEncontradosNoResultadoDaBuscaPorTabelaDePrecoPorCamposNaoAssociadosEntreSi(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarDadosNaoEncontradosNaBusca(Mensagem);
        }

        [When(@"que preencho os campos de busca por tabela de preço ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoQuePreenchoOsCamposDeBuscaPorTabelaDePreco(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco(Nome, InicioVigencia, FimVigencia, Midia, Padrao);
        }

        [When(@"limpo os campos da consulta")]
        public void QuandoLimpoOsCamposDaConsulta()
        {
            TelaCadastroDeTabelaDePrecosPage.LimparCamposDeBusca();
        }

        [Then(@"visualizo os campos de busca sem preenchimento")]
        public void EntaoVisualizoOsCamposDeBuscaSemPreenchimento()
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarCamposDeBuscaEmBranco();
        }

    }
}
