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
namespace SOM.BDD.Features.UsoEReporte.PainelDeExibicao
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("3.1.3 - Painel de Exibição", new string[] {
            "kill_Driver",
            "UsoeReport",
            "PaineldeExibicao"}, SourceFile="Features\\UsoEReporte\\Painel de Exibição\\3.1.3 - Painel de Exibição.feature", SourceLine=6)]
    public partial class _3_1_3_PainelDeExibicaoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.3 - Painel de Exibição.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.3 - Painel de Exibição", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "UsoeReport",
                        "PaineldeExibicao"});
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
 testRunner.And("a tela de painel de exibição esteja aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição sem informar periodo.", new string[] {
                "chrome",
                "PaineldeExibicaoCT01"}, SourceLine=13)]
        public virtual void RealizarBuscaNoPainelDeExibicaoSemInformarPeriodo_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição sem informar periodo.", null, new string[] {
                        "chrome",
                        "PaineldeExibicaoCT01"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
    testRunner.When("realizo uma busca com o campo periodo em branco", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
    testRunner.Then("visualizo o campo periodo em destaque para o preenchimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição sem informar Genero Direitos Musicais.", new string[] {
                "chrome",
                "PaineldeExibicaoCT02"}, SourceLine=18)]
        public virtual void RealizarBuscaNoPainelDeExibicaoSemInformarGeneroDireitosMusicais_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição sem informar Genero Direitos Musicais.", null, new string[] {
                        "chrome",
                        "PaineldeExibicaoCT02"});
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 20
    testRunner.When("realizo uma busca no painel de exibição sem preencher o campo Genero Direitos Mus" +
                    "icais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 21
    testRunner.Then("visualizo o campo Genero Direitos Musicais destacado para preenchimento.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição sem informar Midia.", new string[] {
                "chrome",
                "PaineldeExibicaoCT03"}, SourceLine=23)]
        public virtual void RealizarBuscaNoPainelDeExibicaoSemInformarMidia_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição sem informar Midia.", null, new string[] {
                        "chrome",
                        "PaineldeExibicaoCT03"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 25
    testRunner.When("realizo uma busca no painel de exibição sem preencher o campo Midia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
    testRunner.Then("visualizo o campo Genero Midia destacado para preenchimento.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisDRAMATURGIADIARIA_(string generoDireitosMusicais, string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Genero Direitos Musicais DRAMATURGIA DIÁ" +
                    "RIA.", null, @__tags);
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 30
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusic" +
                        "ais, Midia, Periodo e ano {0}, {1} , {2} , {3}", generoDireitosMusicais, midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 31
    testRunner.Then("visualiso o resultado da pesquisa de Genero Direitos Musicais DRAMATURGIA DIÁRIA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Genero Direitos Musicais DRAMATURGIA DIÁ" +
            "RIA., \"DRAMATURGIA DIÁRIA\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT04"}, SourceLine=34)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisDRAMATURGIADIARIA__DRAMATURGIADIARIA()
        {
#line 29
this.RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisDRAMATURGIADIARIA_("\"DRAMATURGIA DIÁRIA\"", "\"TV\"", "\"outubro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisDRAMATURGIASEMANAL_(string generoDireitosMusicais, string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Genero Direitos Musicais DRAMATURGIA SEM" +
                    "ANAL.", null, @__tags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 39
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusic" +
                        "ais, Midia, Periodo e ano {0}, {1} , {2} , {3}", generoDireitosMusicais, midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 40
    testRunner.Then("visualiso o resultado da pesquisa de Genero Direitos Musicais DRAMATURGIA SEMANAL" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Genero Direitos Musicais DRAMATURGIA SEM" +
            "ANAL., \"DRAMATURGIA SEMANAL\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT05"}, SourceLine=43)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisDRAMATURGIASEMANAL__DRAMATURGIASEMANAL()
        {
#line 38
this.RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisDRAMATURGIASEMANAL_("\"DRAMATURGIA SEMANAL\"", "\"GLOBONEWS\"", "\"outubro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisESPORTE_(string generoDireitosMusicais, string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Genero Direitos Musicais ESPORTE.", null, @__tags);
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 48
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusic" +
                        "ais, Midia, Periodo e ano {0}, {1} , {2} , {3}", generoDireitosMusicais, midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 49
    testRunner.Then("visualiso o resultado da pesquisa de Genero Direitos Musicais ESPORTE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Genero Direitos Musicais ESPORTE., \"ESPO" +
            "RTE\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT06"}, SourceLine=52)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisESPORTE__ESPORTE()
        {
#line 47
this.RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisESPORTE_("\"ESPORTE\"", "\"TV\"", "\"fevereiro\"", "\"2019\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisJORNALISMO_(string generoDireitosMusicais, string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Genero Direitos Musicais JORNALISMO.", null, @__tags);
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 57
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusic" +
                        "ais, Midia, Periodo e ano {0}, {1} , {2} , {3}", generoDireitosMusicais, midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 58
    testRunner.Then("visualiso o resultado da pesquisa de Genero Direitos Musicais JORNALISMO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Genero Direitos Musicais JORNALISMO., \"J" +
            "ORNALISMO\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT07"}, SourceLine=61)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisJORNALISMO__JORNALISMO()
        {
#line 56
this.RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisJORNALISMO_("\"JORNALISMO\"", "\"TV\"", "\"Outubro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisVARIEDADEDIARIA_(string generoDireitosMusicais, string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT08"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Genero Direitos Musicais VARIEDADE DIÁRI" +
                    "A.", null, @__tags);
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 66
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusic" +
                        "ais, Midia, Periodo e ano {0}, {1} , {2} , {3}", generoDireitosMusicais, midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 67
    testRunner.Then("visualiso o resultado da pesquisa de Genero Direitos Musicais VARIEDADE DIÁRIA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Genero Direitos Musicais VARIEDADE DIÁRI" +
            "A., \"VARIEDADE DIÁRIA\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT08"}, SourceLine=70)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisVARIEDADEDIARIA__VARIEDADEDIARIA()
        {
#line 65
this.RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisVARIEDADEDIARIA_("\"VARIEDADE DIÁRIA\"", "\"TV\"", "\"Outubro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisVARIEDADESEMANAL_(string generoDireitosMusicais, string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT09"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Genero Direitos Musicais VARIEDADE SEMAN" +
                    "AL.", null, @__tags);
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 75
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusic" +
                        "ais, Midia, Periodo e ano {0}, {1} , {2} , {3}", generoDireitosMusicais, midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 76
    testRunner.Then("visualiso o resultado da pesquisa de Genero Direitos Musicais VARIEDADE SEMANAL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Genero Direitos Musicais VARIEDADE SEMAN" +
            "AL., \"VARIEDADE SEMANAL\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT09"}, SourceLine=79)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisVARIEDADESEMANAL__VARIEDADESEMANAL()
        {
#line 74
this.RealizarBuscaNoPainelDeExibicaoComGeneroDireitosMusicaisVARIEDADESEMANAL_("\"VARIEDADE SEMANAL\"", "\"TV\"", "\"abril\"", "\"2014\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComMidiaTV_(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT10"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com Mídia TV.", null, @__tags);
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 84
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 85
    testRunner.Then("visualiso o resultado da pesquisa de Midia TV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com Mídia TV., \"TV\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT10"}, SourceLine=88)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComMidiaTV__TV()
        {
#line 83
this.RealizarBuscaNoPainelDeExibicaoComMidiaTV_("\"TV\"", "\"Outubro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComCANALVIVA_(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT11"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com CANAL VIVA.", null, @__tags);
#line 92
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 93
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 94
 testRunner.Then("visualiso o resultado da pesquisa do CANAL VIVA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com CANAL VIVA., \"CANAL VIVA\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT11"}, SourceLine=97)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComCANALVIVA__CANALVIVA()
        {
#line 92
this.RealizarBuscaNoPainelDeExibicaoComCANALVIVA_("\"CANAL VIVA\"", "\"janeiro\"", "\"2019\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComMULTSHOW_(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT12"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com MULTSHOW.", null, @__tags);
#line 101
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 102
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 103
    testRunner.Then("visualiso o resultado da pesquisa do MULTSHOW", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com MULTSHOW., \"MULTSHOW\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT12"}, SourceLine=106)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComMULTSHOW__MULTSHOW()
        {
#line 101
this.RealizarBuscaNoPainelDeExibicaoComMULTSHOW_("\"MULTSHOW\"", "\"fevereiro\"", "\"2019\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComGLOBOPLAY_(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT13"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com GLOBOPLAY.", null, @__tags);
#line 110
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 111
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 112
    testRunner.Then("visualiso o resultado da pesquisa do GLOBOPLAY", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com GLOBOPLAY., \"GLOBOPLAY\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT13"}, SourceLine=115)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComGLOBOPLAY__GLOBOPLAY()
        {
#line 110
this.RealizarBuscaNoPainelDeExibicaoComGLOBOPLAY_("\"GLOBOPLAY\"", "\"setembro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RealizarBuscaNoPainelDeExibicaoComINTERNET_(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT14"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar busca no painel de Exibição com INTERNET.", null, @__tags);
#line 119
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 120
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 121
    testRunner.Then("visualiso o resultado da pesquisa da INTERNET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar busca no painel de Exibição com INTERNET., \"INTERNET\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT14"}, SourceLine=124)]
        public virtual void RealizarBuscaNoPainelDeExibicaoComINTERNET__INTERNET()
        {
#line 119
this.RealizarBuscaNoPainelDeExibicaoComINTERNET_("\"INTERNET\"", "\"junho\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarACorDoStatusFINALIZADADaCue_Sheet(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT15"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar a cor do status \"FINALIZADA\" da cue-sheet", null, @__tags);
#line 128
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 129
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 130
    testRunner.Then("visualiso o resultado da pesquisa com a cue-sheet FINALIZADA na cor azul", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar a cor do status \"FINALIZADA\" da cue-sheet, \"INTERNET\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT15"}, SourceLine=133)]
        public virtual void ValidarACorDoStatusFINALIZADADaCue_Sheet_INTERNET()
        {
#line 128
this.ValidarACorDoStatusFINALIZADADaCue_Sheet("\"INTERNET\"", "\"junho\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarACorDoStatusPARCIALMENTEVALIDADADaCue_Sheet(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT16"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar a cor do status \"PARCIALMENTE VALIDADA\" da cue-sheet", null, @__tags);
#line 137
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 138
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 139
    testRunner.Then("visualiso o resultado da pesquisa com a cue-sheet PARCIALMENTE VALIDADA na cor am" +
                    "arela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar a cor do status \"PARCIALMENTE VALIDADA\" da cue-sheet, \"GLOBONEWS\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT16"}, SourceLine=142)]
        public virtual void ValidarACorDoStatusPARCIALMENTEVALIDADADaCue_Sheet_GLOBONEWS()
        {
#line 137
this.ValidarACorDoStatusPARCIALMENTEVALIDADADaCue_Sheet("\"GLOBONEWS\"", "\"julho\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarACorDoStatusVALIDADADaCue_Sheet(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT17"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar a cor do status \"VALIDADA\" da cue-sheet", null, @__tags);
#line 146
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 147
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 148
    testRunner.Then("visualiso o resultado da pesquisa com a cue-sheet VALIDADA na cor Verde", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar a cor do status \"VALIDADA\" da cue-sheet, \"CANAL VIVA\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT17"}, SourceLine=151)]
        public virtual void ValidarACorDoStatusVALIDADADaCue_Sheet_CANALVIVA()
        {
#line 146
this.ValidarACorDoStatusVALIDADADaCue_Sheet("\"CANAL VIVA\"", "\"setembro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarACorDoStatusEMABERTODaCue_Sheet(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT18"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar a cor do status \"EM ABERTO\" da cue-sheet", null, @__tags);
#line 155
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 156
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 157
    testRunner.Then("visualiso o resultado da pesquisa com a cue-sheet EM ABERTO na cor CINZA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar a cor do status \"EM ABERTO\" da cue-sheet, \"GLOBOPLAY\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT18"}, SourceLine=160)]
        public virtual void ValidarACorDoStatusEMABERTODaCue_Sheet_GLOBOPLAY()
        {
#line 155
this.ValidarACorDoStatusEMABERTODaCue_Sheet("\"GLOBOPLAY\"", "\"setembro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarACorDoStatusCRIADADaCue_Sheet(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT19"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar a cor do status \"CRIADA\" da cue-sheet", null, @__tags);
#line 164
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 165
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 166
    testRunner.Then("visualiso o resultado da pesquisa com a cue-sheet CRIADA na cor VERMELHO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar a cor do status \"CRIADA\" da cue-sheet, \"SPORTV\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT19"}, SourceLine=169)]
        public virtual void ValidarACorDoStatusCRIADADaCue_Sheet_SPORTV()
        {
#line 164
this.ValidarACorDoStatusCRIADADaCue_Sheet("\"SPORTV\"", "\"outubro\"", "\"2018\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarACorDoStatusLIBERADADaCue_Sheet(string midia, string periodo, string ano, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "PaineldeExibicaoCT20"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar a cor do status \"LIBERADA\" da cue-sheet", null, @__tags);
#line 173
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 174
    testRunner.When(string.Format("realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e an" +
                        "o {0} , {1} , {2}", midia, periodo, ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 175
    testRunner.Then("visualiso o resultado da pesquisa com a cue-sheet LIBERADA na cor LARANJA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar a cor do status \"LIBERADA\" da cue-sheet, \"GLOBONEWS\"", new string[] {
                "chrome",
                "PaineldeExibicaoCT20"}, SourceLine=178)]
        public virtual void ValidarACorDoStatusLIBERADADaCue_Sheet_GLOBONEWS()
        {
#line 173
this.ValidarACorDoStatusLIBERADADaCue_Sheet("\"GLOBONEWS\"", "\"novembro\"", "\"2018\"", ((string[])(null)));
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
