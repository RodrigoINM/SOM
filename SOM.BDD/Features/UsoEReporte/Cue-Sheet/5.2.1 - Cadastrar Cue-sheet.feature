#language:pt
#Author: Rodrigo Magno
#Date: 12/11/2018
#Version: 1.0

@kill_Driver @CueSheet @CadastroDeCueSheet
Funcionalidade: 5.2.1 - Cadastrar Cue-sheet

Contexto: 
	Dado que esteja logado no sistema SOM
	
@chrome @CadastroDeCueSheetCT01
Esquema do Cenario: Cadastrar Cue-sheet manual
	Dado que tenha um produto cadastrado no sistema
	Quando que cadastro uma nova cue-sheet sem importar um arquivo com os itens da cue-sheet
	Entao visualizo uma mensagem de critica para confirmação junto com uma mensagem de cadastro realizado com sucesso <MensagemCritica>, <Mensagem>
      
  Exemplos:
      | MensagemCritica                                                         | Mensagem                            | 
      | "Você não selecionou um arquivo. Deseja criar a cue-sheet mesmo assim?" | "Cue-sheet cadastrada com sucesso " | 
 
@chrome @CadastroDeCueSheetCT02
Cenario: Validar campo Capítulo obrigatório
	Dado que tenha um produto cadastrado no sistema com capitulo obrigatório
	Quando tento cadastrar uma cue-sheet sem informar o capitulo
	Entao visualizo o campo Capitulo em destaque para o preenchimento obrigatorio
		
@chrome @CadastroDeCueSheetCT03
Esquema do Cenario: Validar duplicidade de nova Cue-sheet
	Dado que tenha uma cue-sheet cadastrada no sistema
	Quando tento cadastrar uma nova cue-sheet com os mesmos dados da cue-sheet existente
	Entao visualizo uma mensagem de critica informando que já existe uma cue-sheet cadastrada para essa midia e data <Mensagem>
    
  Exemplos:
      | Mensagem                                                                                                                                                                        |
      | "Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Data de Exibição. Os itens do arquivos serão incluídos ao final da planilha. Deseja prosseguir?" |
  
@chrome @CadastroDeCueSheetCT04
Esquema do Cenario: Validar critica para criacao de cue-sheet como reprise/rebatida
	Dado que tenha um produto cadastrado no sistema
	Quando tento cadastrar uma nova cue-sheet <RepriseRebatida>
	Entao visualizo uma mensagem de critica informando que o capitulo não está cadastrado como inedito <Mensagem>
        
  Exemplos:
      | RepriseRebatida | Mensagem                                                                                     | 
      | "Reprise"       | "Esta cue-sheet não pode ser uma reprise pois o capítulo não está cadastrado como inédito."  | 
      | "Rebatida"      | "Esta cue-sheet não pode ser uma rebatida pois o capítulo não está cadastrado como inédito." | 
  
@chrome @CadastroDeCueSheetCT05
Cenario: Cancelar criação de cue-sheet sem arquivo de importação  
	Dado que tenha um produto cadastrado no sistema
	Quando tento cadastrar uma nova cue-sheet sem importar um arquivo com os itens da cue-sheet
	Entao visualizo o campo de importar arquivo em destaque ao não criar a cue-sheet sem fazer a importação

