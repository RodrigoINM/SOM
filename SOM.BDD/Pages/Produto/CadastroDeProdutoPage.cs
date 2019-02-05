using Framework.Core.PageObjects;
using Framework.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Core.FrameworkActions;
using System.Threading;
using Framework.Core.Extensions.ElementExtensions;
using Framework.Core.Helpers;

namespace SOM.BDD.Pages.Produto
{
    public class CadastroDeProdutoPage : PageBase
    {
        private string CadastrarProdutoUrl { get; }

        private string PageTitle => "SOM | Cadastro de Produto";

        string GeracaoEmLote = "$('input[id=\"GeracaoLote\"]').click();";

        private Element InpNomeProduto { get; set; }
        private Element InpEpisodio { get; set; }
        private Element SlctGeneroOriginal { get; set; }
        private Element InpGeneroOriginal { get; set; }
        private Element SlctGeneroMusical { get; set; }
        private Element InpGeneroMusical { get; set; }
        private Element InpArProduto { get; set; }
        private Element InpAtividade { get; set; }
        private Element InpMidias { get; set; }
        private Element ChckGradeAtual { get; set; }
        private Element ChckAtualizaOrigem { get; set; }
        private Element ChckCapituloObrigatorio { get; set; }
        private Element BtnSalvarProduto { get; set; }
        public Element BtnCancelarCadastro { get; private set; }

        //Pop up confirmação de ativação
        private Element BtnConfirmarAtivacao { get; set; }

        //Cadastrar capitulo
        public Element BtnAdicionarCapitulo { get; private set; }
        public Element InpCapitulo { get; private set; }
        public Element InpQtdCapitulos { get; private set; }
        public Element BtnSalvarCapitulo { get; private set; }
        public Element BtnCancelarCadastroCapitulo { get; private set; }

        //Alterar produto
        public Element BtnEditarProduto { get; private set; }
        public Element BtnSalvarEdicaoDeProduto { get; private set; }

        public CadastroDeProdutoPage(IBrowser browser, string cadastrarProdutoUrl) : base(browser)
        {
            CadastrarProdutoUrl = cadastrarProdutoUrl;

            InpNomeProduto = Element.Css("input[ng-model='ProdutoDados.Nome']");
            InpEpisodio = Element.Css("input[ng-model='ProdutoDados.Episodio']");
            SlctGeneroOriginal = Element.Css("div[ng-model='ProdutoDados.generoOriginal.selected']");
            InpGeneroOriginal = Element.Css("div[ng-model='ProdutoDados.generoOriginal.selected'] input[ng-model='$select.search']");
            SlctGeneroMusical = Element.Css("div[ng-model='ProdutoDados.generoDiretoMusical.selected']");
            InpGeneroMusical = Element.Css("div[ng-model='ProdutoDados.generoDiretoMusical.selected'] input[ng-model='$select.search']");
            InpArProduto = Element.Css("input[ng-model='ProdutoDados.AR']");
            InpAtividade = Element.Css("input[ng-model='ProdutoDados.Atividade']");
            InpMidias = Element.Css("div[ng-model='ProdutoDados.Midias'] input");
            ChckGradeAtual = Element.Css("div[class='onoffswitch'] label[for='GradeAtual']");
            ChckAtualizaOrigem = Element.Css("div[class='onoffswitch'] label[for='AtualizaOrigem']");
            ChckCapituloObrigatorio = Element.Css("div[class='onoffswitch'] label[for='CapituloObrigatorio']");
            BtnSalvarProduto = Element.Css("a[ng-click='salvarProduto(false)']");
            BtnCancelarCadastro = Element.Css("a[ng-click='voltarLista()']");

            //Pop up confirmação de ativação
            BtnConfirmarAtivacao = Element.Css("button[class='confirm']");

            //Cadastrar capitulo
            BtnAdicionarCapitulo = Element.Css("i[ng-click='ModalCapitulo(false)']");
            InpCapitulo = Element.Css("input[ng-model='CapituloDados.NumeroCapitulo']");
            InpQtdCapitulos = Element.Css("input[ng-model='CapituloDados.QuantidadeCapitulos']");
            BtnSalvarCapitulo = Element.Css("a[ng-click='salvarCapitulo()']");
            BtnCancelarCadastroCapitulo = Element.Css("a[ng-click='cancelar()']");

            //Alterar produto
            BtnEditarProduto = Element.Css("i[class='fa fa-edit pull-right editarproduto']");
            BtnSalvarEdicaoDeProduto = Element.Css("a[class='btn btn-link collapsed editarproduto']");
        }

        public static string Produto { get; set; }
        public static string Produto2 { get; set; }
        public static string Episodio { get; set; }
        public static string Episodio2 { get; set; }

