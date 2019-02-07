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
namespace SOM.BDD.Features.Pagamento.TabelaDePreco
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("6.5.4 - Tabelas de Preço - Fatores", new string[] {
            "kill_Driver",
            "TabelaDePrecoFeatures"}, SourceFile="Features\\Pagamento\\Tabela de Preço\\6.5.4 - Tabelas de Preço - Fatores.feature", SourceLine=5)]
    public partial class _6_5_4_TabelasDePreco_FatoresFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.5.4 - Tabelas de Preço - Fatores.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "6.5.4 - Tabelas de Preço - Fatores", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "TabelaDePrecoFeatures"});
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
        
        public virtual void CriarUmFatorComSucesso(string tabelaDePreco, string midia, string fator, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TabelaDePrecoFeaturesCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um fator com sucesso", null, @__tags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 13
 testRunner.Given(string.Format("que estou na tela de detalhes da tabela de preço desejada {0}", tabelaDePreco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.When(string.Format("cadastro um novo fator para a tabela de preço {0}, {1}", midia, fator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 15
 testRunner.Then(string.Format("visualizo a mensagem de fator incluido com sucesso na tabela de preço {0}, {1}", mensagem, midia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um fator com sucesso, \"UBEM - 2012\"", new string[] {
                "chrome",
                "TabelaDePrecoFeaturesCT01"}, SourceLine=18)]
        public virtual void CriarUmFatorComSucesso_UBEM_2012()
        {
#line 12
this.CriarUmFatorComSucesso("\"UBEM - 2012\"", "\"TV\"", "\"Fator\"", "\"Fator incluído com sucesso\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirUmFatorComSucesso(string tabelaDePreco, string midia, string fator, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TabelaDePrecoFeaturesCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir um fator com sucesso", null, @__tags);
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 23
 testRunner.Given(string.Format("que estou na tela de detalhes da tabela de preço desejada {0}", tabelaDePreco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 24
 testRunner.When(string.Format("cadastro um novo fator para a tabela de preço {0}, {1}", midia, fator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 25
 testRunner.And(string.Format("excluo o fator cadastrado {0}", midia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 26
 testRunner.Then(string.Format("visualizo a mensagem de fator excluido com sucesso na tabela de preço {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir um fator com sucesso, \"UBEM - 2012\"", new string[] {
                "chrome",
                "TabelaDePrecoFeaturesCT02"}, SourceLine=29)]
        public virtual void ExcluirUmFatorComSucesso_UBEM_2012()
        {
#line 22
this.ExcluirUmFatorComSucesso("\"UBEM - 2012\"", "\"TV\"", "\"Fator\"", "\"Fator excluído com sucesso\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CriarMaisDeUmFatorParaAMesmaMidia(string tabelaDePreco, string midia, string fator, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TabelaDePrecoFeaturesCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar mais de um fator para a mesma mídia", null, @__tags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 34
 testRunner.Given(string.Format("que estou na tela de detalhes da tabela de preço desejada {0}", tabelaDePreco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 35
 testRunner.When(string.Format("cadastro um novo fator para a tabela de preço {0}, {1}", midia, fator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 36
 testRunner.And(string.Format("cadastro um fator igual ao já existente {0}, {1}", midia, fator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 37
 testRunner.Then(string.Format("visualizo a mensagem de que já existe um fator para essa midia na tabela de preço" +
                        " {0}, {1}", mensagem, midia), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar mais de um fator para a mesma mídia, \"UBEM - 2012\"", new string[] {
                "chrome",
                "TabelaDePrecoFeaturesCT03"}, SourceLine=40)]
        public virtual void CriarMaisDeUmFatorParaAMesmaMidia_UBEM_2012()
        {
#line 33
this.CriarMaisDeUmFatorParaAMesmaMidia("\"UBEM - 2012\"", "\"TV\"", "\"Fator\"", "\"Já existe um fator para esta mídia.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CriarFatoresComNumerosMuitoAltos(string tabelaDePreco, string midia, string fator, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TabelaDePrecoFeaturesCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar fatores com números muito altos", null, @__tags);
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 45
 testRunner.Given(string.Format("que estou na tela de detalhes da tabela de preço desejada {0}", tabelaDePreco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 46
 testRunner.When(string.Format("cadastro um novo fator para a tabela de preço {0}, {1}", midia, fator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 47
 testRunner.Then(string.Format("visualizo a mensagem de erro ao tentar incluir um fator com valor muito alto na t" +
                        "abela de preço {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar fatores com números muito altos, \"UBEM - 2012\"", new string[] {
                "chrome",
                "TabelaDePrecoFeaturesCT04"}, SourceLine=50)]
        public virtual void CriarFatoresComNumerosMuitoAltos_UBEM_2012()
        {
#line 44
this.CriarFatoresComNumerosMuitoAltos("\"UBEM - 2012\"", "\"TV\"", "\"11111111111111111111111\"", "\"Ocorreu um erro ao salvar o item.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CriarFatoresComNumerosNegativos(string tabelaDePreco, string midia, string fator, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "TabelaDePrecoFeaturesCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar fatores com números negativos", null, @__tags);
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 55
 testRunner.Given(string.Format("que estou na tela de detalhes da tabela de preço desejada {0}", tabelaDePreco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 56
 testRunner.When(string.Format("cadastro um novo fator para a tabela de preço {0}, {1}", midia, fator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 57
 testRunner.Then(string.Format("visualizo a mensagem de erro ao tentar incluir um fator com valor negativo na tab" +
                        "ela de preço {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar fatores com números negativos, \"UBEM - 2012\"", new string[] {
                "chrome",
                "TabelaDePrecoFeaturesCT05"}, SourceLine=60)]
        public virtual void CriarFatoresComNumerosNegativos_UBEM_2012()
        {
#line 54
this.CriarFatoresComNumerosNegativos("\"UBEM - 2012\"", "\"TV\"", "\"-9999\"", "\"Ocorreu um erro ao salvar o item.\"", ((string[])(null)));
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
