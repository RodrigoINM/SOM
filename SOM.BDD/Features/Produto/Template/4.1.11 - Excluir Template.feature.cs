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
namespace SOM.BDD.Features.Produto.Template
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("4.1.11 - Excluir Template", new string[] {
            "kill_Driver",
            "Template",
            "ExclusaoDeTemplateDeProduto"}, Description="Como usuário com permissão para excluir tempplate\r\nQuero poder excluir as informa" +
        "ções do template do produto já cadastrada no sistema\r\nPara indisponibilizar esta" +
        " informação no cadastro de uma cue-sheet", SourceFile="Features\\Produto\\Template\\4.1.11 - Excluir Template.feature", SourceLine=5)]
    public partial class _4_1_11_ExcluirTemplateFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "4.1.11 - Excluir Template.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "4.1.11 - Excluir Template", "Como usuário com permissão para excluir tempplate\r\nQuero poder excluir as informa" +
                    "ções do template do produto já cadastrada no sistema\r\nPara indisponibilizar esta" +
                    " informação no cadastro de uma cue-sheet", ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Template",
                        "ExclusaoDeTemplateDeProduto"});
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
#line 12
#line 13
    testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        public virtual void ExcluirItemDeTemplate(string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir Item de Template", null, @__tags);
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 17
 testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 18
 testRunner.When("excluo o item de template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 19
 testRunner.Then(string.Format("visualizo uma mensagem de item de template excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir Item de Template, \"Registros excluídos com sucesso.\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT01"}, SourceLine=22)]
        public virtual void ExcluirItemDeTemplate_RegistrosExcluidosComSucesso_()
        {
#line 16
this.ExcluirItemDeTemplate("\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirItemDeTemplateDentroDeUmBloco(string bloco, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir Item de Template dentro de um Bloco", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 27
 testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 28
 testRunner.And(string.Format("adiciono um bloco para o item de template criado {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.When("excluo o item de template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 30
 testRunner.Then(string.Format("visualizo uma mensagem de item de template excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir Item de Template dentro de um Bloco, \"Teste de Bloco\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT02"}, SourceLine=33)]
        public virtual void ExcluirItemDeTemplateDentroDeUmBloco_TesteDeBloco()
        {
#line 26
this.ExcluirItemDeTemplateDentroDeUmBloco("\"Teste de Bloco\"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirItemDeTemplateDentroDeUmaMateria(string bloco, string materia, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir Item de Template dentro de uma Materia", null, @__tags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 38
 testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 39
 testRunner.And(string.Format("adiciono um bloco para o item de template criado {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 40
 testRunner.And(string.Format("adiciono uma materia para o item de template criado {0}", materia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 41
 testRunner.When("excluo o item de template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 42
 testRunner.Then(string.Format("visualizo uma mensagem de item de template excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir Item de Template dentro de uma Materia, \"Teste de Bloco\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT03"}, SourceLine=45)]
        public virtual void ExcluirItemDeTemplateDentroDeUmaMateria_TesteDeBloco()
        {
#line 37
this.ExcluirItemDeTemplateDentroDeUmaMateria("\"Teste de Bloco\"", "\"Teste de Materia\"", "\"Registros excluídos com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirUmaMateria(string bloco, string materia, string mensagemExclusaoMateria, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir uma matéria", null, @__tags);
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 50
 testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 51
 testRunner.And(string.Format("adiciono um bloco para o item de template criado {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 52
 testRunner.And(string.Format("adiciono uma materia para o item de template criado {0}", materia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 53
 testRunner.When(string.Format("excluo a materia dentro de um bloco {0}, {1}", materia, mensagemExclusaoMateria), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 54
 testRunner.Then(string.Format("visualizo uma mensagem de materia excluida com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir uma matéria, \"Bloco\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT04"}, SourceLine=57)]
        public virtual void ExcluirUmaMateria_Bloco()
        {
#line 49
this.ExcluirUmaMateria("\"Bloco\"", "\"Materia\"", "\"A matéria Materia será excluída. Deseja continuar?\"", "\"Matéria excluída com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirUmBloco(string bloco, string mensagemExclusaoBloco, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir um Bloco", null, @__tags);
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 62
 testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 63
 testRunner.And(string.Format("adiciono um bloco para o item de template criado {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 64
 testRunner.When(string.Format("excluo um bloco do template {0}, {1}", bloco, mensagemExclusaoBloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 65
 testRunner.Then(string.Format("visualizo uma mensagem de bloco excluido com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir um Bloco, \"Bloco\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT05"}, SourceLine=68)]
        public virtual void ExcluirUmBloco_Bloco()
        {
#line 61
this.ExcluirUmBloco("\"Bloco\"", "\"O bloco Bloco será excluído. Deseja continuar?\"", "\"Bloco excluído com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarExclusaoDeUmaMateria(string bloco, string materia, string mensagemExclusaoMateria, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar exclusão de uma matéria", null, @__tags);
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 73
 testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 74
 testRunner.And(string.Format("adiciono um bloco para o item de template criado {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 75
 testRunner.And(string.Format("adiciono uma materia para o item de template criado {0}", materia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 76
 testRunner.When(string.Format("cancelo a exclusão da materia dentro de um bloco {0}, {1}", materia, mensagemExclusaoMateria), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 77
 testRunner.Then(string.Format("visualizo a Materia e o Bloco na grid de template com sucesso {0}, {1}", bloco, materia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar exclusão de uma matéria, \"Bloco\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT06"}, SourceLine=80)]
        public virtual void CancelarExclusaoDeUmaMateria_Bloco()
        {
#line 72
this.CancelarExclusaoDeUmaMateria("\"Bloco\"", "\"Materia\"", "\"A matéria Materia será excluída. Deseja continuar?\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarExclusaoDeUmBloco(string bloco, string mensagemExclusaoBloco, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ExclusaoDeTemplateDeProdutoCT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar exclusão de um Bloco", null, @__tags);
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 85
    testRunner.Given("que tenha um produto com template cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 86
 testRunner.And(string.Format("adiciono um bloco para o item de template criado {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 87
 testRunner.When(string.Format("cancelo a exclusão da materia dentro de um bloco {0}, {1}", bloco, mensagemExclusaoBloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 88
 testRunner.Then(string.Format("visualizo o Bloco na grid de template com sucesso {0}", bloco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar exclusão de um Bloco, \"Bloco\"", new string[] {
                "chrome",
                "ExclusaoDeTemplateDeProdutoCT07"}, SourceLine=91)]
        public virtual void CancelarExclusaoDeUmBloco_Bloco()
        {
#line 84
this.CancelarExclusaoDeUmBloco("\"Bloco\"", "\"O bloco Bloco será excluído. Deseja continuar?\"", ((string[])(null)));
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
