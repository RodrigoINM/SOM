using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Configuration;
using SOM.BDD.Helpers;
using System.IO;
using ExcelDataReader;

namespace SOM.BDD.Pages.UsoEReporte.RelatorioUBEM
{
    public class GerarRelatorioUBEM : PageBase
    {
        private string RelatorioUBEMUrl { get; }

        private string PageTitle => "SOM | Relatório UBEM";

        private Element MsgFechamento { get; set; }
        private Element SlctAssociacao { get; set; }
        private Element SlctTipo { get; set; }
        private Element InpPeriodo { get; set; }
        private Element InpProduto { get; set; }
        private Element InpDDA { get; set; }
        private Element InpMidia { get; set; }
        private Element ChckMidia { get; set; }
        private Element OptProduto { get; set; }
        private Element OptDDA { get; set; }
        private Element BtnDownloadExcelMensal { get; set; }
        private Element BtnDownloadExcel { get; set; }

        public GerarRelatorioUBEM(IBrowser browser, string relatorioUBEMUrl) : base(browser)
        {
            RelatorioUBEMUrl = relatorioUBEMUrl;

            MsgFechamento = Element.Css("div[ng-if='loadFechamento === false'] label");
            SlctAssociacao = Element.Css("select[ng-model='report.tipoAssociacao']");
            SlctTipo = Element.Css("select[ng-model='report.tipoRelatorio']");
            InpPeriodo = Element.Css("input[ng-model='report.dataFechamento']");
            InpProduto = Element.Css("input[ng-model='DscProduto']");
            InpDDA = Element.Css("input[ng-model='report.DDA']");
            InpMidia = Element.Css("input[ng-model='$select.search']");
            ChckMidia = Element.Css("input[id='ExibirMidiaId']");
            OptProduto = Element.Css("li[id='typeahead-12-1291-option-0']");
            OptDDA = Element.Css("li[id='typeahead-13-3411-option-0']");
            BtnDownloadExcelMensal = Element.Css("a[ng-click='GerarExcel()']");
            BtnDownloadExcel = Element.Css("a[ng-click='BaixarExcel()']");
        }

