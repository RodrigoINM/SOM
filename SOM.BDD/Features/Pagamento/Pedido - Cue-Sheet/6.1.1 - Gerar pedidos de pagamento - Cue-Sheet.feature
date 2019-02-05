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
  
@chrome @PedidosPagamentoCueSheetCT02
Esquema do Cenario: Alteração de obra - Pedido já existente para a mesma obra e sincronismo
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
	E que eu tenha dois pedidos gerados para itens de cue-sheet com obras diferentes <TITULO1> e <TITULO2>
	Quando altero a titulo da obra <TITULO2> para o mesmo da obra <TITULO1>
    Então visualizo o icone de pedido no item de cue-sheet com o pedido existente associado para <TITULO1>, <SINCRONISMO2>, <TEMPOSOMADO>, <TEMPO>, <TEMPO2>
	  
  Exemplos: 
      | TITULO1          | TITULO2        | SINCRONISMO | TEMPOSOMADO | SINCRONISMO2 | TEMPO | TEMPO2 |
      | "TESTE DE 500MB" | "MUSICA TESTE" | "ADORNO"    | "41"        | "FUNDO"      | "16"  | "25"   |

@chrome @PedidosPagamentoCueSheetCT03
Esquema do Cenario: Não marcar para gerar pedido linhas de ABERTURA ou TEMA
	Dado que tenha uma cue-sheet do genero jornalismo previamente cadastrada
	E que possuo itens de sincronismo ABERTURA. <TITULO>, <UTITLIZACAO>, <SINCRONISMO>, <TEMPO>
	E possuo itens de sincronismo TEMA. <TITULO>, <UTITLIZACAO>, <SINCRONISMO2>, <TEMPO2>
	Quando acesso a tela de Gerar Pedido
	Então não visualizo os itens de ABERTURA <SINCRONISMO> ou TEMA <SINCRONISMO2> selecionados. <TITULO>, <TEMPO>, <TEMPO2>
	  
  Exemplos: 
      | TITULO           | UTITLIZACAO       | SINCRONISMO | SINCRONISMO2 | TEMPO | TEMPO2 |
      | "TESTE DE 500MB" | "BK – BACKGROUND" | "ABERTURA"  | "TEMA"       | "16"  | "25"   |
	  
@chrome @PedidosPagamentoCueSheetCT04
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
  
@chrome @PedidosPagamentoCueSheetCT05
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
	  