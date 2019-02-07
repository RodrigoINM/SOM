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
  

##Conversa#==========#==========#==========#==========#==========#==========#==========#==========#==========#==========#
#    #Regras definidas em reunião com o cliente
#    Ao excluir um item que nunca foi enviado ao ECAD ou a UBEM o item poderá ser excluído definitivamente.
#    Ao excluir um item que já foi enviado ao ECAD ou a UBEM deve ser desativado para manter histórico no relatório.
#    Ao excluir um item de cue-sheet que possuo pedido é necessário cancelar todos os itens cujo status de pagamento sejam diferentes de "Aguardando Aprovação", "Aprovado" ou "Cancelado" e o item deve ser desativado para manter o histórico.
#    Os pedidos com todos os itens cancelados também serão cancelados.
#    Deve ser exibida mensagem ao usuário informando que o pedido ou pedidos associados aos itens serão cancelado e solicitar confirmação para a ação de exclusão.
#    
##CTs escritos pela Marcelle #==========#==========#==========#==========#==========#==========#==========#==========#
#Contexto:
#    Dado que estou na tela de detalhe da cue-sheet
#    E selecionei os itens que desejo excluir
#
#    Cenário: Exclusão de item sem fechamento ao ECAD, UBEM ou pedido associado
#        Dado que nenhum dos itens selecionados foi relacionado no fechamento ECAD ou UBEM
#        Quando confirmo a exclusão dos itens
#        Então visualizo a mensagem confirmando a exclusão
#        E não visualizo as linhas excluídas na cue-sheet
#        E o item é excluído fisicamente da base de dados
#
#    Cenário: Exclusão de item com fechamento ao ECAD
#        Dado que os itens selecionados foram relacionados no fechamento ECAD
#        Quando confirmo a exclusão dos itens
#        Então visualizo a mensagem confirmando a exclusão
#        E não visualizo as linhas excluídas na cue-sheet
#        E o item inativado na base para ser usado em futuros relatórios de complemento
#
#    Cenário: Exclusão de item com fechamento ao UBEM
#        Dado que os itens selecionados foram relacionados no fechamento UBEM
#        Quando confirmo a exclusão dos itens
#        Então visualizo a mensagem confirmando a exclusão
#        E não visualizo as linhas excluídas na cue-sheet
#        E o item inativado na base para ser usado em futuros relatórios de complemento
#
#    Cenário: Exclusão total de itens com pedido "Em andamento"
#        Dado que os itens selecionados estão associados a pedido com status em andamento
#        E não existem outros itens associados ao mesmo pedido
#        Quando confirmo a exclusão dos itens
#        Então visualizo a mensagem confirmando a exclusão
#        E não visualizo as linhas excluídas na cue-sheet
#        E todos os itens do pedido com status diferente de "Aguardando Aprovação", "Aprovado" ou "Cancelado" são cancelados
#        E o item inativado na base para histórico
#
#    Cenário: Exclusão parcial de itens com pedido "Em andamento"
#        Dado que os itens selecionados estão associados a pedido com status em andamento
#        Mas existem outros itens associados ao mesmo pedido
#        Quando confirmo a exclusão dos itens
#        Então visualizo a mensagem confirmando a exclusão
#        E não visualizo as linhas excluídas na cue-sheet
#        E o item inativado na base para histórico