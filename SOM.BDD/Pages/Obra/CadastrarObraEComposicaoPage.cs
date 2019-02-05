using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using Framework.Core.Extensions.ElementExtensions;
using System;
using System.Threading;
using Framework.Core.Helpers;
using SOM.BDD.Pages.Produto;

namespace SOM.BDD.Pages.Obra
{
    public class CadastrarObraEComposicaoPage : PageBase
    {
        private string CadastroObraUrl { get; }

        public CadastroDeProdutoPage TelaCadastroDeProdutoPage { get; private set; }

        private string PageTitle => "SOM | Cadastro de Obra";

        //Cadastro de Obra
        public Element InpTituloObra { get; private set; }
        public Element InpSubTitulo { get; private set; }
        public Element RdNacional { get; private set; }
        public Element RdInternacional { get; private set; }
        public Element InpTituloAlternativo { get; private set; }
        public Element InpIswc { get; private set; }
        public Element SlctTipo { get; private set; }
        public Element SlctAno { get; private set; }
        public Element SlctPais { get; private set; }
        public Element ChckDominioPublico { get; private set; }
        public Element ChckInstitucional { get; private set; }
        public Element ChckBlackList { get; private set; }
        public Element ChckEmblematica { get; private set; }
        public Element BtnSalvarObra { get; private set; }
        public Element BtnSalvarObraEComposicao { get; private set; }
        public Element BtnEditarObra { get; private set; }
        public Element BtnConfirmar { get; private set; }

        //Cadastro de composição
        public Element BtnAdicionarComposicao { get; private set; }
        public Element InpAutor { get; private set; }
        public Element InpDDA { get; private set; }
        public Element InpPercentual { get; private set; }
        public Element BtnAdicionarCompositor { get; private set; }

        //Cadastrar autor
        public Element BtnCadastrarAutor { get; private set; }
        public Element InpNomeArtistico { get; private set; }
        public Element InpNomeCompletoAutor { get; private set; }
        public Element BtnShowContatos { get; private set; }
        public Element InpNomeContato { get; private set; }
        public Element SlctTipoContatoAutor { get; private set; }
        public Element InpValorContatoAutor { get; private set; }
        public Element BtnAdicionarItemContato { get; private set; }
        public Element BtnSalvarContatoAutor { get; private set; }
        public Element BtnSalvarCadastroDeAutor { get; private set; }
        public Element InpDataInicioContratacao { get; private set; }
        public Element InpDataFimContratacao { get; private set; }

        //Cadastrar DDA
        public Element BtnCadastrarDDA { get; private set; }
        public Element InpNomeFantasia { get; private set; }
        public Element InpNomeCompleto { get; private set; }
        public Element InpCPF { get; private set; }
        public Element SlctAssociacaoDDA { get; private set; }
        public Element ChckAdministrador { get; private set; }
        public Element InpDataNascimento { get; private set; }
        public Element BtnSalvarDDA { get; private set; }
        public Element BtnAddDDAOriginal { get; private set; }

        //Elementos cadastro de contato de DDA
        public Element BtnShowCamposContato { get; private set; }
        public Element InpNomeContatoDDA { get; private set; }
        public Element TextAreaObservacao { get; private set; }
        public Element InpTipoContato { get; private set; }
        public Element SlctTipoContato { get; private set; }
        public Element ChckRecebeAutorizacao { get; private set; }
        public Element BtnAdicionarContatoDDA { get; private set; }
        public Element BtnSalvarContatoDDA { get; private set; }

