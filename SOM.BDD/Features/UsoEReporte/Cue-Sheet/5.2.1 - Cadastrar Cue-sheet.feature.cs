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
namespace SOM.BDD.Features.UsoEReporte.Cue_Sheet
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("5.2.1 - Cadastrar Cue-sheet", new string[] {
            "kill_Driver",
            "CueSheet",
            "CadastroDeCueSheet"}, SourceFile="Features\\UsoEReporte\\Cue-Sheet\\5.2.1 - Cadastrar Cue-sheet.feature", SourceLine=6)]
    public partial class _5_2_1_CadastrarCue_SheetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "5.2.1 - Cadastrar Cue-sheet.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "5.2.1 - Cadastrar Cue-sheet", null, ProgrammingLanguage.CSharp, new string[] {
                        "kill_Driver",
                        "CueSheet",
                        "CadastroDeCueSheet"});
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
        
        public virtual void CadastrarCue_SheetManual(string mensagemCritica, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastroDeCueSheetCT01"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastrar Cue-sheet manual", null, @__tags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 14
 testRunner.Given("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
 testRunner.When("que cadastro uma nova cue-sheet sem importar um arquivo com os itens da cue-sheet" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
 testRunner.Then(string.Format("visualizo uma mensagem de critica para confirmação junto com uma mensagem de cada" +
                        "stro realizado com sucesso {0}, {1}", mensagemCritica, mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cadastrar Cue-sheet manual, \"Você não selecionou um arquivo. Deseja criar a cue-s" +
            "heet mesmo assim?\"", new string[] {
                "chrome",
                "CadastroDeCueSheetCT01"}, SourceLine=19)]
        public virtual void CadastrarCue_SheetManual_VoceNaoSelecionouUmArquivo_DesejaCriarACue_SheetMesmoAssim()
        {
#line 13
this.CadastrarCue_SheetManual("\"Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?\"", "\"Cue-sheet cadastrada com sucesso \"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar campo Capítulo obrigatório", new string[] {
                "chrome",
                "CadastroDeCueSheetCT02"}, SourceLine=22)]
        public virtual void ValidarCampoCapituloObrigatorio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar campo Capítulo obrigatório", null, new string[] {
                        "chrome",
                        "CadastroDeCueSheetCT02"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 24
 testRunner.Given("que tenha um produto cadastrado no sistema com capitulo obrigatório", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 25
 testRunner.When("tento cadastrar uma cue-sheet sem informar o capitulo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
 testRunner.Then("visualizo o campo Capitulo em destaque para o preenchimento obrigatorio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void ValidarDuplicidadeDeNovaCue_Sheet(string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastroDeCueSheetCT03"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar duplicidade de nova Cue-sheet", null, @__tags);
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 30
 testRunner.Given("que tenha uma cue-sheet cadastrada no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 31
 testRunner.When("tento cadastrar uma nova cue-sheet com os mesmos dados da cue-sheet existente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 32
 testRunner.Then(string.Format("visualizo uma mensagem de critica informando que já existe uma cue-sheet cadastra" +
                        "da para essa midia e data {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar duplicidade de nova Cue-sheet, \"Já existe uma cue-sheet cadastrada para e" +
            "ste mesmo Produto, Capítulo, Mídia e Data de Exibição. Os itens do arquivos serã" +
            "o incluídos ao final da planilha. Deseja prosseguir?\"", new string[] {
                "chrome",
                "CadastroDeCueSheetCT03"}, SourceLine=35)]
        public virtual void ValidarDuplicidadeDeNovaCue_Sheet_JaExisteUmaCue_SheetCadastradaParaEsteMesmoProdutoCapituloMidiaEDataDeExibicao_OsItensDoArquivosSeraoIncluidosAoFinalDaPlanilha_DesejaProsseguir()
        {
#line 29
this.ValidarDuplicidadeDeNovaCue_Sheet("\"Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Da" +
                    "ta de Exibição. Os itens do arquivos serão incluídos ao final da planilha. Desej" +
                    "a prosseguir?\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidarCriticaParaCriacaoDeCue_SheetComoRepriseRebatida(string repriseRebatida, string mensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome",
                    "CadastroDeCueSheetCT04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar critica para criacao de cue-sheet como reprise/rebatida", null, @__tags);
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 40
 testRunner.Given("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 41
 testRunner.When(string.Format("tento cadastrar uma nova cue-sheet {0}", repriseRebatida), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 42
 testRunner.Then(string.Format("visualizo uma mensagem de critica informando que o capitulo não está cadastrado c" +
                        "omo inedito {0}", mensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar critica para criacao de cue-sheet como reprise/rebatida, \"Reprise\"", new string[] {
                "chrome",
                "CadastroDeCueSheetCT04"}, SourceLine=45)]
        public virtual void ValidarCriticaParaCriacaoDeCue_SheetComoRepriseRebatida_Reprise()
        {
#line 39
this.ValidarCriticaParaCriacaoDeCue_SheetComoRepriseRebatida("\"Reprise\"", "\"Esta cue-sheet não pode ser uma reprise pois o capítulo não está cadastrado como" +
                    " inédito.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Validar critica para criacao de cue-sheet como reprise/rebatida, \"Rebatida\"", new string[] {
                "chrome",
                "CadastroDeCueSheetCT04"}, SourceLine=45)]
        public virtual void ValidarCriticaParaCriacaoDeCue_SheetComoRepriseRebatida_Rebatida()
        {
#line 39
this.ValidarCriticaParaCriacaoDeCue_SheetComoRepriseRebatida("\"Rebatida\"", "\"Esta cue-sheet não pode ser uma rebatida pois o capítulo não está cadastrado com" +
                    "o inédito.\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Cancelar criação de cue-sheet sem arquivo de importação", new string[] {
                "chrome",
                "CadastroDeCueSheetCT05"}, SourceLine=49)]
        public virtual void CancelarCriacaoDeCue_SheetSemArquivoDeImportacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancelar criação de cue-sheet sem arquivo de importação", null, new string[] {
                        "chrome",
                        "CadastroDeCueSheetCT05"});
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 51
 testRunner.Given("que tenha um produto cadastrado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 52
 testRunner.When("tento cadastrar uma nova cue-sheet sem importar um arquivo com os itens da cue-sh" +
                    "eet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 53
 testRunner.Then("visualizo o campo de importar arquivo em destaque ao não criar a cue-sheet sem fa" +
                    "zer a importação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
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
