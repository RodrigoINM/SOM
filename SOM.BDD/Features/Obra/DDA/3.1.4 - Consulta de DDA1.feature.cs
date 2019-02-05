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
    [TechTalk.SpecRun.FeatureAttribute("3.1.4 - Consulta de DDA", new string[] {
            "kill_Driver",
            "DDA",
            "ConsultaDeDDA"}, SourceFile="Features\\Obra\\DDA\\3.1.4 - Consulta de DDA.feature", SourceLine=6)]
    public partial class _3_1_4_ConsultaDeDDAFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.4 - Consulta de DDA.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.4 - Consulta de DDA", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "DDA",
                        "ConsultaDeDDA"});
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
        
        public virtual void BuscaSimplesPorDDAComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string tIPO, string dOCUMENTO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca Simples por DDA com sucesso", null, @__tags);
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
 testRunner.Then(string.Format("visualizo os dados do DDA no resultado da busca {0}, {1}, {2}, {3}, {4}", nOMEFANTASIA, nOMECOMPLETO, dOCUMENTO, aSSOCIACAO, tIPO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca Simples por DDA com sucesso, \"Teste INM 607\"", new string[] {
                "chrome",
                "ConsultaDeDDACT01"}, SourceLine=19)]
        public virtual void BuscaSimplesPorDDAComSucesso_TesteINM607()
        {
#line 13
this.BuscaSimplesPorDDAComSucesso("\"Teste INM 607\"", "\"Teste INM 607\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 607\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Sim\"", "\"Administrador\"", "\"546.353.563-57\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorNomeFantasiaComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string tIPO, string dOCUMENTO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Nome Fantasia com sucesso", null, @__tags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 24
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 25
    testRunner.When(string.Format("faço uma busca avançada por nome fantasia de DDA {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
 testRunner.Then(string.Format("visualizo os dados do DDA no resultado da busca {0}, {1}, {2}, {3}, {4}", nOMEFANTASIA, nOMECOMPLETO, dOCUMENTO, aSSOCIACAO, tIPO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Nome Fantasia com sucesso, \"Teste INM 608\"", new string[] {
                "chrome",
                "ConsultaDeDDACT02"}, SourceLine=29)]
        public virtual void BuscaAvancadaPorNomeFantasiaComSucesso_TesteINM608()
        {
#line 23
this.BuscaAvancadaPorNomeFantasiaComSucesso("\"Teste INM 608\"", "\"Teste INM 608\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 608\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Sim\"", "\"Administrador\"", "\"546.353.563-57\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorTipoComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string tIPO, string dOCUMENTO, string fILTROTIPO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Tipo com sucesso", null, @__tags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 34
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 35
    testRunner.When(string.Format("faço uma busca avançada por nome fantasia e tipo de DDA {0}, {1}", nOMEFANTASIA, fILTROTIPO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 36
 testRunner.Then(string.Format("visualizo os dados do DDA no resultado da busca {0}, {1}, {2}, {3}, {4}", nOMEFANTASIA, nOMECOMPLETO, dOCUMENTO, aSSOCIACAO, tIPO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Tipo com sucesso, \"Teste INM 609\"", new string[] {
                "chrome",
                "ConsultaDeDDACT03"}, SourceLine=39)]
        public virtual void BuscaAvancadaPorTipoComSucesso_TesteINM609()
        {
#line 33
this.BuscaAvancadaPorTipoComSucesso("\"Teste INM 609\"", "\"Teste INM 609\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 609\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Sim\"", "\"Administrador\"", "\"546.353.563-57\"", "\"Grupo Editorial\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorAssociacaoComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string tIPO, string dOCUMENTO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Associação com sucesso", null, @__tags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 44
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 45
    testRunner.When(string.Format("faço uma busca avançada por nome fantasia e associação {0}, {1}", nOMEFANTASIA, aSSOCIACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 46
 testRunner.Then(string.Format("visualizo os dados do DDA no resultado da busca {0}, {1}, {2}, {3}, {4}", nOMEFANTASIA, nOMECOMPLETO, dOCUMENTO, aSSOCIACAO, tIPO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Associação com sucesso, \"Teste INM 610\"", new string[] {
                "chrome",
                "ConsultaDeDDACT04"}, SourceLine=49)]
        public virtual void BuscaAvancadaPorAssociacaoComSucesso_TesteINM610()
        {
#line 43
this.BuscaAvancadaPorAssociacaoComSucesso("\"Teste INM 610\"", "\"Teste INM 610\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 610\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Sim\"", "\"Administrador\"", "\"546.353.563-57\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorNomeCompletoRazaoSocialComSucessoComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string tIPO, string dOCUMENTO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Nome Completo / Razão social com sucesso com sucesso", null, @__tags);
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 54
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 55
 testRunner.When(string.Format("faço uma busca avançada por nome fantasia e nome completo {0}, {1}", nOMEFANTASIA, nOMECOMPLETO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 56
 testRunner.Then(string.Format("visualizo os dados do DDA no resultado da busca {0}, {1}, {2}, {3}, {4}", nOMEFANTASIA, nOMECOMPLETO, dOCUMENTO, aSSOCIACAO, tIPO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Nome Completo / Razão social com sucesso com sucesso, \"Teste I" +
            "NM 611\"", new string[] {
                "chrome",
                "ConsultaDeDDACT05"}, SourceLine=59)]
        public virtual void BuscaAvancadaPorNomeCompletoRazaoSocialComSucessoComSucesso_TesteINM611()
        {
#line 53
this.BuscaAvancadaPorNomeCompletoRazaoSocialComSucessoComSucesso("\"Teste INM 611\"", "\"Teste INM 611\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 611\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Sim\"", "\"Administrador\"", "\"546.353.563-57\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPorDDANaoCadastrados(string nOMEFANTASIA, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca por DDA não cadastrados", null, @__tags);
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 64
 testRunner.Given("que esteja com a tela de Busca de DDA aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 65
 testRunner.When(string.Format("faço uma busca avançada por um DDA que não esteja cadastrado no sistema {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 66
 testRunner.Then(string.Format("visualizo uma mensagem de dados não encontrados no resultado da busca {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por DDA não cadastrados, \"Teste 9999999\"", new string[] {
                "chrome",
                "ConsultaDeDDACT06"}, SourceLine=69)]
        public virtual void BuscaPorDDANaoCadastrados_Teste9999999()
        {
#line 63
this.BuscaPorDDANaoCadastrados("\"Teste 9999999\"", "\"Dados não encontratos\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPorCamposNaoAssociados(string nOMEFANTASIA, string nOMECOMPLETO, string mENSAGEM, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca por Campos não associados", null, @__tags);
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 74
 testRunner.Given("que esteja com a tela de Busca de DDA aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 75
 testRunner.When(string.Format("faço uma busca avançada de DDA por dados não relacionados entre si {0}, {1}", nOMEFANTASIA, nOMECOMPLETO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 76
 testRunner.Then(string.Format("visualizo uma mensagem de dados não encontrados no resultado da busca {0}", mENSAGEM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por Campos não associados, \"Teste INM 611\"", new string[] {
                "chrome",
                "ConsultaDeDDACT07"}, SourceLine=79)]
        public virtual void BuscaPorCamposNaoAssociados_TesteINM611()
        {
#line 73
this.BuscaPorCamposNaoAssociados("\"Teste INM 611\"", "\"Teste INM 610\"", "\"Dados não encontratos\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void GerarRelatorioDDAEmExcelComSucesso(string nOMEFANTASIA, string nOMECOMPLETO, string cPF, string aSSOCIACAO, string aDMINISTRADOR, string dATANASCIMENTO, string nOMECONTATO, string tIPOCONTATO, string cONTATO, string aUTORIZACAO, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeDDACT08"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Gerar relatório DDA em Excel com sucesso", null, @__tags);
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 84
 testRunner.Given(string.Format("que tenha um DDA cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", nOMEFANTASIA, nOMECOMPLETO, cPF, aSSOCIACAO, aDMINISTRADOR, dATANASCIMENTO, nOMECONTATO, tIPOCONTATO, cONTATO, aUTORIZACAO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 85
 testRunner.When(string.Format("faço uma busca avançada por nome fantasia e nome completo {0}, {1}", nOMEFANTASIA, nOMECOMPLETO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 86
 testRunner.And("faço download do relatório em excel do resultado da busca", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 87
    testRunner.Then(string.Format("visualizo o download da planilha excel com resultado da busca por DDA {0}", nOMEFANTASIA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Gerar relatório DDA em Excel com sucesso, \"Teste INM 612\"", new string[] {
                "chrome",
                "ConsultaDeDDACT08"}, SourceLine=90)]
        public virtual void GerarRelatorioDDAEmExcelComSucesso_TesteINM612()
        {
#line 83
this.GerarRelatorioDDAEmExcelComSucesso("\"Teste INM 612\"", "\"Teste INM 612\"", "\"54635356357\"", "\"UBEM\"", "\"Sim\"", "\"10/10/1992\"", "\"Contato Teste 612\"", "\"E-mail\"", "\"teste@teste.com\"", "\"Sim\"", ((string[])(null)));
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
