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
    [TechTalk.SpecRun.FeatureAttribute("Validar Status Pav de Pedidos Autorizados para Pagamento", new string[] {
            "kill_Driver",
            "StatusPav",
            "Pedidos"}, SourceFile="Features\\Pagamento\\Pedido\\Status PAV.feature", SourceLine=5)]
    public partial class ValidarStatusPavDePedidosAutorizadosParaPagamentoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Status PAV.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "Validar Status Pav de Pedidos Autorizados para Pagamento", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "StatusPav",
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
#line 8
#line 9
 testRunner.Given("que esteja logado no sistema SOM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        public virtual void AlterarNacionalidadeDaObraParaPedidoComStatusPAVAutorizado(string pedido, string obra, string nacionalidade, string pais, string statusPav, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "StatusPavCT01",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar nacionalidade da obra para pedido com Status PAV Autorizado", null, @__tags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 14
    testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 15
    testRunner.And(string.Format("altero a nacionalidade da obra {0}, {1}, {2}", nacionalidade, pais, obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteracao {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.And(string.Format("faço uma busca pelo pedido afetado {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 18
    testRunner.Then(string.Format("visualizo que o Status Pav do pedido continua como Aprovado {0}, {1}, {2}, {3}, {" +
                        "4}", statusPav, nacionalidade, pais, obra, pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar nacionalidade da obra para pedido com Status PAV Autorizado, \"1000449\"", new string[] {
                "chrome",
                "StatusPavCT01",
                "Pedidos"}, SourceLine=21)]
        public virtual void AlterarNacionalidadeDaObraParaPedidoComStatusPAVAutorizado_1000449()
        {
#line 12
this.AlterarNacionalidadeDaObraParaPedidoComStatusPAVAutorizado("\"1000449\"", "\"MUSICA DE TESTE 4 INT\"", "\"Internacional\"", "\"Alemanha\"", "\"Aprovado\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarAutorDaComposicaoParaQuePossuaDuplicidadeDeUmaObraParaPedidoComStatusPAVAutorizado(string pedido, string obra, string autor, string statusPav, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "StatusPavCT02",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar autor da composição para que possua duplicidade de uma obra para pedido c" +
                    "om Status PAV Autorizado", null, @__tags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 27
    testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 28
    testRunner.And(string.Format("altero um dos autores da composição para que esteja com duplicidade {0}", autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteracao {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 31
    testRunner.Then(string.Format("visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do c" +
                        "ompositor para duplicidade {0}, {1}, {2}", autor, obra, statusPav), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar autor da composição para que possua duplicidade de uma obra para pedido c" +
            "om Status PAV Autorizado, \"1000109\"", new string[] {
                "chrome",
                "StatusPavCT02",
                "Pedidos"}, SourceLine=34)]
        public virtual void AlterarAutorDaComposicaoParaQuePossuaDuplicidadeDeUmaObraParaPedidoComStatusPAVAutorizado_1000109()
        {
#line 25
this.AlterarAutorDaComposicaoParaQuePossuaDuplicidadeDeUmaObraParaPedidoComStatusPAVAutorizado("\"1000109\"", "\"OBRA TESTE 2\"", "\"AUTOR TESTE 2\"", "\"Aprovado\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarAutorParaPedidoComStatusPAVAutorizado(string pedido, string obra, string novoAutor1, string autor1, string statusPav, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "StatusPavCT03",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar autor para pedido com Status PAV Autorizado", null, @__tags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 40
    testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 41
    testRunner.And(string.Format("altero os autores da obra {0}, {1}", autor1, novoAutor1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 42
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteracao {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 44
    testRunner.Then(string.Format("visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do A" +
                        "utor da composição {0}, {1}, {2}, {3}, {4}", autor1, novoAutor1, statusPav, obra, pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar autor para pedido com Status PAV Autorizado, \"1000150\"", new string[] {
                "chrome",
                "StatusPavCT03",
                "Pedidos"}, SourceLine=47)]
        public virtual void AlterarAutorParaPedidoComStatusPAVAutorizado_1000150()
        {
#line 38
this.AlterarAutorParaPedidoComStatusPAVAutorizado("\"1000150\"", "\"TESTE DE CONHECIMENTO\"", "\"ALYNE WAITE\"", "\"ROSANA SILVA\"", "\"Aprovado\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarPorcentagemDosAutoresDaComposicaoDeUmaObraParaPedidoComStatusPAVAutorizado(string pedido, string obra, string autor1, string autor2, string porcentagem1, string porcentagem2, string statusPav, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "StatusPavCT04",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar porcentagem dos autores da composição de uma obra para pedido com Status " +
                    "PAV Autorizado", null, @__tags);
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 53
    testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 54
    testRunner.And(string.Format("altero a porcentagem dos autores da composição {0}, {1}, {2}, {3}", autor1, autor2, porcentagem1, porcentagem2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 55
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteracao {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 57
    testRunner.Then(string.Format("visualizo que o Status Pav do pedido continua como Aprovado apos a alteração da p" +
                        "orcentagem dos Autores da composição {0}, {1}, {2}, {3}, {4}, {5}, {6}", autor1, porcentagem1, autor2, porcentagem2, obra, pedido, statusPav), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar porcentagem dos autores da composição de uma obra para pedido com Status " +
            "PAV Autorizado, \"1000457\"", new string[] {
                "chrome",
                "StatusPavCT04",
                "Pedidos"}, SourceLine=60)]
        public virtual void AlterarPorcentagemDosAutoresDaComposicaoDeUmaObraParaPedidoComStatusPAVAutorizado_1000457()
        {
#line 51
this.AlterarPorcentagemDosAutoresDaComposicaoDeUmaObraParaPedidoComStatusPAVAutorizado("\"1000457\"", "\"CVC Vasco 2018 INT\"", "\"MARCELLE MENDONCA\"", "\"LUAN SANTANA\"", "\"20\"", "\"55\"", "\"Aprovado\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDDAsDeUmaObraParaPedidoComStatusPAVAutorizado(string pedido, string obra, string autor, string dDA, string novoDDA, string statusPav, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "StatusPavCT05",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar DDAs de uma obra para pedido com Status PAV Autorizado", null, @__tags);
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 66
    testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 67
    testRunner.And(string.Format("altero os DDAs dos autores da composição {0}, {1}", autor, novoDDA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 68
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteracao {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 70
    testRunner.Then(string.Format("visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do D" +
                        "DA do Autor da composição {0}, {1}, {2}, {3}, {4}", autor, dDA, obra, pedido, statusPav), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar DDAs de uma obra para pedido com Status PAV Autorizado, \"1000143\"", new string[] {
                "chrome",
                "StatusPavCT05",
                "Pedidos"}, SourceLine=73)]
        public virtual void AlterarDDAsDeUmaObraParaPedidoComStatusPAVAutorizado_1000143()
        {
#line 64
this.AlterarDDAsDeUmaObraParaPedidoComStatusPAVAutorizado("\"1000143\"", "\"DOMITILA\"", "\"RAFAEL LANGONI\"", "\"DECK\"", "\"NOWA\"", "\"Aprovado\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarQuantidadeDeAutoresDeUmaObraParaPedidoComStatusPAVAutorizado(string pedido, string obra, string autor1, string autor2, string dDA, string porcentagem1, string porcentagem2, string porcentagemOriginal, string statusPav, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "StatusPavCT06",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar quantidade de autores de uma obra para pedido com Status PAV Autorizado", null, @__tags);
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 79
    testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 80
 testRunner.And(string.Format("diminuo a porcentagem de um Autor {0}, {1}", autor1, porcentagem1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 81
    testRunner.And(string.Format("acrescento um novo Autor a composição com o percentual restante {0}, {1}, {2}", autor2, dDA, porcentagem2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 82
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteracao {0}", pedido), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 84
    testRunner.Then(string.Format("visualizo que o Status Pav do pedido continua como Aprovado apos a adição de mais" +
                        " um compositor na obra {0}, {1}, {2}, {3}, {4}, {5}", autor1, autor2, porcentagemOriginal, obra, pedido, statusPav), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar quantidade de autores de uma obra para pedido com Status PAV Autorizado, " +
            "\"1000448\"", new string[] {
                "chrome",
                "StatusPavCT06",
                "Pedidos"}, SourceLine=87)]
        public virtual void AlterarQuantidadeDeAutoresDeUmaObraParaPedidoComStatusPAVAutorizado_1000448()
        {
#line 77
this.AlterarQuantidadeDeAutoresDeUmaObraParaPedidoComStatusPAVAutorizado("\"1000448\"", "\"MUSICA DE TESTE 2\"", "\"LUAN SANTANA\"", "\"MARCELLE MENDONCA\"", "\"WARNER CHAPPELL\"", "\"30\"", "\"30\"", "\"60\"", "\"Aprovado\"", ((string[])(null)));
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
