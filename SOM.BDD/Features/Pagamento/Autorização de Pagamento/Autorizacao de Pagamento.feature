#language:pt
#Author: Rodrigo Magno
#Date: 25/01/2018

@kill_Driver @ConsultaAutorizaçãoDePagamento
Funcionalidade: Consulta por autorização de pagamentos

Contexto: 
	Dado que esteja logado no sistema SOM
	E que esteja na tela de Autorizacao de Pagamentos
	
@chrome	@ConsultaAutorizaçãoDePagamentoCT01
Esquema do Cenario: Busca rápida por número de AP
	Quando faço uma busca rápida pelo número de AP <AP>
	Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  
  Exemplos:
      | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      | 
      | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" | 
  
@chrome	@ConsultaAutorizaçãoDePagamentoCT02
Esquema do Cenario: Busca por AP inicial e AP final
	Quando faço uma busca avançada de solicitações de pedidos para pagamento por AP Inicial e AP Final <APInicial>, <APFinal>
	Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  
  Exemplos:
      | APInicial | APFinal   | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      | 
      | "1003194" | "1003194" | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" | 
  
@chrome	@ConsultaAutorizaçãoDePagamentoCT03
Esquema do Cenario: Busca por Lote inicial e Lote final
	Quando faço uma busca avançada de solicitações de pedidos para pagamento por Lote Inicial e Lote Final <LoteInicial>, <LoteFinal>
	Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  
  Exemplos:
      | LoteInicial | LoteFinal | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      |
      | "1000319"   | "1000319" | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" |
  
@chrome	@ConsultaAutorizaçãoDePagamentoCT04
Esquema do Cenario: Busca por Numero do pedido inicial e Numero do pedido final
	Quando faço uma busca avançada de solicitações de pedidos para pagamento por Número Pedido Inicial e Número Pedido Final <NumeroPedidoInicial>, <NumeroPedidoFinal>
	Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  	  
  Exemplos:
      | NumeroPedidoInicial | NumeroPedidoFinal | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      | 
      | "1001404"           | "1001404"         | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" | 
  
@chrome	@ConsultaAutorizaçãoDePagamentoCT05
Esquema do Cenario: Busca por DDA e numero de pedido inicial
    Quando faço uma busca avançada de solicitações de pedidos para pagamento por DDA e Número Pedido Inicial <DDA>, <NumeroPedidoInicial>
    Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  	  
  Exemplos:
      | NumeroPedidoInicial | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      | 
      | "1001404"           | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" | 
  
@chrome	@ConsultaAutorizaçãoDePagamentoCT06
Esquema do Cenario: Busca por AR e numero de pedido inicial
    Quando faço uma busca avançada de solicitações de pedidos para pagamento por AR e Número Pedido Inicial <AR>, <NumeroPedidoInicial>
    Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  	  
  Exemplos:
      | NumeroPedidoInicial | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      | 
      | "1001404"           | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" | 
  
@chrome	@ConsultaAutorizaçãoDePagamentoCT07
Esquema do Cenario: Busca por data inicial da AP e data final da AP
     Quando faço uma busca avançada de solicitações de pedidos para pagamento por Data Inicial da Ap e Data Final da Ap <DataInicialAp>, <DataFinalAp>, <NumeroPedidoInicial>
    Então visualizo os dados da solicitação de pagamento para pedido no resultado da busca <AP>, <Lote>, <LPE>, <AR>, <Midia>, <Creditado>, <Valor>
  	  
  Exemplos:
      | NumeroPedidoInicial | AP        | Lote      | LPE      | AR       | Midia       | Creditado             | Valor      | DataInicialAp | DataFinalAp  |
      | "1001404"           | "1003194" | "1000319" | "307370" | "290407" | "GLOBONEWS" | "Hildegard1167235435" | "R$ 47,25" | "25/01/2019"  | "25/01/2019" |
 
@chrome	@ConsultaAutorizaçãoDePagamentoCT08  
Esquema do Cenario: Donwload do espelho de pagamento em PDF
	Quando faço uma busca avançada de solicitações de pedidos para pagamento por AP Inicial e AP Final <APInicial>, <APFinal>
	Então realizo o download do espelho de pagamento em PDF

	Exemplos:
      | APInicial | APFinal   |
      | "1003194" | "1003194" |
 
@chrome	@ConsultaAutorizaçãoDePagamentoCT09  
Esquema do Cenario: Donwload do espelho de pagamento em EXCEL
    Quando faço uma busca avançada de solicitações de pedidos para pagamento por AP Inicial e AP Final <APInicial>, <APFinal>
    Entao visualizo o aquivo com os dados <Lote>, <NumeroDaAp>, <NumeroDaLPE>, <Editora>, <DataDeEmissao>, <Produto>, <Episodio>, <Capitulo>, <DataDeExibicao>, <Obra>, <Autor>, <Atividade>, <Creditado>, <Sincronismo>, <Percentual>, <Ar>, <Autorizacao> , <Valor> e <NomePlanilha> do pedido no espelho de pagamento em excel
    
  Exemplos:
      | APInicial | APFinal   | Lote      | NumeroDaAp | NumeroDaLPE | Editora               | DataDeEmissao | Produto                          | Episodio            | Capitulo | DataDeExibicao | Obra                | Autor             | Atividade | Creditado        | Sincronismo | Percentual | Ar       | Autorizacao  | Valor   | NomePlanilha        |
      | "1003194" | "1003194" | "1000319" | "1003194"  | "307370"    | "HILDEGARD1167235435" | "25/01/2019"  | "AVIS1816412639 OZANE1633164760" | "PAULETTE436942029" | "01"     | "10/10/2018"   | "JONELLE1677499510" | "HIRAM1326096162" | "7001"    | "AURA1386471269" | "ABERTURA"  | "70"       | "290407" | "2019010012" | "47,25" | "Espelho Pagamento" |
 
#@chrome	@ConsultaAutorizaçãoDePagamentoCT10   
#Esquema do Cenario: Enviar espelho de pagamento
#    Quando faço uma busca avançada de solicitações de pedidos para pagamento por AP Inicial e AP Final <APInicial>, <APFinal>
#    Quando faco download do espelho de pagamento para ser enviado por email
#      
#  Exemplos:
#      | APInicial | APFinal   |
#      | "1003194" | "1003194" |
  