        public CadastrarObraEComposicaoPage(IBrowser browser, string cadastroObraUrl) : base(browser)
        {
            CadastroObraUrl = cadastroObraUrl;

            //Cadastro de Obra
            InpTituloObra = Element.Css("input[ng-model='ObraDados.Titulo']");
            InpSubTitulo = Element.Css("input[ng-model='ObraDados.SubTitulo']");
            RdNacional = Element.Css("input[id='optionsRadios1']");
            RdInternacional = Element.Css("input[id='optionsRadios2']");
            InpTituloAlternativo = Element.Css("div[class='col-md-4 ObraCad'] input");
            InpIswc = Element.Css("input[ng-model='ObraDados.ISWC']");
            SlctTipo = Element.Css("div[ng-model='ObraDados.TipoObras.selected'] i[class='caret pull-right']");
            SlctAno = Element.Css("div[ng-model='ObraDados.AnoS.selected'] i[class='caret pull-right']");
            SlctPais = Element.Css("div[ng-model='ObraDados.PaisS.selected'] i[class='caret pull-right']");
            ChckDominioPublico = Element.Css("input[id='dominioPublicoId']");
            ChckInstitucional = Element.Css("input[id='institucionalId']");
            ChckBlackList = Element.Css("input[id='blacklistId']");
            ChckEmblematica = Element.Css("input[id='emblematicaId']");
            BtnSalvarObra = Element.Css("a[uib-tooltip='Salvar']");
            BtnSalvarObraEComposicao = Element.Css("a[ng-click='VerificaSeExisteAlteracaoComposicao(ObraDados)']");
            BtnEditarObra = Element.Css("a[uib-tooltip='Editar obra']");
            BtnConfirmar = Element.Css("button[class='confirm']");

            //Cadastro de composição
            BtnAdicionarComposicao = Element.Css("i[ng-click='ModalComposicao(false)']");
            InpAutor = Element.Css("input[ng-model='DscAutor']");
            InpDDA = Element.Css("input[ng-model='DscDDA']");
            InpPercentual = Element.Css("input[ng-model='ComposicaoObraDados.PercentualAutoral']");
            BtnAdicionarCompositor = Element.Css("a[ng-click='adicionarComposicao()']");

            //Cadastrar autor
            BtnCadastrarAutor = Element.Css("div[ng-click='showModalAutor()']");
            InpNomeArtistico = Element.Css("input[ng-model='AutorDados.NomeArtistico']");
            InpNomeCompletoAutor = Element.Css("input[ng-model='AutorDados.NomeCompleto']");
            BtnShowContatos = Element.Xpath("//h5[text()='Contatos']/..//a");
            InpNomeContato = Element.Css("input[ng-model='Contato.Nome']");
            SlctTipoContatoAutor = Element.Css("select[ng-model='Contato.ItemContato.TipoContato.selected']");
            InpValorContatoAutor = Element.Css("input[ng-model='Contato.ItemContato.Valor']");
            BtnAdicionarItemContato = Element.Css("div[ng-click='adicionarItemContato(false)']");
            BtnSalvarContatoAutor = Element.Css("a[ng-click='salvarContato(false)']");
            BtnSalvarCadastroDeAutor = Element.Css("a[ng-click='salvarAutor(false, false)']");
            InpDataInicioContratacao = Element.Css("input[ng-model='AutorDados.DataContratacao']");
            InpDataFimContratacao = Element.Css("input[ng-model='AutorDados.DataContratacaoFim']");

            //Cadastrar DDA
            BtnCadastrarDDA = Element.Css("div[ng-click='showModalDDA()']");
            InpNomeFantasia = Element.Css("input[ng-model='DDADados.Nome']");
            InpNomeCompleto = Element.Css("input[ng-model='DDADados.RazaoSocial']");
            InpCPF = Element.Css("input[ng-model='DDADados.NumeroDocumento']");
            SlctAssociacaoDDA = Element.Css("select[ng-model='DDADados.Associacao']");
            ChckAdministrador = Element.Css("div[class='onoffswitch'] label[for='grupoEditorialId']");
            InpDataNascimento = Element.Css("input[ng-model='DDADados.DataNascimento']");
            BtnSalvarDDA = Element.Css("a[ng-click='salvarDDA(false, true)']");
            BtnAddDDAOriginal = Element.Css("div[ng-click='showModalDDAOriginal()']");

            //Elementos cadastro de contato de DDA
            BtnShowCamposContato = Element.Xpath("//h5[text()='Contatos']/..//a");
            InpNomeContatoDDA = Element.Xpath("//h5[text()='Contatos']/../..//input[@ng-model='Contato.Nome']");
            TextAreaObservacao = Element.Xpath("//h5[text()='Contatos']/../..//textarea[@ng-model='Contato.Observacao']");
            InpTipoContato = Element.Xpath("//h5[text()='Contatos']/../..//input[@ng-model='Contato.ItemContato.Valor']");
            SlctTipoContato = Element.Xpath("//h5[text()='Contatos']/../..//select[@ng-model='Contato.ItemContato.TipoContato.selected']");
            ChckRecebeAutorizacao = Element.Css("div[class='onoffswitch'] label[for='FalecidoDominioPublicoId']");
            BtnAdicionarContatoDDA = Element.Css("div[ng-click='adicionarItemContato(false)'] i");
            BtnSalvarContatoDDA = Element.Css("a[ng-click='salvarContato(false)']");
        }

        public static string Obra { get; set; }

