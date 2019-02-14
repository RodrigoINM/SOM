#language:pt
#Author: Rodrigo Magno
#Date: 06/02/2019

@kill_Driver @ExcluirItensDeCueSheet
Funcionalidade: 5.2.11 - Excluir um item selecionado na cue-sheet

Contexto: Excluir um item selecionado na cue-sheet
    Dado que esteja logado no sistema SOM

@chrome @ExcluirItensDeCueSheetCT01
Esquema do Cenário: Excluir um item selecionado com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT02
Esquema do Cenário: Excluir todos os itens selecionados com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando excluo os dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT03
Esquema do Cenário: Cancelar exlusão de item de Cue-Sheet
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando seleciono um item e clico em excluir <Obra>
	Mas cancelo a exclusão do item da Cue-Sheet
	Então visualizo os dados do item da Cue-Sheet na grid com sucesso <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>

  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        |
  
@chrome @ExcluirItensDeCueSheetCT04
Esquema do Cenário: Excluir um item pendente com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT05
Esquema do Cenário: Cancelar exclusão de um item da cue-sheet
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando seleciono os itens e clico em excluir <Obra>, <Obra2>
	Mas cancelo a exclusão dos itens da Cue-Sheet
	Então visualizo os dados dos itens da Cue-Sheet na grid com sucesso <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT06
Esquema do Cenário: Exclusão de item sem fechamento ao ECAD, UBEM ou pedido associado
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	E que tenha um item aprovado <Obra>
	E que tenha um item com pedido enviado para pagamento
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT07
Esquema do Cenário: Exclusão de item com fechamento ao ECAD
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	E que tenha um item aprovado <Obra>
	E que tenha um item com pedido enviado para pagamento
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  

@chrome @ExcluirItensDeCueSheetCT08
Esquema do Cenário: Exclusão de item com fechamento ao UBEM
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	E que tenha um item aprovado <Obra>
	E que tenha um item com pedido enviado para pagamento
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT09
Esquema do Cenário: Exclusão total de itens com pedido "Em andamento"
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	E que tenha um item aprovado <Obra>
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @ExcluirItensDeCueSheetCT10
Esquema do Cenário: Exclusão parcial de itens com pedido "Em andamento"
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	E que tenha um item aprovado <Obra>
	Quando excluo um item cadastrado na Cue-Sheet <Obra>
	Então visualizo uma mensagem de registro excluido com sucesso <Mensagem>

  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  