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
namespace SOM.BDD.Features.Produto
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("4.1.5 - Consulta Produto", new string[] {
            "kill_Driver",
            "Produto",
            "ConsultaDeProduto"}, SourceFile="Features\\Produto\\4.1.5 - Consulta Produto.feature", SourceLine=6)]
    public partial class _4_1_5_ConsultaProdutoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "4.1.5 - Consulta Produto.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "4.1.5 - Consulta Produto", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Produto",
                        "ConsultaDeProduto"});
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
        
        public virtual void BuscaSimplesPorProdutoProduto(string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca Simples por produto Produto", null, @__tags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 14
 testRunner.Given(string.Format("que eu tenha um produto cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
    testRunner.When("faço uma busca simples pelo produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
 testRunner.Then(string.Format("visualizo o produto no resultado da busca {0}, {1}, {2}, {3}, {4}, {5}, {6} e {7}" +
                        "", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca Simples por produto Produto, \"Novela\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT01"}, SourceLine=19)]
        public virtual void BuscaSimplesPorProdutoProduto_Novela()
        {
#line 13
this.BuscaSimplesPorProdutoProduto("\"Novela\"", "\"DRAMATURGIA SEMANAL\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"GLOBONEWS\"", "\"Não\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorNomeDoProduto(string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Nome do Produto", null, @__tags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 24
 testRunner.Given(string.Format("que eu tenha um produto cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 25
 testRunner.When("faço uma busca avançada por Produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
    testRunner.Then(string.Format("visualizo o produto no resultado da busca {0}, {1}, {2}, {3}, {4}, {5}, {6} e {7}" +
                        "", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Nome do Produto, \"Novela\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT02"}, SourceLine=29)]
        public virtual void BuscaAvancadaPorNomeDoProduto_Novela()
        {
#line 23
this.BuscaAvancadaPorNomeDoProduto("\"Novela\"", "\"DRAMATURGIA SEMANAL\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"GLOBONEWS\"", "\"Não\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorEpisodio(string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Episódio", null, @__tags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 34
 testRunner.Given(string.Format("que eu tenha um produto cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 35
 testRunner.When("faço uma busca avançada por Produto e Episódio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 36
    testRunner.Then(string.Format("visualizo o produto no resultado da busca {0}, {1}, {2}, {3}, {4}, {5}, {6} e {7}" +
                        "", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Episódio, \"Novela\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT03"}, SourceLine=39)]
        public virtual void BuscaAvancadaPorEpisodio_Novela()
        {
#line 33
this.BuscaAvancadaPorEpisodio("\"Novela\"", "\"DRAMATURGIA SEMANAL\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"GLOBONEWS\"", "\"Não\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorGeneroOriginal(string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Gênero Original", null, @__tags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 44
 testRunner.Given(string.Format("que eu tenha um produto cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 45
 testRunner.When(string.Format("faço uma busca avançada por Produto e Gênero Original {0}", generoOriginal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 46
    testRunner.Then(string.Format("visualizo o produto no resultado da busca {0}, {1}, {2}, {3}, {4}, {5}, {6} e {7}" +
                        "", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Gênero Original, \"Novela\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT04"}, SourceLine=49)]
        public virtual void BuscaAvancadaPorGeneroOriginal_Novela()
        {
#line 43
this.BuscaAvancadaPorGeneroOriginal("\"Novela\"", "\"DRAMATURGIA SEMANAL\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"GLOBONEWS\"", "\"Não\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaAvancadaPorGeneroDireitosMusicais(string generoOriginal, string generoDireitosMusicais, string aR, string gradeAtual, string atividade, string atualizaOrigem, string midias, string capituloObrigatorio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca avançada por Gênero Direitos Musicais", null, @__tags);
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 54
 testRunner.Given(string.Format("que eu tenha um produto cadastrado {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 55
    testRunner.When(string.Format("faço uma busca avançada por Produto e Direitos Musicais {0}", generoDireitosMusicais), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 56
    testRunner.Then(string.Format("visualizo o produto no resultado da busca {0}, {1}, {2}, {3}, {4}, {5}, {6} e {7}" +
                        "", generoOriginal, generoDireitosMusicais, aR, gradeAtual, midias, atividade, atualizaOrigem, capituloObrigatorio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca avançada por Gênero Direitos Musicais, \"Novela\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT05"}, SourceLine=59)]
        public virtual void BuscaAvancadaPorGeneroDireitosMusicais_Novela()
        {
#line 53
this.BuscaAvancadaPorGeneroDireitosMusicais("\"Novela\"", "\"DRAMATURGIA SEMANAL\"", "\"4135\"", "\"Sim\"", "\"Atividade\"", "\"Não\"", "\"GLOBONEWS\"", "\"Não\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPorProdutosNaoCadastrados(string nome, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca por produtos não cadastrados", null, @__tags);
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 64
    testRunner.When("faço uma busca avançada por Produto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 65
    testRunner.Then(string.Format("visualizo a {0} de dados nao encontrados na busca pelo produto informado", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por produtos não cadastrados, \"Produto Inexistente\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT06"}, SourceLine=68)]
        public virtual void BuscaPorProdutosNaoCadastrados_ProdutoInexistente()
        {
#line 63
this.BuscaPorProdutosNaoCadastrados("\"Produto Inexistente\"", "\"Dados não encontratos\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por produtos não cadastrados, \"Produto nome\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT06"}, SourceLine=68)]
        public virtual void BuscaPorProdutosNaoCadastrados_ProdutoNome()
        {
#line 63
this.BuscaPorProdutosNaoCadastrados("\"Produto nome\"", "\"Dados não encontratos\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void BuscaPorProdutoEEpisodiosNaoAssociados(string nome, string episodio, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "ConsultaDeProdutoCT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Busca por Produto e Episódios não associados", null, @__tags);
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 74
    testRunner.When(string.Format("faço uma busca avançada por Produto e Episódio {0}, {1}", nome, episodio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 75
    testRunner.Then(string.Format("visualizo a {0} de dados nao encontrados na busca pelo produto informado", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Busca por Produto e Episódios não associados, \"Teste INM\"", new string[] {
                "chrome",
                "ConsultaDeProdutoCT07"}, SourceLine=78)]
        public virtual void BuscaPorProdutoEEpisodiosNaoAssociados_TesteINM()
        {
#line 73
this.BuscaPorProdutoEEpisodiosNaoAssociados("\"Teste INM\"", "\"Episodio 120\"", "\"Dados não encontratos\"", ((string[])(null)));
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
