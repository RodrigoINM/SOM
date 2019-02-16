using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Pagamento.Pedido___Cue_Sheet;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.UsoEReporte.Cue_Sheet;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Pagamento.Pedido___Cue_Sheet
{
    [Binding]
    public sealed class GerarPedidosDePagamentoCueSheetSteps
    {
        public GerarPedidosDePagamentoCueSheetPage TelaGerarPedidosDePagamentoCueSheetPage { get; private set; }
        public ConsultarCueSheetPage TelaConsultarCueSheetPage { get; private set; }
        public CadastrarCueSheetPage TelaCadastrarCueSheetPage { get; private set; }
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }

        public GerarPedidosDePagamentoCueSheetSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaGerarPedidosDePagamentoCueSheetPage = new GerarPedidosDePagamentoCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"],
                ConfigurationManager.AppSettings["DetalheDaCueSheetUrl"]);
            TelaConsultarCueSheetPage = new ConsultarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaDeCueSheetUrl"]);
            TelaCadastrarCueSheetPage = new CadastrarCueSheetPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroDeCueSheet"]);
            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
        }


        [Given(@"que tenha uma cue-sheet previamente cadastrada")]
        public void DadoQueTenhaUmaCue_SheetPreviamenteCadastrada()
        {
            TelaConsultarCueSheetPage.Navegar();
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet("TESTE ESPORTE OU JORNALISMO", "TESTE", "1", "", "12/11/2018", "", "", "");
            TelaConsultarCueSheetPage.SelecionarCueSheet("TESTE ESPORTE OU JORNALISMO");
        }

        //Inclusão de novo item - Pedido já existente para a mesma obra e sincronismo (Exceto Abertura e Tema)
        [Given(@"que já existe pedido com os mesmos dados da cue-sheet ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueJaExistePedidoComOsMesmosDadosDaCue_Sheet(string Titulo, string Utilizacao, string Sincronismo, string Tempo)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheetSemFonograma(CadastrarObraEComposicaoPage.Obra, Utilizacao, Sincronismo, Tempo, "ANITTA", CadastrarObraEComposicaoPage.Autor);
            //TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(CadastrarObraEComposicaoPage.Obra, Utilizacao, Sincronismo, Tempo);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, Tempo, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", Tempo, "Sim");
        }

        [Given(@"incluo uma nova linha para um mesmo ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoIncluoUmaNovaLinhaParaUmMesmo(string Titulo, string Utilizacao, string Sincronismo, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(CadastrarObraEComposicaoPage.Obra, Utilizacao, Sincronismo, Tempo2);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(CadastrarObraEComposicaoPage.Obra, Tempo2, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Tempo2);
        }

        [When(@"confirmo a geração de pedido para ""(.*)"" e ""(.*)""")]
        public void QuandoConfirmoAGeracaoDePedidoParaE(string Titulo, string Sincronismo)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", CadastrarObraEComposicaoPage.Obra, "Sim");
        }

        [Then(@"visualizo o icone de pedido no item de cue-sheet com o pedido existente associado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOIconeDePedidoNoItemDeCue_SheetComOPedidoExistenteAssociado(string Titulo, string Utilizacao, string Sincronismo, string TempoSomado, string Tempo1, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", CadastrarObraEComposicaoPage.Obra, "Sim");
            TelaGerarPedidosDePagamentoCueSheetPage.NavegarTelaDePedidoCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoNaTelaDePedido(CadastrarObraEComposicaoPage.Obra, TempoSomado, "", Utilizacao, Sincronismo, "");
            TelaGerarPedidosDePagamentoCueSheetPage.VoltarParaListaCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo1);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo2);
        }

        //Alteração de sincronismo - Pedido já existente para a mesma obra e sincronismo
        [Given(@"que eu tenha dois pedidos gerados para itens de cue-sheet com sincronismos diferentes ""(.*)"" E ""(.*)""")]
        public void DadoQueEuTenhaDoisPedidosGeradosParaItensDeCue_SheetComSincronismosDiferentesE(string Sincronismo1, string Sincronismo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet("MUSICA DA MARCELLE", "BK – BACKGROUND", Sincronismo1, "16");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado("MUSICA DA MARCELLE", "16", "BK – BACKGROUND", Sincronismo1, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet("MUSICA DA MARCELLE", "BK – BACKGROUND", Sincronismo2, "25");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado("MUSICA DA MARCELLE", "25", "BK – BACKGROUND", Sincronismo2, "Não");

            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Sincronismo1);
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Sincronismo2);

            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("", "", "Sim");
        }

        [When(@"altero o ""(.*)"" para o mesmo de ""(.*)""")]
        public void QuandoAlteroOParaOMesmoDe(string Sincronismo2, string Sincronismo1)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemAAlterar(Sincronismo2);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheet("", "", Sincronismo1, "");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet("25");
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("", "", "Sim");
        }

        [Then(@"visualizo o icone de pedido no item de cue-sheet com o pedido existente selecionado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOIconeDePedidoNoItemDeCue_SheetComOPedidoExistenteSelecionado(string Titulo, string Sincronismo, string TempoSomado, 
            string Tempo1, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.NavegarTelaDePedidoCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoNaTelaDePedido(Titulo, TempoSomado, "Gravado", "BK – BACKGROUND", Sincronismo, "Sim");
            TelaGerarPedidosDePagamentoCueSheetPage.VoltarParaListaCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo1);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo2);
        }

        //Alteração de obra - Pedido já existente para a mesma obra e sincronismo
        [Given(@"que eu tenha dois pedidos gerados para itens de cue-sheet com obras diferentes ""(.*)"" e ""(.*)""")]
        public void DadoQueEuTenhaDoisPedidosGeradosParaItensDeCue_SheetComObrasDiferentesE(string Titulo1, string Titulo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo1, "BK – BACKGROUND", "ADORNO", "16");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo1, "16", "BK – BACKGROUND", "ADORNO", "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo2, "BK – BACKGROUND", "ADORNO", "25");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo2, "25", "BK – BACKGROUND", "ADORNO", "Não");

            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Titulo1);
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Titulo2);

            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", Titulo1, "Sim");
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("", Titulo2, "Sim");
        }

        [When(@"altero a titulo da obra ""(.*)"" para o mesmo da obra ""(.*)""")]
        public void QuandoAlteroATituloDaObraParaOMesmoDaObra(string Titulo2, string Titulo1)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemAAlterar(Titulo2);
            TelaGerarPedidosDePagamentoCueSheetPage.AlterarItemDeCueSheet(Titulo1, "", "", "");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet("25");
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", Titulo1, "Sim");
        }

        [Then(@"visualizo o icone de pedido no item de cue-sheet com o pedido existente associado para ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOIconeDePedidoNoItemDeCue_SheetComOPedidoExistenteAssociadoPara(string Titulo, string Sincronismo, string TempoSomado,
            string Tempo1, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.NavegarTelaDePedidoCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoNaTelaDePedido(Titulo, TempoSomado, "Gravado", "BK – BACKGROUND", Sincronismo, "");
            TelaGerarPedidosDePagamentoCueSheetPage.VoltarParaListaCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo1);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo2);
        }

        //Não marcar para gerar pedido linhas de ABERTURA ou TEMA
        [Given(@"que possuo itens de sincronismo ABERTURA\. ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQuePossuoItensDeSincronismoABERTURA_(string Titulo, string Utilizacao, string Sincronismo, string Tempo)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo, Utilizacao, Sincronismo, Tempo);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo, Tempo, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Titulo);
        }

        [Given(@"possuo itens de sincronismo TEMA\. ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoPossuoItensDeSincronismoTEMA_(string Titulo, string Utilizacao, string Sincronismo2, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo, Utilizacao, Sincronismo2, Tempo2);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo, Tempo2, Utilizacao, Sincronismo2, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Sincronismo2);
        }

        [When(@"acesso a tela de Gerar Pedido")]
        public void QuandoAcessoATelaDeGerarPedido()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.NavegarTelaDegeracaoDePedidos();
        }
        
        [Then(@"não visualizo os itens de ABERTURA ""(.*)"" ou TEMA ""(.*)"" selecionados\. ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoNaoVisualizoOsItensDeABERTURAOuTEMASelecionados_(string Sincronismo, string Sincronismo2, string Titulo, string Tempo, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoNaTelaDePedido(Titulo, Tempo, "", "", Sincronismo, "");
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoNaTelaDePedido(Titulo, Tempo, "", "", Sincronismo2, "");
            TelaGerarPedidosDePagamentoCueSheetPage.VoltarParaListaCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo2);
        }

        //Novo item ABERTURA ou TEMA válido em Variedades ou Jornalismo ou Esporte com pedido existente
        [Given(@"que tenha uma cue-sheet do genero jornalismo previamente cadastrada")]
        public void DadoQueTenhaUmaCue_SheetDoGeneroJornalismoPreviamenteCadastrada()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Jornalismo", "JORNALISMO",
                "290407", "Sim", "GLOBONEWS", "7001", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapituloProduto();
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "1");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("50", "2");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();

            //TelaCadastroDeProdutoPage.Navegar();
            //TelaCadastroDeProdutoPage.CadastroDeProduto("Jornalismo", "JORNALISMO",
            //    "4135", "Sim", "SPORTV", "Atividade", "Não", "Não");
            //TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            //Thread.Sleep(2000);
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheet(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), "01", "11/11/2018", "GLOBONEWS", "");
            TelaCadastrarCueSheetPage.ValidarPopupSemImportacao("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", "Cue-sheet cadastrada com sucesso ");
            TelaCadastrarCueSheetPage.ValidarCueSheetCadastrada(TelaCadastroDeProdutoPage.GetProduto(), "", "", "", "");
        }

        [Given(@"que tenha uma cue-sheet do genero jornalismo previamente cadastrada com data de exibição dentro do período de (.*) meses")]
        public void DadoQueTenhaUmaCue_SheetDoGeneroJornalismoPreviamenteCadastradaComDataDeExibicaoDentroDoPeriodoDeMeses(int p0)
        {
            TelaConsultarCueSheetPage.Navegar();
            TelaConsultarCueSheetPage.ConsultaAvacadaDeCueSheet("JORNAL NACIONAL", "", "", "GLOBONEWS", "14/11/2018", "", "", "");
            TelaConsultarCueSheetPage.SelecionarCueSheet("JORNAL NACIONAL");
        }

        [Given(@"que existe um pedido de ABERTURA ou TEMA para ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueExisteUmPedidoDeABERTURAOuTEMAPara(string Titulo, string Utilizacao, string Sincronismo, string Tempo)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo, Utilizacao, Sincronismo, Tempo);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo, Tempo, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Titulo);
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", Titulo, "Sim");
        }

        [Given(@"que eu tenha criado um item novo item\. ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueEuTenhaCriadoUmItemNovoItem_(string Titulo, string Utilizacao, string Sincronismo, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheet(Titulo, Utilizacao, Sincronismo, Tempo2);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo, Tempo2, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Tempo2);
        }

        [Then(@"visualizo uma observação informando que existe pedido válido")]
        public void EntaoVisualizoUmaObservacaoInformandoQueExistePedidoValido()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarIconObservacao();
        }

        [Then(@"visualizo o ícone para o pedido que será associado após a geração")]
        public void EntaoVisualizoOIconeParaOPedidoQueSeraAssociadoAposAGeracao()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarIconPedido();
        }

        [When(@"seleciono o item e confirmo a geração do pedido ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoSelecionoOItemEConfirmoAGeracaoDoPedido(string Titulo, string Utilizacao, string Sincronismo, string TempoSomado)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.VoltarParaListaCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", TempoSomado, "Sim");
        }

        [Then(@"visualizo o pedido existente associado ao item de cue-sheet ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOPedidoExistenteAssociadoAoItemDeCue_Sheet(string Titulo, string Utilizacao, string Sincronismo, string TempoSomado,
            string Tempo1, string Tempo2)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.NavegarTelaDegeracaoDePedidos();
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoNaTelaDePedido(Titulo, TempoSomado, "", Utilizacao, Sincronismo, "");
            TelaGerarPedidosDePagamentoCueSheetPage.VoltarParaListaCueSheet();
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo1);
            TelaGerarPedidosDePagamentoCueSheetPage.ExcluirItemCueSheet(Tempo2);
        }

        [Given(@"que tenha uma cue-sheet do genero Dramaturgia previamente cadastrada")]
        public void DadoQueTenhaUmaCue_SheetDoGeneroDramaturgiaPreviamenteCadastrada()
        {
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            TelaCadastroDeProdutoPage.CadastrarCapituloProduto();
            Thread.Sleep(2000);
            TelaCadastrarCueSheetPage.Navegar();
            TelaCadastrarCueSheetPage.CadastrarCueSheet(TelaCadastroDeProdutoPage.GetProduto(), TelaCadastroDeProdutoPage.GetEpisodio(), "01", "11/11/2018", "GLOBONEWS", "");
            TelaCadastrarCueSheetPage.ValidarPopupSemImportacao("Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?", "Cue-sheet cadastrada com sucesso ");
            TelaCadastrarCueSheetPage.ValidarCueSheetCadastrada(TelaCadastroDeProdutoPage.GetProduto(), "", "", "", "");
        }

        //Alterar itens da obra com pedido em andamento
        [When(@"altero os percentuais dos itens de composição de uma obra com pedido em andamento ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOsPercentuaisDosItensDeComposicaoDeUmaObraComPedidoEmAndamento(string Titulo, string Utilizacao, string Sincronismo, string Tempo, string Interprete, string LinkCueSheet, string AutorDDA)
        {
            TelaGerarPedidosDePagamentoCueSheetPage.NavegarPara(LinkCueSheet);
            TelaGerarPedidosDePagamentoCueSheetPage.CadastrarItemCueSheetSemFonograma(Titulo, Utilizacao, Sincronismo, Tempo, Interprete, AutorDDA);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoCadastrado(Titulo, Tempo, Utilizacao, Sincronismo, "Não");
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(Titulo);
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", Titulo, "Sim");
        }

        [Then(@"visualizo que os itens alterados foram cancelados no pedido")]
        public void EntaoVisualizoQueOsItensAlteradosForamCanceladosNoPedido()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"foram gerados novos itens com os valores recalculados no pedido")]
        public void EntaoForamGeradosNovosItensComOsValoresRecalculadosNoPedido()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"visualizo apenas o icone para aprovar o item cadastrado")]
        public void EntaoVisualizoApenasOIconeParaAprovarOItemCadastrado()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.SelecionarItemDaCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarIconeDeAprovarItemDeCueSheet();
        }

        [When(@"eu aprovo e crio um pedido para o item da Cue-Sheet")]
        public void QuandoEuAprovoECrioUmPedidoParaOItemDaCue_Sheet()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.AprovarItemDeCueSheet(CadastrarObraEComposicaoPage.Obra);
            TelaGerarPedidosDePagamentoCueSheetPage.GerarPedidoParaItemDeCueSheet("Sim", CadastrarObraEComposicaoPage.Obra, "Sim");
        }

        [Then(@"visualizo o pedido cadastrado com sucesso")]
        public void EntaoVisualizoOPedidoCadastradoComSucesso()
        {
            TelaGerarPedidosDePagamentoCueSheetPage.ValidarPedidoGerado(CadastrarObraEComposicaoPage.Obra);
        }

    }
}
