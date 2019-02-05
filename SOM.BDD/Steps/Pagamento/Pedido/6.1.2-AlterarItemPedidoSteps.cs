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
    public sealed class AlterarItemPedidoSteps
    {
        public CriarPedidoManualmentePage TelaCriarPedidoManualmentePage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public PedidoPage TelaPedidoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public ExcluirObraPage TelaExcluirObraPage { get; private set; }

        public AlterarItemPedidoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCriarPedidoManualmentePage = new CriarPedidoManualmentePage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDePedidoUrl"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaAlterarItemPedidoPage = new AlterarItemPedidoPage((IBrowser)browser);
            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);
            TelaExcluirObraPage = new ExcluirObraPage((IBrowser)browser);
        }

        [When(@"altero o valor do pagamento, a moeda e a taxa de conversão de um item do pedido ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOValorDoPagamentoAMoedaEATaxaDeConversaoDeUmItemDoPedido(string ValorPagamento, string Moeda, string TaxaConversao, string Autor)
        {
            TelaAlterarItemPedidoPage.EditarItemDePedido(ValorPagamento, Moeda, TaxaConversao, CadastrarObraEComposicaoPage.Autor);
            TelaAlterarItemPedidoPage.SalvarEdicaoPedido();
        }

        [Then(@"visualizo o novo valor a ser pago para o DDA do Autor na aba de pagamento ""(.*)""")]
        public void EntaoVisualizoONovoValorASerPagoParaODDADoAutorNaAbaDePagamento(string NovoValor)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(CadastrarObraEComposicaoPage.Autor);
            TelaAlterarItemPedidoPage.ValidarValorTotalUmItemSelecionado(NovoValor, CadastrarObraEComposicaoPage.Autor);
        }

        //Validar item bloqueado para edição quando já estiver Aprovado
        [Given(@"que tenha um pedido previamente cadastrado no sistema ""(.*)""")]
        public void DadoQueTenhaUmPedidoPreviamenteCadastradoNoSistema(string Obra)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
            TelaCriarPedidoManualmentePage.Navegar();
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(Obra, "10/10/2018", "10", "GLOBONEWS", "ABERTURA");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
        }

        [Given(@"que possua um item com status de aguardando aprovacao ""(.*)"", ""(.*)""")]
        public void DadoQuePossuaUmItemComStatusDeAguardandoAprovacao(string Status, string Autor)
        {
            TelaAlterarItemPedidoPage.RegistrarAutorizacaoDeItem(Autor);
            TelaAlterarItemPedidoPage.ValidarPopupAutorizacaoDDA("", "Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("1 item(ns) registrado(s) com sucesso.");
            TelaAlterarItemPedidoPage.ValidarStatusAutorizacao("Autorizado", Autor);
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Autor);
            TelaAlterarItemPedidoPage.RealizarPagamento();
            TelaAlterarItemPedidoPage.PopupRealizarPagamento("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento(Status, Autor);
        }
        

        [When(@"tento editar esse item ""(.*)""")]
        public void QuandoTentoEditarEsseItem(string Autor)
        {
            TelaAlterarItemPedidoPage.SelecionarItemParaEditar(Autor);
        }

        [Then(@"visualizo os campos de ""(.*)"", ""(.*)"" e ""(.*)"" bloqueados para edicao")]
        public void EntaoVisualizoOsCamposDeEBloqueadosParaEdicao(string p0, string p1, string p2)
        {
            TelaAlterarItemPedidoPage.ValidarCamposBloqueadosParaEdicao();
        }

        //Registrar Autorização
        [When(@"regsitro a autorizacao para um item do pedido ""(.*)""")]
        public void QuandoRegsitroAAutorizacaoParaUmItemDoPedido(string Autor)
        {
            TelaAlterarItemPedidoPage.RegistrarAutorizacaoDeItem(CadastrarObraEComposicaoPage.Autor);
        }

        [Then(@"visualizo o pop up de confirmação para o DDA selecionado ""(.*)""")]
        public void EntaoVisualizoOPopUpDeConfirmacaoParaODDASelecionado(string DDA)
        {
            TelaAlterarItemPedidoPage.ValidarPopupAutorizacaoDDA("", "Sim");
        }

        [Then(@"a mensagem de sucesso apos confirmar a autorizacao do item do pedido ""(.*)""")]
        public void EntaoAMensagemDeSucessoAposConfirmarAAutorizacaoDoItemDoPedido(string Mensagem)
        {
            TelaAlterarItemPedidoPage.ValidarPopupSucesso(Mensagem);
        }

        [Then(@"visualizo o status de autorizado para o item selecionado ""(.*)""")]
        public void EntaoVisualizoOStatusDeAutorizadoParaOItemSelecionado(string Status)
        {
            TelaAlterarItemPedidoPage.ValidarStatusAutorizacao(Status, CadastrarObraEComposicaoPage.Autor);
        }

        //Validar o pagamento para o Administrador com sucesso
        [When(@"faço o pagamento ao Administrador ""(.*)""")]
        public void QuandoFacoOPagamentoAoAdministrador(string Autor)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Autor);
            TelaAlterarItemPedidoPage.PagarAoAdministrador();
        }

        [Then(@"visualizo a mensagem de sucesso após confirmar o pagamento ao administrador ""(.*)""")]
        public void EntaoVisualizoAMensagemDeSucessoAposConfirmarOPagamentoAoAdministrador(string Mensagem)
        {
            TelaAlterarItemPedidoPage.ValidarPopupAutorizacaoDDA("", "Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso(Mensagem);
        }

        [Then(@"visualizo o campo de pagar ao administrador preenchido ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOCampoDePagarAoAdministradorPreenchido(string Autor, string PagarAdministrador)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarPagamentoAoAdministrador(Autor, PagarAdministrador);
        }

        //Cancelar um item de pedido no detelhe do pedido
        [When(@"cancelo um item de pedido para um autor ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCanceloUmItemDePedidoParaUmAutor(string Mensagem, string StatusDeAprovacao, string Autor)
        {
            if (StatusDeAprovacao == "Aguardando Autorização")
            {
                TelaPedidoPage.SelecionarUmItemDePedidoAutorização(Autor);
                TelaAlterarItemPedidoPage.EnviarAutorizacao();
            }
            TelaPedidoPage.SelecionarUmItemDePedidoAutorização(Autor);
            TelaAlterarItemPedidoPage.CancelarItemDePedido();
            TelaAlterarItemPedidoPage.ValidarPopupItemCancelado(Mensagem);
        }

        [Then(@"visualizo o item do pedido com o status de cancelado ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOItemDoPedidoComOStatusDeCancelado(string Status, string Autor)
        {
            TelaAlterarItemPedidoPage.ValidarStatusAutorizacao(Status, Autor);
        }

        //Cancelar um item de pedido na busca por pedido
        [When(@"cancelo um item de pedido para um autor na busca de pedido ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCanceloUmItemDePedidoParaUmAutorNaBuscaDePedido(string Mensagem, string StatusDeAprovacao, string Autor)
        {
            TelaPedidoPage.Navegar();
            TelaAlterarItemPedidoPage.ConsultaDePedido("Obra");
            if (StatusDeAprovacao == "Aguardando Autorização")
            {
                TelaPedidoPage.AcessarAbaAutorizacaoNaTelaDeBusca();
                TelaPedidoPage.SelecionarUmItemDePedidoAutorizacaoNaTelaDeBusca(Autor);
                TelaAlterarItemPedidoPage.EnviarAutorizacao();
            }
            TelaPedidoPage.AcessarAbaAutorizacaoNaTelaDeBusca();
            TelaPedidoPage.SelecionarUmItemDePedidoAutorizacaoNaTelaDeBusca(Autor);
            TelaAlterarItemPedidoPage.CancelarItemDePedido();
            TelaAlterarItemPedidoPage.ValidarPopupItemCancelado(Mensagem);
        }

        [Then(@"visualizo o item do pedido com o status de cancelado na busca de pedido ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOItemDoPedidoComOStatusDeCanceladoNaBuscaDePedido(string StatusFinal, string Autor)
        {
            TelaPedidoPage.AcessarAbaPagamentoNaTelaDeBusca();
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusFinal, Autor);
        }

        //Alterar o valor do DNI com sucesso
        [When(@"adiciono um item de DNI no pedido")]
        public void QuandoAdicionoUmItemDeDNINoPedido()
        {
            TelaAlterarItemPedidoPage.AdicionarDNI();
        }

        [When(@"insiro um valor para o campo de pagamento do DNI ""(.*)"", ""(.*)""")]
        public void QuandoInsiroUmValorParaOCampoDePagamentoDoDNI(string Midia, string ValorPagamento)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.EditarItemDePedido(ValorPagamento, "", "", Midia);
            TelaAlterarItemPedidoPage.SalvarEdicaoPedido();
        }

        [Then(@"o valor do item de DNI atualizado ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoOValorDoItemDeDNIAtualizado(string Mensagem, string Midia, string ValorPagamento)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Midia);
            TelaAlterarItemPedidoPage.ValidarValorTotalUmItemSelecionado(ValorPagamento, Midia);
        }

        //Remover registro de Pagamento Ao Administrador com sucesso
        [When(@"removo o registro de pagamento ao administrador ""(.*)"", ""(.*)""")]
        public void QuandoRemovoORegistroDePagamentoAoAdministrador(string Autor, string Mensagem)
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Autor);
            TelaAlterarItemPedidoPage.PagarAoAdministrador();
            TelaAlterarItemPedidoPage.ValidarPopupAutorizacaoDDA("", "Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso(Mensagem);
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarPagamentoAoAdministrador(Autor, "Sim");
            TelaPedidoPage.SelecionarUmItemDePedidoPagamento(Autor);
            TelaAlterarItemPedidoPage.RemoverPagamentoAoAdministrador();
            TelaAlterarItemPedidoPage.ValidarPopupAutorizacaoDDA("", "Sim");
        }

        [Then(@"visualizo a mensagem de alteração realizada com sucesso ao remover o registro de pagamento ao administrador ""(.*)""")]
        public void EntaoVisualizoAMensagemDeAlteracaoRealizadaComSucessoAoRemoverORegistroDePagamentoAoAdministrador(string Mensagem)
        {
            TelaAlterarItemPedidoPage.ValidarPopupSucesso(Mensagem);
        }

        //Alterar nacionalidade para obras com pedido pendente
        [Given(@"que tenha um pedido previamente cadastrado no sistema para uma obra nacional ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmPedidoPreviamenteCadastradoNoSistemaParaUmaObraNacional(string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica(Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional, BlackList, Emblematica);
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "1");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "2");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            Thread.Sleep(2000);
            TelaCriarPedidoManualmentePage.Navegar();
            TelaCriarPedidoManualmentePage.CadastrarPedidoManual(CadastrarObraEComposicaoPage.Obra, "10/10/2018", "10", "GLOBONEWS", "ABERTURA");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
            TelaCriarPedidoManualmentePage.ValidarPedidoCriado("", "", "Em andamento", "", "");
        }

        [When(@"altero a nacionalidade da obra para internacional ""(.*)"", ""(.*)""")]
        public void QuandoAlteroANacionalidadeDaObraParaInternacional(string NovaNacionalidade, string NovoPais)
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(CadastrarObraEComposicaoPage.Obra);
            TelaCadastrarObraEComposicaoPage.EditarObra(CadastrarObraEComposicaoPage.Obra, "", "", "", "", "", "", NovaNacionalidade, NovoPais, "", "", "", "");
        }

        [When(@"seleciono o pedido a ser afetado pela alteracao")]
        public void QuandoSelecionoOPedidoASerAfetadoPelaAlteracao()
        {
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(CadastroDeProdutoPage.Produto);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }

        [Then(@"visualizo que os itens do pedido foram cancelados")]
        public void EntaoVisualizoQueOsItensDoPedidoForamCancelados()
        {
            TelaPedidoPage.Navegar();
            TelaAlterarItemPedidoPage.ConsultaDePedido("Obra");
            TelaAlterarItemPedidoPage.AcessarPedido();
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("Cancelado", "Autor");
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("Cancelado", "Autor2");
        }

        [Then(@"visualizo que foram criados outros itens com o valor referente a tabela de preco internacional")]
        public void EntaoVisualizoQueForamCriadosOutrosItensComOValorReferenteATabelaDePrecoInternacional()
        {
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("A Pagar", "Autor");
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("A Pagar", "Autor2");
        }

        //Alterar obra para Dominio Publico com pedido pendente
        [When(@"altero a obra para dominio publico")]
        public void QuandoAlteroAObraParaDominioPublico()
        {
            TelaCadastrarObraEComposicaoPage.EditarObra(CadastrarObraEComposicaoPage.Obra, "", "", "", "", "", "", "", "", "Sim", "", "", "");
        }

        [Then(@"visualizo que os itens do pedido foram cancelados ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOsItensDoPedidoForamCancelados(string Autor1, string Autor2)
        {
            TelaPedidoPage.Navegar();
            TelaAlterarItemPedidoPage.ConsultaDePedido("Obra");
            TelaAlterarItemPedidoPage.AcessarPedido();
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("Cancelado", Autor1);
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("Cancelado", Autor2);
        }


        [When(@"altero a obra para blacklist")]
        public void QuandoAlteroAObraParaBlacklist()
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(CadastrarObraEComposicaoPage.Obra);
            TelaCadastrarObraEComposicaoPage.EditarObra(CadastrarObraEComposicaoPage.Obra, "", "", "", "", "", "", "", "", "", "", "Sim", "");
        }

        [Then(@"visualizo que os itens do pedido não foram afetados pela alteração ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOsItensDoPedidoNaoForamAfetadosPelaAlteracao(string Autor1, string Autor2)
        {
            TelaPedidoPage.Navegar();
            TelaAlterarItemPedidoPage.ConsultaDePedido("Obra");
            TelaAlterarItemPedidoPage.AcessarPedido();
            TelaCriarPedidoManualmentePage.TrocarAbaBrowser();
            TelaPedidoPage.AcessarAbaPagamento();
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("A Pagar", Autor1);
            TelaAlterarItemPedidoPage.ValidarStatusPagamento("A Pagar", Autor2);
        }

        //Alterar porcentagem dos autores da composição de uma obra com pedido pendente
        [When(@"faço uma busca pela obra associada ao pedido ""(.*)""")]
        public void QuandoFacoUmaBuscaPelaObraAssociadaAoPedido(string Obra)
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Obra);
        }

        [When(@"altero a porcentagem dos autores da composição ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroAPorcentagemDosAutoresDaComposicao(string Autor1, string Autor2, string Porcentagem1, string Porcentagem2)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor1);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Porcentagem1, "");
            TelaCadastrarObraEComposicaoPage.ValidarAutor(Porcentagem1);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor2);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Porcentagem2, "");
            TelaCadastrarObraEComposicaoPage.ValidarAutor(Porcentagem2);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }

        [When(@"seleciono o pedido a ser afetado pela alteração através do produto associado ""(.*)""")]
        public void QuandoSelecionoOPedidoASerAfetadoPelaAlteracaoAtravesDoProdutoAssociado(string Produto)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(Produto);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }

        [When(@"faço uma busca pelo pedido através do nome da obra associada ""(.*)""")]
        public void QuandoFacoUmaBuscaPeloPedidoAtravesDoNomeDaObraAssociada(string Obra)
        {
            TelaPedidoPage.Navegar();
            TelaAlterarItemPedidoPage.ConsultaDePedido("Produto");
        }

        [Then(@"visualizo que os itens anteriores foram cancelados na tela de pagamento ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOsItensAnterioresForamCanceladosNaTelaDePagamento(string Autor1, string Autor2, string StatusItem)
        {
            TelaPedidoPage.AcessarAbaPagamentoNaTelaDeBusca();
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusItem, Autor1);
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusItem, Autor2);
        }

        [Then(@"visualizo que existem novos itens a pagar com valores diferentes ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueExistemNovosItensAPagarComValoresDiferentes(string Autor1, string Autor2, string StatusFinalItem)
        {
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusFinalItem, Autor1);
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusFinalItem, Autor2);
            TelaPedidoPage.ValidarNovosValoresParaItemDePedido(CadastrarObraEComposicaoPage.Autor);
            TelaPedidoPage.ValidarNovosValoresParaItemDePedido(CadastrarObraEComposicaoPage.Autor2);
        }

        //Alterar os Autores da composição de uma obra com pedido pendente
        [When(@"altero todos os autores da composicao ""(.*)"", ""(.*)""")]
        public void QuandoAlteroTodosOsAutoresDaComposicao(string Autor1, string Autor2)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor1);
            TelaCadastrarObraEComposicaoPage.EditarComposicao(Autor1, "", "", "1");
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }

        [Then(@"visualizo que os itens anteriores foram cancelados na tela de pagamento e gerados novos itens para os novos compositores ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOsItensAnterioresForamCanceladosNaTelaDePagamentoEGeradosNovosItensParaOsNovosCompositores(string Autor1, string Autor2, string StatusItem)
        {
            TelaPedidoPage.AcessarAbaPagamentoNaTelaDeBusca();
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusItem, Autor1);
            TelaPedidoPage.ValidarCompositorAntigoCancelado(Autor1);
        }

        //Excluir Obra tendo pedido pendente
        [When(@"excluo a obra associada a esse pedido ""(.*)""")]
        public void QuandoExcluoAObraAssociadaAEssePedido(string Obra)
        {
            TelaExcluirObraPage.ExcluirObraRandomica(Obra);
        }

        [Then(@"visualizo que o pedido e seus itens estão cancelados na tela de busca por pedido ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOPedidoESeusItensEstaoCanceladosNaTelaDeBuscaPorPedido(string Autor1, string Autor2, string StatusItem)
        {
            TelaPedidoPage.AcessarAbaPagamentoNaTelaDeBusca();
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusItem, Autor1);
            TelaPedidoPage.ValidarStatusPagamentoNaTelaDeBusca(StatusItem, Autor2);
        }

    }
}
