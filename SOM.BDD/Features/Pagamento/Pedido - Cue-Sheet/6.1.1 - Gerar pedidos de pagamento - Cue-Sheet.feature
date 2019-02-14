#language:pt
#Author: Rodrigo Magno
#Date: 12/11/2018
#Version: 1.0

@kill_Driver @PedidosPagamentoCueSheet @Pedidos
Funcionalidade: 6.1.1 - Gerar pedidos de pagamento - Cue-Sheet

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @PedidosPagamentoCueSheetCT01
Esquema do Cenario: Inclusão de novo item - Pedido já existente para a mesma obra e sincronismo (Exceto Abertura e Tema)
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
    E que já existe pedido com os mesmos dados da cue-sheet <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO>
    E incluo uma nova linha para um mesmo <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO2>
    Quando confirmo a geração de pedido para <TITULO> e <SINCRONISMO>
    Então visualizo o icone de pedido no item de cue-sheet com o pedido existente associado <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPOSOMADO>, <TEMPO>, <TEMPO2>
	  
  Exemplos: 
      | TITULO           | UTITLIZACAO       | SINCRONISMO | TEMPO | TEMPO2 | TEMPOSOMADO |
      | "TESTE DE 500MB" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | "25"   | "41"        |
  
@chrome @PedidosPagamentoCueSheetCT02
Esquema do Cenario: Alteração de sincronismo - Pedido já existente para a mesma obra e sincronismo
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
	E que eu tenha dois pedidos gerados para itens de cue-sheet com sincronismos diferentes <SINCRONISMO1> E <SINCRONISMO2>
	Quando altero o <SINCRONISMO2> para o mesmo de <SINCRONISMO1>
    Então visualizo o icone de pedido no item de cue-sheet com o pedido existente selecionado <TITULO>, <SINCRONISMO>, <TEMPOSOMADO>, <TEMPO>, <TEMPO2>
	  
  Exemplos: 
      | TITULO               | SINCRONISMO1 | TEMPOSOMADO | SINCRONISMO2   | SINCRONISMO | TEMPO | TEMPO2 |
      | "MUSICA DA MARCELLE" | "ADORNO"     | "41"        | "ENCERRAMENTO" | "FUNDO"     | "16"  | "25"   |
  
@chrome @PedidosPagamentoCueSheetCT03
Esquema do Cenario: Alteração de obra - Pedido já existente para a mesma obra e sincronismo
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
	E que eu tenha dois pedidos gerados para itens de cue-sheet com obras diferentes <TITULO1> e <TITULO2>
	Quando altero a titulo da obra <TITULO2> para o mesmo da obra <TITULO1>
    Então visualizo o icone de pedido no item de cue-sheet com o pedido existente associado para <TITULO1>, <SINCRONISMO2>, <TEMPOSOMADO>, <TEMPO>, <TEMPO2>
	  
  Exemplos: 
      | TITULO1          | TITULO2        | SINCRONISMO | TEMPOSOMADO | SINCRONISMO2 | TEMPO | TEMPO2 |
      | "TESTE DE 500MB" | "MUSICA TESTE" | "ADORNO"    | "41"        | "FUNDO"      | "16"  | "25"   |

@chrome @PedidosPagamentoCueSheetCT04
Esquema do Cenario: Não marcar para gerar pedido linhas de ABERTURA ou TEMA
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
	E que possuo itens de sincronismo ABERTURA. <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO>
	E possuo itens de sincronismo TEMA. <TITULO>, <UTITLIZACAO>, <SINCRONISMO2>, <TEMPO2>
	Quando acesso a tela de Gerar Pedido
	Então não visualizo os itens de ABERTURA <SINCRONISMO> ou TEMA <SINCRONISMO2> selecionados. <TITULO>, <TEMPO>, <TEMPO2>
	  
  Exemplos: 
      | TITULO           | UTITLIZACAO       | SINCRONISMO | SINCRONISMO2 | TEMPO | TEMPO2 |
      | "TESTE DE 500MB" | "BK – BACKGROUND" | "ABERTURA"  | "TEMA"       | "16"  | "25"   |
	  
