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
        
        public virtual void CadastrarItemNaCue_SheetComObraTotalmentePreenchidos(string gravadora, string submix, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarCamposGravadoraESubmixCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastrar item na cue-sheet com obra totalmente preenchidos", null, @__tags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 26
    testRunner.Given("que tenha uma obra cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 27
 testRunner.And("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 28
 testRunner.And("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.And("que tenha um item cadastrado na cue-sheet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 30
 testRunner.When(string.Format("altero a Gravadora e o Submix do item da Cue-Sheet {0}, {1}", gravadora, submix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 31
 testRunner.Then(string.Format("visualizo a Gravadora do item atualizada na grid da Cue-Sheet {0}", gravadora), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cadastrar item na cue-sheet com obra totalmente preenchidos, \"SOM LIVRE\"", new string[] {
                "chrome",
                "AlterarCamposGravadoraESubmixCT02"}, SourceLine=34)]
        public virtual void CadastrarItemNaCue_SheetComObraTotalmentePreenchidos_SOMLIVRE()
        {
#line 25
this.CadastrarItemNaCue_SheetComObraTotalmentePreenchidos("\"SOM LIVRE\"", "\"FULLMIX\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarQueNaoEPossivelCadastrarMusicaComTituloEmBranco(string titulo, string gravadora, string submix, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarCamposGravadoraESubmixCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar que não é possivel cadastrar musica com Título em branco", null, @__tags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 39
    testRunner.Given("que tenha uma obra cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 40
 testRunner.And("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 41
 testRunner.And("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 42
 testRunner.When(string.Format("tento cadastrar um item de Cue-Sheet sem preencher o titulo da musica {0}, {1}, {" +
                        "2}", titulo, gravadora, submix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 43
 testRunner.Then("visualizo o campo de Título da obra em destaque", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar que não é possivel cadastrar musica com Título em branco, \" \"", new string[] {
                "chrome",
                "AlterarCamposGravadoraESubmixCT03"}, SourceLine=46)]
        public virtual void ValidarQueNaoEPossivelCadastrarMusicaComTituloEmBranco_()
        {
#line 38
this.ValidarQueNaoEPossivelCadastrarMusicaComTituloEmBranco("\" \"", "\"SOM LIVRE\"", "\"FULLMIX\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void EditarItemDaCue_SheetQueTenhaUmaMusicaDeTransicaoComSucesso(string titulo, string gravadora, string submix, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarCamposGravadoraESubmixCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editar item da cue-sheet que tenha uma musica de transição com sucesso", null, @__tags);
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 51
 testRunner.Given("que tenha uma obra cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 52
 testRunner.And("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 53
 testRunner.And("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 54
 testRunner.And(string.Format("que tenha um item de Cue-Sheet cadastrado com Musica de transição {0}", titulo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 55
 testRunner.When(string.Format("altero a Gravadora e o Submix do item da Cue-Sheet {0}, {1}", gravadora, submix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 56
 testRunner.Then(string.Format("visualizo a Gravadora do item atualizada na grid da Cue-Sheet {0}", gravadora), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Editar item da cue-sheet que tenha uma musica de transição com sucesso, \"Aleatóri" +
            "o\"", new string[] {
                "chrome",
                "AlterarCamposGravadoraESubmixCT04"}, SourceLine=59)]
        public virtual void EditarItemDaCue_SheetQueTenhaUmaMusicaDeTransicaoComSucesso_Aleatorio()
        {
#line 50
this.EditarItemDaCue_SheetQueTenhaUmaMusicaDeTransicaoComSucesso("\"Aleatório\"", "\"SOM LIVRE\"", "\"FULLMIX\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CadastrarItemNaCue_SheetComMusicaDeTransicaoPreenchidos(string titulo, string gravadora, string submix, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarCamposGravadoraESubmixCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastrar item na cue-sheet com musica de transição preenchidos", null, @__tags);
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 64
    testRunner.Given("que tenha uma obra cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 65
 testRunner.And("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 66
 testRunner.And("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 67
 testRunner.And(string.Format("que tenha um item de Cue-Sheet cadastrado com Musica de transição {0}", titulo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 68
 testRunner.When(string.Format("altero a Gravadora e o Submix do item da Cue-Sheet {0}, {1}", gravadora, submix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 69
 testRunner.Then(string.Format("visualizo a Gravadora do item atualizada na grid da Cue-Sheet {0}", gravadora), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cadastrar item na cue-sheet com musica de transição preenchidos, \"Aleatório\"", new string[] {
                "chrome",
                "AlterarCamposGravadoraESubmixCT05"}, SourceLine=72)]
        public virtual void CadastrarItemNaCue_SheetComMusicaDeTransicaoPreenchidos_Aleatorio()
        {
#line 63
this.CadastrarItemNaCue_SheetComMusicaDeTransicaoPreenchidos("\"Aleatório\"", "\"SOM LIVRE\"", "\"FULLMIX\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar que não é possivel cadastrar musica com Autores em branco", new string[] {
                "chrome",
                "AlterarCamposGravadoraESubmixCT06"}, SourceLine=75)]
        public virtual void ValidarQueNaoEPossivelCadastrarMusicaComAutoresEmBranco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar que não é possivel cadastrar musica com Autores em branco", null, new string[] {
                        "chrome",
                        "AlterarCamposGravadoraESubmixCT06"});
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 77
    testRunner.Given("que tenha uma obra cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 78
 testRunner.And("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 79
 testRunner.And("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 80
 testRunner.When("tento cadastrar uma Musica de transição sem informar o Titulo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 81
 testRunner.Then("visualizo o campo de Titulo em destaque", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
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
