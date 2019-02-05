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
    [TechTalk.SpecRun.FeatureAttribute("3.1.4 - Alterações de DDA", new string[] {
            "chrome",
            "kill_Driver",
            "DDA",
            "AlteracaoDeDDA"}, SourceFile="Features\\Obra\\DDA\\3.1.4 - Alteração de DDA.feature", SourceLine=6)]
    public partial class _3_1_4_AlteracoesDeDDAFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.4 - Alteração de DDA.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.4 - Alterações de DDA", null, ProgrammingLanguage.CSharp, new string[] {
                        "chrome",
                        "kill_Driver",
                        "DDA",
                        "AlteracaoDeDDA"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Alteração de Nome Fantasia com sucesso", new string[] {
                "chrome",
                "AlteracaoDeDDACT01"}, SourceLine=13)]
        public virtual void AlteracaoDeNomeFantasiaComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteração de Nome Fantasia com sucesso", null, new string[] {
                        "chrome",
                        "AlteracaoDeDDACT01"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
 testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 16
    testRunner.When("altero e salvo o campo Nome Fantasia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 17
    testRunner.Then("visualizo o DDA alterado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void AlteracaoDeRazaoSocialDoDDA(string razaoSocial, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoDeDDACT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteração de Razão Social do DDA", null, @__tags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 21
 testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 22
    testRunner.When(string.Format("altero e salvo o campo Razão Social {0}", razaoSocial), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 23
    testRunner.Then("visualizo o DDA alterado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alteração de Razão Social do DDA, \"Teste INM\"", new string[] {
                "chrome",
                "AlteracaoDeDDACT02"}, SourceLine=26)]
        public virtual void AlteracaoDeRazaoSocialDoDDA_TesteINM()
        {
#line 20
this.AlteracaoDeRazaoSocialDoDDA("\"Teste INM\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar DDA que não esteja sendo utilizado em obras", new string[] {
                "chrome",
                "AlteracaoDeDDACT03"}, SourceLine=29)]
        public virtual void AlterarDDAQueNaoEstejaSendoUtilizadoEmObras()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar DDA que não esteja sendo utilizado em obras", null, new string[] {
                        "chrome",
                        "AlteracaoDeDDACT03"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 31
    testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 32
    testRunner.When("altero e salvo o DDA sem obras", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 33
    testRunner.Then("visualizo o DDA alterado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar DDA associado a uma obra sem fonograma", new string[] {
                "chrome",
                "AlteracaoDeDDACT04"}, SourceLine=35)]
        public virtual void AlterarDDAAssociadoAUmaObraSemFonograma()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar DDA associado a uma obra sem fonograma", null, new string[] {
                        "chrome",
                        "AlteracaoDeDDACT04"});
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 37
    testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 38
    testRunner.When("altero e salvo o DDA sem fonograma", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 39
    testRunner.Then("visualizo o DDA alterado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar alteração de DDA na pesquisa", new string[] {
                "chrome",
                "AlteracaoDeDDACT05"}, SourceLine=41)]
        public virtual void ValidarAlteracaoDeDDANaPesquisa()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar alteração de DDA na pesquisa", null, new string[] {
                        "chrome",
                        "AlteracaoDeDDACT05"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 43
      testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 44
   testRunner.When("altero os campos obrigatorios de DDA e salvo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 45
   testRunner.Then("visualizo o DDA alterado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void CancelarAlteracao(string razaoSocial, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoDeDDACT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar alteração", null, @__tags);
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 49
 testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 50
    testRunner.When(string.Format("altero a Razão Social, e realizo o cancelamento da edição {0}", razaoSocial), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 51
    testRunner.Then("visualizo a confirmação de cancelamento de edição do DDA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar alteração, \"Teste 012\"", new string[] {
                "chrome",
                "AlteracaoDeDDACT06"}, SourceLine=54)]
        public virtual void CancelarAlteracao_Teste012()
        {
#line 48
this.CancelarAlteracao("\"Teste 012\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlteracaoDaAssociacaoDoDDAParaSemAssociacao(string associacao, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlteracaoDeDDACT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteração da Associação do DDA para Sem associação", null, @__tags);
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 59
      testRunner.Given("que tenho um DDA cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 60
      testRunner.When(string.Format("altero e salvo o campo associação do DDA {0}", associacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 61
      testRunner.Then("visualizo o DDA alterado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alteração da Associação do DDA para Sem associação, \"SEM ASSOCIAÇÃO\"", new string[] {
                "chrome",
                "AlteracaoDeDDACT07"}, SourceLine=64)]
        public virtual void AlteracaoDaAssociacaoDoDDAParaSemAssociacao_SEMASSOCIACAO()
        {
#line 58
this.AlteracaoDaAssociacaoDoDDAParaSemAssociacao("\"SEM ASSOCIAÇÃO\"", ((string[])(null)));
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
