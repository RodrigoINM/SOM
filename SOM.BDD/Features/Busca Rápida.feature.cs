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
namespace SOM.BDD.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Consulta pelo menu Busca Rápida", new string[] {
            "kill_Driver",
            "ConsultaRapida"}, SourceFile="Features\\Busca Rápida.feature", SourceLine=5)]
    public partial class ConsultaPeloMenuBuscaRapidaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Busca Rápida.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "Consulta pelo menu Busca Rápida", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "ConsultaRapida"});
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
        
        public virtual void BuscarRapidamenteComSucesso(string buscaRapida, string obra, string mensagemObra, string produto, string mensagemProduto, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaRapidaCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buscar rapidamente com sucesso", null, @__tags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 13
    testRunner.When(string.Format("faço uma consulta no menu de busca rápida {0}", buscaRapida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 14
 testRunner.Then(string.Format("visualizo as obras e produtos no resultado da busca rápida com sucesso {0}, {1}, " +
                        "{2}, {3}", obra, mensagemObra, produto, mensagemProduto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buscar rapidamente com sucesso, \"Teste INM\"", new string[] {
                "chrome",
                "ConsultaRapidaCT01"}, SourceLine=17)]
        public virtual void BuscarRapidamenteComSucesso_TesteINM()
        {
#line 12
this.BuscarRapidamenteComSucesso("\"Teste INM\"", "\"Teste INM\"", "\"Buscar mais obras com: Teste INM\"", "\"Teste INM\"", "\"Buscar mais produtos com: Teste INM\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AcessarConsultaDeObraPelaBuscaRapidaComSucesso(string obra, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaRapidaCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Acessar Consulta de Obra pela Busca Rápida com sucesso", null, @__tags);
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 22
 testRunner.When(string.Format("faço uma consulta no menu de busca rápida {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 23
 testRunner.And(string.Format("acesso a Obra no resultado da busca rápida {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 24
 testRunner.Then(string.Format("visualizo a tela de detalhe da obra com sucesso {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acessar Consulta de Obra pela Busca Rápida com sucesso, \"Aletha920270007\"", new string[] {
                "chrome",
                "ConsultaRapidaCT02"}, SourceLine=27)]
        public virtual void AcessarConsultaDeObraPelaBuscaRapidaComSucesso_Aletha920270007()
        {
#line 21
this.AcessarConsultaDeObraPelaBuscaRapidaComSucesso("\"Aletha920270007\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AcessarConsultaDeProdutoPelaBuscaRapidaComSucesso(string produto, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaRapidaCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Acessar Consulta de Produto pela Busca Rápida com sucesso", null, @__tags);
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 32
    testRunner.When(string.Format("faço uma consulta no menu de busca rápida {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 33
 testRunner.And(string.Format("acesso o Produto no resultado da busca rápida {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 34
 testRunner.Then(string.Format("visualizo a tela de detalhe do Produto com sucesso {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Acessar Consulta de Produto pela Busca Rápida com sucesso, \"Jann313634060 Iarocci" +
            "150695885\"", new string[] {
                "chrome",
                "ConsultaRapidaCT03"}, SourceLine=37)]
        public virtual void AcessarConsultaDeProdutoPelaBuscaRapidaComSucesso_Jann313634060Iarocci150695885()
        {
#line 31
this.AcessarConsultaDeProdutoPelaBuscaRapidaComSucesso("\"Jann313634060 Iarocci150695885\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscarPorTituloCadastradoApenasEmObraComSucesso(string obra, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaRapidaCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buscar por título cadastrado apenas em Obra com sucesso", null, @__tags);
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 42
    testRunner.When(string.Format("faço uma consulta no menu de busca rápida {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 43
 testRunner.Then(string.Format("visualizo a obra no resultado da busca rápida com sucesso {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buscar por título cadastrado apenas em Obra com sucesso, \"Aletha920270007\"", new string[] {
                "chrome",
                "ConsultaRapidaCT04"}, SourceLine=46)]
        public virtual void BuscarPorTituloCadastradoApenasEmObraComSucesso_Aletha920270007()
        {
#line 41
this.BuscarPorTituloCadastradoApenasEmObraComSucesso("\"Aletha920270007\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscarPorTituloCadastradoApenasEmProdutoComSucesso(string produto, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaRapidaCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buscar por título cadastrado apenas em Produto com sucesso", null, @__tags);
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 51
    testRunner.When(string.Format("faço uma consulta no menu de busca rápida {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 52
 testRunner.Then(string.Format("visualizo o produto no resultado da busca rápida com sucesso {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buscar por título cadastrado apenas em Produto com sucesso, \"Jann313634060 Iarocc" +
            "i150695885\"", new string[] {
                "chrome",
                "ConsultaRapidaCT05"}, SourceLine=55)]
        public virtual void BuscarPorTituloCadastradoApenasEmProdutoComSucesso_Jann313634060Iarocci150695885()
        {
#line 50
this.BuscarPorTituloCadastradoApenasEmProdutoComSucesso("\"Jann313634060 Iarocci150695885\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscarPorUmTituloNaoCadastrado(string buscaRapida, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaRapidaCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buscar por um título não cadastrado", null, @__tags);
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 60
 testRunner.When(string.Format("faço uma consulta no menu de busca rápida por um título não cadastrado no sistema" +
                        " {0}", buscaRapida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 61
 testRunner.Then(string.Format("visualizo a mensagem de dados não encontrados na busca rápida {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buscar por um título não cadastrado, \"Teste Inexistente\"", new string[] {
                "chrome",
                "ConsultaRapidaCT06"}, SourceLine=64)]
        public virtual void BuscarPorUmTituloNaoCadastrado_TesteInexistente()
        {
#line 59
this.BuscarPorUmTituloNaoCadastrado("\"Teste Inexistente\"", "\"Nenhum resultado encontrado\"", ((string[])(null)));
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
