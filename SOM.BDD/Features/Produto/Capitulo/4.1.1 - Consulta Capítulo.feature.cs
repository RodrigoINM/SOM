﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SOM.BDD.Features.Produto.Capitulo
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("4.1.1 - Consulta de capítulos", new string[] {
            "kill_Driver",
            "Capitulo",
            "ConsultaDeCapitulo"}, Description="Como um usuário com permissão de consultar\r\nEu quero poder consultar as informaçõ" +
        "es de capítulo para um produto já cadastrado\r\nPara que possa conferir os dados n" +
        "o cadastro associada ao produto", SourceFile="Features\\Produto\\Capitulo\\4.1.1 - Consulta Capítulo.feature", SourceLine=5)]
    public partial class _4_1_1_ConsultaDeCapitulosFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "4.1.1 - Consulta Capítulo.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "4.1.1 - Consulta de capítulos", "Como um usuário com permissão de consultar\r\nEu quero poder consultar as informaçõ" +
                    "es de capítulo para um produto já cadastrado\r\nPara que possa conferir os dados n" +
                    "o cadastro associada ao produto", ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Capitulo",
                        "ConsultaDeCapitulo"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 11
#line 12
    testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        public virtual void BuscaPeloNomeDoProduto(string nomeProduto, string episodio, string capitulo, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeCapituloCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca pelo Nome do Produto", null, @__tags);
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
this.FeatureBackground();
#line 16
 testRunner.Given("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 17
 testRunner.And("que esteja na tela de consulta de capitulos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 18
    testRunner.When(string.Format("faço uma busca de capítulo por nome do Produto {0}", nomeProduto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 19
 testRunner.Then(string.Format("visualizo os dados do produto e capítulo cadastrados no sistema no resultado da b" +
                        "usca {0}, {1}, {2}", nomeProduto, episodio, capitulo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca pelo Nome do Produto, \"Aleatório\"", new string[] {
                "chrome",
                "ConsultaDeCapituloCT01"}, SourceLine=22)]
        public virtual void BuscaPeloNomeDoProduto_Aleatorio()
        {
#line 15
this.BuscaPeloNomeDoProduto("\"Aleatório\"", "\"Aleatório\"", "\"01\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPeloEpisodio(string nomeProduto, string episodio, string capitulo, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeCapituloCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca pelo Episódio", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
this.FeatureBackground();
#line 27
 testRunner.Given("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 28
 testRunner.And("que esteja na tela de consulta de capitulos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
    testRunner.When(string.Format("faço uma busca de capítulo por episodio {0}", episodio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 30
 testRunner.Then(string.Format("visualizo os dados do produto e capítulo cadastrados no sistema no resultado da b" +
                        "usca {0}, {1}, {2}", nomeProduto, episodio, capitulo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca pelo Episódio, \"Aleatório\"", new string[] {
                "chrome",
                "ConsultaDeCapituloCT02"}, SourceLine=33)]
        public virtual void BuscaPeloEpisodio_Aleatorio()
        {
#line 26
this.BuscaPeloEpisodio("\"Aleatório\"", "\"Aleatório\"", "\"01\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPeloCapituloInicioEFim(string capituloInicio, string capituloFim, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeCapituloCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca pelo Capítulo Início e Fim", null, @__tags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
this.FeatureBackground();
#line 38
 testRunner.Given("que esteja na tela de consulta de capitulos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 39
    testRunner.When(string.Format("faço uma busca de capítulo por capitulo inicial e final {0}, {1}", capituloInicio, capituloFim), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 40
 testRunner.Then(string.Format("visualizo uma mensagem de critica pedindo para informar ao menos um produto ou ep" +
                        "isodio {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca pelo Capítulo Início e Fim, \"01\"", new string[] {
                "chrome",
                "ConsultaDeCapituloCT03"}, SourceLine=43)]
        public virtual void BuscaPeloCapituloInicioEFim_01()
        {
#line 37
this.BuscaPeloCapituloInicioEFim("\"01\"", "\"22\"", "\"Informe ao menos um produto ou episódio.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaSemPreenchimentoDeNenhumDosCampos(string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeCapituloCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca sem preenchimento de nenhum dos campos", null, @__tags);
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
this.FeatureBackground();
#line 48
 testRunner.Given("que esteja na tela de consulta de capitulos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 49
 testRunner.When("faço um busca por capitulo sem preencher nenhum campo da consulta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 50
 testRunner.Then(string.Format("visualizo uma mensagem de critica pedindo para informar ao menos um produto ou ep" +
                        "isodio {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca sem preenchimento de nenhum dos campos, \"Informe ao menos um produto ou epi" +
            "sódio.\"", new string[] {
                "chrome",
                "ConsultaDeCapituloCT04"}, SourceLine=53)]
        public virtual void BuscaSemPreenchimentoDeNenhumDosCampos_InformeAoMenosUmProdutoOuEpisodio_()
        {
#line 47
this.BuscaSemPreenchimentoDeNenhumDosCampos("\"Informe ao menos um produto ou episódio.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPorProdutosNaoCadastrados(string nomeProduto, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeCapituloCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca por produtos não cadastrados", null, @__tags);
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
this.FeatureBackground();
#line 58
 testRunner.Given("que esteja na tela de consulta de capitulos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
 testRunner.When(string.Format("faço um busca por capitulo informando um produto que não foi cadastrado no sistem" +
                        "a {0}", nomeProduto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 60
 testRunner.Then(string.Format("visualizo uma mensagem que não existe dados cadastrados no resultado da busca por" +
                        " capítulo {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por produtos não cadastrados, \"Produto Inexistente\"", new string[] {
                "chrome",
                "ConsultaDeCapituloCT05"}, SourceLine=63)]
        public virtual void BuscaPorProdutosNaoCadastrados_ProdutoInexistente()
        {
#line 57
this.BuscaPorProdutosNaoCadastrados("\"Produto Inexistente\"", "\"Dados não encontratos\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPorProdutoEEpisodiosNaoAssociados(string nomeProduto, string episodio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeCapituloCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca por Produto e Episódios não associados", null, @__tags);
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
this.FeatureBackground();
#line 68
 testRunner.Given("que esteja na tela de consulta de capitulos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 69
 testRunner.When(string.Format("faço um busca por capitulo informando um produto e um episodio que não são associ" +
                        "ados {0}, {1}", nomeProduto, episodio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 70
 testRunner.Then(string.Format("visualizo uma mensagem que não existe dados cadastrados no resultado da busca por" +
                        " capítulo {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por Produto e Episódios não associados, \"Teste INM\"", new string[] {
                "chrome",
                "ConsultaDeCapituloCT06"}, SourceLine=73)]
        public virtual void BuscaPorProdutoEEpisodiosNaoAssociados_TesteINM()
        {
#line 67
this.BuscaPorProdutoEEpisodiosNaoAssociados("\"Teste INM\"", "\"Episodio 120\"", "\"Dados não encontratos\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
