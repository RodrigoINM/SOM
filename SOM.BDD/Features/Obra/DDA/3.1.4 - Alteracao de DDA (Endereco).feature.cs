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
namespace SOM.BDD.Features.Obra.DDA
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("3.1.4 - Alterações de DDA - Endereço", new string[] {
            "chrome",
            "kill_Driver",
            "DDA",
            "AlteracaoDeEndereçoDDA"}, SourceFile="Features\\Obra\\DDA\\3.1.4 - Alteracao de DDA (Endereco).feature", SourceLine=6)]
    public partial class _3_1_4_AlteracoesDeDDA_EnderecoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.4 - Alteracao de DDA (Endereco).feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.4 - Alterações de DDA - Endereço", null, ProgrammingLanguage.CSharp, new string[] {
                        "chrome",
                        "kill_Driver",
                        "DDA",
                        "AlteracaoDeEndereçoDDA"});
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
#line 9
#line 10
    testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 11
    testRunner.And("que estou com a tela Novo Cadastro de DDA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
        }
        
        public virtual void AlteracaoDeEnderecoComSucesso(string logradouro, string bairro, string cidade, string uF, string cEP, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoEnderecoDeDDACT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteração de endereço com sucesso", null, @__tags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
    testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 16
    testRunner.And(string.Format("altero os campos de endereço do DDA {0}, {1}, {2}, {3} e {4}", logradouro, bairro, cidade, uF, cEP), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
    testRunner.Then(string.Format("visualizo a mensagem de enderço do DDA alterado com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alteração de endereço com sucesso, \"Rua Teste, n° 1\"", new string[] {
                "chrome",
                "AlteracaoEnderecoDeDDACT01"}, SourceLine=20)]
        public virtual void AlteracaoDeEnderecoComSucesso_RuaTesteN1()
        {
#line 14
this.AlteracaoDeEnderecoComSucesso("\"Rua Teste, n° 1\"", "\"Bairro Teste\"", "\"Teste\"", "\"RJ\"", "\"24546-787\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlteracaoDePais(string pais, string logradouro, string bairro, string cidade, string uF, string cEP, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoEnderecoDeDDACT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteracao de país", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 25
 testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 26
    testRunner.And(string.Format("altero os campos de endereço internacional do DDA {0}, {1}, {2}, {3}, {4} e {5}", pais, logradouro, bairro, cidade, uF, cEP), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
    testRunner.Then(string.Format("visualizo a mensagem de enderço do DDA alterado com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alteracao de país, \"Portugal\"", new string[] {
                "chrome",
                "AlteracaoEnderecoDeDDACT02"}, SourceLine=30)]
        public virtual void AlteracaoDePais_Portugal()
        {
#line 24
this.AlteracaoDePais("\"Portugal\"", "\"Rua Teste, n° 1\"", "\"Bairro Teste\"", "\"Teste\"", "\"RJ\"", "\"24546-787\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
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