using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra
{
    [Binding]
    public sealed class CadastrarObraEComposicaoSteps
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public ExcluirObraPage TelaExcluirObraPage { get; private set; }

        public CadastrarObraEComposicaoSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);

            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);

            TelaExcluirObraPage = new ExcluirObraPage((IBrowser)browser);
        }

        [Given(@"que esteja com a tela de cadastro de Obras aberta")]
        public void DadoQueEstejaComATelaDeCadastroDeObrasAberta()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
        }

        [When(@"tento cadastrar uma obra sem informar uma composição ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoTentoCadastrarUmaObraSemInformarUmaComposicao(string Titulo, string SubTitutlo, string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            TelaCadastrarObraEComposicaoPage.CadastrarObra(Titulo, SubTitutlo, Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional, BlackList, Emblematica);
        }
        
        [Then(@"visualizo a mensagem de que ao menos uma composição da obra deve ser cadastrada ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDeQueAoMenosUmaComposicaoDaObraDeveSerCadastrada(string Titulo, string Mensagem, string SubTitutlo, string Tipo, string Iswc, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico)
        {
            TelaCadastrarObraEComposicaoPage.ValidarObraCadastrada(Titulo, SubTitutlo, Tipo, Iswc, ObraOriginal, Nacionalidade, Pais, DominioPublico);
            TelaCadastrarObraEComposicaoPage.ValidarPopupAlertaSemComposicao(Mensagem);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Titulo);
            TelaExcluirObraPage.ExclusaoDeObra(Titulo, "Registro excluído com sucesso.");
        }

        //Inclusão de Obra preenchendo todos os campos de obra
        [When(@"cadastro uma nova obra preenchendo os campos ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaObraPreenchendoOsCampos(string Titulo, string SubTitutlo, string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            QuandoTentoCadastrarUmaObraSemInformarUmaComposicao(Titulo, SubTitutlo, Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional, BlackList, Emblematica);
        }

        [When(@"incluo uma composicao com um unico autor com percentual de (.*)% ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoIncluoUmaComposicaoComUmUnicoAutorComPercentualDe(int p0, string Autor, string DDA, string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.CadastrarComposicao(Autor, DDA, Percentual);
        }

        [Then(@"visualizo todas as informacoes cadastradas de obra com sucesso ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoTodasAsInformacoesCadastradasDeObraComSucesso(string Titulo, string SubTitutlo, string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica, string Autor, string DDA, string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.ValidarObraCadastrada(Titulo, SubTitutlo, Tipo, Iswc, ObraOriginal, Nacionalidade, Pais, DominioPublico);
            TelaCadastrarObraEComposicaoPage.ValidarComposicaoCadastrada(Autor, "", DDA, Percentual);
        }

        //Inclusão de Obra sem preencher os campos obrigatorios de obra
        [When(@"tento cadastrar uma obra sem preencher os campos obriatórios ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoTentoCadastrarUmaObraSemPreencherOsCamposObriatorios(string Titulo, string SubTitutlo, string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            QuandoTentoCadastrarUmaObraSemInformarUmaComposicao(Titulo, SubTitutlo, Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional, BlackList, Emblematica);
        }

        [Then(@"visualizo os campos obrigatorios em destaque na tela do sistema com sucesso")]
        public void EntaoVisualizoOsCamposObrigatoriosEmDestaqueNaTelaDoSistemaComSucesso()
        {
            TelaCadastrarObraEComposicaoPage.ValidarCamposObrigatoriosEmDestaqueDeObra();
        }

        //Inclusão de Obra com um percentual de composição inferior a 100%
        [When(@"cadastro uma nova composição com percentual inferior a (.*)% ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaComposicaoComPercentualInferiorA(int p0, string Autor, string DDA, string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.CadastrarComposicao(Autor, DDA, Percentual);
        }
        
        [Then(@"visualizo a mensagem de Percentual inferior a (.*)% ao salvar a obra ""(.*)"", ""(.*)""")]
        public void EntaoVisualizoAMensagemDePercentualInferiorAAoSalvarAObra(int p0, string Titulo, string Mensagem)
        {
            TelaCadastrarObraEComposicaoPage.ValidarPopupPercentual(Mensagem);
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Titulo);
            TelaExcluirObraPage.ExclusaoDeObra(Titulo, "Registro excluído com sucesso.");
        }

        //Inclusão de Obra com percentual de composição acima de 100%
        [When(@"cadastro uma nova composição com percentual superior a (.*)% ""(.*)"", ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmaNovaComposicaoComPercentualSuperiorA(int p0, string Autor, string DDA, string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.CadastrarComposicao(Autor, DDA, Percentual);
        }
        
        [Then(@"visualizo a mensagem de Percentual superior a (.*)% ao salvar a obra ""(.*)""")]
        public void EntaoVisualizoAMensagemDePercentualSuperiorAAoSalvarAObra(int p0, string Mensagem)
        {
            TelaCadastrarObraEComposicaoPage.ValidarPopupPercentualAcimaDoPermitido(Mensagem);
        }

        //Inclusão de Obra com somatorio de percentual de composicao acima de 100%
        [Then(@"visualizo a mensagem de Percentual superior a (.*)% com sucesso ao incluir a segunda composicao ""(.*)""")]
        public void EntaoVisualizoAMensagemDePercentualSuperiorAComSucessoAoIncluirASegundaComposicao(int p0, string Mensagem)
        {
            TelaCadastrarObraEComposicaoPage.ValidarPopupPercentualAcimaDoPermitido(Mensagem);
        }

        //Validar criação de Autor na tela de composição
        [When(@"cadastro um novo autor pela tela de composição ""(.*)""")]
        public void QuandoCadastroUmNovoAutorPelaTelaDeComposicao(string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente(Percentual, "1");
        }

        //Validar criação de Duplicidade na composição
        [When(@"incluo uma composição com duplicidade")]
        public void QuandoIncluoUmaComposicaoComDuplicidade()
        {
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.CadastrarDuplicidade();
        }

        [Then(@"visualizo os dados da composição em vermelho ao salvar a obra ""(.*)""")]
        public void EntaoVisualizoOsDadosDaComposicaoEmVermelhoAoSalvarAObra(string Titulo)
        {
            TelaCadastrarObraEComposicaoPage.ValidarComposicaoEmDuplicidade();
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra(Titulo);
            TelaCadastrarObraEComposicaoPage.ValidarComposicaoEmDuplicidadeNaGrid();
            TelaExcluirObraPage.ExclusaoDeObra(Titulo, "Registro excluído com sucesso.");
        }

        //Validar criação dos tipos de DDA na tela de composição
        [When(@"cadastro um novo DDA pela tela de composição ""(.*)"", ""(.*)""")]
        public void QuandoCadastroUmNovoDDAPelaTelaDeComposicao(string TipoDDA, string Percentual)
        {
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.CadastrarDDAOriginal(TipoDDA);
        }

    }
}
