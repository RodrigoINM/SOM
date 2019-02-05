using Framework.Core.Interfaces;
using SOM.BDD.Pages.Ferramenta;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Ferramenta
{
    [Binding]
    public class TransferênciadeObraDeParaSteps
    {
        public TransferênciadeObraDeParaPage TelaTransferênciadeObraDeParaPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }

        public TransferênciadeObraDeParaSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaTransferênciadeObraDeParaPage = new TransferênciadeObraDeParaPage((IBrowser)browser,
                ConfigurationManager.AppSettings["TransferenciaObraUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
        }

        [Given(@"a tela transferência de Obra \(De/Para\) esteja aberta")]
        public void DadoATelaTransferenciaDeObraDeParaEstejaAberta()
        {
            TelaTransferênciadeObraDeParaPage.Navegar();
        }

        [When(@"realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObraPara ""(.*)"" , ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaDeObraPreenchendoOsCamposTituloObraDeETituloObraPara(string ObraDe, string ObraPara)
        {
            TelaTransferênciadeObraDeParaPage.TransferenciaAutorVisivel(ObraDe, ObraPara);
            TelaTransferênciadeObraDeParaPage.SalvarTransferencia();
        }

        [When(@"realizo uma Transferência de obraDe preenchendo os campos TituloObraDe e TituloObraPara ""(.*)"" , ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaDeObraDePreenchendoOsCamposTituloObraDeETituloObraPara(string ObraDe, string ObraPara)
        {
            TelaTransferênciadeObraDeParaPage.TransferenciaAutor(ObraDe, ObraPara);
            TelaTransferênciadeObraDeParaPage.SalvarTransferencia();
        }

        [Then(@"visualizo a mensagem de transferencia de obra concluida ""(.*)""")]
        public void EntaoVisualizoAMensagemDeTransferenciaDeObraConcluida(string MensagemDeAlteração)
        {
            TelaTransferênciadeObraDeParaPage.TransferenciaDePara();
            TelaTransferênciadeObraDeParaPage.ValidarDadosAlterados(MensagemDeAlteração);
            TelaTransferênciadeObraDeParaPage.TransferenciaAutorVisivel("NOVO AMANHECER", "AMIANTO");
            TelaTransferênciadeObraDeParaPage.SalvarTransferencia();
            TelaTransferênciadeObraDeParaPage.TransferenciaDePara();
            TelaTransferênciadeObraDeParaPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Then(@"visualizo os campos TituloObraDe e TituloObraPara em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposTituloObraDeETituloObraParaEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeObraDeParaPage.ValidarCampos();
        }

        [Then(@"visualizo os campos TituloObraDe em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposTituloObraDeEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeObraDeParaPage.ValidarCampoObraDe();
        }

        [Then(@"visualizo os campos TituloObraPara em destaque para preenchimento")]
        public void EntaoVisualizoOsCamposTituloObraParaEmDestaqueParaPreenchimento()
        {
            TelaTransferênciadeObraDeParaPage.ValidarCampoObraPara();
        }

        [Given(@"que a tenho uma Obra disponivel para exclusão")]
        public void DadoQueATenhoUmaObraDisponivelParaExclusao()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaTransferênciadeObraDeParaPage.Navegar();
        }

        [When(@"realizo uma Transferência preenchendo os campos TituloObraDe e TituloObraPara (.*) , ""(.*)""")]
        public void QuandoRealizoUmaTransferenciaPreenchendoOsCamposTituloObraDeETituloObraPara(string p0, string ObraPara)
        {
            TelaTransferênciadeObraDeParaPage.TransferenciaAutorVisivel(CadastrarObraEComposicaoPage.Obra, ObraPara);
        }


        [When(@"seleciono a CheckBox de exclusão de ObraDe")]
        public void QuandoSelecionoACheckBoxDeExclusaoDeObraDe()
        {
            TelaTransferênciadeObraDeParaPage.ConfirmarExclusãoObraDe();
        }

        [Then(@"visualizo a mensagem de confirmação de exclusão da ObraDe ""(.*)""")]
        public void EntaoVisualizoAMensagemDeConfirmacaoDeExclusaoDaObraDe(string MensagemDeAlteração)
        {
            TelaTransferênciadeObraDeParaPage.SalvarTransferencia();
            TelaTransferênciadeObraDeParaPage.ConfirmarTransferencia();
            TelaTransferênciadeObraDeParaPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Then(@"visualizo a mensagem de Obra, operação cancelada ""(.*)""")]
        public void EntaoVisualizoAMensagemDeObraOperacaoCancelada(string Mensagem)
        {
            TelaTransferênciadeObraDeParaPage.ValidarAlerta(Mensagem);
        }

    }
}
