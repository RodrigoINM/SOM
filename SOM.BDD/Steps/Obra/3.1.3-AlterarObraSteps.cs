using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra
{
    [Binding]
    public sealed class AlterarObraSteps
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public ExcluirObraPage TelaExcluirObraPage { get; private set; }

        public AlterarObraSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);

            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);

            TelaExcluirObraPage = new ExcluirObraPage((IBrowser)browser);
        }

        [When(@"faço uma busca simples por uma obra")]
        public void QuandoFacoUmaBuscaSimplesPorUmaObra()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra("Obra");
        }

        [When(@"altero e salvo os dados no campo titulo")]
        public void QuandoAlteroESalvoOsDadosNoCampoTitulo()
        {
            TelaCadastrarObraEComposicaoPage.EditarTitulodaObra("", "", "", "", "", "", "", "", "", "", "", "");

        }

        [Then(@"visualizo a mensagem de alterado obra com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeAlteradoObraComSucesso(string MensagemDeAlteração)
        {
            TelaCadastrarObraEComposicaoPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Given(@"que esteja na tela Edição de Obra")]
        public void DadoQueEstejaNaTelaEdicaoDeObra()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra("Obra");
        }

        [When(@"salvo a alteração no campo tipo da obra ""(.*)""")]
        public void QuandoSalvoAAlteracaoNoCampoTipoDaObra(string Tipo)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", "", Tipo, "", "", "", "", "", "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem de alteração da obra com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeAlteracaoDaObraComSucesso(string MensagemDeAlteração)
        {
            TelaCadastrarObraEComposicaoPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [When(@"salvo a alteração no campo Ano ""(.*)""")]
        public void QuandoSalvoAAlteracaoNoCampoAno(string Ano)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", "", "", "", "", Ano, "", "", "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem de alteração do ano da obra com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeAlteracaoDoAnoDaObraComSucesso(string MensagemDeAlteração)
        {
            TelaCadastrarObraEComposicaoPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Given(@"altero os dados obrigatorios Titulo, ""(.*)"" e ""(.*)"" da obra")]
        public void DadoAlteroOsDadosObrigatoriosTituloEDaObra(string Tipo, string Nacionalidade)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", "", Tipo, "", "", "", "", Nacionalidade, "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem dos campos obrigatórios, alterado com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDosCamposObrigatoriosAlteradoComSucesso(string MensagemDeAlteração)
        {
            TelaCadastrarObraEComposicaoPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Given(@"salvo uma alteracao feita no campo de ""(.*)""")]
        public void DadoSalvoUmaAlteracaoFeitaNoCampoDe(string Derivacao)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", "", "", "", "", "", Derivacao, "", "", "", "", "", "");
        }

        [Then(@"visualizo a mensagem de alteração ""(.*)"" com sucesso")]
        public void EntaoVisualizoAMensagemDeAlteracaoComSucesso(string MensagemDeAlteração)
        {
            TelaCadastrarObraEComposicaoPage.ValidarDadosAlterados(MensagemDeAlteração);
        }

        [Given(@"que esteja na tela Edição de Obra, que já possue Obra Origunal informada")]
        public void DadoQueEstejaNaTelaEdicaoDeObraQueJaPossueObraOrigunalInformada()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Adaptação", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra("Obra");
        }

        [Given(@"altero o campo de ""(.*)"" e salvo")]
        public void DadoAlteroOCampoDeESalvo(string AlterarObra)
        {
            TelaCadastrarObraEComposicaoPage.AlteroCampoObraOriginal(AlterarObra);
        }

        [When(@"salvo a aletracao da flag ""(.*)""")]
        public void QuandoSalvoAAletracaoDaFlag(string Institucional)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", "", "", "", "", "", "", "", "", "", Institucional, "", "");
        }

        [When(@"salvo a aletracao da flag emblematica ""(.*)""")]
        public void QuandoSalvoAAletracaoDaFlagEmblematica(string Emblematica)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", "", "", "", "", "", "", "", "", "", "", "", Emblematica);
        }

        [When(@"salvo a alteracao do ""(.*)""")]
        public void QuandoSalvoAAlteracaoDo(string SubTitutlo)
        {
            TelaCadastrarObraEComposicaoPage.EditarObra("", SubTitutlo, "", "", "", "", "", "", "", "", "", "", "");
        }

        [When(@"salvo a alteracao de DDA com ""(.*)""")]
        public void QuandoSalvoAAlteracaoDeDDACom(string Associacao)
        {
            TelaCadastrarObraEComposicaoPage.SelecionarComposicaoParaEdicao("Autor");
            TelaCadastrarObraEComposicaoPage.CadastrarDDAManualmente(Associacao);
        }

        [Then(@"visualizo a mensagem de DDA ""(.*)"" com sucesso")]
        public void EntaoVisualizoAMensagemDeDDAComSucesso(string Mensagem)
        {
            TelaCadastrarObraEComposicaoPage.ValidarPopupSucesso(Mensagem);
        }

    }

}

