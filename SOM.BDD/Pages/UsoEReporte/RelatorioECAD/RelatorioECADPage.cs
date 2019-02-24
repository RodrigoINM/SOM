using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ExcelDataReader;
using SOM.BDD.Helpers;
using System.Windows.Forms;

namespace SOM.BDD.Pages.UsoEReporte.RelatorioECAD
{
    public class RelatorioECADPage : PageBase
    {
        public RelatorioECADPage(IBrowser browser, string relatorioECADUrl) : base(browser)
        {
            RelatorioECADUrl = relatorioECADUrl;

            InpMidia = Element.Css("input[ng-model='$select.search']");
            InpDDA = Element.Css("input[ng-model='report.DDA']");
            InpProduto = Element.Css("input[ng-model='DscProduto']");
            SlctTipo = Element.Css("select[ng-model='report.tipoRelatorio']");
            InpPeriodo = Element.Css("input[ng-model='report.dataFechamento']");
            BtnDownloadExcel = Element.Css("a[ng-click='BaixarExcel()']");
            BtnHistorico = Element.Css("a[ng-click='AbrirHistorico()']");
            PeriFechamento = Element.Css("div[ng-class='classData'] input[ng-change='BuscarRelatorioFechamento()']");
        }

        public string RelatorioECADUrl { get; private set; }
        public Element InpMidia { get; private set; }
        public Element InpDDA { get; private set; }
        public Element InpProduto { get; private set; }
        public Element SlctTipo { get; private set; }
        public Element InpPeriodo { get; private set; }
        public Element BtnDownloadExcel { get; private set; }
        public Element BtnHistorico { get; private set; }
        public Element PeriFechamento { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(RelatorioECADUrl);
        }

        public void FiltrarRelatorioEcad(string Tipo, string Mes, string Ano, string Produto,
            string DDA, string Midias)
        {
            SelecionarTipo(Tipo);
            InformarPeriodo(Mes, Ano);
            SelecionarProduto(Produto);
            SelecionarDDA(DDA);
            SelecionarMidias(Midias);

        }

        public void SelecionarFechamento()
        {
            var FechamentoMensal = Element.Css("a[ng-click='AbrirModalFechamento()']");
            MouseActions.ClickATM(Browser, FechamentoMensal);
        }

        public void DestaqueMsgFechamento(string Mensagem)
        {
            var TextFechamento = Element.Xpath("//h5[text()='" + Mensagem + "']");
            ElementExtensions.IsElementVisible(TextFechamento, Browser);
        }

        public void SelecionarMidias(string Midias)
        {
            if (Midias != "")
            {
                MouseActions.ClickATM(Browser, InpMidia);
                var TipoMidia = Element.Xpath("//*[@class='ng-binding ng-scope'][text()='" + Midias + "']");
                ElementExtensions.IsElementVisible(TipoMidia, Browser);
                MouseActions.ClickATM(Browser, TipoMidia);
            }
        }

        public void SelecionarDDA(string DDA)
        {
            if (DDA != "")
            {
                AutomatedActions.SendData(Browser, InpDDA, DDA);
                Thread.Sleep(2000);
                var ValidarDDA = Element.Xpath("//strong[text()='" + DDA + "']");
                MouseActions.ClickATM(Browser, ValidarDDA);
            }
        }

        public void ValidarHistorico()
        {
            MouseActions.ClickATM(Browser, BtnHistorico);
            Thread.Sleep(3000);
            var nomeUsuarioLogado = ElementExtensions.GetTexto(Element.Css("li[class='nav-header'] span:nth-child(1)"), Browser);
            var nomeUsuarioNoHistorico = ElementExtensions.GetTexto(Element.Css("div[role='tablist'] div[ng-repeat='item in ListJSON']:nth-child(1) b:nth-child(1)"), Browser);
            Assert.AreEqual(nomeUsuarioLogado, nomeUsuarioNoHistorico);

        }

        public void SelecionarProduto(string Produto)
        {
            if (Produto != "")
            {
                AutomatedActions.SendData(Browser, InpProduto, Produto);
                Thread.Sleep(3000);
                var ValidarProduto = Element.Xpath("//strong[text()='" + Produto + "']");
                MouseActions.ClickATM(Browser, ValidarProduto);
            }
        }

        public void SelecionarTipo(string Tipo)
        {
            if (Tipo != "")
            {
                if (Tipo == "Mensal")
                    MouseActions.SelectElementATMByValue(Browser, SlctTipo, "M");
                else
                    MouseActions.SelectElementATMByValue(Browser, SlctTipo, "C");

            }
        }

