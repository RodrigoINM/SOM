using Framework.Core.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;

namespace SOM.BDD.Pages.Obra.DDA
{
    public class ExclusaoDeDDAPage : PageBase
    {
        //Exclusao de DDA
        private Element BtnConfirmarExclusao { get; set; }
        public Element BtnCancelarExclusao { get; private set; }
        public Element BtnExcluirEndereco { get; private set; }
        public Element BtnExcluirContato { get; private set; }

        public ExclusaoDeDDAPage(IBrowser browser) : base(browser)
        {
            //Exclusao de DDA
            BtnConfirmarExclusao = Element.Xpath("//h2[text()='Deseja excluir?']/..//button[@class='confirm']");
            BtnCancelarExclusao = Element.Css("button[class='cancel']");
            BtnExcluirEndereco = Element.Css("span[ng-click='excluirEnderecos(item, false)'] i");
            BtnExcluirContato = Element.Css("span[ng-click='excluirContatos(item, false)'] i");
        }

        public override void Navegar()
        {
            throw new NotImplementedException();
        }

        public void ExcluirCadastroDDA(string NomeFantasia)
        {
            //string nomeDDAExcluir = "//table[@id='DataTables_Table_0']//div[text()='" + NomeFantasia + "']/../..//div[@uib-tooltip='Excluir']";
            string nomeDDAExcluir = "//table//div[text()='" + NomeFantasia + "']/../..//div[@uib-tooltip='Excluir']";
            MouseActions.ClickATM(Browser, Element.Xpath(nomeDDAExcluir));
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            Thread.Sleep(1500);
        }

        public void CancelarExclusaoDDA(string NomeFantasia)
        {
            string nomeDDAExcluir = "//table[@id='DataTables_Table_0']//div[text()='" + NomeFantasia + "']/../..//div[@uib-tooltip='Excluir']";
            MouseActions.ClickATM(Browser, Element.Xpath(nomeDDAExcluir));
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnCancelarExclusao);
            Thread.Sleep(1500);
        }

        public void ExcluirEnderecoDeDDA()
        {
            MouseActions.ClickATM(Browser, BtnExcluirEndereco);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
        }

        public void ExcluirContatoDeDDA()
        {
            MouseActions.ClickATM(Browser, BtnExcluirContato);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
        }

        public void ValidarExclusaoDeDDA(string NomeFantasia)
        {
            string nomeFantasia = "//table[@id='DataTables_Table_0']//div[text()='" + NomeFantasia + "']";
            ElementExtensions.IsNotElementVisible(Element.Xpath(nomeFantasia), Browser);
        }

        public void ValidarPopUpExclusaoDDASucesso(string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));
        }

    }
}
