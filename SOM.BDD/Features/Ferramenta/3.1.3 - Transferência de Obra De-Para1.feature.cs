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
namespace SOM.BDD.Features.Ferramenta
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("3.1.3 - Transferência de Obra (De/Para)", new string[] {
            "kill_Driver",
            "Ferramentas",
            "TransferenciaDeObra"}, SourceFile="Features\\Ferramenta\\3.1.3 - Transferência de Obra De-Para.feature", SourceLine=6)]
    public partial class _3_1_3_TransferenciaDeObraDeParaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.3 - Transferência de Obra De-Para.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.3 - Transferência de Obra (De/Para)", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Ferramentas",
                        "TransferenciaDeObra"});
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
#line 10
#line 11
    testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        public virtual void TransferenciaDeObraDePara(string tituloObraDe, string tituloObraPara, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TransferenciaDeObraCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transferência de Obra (De/Para)", null, @__tags);
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 16
 testRunner.Given("a tela transferência de Obra (De/Para) esteja aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 17
    testRunner.When(string.Format("realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObra" +
                        "Para {0} , {1}", tituloObraDe, tituloObraPara), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 18
    testRunner.Then(string.Format("visualizo a mensagem de transferencia de obra concluida {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transferência de Obra (De/Para), \"AMIANTO\"", new string[] {
                "chrome",
                "TransferenciaDeObraCT01"}, SourceLine=21)]
        public virtual void TransferenciaDeObraDePara_AMIANTO()
        {
#line 15
this.TransferenciaDeObraDePara("\"AMIANTO\"", "\"NOVO AMANHECER\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void TransferenciaDeAutorDeParaComTodosOsCamposEmBranco_(string tituloObraDe, string tituloObraPara, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TransferenciaDeObraCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transferencia de Autor (De/Para) com todos os campos em branco.", null, @__tags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 26
 testRunner.Given("a tela transferência de Obra (De/Para) esteja aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 27
    testRunner.When(string.Format("realizo uma Transferência de obraDe preenchendo os campos TituloObraDe e TituloOb" +
                        "raPara {0} , {1}", tituloObraDe, tituloObraPara), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 28
    testRunner.Then("visualizo os campos TituloObraDe e TituloObraPara em destaque para preenchimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transferencia de Autor (De/Para) com todos os campos em branco., \" \"", new string[] {
                "chrome",
                "TransferenciaDeObraCT02"}, SourceLine=31)]
        public virtual void TransferenciaDeAutorDeParaComTodosOsCamposEmBranco__()
        {
#line 25
this.TransferenciaDeAutorDeParaComTodosOsCamposEmBranco_("\" \"", "\" \"", ((string[])(null)));
#line hidden
        }
        
        public virtual void TransferenciaDeObraDeParaComTituloObraInexistente(string tituloObraDe, string tituloObraPara, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TransferenciaDeObraCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transferência de Obra (De/Para) com Título Obra inexistente", null, @__tags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 36
 testRunner.Given("a tela transferência de Obra (De/Para) esteja aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 37
 testRunner.When(string.Format("realizo uma Transferência de obraDe preenchendo os campos TituloObraDe e TituloOb" +
                        "raPara {0} , {1}", tituloObraDe, tituloObraPara), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 38
    testRunner.Then("visualizo os campos TituloObraDe em destaque para preenchimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transferência de Obra (De/Para) com Título Obra inexistente, \"kdhjf\"", new string[] {
                "chrome",
                "TransferenciaDeObraCT03"}, SourceLine=41)]
        public virtual void TransferenciaDeObraDeParaComTituloObraInexistente_Kdhjf()
        {
#line 35
this.TransferenciaDeObraDeParaComTituloObraInexistente("\"kdhjf\"", "\"NOVO AMANHECER\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void TransferenciaDeDDADeParaComNomeDDAParaInexistente_(string tituloObraDe, string tituloObraPara, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TransferenciaDeObraCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transferencia de DDA (De/Para) com Nome DDA(Para) inexistente.", null, @__tags);
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 46
 testRunner.Given("a tela transferência de Obra (De/Para) esteja aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 47
 testRunner.When(string.Format("realizo uma Transferência de obraDe preenchendo os campos TituloObraDe e TituloOb" +
                        "raPara {0} , {1}", tituloObraDe, tituloObraPara), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 48
    testRunner.Then("visualizo os campos TituloObraPara em destaque para preenchimento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transferencia de DDA (De/Para) com Nome DDA(Para) inexistente., \"NOVO AMANHECER\"", new string[] {
                "chrome",
                "TransferenciaDeObraCT04"}, SourceLine=51)]
        public virtual void TransferenciaDeDDADeParaComNomeDDAParaInexistente__NOVOAMANHECER()
        {
#line 45
this.TransferenciaDeDDADeParaComNomeDDAParaInexistente_("\"NOVO AMANHECER\"", "\"kdhjf\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void TransferenciaDeDDADeParaSelecionandoACheckboxExcluir(string tituloObraPara, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TransferenciaDeObraCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transferencia de DDA (De/Para) selecionando a checkbox excluir", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 56
 testRunner.Given("que a tenho uma Obra disponivel para exclusão", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 57
 testRunner.When(string.Format("realizo uma Transferência preenchendo os campos TituloObraDe e TituloObraPara <Ti" +
                        "tuloObraDe> , {0}", tituloObraPara), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 58
    testRunner.And("seleciono a CheckBox de exclusão de ObraDe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 59
 testRunner.Then(string.Format("visualizo a mensagem de confirmação de exclusão da ObraDe {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transferencia de DDA (De/Para) selecionando a checkbox excluir, \"NOVO AMANHECER\"", new string[] {
                "chrome",
                "TransferenciaDeObraCT05"}, SourceLine=62)]
        public virtual void TransferenciaDeDDADeParaSelecionandoACheckboxExcluir_NOVOAMANHECER()
        {
#line 55
this.TransferenciaDeDDADeParaSelecionandoACheckboxExcluir("\"NOVO AMANHECER\"", "\"Obra excluída com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void TransferenciaDeDDADeParaComNomeDDADeParaIguais_(string tituloObraDe, string tituloObraPara, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TransferenciaDeObraCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transferencia de DDA (De/Para) com Nome DDA (De/Para) iguais.", null, @__tags);
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 67
 testRunner.Given("a tela transferência de Obra (De/Para) esteja aberta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 68
 testRunner.When(string.Format("realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObra" +
                        "Para {0} , {1}", tituloObraDe, tituloObraPara), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 69
    testRunner.Then(string.Format("visualizo a mensagem de Obra, operação cancelada {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transferencia de DDA (De/Para) com Nome DDA (De/Para) iguais., \"NOVO AMANHECER\"", new string[] {
                "chrome",
                "TransferenciaDeObraCT06"}, SourceLine=72)]
        public virtual void TransferenciaDeDDADeParaComNomeDDADeParaIguais__NOVOAMANHECER()
        {
#line 66
this.TransferenciaDeDDADeParaComNomeDDADeParaIguais_("\"NOVO AMANHECER\"", "\"NOVO AMANHECER\"", "\"Operação cancelada, não permitido fazer a transferência para a mesma obra.\"", ((string[])(null)));
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