@chrome @PedidosPagamentoCueSheetCT05
Esquema do Cenario: Novo item ABERTURA ou TEMA válido em Variedades ou Jornalismo ou Esporte com pedido existente
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
	E que existe um pedido de ABERTURA ou TEMA para <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO>
	E que eu tenha criado um item novo item. <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO2>
	Quando acesso a tela de Gerar Pedido
	Então visualizo uma observação informando que existe pedido válido
	E visualizo o ícone para o pedido que será associado após a geração
    Quando seleciono o item e confirmo a geração do pedido <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPOSOMADO>
    Então visualizo o pedido existente associado ao item de cue-sheet <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPOSOMADO>, <TEMPO>, <TEMPO2>
	
  Exemplos: 
      | TITULO           | UTITLIZACAO       | SINCRONISMO | TEMPO | TEMPO2 | TEMPOSOMADO |
      | "TESTE DE 500MB" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | "25"   | "41"        |
  
@chrome @PedidosPagamentoCueSheetCT06
Esquema do Cenario: Novo item ABERTURA ou TEMA em Dramaturgia com pedido existente
	Dado que tenha uma cue-sheet do genero Dramaturgia previamente cadastrada
	E que existe um pedido de ABERTURA ou TEMA para <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO>
	E que eu tenha criado um item novo item. <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO2>
	Quando acesso a tela de Gerar Pedido
	Então visualizo o ícone para o pedido que será associado após a geração
    Quando seleciono o item e confirmo a geração do pedido <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPOSOMADO>
	Então visualizo o pedido existente associado ao item de cue-sheet <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPOSOMADO>, <TEMPO>, <TEMPO2>
	
  Exemplos: 
      | TITULO           | UTITLIZACAO       | SINCRONISMO | TEMPO | TEMPO2 | TEMPOSOMADO |
      | "TESTE DE 500MB" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | "25"   | "41"        |
	  

@chrome @PedidosPagamentoCueSheetCT07
Esquema do Cenario: Gerar pedido sem itens aprovados
    Dado que tenha uma Cue-Sheet cadastrada no sistema <Produto>, <Episodio>, <Capitulo>, <Midia>, <Dia>, <Mes>, <Ano>, <RepriseRebatida>
	E que tenha um item cadastrado na Cue-Sheet <Obra>, <Utilizacao>, <Sincronismo>, <Tempo>, <Interprete>
	Então visualizo apenas o icone para aprovar o item cadastrado
	
  Exemplos:
      | Produto     | Episodio    | Capitulo | Midia       | Dia  | Mes  | Ano    | RepriseRebatida | Obra        | Utilizacao        | Sincronismo | Tempo | Interprete |
      | "Aleatório" | "Aleatório" | "01"     | "GLOBONEWS" | "12" | "12" | "2018" | "Não"           | "Aleatório" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | " "        |

@chrome @PedidosPagamentoCueSheetCT08
 Cenario: Gerar pedido para planilha de cue-sheet 100% aprovada
     Dado que tenha uma obra cadastrada no sistema
	 E que tenha um produto cadastrado no sistema
	 E que tenha uma cue-sheet cadastrada no sistema
	 E que tenha um item cadastrado na cue-sheet
	 Quando eu aprovo e crio um pedido para o item da Cue-Sheet
	 Então visualizo o pedido cadastrado com sucesso
	

#@chrome
#Esquema do Cenario: Alterar itens da obra com pedido em andamento
#	Quando altero os percentuais dos itens de composição de uma obra com pedido em andamento <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO>, <INTERPRETE>, <LINKCUESHEET>, <AUTORDDA>
#	Entao visualizo que os itens alterados foram cancelados no pedido
#	E foram gerados novos itens com os valores recalculados no pedido
#
#	
#  Exemplos: 
#      | LINKCUESHEET | TITULO      | UTITLIZACAO       | SINCRONISMO | TEMPO | INTERPRETE | AUTORDDA                           |
#      | "235830"     | "BANG BANG" | "BK – BACKGROUND" | "ABERTURA"  | "16"  | "ANITTA"   | "RAHMAKAN TURNBOW-WARNER CHAPPELL" |
#	  


#################################################################################################################	  

