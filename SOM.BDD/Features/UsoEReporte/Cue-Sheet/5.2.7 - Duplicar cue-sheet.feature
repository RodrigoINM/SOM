#language:pt
#Author: Rodrigo Magno
#Date: 06/02/2019

@kill_Driver @DuplicarCueSheet
Funcionalidade: 5.2.7 - Duplicar Cue-Sheet

Contexto: 
    Dado que esteja logado no sistema SOM

@chrome @DuplicarCueSheetCT01
Esquema do Cenário: Validar os campos corretamentte da tela Duplicar
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando duplicar a Cue-Sheet
	Então visualizo os campo de nome do produto e episodio bloqueados para edição
	E visualizo os campos preenchidos com os dados da Cue-Sheet a ser duplicada <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	  
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        |
  
@chrome @DuplicarCueSheetCT02
Esquema do Cenário: Duplicar cue-sheet com capitulo obrigatório
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando duplicar a Cue-Sheet como Rebatida
	Então visualizo a tela de detalhe da cue-sheet duplicada como Rebatida com sucesso <RepriseRebatida>
	 
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Rebatida"      | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        |
  
@chrome @DuplicarCueSheetCT03
Esquema do Cenário: Duplicar Cue-sheet com capítulo não obrigatório
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando duplicar a Cue-Sheet como Rebatida
	Então visualizo a tela de detalhe da cue-sheet duplicada como Rebatida com sucesso <RepriseRebatida>
	 
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Rebatida"      | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        |
  
@chrome @DuplicarCueSheetCT04
Esquema do Cenário: Validar mensagem de alerta de duplicidade de cadastro de cue-sheet
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando duplicar a Cue-Sheet sem alterar nenhuma informação
	Então visualizo uma mensagem de alerta informando que já existe Cue-Sheet cadastrada com esse dados <Mensagem>
	 
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                                                                                          |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | " "             | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Data de Exibição." |
  
@chrome @DuplicarCueSheetCT05
Esquema do Cenário: Validar mensagem ao duplicar Cue-sheet de Reprise
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando duplicar a Cue-Sheet como Reprise
	Então visualizo uma mensagem de alerta informando que já existe Cue-Sheet cadastrada com esse dados <Mensagem>
	 
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                                                                                          |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Reprise"       | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Data de Exibição." |
  
@chrome @DuplicarCueSheetCT06
Esquema do Cenário: Validar mensagem de alerta ao duplicar cue-sheet sem alterar os dados dos campos
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando duplicar a Cue-Sheet sem alterar nenhuma informação
	Então visualizo uma mensagem de alerta informando que já existe Cue-Sheet cadastrada com esse dados <Mensagem>
	 
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                                                                                          |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | " "             | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Já existe uma cue-sheet cadastrada para este mesmo Produto, Capítulo, Mídia e Data de Exibição." |
  