        public void InformarPeriodo(string Mes, string Ano)
        {
            if (Mes != " ")
            {
                Thread.Sleep(2000);
                AutomatedActions.SendData(Browser, InpPeriodo, Mes);
                Thread.Sleep(2000);
                KeyboardActions.Tab(Browser, InpPeriodo);
                Thread.Sleep(2000);
                AutomatedActions.SendData(Browser, InpPeriodo, Ano);
            }
        }

        public void PeriodoFechamento(string Mes, string Ano)
        {
            if (Mes != " ")
            {
                Thread.Sleep(2000);
                AutomatedActions.SendData(Browser, PeriFechamento, Mes);
                Thread.Sleep(2000);
                KeyboardActions.ArrowRight(Browser, PeriFechamento);
                //Thread.Sleep(2000);
                AutomatedActions.SendData(Browser, PeriFechamento, Ano);
            }
        }


        public void ValidarMensagemFechamentoInexistente(string Mensagem)
        {
            ElementExtensions.IsClickable(Element.Xpath("//div[@ng-if='loadFechamento === false']/label"), Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Xpath("//div[@ng-if='loadFechamento === false']/label"), "textContent", Browser));
        }
        

        public void DownloadRelatorioECAD()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnDownloadExcel);

            try
            {
                Thread.Sleep(9000);
                Thread.Sleep(9000);
                Assert.IsTrue(ElementExtensions.IsClickable(SlctTipo, Browser));
            }
            catch
            {
                Thread.Sleep(9000);
                Thread.Sleep(9000);
                Assert.IsTrue(ElementExtensions.IsClickable(SlctTipo, Browser));
            }

            Thread.Sleep(2000);
        }


        public void ValidarRelatorioECAD(string Programa, string DataExibicao, string Capitulo, string NomedoEpisodio,
            string Diretor, string OrdemExecucao, string TitulodaObraMusica, string TipodeMusica, string Autor, string Interprete,
            string Segundos, string Classificacao, string Compositores, string Editora, string Gravadora, string Submix, string NomePlanilha,
            string Mes, string Ano)
        {
            string teste = "Relatorio_ECAD_";
            switch (Mes)
            {
                case "Janeiro":
                    {
                        string file = teste + "01" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Fevereiro":
                    {
                        string file = teste + "02" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Março":
                    {
                        string file = teste + "03" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Abril":
                    {
                        string file = teste + "04" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Maio":
                    {
                        string file = teste + "05" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Junho":
                    {
                        string file = teste + "06" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Julho":
                    {
                        string file = teste + "07" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Agosto":
                    {
                        string file = teste + "08" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Setembro":
                    {
                        string file = teste + "09" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Outubro":
                    {
                        string file = teste + "10" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Novembro":
                    {
                        string file = teste + "11" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
                case "Dezembro":
                    {
                        string file = teste + "12" + Ano + "";
                        ValidarDownloadRelatorioECAD2(file, Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor, OrdemExecucao, TitulodaObraMusica,
                        TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, Mes, Ano);
                        break;
                    }
            }
        }

        public void ValidarDownloadRelatorioECAD2(string file, string Programa, string DataExibicao, string Capitulo, string NomedoEpisodio,
            string Diretor, string OrdemExecucao, string TitulodaObraMusica, string TipodeMusica, string Autor, string Interprete,
            string Segundos, string Classificacao, string Compositores, string Editora, string Gravadora, string Submix, string NomePlanilha,
            string Mes, string Ano)
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx";

            ValidarDadosRelatorioECAD(Programa, DataExibicao, Capitulo, NomedoEpisodio, Diretor,
            OrdemExecucao, TitulodaObraMusica, TipodeMusica, Autor, Interprete, Segundos, Classificacao, Compositores, Editora, Gravadora, Submix, NomePlanilha, file);

            File.Delete(originalFileName);
        }


        public void ValidarDadosRelatorioECAD(string Programa, string DataExibicao, string Capitulo, string NomedoEpisodio,
            string Diretor, string OrdemExecucao, string TitulodaObraMusica, string TipodeMusica, string Autor, string Interprete,
            string Segundos, string Classificacao, string Compositores, string Editora, string Gravadora, string Submix, string NomePlanilha, string file)
        {
            ExcelUtil.PopulateInCollection(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\" + file + ".xlsx", NomePlanilha);

            ValidarColuna(Programa, "PROGRAMA");
            ValidarColuna(DataExibicao, "DATA EXIBIÇÃO");
            ValidarColuna(Capitulo, "CAPÍTULO");
            ValidarColuna(NomedoEpisodio, "NOME DO EPISÓDIO");
            ValidarColuna(Diretor, "DIRETOR");
            ValidarColuna(OrdemExecucao, "ORDEM EXECUÇÃO");
            ValidarColuna(TitulodaObraMusica, "TÍTULO DA OBRA MUSICAL");
            ValidarColuna(TipodeMusica, "TIPO DE MÚSICA");
            ValidarColuna(Autor, "AUTOR");
            ValidarColuna(Interprete, "INTERPRETE");
            ValidarColuna(Segundos, "SEGUNDOS");
            ValidarColuna(Classificacao, "CLASSIFICAÇÃO");
            ValidarColuna(Compositores, "COMPOSITOR(ES) DAS TRILHAS DO PROGRAMA");
            ValidarColuna(Editora, "EDITORA");
            ValidarColuna(Gravadora, "GRAVADORA");
            ValidarColuna(Submix, "SUBMIX / TIPO DE ARRANJO");
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

        public void ValidarPDF()
        {
            Thread.Sleep(2000);
            var BtnPDF = Element.Css("a[ng-click='BaixarPDF()']");
            MouseActions.ClickATM(Browser, BtnPDF);

            Thread.Sleep(60000);

            AutoItHelper.CancelarImpressao();

            Browser.SwitchToLastWindow();
            CamposPDF();

        }

        public void CamposPDF()
        {
            var ThPrograma = Element.Xpath("//th[text()='Programa']");
            var ThData = Element.Xpath("//th[text()='Data Exibição']");
            var ThHorario = Element.Xpath("//th[text()='Horário de Exibição']");
            var ThCapitulo = Element.Xpath("//th[text()='Capítulo']");
            var ThTemporada = Element.Xpath("//th[text()='Temporada']");
            var ThNomeEpisodio = Element.Xpath("//th[text()='Nome do Episódio']");
            var ThProdutor = Element.Xpath("//th[text()='Produtor']");
            var ThDiretor = Element.Xpath("//th[text()='Diretor']");
            var ThOrdemExecucao = Element.Xpath("//th[text()='Ordem Execução']");
            var ThTituloObra = Element.Xpath("//th[text()='Título da Obra Musical']");
            var ThTipoMusica = Element.Xpath("//th[text()='Tipo de Música']");
            var ThAutor = Element.Xpath("//th[text()='Autor']");
            var ThInterprete = Element.Xpath("//th[text()='Interprete']");
            var ThSegundos = Element.Xpath("//th[text()='Segundos']");
            var ThClassificao = Element.Xpath("//th[text()='Classificação']");
            var ThCompositor = Element.Xpath("//th[text()='Compositor(es) das trilhas do Programa']");
            var ThEditora = Element.Xpath("//th[text()='Editora']");
            var ThGravadora = Element.Xpath("//th[text()='Gravadora']");
            var ThISRC = Element.Xpath("//th[text()='ISRC']");
            var ThSubmix = Element.Xpath("//th[text()='Submix / Tipo de Arranjo']");


            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThPrograma, Browser);
            ElementExtensions.IsElementVisible(ThData, Browser);
            ElementExtensions.IsElementVisible(ThHorario, Browser);
            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThCapitulo, Browser);
            ElementExtensions.IsElementVisible(ThTemporada, Browser);
            ElementExtensions.IsElementVisible(ThNomeEpisodio, Browser);
            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThProdutor, Browser);
            ElementExtensions.IsElementVisible(ThDiretor, Browser);
            ElementExtensions.IsElementVisible(ThOrdemExecucao, Browser);
            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThTituloObra, Browser);
            ElementExtensions.IsElementVisible(ThTipoMusica, Browser);
            ElementExtensions.IsElementVisible(ThAutor, Browser);
            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThInterprete, Browser);
            ElementExtensions.IsElementVisible(ThSegundos, Browser);
            ElementExtensions.IsElementVisible(ThClassificao, Browser);
            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThCompositor, Browser);
            ElementExtensions.IsElementVisible(ThEditora, Browser);
            ElementExtensions.IsElementVisible(ThGravadora, Browser);
            Thread.Sleep(1000);
            ElementExtensions.IsElementVisible(ThISRC, Browser);
            ElementExtensions.IsElementVisible(ThSubmix, Browser);
        }
    }
}

