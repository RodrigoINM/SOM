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
	Dado que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
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

@chrome @CadastroDeCueSheetCT06
Esquema do Cenario: Cadastrar itens por importação de arquivo com extensões ".TXT" e ".EDL" na tela Cadastro de Cue-Sheet
	Dado que tenha um produto cadastrado no sistema
	Quando cadastro uma Cue-Sheet importando uma lista de itens <ListaDeItensDaCueSheet>
	Então visualizo um dos itens da lista cadastrado na Cue-Sheet com sucesso <ItemDaCueSheet>
 
 Exemplos:
      | ListaDeItensDaCueSheet                                | ItemDaCueSheet                  |
      | "ONOF 30 BL1.txt"                                     | "NASCENTE"                      |
      | "MASTER GUILHERME VETERANO E APRENDIZ  GUILHERME.edl" | "VINHETA__BEM_VERAO___AUDIO_01" |

@chrome @CadastroDeCueSheetCT07
Esquema do Cenario: Importar arquivos TXT e EDL com itens de cue-sheet na tela de detahes da cue-sheet
    Dado que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando faço upload de um arquivo com uma lista de itens para Cue-Sheet <ListaDeItensDaCueSheet>
	Então visualizo um dos itens da lista cadastrado na Cue-Sheet com sucesso <ItemDaCueSheet>
 
 Exemplos:
      | ListaDeItensDaCueSheet                                | ItemDaCueSheet                  |
      | "ONOF 30 BL1.txt"                                     | "NASCENTE"                      |
      | "MASTER GUILHERME VETERANO E APRENDIZ  GUILHERME.edl" | "VINHETA__BEM_VERAO___AUDIO_01" |

@chrome @CadastroDeCueSheetCT08
Cenario: Item com Obra associada para gênero diferente de Jornalismo e Esporte
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cadastro um item na Cue-Sheet
	Então visualizo o item da Cue-Sheet cadastrado na grid com sucesso

@chrome @CadastroDeCueSheetCT09
Cenario: Item com Fonograma para gênero diferente de Jornalismo e Esporte
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cadastro um item na Cue-Sheet
	Então visualizo o item da Cue-Sheet cadastrado na grid com sucesso

@chrome @CadastroDeCueSheetCT10
Esquema do Cenario: Validar extensão do arquivo de importação diferente de .EDL ou .TXT
    Dado que tenha um produto cadastrado no sistema
	Quando tento cadastrar uma Cue-Sheet importando um arquivo com extensão diferente de EDL e TXT <ListaDeItensDaCueSheet>
	Então visualizo uma mensagem informando que o arquivo é inválido <Mensagem>

 Exemplos:
      | ListaDeItensDaCueSheet | Mensagem                                                               |
      | "Massa.xlsx"           | "Este arquivo não pode ser importado. O formato do arquivo é inválido" |
 
@chrome @CadastroDeCueSheetCT11
 Cenario: Cancelar cadastro de item na cue-sheet
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cancelo o cadastro de um item de Cue-Sheet
	Então visualizo que o total de itens na Cue-Sheet continua como zero

@chrome @CadastroDeCueSheetCT12
Esquema do Cenario: Cue-sheet de uma reprise para gênero Jornalismo
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema <GeneroOriginal>, <DireitosMusicais>
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cadastro um item na Cue-Sheet
	E altero o item para Fair Use
	Então visualizo o item da Cue-Sheet cadastrado na grid com sucesso
	
 Exemplos:
      | GeneroOriginal | DireitosMusicais |
      | "Jornalismo"   | "JORNALISMO"     |
 
@chrome @CadastroDeCueSheetCT13
Esquema do Cenario: Cue-sheet de uma reprise para gênero Esporte
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema <GeneroOriginal>, <DireitosMusicais>
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cadastro um item na Cue-Sheet
	E altero o item para Fair Use
	Então visualizo o item da Cue-Sheet cadastrado na grid com sucesso
	
 Exemplos:
      | GeneroOriginal | DireitosMusicais |
      | "Jornalismo"   | "ESPORTE"        |
 
@chrome @CadastroDeCueSheetCT14
Esquema do Cenario: Impedir importação no detalhe da Cue-sheet com status Liberada
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	E finalizo a Cue-Sheet
	Então visualizo o Status da Cue-Sheet como Finalizada <Status>
	E visualizo apenas o botão de Reiniciar Cue-Sheet
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Status       |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Finalizada" |

@chrome @CadastroDeCueSheetCT15
Cenario: Validar campos obrigatórios em branco
    E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando tento cadastrar um item de Cue-Sheet deixando os campos obrigatórios em branco
	Então visualizo os campos obrigatórios para o cadastro de um item de Cue-Sheet em destaque