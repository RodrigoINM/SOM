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
namespace SOM.BDD.Features.Pagamento.Pedido
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("6.1.10 - Seleção de itens e atualização do Valor Total", new string[] {
            "kill_Driver",
            "CriarPedidoManual",
            "Pedidos"}, SourceFile="Features\\Pagamento\\Pedido\\6.1.10 - Exibir Valor Total do Pedido.feature", SourceLine=6)]
    public partial class _6_1_10_SelecaoDeItensEAtualizacaoDoValorTotalFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.1.10 - Exibir Valor Total do Pedido.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "6.1.10 - Seleção de itens e atualização do Valor Total", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "CriarPedidoManual",
                        "Pedidos"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Seleção de um item", new string[] {
                "chrome",
                "CriarPedidoManualCT01"}, SourceLine=12)]
        public virtual void SelecaoDeUmItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seleção de um item", null, new string[] {
                        "chrome",
                        "CriarPedidoManualCT01"});
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 14
 testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
 testRunner.And("que esteja na aba de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.When("seleciono um item do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 17
 testRunner.Then("visualizo o valor total do item selecionado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Soma de itens no detalhe do pedido", new string[] {
                "chrome",
                "CriarPedidoManualCT02"}, SourceLine=19)]
        public virtual void SomaDeItensNoDetalheDoPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Soma de itens no detalhe do pedido", null, new string[] {
                        "chrome",
                        "CriarPedidoManualCT02"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 21
    testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 22
 testRunner.And("que esteja na aba de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 23
 testRunner.When("seleciono dois itens do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 24
 testRunner.Then("visualizo o valor total da soma dos itens selecionados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtração de itens no detalhe do pedido", new string[] {
                "chrome",
                "CriarPedidoManualCT03"}, SourceLine=26)]
        public virtual void SubtracaoDeItensNoDetalheDoPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtração de itens no detalhe do pedido", null, new string[] {
                        "chrome",
                        "CriarPedidoManualCT03"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 28
    testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 29
 testRunner.And("que esteja na aba de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 30
    testRunner.When("seleciono todos os itens do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 31
    testRunner.And("retiro da selecao um item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 32
    testRunner.Then("visualizo o valor total menos o valor do item nao selecionado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Soma de itens na busca por pedido", new string[] {
                "chrome",
                "CriarPedidoManualCT04"}, SourceLine=34)]
        public virtual void SomaDeItensNaBuscaPorPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Soma de itens na busca por pedido", null, new string[] {
                        "chrome",
                        "CriarPedidoManualCT04"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 36
 testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 37
 testRunner.And("realizo uma consulta pelo numero do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 38
 testRunner.When("seleciono todos os itens do pedido na aba de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 39
 testRunner.Then("visualizo o valor total da soma dos itens selecionados no resultado da busca", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtração de itens na busca por pedido", new string[] {
                "chrome",
                "CriarPedidoManualCT05"}, SourceLine=41)]
        public virtual void SubtracaoDeItensNaBuscaPorPedido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtração de itens na busca por pedido", null, new string[] {
                        "chrome",
                        "CriarPedidoManualCT05"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 43
    testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 44
    testRunner.And("realizo uma consulta pelo numero do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 45
 testRunner.When("seleciono todos os itens do pedido na aba de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 46
 testRunner.And("retiro da selecao um item do pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 47
 testRunner.Then("visualizo o valor total menos o valor do item não selecionado no resultado da bus" +
                    "ca", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
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
