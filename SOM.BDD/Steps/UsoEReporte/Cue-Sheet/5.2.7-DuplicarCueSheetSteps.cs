using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.UsoEReporte.Cue_Sheet;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.UsoEReporte.Cue_Sheet
{
    [Binding]
    public sealed class DuplicarCueSheetSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }

        public DuplicarCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCueSheetPage = new CadastrarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCueSheet"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaGerarPedidosDePagamentoCueSheetPage = new GerarPedidosDePagamentoCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"],
                ConfigurationManager.AppSettings["DetalheDaCueSheetUrl"]);
        }
        
        [Given(@"que tenha uma Cue-Sheet cadastrada no sistema ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmaCue_SheetCadastradaNoSistema(string Produto, string Episodio, string Capitulo, string Midia, string Dia, string Mes, string Ano, string RepriseRebatida)
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", Midia, "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo(Capitulo);
            Thread.Sleep(2000);
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheetRandomica(Produto, Episodio, Capitulo, Dia + "/" + Mes + "/" + Ano, Midia, "");
            TelaCadastrarCueSheetPage.ValidarPopupSemImportacao("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", "Cue-sheet cadastrada com sucesso ");
            TelaCadastrarCueSheetPage.ValidarCueSheetRandomicaCadastrada(Produto, "", Episodio, Capitulo, "");
        }
        
        [Given(@"que tenha um item cadastrado na Cue-Sheet ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmItemCadastradoNaCue_Sheet(string Obra, string Utilizacao, string Sincronismo, string Tempo, string Interprete)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadasTrarItemCueSheetRandomico(Obra, Utilizacao, Sincronismo, Tempo, "");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemCueSheetRandomicoCadastrado(Obra, Tempo, Utilizacao, Sincronismo, "Não");
        }

        [When(@"duplicar a Cue-Sheet")]
        public void QuandoDuplicarACue_Sheet()
        {
            TelaCadastrarCueSheetPage.ClicarDuplicarCueSheet();
        }

        [Then(@"visualizo os campo de nome do produto e episodio bloqueados para edição")]
        public void EntaoVisualizoOsCampoDeNomeDoProdutoEEpisodioBloqueadosParaEdicao()
        {
            TelaCadastrarCueSheetPage.ValidarCamposBloqueadosParaDuplicarCueSheet();
        }

        [Then(@"visualizo os campos preenchidos com os dados da Cue-Sheet a ser duplicada ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsCamposPreenchidosComOsDadosDaCue_SheetASerDuplicada(string Produto, string Episodio, string Capitulo, string Midia,
            string Dia, string Mes, string Ano, string RepriseRebatida)
        {
            TelaCadastrarCueSheetPage.ValidarValoresDaCueSheetADuplicarRandomica(Produto, Episodio, Capitulo, Midia, Dia, Mes, Ano, RepriseRebatida);
        }

        [When(@"duplicar a Cue-Sheet como Rebatida")]
        public void QuandoDuplicarACue_SheetComoRebatida()
        {
            TelaCadastrarCueSheetPage.DuplicarCueSheet("Rebatida");
        }

        [Then(@"visualizo a tela de detalhe da cue-sheet duplicada como Rebatida com sucesso ""(.*)""")]
        public void EntaoVisualizoATelaDeDetalheDaCue_SheetDuplicadaComoRebatidaComSucesso(string RepriseRebatida)
        {
            TelaCadastrarCueSheetPage.ValidarRepriseRebatida(RepriseRebatida);
        }

        [When(@"duplicar a Cue-Sheet sem alterar nenhuma informação")]
        public void QuandoDuplicarACue_SheetSemAlterarNenhumaInformacao()
        {
            TelaCadastrarCueSheetPage.DuplicarCueSheet("");
        }

        [Then(@"visualizo uma mensagem de alerta informando que já existe Cue-Sheet cadastrada com esse dados ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeAlertaInformandoQueJaExisteCue_SheetCadastradaComEsseDados(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarAlerta(Mensagem);
        }

        [When(@"duplicar a Cue-Sheet como Reprise")]
        public void QuandoDuplicarACue_SheetComoReprise()
        {
            TelaCadastrarCueSheetPage.DuplicarCueSheet("Reprise");
        }

    }
}
