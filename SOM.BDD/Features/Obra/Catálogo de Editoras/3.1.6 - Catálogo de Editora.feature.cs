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
namespace SOM.BDD.Features.Obra.CatalogoDeEditoras
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("3.1.6 - Importação de Biblioteca de Catálogo de Editora", new string[] {
            "kill_Driver",
            "Obra",
            "CatalagodeEditora"}, SourceFile="Features\\Obra\\Catálogo de Editoras\\3.1.6 - Catálogo de Editora.feature", SourceLine=6)]
    public partial class _3_1_6_ImportacaoDeBibliotecaDeCatalogoDeEditoraFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.6 - Catálogo de Editora.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "3.1.6 - Importação de Biblioteca de Catálogo de Editora", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Obra",
                        "CatalagodeEditora"});
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
      testRunner.And("a tela de de Catálogo de editora esteja aberto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
        }
        
        public virtual void ImportarBibliotecaComSucesso(string arquivo, string linha, string titulo, string composicao, string nacionalidade, string dominioPublico, string tipo, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CatalagodeEditoraCt01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Importar Biblioteca com sucesso", null, @__tags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
    testRunner.When(string.Format("faço um upload de um {0} válido", arquivo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
    testRunner.Then(string.Format("visualizo a grid com os seguintes colunas na aba Itens Válidos: {0}, {1}, {2}, {3" +
                        "}, {4} e {5}", linha, titulo, composicao, nacionalidade, dominioPublico, tipo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 17
    testRunner.And(string.Format("é salva uma Obra com o {0}", titulo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Importar Biblioteca com sucesso, \"template.xlsx\"", new string[] {
                "chrome",
                "CatalagodeEditoraCt01"}, SourceLine=20)]
        public virtual void ImportarBibliotecaComSucesso_Template_Xlsx()
        {
#line 14
this.ImportarBibliotecaComSucesso("\"template.xlsx\"", "\"1\"", "\"OBRA TEMPLATE\"", "\"Produto Teste\"", "\"Nacional\"", "\"Não\"", "\"TRILHA MUSICAL\"", ((string[])(null)));
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