        public override void Navegar()
        {
            Browser.Abrir(RelatorioUBEMUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void VerificarPeriodoFechadoUbem()
        {

        }

        public void FiltrarRelatorioUbem(string Associacao, string Tipo, string Mes, string Ano, string Produto,
            string DDA, string Midias)
        {
            SelecionarAssociacao(Associacao, Tipo);
            InformarPeriodo(Mes, Ano);
            SelecionarProduto(Produto);
            SelecionarDDA(DDA);
            SelecionarMidias(Midias);
        }

        private void SelecionarMidias(string Midias)
        {
            if (Midias != "")
            {
                MouseActions.ClickATM(Browser, InpMidia);
                //InpMidia.Click();
                //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                MouseActions.ClickATM(Browser, Element.Xpath("//*[@class='ng-binding ng-scope'][contains(.,'" + Midias + "')]"));
                //Driver.FindElement(By.XPath("//*[@class='ng-binding ng-scope'][contains(.,'" + Midias + "')]")).Click();
            }
        }

        private void SelecionarDDA(string DDA)
        {
            if (DDA != "")
            {
                AutomatedActions.SendData(Browser, InpDDA, DDA);
                //InpDDA.SendKeys(DDA);
                //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                MouseActions.ClickATM(Browser, OptDDA);
                //OptDDA.Click();
            }
        }

        private void SelecionarProduto(string Produto)
        {
            if (Produto != "")
            {
                AutomatedActions.SendData(Browser, InpProduto, Produto);
                //InpProduto.SendKeys(Produto);
                //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                MouseActions.ClickATM(Browser, OptProduto);
                //OptProduto.Click();
            }
        }

        private void SelecionarAssociacao(string Associacao, string Tipo)
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //var selectAssociacao = new SelectElement(SlctAssociacao);
            switch (Associacao)
            {
                case "UBEM":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacao, "U");
                        //selectAssociacao.SelectByValue("U");
                        SelecionarTipo(Tipo);
                        break;
                    }
                case "SEM ASSOCIAÇÃO":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacao, "S");
                        //selectAssociacao.SelectByValue("S");
                        break;
                    }
                case "TODAS":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacao, "T");
                        //selectAssociacao.SelectByValue("T");
                        break;
                    }
            }
        }

        private void SelecionarTipo(string Tipo)
        {
            if (Tipo != "")
            {
                //var selectTipo = new SelectElement(SlctTipo);
                if (Tipo == "Mensal")
                    MouseActions.SelectElementATMByValue(Browser, SlctTipo, "M");
                //selectTipo.SelectByValue("M");
                else
                    MouseActions.SelectElementATMByValue(Browser, SlctTipo, "C");
                //selectTipo.SelectByValue("C");
            }
        }

        private void InformarPeriodo(string Mes, string Ano)
        {
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpPeriodo, Mes);
            Thread.Sleep(2000);
            KeyboardActions.Tab(Browser, InpPeriodo);
            Thread.Sleep(2000);
            AutomatedActions.SendData(Browser, InpPeriodo, Ano);
        }

        public void DownloadRelatorioUbemMensal()
        {
            MouseActions.ClickATM(Browser, BtnDownloadExcelMensal);
            Thread.Sleep(2000);
            Assert.IsTrue(ElementExtensions.IsClickable(SlctAssociacao, Browser));
            Thread.Sleep(2000);
        }

        public void DownloadRelatorioUbem()
        {
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            MouseActions.ClickATM(Browser, BtnDownloadExcel);
            //BtnDownloadExcel.Click();
            Thread.Sleep(2000);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(360);
            Assert.IsTrue(ElementExtensions.IsClickable(SlctAssociacao, Browser));
            //Assert.IsTrue(SlctAssociacao.Displayed);
            Thread.Sleep(2000);
        }

        public void ValidarMensagemFechamentoInexistente(string Mensagem)
        {
            ElementExtensions.IsClickable(Element.Xpath("//div[@ng-if='loadFechamento === false']/label"), Browser);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Xpath("//div[@ng-if='loadFechamento === false']/label"), "textContent", Browser));
            //Assert.AreEqual(Mensagem, Driver.FindElement(By.XPath("//div[@ng-if='loadFechamento === false']/label")).GetAttribute("textContent"));
        }

        public void ValidarDadosRelatorioUbem(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise, string file)
        {
            ExcelUtil.PopulateInCollection(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx", "Planilha Mensal UBEM");

            ValidarColuna(Programa, "PROGRAMA");
            ValidarColuna(Data, "DATA EXIBIÇÃO");
            ValidarColuna(Capitulo, "CAPÍTULO");
            ValidarColuna(Episodio, "EPISÓDIO");
            ValidarColuna(Genero, "GÊNERO");
            ValidarColuna(TituloMusica, "TÍTULO DA MÚSICA");
            ValidarColuna(TituloOriginal, "TÍTULO ORIGINAL");
            ValidarColuna(Autor, "AUTOR");
            ValidarColuna(DDA, "DDA");
            ValidarColuna(Duplicidade, "POSSUI DUPLICIDADE");
            ValidarColuna(Sincronismo, "SINCRONISMO");
            ValidarColuna(Interpretes, "INTÉRPRETES");
            ValidarColuna(Reprise, "REPRISE");
        }

        private void ValidarColuna(string ValorLinha, string Coluna)
        {
            if (ValorLinha != "" && ValorLinha != " ")
            {
                var linha = "0";
                var numLinha = 1;

                while (linha != ValorLinha && linha != "")
                {
                    linha = $"{ExcelUtil.ReadData(numLinha, Coluna)}";
                    if (linha == ValorLinha)
                    {
                        Assert.AreEqual(ValorLinha, linha);
                    }
                    else
                    {
                        linha = $"{ExcelUtil.ReadData(numLinha, "PROGRAMA")}";
                        if (linha == "")
                        {
                            throw new ArgumentException("Na coluna " + Coluna + " não existe o valor " + ValorLinha);
                        }
                    }
                    numLinha = numLinha + 1;
                }
            }
        }

        public void ValidarRelatorioUbem(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise,
            string Associacao, string Mes, string Ano)
        {
            switch (Associacao)
            {
                case "UBEM":
                    {
                        ValidarRelatorioAssociacao(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "SEM ASSOCIAÇÃO":
                    {
                        Associacao = "SEM_ASSOCIACAO";
                        ValidarRelatorioAssociacao(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "TODAS":
                    {
                        Associacao = "TODAS_ASSOCIACOES";
                        ValidarRelatorioAssociacao(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
            }
        }

        public void ExcluirRelatorio(string Associacao, string Mes, string Ano)
        {
            switch (Associacao)
            {
                case "UBEM":
                    {
                        DataRelatorio(Associacao, Mes, Ano);
                        break;
                    }
                case "SEM ASSOCIAÇÃO":
                    {
                        Associacao = "SEM_ASSOCIACAO";
                        DataRelatorio(Associacao, Mes, Ano);
                        break;
                    }
                case "TODAS":
                    {
                        Associacao = "TODAS_ASSOCIACOES";
                        DataRelatorio(Associacao, Mes, Ano);
                        break;
                    }
            }
        }

        private void DataRelatorio(string Associacao, string Mes, string Ano)
        {
            string teste = "Relatorio_" + Associacao + "_";
            switch (Mes)
            {
                case "Janeiro":
                    {
                        string file = teste + "01" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Fevereiro":
                    {
                        string file = teste + "02" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Março":
                    {
                        string file = teste + "03" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Abril":
                    {
                        string file = teste + "04" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Maio":
                    {
                        string file = teste + "05" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Junho":
                    {
                        string file = teste + "06" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Julho":
                    {
                        string file = teste + "07" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Agosto":
                    {
                        string file = teste + "08" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Setembro":
                    {
                        string file = teste + "09" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Outubro":
                    {
                        string file = teste + "10" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Novembro":
                    {
                        string file = teste + "11" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
                case "Dezembro":
                    {
                        string file = teste + "12" + Ano + "";
                        CaminhoRelatorioParaExclusao(file, Associacao, Mes, Ano);
                        break;
                    }
            }
        }

        private void CaminhoRelatorioParaExclusao(string file, string Associacao, string Mes, string Ano)
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx";

            File.Delete(originalFileName);
        }

        public void ValidarRelatorioAssociacao(string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise,
            string Associacao, string Mes, string Ano)
        {
            string teste = "Relatorio_" + Associacao + "_";
            switch (Mes)
            {
                case "Janeiro":
                    {
                        string file = teste + "01" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Fevereiro":
                    {
                        string file = teste + "02" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Março":
                    {
                        string file = teste + "03" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Abril":
                    {
                        string file = teste + "04" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Maio":
                    {
                        string file = teste + "05" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Junho":
                    {
                        string file = teste + "06" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Julho":
                    {
                        string file = teste + "07" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Agosto":
                    {
                        string file = teste + "08" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Setembro":
                    {
                        string file = teste + "09" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Outubro":
                    {
                        string file = teste + "10" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Novembro":
                    {
                        string file = teste + "11" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
                case "Dezembro":
                    {
                        string file = teste + "12" + Ano + "";
                        ValidarDownloadRelatorio2(file, Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, Associacao, Mes, Ano);
                        break;
                    }
            }
        }
        
        public void ValidarDownloadRelatorio2(string file, string Programa, string Data, string Capitulo, string Episodio, string Genero, string TituloMusica,
            string TituloOriginal, string Autor, string DDA, string Duplicidade, string Sincronismo, string Interpretes, string Reprise,
            string Associacao, string Mes, string Ano)
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx";

            ValidarDadosRelatorioUbem(Programa, Data, Capitulo, Episodio, Genero, TituloMusica, TituloOriginal,
                Autor, DDA, Duplicidade, Sincronismo, Interpretes, Reprise, file);

            File.Delete(originalFileName);
        }

        private void LerRelatorio(string originalFileName)
        {
            using (var stream = File.Open(originalFileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                reader = ExcelReaderFactory.CreateReader(stream);

                //reader.IsFirstRowAsColumnNames
                var conf = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };

                var dataSet = reader.AsDataSet(conf);
                var dataTable = dataSet.Tables[0];
            }
        }

    }
}
