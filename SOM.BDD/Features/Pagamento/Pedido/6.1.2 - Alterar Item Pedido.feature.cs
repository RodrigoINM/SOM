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
    [TechTalk.SpecRun.FeatureAttribute("6.1.2 - Alterar itens de pedido", new string[] {
            "kill_Driver",
            "AlterarItensDePedido",
            "Pedidos"}, SourceFile="Features\\Pagamento\\Pedido\\6.1.2 - Alterar Item Pedido.feature", SourceLine=6)]
    public partial class _6_1_2_AlterarItensDePedidoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.1.2 - Alterar Item Pedido.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "6.1.2 - Alterar itens de pedido", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "AlterarItensDePedido",
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
        
        public virtual void AlterarValorAPagarParaUmItemDePedido(string valorPagamento, string moeda, string taxaDeConversao, string novoValor, string autor, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT01",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar valor a pagar para um item de pedido", null, @__tags);
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
 testRunner.When(string.Format("altero o valor do pagamento, a moeda e a taxa de conversão de um item do pedido {" +
                        "0}, {1}, {2}, {3}", valorPagamento, moeda, taxaDeConversao, autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 17
 testRunner.Then(string.Format("visualizo o novo valor a ser pago para o DDA do Autor na aba de pagamento {0}", novoValor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar valor a pagar para um item de pedido, \"300,00\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT01",
                "Pedidos"}, SourceLine=20)]
        public virtual void AlterarValorAPagarParaUmItemDePedido_30000()
        {
#line 13
this.AlterarValorAPagarParaUmItemDePedido("\"300,00\"", "\"Dólar\"", "\"3,8\"", "\"1.140,00\"", "\"Rodrigo\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarItemBloqueadoParaEdicaoQuandoJaEstiverAprovado(string valorPagamento, string moeda, string taxaDeConversao, string status, string autor, string obra, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT02",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar item bloqueado para edição quando já estiver Aprovado", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 25
    testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 26
 testRunner.And(string.Format("que possua um item com status de aguardando aprovacao {0}, {1}", status, autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
    testRunner.When(string.Format("tento editar esse item {0}", autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 28
    testRunner.Then(string.Format("visualizo os campos de {0}, {1} e {2} bloqueados para edicao", valorPagamento, moeda, taxaDeConversao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar item bloqueado para edição quando já estiver Aprovado, \"300,00\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT02",
                "Pedidos"}, SourceLine=31)]
        public virtual void ValidarItemBloqueadoParaEdicaoQuandoJaEstiverAprovado_30000()
        {
#line 24
this.ValidarItemBloqueadoParaEdicaoQuandoJaEstiverAprovado("\"300,00\"", "\"Dólar\"", "\"3,8\"", "\"Aguardando Aprovação\"", "\"ALYNE WAITE\"", "\"TESTE DE 500MB\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RegistrarAutorizacao(string mensagem, string status, string autor, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT03",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Registrar Autorização", null, @__tags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 36
    testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 37
    testRunner.When(string.Format("regsitro a autorizacao para um item do pedido {0}", autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 38
    testRunner.Then(string.Format("visualizo o pop up de confirmação para o DDA selecionado {0}", autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 39
    testRunner.And(string.Format("a mensagem de sucesso apos confirmar a autorizacao do item do pedido {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 40
    testRunner.And(string.Format("visualizo o status de autorizado para o item selecionado {0}", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Registrar Autorização, \"1 item(ns) registrado(s) com sucesso.\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT03",
                "Pedidos"}, SourceLine=43)]
        public virtual void RegistrarAutorizacao_1ItemNsRegistradoSComSucesso_()
        {
#line 35
this.RegistrarAutorizacao("\"1 item(ns) registrado(s) com sucesso.\"", "\"Autorizado\"", "\"ALYNE WAITE\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarOPagamentoParaOAdministradorComSucesso(string pagarAdministrador, string mensagem, string autor, string obra, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT04",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar o pagamento para o Administrador com sucesso", null, @__tags);
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 48
    testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 49
    testRunner.When(string.Format("faço o pagamento ao Administrador {0}", autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 50
    testRunner.Then(string.Format("visualizo a mensagem de sucesso após confirmar o pagamento ao administrador {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 51
    testRunner.And(string.Format("visualizo o campo de pagar ao administrador preenchido {0}, {1}", autor, pagarAdministrador), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar o pagamento para o Administrador com sucesso, \"Sim\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT04",
                "Pedidos"}, SourceLine=54)]
        public virtual void ValidarOPagamentoParaOAdministradorComSucesso_Sim()
        {
#line 47
this.ValidarOPagamentoParaOAdministradorComSucesso("\"Sim\"", "\"Itens do pedido atualizados com sucesso!\"", "\"ALYNE WAITE\"", "\"TESTE DE 500MB\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarOValorDoDNIComSucesso(string valorPagamento, string mensagem, string midia, string obra, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT05",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar o valor do DNI com sucesso", null, @__tags);
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 59
 testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 60
 testRunner.When("adiciono um item de DNI no pedido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 61
 testRunner.And(string.Format("insiro um valor para o campo de pagamento do DNI {0}, {1}", midia, valorPagamento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 62
 testRunner.Then(string.Format("o valor do item de DNI atualizado {0}, {1}, {2}", mensagem, midia, valorPagamento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar o valor do DNI com sucesso, \"300,00\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT05",
                "Pedidos"}, SourceLine=65)]
        public virtual void AlterarOValorDoDNIComSucesso_30000()
        {
#line 58
this.AlterarOValorDoDNIComSucesso("\"300,00\"", "\"Item de pedido alterado com sucesso.\"", "\"DNI\"", "\"TESTE DE 500MB\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarUmItemDePedidoNoDetelheDoPedido(string statusDeAprovacao, string statusFinal, string mensagem, string autor, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT06",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar um item de pedido no detelhe do pedido", null, @__tags);
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 70
 testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 71
 testRunner.When(string.Format("cancelo um item de pedido para um autor {0}, {1}, {2}", mensagem, statusDeAprovacao, autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 72
    testRunner.Then(string.Format("visualizo o item do pedido com o status de cancelado {0}, {1}", statusFinal, autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar um item de pedido no detelhe do pedido, \"Pendente\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT06",
                "Pedidos"}, SourceLine=75)]
        public virtual void CancelarUmItemDePedidoNoDetelheDoPedido_Pendente()
        {
#line 69
this.CancelarUmItemDePedidoNoDetelheDoPedido("\"Pendente\"", "\"Cancelado\"", "\"Total de itens cancelados: 1\"", "\"Autor\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar um item de pedido no detelhe do pedido, \"Aguardando Autorização\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT06",
                "Pedidos"}, SourceLine=75)]
        public virtual void CancelarUmItemDePedidoNoDetelheDoPedido_AguardandoAutorizacao()
        {
#line 69
this.CancelarUmItemDePedidoNoDetelheDoPedido("\"Aguardando Autorização\"", "\"Cancelado\"", "\"Total de itens cancelados: 1\"", "\"Autor2\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void CancelarUmItemDePedidoNaBuscaPorPedido(string statusDeAprovacao, string statusFinal, string mensagem, string autor, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT07",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar um item de pedido na busca por pedido", null, @__tags);
#line 80
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 81
 testRunner.Given("que tenha um pedido previamente cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 82
 testRunner.When(string.Format("cancelo um item de pedido para um autor na busca de pedido {0}, {1}, {2}", mensagem, statusDeAprovacao, autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 83
    testRunner.Then(string.Format("visualizo o item do pedido com o status de cancelado na busca de pedido {0}, {1}", statusFinal, autor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar um item de pedido na busca por pedido, \"Pendente\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT07",
                "Pedidos"}, SourceLine=86)]
        public virtual void CancelarUmItemDePedidoNaBuscaPorPedido_Pendente()
        {
#line 80
this.CancelarUmItemDePedidoNaBuscaPorPedido("\"Pendente\"", "\"Cancelado\"", "\"Total de itens cancelados: 1\"", "\"Autor\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar um item de pedido na busca por pedido, \"Aguardando Autorização\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT07",
                "Pedidos"}, SourceLine=86)]
        public virtual void CancelarUmItemDePedidoNaBuscaPorPedido_AguardandoAutorizacao()
        {
#line 80
this.CancelarUmItemDePedidoNaBuscaPorPedido("\"Aguardando Autorização\"", "\"Cancelado\"", "\"Total de itens cancelados: 1\"", "\"Autor2\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void RemoverRegistroDePagamentoAoAdministradorComSucesso(string mensagem, string autor, string obra, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT08",
                    "Pedidos"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remover registro de Pagamento Ao Administrador com sucesso", null, @__tags);
#line 91
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 92
 testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 93
 testRunner.When(string.Format("removo o registro de pagamento ao administrador {0}, {1}", autor, mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 94
 testRunner.Then(string.Format("visualizo a mensagem de alteração realizada com sucesso ao remover o registro de " +
                        "pagamento ao administrador {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Remover registro de Pagamento Ao Administrador com sucesso, \"Itens do pedido atua" +
            "lizados com sucesso!\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT08",
                "Pedidos"}, SourceLine=97)]
        public virtual void RemoverRegistroDePagamentoAoAdministradorComSucesso_ItensDoPedidoAtualizadosComSucesso()
        {
#line 91
this.RemoverRegistroDePagamentoAoAdministradorComSucesso("\"Itens do pedido atualizados com sucesso!\"", "\"ALYNE WAITE\"", "\"TESTE DE 500MB\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarNacionalidadeParaObrasComPedidoPendente(string tipo, string titutloAlternativo, string iswc, string ano, string obraOriginal, string nacionalidade, string pais, string dominioPublico, string institucional, string blackList, string emblematica, string novaNacionalidade, string novoPais, string autor, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT09",
                    "Obra"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar nacionalidade para obras com pedido pendente", null, @__tags);
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 104
 testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema para uma obra nacional {0}," +
                        " {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", tipo, titutloAlternativo, iswc, ano, obraOriginal, nacionalidade, pais, dominioPublico, institucional, blackList, emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 105
 testRunner.When(string.Format("altero a nacionalidade da obra para internacional {0}, {1}", novaNacionalidade, novoPais), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 106
 testRunner.And("seleciono o pedido a ser afetado pela alteracao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 107
 testRunner.Then("visualizo que os itens do pedido foram cancelados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 108
    testRunner.And("visualizo que foram criados outros itens com o valor referente a tabela de preco " +
                    "internacional", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar nacionalidade para obras com pedido pendente, \"MUSICA COMERCIAL\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT09",
                "Obra"}, SourceLine=111)]
        public virtual void AlterarNacionalidadeParaObrasComPedidoPendente_MUSICACOMERCIAL()
        {
#line 103
this.AlterarNacionalidadeParaObrasComPedidoPendente("\"MUSICA COMERCIAL\"", "\" \"", "\" \"", "\"2018\"", "\"Sim\"", "\"Nacional\"", "\" \"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Internacional\"", "\"Alemanha\"", "\"Autor\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarObraParaDominioPublicoComPedidoPendente(string tipo, string titutloAlternativo, string iswc, string ano, string obraOriginal, string nacionalidade, string pais, string dominioPublico, string institucional, string blackList, string emblematica, string autor1, string autor2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT10",
                    "Obra"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar obra para Dominio Publico com pedido pendente", null, @__tags);
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 116
 testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema para uma obra nacional {0}," +
                        " {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", tipo, titutloAlternativo, iswc, ano, obraOriginal, nacionalidade, pais, dominioPublico, institucional, blackList, emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 117
 testRunner.When("altero a obra para dominio publico", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 118
 testRunner.And("seleciono o pedido a ser afetado pela alteracao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 119
 testRunner.Then(string.Format("visualizo que os itens do pedido foram cancelados {0}, {1}", autor1, autor2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar obra para Dominio Publico com pedido pendente, \"MUSICA COMERCIAL\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT10",
                "Obra"}, SourceLine=122)]
        public virtual void AlterarObraParaDominioPublicoComPedidoPendente_MUSICACOMERCIAL()
        {
#line 115
this.AlterarObraParaDominioPublicoComPedidoPendente("\"MUSICA COMERCIAL\"", "\" \"", "\" \"", "\"2018\"", "\"Sim\"", "\"Nacional\"", "\" \"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Autor\"", "\"Autor2\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarObraParaBlacklistComPedidoPendente(string tipo, string titutloAlternativo, string iswc, string ano, string obraOriginal, string nacionalidade, string pais, string dominioPublico, string institucional, string blackList, string emblematica, string autor1, string autor2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT11",
                    "Obra"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar obra para Blacklist com pedido pendente", null, @__tags);
#line 126
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 127
    testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema para uma obra nacional {0}," +
                        " {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", tipo, titutloAlternativo, iswc, ano, obraOriginal, nacionalidade, pais, dominioPublico, institucional, blackList, emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 128
 testRunner.When("altero a obra para blacklist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 129
 testRunner.Then(string.Format("visualizo que os itens do pedido não foram afetados pela alteração {0}, {1}", autor1, autor2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar obra para Blacklist com pedido pendente, \"MUSICA COMERCIAL\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT11",
                "Obra"}, SourceLine=132)]
        public virtual void AlterarObraParaBlacklistComPedidoPendente_MUSICACOMERCIAL()
        {
#line 126
this.AlterarObraParaBlacklistComPedidoPendente("\"MUSICA COMERCIAL\"", "\" \"", "\" \"", "\"2018\"", "\"Sim\"", "\"Nacional\"", "\" \"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Autor\"", "\"Autor2\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarPorcentagemDosAutoresDaComposicaoDeUmaObraComPedidoPendente(
                    string tipo, 
                    string titutloAlternativo, 
                    string iswc, 
                    string ano, 
                    string obraOriginal, 
                    string nacionalidade, 
                    string pais, 
                    string dominioPublico, 
                    string institucional, 
                    string blackList, 
                    string emblematica, 
                    string autor1, 
                    string autor2, 
                    string statusItem, 
                    string statusFinalItem, 
                    string obra, 
                    string produto, 
                    string porcentagem1, 
                    string porcentagem2, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT12",
                    "Obra"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar porcentagem dos autores da composição de uma obra com pedido pendente", null, @__tags);
#line 136
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 137
    testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema para uma obra nacional {0}," +
                        " {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", tipo, titutloAlternativo, iswc, ano, obraOriginal, nacionalidade, pais, dominioPublico, institucional, blackList, emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 138
 testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 139
 testRunner.And(string.Format("altero a porcentagem dos autores da composição {0}, {1}, {2}, {3}", autor1, autor2, porcentagem1, porcentagem2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 140
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteração através do produto associado {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 141
 testRunner.And(string.Format("faço uma busca pelo pedido através do nome da obra associada {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 142
 testRunner.Then(string.Format("visualizo que os itens anteriores foram cancelados na tela de pagamento {0}, {1}," +
                        " {2}", autor1, autor2, statusItem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 143
 testRunner.And(string.Format("visualizo que existem novos itens a pagar com valores diferentes {0}, {1}, {2}", autor1, autor2, statusFinalItem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar porcentagem dos autores da composição de uma obra com pedido pendente, \"M" +
            "USICA COMERCIAL\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT12",
                "Obra"}, SourceLine=146)]
        public virtual void AlterarPorcentagemDosAutoresDaComposicaoDeUmaObraComPedidoPendente_MUSICACOMERCIAL()
        {
#line 136
this.AlterarPorcentagemDosAutoresDaComposicaoDeUmaObraComPedidoPendente("\"MUSICA COMERCIAL\"", "\" \"", "\" \"", "\"2018\"", "\"Sim\"", "\"Nacional\"", "\" \"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Autor\"", "\"Autor2\"", "\"Cancelado\"", "\"A Pagar\"", "\"Obra\"", "\"Produto\"", "\"30\"", "\"70\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarOsAutoresDaComposicaoDeUmaObraComPedidoPendente(
                    string tipo, 
                    string titutloAlternativo, 
                    string iswc, 
                    string ano, 
                    string obraOriginal, 
                    string nacionalidade, 
                    string pais, 
                    string dominioPublico, 
                    string institucional, 
                    string blackList, 
                    string emblematica, 
                    string autor1, 
                    string autor2, 
                    string statusNovoItem, 
                    string obra, 
                    string produto, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT13",
                    "Obra"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar os Autores da composição de uma obra com pedido pendente", null, @__tags);
#line 150
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 151
 testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema para uma obra nacional {0}," +
                        " {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", tipo, titutloAlternativo, iswc, ano, obraOriginal, nacionalidade, pais, dominioPublico, institucional, blackList, emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 152
 testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 153
 testRunner.And(string.Format("altero todos os autores da composicao {0}, {1}", autor1, autor2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 154
 testRunner.And(string.Format("seleciono o pedido a ser afetado pela alteração através do produto associado {0}", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 155
 testRunner.And(string.Format("faço uma busca pelo pedido através do nome da obra associada {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 156
 testRunner.Then(string.Format("visualizo que os itens anteriores foram cancelados na tela de pagamento e gerados" +
                        " novos itens para os novos compositores {0}, {1}, {2}", autor1, autor2, statusNovoItem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar os Autores da composição de uma obra com pedido pendente, \"MUSICA COMERCI" +
            "AL\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT13",
                "Obra"}, SourceLine=159)]
        public virtual void AlterarOsAutoresDaComposicaoDeUmaObraComPedidoPendente_MUSICACOMERCIAL()
        {
#line 150
this.AlterarOsAutoresDaComposicaoDeUmaObraComPedidoPendente("\"MUSICA COMERCIAL\"", "\" \"", "\" \"", "\"2018\"", "\"Sim\"", "\"Nacional\"", "\" \"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Autor\"", "\"Autor2\"", "\"A Pagar\"", "\"Obra\"", "\"Produto\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ExcluirObraTendoPedidoPendente(
                    string tipo, 
                    string titutloAlternativo, 
                    string iswc, 
                    string ano, 
                    string obraOriginal, 
                    string nacionalidade, 
                    string pais, 
                    string dominioPublico, 
                    string institucional, 
                    string blackList, 
                    string emblematica, 
                    string autor1, 
                    string autor2, 
                    string statusItem, 
                    string obra, 
                    string produto, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarItensDePedidoCT14",
                    "Obra"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir Obra tendo pedido pendente", null, @__tags);
#line 163
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 164
 testRunner.Given(string.Format("que tenha um pedido previamente cadastrado no sistema para uma obra nacional {0}," +
                        " {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", tipo, titutloAlternativo, iswc, ano, obraOriginal, nacionalidade, pais, dominioPublico, institucional, blackList, emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 165
 testRunner.When(string.Format("faço uma busca pela obra associada ao pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 166
 testRunner.And(string.Format("excluo a obra associada a esse pedido {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 168
 testRunner.And(string.Format("faço uma busca pelo pedido através do nome da obra associada {0}", obra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 169
 testRunner.Then(string.Format("visualizo que o pedido e seus itens estão cancelados na tela de busca por pedido " +
                        "{0}, {1}, {2}", autor1, autor2, statusItem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Excluir Obra tendo pedido pendente, \"MUSICA COMERCIAL\"", new string[] {
                "chrome",
                "AlterarItensDePedidoCT14",
                "Obra"}, SourceLine=172)]
        public virtual void ExcluirObraTendoPedidoPendente_MUSICACOMERCIAL()
        {
#line 163
this.ExcluirObraTendoPedidoPendente("\"MUSICA COMERCIAL\"", "\" \"", "\" \"", "\"2018\"", "\"Sim\"", "\"Nacional\"", "\" \"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Não\"", "\"Autor\"", "\"Autor2\"", "\"Cancelado\"", "\"Obra\"", "\"Produto\"", ((string[])(null)));
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
