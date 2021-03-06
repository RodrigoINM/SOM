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
    [TechTalk.SpecRun.FeatureAttribute("3.1.4 - Cadastro de DDA", new string[] {
            "chrome",
            "kill_Driver",
            "DDA",
            "CadastroDeDDA"}, SourceFile="Features\\Obra\\DDA\\3.1.4 - Cadastro de DDA.feature", SourceLine=6)]
    public partial class _3_1_4_CadastroDeDDAFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.4 - Cadastro de DDA.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.4 - Cadastro de DDA", null, ProgrammingLanguage.CSharp, new string[] {
                        "chrome",
                        "kill_Driver",
                        "DDA",
                        "CadastroDeDDA"});
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
        
        public virtual void CadastroDeDDAComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastroDeDDACT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de DDA com sucesso", null, @__tags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
 testRunner.When(string.Format("cadastro um novo DDA {0}, {1}, {2}, {3}, {4}, {5}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
 testRunner.And(string.Format("cadastro o contato do DDA {0}, {1}, {2}, {3}", nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.Then(string.Format("visualizo a mensagem de cadastro de DDA com sucesso {0}, {1}", nOMEFANTASIA, mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cadastro de DDA com sucesso, \"Teste INM 605\"", new string[] {
                "chrome",
                "CadastroDeDDACT01"}, SourceLine=20)]
        public virtual void CadastroDeDDAComSucesso_TesteINM605()
        {
#line 14
this.CadastroDeDDAComSucesso("\"Teste INM 605\"", "\"Teste INM 605\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 605\"", "\"E-mail\"", "\"teste@teste.com\"", "\"sim\"", "\"Registro salvo com sucesso\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CadastroDeDDASemContatoParaAutorizacao(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastroDeDDACT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de DDA sem Contato para autorização", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 25
 testRunner.When(string.Format("cadastro um novo DDA {0}, {1}, {2}, {3}, {4}, {5}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
 testRunner.Then(string.Format("visualizo uma mensagem de critica ao salvar a obra sem o contato {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cadastro de DDA sem Contato para autorização, \"Teste INM 606\"", new string[] {
                "chrome",
                "CadastroDeDDACT02"}, SourceLine=29)]
        public virtual void CadastroDeDDASemContatoParaAutorizacao_TesteINM606()
        {
#line 24
this.CadastroDeDDASemContatoParaAutorizacao("\"Teste INM 606\"", "\"Teste INM 606\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Não é permitido o cadastro de um DDA sem pelo menos um contato de e-mail que rec" +
                    "eba autorização.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CadastrarDDASemPreenchimentoDeCampoObrigatorio(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastroDeDDACT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastrar DDA sem preenchimento de campo obrigatório", null, @__tags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 34
    testRunner.When(string.Format("cadastro um DDA sem preenchimento dos campos dos campos obrigatorios {0}, {1}, {2" +
                        "}, {3}, {4}, {5}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 35
 testRunner.Then("visualizo os campos obrigatorios em destaque", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cadastrar DDA sem preenchimento de campo obrigatório, \" \"", new string[] {
                "chrome",
                "CadastroDeDDACT03"}, SourceLine=38)]
        public virtual void CadastrarDDASemPreenchimentoDeCampoObrigatorio_()
        {
#line 33
this.CadastrarDDASemPreenchimentoDeCampoObrigatorio("\" \"", "\" \"", "\" \"", "\" \"", "\" \"", "\" \"", ((string[])(null)));
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
