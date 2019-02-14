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
    public sealed class CadastrarCueSheetSteps
    {
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }

        public CadastrarCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarCueSheetPage = new CadastrarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCueSheet"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaGerarPedidosDePagamentoCueSheetPage = new GerarPedidosDePagamentoCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"],
                ConfigurationManager.AppSettings["DetalheDaCueSheetUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
        }

        [Given(@"que esteja na tela de cadastro de Cue-Sheet")]
        public void DadoQueEstejaNaTelaDeCadastroDeCue_Sheet()
        {
            TelaCadastrarCueSheetPage.Navegar();
        }

        //Cadastrar Cue-sheet manual
        [Given(@"que tenha um produto cadastrado no sistema")]
        public void DadoQueTenhaUmProdutoCadastradoNoSistema()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
        }

        [When(@"que cadastro uma nova cue-sheet sem importar um arquivo com os itens da cue-sheet")]
        public void QuandoQueCadastroUmaNovaCue_SheetSemImportarUmArquivoComOsItensDaCue_Sheet()
        {
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheet(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), "01", "11/11/2018", "GLOBONEWS", "");
        }

        [Then(@"visualizo uma mensagem de critica para confirmação junto com uma mensagem de cadastro realizado com sucesso ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeCriticaParaConfirmacaoJuntoComUmaMensagemDeCadastroRealizadoComSucesso(string MensagemCritica, string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarPopupSemImportacao(MensagemCritica, Mensagem);
            TelaCadastrarCueSheetPage.ValidarCueSheetCadastrada(TelaCadastroDeProdutoPage.GetProduto(), "", "", "", "");
        }

        //Validar campo Capítulo obrigatório
        [Given(@"que tenha um produto cadastrado no sistema com capitulo obrigatório")]
        public void DadoQueTenhaUmProdutoCadastradoNoSistemaComCapituloObrigatorio()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
        }

        [When(@"tento cadastrar uma cue-sheet sem informar o capitulo")]
        public void QuandoTentoCadastrarUmaCue_SheetSemInformarOCapitulo()
        {
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheet(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), "", "11/11/2018", "GLOBONEWS", "");
        }

        [Then(@"visualizo o campo Capitulo em destaque para o preenchimento obrigatorio")]
        public void EntaoVisualizoOCampoCapituloEmDestaqueParaOPreenchimentoObrigatorio()
        {
            TelaCadastrarCueSheetPage.ValidarCapituloObrigatorio();
        }

        //Validar duplicidade de nova Cue-sheet
        [Given(@"que tenha uma cue-sheet cadastrada no sistema")]
        public void DadoQueTenhaUmaCue_SheetCadastradaNoSistema()
        {
            QuandoQueCadastroUmaNovaCue_SheetSemImportarUmArquivoComOsItensDaCue_Sheet();
            EntaoVisualizoUmaMensagemDeCriticaParaConfirmacaoJuntoComUmaMensagemDeCadastroRealizadoComSucesso("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", "Cue-sheet cadastrada com sucesso ");
        }

        [When(@"tento cadastrar uma nova cue-sheet com os mesmos dados da cue-sheet existente")]
        public void QuandoTentoCadastrarUmaNovaCue_SheetComOsMesmosDadosDaCue_SheetExistente()
        {
            QuandoQueCadastroUmaNovaCue_SheetSemImportarUmArquivoComOsItensDaCue_Sheet();
        }

        [Then(@"visualizo uma mensagem de critica informando que já existe uma cue-sheet cadastrada para essa midia e data ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeCriticaInformandoQueJaExisteUmaCue_SheetCadastradaParaEssaMidiaEData(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarPopUpsDeCriticaDaCueSheet("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", Mensagem);
        }

        //Validar critica para criacao de cue-sheet como reprise/rebatida
        [When(@"tento cadastrar uma nova cue-sheet ""(.*)""")]
        public void QuandoTentoCadastrarUmaNovaCue_Sheet(string RepriseRebatida)
        {
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheet(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), "", "11/11/2018", "GLOBONEWS", RepriseRebatida);
        }

        [Then(@"visualizo uma mensagem de critica informando que o capitulo não está cadastrado como inedito ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeCriticaInformandoQueOCapituloNaoEstaCadastradoComoInedito(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarPopUpsDeCriticaDaCueSheet("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", Mensagem);
        }

        //Cancelar criação de cue-sheet sem arquivo de importação 
        [When(@"tento cadastrar uma nova cue-sheet sem importar um arquivo com os itens da cue-sheet")]
        public void QuandoTentoCadastrarUmaNovaCue_SheetSemImportarUmArquivoComOsItensDaCue_Sheet()
        {
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheet(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), "", "11/11/2018", "GLOBONEWS", "");
        }

        [Then(@"visualizo o campo de importar arquivo em destaque ao não criar a cue-sheet sem fazer a importação")]
        public void EntaoVisualizoOCampoDeImportarArquivoEmDestaqueAoNaoCriarACue_SheetSemFazerAImportacao()
        {
            TelaCadastrarCueSheetPage.ValidarArquivoDeImportacaoObrigatorio();
        }

        //Cadastrar itens por importação de arquivo com extensões ".TXT" e ".EDL" na tela Cadastro de Cue-Sheet
        [When(@"faço upload de um arquivo com uma lista de itens para Cue-Sheet ""(.*)""")]
        public void QuandoFacoUploadDeUmArquivoComUmaListaDeItensParaCue_Sheet(string Extensao)
        {
            TelaCadastrarCueSheetPage.RealizarUploadDeArquivo(Extensao);
        }

        [Then(@"visualizo um dos itens da lista cadastrado na Cue-Sheet com sucesso ""(.*)""")]
        public void EntaoVisualizoUmDosItensDaListaCadastradoNaCue_SheetComSucesso(string ItemDaCueSheet)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemDeCueSheet(ItemDaCueSheet);
        }

        [When(@"cadastro um item na Cue-Sheet")]
        public void QuandoCadastroUmItemNaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheetSemFonograma(CadastrarObraEComposicaoPage.Obra, "BK – BACKGROUND", "ABERTURA", "12", "ANITTA", CadastrarObraEComposicaoPage.Autor);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, "12", "BK – BACKGROUND", "ABERTURA", "Não");
        }

        [Then(@"visualizo o item da Cue-Sheet cadastrado na grid com sucesso")]
        public void EntaoVisualizoOItemDaCue_SheetCadastradoNaGridComSucesso()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
        }

        //Validar extensão do arquivo de importação diferente de .EDL ou .TXT
        [When(@"tento cadastrar uma Cue-Sheet importando um arquivo com extensão diferente de EDL e TXT ""(.*)""")]
        public void QuandoTentoCadastrarUmaCue_SheetImportandoUmArquivoComExtensaoDiferenteDeEDLETXT(string ListaDeItensDaCueSheet)
        {
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheetComImportacaoDeArquivo(CadastroDeProdutoPage.Produto, CadastroDeProdutoPage.Episodio, 
                "01", "11/11/2018", "GLOBONEWS", "", ListaDeItensDaCueSheet);
        }

        [Then(@"visualizo uma mensagem informando que o arquivo é inválido ""(.*)""")]
        public void EntaoVisualizoUmaMensagemInformandoQueOArquivoEInvalido(string Mensagem)
        {
            TelaCadastrarCueSheetPage.ValidarAlerta(Mensagem);
        }

        [When(@"cadastro uma Cue-Sheet importando uma lista de itens ""(.*)""")]
        public void QuandoCadastroUmaCue_SheetImportandoUmaListaDeItens(string ListaDeItensDaCueSheet)
        {
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheetComImportacaoDeArquivo(CadastroDeProdutoPage.Produto, CadastroDeProdutoPage.Episodio,
                "01", "11/11/2018", "GLOBONEWS", "", ListaDeItensDaCueSheet);
        }

        //Cancelar cadastro de item na cue-sheet
        [When(@"cancelo o cadastro de um item de Cue-Sheet")]
        public void QuandoCanceloOCadastroDeUmItemDeCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CancelarCadastroDeItemCueSheet(CadastrarObraEComposicaoPage.Obra, 
                "BK – BACKGROUND", "ABERTURA", "12");
        }

        [Then(@"visualizo que o total de itens na Cue-Sheet continua como zero")]
        public void EntaoVisualizoQueOTotalDeItensNaCue_SheetContinuaComoZero()
        {
            TelaCadastrarCueSheetPage.ValidarTotalDeItens(" 0");
        }

        //Cue-sheet de uma reprise para gênero Jornalismo
        [Given(@"que tenha um produto cadastrado no sistema ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmProdutoCadastradoNoSistema(string GeneroOriginal, string DireitosMusicais)
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto(GeneroOriginal, DireitosMusicais,
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapitulo("01");
            Thread.Sleep(2000);
        }

        [When(@"altero o item para Fair Use")]
        public void QuandoAlteroOItemParaFairUse()
        {
            TelaCadastrarCueSheetPage.AbrirItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheetParaFairUse();
        }

        [Then(@"visualizo apenas o botão de Reiniciar Cue-Sheet")]
        public void EntaoVisualizoApenasOBotaoDeReiniciarCue_Sheet()
        {
            TelaCadastrarCueSheetPage.ValidarBotaoReiniciarCueSheet();
        }

        //Validar campos obrigatórios em branco
        [When(@"tento cadastrar um item de Cue-Sheet deixando os campos obrigatórios em branco")]
        public void QuandoTentoCadastrarUmItemDeCue_SheetDeixandoOsCamposObrigatoriosEmBranco()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet("", "", "", "");
        }

        [Then(@"visualizo os campos obrigatórios para o cadastro de um item de Cue-Sheet em destaque")]
        public void EntaoVisualizoOsCamposObrigatoriosParaOCadastroDeUmItemDeCue_SheetEmDestaque()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarCampoEmBranco("Título");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarCampoEmBranco("Tempo");
        }

    }
}
