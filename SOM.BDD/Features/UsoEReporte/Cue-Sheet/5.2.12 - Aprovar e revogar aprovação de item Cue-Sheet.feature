#language:pt
#Author: Rodrigo Magno
#Date: 06/02/2019

@kill_Driver @AprovarERevogarItemCueSheet
Funcionalidade: 5.2.12 - Aprovar e revogar aprovação de item cue-sheet

Contexto: Aprovar e/ou revogar aprovação de um item da cue-sheet
      Dado que esteja logado no sistema SOM

@chrome @AprovarERevogarItemCueSheetCT01
Esquema do Cenário: Aprovar um item com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	Então visualizo o percentual de aprovação da Cue-Sheet alterado <Percentual>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Percentual |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | " 100,00%" |

@chrome @AprovarERevogarItemCueSheetCT02
Esquema do Cenário: Validar aprovação de itens com status Pendente
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet sem Interprete <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Então visualizo uma mensagem de alerta informando que o item não pode ser aprovado devido a pendencia do Interprete
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        |

@chrome @AprovarERevogarItemCueSheetCT03
Esquema do Cenário: Aprovar vários itens sem impedimento
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>
	Então visualizo os itens aprovados na Cue-Sheet com sucesso <Obra>, <Obra2>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
@chrome @AprovarERevogarItemCueSheetCT04
Esquema do Cenário: Revogar item com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo um item da Cue-Sheet <Obra>
	E revogo a aprovação de um item da Cue-Sheet <Obra>
	Então visualizo o percentual de aprovação da Cue-Sheet alterado <Percentual>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete | Percentual |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | " 0,00%"   |

@chrome @AprovarERevogarItemCueSheetCT05
Esquema do Cenário: Revogar vários itens
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>
	E revogo a aprovação de dois itens da Cue-Sheet <Obra>, <Obra2>
	Então visualizo o percentual de aprovação da Cue-Sheet alterado <Percentual>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Percentual |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | " 0,00%"   |
  
@chrome @AprovarERevogarItemCueSheetCT06
Esquema do Cenário: Aprovar todos os itens com sucesso
	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Quando aprovo dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>
	Então visualizo os itens aprovados na Cue-Sheet com sucesso <Obra>, <Obra2>
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
  
#
#@chrome @AprovarERevogarItemCueSheetCT07
#Esquema do Cenário: Revogar itens com pedidos em aberto
#	Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
#	E que tenha dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
#	Quando aprovo dois itens cadastrados na Cue-Sheet <Obra>, <Obra2>
#	Então visualizo os itens aprovados na Cue-Sheet com sucesso <Obra>, <Obra2>
#	
#  Exemplos:
#      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Obra2             | Utilizacao        | Sincronismo | Tempo | Interprete | Mensagem                           |
#      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "TESTE INMETRICS" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        | "Registros excluídos com sucesso." |
#  
#
#
#      Dado que o item de <Ordem> tenha um <NumeroPedido> com <StatusPedido>
#      Quando revogo este item
#      Então visualizo a <Mensagem>
#
#      Exemplos:
#          | Ordem | NumeroPedido | StatusPedido   | Mensagem                                                  |
#          | "1"   | "1000553"    | "Em Andamento" | "A aprovação foi revogada e o item liberado para edição." |
#

#Esquema do Cenário: Revogar itens enviados ao ECAD
#    Dado que o item de <Ordem> tenha um <NumeroPedido> e tenha sido enviado ao relatório ECAD
#    Quando revogo este item
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Ordem | NumeroPedido | Mensagem                                                  |
#        | "1"   | "1000553"    | "A aprovação foi revogada e o item liberado para edição." |
#
#
#Esquema do Cenário: Revogar itens enviados ao UBEM
#    Dado que o item de <Ordem> tenha um <NumeroPedido> e tenha sido enviado ao relatório UBEM
#    Quando revogo este item
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Ordem | NumeroPedido | Mensagem                                                  |
#        | "1"   | "1000553"    | "A aprovação foi revogada e o item liberado para edição." |
#
#
#Esquema do Cenário: Revogar itens enviados para pagamento
#    Dado que o item de <Ordem> tenha um <NumeroPedido> e tenha sido enviado para pagamento
#    Quando revogo este item
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Ordem | NumeroPedido | Mensagem                                                  |
#        | "1"   | "1000553"    | "A aprovação foi revogada e o item liberado para edição." |

#Esquema do Cenário: Aprovar com usuário sem permissão
#    Dado que logo com um usuário sem premissão
#    Quando tento aprovar um item com <Ordem>
#    Então não visualizo o ícone de aprovação
#
#    Exemplos:
#        | Ordem |
#        | "1"   |
#
#
#Esquema do Cenário: Revogar com usuário sem permissão
#    Dado que logo com um usuário sem premissão
#    Quando tento revogar um item com <Ordem>
#    Então não visualizo o ícone de revogação
#
#    Exemplos:
#        | Ordem |
#        | "1"   |