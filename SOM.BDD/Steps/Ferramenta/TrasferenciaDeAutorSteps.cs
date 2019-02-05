using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta
{
    [Binding]
    public sealed class TrasferenciaDeAutorSteps
    {
        public TransferenciaDeAutorPage TelaTransferenciaDeAutorPage { get; private set; }
        public CadastrarAutorPage TelaCadastro { get; set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }

        public TrasferenciaDeAutorSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaTransferenciaDeAutorPage = new TransferenciaDeAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["TransferenciadeAutorUrl"]);
            TelaCadastro = new CadastrarAutorPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroAutorUrl"]);

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                 ConfigurationManager.AppSettings["CadastroObraUrl"]);
        }

        [Given(@"a tela transferencia de autor \(De/Para\) esteja aberta")]
        public void DadoATelaTransferenciaDeAutorDeParaEstejaAberta()
        {
            TelaTransferenciaDeAutorPage.Navegar();
        }

        [When(@"realizo uma Transferência preenchendo os campos ""(.*)"" e ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaPreenchendoOsCamposE(string De, string Para)
        {
            TelaTransferenciaDeAutorPage.TranferenciaDeParaAutor(De, Para);
        }

        [Then(@"visualizo a mensagem de confirmação de transferência ""(.*)""")]
        public void EntaoVisualizoAMensagemDeConfirmacaoDeTransferencia(string MensagemDeAlteração)
        {
            TelaTransferenciaDeAutorPage.ConfirmarDePara();
            TelaTransferenciaDeAutorPage.ValidarDadosAlterados(MensagemDeAlteração);
            TelaTransferenciaDeAutorPage.TranferenciaDeParaAutor("NOVO SOM", "Teste Autor Teste");
            TelaTransferenciaDeAutorPage.ValidarDadosAlterados(MensagemDeAlteração);
            TelaTransferenciaDeAutorPage.ConfirmarDePara();
        }

        [Then(@"visualizo os campos NomeAutorDE e NomeAutorPara em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposNomeAutorDEENomeAutorParaEmDestaqueParaPreenchimento()
        {
            TelaTransferenciaDeAutorPage.SalvarAlteração();
            TelaTransferenciaDeAutorPage.ValidarCamposDEPARAAutor();
        }

        [Then(@"visualizo o campo NomeAutorDe em destaque para preenchimento\.")]
        public void EntaoVisualizoOCampoNomeAutorDeEmDestaqueParaPreenchimento_()
        {
            TelaTransferenciaDeAutorPage.SalvarAlteração();
            TelaTransferenciaDeAutorPage.ValidarCamposDEAutor();
        }

        [Then(@"visualizo o campo NomeAutorPara em destaque para preenchimento\.")]
        public void EntaoVisualizoOCampoNomeAutorParaEmDestaqueParaPreenchimento_()
        {
            TelaTransferenciaDeAutorPage.SalvarAlteração();
            TelaTransferenciaDeAutorPage.ValidarCamposPARAAutor();
        }

        [Then(@"visualizo a mensagem que o Autor não possui obras ""(.*)""")]
        public void EntaoVisualizoAMensagemQueOAutorNaoPossuiObras(string Mensagem)
        {
            TelaTransferenciaDeAutorPage.SalvarAlteração();
            TelaTransferenciaDeAutorPage.MensagemAutorDeValidação(Mensagem);
        }

        [When(@"visualizo a mensagem de Autor DePara não permitido ""(.*)""")]
        public void QuandoVisualizoAMensagemDeAutorDeParaNaoPermitido(string Mensagem)
        {
            TelaTransferenciaDeAutorPage.SalvarAlteração();
            TelaTransferenciaDeAutorPage.MensagemAutorDeValidação(Mensagem);
        }

        [When(@"realizo uma Transferência de autor preenchendo o campos AutorDe e AutorPara ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaDeAutorPreenchendoOCamposAutorDeEAutorPara(string Para)
        {
            TelaCadastro.Navegar();
            TelaCadastrarObraEComposicaoPage.GerarAutorRandomico();
            TelaCadastrarObraEComposicaoPage.PreencherAutorRandomico(CadastrarObraEComposicaoPage.Autor);
            TelaCadastro.BotaoSalvar();
            TelaTransferenciaDeAutorPage.Navegar();
            TelaTransferenciaDeAutorPage.TranferenciaDeParaAutor(CadastrarObraEComposicaoPage.Autor, Para);
        }


        [When(@"seleciono o checkbox de excluir AutorDe")]
        public void QuandoSelecionoOCheckboxDeExcluirAutorDe()
        {
            TelaTransferenciaDeAutorPage.ConfirmarExclusãoAutorDe();
            TelaTransferenciaDeAutorPage.SalvarAlteração();
            TelaTransferenciaDeAutorPage.ValidarExclusãoAutorDePara();
        }

        [Then(@"visualizo a mensagem de confirmação da exclusão do autor ""(.*)""")]
        public void EntaoVisualizoAMensagemDeConfirmacaoDaExclusaoDoAutor(string MensagemDeAlteração)
        {
            TelaTransferenciaDeAutorPage.ValidarDadosAlterados(MensagemDeAlteração);
        }


    }
}