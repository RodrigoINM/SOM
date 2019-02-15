using Framework.Core.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System.Threading;
using System.Windows.Forms;
using SOM.BDD.Helpers;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace SOM.BDD.Pages.Obra.Catálogo_de_Editoras
{
    public class CatálogodeEditoraPage : PageBase
    {
        public CatálogodeEditoraPage(IBrowser browser, string catalogoEditorasUrl) : base(browser)
        {
            CatalogoEditorasUrl = catalogoEditorasUrl;

            InpArquivo = Element.Css("input[id='arquivo']");
            ElementeMensagem = Element.Css("div[class='ng-binding ng-scope']");
        }

        public string CatalogoEditorasUrl { get; private set; }
        public Element InpArquivo { get; private set; }
        public CatálogodeEditoraPage TelaCatálogodeEditoraPage { get; private set; }
        public Element ElementeMensagem { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(CatalogoEditorasUrl);
        }

        public void RealizarUploadDeArquivo(string Arquivo)
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpArquivo);
            Thread.Sleep(2000);
            SendKeys.SendWait(GetPath.GetResourcePath(Arquivo));
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(2000);
            var SalvarUpload = Element.Css("a[ng-click='upload()']");
            ElementExtensions.IsElementVisible(SalvarUpload, Browser);
            MouseActions.ClickATM(Browser, SalvarUpload);
        }

        public void BaixarAquivoVazio()
        {
            Thread.Sleep(2000);
            var SalvarUpload = Element.Css("a[ng-click='upload()']");
            ElementExtensions.IsElementVisible(SalvarUpload, Browser);
            MouseActions.ClickATM(Browser, SalvarUpload);
        }

        public void CancelarUpload()
        {
            Thread.Sleep(2000);
            var Cancelar = Element.Css("a[uib-tooltip='Cancelar']");
            MouseActions.ClickATM(Browser, Cancelar);
            Thread.Sleep(2000);
            var ConFimrCancelar = Element.Xpath("//h2[text()='Deseja cancelar?']/..//button[@class='confirm']");
            MouseActions.ClickATM(Browser, ConFimrCancelar);

        }

        public void ValidarGrid(string Linha, string Titulo, string Composicao, string Nacionalidade, string DominioPublico, string Tipo)
        {
            var Linhagrid = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemSucesso'] th:nth-child(1)");
            var Titulogrid = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemSucesso'] th:nth-child(2)");
            var Composicaogrid = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemSucesso'] th:nth-child(3)");
            var Nacionalidadegrid = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemSucesso'] th:nth-child(4)");
            var DominioPublicgrid = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemSucesso'] th:nth-child(5)");
            var Tipogrid = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemSucesso'] th:nth-child(6)");

            Assert.AreEqual(Linha, Linhagrid.GetTexto(Browser));
            Thread.Sleep(2000);
            Assert.AreEqual(Titulo, Titulogrid.GetTexto(Browser));
            Thread.Sleep(2000);
            Assert.AreEqual(Composicao, Composicaogrid.GetTexto(Browser));
            Thread.Sleep(2000);
            Assert.AreEqual(Nacionalidade, Nacionalidadegrid.GetTexto(Browser));
            Thread.Sleep(2000);
            Assert.AreEqual(DominioPublico, DominioPublicgrid.GetTexto(Browser));
            Thread.Sleep(2000);
            Assert.AreEqual(Tipo, Tipogrid.GetTexto(Browser));
        }

        public void Importar()
        {
            var BtnImportacao = Element.Css("a[ng-click='importar()']");
            MouseActions.ClickATM(Browser, BtnImportacao);
        }

        public void ValidarMsg(string MensagemDeAlteração)
        {
            Assert.AreEqual(MensagemDeAlteração, ElementExtensions.GetValorAtributo(ElementeMensagem, "textContent", Browser));
            Thread.Sleep(2000);
        }

        public void AquivoInvalido(string Mensagem)
        {
            var textAlerta = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(textAlerta, "textContent", Browser));
        }

        public void ValidarAutorinexixtente(string Autor)
        {
            var AutorInexistente = Element.Css("tr[ng-repeat='item in ImportacaoJornalismo.ItemErro']:nth-child(1) th:nth-child(7)");
            var InpItensValidos = Element.Xpath("//a/uib-tab-heading[text()='Itens inválidos']");

            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpItensValidos);
            Thread.Sleep(2000);
            Assert.AreEqual(Autor, AutorInexistente.GetTexto(Browser));
        }

        public void BaixarTeplate()
        {
            Thread.Sleep(2000);
            var Template = Element.Css("a[href='TEMPLATE.xlsx']");
            MouseActions.ClickATM(Browser, Template);
        }

        public void CaminhoRelatorioParaExclusao()
        {
            Thread.Sleep(2000);
            string originalFileName = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\TEMPLATE.xlsx";

            File.Delete(originalFileName);
        }


    }
}
