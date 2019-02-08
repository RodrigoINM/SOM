using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Produto.Template;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Template
{
    [Binding]
    public sealed class CadastroDeTemplateSteps
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public CadastroDeTemplatePage TelaCadastroDeTemplatePage { get; private set; }

        public CadastroDeTemplateSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaCadastroDeTemplatePage = new CadastroDeTemplatePage((IBrowser)browser);
        }

        [Given(@"que tenha uma obra cadastrada no sistema")]
        public void DadoQueTenhaUmaObraCadastradaNoSistema()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
        }

        [When(@"cadastro um novo item de template para o produto ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoItemDeTemplateParaOProduto(string Ordem, string Titulo, string Gravadora, string TipoExibicao, string TipoUtilizacao,
            string SincronismoGlobo, string Submix, string Tempo, string Observacao)
        {
            TelaCadastroDeTemplatePage.CadastrarItemTemplate(Ordem, Titulo, "Aleatório", TipoUtilizacao, SincronismoGlobo, Tempo,
                Gravadora, Submix, Observacao);
            TelaCadastroDeTemplatePage.ValidarObraDeTemplate(Titulo);
        }

        [Then(@"visualizo os dados do item de template cadastrados com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOsDadosDoItemDeTemplateCadastradosComSucesso(string Ordem, string Titulo, string Gravadora, string TipoExibicao, string TipoUtilizacao,
            string SincronismoGlobo, string Tempo, string Observacao)
        {
            TelaCadastroDeTemplatePage.ValidarItemTemplate(Ordem);
            TelaCadastroDeTemplatePage.ValidarObraDeTemplate(Titulo);
            TelaCadastroDeTemplatePage.ValidarItemTemplate(TipoExibicao);
            TelaCadastroDeTemplatePage.ValidarItemTemplate(TipoUtilizacao);
            TelaCadastroDeTemplatePage.ValidarItemTemplate(SincronismoGlobo);
            TelaCadastroDeTemplatePage.ValidarItemTemplate(Tempo);
        }

        [When(@"cadastro um novo item de template para o produto sem preencher os campos obrigatorios")]
        public void QuandoCadastroUmNovoItemDeTemplateParaOProdutoSemPreencherOsCamposObrigatorios()
        {
            TelaCadastroDeTemplatePage.CadastrarItemDeTemplateEmBranco();
        }

        [Then(@"visualizo os campos obrigatorios de cadastros de item de template em destaque")]
        public void EntaoVisualizoOsCamposObrigatoriosDeCadastrosDeItemDeTemplateEmDestaque()
        {
            TelaCadastroDeTemplatePage.ValidarCamposObrigatoriosEmDestaque("Título");
            TelaCadastroDeTemplatePage.ValidarCamposObrigatoriosEmDestaque("Tipo de Utilizacao");
            TelaCadastroDeTemplatePage.ValidarCamposObrigatoriosEmDestaque("Intérprete");
            TelaCadastroDeTemplatePage.ValidarCamposObrigatoriosEmDestaque("Tempo (segundos)");
            TelaCadastroDeTemplatePage.ValidarCamposObrigatoriosEmDestaque("Sincronismo Globo");
        }

        [When(@"cadastro dois itens de template identicos para o produto ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroDoisItensDeTemplateIdenticosParaOProduto(string Ordem, string Titulo, string Interprete, string Gravadora, 
            string TipoExibicao, string TipoUtilizacao, string SincronismoGlobo, string Submix, string Tempo, string Observacao)
        {
            TelaCadastroDeTemplatePage.CadastrarItemTemplate(Ordem, Titulo, Interprete, TipoUtilizacao, SincronismoGlobo, Tempo,
                Gravadora, Submix, Observacao);
            TelaCadastroDeTemplatePage.ValidarObraDeTemplate(Titulo);
            TelaCadastroDeTemplatePage.CadastrarItemTemplate(Ordem, Titulo, Interprete, TipoUtilizacao, SincronismoGlobo, Tempo,
                Gravadora, Submix, Observacao);
            TelaCadastroDeTemplatePage.ValidarObraDeTemplate(Titulo);
        }

        [When(@"cancelo a criação de um novo item de template")]
        public void QuandoCanceloACriacaoDeUmNovoItemDeTemplate()
        {
            TelaCadastroDeTemplatePage.CancelarCriacaoDeTemplate();
        }

        [Then(@"visualizo a tela do produto sem ter criado um item de template")]
        public void EntaoVisualizoATelaDoProdutoSemTerCriadoUmItemDeTemplate()
        {
            TelaCadastroDeTemplatePage.ValidarCancelamentoDeItemDeTemplate();
        }

        [When(@"adiciono um bloco para o item de template criado ""(.*)""")]
        public void QuandoAdicionoUmBlocoParaOItemDeTemplateCriado(string Bloco)
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.CriarBlocoMateria(Bloco);
        }

        [Then(@"visualizo o bloco criado para o item de template com sucesso ""(.*)""")]
        public void EntaoVisualizoOBlocoCriadoParaOItemDeTemplateComSucesso(string Bloco)
        {
            TelaCadastroDeTemplatePage.ValidarBlocoMateriaCriado(Bloco);
        }

        [When(@"adiciono uma materia para o item de template criado ""(.*)""")]
        public void QuandoAdicionoUmaMateriaParaOItemDeTemplateCriado(string Materia)
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.CriarBlocoMateria(Materia);
        }

        [Then(@"visualizo o bloco e a materia criada para o item de template com sucesso ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoOBlocoEAMateriaCriadaParaOItemDeTemplateComSucesso(string Bloco, string Materia)
        {
            TelaCadastroDeTemplatePage.ValidarBlocoMateriaCriado(Bloco);
            TelaCadastroDeTemplatePage.ValidarBlocoMateriaCriado(Materia);
        }

        [When(@"adiciono um bloco para o segundo item de template criado ""(.*)"", ""(.*)""")]
        public void QuandoAdicionoUmBlocoParaOSegundoItemDeTemplateCriado(string Bloco, string Ordem)
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(Ordem);
            TelaCadastroDeTemplatePage.CriarBlocoMateria(Bloco);
        }

        [When(@"tento adicionar uma nova materia para a materia já criada")]
        public void QuandoTentoAdicionarUmaNovaMateriaParaAMateriaJaCriada()
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.CriarNovaMateria();
        }

        [Then(@"visualizo uma mensagem de erro informando que o item selecionado já possui uma materia e bloco ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeErroInformandoQueOItemSelecionadoJaPossuiUmaMateriaEBloco(string Mensagem)
        {
            TelaCadastroDeTemplatePage.ValidarMensagem(Mensagem);
        }

        [When(@"cadastro um novo item de template para o produto criando um novo interprete na tela de criação do item ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoItemDeTemplateParaOProdutoCriandoUmNovoInterpreteNaTelaDeCriacaoDoItem(string Ordem, string Titulo, string Gravadora, string TipoExibicao, string TipoUtilizacao,
            string SincronismoGlobo, string Submix, string Tempo, string Observacao)
        {
            TelaCadastroDeTemplatePage.CadastrarItemTemplate(Ordem, Titulo, "Aleatório", TipoUtilizacao, SincronismoGlobo, Tempo,
                Gravadora, Submix, Observacao);
        }

        [When(@"cadastro um novo item de template para o produto tentando cadastrar um interprete já existente na tela de criação do item ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoItemDeTemplateParaOProdutoTentandoCadastrarUmInterpreteJaExistenteNaTelaDeCriacaoDoItem(string Ordem, string Titulo, string Interprete, string Gravadora, string TipoExibicao, string TipoUtilizacao,
            string SincronismoGlobo, string Submix, string Tempo, string Observacao)
        {
            TelaCadastroDeTemplatePage.CadastrarTemplateComInterpreteExistente(Ordem, Titulo, Interprete, TipoUtilizacao, SincronismoGlobo, Tempo,
                Gravadora, Submix, Observacao);
        }

        [Then(@"visualizo uma mensagem de erro ao tentar cadastrar um interprete já existente ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeErroAoTentarCadastrarUmInterpreteJaExistente(string Mensagem)
        {
            TelaCadastroDeTemplatePage.ValidarMensagem(Mensagem);
        }

    }
}
