using Framework.Core.Interfaces;
using SOM.BDD.Pages.Obra;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SOM.BDD.Steps.Obra
{
    [Binding]
    public sealed class ExcluirObraSteps
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; private set; }
        public ConsultarObraPage TelaConsultarObraPage { get; private set; }
        public ExcluirObraPage TelaExcluirObraPage { get; private set; }

        public ExcluirObraSteps()
        {
            var browser = ScenarioContext.Current["browser"];

            TelaCadastrarObraEComposicaoPage = new CadastrarObraEComposicaoPage((IBrowser)browser,
                ConfigurationManager.AppSettings["CadastroObraUrl"]);

            TelaConsultarObraPage = new ConsultarObraPage((IBrowser)browser,
                ConfigurationManager.AppSettings["ConsultaObraUrl"]);

            TelaExcluirObraPage = new ExcluirObraPage((IBrowser)browser);
        }

        [Given(@"que tenha uma obra cadastrada no sistema ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void DadoQueTenhaUmaObraCadastradaNoSistema(string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica(Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional, BlackList, Emblematica);
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
        }

        [When(@"excluo essa obra")]
        public void QuandoExcluoEssaObra()
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.BuscaSimplesObra();
        }

        [Then(@"visualizo a mensagem de obra excluida com sucesso ""(.*)""")]
        public void EntaoVisualizoAMensagemDeObraExcluidaComSucesso(string Mensagem)
        {
            TelaExcluirObraPage.ExcluirObraRandomica("Obra");
        }

        [Given(@"que tenho uma obra cadastrado no sistema")]
        public void DadoQueTenhoUmaObraCadastradoNoSistema()
        {
            TelaCadastrarObraEComposicaoPage.Navegar();
            TelaCadastrarObraEComposicaoPage.CadastroDeObraRandomica("MUSICA COMERCIAL", "", "", "2018", "Sim", "Nacional", "", "Não", "Não", "Não", "Não");
            TelaCadastrarObraEComposicaoPage.CadastrarComposicaoManualmente("100", "1");
            TelaCadastrarObraEComposicaoPage.SalvarObraEComposicao();
        }

        [When(@"excluo a composição cadstrada nessa obra")]
        public void QuandoExcluoAComposicaoCadstradaNessaObra()
        {
            TelaConsultarObraPage.Navegar();
            TelaConsultarObraPage.ConsultaSimplesObra("Obra");
            TelaCadastrarObraEComposicaoPage.ExcluirComposição();
        }

        [Then(@"visualizo a mensagem de registro excluido com sucesso\.")]
        public void EntaoVisualizoAMensagemDeRegistroExcluidoComSucesso_()
        {
            TelaCadastrarObraEComposicaoPage.MsgExcluirComposição();
        }

    }
}
