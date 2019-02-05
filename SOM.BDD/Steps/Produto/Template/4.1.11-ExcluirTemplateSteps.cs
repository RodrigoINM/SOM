using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using SOM.BDD.Pages.Produto.Template;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Produto.Template
{
    [Binding]
    public sealed class ExcluirTemplateSteps
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public CadastroDeTemplatePage TelaCadastroDeTemplatePage { get; private set; }

        public ExcluirTemplateSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);
            TelaCadastroDeTemplatePage = new CadastroDeTemplatePage((IBrowser)browser);
        }

        [When(@"excluo o item de template cadastrado")]
        public void QuandoExcluoOItemDeTemplateCadastrado()
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.ExcluirItemDeTemplate();
        }

        [Then(@"visualizo uma mensagem de item de template excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeItemDeTemplateExcluidoComSucesso(string Mensagem)
        {
            TelaCadastroDeTemplatePage.ValidarPopup(Mensagem);
        }

        [Given(@"adiciono uma materia para o item de template criado ""(.*)""")]
        public void DadoAdicionoUmaMateriaParaOItemDeTemplateCriado(string Materia)
        {
            TelaCadastroDeTemplatePage.SelecionarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            TelaCadastroDeTemplatePage.CriarBlocoMateria(Materia);
        }

        [When(@"excluo a materia dentro de um bloco ""(.*)"", ""(.*)""")]
        public void QuandoExcluoAMateriaDentroDeUmBloco(string Materia, string MensagemExclusaoMateria)
        {
            TelaCadastroDeTemplatePage.ExcluirMateriaEBloco(Materia, MensagemExclusaoMateria, "Sim");
        }

        [Then(@"visualizo uma mensagem de materia excluida com sucesso ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeMateriaExcluidaComSucesso(string Mensagem)
        {
            TelaCadastroDeTemplatePage.ValidarPopup(Mensagem);
        }

        [When(@"excluo um bloco do template ""(.*)"", ""(.*)""")]
        public void QuandoExcluoUmBlocoDoTemplate(string Bloco, string MensagemExclusaoBloco)
        {
            TelaCadastroDeTemplatePage.ExcluirMateriaEBloco(Bloco, MensagemExclusaoBloco, "Sim");
        }

        [Then(@"visualizo uma mensagem de bloco excluido com sucesso ""(.*)""")]
        public void EntaoVisualizoUmaMensagemDeBlocoExcluidoComSucesso(string Mensagem)
        {
            TelaCadastroDeTemplatePage.ValidarPopup(Mensagem);
        }

        [When(@"cancelo a exclusão da materia dentro de um bloco ""(.*)"", ""(.*)""")]
        public void QuandoCanceloAExclusaoDaMateriaDentroDeUmBloco(string Materia, string MensagemExclusaoMateria)
        {
            TelaCadastroDeTemplatePage.ExcluirMateriaEBloco(Materia, MensagemExclusaoMateria, "Não");
        }

        [Then(@"visualizo a Materia e o Bloco na grid de template com sucesso ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMateriaEOBlocoNaGridDeTemplateComSucesso(string Bloco, string Materia)
        {
            TelaCadastroDeTemplatePage.ValidarItemTemplate(Bloco);
            TelaCadastroDeTemplatePage.ValidarItemTemplate(Materia);
        }

        [Then(@"visualizo o Bloco na grid de template com sucesso ""(.*)""")]
        public void EntaoVisualizoOBlocoNaGridDeTemplateComSucesso(string Bloco)
        {
            TelaCadastroDeTemplatePage.ValidarItemTemplate(Bloco);
        }

    }
}
