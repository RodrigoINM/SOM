using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;

namespace SOM.BDD.Pages.Produto
{
    public class ConsultaDeProdutoPage : PageBase
    {
        private string BuscaProdutoUrl { get; }

        private string PageTitle => "SOM | Produto";

        //Consulta simples de produto
        private Element InpBuscaProduto { get; set; }
        private Element BtnPesquisar { get; set; }

        //Consulta Avançada de produto
        public Element InpNomeProduto { get; private set; }
        public Element InpEpisodio { get; private set; }
        public Element SlctGeneroOriginal { get; private set; }
        public Element SlctDireitosMusicais { get; private set; }
        public Element BtnPesquisarConsultaAvancada { get; private set; }
        public Element BtnFiltros { get; private set; }

        public ConsultaDeProdutoPage(IBrowser browser, string buscaProdutoUrl) : base(browser)
        {
            BuscaProdutoUrl = buscaProdutoUrl;

            InpBuscaProduto = Element.Css("input[placeholder='Buscar Produto']");
            BtnPesquisar = Element.Css("a[uib-tooltip='Pesquisar']");

            //Consulta avançada de produto
            InpNomeProduto = Element.Css("div[id='filtroTela'] input[ng-model='ProdutoFiltros.Nome']");
            InpEpisodio = Element.Css("div[id='filtroTela'] input[ng-model='ProdutoFiltros.Episodio']");
            SlctGeneroOriginal = Element.Css("div[ng-model='ProdutoFiltros.generoOriginal.selected'] i[class='caret pull-right']");
            SlctDireitosMusicais = Element.Css("div[ng-model='ProdutoFiltros.generoDiretoMusical.selected'] i[class='caret pull-right']");
            BtnPesquisarConsultaAvancada = Element.Css("button[ng-click='GetAllProduto(false)']");
            BtnFiltros = Element.Css("a[ng-click='ShowHideFiltro()']");
        }

        public CadastroDeProdutoPage MetodosProduto { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(BuscaProdutoUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void ConsultaSimplesProduto()
        {
            Navegar();
            Browser.RefreshPage();
            AutomatedActions.SendDataATM(Browser, InpBuscaProduto, CadastroDeProdutoPage.Produto);
            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        public void BuscaSimplesDeProduto(string Valor)
        {
            Navegar();
            Browser.RefreshPage();
            AutomatedActions.SendDataATM(Browser, InpBuscaProduto, Valor);
            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        private void SelecionarGeneroMusical(string Valor)
        {
            if (Valor != "")
            {
                MouseActions.ClickATM(Browser, SlctGeneroOriginal);
                var selecionarGeneroOriginal = Element.Xpath("//a/div[text()='" + Valor + "']");
                MouseActions.ClickATM(Browser, selecionarGeneroOriginal);
            }
        }

        private void SelecionarDireitosMusicais(string Valor)
        {
            if (Valor != "")
            {
                MouseActions.ClickATM(Browser, SlctDireitosMusicais);
                var selecionarDireitosMusicais = Element.Xpath("//a/div[text()='" + Valor + "']");
                MouseActions.ClickATM(Browser, selecionarDireitosMusicais);
            }
        }


        public void ConsultaAvancadaDeProdutoInexistentes(string Nome, string Episodio)
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnFiltros);
            if (Nome != "")
                AutomatedActions.SendDataATM(Browser, InpNomeProduto, Nome);
            if (Episodio != "")
                AutomatedActions.SendDataATM(Browser, InpEpisodio, Episodio);

            MouseActions.ClickATM(Browser, BtnPesquisarConsultaAvancada);
        }

        public void ConsultaAvancadaDeProduto(string GeneroOriginal, string DireitosMusicais)
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnFiltros);
            if(CadastroDeProdutoPage.Produto != "")
                AutomatedActions.SendDataATM(Browser, InpNomeProduto, CadastroDeProdutoPage.Produto);
            if(CadastroDeProdutoPage.Episodio != "")
                AutomatedActions.SendDataATM(Browser, InpEpisodio, CadastroDeProdutoPage.Episodio);
            SelecionarGeneroMusical(GeneroOriginal);
            SelecionarDireitosMusicais(DireitosMusicais);

            MouseActions.ClickATM(Browser, BtnPesquisarConsultaAvancada);
        }

        public void ValidarDadosNaoEncontradosProduto(string Mensagem)
        {
            var resultado = Element.Css("td[class='dataTables_empty']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(resultado, "textContent", Browser));
        }
    }
}