        public string ProdutoCadastrado
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr() + " " + FakeHelpers.LastName() + FakeHelpers.RandomNumberStr(); }
        }

        public string ProdutoCadastrado2
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr() + " " + FakeHelpers.LastName() + FakeHelpers.RandomNumberStr(); }
        }

        public string EpisodioCadastrado
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr(); }
        }

        public string EpisodioCadastrado2
        {
            get { return FakeHelpers.FirstName() + FakeHelpers.RandomNumberStr(); }
        }

        public string GetProduto()
        {
            return Produto;
        }

        private void SetProduto(string nome)
        {
            Produto = nome;
        }

        public string GetProduto2()
        {
            return Produto2;
        }

        private void SetProduto2(string nome)
        {
            Produto2 = nome;
        }

        public string GetEpisodio()
        {
            return Episodio;
        }

        private void SetEpisodio(string nome)
        {
            Episodio = nome;
        }

        public string GetEpisodio2()
        {
            return Episodio2;
        }

        private void SetEpisodio2(string nome)
        {
            Episodio2 = nome;
        }

        public override void Navegar()
        {
            Browser.Abrir(CadastrarProdutoUrl);
            Assert.IsTrue(Browser.PageSource(PageTitle));
        }

        public void CadastrarCapitulo(string Capitulo)
        {
            ClicarAdicionarCapitulo();

            AutomatedActions.SendDataATM(Browser, InpCapitulo, Capitulo);
            MouseActions.ClickATM(Browser, BtnSalvarCapitulo);

            var capituloCadastrado = Element.Css("h5 strong");
            Assert.IsTrue(ElementExtensions.IsClickable(capituloCadastrado, Browser));
        }

        public void CancelarCadastrDeCapitulo()
        {
            ClicarAdicionarCapitulo();

            ElementExtensions.IsElementVisible(BtnCancelarCadastroCapitulo, Browser);
            MouseActions.ClickATM(Browser, BtnCancelarCadastroCapitulo);
        }

        public void CadastroDeCapituloEmLote(string Capitulo, string Lote, string Qtd, string Observacao)
        {
            ClicarAdicionarCapitulo();

            if (Capitulo != "" && Capitulo != " ")
                AutomatedActions.SendDataATM(Browser, InpCapitulo, Capitulo);
            if (Lote == "Sim")
                JsActions.JavaScript(Browser, GeracaoEmLote);
            if (Qtd != "" && Qtd != " ")
                AutomatedActions.SendDataATM(Browser, InpQtdCapitulos, Qtd);

            MouseActions.ClickATM(Browser, BtnSalvarCapitulo);
        }

        public void ValidarCamposObrigatoriosParaCadastroDeCapitulo(string Campo)
        {
            var labelCampo = Element.Xpath("//div[@class='form-group has-error']//label[contains(., '" + Campo + "')]");
            ElementExtensions.IsElementVisible(labelCampo, Browser);
        }

        private void ClicarAdicionarCapitulo()
        {
            try
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnAdicionarCapitulo);
            }
            catch
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnAdicionarCapitulo);
            }
        }

        public void ValidarCapituloCadastrado(string Capitulo)
        {
            Thread.Sleep(2000);
            var nomeCapitulo = Element.Xpath("//h5[@class='ng-binding'][contains(., '" + Capitulo + "')]");
            try
            {
                ElementExtensions.IsElementVisible(nomeCapitulo, Browser);
            }
            catch
            {
                Browser.RefreshPage();
                ElementExtensions.IsElementVisible(nomeCapitulo, Browser);
            }
        }

        public void ValidarNomeProdutoDetalhes(string Produto)
        {
            var nomeProduto = Element.Xpath("//h3[contains(., '" + Produto + "')]");
            ElementExtensions.IsElementVisible(nomeProduto, Browser);
        }

        public void GerarNovoProdutoEEpisodio()
        {
            SetProduto2(ProdutoCadastrado2);
            string Nome = GetProduto2();

            SetEpisodio2(EpisodioCadastrado2);
            string Episodio = GetEpisodio2();
        }

        public void CadastroDeProduto(string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            SetProduto(ProdutoCadastrado);
            string Nome = GetProduto();

            SetEpisodio(EpisodioCadastrado);
            string Episodio = GetEpisodio();
            CadastrarProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
        }

        public void EditarProduto(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            ElementExtensions.IsElementVisible(BtnEditarProduto, Browser);
            MouseActions.ClickATM(Browser, BtnEditarProduto);

            if(Nome == "Aleatório")
            {
                SetProduto(ProdutoCadastrado);
                Nome = GetProduto();
            }

            if(Episodio == "Aleatório")
            {
                SetEpisodio(EpisodioCadastrado);
                Episodio = GetEpisodio();
            }

            CadastrarProduto(Nome, Episodio, GeneroOriginal, GeneroMusical, Ar, GradeAtual, Midias, Atividade, AtualizaOrigem, CapituloObrigatorio);
        }

        public void SalvarEdicaoDeProduto()
        {
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, BtnSalvarEdicaoDeProduto);
            Thread.Sleep(2000);
        }

        public void CadastrarProduto(string Nome, string Episodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            AutomatedActions.SendDataATM(Browser, InpNomeProduto, Nome);
            AutomatedActions.SendDataATM(Browser, InpEpisodio, Episodio);
            if(GeneroOriginal != "" && GeneroOriginal != " ")
            {
                MouseActions.ClickATM(Browser, SlctGeneroOriginal);
                MouseActions.ClickATM(Browser, Element.Xpath("//div[@class='ng-binding ng-scope'][text()='" + GeneroOriginal + "']"));
            }
            if (GeneroMusical != "" && GeneroMusical != " ")
            {
                MouseActions.ClickATM(Browser, SlctGeneroMusical);
                MouseActions.ClickATM(Browser, Element.Xpath("//div[@class='ng-binding ng-scope'][text()='" + GeneroMusical + "']"));
            }
            AutomatedActions.SendDataATM(Browser, InpArProduto, Ar);
            AutomatedActions.SendDataATM(Browser, InpAtividade, Atividade);
            if (GradeAtual == "Não")
            {
                MouseActions.ClickATM(Browser, ChckGradeAtual);
            }
            if (AtualizaOrigem == "Sim")
            {
                MouseActions.ClickATM(Browser, ChckAtualizaOrigem);
            }
            AutomatedActions.SendDataATM(Browser, InpMidias, Midias);
            KeyboardActions.Tab(Browser, InpMidias);
            if (CapituloObrigatorio == "Não")
            {
                MouseActions.ClickATM(Browser, ChckCapituloObrigatorio);
            }
        }

        public void CadastrarCapituloProduto()
        {
            var btnCadastrarCapitulo = Element.Css("i[class='fa fa-plus pull-right cadastrarcapitulo']");
            try
            {
                ElementExtensions.IsElementVisible(btnCadastrarCapitulo, Browser);
                MouseActions.ClickATM(Browser, btnCadastrarCapitulo);
            }
            catch
            {
                ElementExtensions.IsElementVisible(btnCadastrarCapitulo, Browser);
                MouseActions.ClickATM(Browser, btnCadastrarCapitulo);
            }

            var inpNumeroCapitulo = Element.Css("input[ng-model='CapituloDados.NumeroCapitulo']");
            ElementExtensions.IsElementVisible(inpNumeroCapitulo, Browser);
            AutomatedActions.SendData(Browser, inpNumeroCapitulo, "01");

            var btnSalvarCapitulo = Element.Css("a[ng-click='salvarCapitulo()']");
            ElementExtensions.IsElementVisible(btnSalvarCapitulo, Browser);
            MouseActions.ClickATM(Browser, btnSalvarCapitulo);

            var btnEditarCapitulo = Element.Css("i[class='fa fa-edit editarcapitulo']");
            Assert.IsTrue(ElementExtensions.IsElementVisible(btnEditarCapitulo, Browser));
            ElementExtensions.IsClickable(btnEditarCapitulo, Browser);
            ElementExtensions.IsElementVisible(btnEditarCapitulo, Browser);
        }

        public void SalvarCadastroDeProduto()
        {
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, BtnSalvarProduto);
            Thread.Sleep(2000);
        }

        public void ClicarSalvarCadastroDeProduto(string Mensagem)
        {
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, BtnSalvarProduto);

            try
            {
                Thread.Sleep(2000);
                MouseActions.ClickATM(Browser, BtnConfirmarAtivacao);
            }
            catch
            {
                //Thread.Sleep(2000);
                //MouseActions.ClickATM(Browser, BtnConfirmarAtivacao);
            }
        }

        public void ValidarDadosProduto(string Nome, string TextEpisodio, string GeneroOriginal, string GeneroMusical, string Ar, string GradeAtual,
            string Midias, string Atividade, string AtualizaOrigem, string CapituloObrigatorio)
        {
            MouseActions.DoubleClickATM(Browser, Element.Xpath("//table[@dt-columns='dtColumns']//div[text()='" + Produto + "']"));
            ValidarDadosNoDetalheDoProduto("Episódio", Episodio);
            ValidarDadosNoDetalheDoProduto("Gênero Original", GeneroOriginal);
            ValidarDadosNoDetalheDoProduto("Gênero Direitos Musicais", GeneroMusical);
            ValidarDadosNoDetalheDoProduto("AR", Ar);
            ValidarDadosNoDetalheDoProduto("Atividade", Atividade);
            ValidarDadosNoDetalheDoProduto("Grade atual", GradeAtual);
            ValidarDadosNoDetalheDoProduto("Atualiza pela origem", AtualizaOrigem);
            ValidarDadosNoDetalheDoProduto("Capítulo obrigatório", CapituloObrigatorio);
            ValidarDadosNoDetalheDoProduto("Mídias", Midias);
        }

        private void ValidarDadosNoDetalheDoProduto(string Campo, string Valor)
        {
            string Complemento = "0";
            if (Campo != "" && Campo != " ")
            {
                if (Valor != "")
                {
                    switch (Campo)
                    {
                        case "Episódio":
                            {
                                Complemento = "Episódio: ";
                                Campo = "1";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                        case "AR":
                            {
                                Complemento = "AR: ";
                                Campo = "4";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                        case "Atividade":
                            {
                                Complemento = "Atividade: ";
                                Campo = "5";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                        case "Grade atual":
                            {
                                Complemento = "Grade atual: ";
                                Campo = "6";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                        case "Atualiza pela origem":
                            {
                                Complemento = "Atualiza pela origem: ";
                                Campo = "7";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                        case "Capítulo obrigatório":
                            {
                                Complemento = "Capítulo obrigatório: ";
                                Campo = "8";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                        case "Mídias":
                            {
                                Complemento = "Mídias: | ";
                                Campo = "9";
                                ValidarProduto(Campo, Valor, Complemento);
                                break;
                            }
                    }
                }
            }
        }

        private void ValidarProduto(string Campo, string Valor, string Complemento)
        {
            var h4 = Campo;
            var linha = "0";
            string textoCompleto = Complemento + Valor;
            linha = ElementExtensions.GetValorAtributo(Element.Xpath("//div[@ng-if='PesquisaProdutoDetalhe == false']/h4[" + h4 + "]"), "textContent", Browser);
            
            if (Valor == "GLOBONEWS")
            {
                ElementExtensions.IsElementVisible(Element.Xpath("//div[@ng-if='PesquisaProdutoDetalhe == false']/h4[contains (., 'GLOBONEWS')]"), Browser);
            }
            else
            {
                Assert.AreEqual(textoCompleto, linha);
            }
        }

        public void ValidarCamposObrigatoriosCadastroDeProduto(string Nome, string Ar, string GeneroDireitosMusicais, string Atividade, string Midia)
        {
            if (Nome == "Sim")
                Assert.IsTrue(ElementExtensions.IsClickable(Element.Css("div[ng-class='classProdutoNome'][class='form-group has-error']"), Browser));
            if (Ar == "Sim")
                Assert.IsTrue(ElementExtensions.IsClickable(Element.Css("div[ng-class='classProdutoAR'][class='has-error']"), Browser));
            if (GeneroDireitosMusicais == "Sim")
                Assert.IsTrue(ElementExtensions.IsClickable(Element.Css("div[ng-class='classProdutoGenero'][class='has-error']"), Browser));
            if (Atividade == "Sim")
                Assert.IsTrue(ElementExtensions.IsClickable(Element.Css("div[ng-class='classProdutoAtividade'][class='has-error']"), Browser));
            if (Midia == "Sim")
                Assert.IsTrue(ElementExtensions.IsClickable(Element.Css("div[ng-class='classProdutoMidias'][class='has-error']"), Browser));
        }

        public void CancelarCadastroDeProduto()
        {
            MouseActions.ClickATM(Browser, BtnCancelarCadastro);
        }

        public void ValidarMensagemDeProdutoJaExistente(string Mensagem)
        {
            Thread.Sleep(1000);
            MouseActions.ClickATM(Browser, BtnSalvarProduto);

            ElementExtensions.IsElementVisible(BtnConfirmarAtivacao, Browser);
            Thread.Sleep(2000);
            Assert.IsTrue(ElementExtensions.IsClickable(Element.Xpath("//p[contains (., '" + Mensagem + "')]"), Browser));
            MouseActions.ClickATM(Browser, BtnConfirmarAtivacao);
        }

        public void ValidarPopupDeRegistroExistente(string Mensagem)
        {
            var textoMensagem = Element.Css("p[style='display: block;']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetTexto(textoMensagem, Browser));
        }

        public void ValidarPopUpSucesso(string Mensagem)
        {
            var PopUpStatus = Element.Css("div[class='ng-binding ng-scope']");
            Assert.AreEqual(Mensagem, ElementExtensions.GetTexto(PopUpStatus, Browser));
        }

    }
}
