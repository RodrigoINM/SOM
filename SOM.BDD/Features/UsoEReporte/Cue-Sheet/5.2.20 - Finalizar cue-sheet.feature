#language:pt
#Author: Rodrigo Magno
#Date: 08/02/2019

@kill_Driver @FinalizarCueSheet
Funcionalidade: 5.2.20 - Finalizar cue-sheet

Contexto: Finalizar uma cue=sheet
    Dado que esteja logado no sistema SOM

@chrome @FinalizarCueSheetCT01
Esquema do Cenário: Finalizar Cue-sheet 100% aprovada com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	E finalizo a Cue-Sheet
	Então visualizo o Status da Cue-Sheet como Finalizada <Status>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Status       |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Finalizada" |

@chrome @FinalizarCueSheetCT02
Esquema do Cenário: Finalizar Cue-sheet parcialmente validada
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	Então visualizo o Status da Cue-Sheet como parcialmente validada <Status>
	E visualizo o percentual de aprovação da Cue-Sheet alterado <Percentual>

  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Status                  | Percentual |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Parcialmente Validada" | " 50,00%"  |

@chrome @FinalizarCueSheetCT03
Esquema do Cenário: Reiniciar Cue-sheet finalizada
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	E finalizo a Cue-Sheet
	E reinicio a Cue-Sheet
	Então visualizo o Status da Cue-Sheet como Validada <Status>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Status     |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Validada" |
	  
@chrome @FinalizarCueSheetCT04
Esquema do Cenário: Validar que não é possível finalizar Cue-sheet 0% aprovada
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Então visualizo apenas o botão para liberar a cue-sheet
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Status     |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Validada" |
	  