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
namespace SOM.BDD.Features.UsoEReporte.Cue_Sheet
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("5.2.19 - Alterar campos Gravadora e Submix", new string[] {
            "kill_Driver",
            "AlterarCamposGravadoraESubmix"}, SourceFile="Features\\UsoEReporte\\Cue-Sheet\\5.2.19 - Alterar campos Gravadora e Submix.feature" +
        "", SourceLine=5)]
    public partial class _5_2_19_AlterarCamposGravadoraESubmixFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "5.2.19 - Alterar campos Gravadora e Submix.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "5.2.19 - Alterar campos Gravadora e Submix", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "AlterarCamposGravadoraESubmix"});
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
#line 8
#line 9
      testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        public virtual void EditarItemDaCue_SheetQueTenhaUmaObraComSucesso(string gravadora, string submix, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarCamposGravadoraESubmixCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editar item da cue-sheet que tenha uma obra com sucesso", null, @__tags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 13
 testRunner.Given("que tenha uma obra cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.And("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.And("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.And("que tenha um item cadastrado na cue-sheet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.When(string.Format("altero a Gravadora e o Submix do item da Cue-Sheet {0}, {1}", gravadora, submix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 18
 testRunner.Then(string.Format("visualizo a Gravadora do item atualizada na grid da Cue-Sheet {0}", gravadora), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Editar item da cue-sheet que tenha uma obra com sucesso, \"SOM LIVRE\"", new string[] {
                "chrome",
                "AlterarCamposGravadoraESubmixCT01"}, SourceLine=21)]
        public virtual void EditarItemDaCue_SheetQueTenhaUmaObraComSucesso_SOMLIVRE()
        {
#line 12
this.EditarItemDaCue_SheetQueTenhaUmaObraComSucesso("\"SOM LIVRE\"", "\"FULLMIX\"", ((string[])(null)));
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
