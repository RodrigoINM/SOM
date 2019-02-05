using Framework.Core.Interfaces;
using SOM.BDD.Pages.Pagamento.Tabela_de_Preço;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Tabela_e_Preço
{
    [Binding]
    public sealed class CadastroDeTabelaDePrecosSteps
    {
        public CadastroDeTabelaDePrecosPage TelaCadastroDeTabelaDePrecosPage { get; private set; }


        public CadastroDeTabelaDePrecosSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeTabelaDePrecosPage = new CadastroDeTabelaDePrecosPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeTabelaDePrecoUrl"],
                ConfigurationManager.AppSettings["ConsultaDeTabelaDePrecoUrl"]);
        }

        [Given(@"que estou na tela de cadastro de Tabela de Preço")]
        public void DadoQueEstouNaTelaDeCadastroDeTabelaDePreco()
        {
            TelaCadastroDeTabelaDePrecosPage.Navegar();
        }

        [When(@"cadastro uma nova tabela de preço ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaTabelaDePreco(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.CadastrarTabelaDePreco(Nome, InicioVigencia, FimVigencia, Midia, Padrao);
            TelaCadastroDeTabelaDePrecosPage.SalvarCadastroDeTabelaDePreco();
        }

        [Then(@"visualizo a mensagem de tabela de preço criada com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeTabelaDePrecoCriadaComSucesso(string Mensagem)
        {
            try
            {
                TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
            }
            catch
            {
                TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica("Já existe uma tabela cadastrada com este nome e data de vigência.");
            }
        }

        //Validar mensagem de erro ao cadastrar tabelas iguais
        [When(@"cadastro uma nova tabela de preço com o mesmo nome e periodo de vigencia de uma tabela previamente cadastrada ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaTabelaDePrecoComOMesmoNomeEPeriodoDeVigenciaDeUmaTabelaPreviamenteCadastrada(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.CadastrarTabelaDePreco(Nome, InicioVigencia, FimVigencia, Midia, Padrao);
            TelaCadastroDeTabelaDePrecosPage.SalvarCadastroDeTabelaDePreco();
        }

        [Then(@"visualizo a mensagem de critica ao tentar salvar a tabela ""(.*)""")]
        public void EntaoVisualizoAMensagemDeCriticaAoTentarSalvarATabela(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica(Mensagem);
        }

        //Criar tabelas com o mesmo período de vigência
        [When(@"cadastro uma nova tabela de preço com o mesmo periodo de vigencia de uma tabela previamente cadastrada ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaTabelaDePrecoComOMesmoPeriodoDeVigenciaDeUmaTabelaPreviamenteCadastrada(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            QuandoCadastroUmaNovaTabelaDePreco(Nome, InicioVigencia, FimVigencia, Midia, Padrao);
        }

        //Validar campos obrigatórios com sucesso
        [When(@"cadastro uma nova tabela sem preencher os campos obrigatorios ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaTabelaSemPreencherOsCamposObrigatorios(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            QuandoCadastroUmaNovaTabelaDePreco(Nome, InicioVigencia, FimVigencia, Midia, Padrao);
        }

        [Then(@"visualizo os campos destacados para preenchimento")]
        public void EntaoVisualizoOsCamposDestacadosParaPreenchimento()
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarCamposObrigatorios();
        }

        //Validar data inválida com sucesso
        [When(@"cadastro uma nova tabela preenchendo os campos ""(.*)"" e ""(.*)"" com datas inválidas")]
        public void QuandoCadastroUmaNovaTabelaPreenchendoOsCamposEComDatasInvalidas(string InicioVigencia, string FimVigencia)
        {
            QuandoCadastroUmaNovaTabelaDePreco("", InicioVigencia, FimVigencia, "", "");
        }

        //Adicionar valor à aba Dramaturgia Diária da tabela nacional com sucesso
        [Given(@"que estou na tela de detalhes da tabela de preço, na aba Dramaturgia Diária")]
        public void DadoQueEstouNaTelaDeDetalhesDaTabelaDePrecoNaAbaDramaturgiaDiaria()
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("UBEM - 2023", "01/01/2023", "31/12/2023", "", "Não");
            TelaCadastroDeTabelaDePrecosPage.SelecionarTabelaDePreco("UBEM - 2023");
        }
        
        [Then(@"visualizo a mensagem de itens adicionados com sucesso à tabela de preço ""(.*)""")]
        public void EntaoVisualizoAMensagemDeItensAdicionadosComSucessoATabelaDePreco(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupSucesso(Mensagem);
        }

        [Given(@"que estou na tela de detalhes da tabela de preço ""(.*)""")]
        public void DadoQueEstouNaTelaDeDetalhesDaTabelaDePreco(string Genero)
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("UBEM - 2023", "01/01/2023", "31/12/2023", "", "Não");
            TelaCadastroDeTabelaDePrecosPage.SelecionarTabelaDePreco("UBEM - 2023");
            TelaCadastroDeTabelaDePrecosPage.SelecionarAbaGeneroNacionalInternacional(Genero, "Nacional");
        }

        [When(@"preencho com valor válido os tipos de sincronização ""(.*)""")]
        public void QuandoPreenchoComValorValidoOsTiposDeSincronizacao(string Genero)
        {
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePreco(Genero, "Nacional");
        }


        [Given(@"que estou na tela de detalhes da tabela de preço internacional ""(.*)""")]
        public void DadoQueEstouNaTelaDeDetalhesDaTabelaDePrecoInternacional(string Genero)
        {
            TelaCadastroDeTabelaDePrecosPage.NavegarConsultaDeTabelaDePreco();
            TelaCadastroDeTabelaDePrecosPage.PesquisarPorTabelaDePreco("UBEM - 2023", "01/01/2023", "31/12/2023", "", "Não");
            TelaCadastroDeTabelaDePrecosPage.SelecionarTabelaDePreco("UBEM - 2023");
            TelaCadastroDeTabelaDePrecosPage.SelecionarAbaGeneroNacionalInternacional(Genero, "Internacional");
        }

        [When(@"preencho com valor válido os tipos de sincronização internacionais ""(.*)""")]
        public void QuandoPreenchoComValorValidoOsTiposDeSincronizacaoInternacionais(string Genero)
        {
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePreco(Genero, "Internacional");
        }

        //Validar não aceitação de valores negativos na tabela nacional
        [When(@"preencho com valor negativo no tipo de sincronização ""(.*)"", ""(.*)""")]
        public void QuandoPreenchoComValorNegativoNoTipoDeSincronizacao(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePrecoValorInvalido(Abertura, Genero, "ABERTURA", "Nacional");
        }

        [Then(@"visualizo o campo voltar a apresentar o ultimo valor valido da tabela de preço ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOCampoVoltarAApresentarOUltimoValorValidoDaTabelaDePreco(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarValorInvalidoTabelaDePreco(Abertura, Genero, "ABERTURA", "Nacional");
        }

        //Validar não aceitação de valores negativos na tabela internacional
        [When(@"preencho com valor negativo no tipo de sincronização internacional ""(.*)"", ""(.*)""")]
        public void QuandoPreenchoComValorNegativoNoTipoDeSincronizacaoInternacional(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePrecoValorInvalido(Abertura, Genero, "ABERTURA", "Internacional");
        }

        [Then(@"visualizo o campo voltar a apresentar o ultimo valor valido da tabela de preço internacional ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOCampoVoltarAApresentarOUltimoValorValidoDaTabelaDePrecoInternacional(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarValorInvalidoTabelaDePreco(Abertura, Genero, "ABERTURA", "Internacional");
        }

        //Verificar mensagem de erro ao cadastrar valores da tabela nacional com valores muito altos
        [When(@"preencho com valor muito alto no tipo de sincronização ""(.*)"", ""(.*)""")]
        public void QuandoPreenchoComValorMuitoAltoNoTipoDeSincronizacao(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePrecoValorInvalido(Abertura, Genero, "ABERTURA", "Nacional");
        }

        [Then(@"visualizo a mensagem de erro ao tentar salvar a tabela de preço ""(.*)""")]
        public void EntaoVisualizoAMensagemDeErroAoTentarSalvarATabelaDePreco(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.SalvarTabelaDePreco("Nacional");
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica(Mensagem);
        }

        //Verificar mensagem de erro ao cadastrar valores da tabela internacional com valores muito altos
        [When(@"preencho com valor muito alto no tipo de sincronização internacional ""(.*)"", ""(.*)""")]
        public void QuandoPreenchoComValorMuitoAltoNoTipoDeSincronizacaoInternacional(string Genero, string Abertura)
        {
            TelaCadastroDeTabelaDePrecosPage.PreencherTabelaDePrecoValorInvalido(Abertura, Genero, "ABERTURA", "Internacional");
        }

        [Then(@"visualizo a mensagem de erro ao tentar salvar a tabela de preço internacional ""(.*)""")]
        public void EntaoVisualizoAMensagemDeErroAoTentarSalvarATabelaDePrecoInternacional(string Mensagem)
        {
            TelaCadastroDeTabelaDePrecosPage.SalvarTabelaDePreco("Internacional");
            TelaCadastroDeTabelaDePrecosPage.ValidarPopupCritica(Mensagem);
        }

        //Sair da tela sem salvar cadastro de tabela
        [When(@"cancelo o cadastro de uma nova tabela de preço ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCanceloOCadastroDeUmaNovaTabelaDePreco(string Nome, string InicioVigencia, string FimVigencia, string Midia, string Padrao)
        {
            TelaCadastroDeTabelaDePrecosPage.CadastrarTabelaDePreco(Nome, InicioVigencia, FimVigencia, Midia, Padrao);
            TelaCadastroDeTabelaDePrecosPage.CancelarCadastroDeTabelaDePreco();
        }

        [Then(@"visualizo a tela de busca por tabela de preço")]
        public void EntaoVisualizoATelaDeBuscaPorTabelaDePreco()
        {
            TelaCadastroDeTabelaDePrecosPage.ValidarTelaDeBusca();
        }

    }
}
