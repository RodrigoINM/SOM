using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Produto;
using SOM.BDD.Pages.Produto.Template;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;


namespace SOM.BDD.Steps.Produto.Template
{
    [Binding]
    public sealed class AlteracaoDeTemplateSteps
    {
        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public CadastroDeTemplatePage TelaCadastroDeTemplatePage { get; private set; }

        public AlteracaoDeTemplateSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastroDeProdutoPage = new CadastroDeProdutoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastrarProdutoUrl"]);
            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaCadastroDeTemplatePage = new CadastroDeTemplatePage((IBrowser)browser);
        }

        [Given(@"que tenha um produto com template cadastrado")]
        public void DadoQueTenhaUmProdutoComTemplateCadastrado()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaCadastroDeProdutoPage.Navegar();
            TelaCadastroDeProdutoPage.CadastroDeProduto("Novela", "DRAMATURGIA SEMANAL",
                "4135", "Sim", "GLOBONEWS", "Atividade", "Não", "Sim");
            TelaCadastroDeProdutoPage.SalvarCadastroDeProduto();
            //TelaCadastroDeProdutoPage.CadastrarCapitulo();
            Thread.Sleep(2000);
            TelaCadastroDeTemplatePage.CadastrarItemTemplate("1", CadastrarObraEComposicaoPage.Obra, "Aleatório", "PE – PERFORMANCE", "ENCERRAMENTO", "12",
                "", "", "");
        }

        [When(@"altero os dados do template ""(.*)""")]
        public void QuandoAlteroOsDadosDoTemplate(string Titulo)
        {
            TelaCadastroDeTemplatePage.AbrirItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.AlterarItemTemplate("", Titulo, "Aleatório", "", "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem de alteração realizada com sucesso no template ""(.*)""")]
        public void EntaoVisualizoAMensagemDeAlteracaoRealizadaComSucessoNoTemplate(string Mensagem)
        {
            TelaCadastroDeTemplatePage.ValidarPopup(Mensagem);
        }

        [When(@"altero o item informando os mesmos dados do item de template previamente cadastrado ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoAlteroOItemInformandoOsMesmosDadosDoItemDeTemplatePreviamenteCadastrado(string Ordem, string Titulo, string Gravadora, string TipoExibicao, string TipoUtilizacao,
            string SincronismoGlobo, string Submix, string Tempo, string Observacao)
        {
            TelaCadastroDeTemplatePage.AbrirItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.AlterarItemTemplate("", Titulo, "Aleatório", TipoUtilizacao, SincronismoGlobo, Tempo,
                Gravadora, Submix, Observacao);
        }

        [Given(@"adiciono um bloco para o item de template criado ""(.*)""")]
        public void DadoAdicionoUmBlocoParaOItemDeTemplateCriado(string Bloco)
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.CriarBlocoMateria(Bloco);
        }

        [When(@"incluo esse item de template no bloco existente ""(.*)""")]
        public void QuandoIncluoEsseItemDeTemplateNoBlocoExistente(string Bloco)
        {
            TelaCadastroDeTemplatePage.IncluirTemplateEmBlocoMateriaExistente("TESTE INMETRICS", CadastrarObraEComposicaoPage.Obra);
        }

        [When(@"cancelo a alteração de um item do template")]
        public void QuandoCanceloAAlteracaoDeUmItemDoTemplate()
        {
            TelaCadastroDeTemplatePage.AbrirItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.CancelarAlteracaoDeTemplate();
        }

        [Then(@"volto a visualizar o item previamente cadastrado sem alteração")]
        public void EntaoVoltoAVisualizarOItemPreviamenteCadastradoSemAlteracao()
        {
            TelaCadastroDeTemplatePage.ValidarObraDeTemplate(CadastrarObraEComposicaoPage.Obra);
        }

    }
}
