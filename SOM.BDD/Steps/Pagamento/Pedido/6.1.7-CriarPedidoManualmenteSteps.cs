using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using SOM.BDD.Pages.Produto;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido
{
    [Binding]
    public sealed class CriarPedidoManualmenteSteps
    {
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }

        public CriarPedidoManualmenteSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCriarPedidoManualmentePage = new CriarPedidoManualmentePage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDePedidoUrl"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
        }

        [Given(@"que tenha um produto e uma obra cadastrada no sistema")]
        public void DadoQueTenhaUmProdutoEUmaObraCadastradaNoSistema()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "1");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "2");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
        }

        [Given(@"que estou na tela de criação de pedidos")]
        public void DadoQueEstouNaTelaDeCriacaoDePedidos()
        {
            TelaCriarPedidoManualmentePage.Navegar();
        }

        [Then(@"visualizo o pedido gerado com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOPedidoGeradoComSucesso(string MidiaADebitar, string Sincronismo, string Status, string StatusPav, string Reprise)
        {
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
            TelaCriarPedidoManualmentePage.ValidarPedidoCriado(MidiaADebitar, Sincronismo, Status, StatusPav, Reprise);
        }

        //Criar Pedido sem Tabela Vigente
        [When(@"crio um novo pedido manualmente ""(.*)"", ""(.*)"", ""(.*)"" ""(.*)""")]
        public void QuandoCrioUmNovoPedidoManualmente(string DataExibicao, string Tempo, string MidiaADebitar, string Sincronismo)
        {
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(CadastrarObraEComposicaoPage.Obra, DataExibicao, Tempo, MidiaADebitar, Sincronismo);
        }

        [Then(@"eu visualizo a mensagem de critica informando que o pedido não pode ser criado para essa data ""(.*)""")]
        public void EntaoEuVisualizoAMensagemDeCriticaInformandoQueOPedidoNaoPodeSerCriadoParaEssaData(string Mensagem)
        {
            TelaCriarPedidoManualmentePage.ValidarPopupCritica(Mensagem);
        }

        //Obra de domínio público
        [Given(@"que tenha um produto e uma obra de dominio publico cadastrada no sistema")]
        public void DadoQueTenhaUmProdutoEUmaObraDeDominioPublicoCadastradaNoSistema()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Sim", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
        }

        [When(@"crio um novo pedido manualmente para uma obra de dominio publico")]
        public void QuandoCrioUmNovoPedidoManualmenteParaUmaObraDeDominioPublico()
        {
            TelaCriarPedidoManualmentePage.Navegar();
            TelaCriarPedidoManualmentePage.CadastrarPedidoManualObraDominioPublico();
        }

        [Then(@"eu visualizo a mensagem de critica informando que o pedido não pode ser criado para essa obra ""(.*)""")]
        public void EntaoEuVisualizoAMensagemDeCriticaInformandoQueOPedidoNaoPodeSerCriadoParaEssaObra(string Mensagem)
        {
            TelaCriarPedidoManualmentePage.ValidarPopupCritica(Mensagem);
        }

        //Cadastro de Intérprete
        [When(@"cadastro um novo interprete")]
        public void QuandoCadastroUmNovoInterprete()
        {
            TelaCriarPedidoManualmentePage.CadastroDeInterprete();
        }

        [Then(@"visualizo a mensagem de Intérprete cadastrado com sucesso")]
        public void EntaoVisualizoAMensagemDeInterpreteCadastradoComSucesso()
        {
            TelaCriarPedidoManualmentePage.ValidarPopupSucesso("Intérprete cadastrado com sucesso.");
        }

        //Todos os itens com autores contratados
        [Given(@"que tenha um produto e uma obra cadastrada no sistema com autores contratados")]
        public void DadoQueTenhaUmProdutoEUmaObraCadastradaNoSistemaComAutoresContratados()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmenteAutorContratado("100");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
        }

        [When(@"crio um novo pedido manualmente para uma obra com autores contratados")]
        public void QuandoCrioUmNovoPedidoManualmenteParaUmaObraComAutoresContratados()
        {
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(CadastrarObraEComposicaoPage.Obra, "10/10/2018", "10", "CANAL INTERNACIONAL", "ABERTURA");
        }

    }
}