#Esquema do Cenario: Cadastrar itens por importação de arquivo com extensões ".TXT" e ".EDL" na tela Cadastro de Cue-Sheet
#    Dado que tenha uma Cue-Sheet cadastrada
#    E salvo o preenchimento de todos os campos com os mesmos valores já cadastrado e anexo o arquivo <Extensao>
#    Quando confirmo a seguinte <Mensagem>
#    Entao visualizo a tela Detalhe de Cue-sheet com os itens do arquivo processado, incluidos no final da grid
#    
#  Exemplos:
#      | Extensao | Numero | Titulo  | Composicao  | Interpretes | Gravadora   | ISRC | Tempo (Seg) | Exibicao  | Utilizacao        | Sincronismo | Mensagem                                                                                                                                                            | 
#      | ".TXT"   | "4"    | "TESTE" | "BANG BANG" | "ANITTA"    | "SOM LIVRE" | " "  | " 20 "      | "GRAVADO" | "BK - BACKGROUD " | "ADORNO"    | "Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Data de Exibição. Os itens do arquivos serão incluídos ao final. Deseja prosseguir?" | 
#      | ".EDL"   | "4"    | "TESTE" | "BANG BANG" | "ANITTA"    | "SOM LIVRE" | " "  | " 20 "      | "GRAVADO" | "BK - BACKGROUD " | "ADORNO"    | "Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Data de Exibição. Os itens do arquivos serão incluídos ao final. Deseja prosseguir?" | 
#  
#Esquema do Cenario: Validar extensão do arquivo de importação diferente de .EDL ou .TXT
#    Dado que esteja na tela de cadastro de Cue-Sheet
#    Quando informo os campos <Produto>, <Capitulo>, <Episodio>, <Midia>, <DataExibicao> e <Reprise> ou <Rebatida> no formulario de cadastro
#    E tento salvar o cadastro importando um arquivo com extensao diferente de TXT e EDL
#    Entao visualizo a <Mensagem> de critica
#      
#  Exemplos:
#      | Produto           | Capitulo | Episodio | Midia | DataExibicao | Reprise | Rebatida | Mensagem                                                                | 
#      | "Jornal Nacional" | "999"    | ""       | "TV"  | "23/10/2018" | ""      | ""       | "Este arquivo não pode ser importado. O formato do arquivo é inválido." | 
#
#Esquema do Cenario: Importar arquivos TXT e EDL com itens de cue-sheet na tela de detahes da cue-sheet
#    Dado que esteja na tela de detalhes de uma cue-sheet previamente cadastrada
#    Quando faco upload de um arquivo <Extensao> com itens de cue-sheet
#    Entao visualizo os itens do arquivo processado na grid da cue-sheet com sucesso
#      
#  Exemplos:
#      | Extensao | 
#      | ".TXT"   | 
#      | ".EDL"   | 
#  
#Cenario: Impedir importação no detalhe da Cue-sheet com status Liberada
#    Dado que esteja na tela de detalhes de uma cue-sheet com status liberada
#    Entao não visualizo o ícone Upload de Arquivo com sucesso
#
#Esquema do Cenario: Item com Obra associada para gênero diferente de Jornalismo e Esporte
#    Dado que possua uma cue-sheet cadastrada com genero diferente de Jornalismo ou Esporte
#    E que esteja na tela de cadastro de novos itens dentro cue-sheet
#    Quando salvo o cadastro preenchendo os campos <Titulo>, <TipoExibicao>, <TipoUtilizacao>, <Sincronismo>, <Interprete>, <Tempo>, <Reprise> e <FairUse>
#    Entao visualizo o item incluido com sucesso no detalhe da cue-sheet
#  
#  Exemplos:
#      | Titulo      | TipoExibicao | TipoUtilizacao    | Sincronismo | Interprete | Tempo | Reprise | FairUse | 
#      | "BANG BANG" | "Gravado"    | "BK - BACKGROUND" | "ABERTURA"  | "ANITTA"   | "10"  | "Não"   | "Sim"   | 
#  
#Esquema do Cenario: Item com Fonograma para gênero diferente de Jornalismo e Esporte
#    Dado que possua uma cue-sheet cadastrada com genero diferente de Jornalismo ou Esporte
#    E que esteja na tela de cadastro de novos itens dentro cue-sheet
#    Quando salvo o cadastro preenchendo os campos <Titulo>, <TipoExibicao>, <TipoUtilizacao>, <Sincronismo>, <Interprete>, <Tempo>, <Reprise> e <FairUse>
#    Entao visualizo o item incluido com sucesso no detalhe da cue-sheet
#
#  Exemplos:
#      | Titulo      | TipoExibicao | TipoUtilizacao    | Sincronismo | Interprete | Tempo | Reprise | FairUse | 
#      | "BANG BANG" | "Gravado"    | "BK - BACKGROUND" | "ABERTURA"  | "ANITTA"   | "10"  | "Não"   | "Sim"   | 
#  
#Esquema do Cenario: Cue-sheet de uma reprise para gênero Jornalismo
#    Dado que possua uma cue-sheet cadastrada com um produto do genero Jornalismo
#    E que esteja na tela de cadastro de novos itens dentro cue-sheet
#    Quando salvo o cadastro preenchendo os campos <Titulo>, <TipoExibicao>, <TipoUtilizacao>, <Sincronismo>, <Interprete>, <Tempo>, <Reprise> e <FairUse>
#    Entao visualizo o item incluido com sucesso no detalhe da cue-sheet
#
#  Exemplos:
#      | Titulo      | TipoExibicao | TipoUtilizacao    | Sincronismo | Interprete | Tempo | Reprise | FairUse | 
#      | "BANG BANG" | "Gravado"    | "BK - BACKGROUND" | "ABERTURA"  | "ANITTA"   | "10"  | "Sim"   | "Sim"   | 
#  
#Esquema do Cenario: Cue-sheet de uma reprise para gênero Esporte
#    Dado que possua uma cue-sheet cadastrada com um produto do genero Esporte
#    E que esteja na tela de cadastro de novos itens dentro cue-sheet
#    Quando salvo o cadastro preenchendo os campos <Titulo>, <TipoExibicao>, <TipoUtilizacao>, <Sincronismo>, <Interprete>, <Tempo>, <Reprise> e <FairUse>
#    Entao visualizo o item incluido com sucesso no detalhe da cue-sheet
#
#  Exemplos:
#      | Titulo      | TipoExibicao | TipoUtilizacao    | Sincronismo | Interprete | Tempo | Reprise | FairUse | 
#      | "BANG BANG" | "Gravado"    | "BK - BACKGROUND" | "ABERTURA"  | "ANITTA"   | "10"  | "Sim"   | "Sim"   | 
#
#Esquema do Cenario: Validar campos obrigatórios em branco
#    Dado que possua uma cue-sheet cadastrada
#    E que esteja na tela de cadastro de novos itens dentro cue-sheet
#    Quando tento salvar o cadastro sem preencher os campos <Titulo> e <Tempo>
#    Entao visualizo os campos <Titulo> e <Tempo> destacados em vermelho
#
#  Exemplos:
#      | Titulo      | Tempo | 
#      | "BANG BANG" | "10"  | 
#
#Esquema do Cenario: Cancelar cadastro de item na cue-sheet
#    Dado que possua uma cue-sheet cadastrada
#    E que esteja na tela de cadastro de novos itens dentro cue-sheet
#    Quando preencho os campos <Titulo>, <TipoExibicao>, <TipoUtilizacao>, <Sincronismo>, <Interprete>, <Tempo>, <Reprise> e <FairUse>
#    E clico em cancelar
#    Entao visualizo a <Mensagem> de confirmacao
#    E retorno para a tela de detalhe da cue-sheet
#  
#  Exemplos:
#      | Titulo      | TipoExibicao | TipoUtilizacao    | Sincronismo | Interprete | Tempo | Reprise | FairUse | Mensagem                                                                                   | 
#      | "BANG BANG" | "Gravado"    | "BK - BACKGROUND" | "ABERTURA"  | "ANITTA"   | "10"  | "Sim"   | "Sim"   | "Deseja cancelar? Registro ainda não foi salvo no sistema, todos os dados serão perdidos." | 