#É necessário selecionar as linhas que darão origem aos pedidos. Por padrão somente Obras comerciais geram pedido e aparecem selecionadas. Acredito que podemos colocar mais cenários de validação.
#temos uma regra também que impede a geração de pedido quando a obra possui todos os autores falecidos a mais de 70 anos (domínio público).
# 	Validar se o sistema está selecionando corretamente apenas linhas com músicas comerciais;
# 	Validar se a soma dos itens está sendo realizada corretamente, principalmente no que diz respeito a regra de Adorno e Fundo
# 	Validar as alterações na cue-sheet que afetam pedidos já gerados
#   Validar geração de pedido para obras com todos os autores falecidos a mais de 70 anos
  
# Esquema do Cenario: Gerar pedido com itens de cue-sheet parcialmente aprovados
#     Dado que estou na tela de detalhe da cue-sheet
#     E possuo itens parcialmente aprovados
#     Quando gero pedido apenas para os itens aprovados
#     Então visualizo a mensagem <Mensagem>
#     E visualizo o icone de detalhes do pedido gerado com sucesso apenas nos itens aprovados
  
#   Exemplos:
#       | Mensagem                      | 
#       | "Pedidos gerados com sucesso" | 


# #Conversa: #==========#==========#==========#==========#==========#==========#==========#==========#==========#
#   No momento da geração do pedido para novos itens deve ser verificado se já existe algum pedido na mesma cue-shet para a mesma Obra e mesmo sincronismo. Se houver o item deve ser associado ao pedido gerado.
#   Chave única para validação de duplicidade:
#   |SINCRONISMO|OBRA|MÍDIA|PRODUTO|EPISODIO|CAPITULO|DATA DE EXIBIÇÃO|
# #Cenários escritos por Marcelle #==========#==========#==========#==========#==========#==========#==========#==========#

#   Cenário: Associar reprise a pedido existente
#     Dado que alterei um item da cue-sheet para Reprise = Sim que possui um pedido com status "em andamento"
#     E o item é o único associado a esse pedido
#     E já existe outro pedido com a chave única de validação com reprise Sim
#     Quando confirmo a geração do pedido
#     Então o item é associado ao outro pedido existente
#     E o pedido que estava associado a ele tem seu itens cancelados

#   Cenário: Alterar pedido na alteração da reprise
#     Dado que alterei um item da cue-sheet para Reprise = Sim que possui um pedido com status "em andamento"
#     E não existe outro pedido com a chave única de validação com reprise Sim
#     Quando confirmo a geração do pedido
#     Então o pedido é alterado e recalculado com os valores de reprise

#   Cenário: Item com pedido associado com status cancelado
#   Dado que possuo um item de cue-sheet assocciado a um pedido com status "Cancelado"
#   Quando confirmo a geração do pedido para este item
#   Então é criado um novo pedido e associado ao item

# Cenário: Novo item ABERTURA ou TEMA expirado em Variedades ou Jornalismo ou Esporte com pedido existente
#   Dado que existe um pedido de ABERTURA ou TEMA para <OBRA>,<PRODUTO>/<EPISODIO> e <MÍDIA>
#   E a <DATA DE EXIBIÇÃO> é maior que 12 meses 
#   E o produto tem Gênero igual a "VARIEDADES DIÁRIA"ou "VARIEDADES SEMANAL" ou "JORNALISMO" ou "ESPORTE"
#   Quando acesso a tela de Gerar Pedido
#   Então visualizo uma observação informando que existe pedido expirado
#   E não visualizo o ícone para o pedido
#   Cenário:
#     Dado que executei o cenário acima
#     Quando seleciono o item e confirmo a geração do pedido
#     Então visualizo o novo pedido criado associado ao item de cue-sheet

#Histórias relacionadas:
  #User Story 139962:Desmarcar sincronismo ABERTURA e TEMA na geração de pedido
  #User Story 139505:Validar duplicidade na geração do pedido
  #User Story 140363:Validar duplicidade para sincronismos ABERTURA e TEMA na geração de pedido
  #User Story 99035:5.2.22 - Implementar cenários de alteração de pedido na cue-sheet
  #User Story 98573:5.2.21 - Ver indicação de pedido na cue-sheet
  #User Story 73285:6.1.1 - Gerar Pedido      