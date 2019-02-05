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
    [TechTalk.SpecRun.FeatureAttribute("3.1.4 - Exclusa de DDA", new string[] {
            "kill_Driver",
            "DDA",
            "Exclusao_DDA"}, SourceFile="Features\\Obra\\DDA\\3.1.4 - Exclusa de DDA.feature", SourceLine=6)]
    public partial class _3_1_4_ExclusaDeDDAFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.4 - Exclusa de DDA.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.4 - Exclusa de DDA", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "DDA",
                        "Exclusao_DDA"});
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
#line hidden
        }
        
        public virtual void ExclusaoDeUmDDAComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "Exclusao_DDACT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de um DDA com sucesso", null, @__tags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 14
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
 testRunner.When(string.Format("faco uma busca simples por DDA {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
    testRunner.And(string.Format("excluo o DDA {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.Then(string.Format("visualizo a mensagem de DDA excluido com sucesso {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de um DDA com sucesso, \"Teste INM 600\"", new string[] {
                "chrome",
                "Exclusao_DDACT01"}, SourceLine=20)]
        public virtual void ExclusaoDeUmDDAComSucesso_TesteINM600()
        {
#line 13
this.ExclusaoDeUmDDAComSucesso("\"Teste INM 600\"", "\"Teste INM 600\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 600\"", "\"E-mail\"", "\"teste@teste.com\"", "\"sim\"", "\"Registro excluído com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarAExclusaoDoDDAComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "Exclusao_DDACT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar a exclusão do DDA com sucesso", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 25
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 26
 testRunner.When(string.Format("faco uma busca simples por DDA {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 27
    testRunner.And(string.Format("cancelo a exclusão um DDA com {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 28
    testRunner.Then(string.Format("visualizo o DDA no resultado da busca com sucesso {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar a exclusão do DDA com sucesso, \"Teste INM 601\"", new string[] {
                "chrome",
                "Exclusao_DDACT02"}, SourceLine=31)]
        public virtual void CancelarAExclusaoDoDDAComSucesso_TesteINM601()
        {
#line 24
this.CancelarAExclusaoDoDDAComSucesso("\"Teste INM 601\"", "\"Teste INM 601\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 601\"", "\"E-mail\"", "\"teste@teste.com\"", "\"sim\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoDeEnderecoComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string lOGRADOURO, string bAIRRO, string cIDADE, string uF, string cEP, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "Exclusao_DDACT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de Endereço com sucesso", null, @__tags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 36
    testRunner.Given(string.Format("que tenha um DDA cadastrado com endereço completo {0}, {1}, {2}, {3}, {4}, {5}, {" +
                        "6}, {7}, {8}, {9}, {10}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, lOGRADOURO, bAIRRO, cIDADE, uF, cEP), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 37
    testRunner.When(string.Format("excluo um endereço do DDA {0}", lOGRADOURO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 38
    testRunner.Then(string.Format("visualizo a mensagem de endereço excluido com sucesso {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de Endereço com sucesso, \"Teste INM 602\"", new string[] {
                "chrome",
                "Exclusao_DDACT03"}, SourceLine=41)]
        public virtual void ExclusaoDeEnderecoComSucesso_TesteINM602()
        {
#line 35
this.ExclusaoDeEnderecoComSucesso("\"Teste INM 602\"", "\"Teste INM 602\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Rua 10\"", "\"Centro\"", "\"Bahia\"", "\"BA\"", "\"23847238\"", "\"Registro excluído com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoDeContatoComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "Exclusao_DDACT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de Contato com sucesso", null, @__tags);
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 46
 testRunner.Given(string.Format("que tenha um DDA cadastrado com um contato {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}" +
                        ", {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 47
    testRunner.When(string.Format("excluo um contato do DDA {0}", nOMECONTATO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 48
    testRunner.Then(string.Format("visualizo a mensagem de contato excluido com sucesso {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de Contato com sucesso, \"Teste INM 603\"", new string[] {
                "chrome",
                "Exclusao_DDACT04"}, SourceLine=51)]
        public virtual void ExclusaoDeContatoComSucesso_TesteINM603()
        {
#line 45
this.ExclusaoDeContatoComSucesso("\"Teste INM 603\"", "\"Teste INM 603\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 603\"", "\"E-mail\"", "\"teste@teste.com\"", "\"sim\"", "\"Registro excluído com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoDeContatoQueRecebeAutorizacao(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "Exclusao_DDACT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de Contato que recebe autorização", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 56
    testRunner.Given(string.Format("que tenha um DDA cadastrado com um contato {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}" +
                        ", {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 57
    testRunner.When(string.Format("excluo um contato do DDA {0}", nOMECONTATO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 58
 testRunner.Then(string.Format("visualizo uma mesnagem de critica ao tentar salvar a obra sem o contato {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de Contato que recebe autorização, \"Teste INM 604\"", new string[] {
                "chrome",
                "Exclusao_DDACT05"}, SourceLine=61)]
        public virtual void ExclusaoDeContatoQueRecebeAutorizacao_TesteINM604()
        {
#line 55
this.ExclusaoDeContatoQueRecebeAutorizacao("\"Teste INM 604\"", "\"Teste INM 604\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 604\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Não\"", "\"Não é permitido o cadastro de um DDA sem pelo menos um contato de e-mail que rec" +
                    "eba autorização.\"", ((string[])(null)));
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
