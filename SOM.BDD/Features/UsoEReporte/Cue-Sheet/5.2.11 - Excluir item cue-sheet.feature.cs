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
    [TechTalk.SpecRun.FeatureAttribute("5.2.11 - Excluir um item selecionado na cue-sheet", new string[] {
            "kill_Driver",
            "ExcluirItensDeCueSheet"}, SourceFile="Features\\UsoEReporte\\Cue-Sheet\\5.2.11 - Excluir item cue-sheet.feature", SourceLine=5)]
    public partial class _5_2_11_ExcluirUmItemSelecionadoNaCue_SheetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "5.2.11 - Excluir item cue-sheet.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "5.2.11 - Excluir um item selecionado na cue-sheet", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "ExcluirItensDeCueSheet"});
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
        
        public virtual void ExcluirUmItemSelecionadoComSucesso(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir um item selecionado com sucesso", null, @__tags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 13
 testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir um item selecionado com sucesso, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT01"}, SourceLine=19)]
        public virtual void ExcluirUmItemSelecionadoComSucesso_Aleatorio()
        {
#line 12
this.ExcluirUmItemSelecionadoComSucesso("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirTodosOsItensSelecionadosComSucesso(
                    string produto, 
                    string episodio, 
                    string capitulo, 
                    string midia, 
                    string dia, 
                    string mes, 
                    string ano, 
                    string repriseRebatida, 
                    string obra, 
                    string obra2, 
                    string utilizacao, 
                    string sincronismo, 
                    string tempo, 
                    string interprete, 
                    string mensagem, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir todos os itens selecionados com sucesso", null, @__tags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 24
 testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 25
 testRunner.And(string.Format("que tenha dois itens cadastrados na Cue-Sheet {0}, {1}, {2}, {3}, {4}, {5}", obra, obra2, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 26
 testRunner.When(string.Format("excluo os dois itens cadastrados na Cue-Sheet {0}, {1}", obra, obra2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 27
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir todos os itens selecionados com sucesso, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT02"}, SourceLine=30)]
        public virtual void ExcluirTodosOsItensSelecionadosComSucesso_Aleatorio()
        {
#line 23
this.ExcluirTodosOsItensSelecionadosComSucesso("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"TESTE INMETRICS\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarExlusaoDeItemDeCue_Sheet(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar exlusão de item de Cue-Sheet", null, @__tags);
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 35
 testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 36
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 37
 testRunner.When(string.Format("seleciono um item e clico em excluir {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 38
 testRunner.But("cancelo a exclusão do item da Cue-Sheet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Mas ");
#line 39
 testRunner.Then(string.Format("visualizo os dados do item da Cue-Sheet na grid com sucesso {0}, {1}, {2}, {3}", obra, utilizacao, sincronismo, tempo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar exlusão de item de Cue-Sheet, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT03"}, SourceLine=42)]
        public virtual void CancelarExlusaoDeItemDeCue_Sheet_Aleatorio()
        {
#line 34
this.CancelarExlusaoDeItemDeCue_Sheet("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirUmItemPendenteComSucesso(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir um item pendente com sucesso", null, @__tags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 47
 testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 48
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 49
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 50
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir um item pendente com sucesso, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT04"}, SourceLine=53)]
        public virtual void ExcluirUmItemPendenteComSucesso_Aleatorio()
        {
#line 46
this.ExcluirUmItemPendenteComSucesso("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarExclusaoDeUmItemDaCue_Sheet(
                    string produto, 
                    string episodio, 
                    string capitulo, 
                    string midia, 
                    string dia, 
                    string mes, 
                    string ano, 
                    string repriseRebatida, 
                    string obra, 
                    string obra2, 
                    string utilizacao, 
                    string sincronismo, 
                    string tempo, 
                    string interprete, 
                    string mensagem, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar exclusão de um item da cue-sheet", null, @__tags);
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 58
    testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
 testRunner.And(string.Format("que tenha dois itens cadastrados na Cue-Sheet {0}, {1}, {2}, {3}, {4}, {5}", obra, obra2, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 60
 testRunner.When(string.Format("seleciono os itens e clico em excluir {0}, {1}", obra, obra2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 61
 testRunner.But("cancelo a exclusão dos itens da Cue-Sheet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Mas ");
#line 62
 testRunner.Then(string.Format("visualizo os dados dos itens da Cue-Sheet na grid com sucesso {0}, {1}, {2}, {3}," +
                        " {4}", obra, obra2, utilizacao, sincronismo, tempo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar exclusão de um item da cue-sheet, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT05"}, SourceLine=65)]
        public virtual void CancelarExclusaoDeUmItemDaCue_Sheet_Aleatorio()
        {
#line 57
this.CancelarExclusaoDeUmItemDaCue_Sheet("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"TESTE INMETRICS\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoDeItemSemFechamentoAoECADUBEMOuPedidoAssociado(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de item sem fechamento ao ECAD, UBEM ou pedido associado", null, @__tags);
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 70
 testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 71
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 72
 testRunner.And(string.Format("que tenha um item aprovado {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 73
 testRunner.And("que tenha um item com pedido enviado para pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 74
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 75
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de item sem fechamento ao ECAD, UBEM ou pedido associado, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT06"}, SourceLine=78)]
        public virtual void ExclusaoDeItemSemFechamentoAoECADUBEMOuPedidoAssociado_Aleatorio()
        {
#line 69
this.ExclusaoDeItemSemFechamentoAoECADUBEMOuPedidoAssociado("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoDeItemComFechamentoAoECAD(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de item com fechamento ao ECAD", null, @__tags);
#line 82
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 83
    testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 84
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 85
 testRunner.And(string.Format("que tenha um item aprovado {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 86
 testRunner.And("que tenha um item com pedido enviado para pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 87
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 88
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de item com fechamento ao ECAD, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT07"}, SourceLine=91)]
        public virtual void ExclusaoDeItemComFechamentoAoECAD_Aleatorio()
        {
#line 82
this.ExclusaoDeItemComFechamentoAoECAD("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoDeItemComFechamentoAoUBEM(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT08"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão de item com fechamento ao UBEM", null, @__tags);
#line 96
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 97
    testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 98
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 99
 testRunner.And(string.Format("que tenha um item aprovado {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 100
 testRunner.And("que tenha um item com pedido enviado para pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 101
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 102
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão de item com fechamento ao UBEM, \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT08"}, SourceLine=105)]
        public virtual void ExclusaoDeItemComFechamentoAoUBEM_Aleatorio()
        {
#line 96
this.ExclusaoDeItemComFechamentoAoUBEM("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoTotalDeItensComPedidoEmAndamento(string produto, string episodio, string capitulo, string midia, string dia, string mes, string ano, string repriseRebatida, string obra, string utilizacao, string sincronismo, string tempo, string interprete, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT09"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão total de itens com pedido \"Em andamento\"", null, @__tags);
#line 109
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 110
    testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 111
 testRunner.And(string.Format("que tenha um item cadastrado na Cue-Sheet {0}, {1}, {2}, {3}, {4}", obra, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 112
 testRunner.And(string.Format("que tenha um item aprovado {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 113
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 114
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão total de itens com pedido \"Em andamento\", \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT09"}, SourceLine=117)]
        public virtual void ExclusaoTotalDeItensComPedidoEmAndamento_Aleatorio()
        {
#line 109
this.ExclusaoTotalDeItensComPedidoEmAndamento("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExclusaoParcialDeItensComPedidoEmAndamento(
                    string produto, 
                    string episodio, 
                    string capitulo, 
                    string midia, 
                    string dia, 
                    string mes, 
                    string ano, 
                    string repriseRebatida, 
                    string obra, 
                    string obra2, 
                    string utilizacao, 
                    string sincronismo, 
                    string tempo, 
                    string interprete, 
                    string mensagem, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExcluirItensDeCueSheetCT10"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exclusão parcial de itens com pedido \"Em andamento\"", null, @__tags);
#line 121
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 122
    testRunner.Given(string.Format("que tenha uma Cue-Sheet cadastrada no sistema {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "{7}", produto, episodio, capitulo, midia, dia, mes, ano, repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 123
 testRunner.And(string.Format("que tenha dois itens cadastrados na Cue-Sheet {0}, {1}, {2}, {3}, {4}, {5}", obra, obra2, utilizacao, sincronismo, tempo, interprete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 124
 testRunner.And(string.Format("que tenha um item aprovado {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 125
 testRunner.When(string.Format("excluo um item cadastrado na Cue-Sheet {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 126
 testRunner.Then(string.Format("visualizo uma mensagem de registro excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Exclusão parcial de itens com pedido \"Em andamento\", \"Aleatório\"", new string[] {
                "chrome",
                "ExcluirItensDeCueSheetCT10"}, SourceLine=129)]
        public virtual void ExclusaoParcialDeItensComPedidoEmAndamento_Aleatorio()
        {
#line 121
this.ExclusaoParcialDeItensComPedidoEmAndamento("\"Aleatório\"", "\"Aleatório\"", "\"01\"", "\"GLOBONEWS\"", "\"12\"", "\"12\"", "\"2018\"", "\"Não\"", "\"Aleatório\"", "\"TESTE INMETRICS\"", "\"BK – BACKGROUND\"", "\"ABERTURA\"", "\"16\"", "\" \"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
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
