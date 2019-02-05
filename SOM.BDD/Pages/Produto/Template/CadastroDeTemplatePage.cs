using Framework.Core.PageObjects;
using System;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.Helpers;
using SOM.BDD.Pages.Obra;

namespace SOM.BDD.Pages.Produto.Template
{
    public class CadastroDeTemplatePage : PageBase
    {
        public Element BtnCadastrarItemTemplate { get; private set; }
        public Element InpOrdem { get; private set; }
        public Element BtnCadastrarInterprete { get; private set; }
        public Element BtnOpenObraFonograma { get; private set; }
        public Element InpGravadora { get; private set; }
        public Element InpSubmix { get; private set; }
        public Element InpTituloObra { get; private set; }
        public Element InpTempo { get; private set; }
        public Element InpNomeInterprete { get; private set; }
        public Element BtnSalvarCadastroDeInterprete { get; private set; }
        public Element BtnSalvarItemTemplate { get; private set; }
        public Element SlctUtilizacao { get; private set; }
        public Element SlctSincronismo { get; private set; }
        public Element TxtObservacao { get; private set; }

        //Pop up mensagem de status
        public Element PopUpStatus { get; private set; }

        //Cadastro de Materia e Bloco
        public Element BtnCriarMateriaBloco { get; private set; }
        public Element InpBlocoMateria { get; private set; }
        public Element BtnSalvarMateriaBloco { get; private set; }
        
        //Excluir Item de Template
        public Element BtnExcluirItemTemplate { get; private set; }
        public Element BtnExcluirMateria { get; private set; }
        public Element BtnExcluirBloco { get; private set; }

        public CadastroDeTemplatePage(IBrowser browser) : base(browser)
        {
            BtnCadastrarItemTemplate = Element.Css("i[ng-click='OpenCadastrarItemModal()']");
            InpOrdem = Element.Css("input[id='ordem']");
            BtnCadastrarInterprete = Element.Css("button[ng-click='CadastrarInterprete()']");
            BtnOpenObraFonograma = Element.Css("button[ng-click='OpenObraFonogramaModal()']");
            InpGravadora = Element.Css("input[ng-model='ItemTemplateDados.RecordCompanyDescription']");
            InpSubmix = Element.Css("input[ng-model='ItemTemplateDados.Submix']");
            InpTituloObra = Element.Css("input[ng-model='ItemTemplateDados.TituloObra']");
            InpTempo = Element.Css("input[id='tempo']");
            InpNomeInterprete = Element.Css("input[ng-model='Interprete.Nome']");
            BtnSalvarCadastroDeInterprete = Element.Css("button[ng-click='cadastrarInterprete()']");
            BtnSalvarItemTemplate = Element.Css("a[ng-click='salvarItemTemplate()']");
            SlctUtilizacao = Element.Css("div[ng-model='ItemTemplateDados.TipoUtilizacaoSelected'] i[class='caret pull-right']");
            SlctSincronismo = Element.Css("div[ng-model='ItemTemplateDados.TipoSincronismoSelected'] i[class='caret pull-right']");
            TxtObservacao = Element.Css("textarea[ng-model='ItemTemplateDados.Observacao']");

            //Pop up mensagem de status
            PopUpStatus = Element.Css("div[class='ng-binding ng-scope']");

            //Cadastro de Materia e Bloco
            BtnCriarMateriaBloco = Element.Css("i[ng-click='CriarMateriaBloco()']");
            InpBlocoMateria = Element.Css("input[ng-model='BlocoMateriaDados.Nome']");
            BtnSalvarMateriaBloco = Element.Css("button[ng-click='criarBlocoMateria()']");

            //Excluir Item de Template
            BtnExcluirItemTemplate = Element.Css("i[class='fa fa-times pull-right excluiritemtemplate']");
            BtnExcluirMateria = Element.Css("a[uib-tooltip='Excluir matéria']");
            BtnExcluirBloco = Element.Css("a[uib-tooltip='Excluir bloco']");
        }

        public override void Navegar()
        {
            throw new NotImplementedException();
        }

