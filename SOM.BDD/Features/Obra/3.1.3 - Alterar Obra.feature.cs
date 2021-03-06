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
namespace SOM.BDD.Features.Obra
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("3.1.3 - Alterar Obra", new string[] {
            "kill_Driver",
            "Obra",
            "AlterarObra"}, SourceFile="Features\\Obra\\3.1.3 - Alterar Obra.feature", SourceLine=6)]
    public partial class _3_1_3_AlterarObraFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "3.1.3 - Alterar Obra.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "3.1.3 - Alterar Obra", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "Obra",
                        "AlterarObra"});
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
    testRunner.And("que esteja na tela de Obras", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoTituloDaObra(string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Título da obra", null, @__tags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 15
 testRunner.When("faço uma busca simples por uma obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
    testRunner.And("altero e salvo os dados no campo titulo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
    testRunner.Then(string.Format("visualizo a mensagem de alterado obra com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Título da obra, \"Dados alterados com sucesso e enviados ao" +
            " GMUSIC.\"", new string[] {
                "chrome",
                "AlterarObraCT01"}, SourceLine=20)]
        public virtual void AlterarDadosDoCampoTituloDaObra_DadosAlteradosComSucessoEEnviadosAoGMUSIC_()
        {
#line 14
this.AlterarDadosDoCampoTituloDaObra("\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoTipoDaObra(string tipo, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT02"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Tipo da obra", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 25
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 26
    testRunner.When(string.Format("salvo a alteração no campo tipo da obra {0}", tipo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 27
    testRunner.Then(string.Format("visualizo a mensagem de alteração da obra com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Tipo da obra, \"BIBLIOTECA MUSICAL\"", new string[] {
                "chrome",
                "AlterarObraCT02"}, SourceLine=30)]
        public virtual void AlterarDadosDoCampoTipoDaObra_BIBLIOTECAMUSICAL()
        {
#line 24
this.AlterarDadosDoCampoTipoDaObra("\"BIBLIOTECA MUSICAL\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Tipo da obra, \"MUSICA COMERCIAL\"", new string[] {
                "chrome",
                "AlterarObraCT02"}, SourceLine=30)]
        public virtual void AlterarDadosDoCampoTipoDaObra_MUSICACOMERCIAL()
        {
#line 24
this.AlterarDadosDoCampoTipoDaObra("\"MUSICA COMERCIAL\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Tipo da obra, \"MUSICA COMERCIAL GRATUITA\"", new string[] {
                "chrome",
                "AlterarObraCT02"}, SourceLine=30)]
        public virtual void AlterarDadosDoCampoTipoDaObra_MUSICACOMERCIALGRATUITA()
        {
#line 24
this.AlterarDadosDoCampoTipoDaObra("\"MUSICA COMERCIAL GRATUITA\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Tipo da obra, \"TRILHA MUSICAL\"", new string[] {
                "chrome",
                "AlterarObraCT02"}, SourceLine=30)]
        public virtual void AlterarDadosDoCampoTipoDaObra_TRILHAMUSICAL()
        {
#line 24
this.AlterarDadosDoCampoTipoDaObra("\"TRILHA MUSICAL\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoAnoDaObra(string ano, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Ano da obra", null, @__tags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 38
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 39
    testRunner.When(string.Format("salvo a alteração no campo Ano {0}", ano), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 40
    testRunner.Then(string.Format("visualizo a mensagem de alteração do ano da obra com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Ano da obra, \"2019\"", new string[] {
                "chrome",
                "AlterarObraCT03"}, SourceLine=43)]
        public virtual void AlterarDadosDoCampoAnoDaObra_2019()
        {
#line 37
this.AlterarDadosDoCampoAnoDaObra("\"2019\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDosCamposObrigatoriosDeObra(string tipo, string nacionalidade, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados dos campos obrigatorios de Obra", null, @__tags);
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 48
 testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 49
    testRunner.And(string.Format("altero os dados obrigatorios Titulo, {0} e {1} da obra", tipo, nacionalidade), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 50
    testRunner.Then(string.Format("visualizo a mensagem dos campos obrigatórios, alterado com sucesso {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados dos campos obrigatorios de Obra, \"TRILHA MUSICAL\"", new string[] {
                "chrome",
                "AlterarObraCT04"}, SourceLine=53)]
        public virtual void AlterarDadosDosCamposObrigatoriosDeObra_TRILHAMUSICAL()
        {
#line 47
this.AlterarDadosDosCamposObrigatoriosDeObra("\"TRILHA MUSICAL\"", "\"Nacional\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoDerivacao(string derivacao, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT05"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Derivação", null, @__tags);
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 58
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
    testRunner.And(string.Format("salvo uma alteracao feita no campo de {0}", derivacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 60
    testRunner.Then(string.Format("visualizo a mensagem de alteração {0} com sucesso", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Derivação, \"Adaptação\"", new string[] {
                "chrome",
                "AlterarObraCT05"}, SourceLine=63)]
        public virtual void AlterarDadosDoCampoDerivacao_Adaptacao()
        {
#line 57
this.AlterarDadosDoCampoDerivacao("\"Adaptação\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Derivação, \"Mashup\"", new string[] {
                "chrome",
                "AlterarObraCT05"}, SourceLine=63)]
        public virtual void AlterarDadosDoCampoDerivacao_Mashup()
        {
#line 57
this.AlterarDadosDoCampoDerivacao("\"Mashup\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Derivação, \"Pot-pourri/Medley\"", new string[] {
                "chrome",
                "AlterarObraCT05"}, SourceLine=63)]
        public virtual void AlterarDadosDoCampoDerivacao_Pot_PourriMedley()
        {
#line 57
this.AlterarDadosDoCampoDerivacao("\"Pot-pourri/Medley\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Derivação, \"Sample\"", new string[] {
                "chrome",
                "AlterarObraCT05"}, SourceLine=63)]
        public virtual void AlterarDadosDoCampoDerivacao_Sample()
        {
#line 57
this.AlterarDadosDoCampoDerivacao("\"Sample\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Derivação, \"Versão\"", new string[] {
                "chrome",
                "AlterarObraCT05"}, SourceLine=63)]
        public virtual void AlterarDadosDoCampoDerivacao_Versao()
        {
#line 57
this.AlterarDadosDoCampoDerivacao("\"Versão\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoObraOriginalDaObraQueJaPossueAMesmaInformada(string derivacao, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT06"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Obra Original da obra que já possue a mesma informada", null, @__tags);
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 72
    testRunner.Given("que esteja na tela Edição de Obra, que já possue Obra Origunal informada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 73
    testRunner.And(string.Format("altero o campo de {0} e salvo", derivacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 74
    testRunner.Then(string.Format("visualizo a mensagem de alteração {0} com sucesso", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Obra Original da obra que já possue a mesma informada, \"Ma" +
            "shup\"", new string[] {
                "chrome",
                "AlterarObraCT06"}, SourceLine=77)]
        public virtual void AlterarDadosDoCampoObraOriginalDaObraQueJaPossueAMesmaInformada_Mashup()
        {
#line 71
this.AlterarDadosDoCampoObraOriginalDaObraQueJaPossueAMesmaInformada("\"Mashup\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoInstitucional(string institucional, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT07"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Institucional", null, @__tags);
#line 81
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 82
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 83
    testRunner.When(string.Format("salvo a aletracao da flag {0}", institucional), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 84
    testRunner.Then(string.Format("visualizo a mensagem de alteração {0} com sucesso", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Institucional, \"Sim\"", new string[] {
                "chrome",
                "AlterarObraCT07"}, SourceLine=87)]
        public virtual void AlterarDadosDoCampoInstitucional_Sim()
        {
#line 81
this.AlterarDadosDoCampoInstitucional("\"Sim\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Institucional, \"Não\"", new string[] {
                "chrome",
                "AlterarObraCT07"}, SourceLine=87)]
        public virtual void AlterarDadosDoCampoInstitucional_Nao()
        {
#line 81
this.AlterarDadosDoCampoInstitucional("\"Não\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoEmblematica(string emblematica, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT08"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Emblemática", null, @__tags);
#line 92
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 93
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 94
    testRunner.When(string.Format("salvo a aletracao da flag emblematica {0}", emblematica), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 95
 testRunner.Then(string.Format("visualizo a mensagem de alteração {0} com sucesso", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Emblemática, \"Sim\"", new string[] {
                "chrome",
                "AlterarObraCT08"}, SourceLine=98)]
        public virtual void AlterarDadosDoCampoEmblematica_Sim()
        {
#line 92
this.AlterarDadosDoCampoEmblematica("\"Sim\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Emblemática, \"Não\"", new string[] {
                "chrome",
                "AlterarObraCT08"}, SourceLine=98)]
        public virtual void AlterarDadosDoCampoEmblematica_Nao()
        {
#line 92
this.AlterarDadosDoCampoEmblematica("\"Não\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDoCampoTituloAlternativo(string tituloAlternativo, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT09"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados do campo Título Alternativo", null, @__tags);
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 104
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 105
    testRunner.When(string.Format("salvo a alteracao do {0}", tituloAlternativo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 106
    testRunner.Then(string.Format("visualizo a mensagem de alteração {0} com sucesso", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Título Alternativo, \"NovoTeste\"", new string[] {
                "chrome",
                "AlterarObraCT09"}, SourceLine=109)]
        public virtual void AlterarDadosDoCampoTituloAlternativo_NovoTeste()
        {
#line 103
this.AlterarDadosDoCampoTituloAlternativo("\"NovoTeste\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados do campo Título Alternativo, \"NovoTitulo\"", new string[] {
                "chrome",
                "AlterarObraCT09"}, SourceLine=109)]
        public virtual void AlterarDadosDoCampoTituloAlternativo_NovoTitulo()
        {
#line 103
this.AlterarDadosDoCampoTituloAlternativo("\"NovoTitulo\"", "\"Dados alterados com sucesso e enviados ao GMUSIC.\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AlterarDadosDaObraComCriacaoDeNovoDDAComAssociacao(string associacao, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "AlterarObraCT10"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alterar dados da obra com criação de novo DDA com associacao", null, @__tags);
#line 114
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 115
    testRunner.Given("que esteja na tela Edição de Obra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 116
    testRunner.When(string.Format("salvo a alteracao de DDA com {0}", associacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 117
    testRunner.Then(string.Format("visualizo a mensagem de DDA {0} com sucesso", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados da obra com criação de novo DDA com associacao, \"UBEM\"", new string[] {
                "chrome",
                "AlterarObraCT10"}, SourceLine=120)]
        public virtual void AlterarDadosDaObraComCriacaoDeNovoDDAComAssociacao_UBEM()
        {
#line 114
this.AlterarDadosDaObraComCriacaoDeNovoDDAComAssociacao("\"UBEM\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Alterar dados da obra com criação de novo DDA com associacao, \"SEM ASSOCIAÇÃO\"", new string[] {
                "chrome",
                "AlterarObraCT10"}, SourceLine=120)]
        public virtual void AlterarDadosDaObraComCriacaoDeNovoDDAComAssociacao_SEMASSOCIACAO()
        {
#line 114
this.AlterarDadosDaObraComCriacaoDeNovoDDAComAssociacao("\"SEM ASSOCIAÇÃO\"", "\"Registro salvo com sucesso.\"", ((string[])(null)));
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
