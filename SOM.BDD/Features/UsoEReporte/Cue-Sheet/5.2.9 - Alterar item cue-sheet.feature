#language:pt
#Author: Rodrigo Magno
#Date: 06/02/2019

@kill_Driver @AlterarCueSheet
Funcionalidade: 5.2.9 - Alterar item na cue-sheet

Contexto: Alterar um item na cue-sheet
    Dado que esteja logado no sistema SOM

@chrome @AlterarCueSheetCT01
Esquema do Cenário: Alterar Título do fonograma com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando alterar o Titulo do item cadastrado na Cue-Sheet <Obra>, <Obra2>
	Então visualizo uma mensagem de item alterado com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Obra2             | Mensagem                    |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "TESTE INMETRICS" | "Item alterado com sucesso" |
  
@chrome @AlterarCueSheetCT02
Esquema do Cenário: Alterar os demais campos com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando alterar dados do item cadastrado na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Então visualizo uma mensagem de item alterado com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Obra2             | Mensagem                    |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "TESTE INMETRICS" | "Item alterado com sucesso" |

@chrome @AlterarCueSheetCT03
Esquema do Cenário: Incluir um interprete pela cue-sheet com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando alterar o Interprete do item cadastrado na Cue-Sheet cadastrando um novo <Obra>
	Então visualizo uma mensagem de item alterado com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Obra2             | Mensagem                    |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "TESTE INMETRICS" | "Item alterado com sucesso" |

@chrome @AlterarCueSheetCT04
Esquema do Cenário: Validar que não é possível alterar item com status Aprovado
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	Então não consigo mais editar o item aprovado da Cue-Sheet <Obra>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Obra2             | Mensagem                    |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "TESTE INMETRICS" | "Item alterado com sucesso" |
