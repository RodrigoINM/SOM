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
namespace SOM.BDD.Features.Produto
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("4.1.7 - Alteração de Produto", new string[] {
            "kill_Driver",
            "Produto",
            "AlteracaoDeProduto"}, Description="Como usuário com permissão para alterar produtos cadastrados\r\nQuero poder alterar" +
        " as informações de produto com uma mídia já cadastrada no sistema\r\nPara utilzar " +
        "esta informação no cadastro de uma cue-sheet associada ao produto", SourceFile="Features\\Produto\\4.1.7 - Alterar Produto.feature", SourceLine=5)]
    public partial class _4_1_7_AlteracaoDeProdutoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "4.1.7 - Alterar Produto.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "4.1.7 - Alteração de Produto", "Como usuário com permissão para alterar produtos cadastrados\r\nQuero poder alterar" +
                    " as informações de produto com uma mídia já cadastrada no sistema\r\nPara utilzar " +
                    "esta informação no cadastro de uma cue-sheet associada ao produto", ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Produto",
                        "AlteracaoDeProduto"});
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
#line 12
#line 13
    testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        public virtual void AlterarProduto(string nome, string episodio, string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoDeProdutoCCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar Produto", null, @__tags);
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 17
 testRunner.Given("que tenha um produto cadastrado no sistema sem possuir um capitulo relacionado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 18
 testRunner.When(string.Format("altero os dados desse produto {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nome, episodio, generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 19
    testRunner.Then(string.Format("visualizo os dados alterados com sucesso na tela do produto {0}, {1}, {2}, {3}, {" +
                        "4}, {5}, {6}, {7}, {8}, {9}", nome, episodio, generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar Produto, \"Aleatório\"", new string[] {
                "chrome",
                "AlteracaoDeProdutoCCT01"}, SourceLine=22)]
        public virtual void AlterarProduto_Aleatorio()
        {
#line 16
this.AlterarProduto("\"Aleatório\"", "\"Aleatório\"", "\"Minissérie\"", "\"ESPORTE\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"SPORTV\"", "\"Não\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarProdutoComInformacoesDeOutroProdutoPreviamenteCadastrado(string nome, string episodio, string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoDeProdutoCCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar Produto com informações de outro produto previamente cadastrado", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 27
 testRunner.Given("que tenha um produto cadastrado no sistema sem possuir um capitulo relacionado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 28
 testRunner.And("que tenha cadastrado mais um produto no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.When(string.Format("altero os dados desse produto para que possua os mesmos dados de um produto previ" +
                        "amente cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nome, episodio, generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 30
    testRunner.Then(string.Format("visualizo uma mensagem de erro informando que já existe um produto cadastrado com" +
                        " essas informações {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar Produto com informações de outro produto previamente cadastrado, \"Aleatór" +
            "io\"", new string[] {
                "chrome",
                "AlteracaoDeProdutoCCT02"}, SourceLine=33)]
        public virtual void AlterarProdutoComInformacoesDeOutroProdutoPreviamenteCadastrado_Aleatorio()
        {
#line 26
this.AlterarProdutoComInformacoesDeOutroProdutoPreviamenteCadastrado("\"Aleatório\"", "\"Aleatório\"", "\"Minissérie\"", "\"ESPORTE\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"SPORTV\"", "\"Não\"", "\"Existe um registro com esses dados cadastrado no sistema.\"", ((string[])(null)));
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