        public void CadastrarItemDeTemplateEmBranco()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnCadastrarItemTemplate);

            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemTemplate, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemTemplate);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemTemplate, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemTemplate);
            }
        }

        public void CadastrarTemplateComInterpreteExistente(string Ordem, string TituloObra, string Interprete, string Utilizacao, string Sincronismo, string Tempo, string Gravadora, string Submix, string Obs)
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnCadastrarItemTemplate);

            AutomatedActions.SendDataATM(Browser, InpOrdem, Ordem);
            AutomatedActions.SendData(Browser, InpTituloObra, TituloObra);
            PreencherObra(TituloObra);
            SelecionarUtilizacao(Utilizacao);
            SelecionarSincronismo(Sincronismo);
            AutomatedActions.SendData(Browser, InpTempo, Tempo);
            AutomatedActions.SendDataATM(Browser, InpGravadora, Gravadora);
            AutomatedActions.SendDataATM(Browser, InpSubmix, Submix);
            AutomatedActions.SendDataATM(Browser, TxtObservacao, Obs);

            
            MouseActions.ClickATM(Browser, BtnCadastrarInterprete);
            AutomatedActions.SendDataATM(Browser, InpNomeInterprete, Interprete);
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeInterprete);
            Thread.Sleep(2000);
        }

        public void AbrirItemTemplate(string Valor)
        {
            var textoItemTemplate = Element.Xpath("//tbody//td[contains(., '" + Valor + "')]");
            MouseActions.DoubleClickATM(Browser, textoItemTemplate);
        }

        public void AlterarItemTemplate(string Ordem, string TituloObra, string Interprete, 
            string Utilizacao, string Sincronismo, string Tempo, string Gravadora, string Submix, string Obs)
        {
            PreencherDadosTemplate(Ordem, TituloObra, Interprete,
            Utilizacao, Sincronismo, Tempo, Gravadora, Submix, Obs);
            SalvarItemTemplate();
        }

        public void CadastrarItemTemplate(string Ordem, string TituloObra, string Interprete, 
            string Utilizacao, string Sincronismo, string Tempo, string Gravadora, string Submix, string Obs)
        {
            Thread.Sleep(2000);
            try
            {
                MouseActions.ClickATM(Browser, BtnCadastrarItemTemplate);
            }
            catch
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnCadastrarItemTemplate);
            }
            PreencherDadosTemplate(Ordem, TituloObra, Interprete, Utilizacao, Sincronismo, Tempo, Gravadora, Submix, Obs);
            SalvarItemTemplate();

            Thread.Sleep(2000);
        }

        private void SalvarItemTemplate()
        {
            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemTemplate, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemTemplate);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarItemTemplate, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarItemTemplate);
            }
        }

        private void PreencherDadosTemplate(string Ordem, string TituloObra, string Interprete, string Utilizacao, string Sincronismo, string Tempo, string Gravadora, string Submix, string Obs)
        {
            if (Ordem != "" && Ordem != " ")
                AutomatedActions.SendDataATM(Browser, InpOrdem, Ordem);
            PreencherObra(TituloObra);
            if (Utilizacao != "" && Utilizacao != " ")
                SelecionarUtilizacao(Utilizacao);
            if (Sincronismo != "" && Sincronismo != " ")
                SelecionarSincronismo(Sincronismo);
            if (Tempo != "" && Tempo != " ")
                AutomatedActions.SendData(Browser, InpTempo, Tempo);
            if (Gravadora != "" && Gravadora != " ")
                AutomatedActions.SendDataATM(Browser, InpGravadora, Gravadora);
            if (Submix != "" && Submix != " ")
                AutomatedActions.SendDataATM(Browser, InpSubmix, Submix);
            if (Obs != "" && Obs != " ")
                AutomatedActions.SendDataATM(Browser, TxtObservacao, Obs);
            if (Interprete != "" && Interprete != " ")
                CadastrarInterprete(Interprete);
        }

        private void PreencherObra(string TituloObra)
        {
            if (TituloObra != "" && TituloObra != " ")
            {
                if (TituloObra == "Aleatório")
                {
                    AutomatedActions.SendDataATM(Browser, InpTituloObra, CadastrarObraEComposicaoPage.Obra);
                    SelecionarObraFonograma("", CadastrarObraEComposicaoPage.Obra);
                }
                else
                {
                    AutomatedActions.SendDataATM(Browser, InpTituloObra, TituloObra);
                    SelecionarObraFonograma("", TituloObra);
                }
            }
        }

        private void CadastrarInterprete(string Interprete)
        {
            if(Interprete == "Aleatório")
            {
                MouseActions.ClickATM(Browser, BtnCadastrarInterprete);
                AutomatedActions.SendDataATM(Browser, InpNomeInterprete, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
                MouseActions.ClickATM(Browser, BtnSalvarCadastroDeInterprete);
                Thread.Sleep(2000);
            }
            else
            {
                var InpInterprete = Element.Css("div[id='performersMulti_chosen'] input[id='novoAutoComplete']");
                MouseActions.ClickATM(Browser, InpInterprete);
                AutomatedActions.SendData(Browser, InpInterprete, Interprete);
                try
                {
                    ElementExtensions.IsElementVisible(Element.Css("div[class='chosen-drop']"), Browser);
                    Thread.Sleep(2000);
                    MouseActions.DoubleClickATM(Browser, Element.Css("div[class='chosen-drop']"));
                }
                catch
                {
                    MouseActions.ClickATM(Browser, InpInterprete);
                    AutomatedActions.SendData(Browser, InpInterprete, Interprete);
                    ElementExtensions.IsElementVisible(Element.Xpath("//li[contains(., '" + Interprete + "')]"), Browser);
                    Thread.Sleep(2000);
                    MouseActions.DoubleClickATM(Browser, Element.Xpath("//li[contains(., '" + Interprete + "')]"));
                }
            }

            try
            {
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
            }
            catch
            {
                Thread.Sleep(2000);
                var interprete = Element.Css("li[class='search-choice']");
                ElementExtensions.IsElementVisible(interprete, Browser);
            }
        }

        public void ValidarPopupCadastroDeTemplateComSucesso()
        {
            Assert.IsTrue(ElementExtensions.IsElementVisible(PopUpStatus, Browser));
        }

        private void SelecionarObraFonograma(string Fonograma, string TituloObra)
        {
            MouseActions.ClickATM(Browser, BtnOpenObraFonograma);
            if (Fonograma != "")
                MouseActions.DoubleClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarFonograma(item)']/td[text()='" + Fonograma + "']"));
            if (TituloObra != "")
                MouseActions.DoubleClickATM(Browser, Element.Xpath("//tr[@ng-click='selecionarObra(item)']/td[text()='" + TituloObra + "']"));
        }

        private void SelecionarUtilizacao(string Utilizacao)
        {
            MouseActions.ClickATM(Browser, SlctUtilizacao);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/div[text()='" + Utilizacao + "']"));
        }

        private void SelecionarSincronismo(string Sincronismo)
        {
            MouseActions.ClickATM(Browser, SlctSincronismo);
            MouseActions.ClickATM(Browser, Element.Xpath("//a/div[text()='" + Sincronismo + "']"));
        }

        public void SelecionarItemTemplate(string Valor)
        {
            Thread.Sleep(2000);
            var slctItem = Element.Xpath("//tbody[@dnd-list='ListTemplateDragDrop.lists']//td[contains(., '" + Valor + "')]");
            try
            {
                ElementExtensions.IsElementVisible(slctItem, Browser);
                MouseActions.ClickATM(Browser, slctItem);
            }
            catch
            {
                ElementExtensions.IsElementVisible(slctItem, Browser);
                MouseActions.ClickATM(Browser, slctItem);
            }
        }

        public void CriarNovaMateria()
        {
            Thread.Sleep(2000);
            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsClickable(BtnCriarMateriaBloco, Browser);
                MouseActions.ClickATM(Browser, BtnCriarMateriaBloco);
            }
            catch
            {
                ElementExtensions.IsClickable(BtnCriarMateriaBloco, Browser);
                MouseActions.ClickATM(Browser, BtnCriarMateriaBloco);
            }
        }

        public void IncluirTemplateEmBlocoMateriaExistente(string Titulo, string Titulo2)
        {
            Thread.Sleep(2000);
            var slctItem1 = Element.Xpath("//tbody[@dnd-list='ListTemplateDragDrop.lists']//td[contains(., '" + Titulo + "')]");
            var slctItem2 = Element.Xpath("//tbody[@dnd-list='ListTemplateDragDrop.lists']//td[contains(., '" + Titulo2 + "')]");

            MouseActions.MouseDragAndDropSML(Browser, slctItem1, slctItem2);
        }

        public void ValidarPopup(string Mensagem)
        {
            Thread.Sleep(2000);
            var textoPopup = Element.Css("div[class='ng-binding ng-scope']");
            var validarMensagem = ElementExtensions.GetTexto(textoPopup, Browser);
            Assert.AreEqual(Mensagem, validarMensagem);
        }

        public void ValidarMensagem(string Mensagem)
        {
            Thread.Sleep(2000);
            var textoPopup = Element.Css("p[style='display: block;']");
            var validarMensagem = ElementExtensions.GetTexto(textoPopup, Browser);
            Assert.AreEqual(Mensagem, validarMensagem);
        }

        public void CriarBlocoMateria(string BlocoMateria)
        {
            ElementExtensions.IsClickable(BtnCriarMateriaBloco, Browser);
            MouseActions.ClickATM(Browser, BtnCriarMateriaBloco);

            AutomatedActions.SendDataATM(Browser, InpBlocoMateria, BlocoMateria);
            MouseActions.ClickATM(Browser, BtnSalvarMateriaBloco);
        }

        public void ValidarBlocoMateriaCriado(string BlocoMateria)
        {
            var nomeBlocoMateria = Element.Xpath("//h4//span[contains(., '" + BlocoMateria + "')]");
            ElementExtensions.IsElementVisible(nomeBlocoMateria, Browser);
        }

        public void ValidarObraDeTemplate(string TituloObra)
        {
            if (TituloObra == "Aleatório")
                ValidarItemTemplate(CadastrarObraEComposicaoPage.Obra);
            else
                ValidarItemTemplate(TituloObra);
        }

        public void ValidarItemTemplate(string Valor)
        {
            var textoTemplate = Element.Xpath("//td[contains(., '" + Valor + "')]");
            try
            {
                ElementExtensions.IsElementVisible(textoTemplate, Browser);
            }
            catch
            {
                ElementExtensions.IsElementVisible(textoTemplate, Browser);
            }
        }

        public void ValidarCamposObrigatoriosEmDestaque(string Valor)
        {
            try
            {
                var textoCampo = Element.Xpath("//div[@class='has-error']//label[contains(., '" + Valor + "')]");
                ElementExtensions.IsElementVisible(textoCampo, Browser);
            }
            catch
            {
                var textoCampo = Element.Xpath("//div[@class='has-error']//label[contains(., '" + Valor + "')]");
                ElementExtensions.IsElementVisible(textoCampo, Browser);
            }
        }

        public void CancelarAlteracaoDeTemplate()
        {
            var BtnCancelar = Element.Css("a[ng-click='cancelar()']");
            ElementExtensions.IsElementVisible(BtnCancelar, Browser);
            MouseActions.ClickATM(Browser, BtnCancelar);
        }

        public void CancelarCriacaoDeTemplate()
        {
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnCadastrarItemTemplate);

            var BtnCancelar = Element.Css("a[ng-click='cancelar()']");
            ElementExtensions.IsElementVisible(BtnCancelar, Browser);
            MouseActions.ClickATM(Browser, BtnCancelar);
        }

        public void ValidarCancelamentoDeItemDeTemplate()
        {
            var listaVazia = Element.Css("tbody[dnd-list='ListTemplateDragDrop.lists']");
            ElementExtensions.IsElementVisible(listaVazia, Browser);
        }

        public void ExcluirItemDeTemplate()
        {
            ElementExtensions.IsElementVisible(BtnExcluirItemTemplate, Browser);
            MouseActions.ClickATM(Browser, BtnExcluirItemTemplate);
        }

        public void ExcluirMateriaEBloco(string MateriaOuBloco, string Mensagem, string ConfirmarExclusao)
        {
            if(MateriaOuBloco == "Materia")
            {
                ElementExtensions.IsElementVisible(BtnExcluirMateria, Browser);
                MouseActions.ClickATM(Browser, BtnExcluirMateria);
            }
            if (MateriaOuBloco == "Bloco")
            {
                ElementExtensions.IsElementVisible(BtnExcluirBloco, Browser);
                MouseActions.ClickATM(Browser, BtnExcluirBloco);
            }

            ValidarMensagem(Mensagem);

            var BtnConfirmarExclusao = Element.Css("button[class='confirm']");
            var BtnCancelarExclusao = Element.Css("button[class='cancel']");

            if(ConfirmarExclusao == "Sim")
            {
                ElementExtensions.IsElementVisible(BtnConfirmarExclusao, Browser);
                MouseActions.ClickATM(Browser, BtnConfirmarExclusao);
            }
            else
            {
                ElementExtensions.IsElementVisible(BtnCancelarExclusao, Browser);
                MouseActions.ClickATM(Browser, BtnCancelarExclusao);
            }
        }

        
    }
}
