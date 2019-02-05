using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Threading;

namespace SOM.BDD.Pages.Obra
{
    public class ExcluirObraPage : PageBase
    {
        public CadastrarObraEComposicaoPage TelaCadastrarObraEComposicaoPage { get; set; }

        //Excluir Obra
        private Element BtnConfirmarExclusao { get; set; }

        public ExcluirObraPage(IBrowser browser) : base(browser)
        {
            //Excluir Obra
            BtnConfirmarExclusao = Element.Xpath("//h2[text()='Deseja excluir?']/..//button[@class='confirm']");
        }

        public override void Navegar()
        {
            throw new NotImplementedException();
        }


        public void ExcluirObra(string Nome)
        {
            string nomeObraExcluir = "//table[@dt-columns='dtColumns']//div[text()='" + Nome + "']/../..//div[@uib-tooltip='Excluir']";
            MouseActions.ClickATM(Browser, Element.Xpath(nomeObraExcluir));
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            Thread.Sleep(1500);
        }

        public void ValidarExclusaoDeObra(string Nome, string Mensagem)
        {
            string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
            ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css(popUpSucesso), "textContent", Browser));

            string caminhoElemento = "//table[@dt-columns='dtColumns']//*[text()='" + Nome + "']";
            try
            {
                ElementExtensions.IsElementVisible(Element.Xpath("//table[@dt-columns='dtColumns']//*[text()='Dados não encontratos']"), Browser);
            }
            catch
            {
                ElementExtensions.IsElementVisible(Element.Xpath(caminhoElemento), Browser);
            }
        }

        public void ExcluirObraRandomica(string Obra)
        {
            if(Obra != "" && Obra != " ")
            {
                Obra = CadastrarObraEComposicaoPage.Obra;
                Thread.Sleep(2000);
                ExcluirObra(Obra);
                ValidarExclusaoDeObra(Obra, "Registro excluído com sucesso.");
            }
            else
            {
                Thread.Sleep(2000);
                ExcluirObra(Obra);
                ValidarExclusaoDeObra(Obra, "Registro excluído com sucesso.");
            }
        }

        public void ExclusaoDeObra(string Nome, string Mensagem)
        {
            ExcluirObra(Nome);
            ValidarExclusaoDeObra(Nome, Mensagem);
        }

    }
}
