using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Threading;

namespace SOM.BDD.Pages.Obra
{
    public class ConsultarObraPage : PageBase
    {
        private string ConsultaObraUrl { get; }

        private string PageTitle => "SOM | Obras";

        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; set; }

        //Filtro Simples
        public Element InpBuscaSimples { get; private set; }
        public Element BtnPesquisaSimples { get; private set; }

        //Filtro avançado
        public Element BtnShowFiltro { get; private set; }
        public Element InpTituloObra { get; private set; }
        public Element InpSubTitulo { get; private set; }
        public Element InpAutor { get; private set; }
        public Element InpTituloAlternativo { get; private set; }
        public Element InpDDA { get; private set; }
        public Element SlctTipo { get; private set; }
        public Element BtnPesquisar { get; private set; }

        public ConsultarObraPage(IBrowser browser, string consultaObraUrl) : base(browser)
        {
            ConsultaObraUrl = consultaObraUrl;

            //Filtro Simples
            InpBuscaSimples = Element.Css("input[placeholder='Buscar Obra']");
            BtnPesquisaSimples = Element.Css("a[uib-tooltip='Pesquisar']");

            //Filtro avançado
            BtnShowFiltro = Element.Css("a[ng-click='ShowHideFiltro()'] i");
            InpTituloObra = Element.Css("div[id='filtroTela'] input[ng-model='ObraFiltros.Titulo']");
            InpSubTitulo = Element.Css("input[ng-model='ObraFiltros.Subtitulo']");
            InpAutor = Element.Css("input[ng-model='ObraFiltros.Autor']");
            InpTituloAlternativo = Element.Css("input[ng-model='ObraFiltros.TituloAlternativo']");
            InpDDA = Element.Css("input[ng-model='ObraFiltros.DDA']");
            SlctTipo = Element.Css("select[ng-model='ObraFiltros.TipoObras.selected']");
            BtnPesquisar = Element.Css("button[ng-disabled='Pesquisa']");

        }

        public override void Navegar()
        {
            Browser.Abrir(ConsultaObraUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        private void AbrirFiltrosAvancadosDeObras()
        {
            try
            {
                MouseActions.ClickATM(Browser, InpTituloObra);
            }
            catch
            {
                MouseActions.ClickATM(Browser, BtnShowFiltro);
            }
        }

        public void BuscaSimplesObra()
        {
            Thread.Sleep(2000);
            var Valor = CadastrarObraEComposicaoPage.Obra;
            ConsultaSimplesObra(Valor);
        }

        public void ConsultaSimplesObra(string Obra)
        {
            Thread.Sleep(2000);
            if(Obra == "Obra")
                AutomatedActions.SendDataATM(Browser, InpBuscaSimples, CadastrarObraEComposicaoPage.Obra);
            else
                AutomatedActions.SendDataATM(Browser, InpBuscaSimples, Obra);
            MouseActions.ClickATM(Browser, BtnPesquisaSimples);
            MouseActions.ClickATM(Browser, BtnShowFiltro);

            if (Obra == "Obra")
            {
                var tituloObra = Element.Xpath("//div[text()='" + CadastrarObraEComposicaoPage.Obra + "']");
                MouseActions.DoubleClickATM(Browser, tituloObra);
            }
            else
            {
                var tituloObra = Element.Xpath("//div[text()='" + Obra + "']");
                MouseActions.DoubleClickATM(Browser, tituloObra);
            }
        }

        public void ConsultaAvancadaObra(string Titulo, string SubTitulo, string Autor, string TituloAlt, string Tipo, string DDA)
        {
            AbrirFiltrosAvancadosDeObras();

            if (Titulo != "" && Titulo != " ")
                AutomatedActions.SendDataATM(Browser, InpTituloObra, Titulo);
            if (SubTitulo != "" && SubTitulo != " ")
                AutomatedActions.SendDataATM(Browser, InpSubTitulo, SubTitulo);
            if (Autor != "" && Autor != " ")
                AutomatedActions.SendDataATM(Browser, InpAutor, Autor);
            if (TituloAlt != "" && TituloAlt != " ")
                AutomatedActions.SendDataATM(Browser, InpTituloAlternativo, TituloAlt);
            if (DDA != "" && DDA != " ")
                AutomatedActions.SendDataATM(Browser, InpDDA, DDA);
            if (Tipo != "" && Tipo != " ")
                SelecionarTipo(Tipo);
            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        private void SelecionarTipo(string Valor)
        {
            switch (Valor)
            {
                case "BIBLIOTECA MUSICAL":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipo, "2");
                        break;
                    }
                case "MUSICA COMERCIAL":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipo, "3");
                        break;
                    }
                case "MUSICA COMERCIAL GRATUITA":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipo, "4");
                        break;
                    }
                case "TRILHA MUSICAL":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipo, "1");
                        break;
                    }
            }
        }

        public void ValidarObraNaGrid(string Titulo, string Autor, string DDA, string Nacionalidade, string Tipo, string DominioPublico)
        {
            try
            {
                var tr = 1;

                while(tr <= 11)
                {
                    var textTitulo = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]//td[1]//div"), "textContent", Browser);
                    var textNacionalidade = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]//td[3]//div"), "textContent", Browser);
                    var textTipo = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]//td[4]//div"), "textContent", Browser);
                    var textDominioPublico = ElementExtensions.GetValorAtributo(Element.Xpath("//tr[" + tr + "]//td[5]//div"), "textContent", Browser);

                    if (textTitulo == Titulo && textNacionalidade == Nacionalidade && textTipo == Tipo && textDominioPublico == DominioPublico)
                    {
                        Assert.AreEqual(Titulo, textTitulo);
                        Assert.AreEqual(Nacionalidade, textNacionalidade);
                        Assert.AreEqual(Tipo, textTipo);
                        Assert.AreEqual(DominioPublico, textDominioPublico);
                        Assert.IsTrue(ElementExtensions.IsClickable(Element.Xpath("//tr[" + tr + "]//td[2]//div[contains (., '" + Autor + "-" + DDA + "')]"), Browser));

                        Thread.Sleep(2000);
                        MouseActions.DoubleClickATM(Browser, Element.Xpath("//tr[" + tr + "]//td[1]//div"));

                        tr = tr + 20;
                    }
                    tr = tr + 1;
                }
            }
            catch
            {
                throw new ArgumentException("A obra não foi encontrada.");
            }
        }

        public void ValidarDadosDeFonograma(string Obra)
        {
            Thread.Sleep(2000);
            MouseActions.DoubleClickATM(Browser, Element.Xpath("//td//div[text()='" + Obra + "']"));
            Thread.Sleep(5000);
            var fonogramatext = Element.Xpath("//h4[text()='Fonograma']");
            ElementExtensions.IsElementVisible(fonogramatext, Browser);
            //ValidarFonograma(Interpretes);
            //ValidarFonograma(ProdutorFonografico);
            //ValidarFonograma(Submix);
            //ValidarFonograma(ISRC);
        }

        //private void ValidarFonograma(string Valor)
        //{
        //    if(Valor != "" && Valor != " ")
        //        ElementExtensions.IsElementVisible(Element.Xpath("//div[@ng-repeat='item in ObraDados.Fonogramas'][1]//h5[contains (., '" + Valor + "')]"), Browser);
        //}
        
   }
}
