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
namespace SOM.BDD.Features.Obra.Autor
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("3.1.5 - Cadastrar Autor", new string[] {
            "kill_Driver",
            "Autor",
            "CadastrarAutor"}, SourceFile="Features\\Obra\\Autor\\3.1.5 - Cadastrar Autor.feature", SourceLine=6)]
    public partial class _3_1_5_CadastrarAutorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.5 - Cadastrar Autor.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "3.1.5 - Cadastrar Autor", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Autor",
                        "CadastrarAutor"});
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
 testRunner.And("que esteja na tela de cadastro Autor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
        }
        
        public virtual void IncluirAutor(string nomeArtistico, string nomeCompleto, string logradouro, string bairro, string cidade, string cEP, string nome, string tipoContato, string telefone, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "excluirAutor",
                    "CadastrarAutorCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir Autor", null, @__tags);
#line 14
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
    testRunner.When(string.Format("cadastro um novo autor com os campos {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
    testRunner.And(string.Format("informo os dados de endereco: {0}, {1}, {2} e {3}", logradouro, bairro, cidade, cEP), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
    testRunner.And(string.Format("informo os dados de contato: {0}, {1} e {2}", nome, tipoContato, telefone), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 18
    testRunner.Then(string.Format("visualizo a {0} do Autor cadastrado com sucesso para o {1}", mensagem, nomeArtistico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir Autor, \"Teste de Autor INM\"", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT01"}, SourceLine=21)]
        public virtual void IncluirAutor_TesteDeAutorINM()
        {
#line 14
 this.IncluirAutor("\"Teste de Autor INM\"", "\"Teste de Autor INM Completo\"", "\"Teste Logradouro\"", "\"Teste\"", "\"Teste\"", "\"11111111\"", "\"Teste INM\"", "\"Telefone\"", "\"2133445566\"", "\"Registro ativado com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir Autor, \"Teste de NomeArtistico\"", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT01"}, SourceLine=21)]
        public virtual void IncluirAutor_TesteDeNomeArtistico()
        {
#line 14
 this.IncluirAutor("\"Teste de NomeArtistico\"", "\"Teste de NomeCompleto\"", "\"Logradouro\"", "\"NovoBairro\"", "\"CidadeTeste\"", "\"21220560\"", "\"Teste de Contato\"", "\"Telefone\"", "\"2133445566\"", "\"Registro ativado com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirAutorSemPreenchimentoDosCamposObrigatorios(string nomeArtistico, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastrarAutorCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir Autor sem preenchimento dos campos obrigatorios", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 27
    testRunner.When(string.Format("tento cadastrar um autor sem informar o {0}", nomeArtistico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 28
    testRunner.Then("visualizo o campo em destaque do cadastro de autor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir Autor sem preenchimento dos campos obrigatorios, \"\"", new string[] {
                "chrome",
                "CadastrarAutorCT02"}, SourceLine=31)]
        public virtual void IncluirAutorSemPreenchimentoDosCamposObrigatorios_()
        {
#line 26
this.IncluirAutorSemPreenchimentoDosCamposObrigatorios("\"\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirDoisAutoresComDadosIguais(string nomeArtistico, string nomeCompleto, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "excluirAutor",
                    "CadastrarAutorCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir dois autores com dados iguais", null, @__tags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 36
    testRunner.When(string.Format("cadastro um autor com {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 37
    testRunner.And(string.Format("tento cadastrar um novo autor com os mesmos dados de {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 38
    testRunner.Then(string.Format("visualizo a {0} que ja existe um autor {1} cadastrados com esses dados", mensagem, nomeArtistico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir dois autores com dados iguais, \"Teste de Autor INM\"", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT03"}, SourceLine=41)]
        public virtual void IncluirDoisAutoresComDadosIguais_TesteDeAutorINM()
        {
#line 35
this.IncluirDoisAutoresComDadosIguais("\"Teste de Autor INM\"", "\"Teste de Autor INM Completo\"", "\"Existe um registro com esses dados cadastrado no sistema.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirUmEnderecoSemPreenchimentoDeCamposObrigatorios(string nomeArtistico, string nomeCompleto, string logradouro, string bairro, string cidade, string cep, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastrarAutorCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir um endereco sem preenchimento de campos obrigatórios", null, @__tags);
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 46
    testRunner.When(string.Format("realizo um cadastro de autor com os campos {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 47
    testRunner.And(string.Format("tento adicionar um endereco sem preencher os campos {0}, {1}, {2} e {3}", logradouro, bairro, cidade, cep), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 48
    testRunner.Then("visualizo os campos em destaque", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir um endereco sem preenchimento de campos obrigatórios, \"Teste de Autor\"", new string[] {
                "chrome",
                "CadastrarAutorCT04"}, SourceLine=51)]
        public virtual void IncluirUmEnderecoSemPreenchimentoDeCamposObrigatorios_TesteDeAutor()
        {
#line 45
this.IncluirUmEnderecoSemPreenchimentoDeCamposObrigatorios("\"Teste de Autor\"", "\"Teste Nome\"", "\" \"", "\" \"", "\" \"", "\" \"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirUmContatoSemPreenchimentoDeCamposObrigatorios(string nomeArtistico, string nomeCompleto, string nomeContato, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastrarAutorCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir um contato sem preenchimento de campos obrigatórios", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 56
    testRunner.When(string.Format("cadastro um novo autor com {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 57
    testRunner.And(string.Format("tento adicionar um contato sem preencher o campos {0}", nomeContato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 58
    testRunner.Then("visualizo o campo Nome da aba de contato em destaque", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir um contato sem preenchimento de campos obrigatórios, \"Teste de Autor\"", new string[] {
                "chrome",
                "CadastrarAutorCT05"}, SourceLine=61)]
        public virtual void IncluirUmContatoSemPreenchimentoDeCamposObrigatorios_TesteDeAutor()
        {
#line 55
this.IncluirUmContatoSemPreenchimentoDeCamposObrigatorios("\"Teste de Autor\"", "\"Teste Nome\"", "\" \"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirTiposDeContato(string nomeArtistico, string nomeCompleto, string nome, string tipoContato, string contato, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "excluirAutor",
                    "CadastrarAutorCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir tipos de contato", null, @__tags);
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 66
    testRunner.When(string.Format("cadastro um autor preenchendo os campos de {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 67
    testRunner.When(string.Format("incluir um novo contato com {0},{1} e {2}", nome, tipoContato, contato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 68
    testRunner.Then(string.Format("visualizo a {0} do Autor cadastrado com sucesso para o {1}", mensagem, nomeArtistico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir tipos de contato, Variant 0", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT06"}, SourceLine=72)]
        public virtual void IncluirTiposDeContato_Variant0()
        {
#line 65
this.IncluirTiposDeContato("\"Teste de Autor INM\"", "\"Teste Nome\"", "\"Nome1\"", "\"Telefone\"", "\"2134352617\"", "\"Registro ativado com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir tipos de contato, Variant 1", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT06"}, SourceLine=72)]
        public virtual void IncluirTiposDeContato_Variant1()
        {
#line 65
this.IncluirTiposDeContato("\"Teste de Autor INM\"", "\"Teste Nome\"", "\"Nome2\"", "\"Celular\"", "\"21824262728\"", "\"Registro ativado com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir tipos de contato, Variant 2", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT06"}, SourceLine=72)]
        public virtual void IncluirTiposDeContato_Variant2()
        {
#line 65
this.IncluirTiposDeContato("\"Teste de Autor INM\"", "\"Teste Nome\"", "\"Nome3\"", "\"Email\"", "\"Teste@teste.com.br\"", "\"Registro ativado com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirMaisDeUmContato(string nomeArtistico, string nomeCompleto, string nomeContato, string tipoContato1, string contato1, string tipoContato2, string contato2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastrarAutorCT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir mais de um contato", null, @__tags);
#line 78
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 79
    testRunner.Given(string.Format("que no cadastramento de um novo autor preencho os campo {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 80
    testRunner.When(string.Format("incluir um contato com {0},{1} e {2}", nomeContato, tipoContato1, contato1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 81
    testRunner.And(string.Format("incluir mais um contato {0} e {1}", tipoContato2, contato2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 82
    testRunner.Then(string.Format("visualizo os {0} cadastrados com sucesso na aba de contatos do autor", nomeContato), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir mais de um contato, \"Teste De Contato 01\"", new string[] {
                "chrome",
                "CadastrarAutorCT07"}, SourceLine=85)]
        public virtual void IncluirMaisDeUmContato_TesteDeContato01()
        {
#line 78
this.IncluirMaisDeUmContato("\"Teste De Contato 01\"", "\"Teste Nome\"", "\"Contato\"", "\"Telefone\"", "\"2134352617\"", "\"Celular\"", "\"21824262728\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirMaisDeUmEndereco(string nomeArtistico, string nomeCompleto, string logradouro1, string bairro1, string cidade1, string cep1, string logradouro2, string bairro2, string cidade2, string cep2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastrarAutorCT08"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir mais de um endereco", null, @__tags);
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 90
    testRunner.Given(string.Format("que no cadastro de um autor preencho os seguintes campos {0} e {1}", nomeArtistico, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 91
    testRunner.When(string.Format("incluir um novo endereco informando os campos {0}, {1}, {2} e {3}", logradouro1, bairro1, cidade1, cep1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 92
    testRunner.And(string.Format("incluir mais um endereco informando os campos {0}, {1}, {2} e {3}", logradouro2, bairro2, cidade2, cep2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 93
    testRunner.Then(string.Format("visualizo os endereços {0} e {1} cadastrados com sucesso", logradouro1, logradouro2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir mais de um endereco, \"Teste De Contato 01\"", new string[] {
                "chrome",
                "CadastrarAutorCT08"}, SourceLine=96)]
        public virtual void IncluirMaisDeUmEndereco_TesteDeContato01()
        {
#line 89
this.IncluirMaisDeUmEndereco("\"Teste De Contato 01\"", "\"Teste Nome\"", "\"Logradouro 1\"", "\"Bairro Teste\"", "\"Cidade\"", "\"21220000\"", "\"Logradouro 2\"", "\"Bairro2\"", "\"Cidade2\"", "\"22202999\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirAutorFalecidoHa70Anos(string nomeAutor, string nomeCompleto, string anoFalecimento, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "excluirAutor",
                    "CadastrarAutorCT09"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir Autor falecido há 70 anos", null, @__tags);
#line 100
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 101
    testRunner.When(string.Format("crio um Autor informando {0} e {1}", nomeAutor, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 102
 testRunner.And(string.Format("preencho o campo de Ano Falecimento {0} igual a 70 anos", anoFalecimento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 103
 testRunner.Then("visualizo o ano de falecimento do autor cadastrado como não", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir Autor falecido há 70 anos, \"Teste de Autor INM\"", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT09"}, SourceLine=106)]
        public virtual void IncluirAutorFalecidoHa70Anos_TesteDeAutorINM()
        {
#line 100
this.IncluirAutorFalecidoHa70Anos("\"Teste de Autor INM\"", "\"Teste de Autor INM Completo\"", "\"1948\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void IncluirAutorFalecidoHaMaisDe70Anos(string nomeAutor, string nomeCompleto, string anoFalecimento, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "excluirAutor",
                    "CadastrarAutorCT10"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Incluir Autor falecido há mais de 70 anos", null, @__tags);
#line 110
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 111
    testRunner.When(string.Format("crio um Autor informando {0} e {1}", nomeAutor, nomeCompleto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 112
 testRunner.And(string.Format("preencho o campo de Ano Falecimento {0} acima de 70 anos", anoFalecimento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 113
 testRunner.Then("visualizo o ano de falecimento do autor cadastrado como sim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Incluir Autor falecido há mais de 70 anos, \"Teste de Autor INM\"", new string[] {
                "chrome",
                "excluirAutor",
                "CadastrarAutorCT10"}, SourceLine=116)]
        public virtual void IncluirAutorFalecidoHaMaisDe70Anos_TesteDeAutorINM()
        {
#line 110
this.IncluirAutorFalecidoHaMaisDe70Anos("\"Teste de Autor INM\"", "\"Teste de Autor INM Completo\"", "\"1946\"", ((string[])(null)));
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
