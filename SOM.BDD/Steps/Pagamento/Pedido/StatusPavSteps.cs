using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido
{
    [Binding]
    public sealed class StatusPavSteps
    {
        public PedidoPage TelaPedidoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public AlterarItemPedidoPage TelaAlterarItemPedidoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public AlterarItemPedidoSteps AlterarItemPedidoSteps { get; private set; }

        public StatusPavSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaPedidoPage = new PedidoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDePedidoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaAlterarItemPedidoPage = new AlterarItemPedidoPage((IBrowser)browser);
            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);
            AlterarItemPedidoSteps = new AlterarItemPedidoSteps();
        }

        [Given(@"que tenha um pedido com Status Pav Aprovado ""(.*)""")]
        public void DadoQueTenhaUmPedidoComStatusPavAprovado(string Pedido)
        {
            TelaPedidoPage.Navegar();
            TelaPedidoPage.BuscaSimplesDePedido(Pedido);
            TelaPedidoPage.AbrirPedido(Pedido);
            TelaPedidoPage.TrocarAbaBrowser();
            TelaPedidoPage.ValidarStatusPav("Aprovado");
        }

        [When(@"altero a nacionalidade da obra ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroANacionalidadeDaObra(string Nacionalidade, string Pais, string Obra)
        {
            TelaCadastrarObraEComposicaoPage.TrocarNacionalidade(Nacionalidade);
        }

        [When(@"seleciono o pedido a ser afetado pela alteracao ""(.*)""")]
        public void QuandoSelecionoOPedidoASerAfetadoPelaAlteracao(string Pedido)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(Pedido);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }

        [When(@"faço uma busca pelo pedido afetado ""(.*)""")]
        public void QuandoFacoUmaBuscaPeloPedidoAfetado(string Pedido)
        {
            TelaPedidoPage.Navegar();
            TelaPedidoPage.BuscaSimplesDePedido(Pedido);
            TelaPedidoPage.AbrirPedido(Pedido);
            TelaPedidoPage.TrocarAbaBrowser();
        }
        
        [Then(@"visualizo que o Status Pav do pedido continua como Aprovado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOStatusPavDoPedidoContinuaComoAprovado(string StatusPav, string Nacionalidade, string Pais, string Obra, string Pedido)
        {
            TelaPedidoPage.ValidarStatusPav(StatusPav);
        }

        [When(@"altero os autores da obra ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsAutoresDaObra(string Autor1, string NovoAutor1)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor1);
            TelaCadastrarObraEComposicaoPage.AlterarAutorComposicao(NovoAutor1);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }

        [Then(@"visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do Autor da composição ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOStatusPavDoPedidoContinuaComoAprovadoAposAAlteracaoDoAutorDaComposicao(string Autor1, string NovoAutor1, string StatusPav, string Obra, string Pedido)
        {
            //TelaPedidoPage.ValidarStatusPav(StatusPav);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Obra);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(NovoAutor1);
            TelaCadastrarObraEComposicaoPage.AlterarAutorComposicao(Autor1);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(Pedido);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }
        
        [Then(@"visualizo que o Status Pav do pedido continua como Aprovado apos a alteração da porcentagem dos Autores da composição ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOStatusPavDoPedidoContinuaComoAprovadoAposAAlteracaoDaPorcentagemDosAutoresDaComposicao(string Autor1, string Porcentagem1, string Autor2, string Porcentagem2, string Obra, string Pedido, string StatusPav)
        {
            //TelaPedidoPage.ValidarStatusPav(StatusPav);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Obra);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor2);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Porcentagem1, "");
            TelaCadastrarObraEComposicaoPage.ValidarAutor(Porcentagem1);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor1);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Porcentagem2, "");
            TelaCadastrarObraEComposicaoPage.ValidarAutor(Porcentagem2);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(Pedido);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }

        [When(@"altero os DDAs dos autores da composição ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsDDAsDosAutoresDaComposicao(string Autor, string NovoDDA)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor);
            TelaCadastrarObraEComposicaoPage.AlterarDDDAComposicao(Autor, NovoDDA);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }
        
        [Then(@"visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do DDA do Autor da composição ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOStatusPavDoPedidoContinuaComoAprovadoAposAAlteracaoDoDDADoAutorDaComposicao(string Autor, string DDA, string Obra, string Pedido, string StatusPav)
        {
            //TelaPedidoPage.ValidarStatusPav(StatusPav);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Obra);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor);
            TelaCadastrarObraEComposicaoPage.AlterarDDDAComposicao(Autor, DDA);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(Pedido);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }

        [When(@"diminuo a porcentagem de um Autor ""(.*)"", ""(.*)""")]
        public void QuandoDiminuoAPorcentagemDeUmAutor(string Autor1, string Porcentagem1)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor1);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", Porcentagem1, "");
            TelaCadastrarObraEComposicaoPage.ValidarPercentualCompositor(Porcentagem1);
        }

        [When(@"acrescento um novo Autor a composição com o percentual restante ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAcrescentoUmNovoAutorAComposicaoComOPercentualRestante(string Autor2, string DDA, string Porcentagem2)
        {
            TelaCadastrarObraEComposicaoPage.AdicionarCompositor(Autor2, DDA, Porcentagem2);
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }

        [Then(@"visualizo que o Status Pav do pedido continua como Aprovado apos a adição de mais um compositor na obra ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOStatusPavDoPedidoContinuaComoAprovadoAposAAdicaoDeMaisUmCompositorNaObra(string Autor1, string Autor2, string PorcentagemOriginal, string Obra, string Pedido, string StatusPav)
        {
            //TelaPedidoPage.ValidarStatusPav(StatusPav);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Obra);
            TelaCadastrarObraEComposicaoPage.ExcluirAutorDaComposicao(Autor2);
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor1);
            TelaCadastrarObraEComposicaoPage.EditarComposicao("", "", PorcentagemOriginal, "");
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
            TelaCadastrarObraEComposicaoPage.SelecionarPedidoAfetadoPelaEdicao(Pedido);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlteracaoDeObra("Sim");
            TelaAlterarItemPedidoPage.ValidarPopupSucesso("");
        }
        
        [When(@"altero um dos autores da composição para que esteja com duplicidade ""(.*)""")]
        public void QuandoAlteroUmDosAutoresDaComposicaoParaQueEstejaComDuplicidade(string Autor)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor);
            TelaCadastrarObraEComposicaoPage.CadastrarDuplicidadeParaCompositor();
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }

        [Then(@"visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do compositor para duplicidade ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoQueOStatusPavDoPedidoContinuaComoAprovadoAposAAlteracaoDoCompositorParaDuplicidade(string Autor, string Obra, string StatusPav)
        {
            //TelaPedidoPage.ValidarStatusPav(StatusPav);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Obra);
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao(Autor);
            TelaCadastrarObraEComposicaoPage.CadastrarDuplicidadeParaCompositor();
            TelaCadastrarObraEComposicaoPage.SalvarEdicaoDeObra();
        }

    }
}
