using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System.Threading;
using System.IO;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Obra.DDA
{
    public class ConsultaDeDDAPage : PageBase
    {
        private string ConsultaDeDDAUrl { get; }

        private string PageTitle => "SOM | DDA";

        //Consulta de DDA cadastrado
        private Element InpBuscaDDA { get; set; }
        private Element BtnPesquisar { get; set; }

        //Consulta avançada de DDA cadastrado
        public Element BtnShowFiltroAvancadoDDA { get; private set; }
        public Element InpNomeFantasia { get; private set; }
        public Element InpNomeCompleto { get; private set; }
        public Element SlctTipo { get; private set; }
        public Element SlctAssociacao { get; private set; }
        public Element SlctAdministradoPor { get; private set; }
        public Element BtnPesquisaAvancada { get; private set; }

        //Baixar relatórios
        public Element BtnDownloadExcel { get; private set; }
        public Element BtnDownloadPdf { get; private set; }

        public ConsultaDeDDAPage(IBrowser browser, string consultaDeDDAUrl) : base(browser)
        {
            ConsultaDeDDAUrl = consultaDeDDAUrl;

            //Consulta de DDA cadastrado
            InpBuscaDDA = Element.Css("input[placeholder='Buscar DDA']");
            BtnPesquisar = Element.Css("a[uib-tooltip='Pesquisar']");

            //Consulta avançada de DDA cadastrado
            BtnShowFiltroAvancadoDDA = Element.Css("a[ng-click='ShowHideFiltro()']");
            InpNomeFantasia = Element.Css("div[id='filtroTela'] input[ng-model='DDAFiltros.Nome']");
            InpNomeCompleto = Element.Css("input[ng-model='DDAFiltros.RazaoSocial']");
            SlctTipo = Element.Css("select[ng-model='DDAFiltros.TipoDDAS.selected']");
            SlctAssociacao = Element.Css("select[ng-model='DDAFiltros.Associacao']");
            SlctAdministradoPor = Element.Css("select[ng-model='DDAFiltros.IdGrupoEditorialS.selected']");
            BtnPesquisaAvancada = Element.Css("button[uib-tooltip='Pesquisar']");

            //Baixar relatórios
            BtnDownloadExcel = Element.Css("a[uib-tooltip='Gerar Excel']");
            BtnDownloadPdf = Element.Css("a[uib-tooltip='Gerar PDF']");
        }

        
        public override void Navegar()
        {
            Browser.Abrir(ConsultaDeDDAUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void ConsultaSimplesDeDDA(string NomeFantasia)
        {
            AutomatedActions.SendDataATM(Browser, InpBuscaDDA, NomeFantasia);
            MouseActions.ClickATM(Browser, BtnPesquisar);
        }

        private void AbrirFiltrosAvancadosDeDDA()
        {
            try
            {
                MouseActions.ClickATM(Browser, InpNomeFantasia);
            }
            catch
            {
                MouseActions.ClickATM(Browser, BtnShowFiltroAvancadoDDA);
            }
        }

        public void ConsultaAvancadaDeDDA(string NomeFantasia, string NomeCompleto, string Tipo, string Associacao)
        {
            AbrirFiltrosAvancadosDeDDA();
            if (NomeFantasia != "" && NomeFantasia != " ")
                AutomatedActions.SendDataATM(Browser, InpNomeFantasia, NomeFantasia);
            if (NomeCompleto != "" && NomeCompleto != " ")
                AutomatedActions.SendDataATM(Browser, InpNomeCompleto, NomeCompleto);
            SelecionarTipoDeDDA(Tipo);
            SelecionarAssociacaoDeDDA(Associacao);

            MouseActions.ClickATM(Browser, BtnPesquisaAvancada);
        }

        private void SelecionarTipoDeDDA(string Valor)
        {
            if (Valor != "" && Valor != " ")
            {
                switch (Valor)
                {
                    case "DDA":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctTipo, "2");
                            break;
                        }
                    case "Grupo Editorial":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctTipo, "1");
                            break;
                        }
                    case "Todos":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctTipo, "0");
                            break;
                        }
                }
            }
        }

        private void SelecionarAssociacaoDeDDA(string Valor)
        {
            if (Valor != "" && Valor != " ")
            {
                switch (Valor)
                {
                    case "UBEM":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctAssociacao, "UBEM");
                            break;
                        }
                    case "SEM ASSOCIAÇÃO":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctAssociacao, "SEM ASSOCIAÇÃO");
                            break;
                        }
                }
            }
        }

        public void BaixarRelatorioExcelDeDDA()
        {
            MouseActions.ClickATM(Browser, BtnDownloadExcel);

            ElementExtensions.EsperarElemento(Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"), Browser);
            Assert.AreEqual("Gerando arquivo excel, favor aguarde.", ElementExtensions.GetValorAtributo(Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"), "textContent", Browser));
            Thread.Sleep(1000);
        }

        public void ExcluirRelatorioExcelDeDDA()
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\Report.xls";

            File.Delete(originalFileName);
        }

        public void BaixarRelatorioPdfDeDDA()
        {
            MouseActions.ClickATM(Browser, BtnDownloadPdf);

            ElementExtensions.EsperarElemento(Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"), Browser);
            Assert.AreEqual("Gerando arquivo PDF, favor aguarde.", ElementExtensions.GetValorAtributo(Element.Css("div[id='toast-container'] div[class='ng-binding ng-scope']"), "textContent", Browser));
            Thread.Sleep(1000);
        }

        public void ExcluirRelatorioPdfDeDDA()
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\Report.pdf";

            File.Delete(originalFileName);
        }

        public void ValidarDadosNaoEncontrados(string Mensagem)
        {
            var mensagem = Element.Css("td[class='dataTables_empty']");

            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(mensagem, "textContent", Browser));
        }

        public void ValidarResultadoDaConsultaDeDDA(string NomeFantasia, string NomeCompletoRazaoSocial, string Documento, string Associacao, string Tipo)
        {
            ValidarDDANaGrid("Nome Fantasia", NomeFantasia);
            ValidarDDANaGrid("Nome Completo", NomeCompletoRazaoSocial);
            ValidarDDANaGrid("Documento", Documento);
            ValidarDDANaGrid("Associação", Associacao);
            ValidarDDANaGrid("Tipo", Tipo);
        }

        private void ValidarDDANaGrid(string Coluna, string Valor)
        {
            if(Valor != "" && Valor != " ")
            {
                switch(Coluna)
                {
                    case "Nome Fantasia":
                        {
                            Coluna = "1";
                            ValidarDDAs(Coluna, Valor);
                            break;
                        }
                    case "Nome Completo":
                        {
                            Coluna = "2";
                            ValidarDDAs(Coluna, Valor);
                            break;
                        }
                    case "Documento":
                        {
                            Coluna = "3";
                            ValidarDDAs(Coluna, Valor);
                            break;
                        }
                    case "Associação":
                        {
                            Coluna = "4";
                            ValidarDDAs(Coluna, Valor);
                            break;
                        }
                    case "Tipo":
                        {
                            Coluna = "5";
                            ValidarDDAs(Coluna, Valor);
                            break;
                        }
                }
            }
        }

        private void ValidarDDAs(string Coluna, string Valor)
        {
            var linha = "0";
            var tr = 1;

            while (linha != Valor)
            {
                var td = Coluna;

                linha = ElementExtensions.GetValorAtributo(Element.Xpath("//*[@dt-columns='dtColumns']/tbody/tr[" + tr + "]/td[" + td + "]/div"), "textContent", Browser);

                if (linha == Valor)
                {
                    Assert.AreEqual(Valor, linha);
                }
                else
                {
                    if (tr == 11)
                    {
                        throw new ArgumentException("Na coluna " + Coluna + " não existe o valor " + Valor);
                    }
                }
                tr = tr + 1;
            }
        }

    }
}