        public string ObraCadastrado
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr(); }
        }
        
        public string GetObra()
        {
            return Obra;
        }

        private void SetObra(string nome)
        {
            Obra = nome;
        }

        public static string Autor { get; set; }

        public string AutorCadastrado
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr(); }
        }

        public string GetAutor()
        {
            return Autor;
        }

        private void SetAutor(string nome)
        {
            Autor = nome;
        }

        public static string Autor2 { get; set; }

        public string AutorCadastrado2
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr(); }
        }

        public string GetAutor2()
        {
            return Autor2;
        }

        private void SetAutor2(string nome)
        {
            Autor2 = nome;
        }

        public override void Navegar()
        {
            try
            {
                Browser.Abrir(CadastroObraUrl);
                Assert.IsTrue(Browser.PageSource(PageTitle));
            }
            catch
            {
                Browser.Abrir(CadastroObraUrl);
                Assert.IsTrue(Browser.PageSource(PageTitle));
            }
            
        }

        private void SelecionarTipoObra(string Valor)
        {
            MouseActions.ClickATM(Browser, SlctTipo);
            MouseActions.ClickATM(Browser, Element.Xpath("//div[text()='" + Valor + "']"));
        }

        private void SelecionarAnoObra(string Valor)
        {
            MouseActions.ClickATM(Browser, SlctAno);
            MouseActions.ClickATM(Browser, Element.Xpath("//div[text()='" + Valor + "']"));
        }

        private void SelecionarPaisObra(string Valor)
        {
            MouseActions.ClickATM(Browser, SlctPais);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, Element.Xpath("//*[text()='" + Valor + "']"));
        }

        private void MarcarDominioPublico(string Valor)
        {
            if (Valor == "Sim")
            {
                Thread.Sleep(2000);
                JsActions.JavaScript(Browser, "$('input[id=\"dominioPublicoId\"]').click();");
            }
        }

        private void MarcarInstitucional(string Valor)
        {
            
            if (Valor == "Sim")
            {
                Thread.Sleep(1500);
                MouseActions.ClickATM(Browser, ChckInstitucional);
            }
        }

        private void MarcarBlackList(string Valor)
        {
            if (Valor == "Sim")
            {
                Thread.Sleep(1500);
                JsActions.JavaScript(Browser, "$('input[id=\"blacklistId\"]').click();");
            }
        }

        private void MarcarEmblematica(string Valor)
        {
            if (Valor == "Sim")
            {
                Thread.Sleep(1500);
                MouseActions.ClickATM(Browser, ChckEmblematica);
            }
        }

        private void MarcarNacionalidade(string Valor)
        {
            if (Valor == "Nacional")
                MouseActions.ClickATM(Browser, RdNacional);
            else
                MouseActions.ClickATM(Browser, RdInternacional);
        }

        public void EditarObra(string Titulo, string SubTitutlo, string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            //var tituloObra = Element.Xpath("//div[text()='" + Titulo + "']");
            //MouseActions.DoubleClickATM(Browser, tituloObra);

            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnEditarObra, Browser);
                MouseActions.ClickATM(Browser, BtnEditarObra);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnEditarObra, Browser);
                MouseActions.ClickATM(Browser, BtnEditarObra);
            }

            Titulo = "";
            CadastrarObra(Titulo, SubTitutlo, Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional,
                BlackList, Emblematica);
        }

        public void TrocarNacionalidade(string Nacionalidade)
        {
            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsClickable(BtnEditarObra, Browser);
                ElementExtensions.IsElementVisible(BtnEditarObra, Browser);
                MouseActions.ClickATM(Browser, BtnEditarObra);
            }
            catch
            {
                ElementExtensions.IsElementVisible(BtnEditarObra, Browser);
                MouseActions.ClickATM(Browser, BtnEditarObra);
            }

            var pais  = Element.Css("div[ng-model='ObraDados.PaisS.selected'] span[class='ng-binding ng-scope']");
            ElementExtensions.IsElementVisible(pais, Browser);
            string nomePais = ElementExtensions.GetValorCss(pais, Browser);
            if(nomePais == "Brasil")
            {
                MouseActions.ClickATM(Browser, RdInternacional);
            }
            else
            {
                MouseActions.ClickATM(Browser, RdNacional);
            }
            SalvarEdicaoDeObra();
        }

        public void SelecionarComposicaoParaEdicao(string Autor)
        {
            try
            {
                Thread.Sleep(2000);
                SelecionarComposicao(Autor);
            }
            catch
            {
                Thread.Sleep(2000);
                SelecionarComposicao(Autor);
            }
        }

        private void SelecionarComposicao(string Autor)
        {
            Thread.Sleep(2000);
            switch (Autor)
            {
                case "Autor":
                    {
                        Autor = CadastrarObraEComposicaoPage.Autor;
                        var editarComposicao = Element.Xpath("//h5[contains(., '" + Autor + "')]/../..//i[@uib-tooltip='Editar']");
                        ElementExtensions.IsElementVisible(editarComposicao, Browser);
                        MouseActions.ClickATM(Browser, editarComposicao);
                        break;
                    }
                case "Autor2":
                    {
                        Autor = Autor2;
                        var editarComposicao = Element.Xpath("//h5[contains(., '" + Autor + "')]/../..//i[@uib-tooltip='Editar']");
                        ElementExtensions.IsElementVisible(editarComposicao, Browser);
                        MouseActions.ClickATM(Browser, editarComposicao);
                        break;
                    }
                default:
                    {
                        var editarComposicao = Element.Xpath("//h5[contains(., '" + Autor + "')]/../..//i[@uib-tooltip='Editar']");
                        ElementExtensions.IsElementVisible(editarComposicao, Browser);
                        MouseActions.ClickATM(Browser, editarComposicao);
                        break;
                    }
            }
        }

        public void ValidarAutor(string Autor)
        {
            var editarComposicao = Element.Xpath("//h5[contains(., '" + Autor + "')]/../..//i[@uib-tooltip='Editar']");
            ElementExtensions.IsElementVisible(editarComposicao, Browser);
            ElementExtensions.IsClickable(editarComposicao, Browser);
        }

        public void AlterarAutorComposicao(string Autor)
        {
            AutomatedActions.SendDataATM(Browser, InpAutor, Autor);
            ElementExtensions.IsElementVisible(Element.Xpath("//a[contains (., '" + Autor + "')]"), Browser);
            MouseActions.ClickATM(Browser, Element.Xpath("//a[contains (., '" + Autor + "')]"));
            SalvarEdicaoDeObra();
            Thread.Sleep(2000);

            ValidarAutor(Autor);
        }

        public void AlterarDDDAComposicao(string Autor, string DDA)
        {
            AutomatedActions.SendDataATM(Browser, InpDDA, DDA);
            ElementExtensions.IsElementVisible(Element.Xpath("//a[contains (., '" + DDA + "')]"), Browser);
            MouseActions.ClickATM(Browser, Element.Xpath("//a[contains (., '" + DDA + "')]"));
            SalvarEdicaoDeObra();
            Thread.Sleep(2000);

            ValidarAutor(Autor);
        }

        public void EditarComposicao(string Autor, string DDA, string Percentual, string NumeroAutor)
        {
            if (Autor != "" && Autor != " ")
            {
                Thread.Sleep(2000);
                CadastrarAutorRandomico(NumeroAutor);
            }
            if (DDA != "" && DDA != " ")
            {
                Thread.Sleep(2000);
                CadastrarDDA();
            }
            if (Percentual != "" && Percentual != " ")
            {
                Thread.Sleep(2000);
                AutomatedActions.SendDataATM(Browser, InpPercentual, Percentual);
            }
                
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
        }

        public void ValidarPercentualCompositor(string Percentual)
        {
            var valorPercentual = Element.Xpath("//h5[contains(., '"  + Percentual + "')]");
            ElementExtensions.IsElementVisible(valorPercentual, Browser);
        }

        public void SelecionarPedidoAfetadoPelaEdicao(string Filtro)
        {
            if(Filtro == "Produto")
            {
                Filtro = CadastroDeProdutoPage.Produto;
                var item = Element.Xpath("//*[text()='" + Filtro + "']");
                MouseActions.ClickATM(Browser, item);
            }
            else
            {
                var item = Element.Xpath("//*[text()='" + Filtro + "']");
                MouseActions.ClickATM(Browser, item);
            }
            

            var salvarSelecao = Element.Css("a[ng-click='ReturnPedidosSelecionados()']");
            MouseActions.ClickATM(Browser, salvarSelecao);
        }

        public void CadastroDeObraRandomica(string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            SetObra(ObraCadastrado);
            string Titulo = GetObra();

            string SubTitutlo = "";

            CadastrarObra(Titulo, SubTitutlo, Tipo, TitutloAlternativo, Iswc, Ano, ObraOriginal, Nacionalidade, Pais, DominioPublico, Institucional,
                BlackList, Emblematica);
        }

        public void CadastrarObra(string Titulo, string SubTitutlo, string Tipo, string TitutloAlternativo, string Iswc, string Ano, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico, string Institucional, string BlackList, string Emblematica)
        {
            if (Titulo != "" && Titulo != " ")
                AutomatedActions.SendDataATM(Browser, InpTituloObra, Titulo);
            if (SubTitutlo != "" && SubTitutlo != " ")
                AutomatedActions.SendDataATM(Browser, InpSubTitulo, SubTitutlo);
            if (Tipo != "" && Tipo != " ")
                SelecionarTipoObra(Tipo);
            if (TitutloAlternativo != "" && TitutloAlternativo != " ")
                AutomatedActions.SendDataEnterATM(Browser, InpTituloAlternativo, TitutloAlternativo);
            if (Iswc != "" && Iswc != " ")
                AutomatedActions.SendDataATM(Browser, InpIswc, Iswc);
            if (Ano != "" && Ano != " ")
                SelecionarAnoObra(Ano);
            if (Nacionalidade != "" && Nacionalidade != " ")
                MarcarNacionalidade(Nacionalidade);
            if (Pais != "" && Pais != " ")
                SelecionarPaisObra(Pais);
            MarcarDominioPublico(DominioPublico);
            MarcarInstitucional(Institucional);
            MarcarBlackList(BlackList);
            MarcarEmblematica(Emblematica);

            var btnSalvarCadastroDeObra = Element.Css("div[class='title-action'] a[uib-tooltip='Salvar']");
            try
            {
                Assert.IsTrue(ElementExtensions.IsElementVisible(btnSalvarCadastroDeObra, Browser));
                MouseActions.ClickATM(Browser, btnSalvarCadastroDeObra);
            }
            catch
            {
                Assert.IsTrue(ElementExtensions.IsElementVisible(btnSalvarCadastroDeObra, Browser));
                MouseActions.ClickATM(Browser, btnSalvarCadastroDeObra);
            }
        }

        public void SalvarEdicaoDeObra()
        {
            Thread.Sleep(1500);
            try
            {
                Thread.Sleep(1500);
                var btnSalvarEdicaoObra = Element.Css("div[id='detalheObra'] a[uib-tooltip='Salvar']");
                ElementExtensions.IsElementVisible(btnSalvarEdicaoObra, Browser);
                MouseActions.ClickATM(Browser, btnSalvarEdicaoObra);
            }
            catch
            {
                Thread.Sleep(1500);
                var btnSalvarEdicaoObra = Element.Css("div[id='detalheObra'] a[uib-tooltip='Salvar']");
                ElementExtensions.IsElementVisible(btnSalvarEdicaoObra, Browser);
                MouseActions.ClickATM(Browser, btnSalvarEdicaoObra);
            }
        }

        private void SelecionarAutor(string Valor)
        {
            AutomatedActions.SendDataATM(Browser, InpAutor, Valor);
            var textAutor = Element.Xpath("//a/strong[text()='" + Valor + "']");
            MouseActions.ClickATM(Browser, textAutor);
        }

        private void SelecionarDDA(string Valor)
        {
            AutomatedActions.SendDataATM(Browser, InpDDA, Valor);
            var textDDA = Element.Xpath("//a/strong[text()='" + Valor + "']");
            MouseActions.ClickATM(Browser, textDDA);
        }

        public void AdicionarCompositor(string Autor, string DDA, string Percentual)
        {
            var btnAddCompositor = Element.Css("a[uib-tooltip='Adicionar composição']");
            ElementExtensions.IsElementVisible(btnAddCompositor, Browser);
            MouseActions.ClickATM(Browser, btnAddCompositor);
            SelecionarAutor(Autor);
            SelecionarDDA(DDA);
            AutomatedActions.SendDataATM(Browser, InpPercentual, Percentual);
            MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
        }

        public void CadastrarComposicao(string Autor, string DDA, string Percentual)
        {
            try
            {
                Thread.Sleep(1500);
                ElementExtensions.IsElementVisible(BtnAdicionarComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarComposicao);
            }
            catch
            {
                ElementExtensions.IsElementVisible(BtnAdicionarComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarComposicao);
            }

            SelecionarAutor(Autor);
            SelecionarDDA(DDA);
            AutomatedActions.SendDataATM(Browser, InpPercentual, Percentual);
            MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
        }

        private void SelecionarTipoContato(string Valor)
        {
            if(Valor != "" && Valor != " ")
            {
                switch(Valor)
                {
                    case "Celular":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctTipoContatoAutor, "2");
                            break;
                        }
                    case "Email":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctTipoContatoAutor, "1");
                            break;
                        }
                    case "Telefone":
                        {
                            MouseActions.SelectElementATMByValue(Browser, SlctTipoContatoAutor, "0");
                            break;
                        }
                }
            }
        }

        public void CadastrarComposicaoManualmenteAutorContratado(string Percentual)
        {
            Thread.Sleep(2000);
            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnAdicionarComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarComposicao);
            }
            catch
            {
                Browser.RefreshPage();
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnAdicionarComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarComposicao);
            }

            CadastrarAutorContratado();
            CadastrarDDA();
            Thread.Sleep(1500);
            AutomatedActions.SendDataATM(Browser, InpPercentual, Percentual);
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
        }

        public void CadastrarComposicaoManualmente(string Percentual, string Numero)
        {
            Thread.Sleep(2000);
            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnAdicionarComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarComposicao);
            }
            catch
            {
                Browser.RefreshPage();
                Thread.Sleep(4000);
                ElementExtensions.IsElementVisible(BtnAdicionarComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarComposicao);
            }

            CadastrarAutorRandomico(Numero);
            CadastrarDDA();
            Thread.Sleep(1500);
            AutomatedActions.SendDataATM(Browser, InpPercentual, Percentual);
            Thread.Sleep(1500);
            try
            {
                ElementExtensions.IsElementVisible(BtnAdicionarCompositor, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
            catch
            {
                Thread.Sleep(1500);
                ElementExtensions.IsElementVisible(BtnAdicionarCompositor, Browser);
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
        }

        public void CadastrarDuplicidadeParaCompositor()
        {
            try
            {
                Thread.Sleep(2000);
                JsActions.JavaScript(Browser, "$('div[class=\"onoffswitch\"] [id=\"Duplicidade\"]').click();");
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
            catch
            {
                Thread.Sleep(2000);
                JsActions.JavaScript(Browser, "$('div[class=\"onoffswitch\"] [id=\"Duplicidade\"]').click();");
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
        }

        public void CadastrarDuplicidade()
        {
            Browser.RefreshPage();

            try
            {
                var editarComposicao = Element.Css("i[ng-click='ModalComposicao(itemComp, itemComp.IdComposicao)']");
                Thread.Sleep(2000);
                Assert.IsTrue(ElementExtensions.IsClickable(editarComposicao, Browser));
                MouseActions.ClickATM(Browser, editarComposicao);

                Thread.Sleep(2000);
                JsActions.JavaScript(Browser, "$('div[class=\"onoffswitch\"] [id=\"Duplicidade\"]').click();");
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
            catch
            {
                Thread.Sleep(2000);
                JsActions.JavaScript(Browser, "$('div[class=\"onoffswitch\"] [id=\"Duplicidade\"]').click();");
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
        }

        public void CadastrarDDAOriginal(string DDAOriginal)
        {
            if(DDAOriginal == "DDA ORIGINAL")
            {
                Thread.Sleep(2000);
                Browser.RefreshPage();

                var editarComposicao = Element.Css("i[ng-click='ModalComposicao(itemComp, itemComp.IdComposicao)']");
                Thread.Sleep(2000);
                Assert.IsTrue(ElementExtensions.IsClickable(editarComposicao, Browser));
                MouseActions.ClickATM(Browser, editarComposicao);

                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnAddDDAOriginal);
                PreencherDadosDeDDA();
                Thread.Sleep(2000);
                Assert.IsTrue(ElementExtensions.IsClickable(BtnAdicionarCompositor, Browser));
                MouseActions.ClickATM(Browser, BtnAdicionarCompositor);
            }
        }

        public void CadastrarAutorContratado()
        {
            MouseActions.ClickATM(Browser, BtnCadastrarAutor);
            AutomatedActions.SendData(Browser, InpNomeArtistico, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            AutomatedActions.SendData(Browser, InpNomeCompletoAutor, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            JsActions.JavaScript(Browser, "$('input[id=\"contratadoId\"]').click();");
            AutomatedActions.SendData(Browser, InpDataInicioContratacao, "08081990");
            AutomatedActions.SendData(Browser, InpDataFimContratacao, "08082020");
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeAutor);
        }

        public void GerarAutorRandomico(string Numero)
        {
            if (Numero == "1")
            {
                SetAutor(AutorCadastrado);
                string Valor = GetAutor();
            }
            if (Numero == "2")
            {
                SetAutor2(AutorCadastrado2);
                string Valor = GetAutor2();
            }
        }

        public void CadastrarAutorRandomico(string Numero)
        {
            if(Numero == "1")
            {
                SetAutor(AutorCadastrado);
                string Valor = GetAutor();
                CadastrarAutorComposicao(Valor);
            }
            if(Numero == "2")
            {
                SetAutor2(AutorCadastrado2);
                string Valor = GetAutor2();
                CadastrarAutorComposicao(Valor);
            }
        }

        public void CadastrarAutorComposicao(string NomeAutor)
        {
            MouseActions.ClickATM(Browser, BtnCadastrarAutor);
            AutomatedActions.SendData(Browser, InpNomeArtistico, NomeAutor);
            AutomatedActions.SendData(Browser, InpNomeCompletoAutor, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());

            MouseActions.ClickATM(Browser, BtnShowContatos);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            SelecionarTipoContato("Email");
            AutomatedActions.SendData(Browser, InpValorContatoAutor, "teste@teste.com.br");
            MouseActions.ClickATM(Browser, BtnAdicionarItemContato);
            MouseActions.ClickATM(Browser, BtnSalvarContatoAutor);
            MouseActions.ClickATM(Browser, BtnSalvarCadastroDeAutor);
        }

        private void CadastrarDDA()
        {
            Thread.Sleep(2000);
            try
            {
                ElementExtensions.IsElementVisible(BtnCadastrarDDA, Browser);
                MouseActions.ClickATM(Browser, BtnCadastrarDDA);
            }
            catch
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnCadastrarDDA, Browser);
                MouseActions.ClickATM(Browser, BtnCadastrarDDA);
            }
            PreencherDadosDeDDA();
        }

        private void PreencherDadosDeDDA()
        {
            ElementExtensions.EsperarElemento(InpNomeFantasia, Browser);
            AutomatedActions.SendDataATM(Browser, InpNomeFantasia, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            AutomatedActions.SendDataATM(Browser, InpNomeCompleto, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            PreencherCNPJ();
            SelecionarAssociacao("UBEM");
            MouseActions.ClickATM(Browser, ChckAdministrador);
            //AutomatedActions.SendData(Browser, InpDataNascimento, "10/10/1992");
            CadastrarContatoDDA();
            MouseActions.ClickATM(Browser, BtnSalvarDDA);
        }

        private void SelecionarAssociacao(string Associacao)
        {
            switch (Associacao)
            {
                case "UBEM":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacaoDDA, "UBEM");
                        break;
                    }
                case "SEM ASSOCIAÇÃO":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctAssociacaoDDA, "SemAssociacao");
                        break;
                    }
            }
        }

        private void PreencherCNPJ()
        {
            var cnpj = Element.Css("input[id='optionsRadios2']");
            ElementExtensions.IsElementVisible(cnpj, Browser);
            MouseActions.ClickATM(Browser, cnpj);

            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, InpCPF);
            Thread.Sleep(2000);
            //AutomatedActions.SendDataATM(Browser, InpCPF, "30.253.090/0001-93");
            AutomatedActions.SendData(Browser, InpCPF, "30.253.090/0001-93");
        }

        public void CadastrarContatoDDA()
        {
            MouseActions.ClickATM(Browser, BtnShowCamposContato);
            AutomatedActions.SendData(Browser, InpNomeContato, FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr());
            SelecionarTipoContatoDeDDA("E-mail");
            AutomatedActions.SendDataATM(Browser, InpTipoContato, "razevedo@inmetrics.com.br");
            MouseActions.ClickATM(Browser, ChckRecebeAutorizacao);
            MouseActions.ClickATM(Browser, BtnAdicionarContatoDDA);
            MouseActions.ClickATM(Browser, BtnSalvarContatoDDA);
        }

        private void SelecionarTipoContatoDeDDA(string TipoContato)
        {
            switch (TipoContato)
            {
                case "Celular":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipoContato, "2");
                        break;
                    }
                case "E-mail":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipoContato, "1");
                        break;
                    }
                case "Telefone":
                    {
                        MouseActions.SelectElementATMByValue(Browser, SlctTipoContato, "0");
                        break;
                    }
            }
        }

        public void ValidarObraCadastrada(string Titulo, string SubTitutlo, string Tipo, string Iswc, string ObraOriginal,
            string Nacionalidade, string Pais, string DominioPublico)
        {
            ValidarDadosNoDetalheDaObra("Subtitulo", SubTitutlo);
            ValidarDadosNoDetalheDaObra("Tipo", Tipo);
            ValidarDadosNoDetalheDaObra("Iswc", Iswc);
            ValidarDadosNoDetalheDaObra("Obra Original", ObraOriginal);
            ValidarDadosNoDetalheDaObra("Nacionalidade", Nacionalidade);
            ValidarDadosNoDetalheDaObra("Pais", Pais);
            ValidarDadosNoDetalheDaObra("Domínio público", DominioPublico);
        }

        private void ValidarDadosNoDetalheDaObra(string Campo, string Valor)
        {
            string Complemento = "0";
            if (Campo != "" && Campo != " ")
            {
                if (Valor != "" && Valor != " ")
                {
                    switch (Campo)
                    {
                        case "Subtitulo":
                            {
                                Complemento = "Subtitulo: ";
                                Campo = "1";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                        case "Tipo":
                            {
                                Complemento = "Tipo: ";
                                Campo = "3";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                        case "ISWC":
                            {
                                Complemento = "ISWC: ";
                                Campo = "4";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                        case "Domínio público":
                            {
                                Complemento = "Domínio público: ";
                                Campo = "5";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                        case "Obra Original":
                            {
                                Complemento = "Obra Original: ";
                                Campo = "6";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                        case "Nacionalidade":
                            {
                                Complemento = "Nacionalidade: ";
                                Campo = "8";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                        case "País":
                            {
                                Complemento = "País: ";
                                Campo = "9";
                                ValidarObra(Campo, Valor, Complemento);
                                break;
                            }
                    }
                }
            }
        }

        private void ValidarObra(string Campo, string Valor, string Complemento)
        {
            var h4 = Campo;
            var linha = "0";
            string textoCompleto = Complemento + Valor;
            linha = ElementExtensions.GetValorAtributo(Element.Xpath("//div[@id='divObraDados']//h4[" + h4 + "]"), "textContent", Browser);
            Assert.AreEqual(textoCompleto, linha);
        }

        //#########################      ValidarComposição         ###################################
        public void ValidarComposicaoCadastrada(string Autor, string Versionista, string DDA, string Percentual)
        {
            ValidarComposicaoNoDetalheDaObra("Autor", Autor);
            ValidarComposicaoNoDetalheDaObra("Versionista", Versionista);
            ValidarComposicaoNoDetalheDaObra("DDA", DDA);
            ValidarComposicaoNoDetalheDaObra("Percentual", Percentual);
        }

        private void ValidarComposicaoNoDetalheDaObra(string Campo, string Valor)
        {
            string Complemento = "0";
            if (Campo != "" && Campo != " ")
            {
                if (Valor != "" && Valor != " ")
                {
                    switch (Campo)
                    {
                        case "Autor":
                            {
                                Complemento = "Autor: ";
                                Campo = "1";
                                ValidarComposicao(Campo, Valor, Complemento);
                                break;
                            }
                        case "Versionista":
                            {
                                Complemento = "Versionista: ";
                                Campo = "2";
                                ValidarComposicao(Campo, Valor, Complemento);
                                break;
                            }
                        case "DDA":
                            {
                                Complemento = "DDA: ";
                                Campo = "3";
                                ValidarComposicao(Campo, Valor, Complemento);
                                break;
                            }
                        case "Percentual":
                            {
                                Complemento = "Percentual: ";
                                Campo = "4";
                                ValidarComposicao(Campo, Valor, Complemento);
                                break;
                            }
                    }
                }
            }
        }

        private void ValidarComposicao(string Campo, string Valor, string Complemento)
        {
            var h5 = Campo;
            var linha = "0";
            linha = ElementExtensions.GetValorAtributo(Element.Xpath("//div[@ng-repeat='itemComp in item.ItensComposicao']//h5[" + h5 + "]"), "textContent", Browser);
            if(Complemento == "Percentual: ")
            {
                string textoCompleto = " " + Complemento + Valor + "% ";
                Assert.AreEqual(textoCompleto, linha);
            }
            else
            {
                string textoCompleto = " " + Complemento + Valor + " ";
                Assert.AreEqual(textoCompleto, linha);
            }
            
        }

        public void ValidarComposicaoEmDuplicidade()
        {
            var composicao = Element.Css("div[class='widget style1 navy-bg duplicidade_true']");
            Assert.IsTrue(ElementExtensions.IsClickable(composicao, Browser));
        }

        public void ValidarComposicaoEmDuplicidadeNaGrid()
        {
            Thread.Sleep(1500);
            var composicao = Element.Css("span[class='text-danger']");
            Assert.IsTrue(ElementExtensions.IsClickable(composicao, Browser));
        }
        //##########################################################################################################

        public void ValidarCamposObrigatoriosEmDestaqueDeObra()
        {
            var campoTitulo = Element.Css("div[ng-class='classObraTitulo'][class='has-error']");
            var campoTipo = Element.Css("div[ng-class='classObraTipo'][class='has-error']");
            var campoNacionalidade = Element.Css("div[ng-class='classObraNacionalidade'][class='has-error']");

            Assert.IsTrue(ElementExtensions.IsElementVisible(campoTitulo, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(campoTipo, Browser));
            Assert.IsTrue(ElementExtensions.IsElementVisible(campoNacionalidade, Browser));
        }

        public void SalvarObraEComposicao()
        {
            try
            {
                Thread.Sleep(2000);
                var nomeObra = Element.Css("div[class='ibox-title'] h3");
                ElementExtensions.IsClickable(nomeObra, Browser);
            }
            catch
            {
                Thread.Sleep(2000);
                var nomeObra = Element.Css("div[class='ibox-title'] h3");
                ElementExtensions.IsElementVisible(nomeObra, Browser);
            }

            try
            {
                Thread.Sleep(2000);
                ElementExtensions.IsElementVisible(BtnSalvarObraEComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarObraEComposicao);
            }
            catch
            {
                Browser.RefreshPage();
                Thread.Sleep(3000);
                ElementExtensions.IsElementVisible(BtnSalvarObraEComposicao, Browser);
                MouseActions.ClickATM(Browser, BtnSalvarObraEComposicao);
            }

            try
            {
                string popUpSucesso = "div[id='toast-container'] div[class='ng-binding ng-scope']";
                ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser);
                Assert.IsTrue(ElementExtensions.IsElementVisible(Element.Css(popUpSucesso), Browser));
                Thread.Sleep(4000);
                ElementExtensions.IsClickable(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
                ElementExtensions.IsElementVisible(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
                Assert.IsTrue(Browser.PageSource("SOM | Obras"));
            }
            catch
            {
                Thread.Sleep(4000);
                ElementExtensions.IsElementVisible(Element.Css("a[ng-click='ShowHideFiltro()']"), Browser);
                Assert.IsTrue(Browser.PageSource("SOM | Obras"));
            }
        }

        public void ValidarPopupAlertaSemComposicao(string Mensagem)
        {
            Thread.Sleep(1500);
            MouseActions.ClickATM(Browser, BtnSalvarObraEComposicao);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css("p[style='display: block;']"), "textContent", Browser));
            Browser.RefreshPage();
        }

        public void ValidarPopupPercentual(string Mensagem)
        {
            Thread.Sleep(1500);
            ElementExtensions.IsElementVisible(BtnSalvarObraEComposicao, Browser);
            MouseActions.ClickATM(Browser, BtnSalvarObraEComposicao);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(Element.Css("p[style='display: block;']"), "textContent", Browser));
            Browser.RefreshPage();
        }

        public void ValidarPopupPercentualAcimaDoPermitido(string Mensagem)
        {
            Thread.Sleep(1500);
            var popUp = Element.Css("p[style='display: block;']");
            ElementExtensions.IsElementVisible(popUp, Browser);
            Assert.AreEqual(Mensagem, ElementExtensions.GetValorAtributo(popUp, "textContent", Browser));
            Browser.RefreshPage();
        }


        public void ValidarPopupAlteracaoDeObra(string Confirmar)
        {
            var textoPopup = ElementExtensions.IsElementVisible(Element.Xpath("//p[@style='display: block;'][contains (., 'Os itens de pedido selecionados serão alterados. Deseja continuar?')]"), Browser);
            Assert.IsTrue(textoPopup);
            Thread.Sleep(2000);

            if (Confirmar == "Sim")
            {
                ElementExtensions.IsElementVisible(BtnConfirmar, Browser);
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnConfirmar);
            }
        }

        public void ExcluirAutorDaComposicao(string Autor)
        {
            Thread.Sleep(2000);
            var excluirComposicao = Element.Xpath("//h5[contains(., '" + Autor + "')]/../..//i[@uib-tooltip='Excluir']");
            ElementExtensions.IsElementVisible(excluirComposicao, Browser);

            try
            {
                MouseActions.ClickATM(Browser, excluirComposicao);
            }
            catch
            {
                MouseActions.ClickATM(Browser, excluirComposicao);
            }

            var popUpExclusao = Element.Xpath("//h2[contains(., 'Deseja excluir?')]");
            ElementExtensions.IsElementVisible(popUpExclusao, Browser);
            var btnConfirmarExclusao = Element.Css("button[class='confirm']");
            ElementExtensions.IsElementVisible(btnConfirmarExclusao, Browser);
            Thread.Sleep(2000);
            MouseActions.ClickATM(Browser, btnConfirmarExclusao);
        }


    }
}
