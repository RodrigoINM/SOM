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
  
#Esquema do Cenario: Donwload do espelho de pagamento em PDF
#    Dado que tenha feito uma busca por <NumeroPedidoInicial> e <NumeroPedidoFinal>
#    Quando faco download do espelho de pagamento em pdf
#    Entao visualizo <Obra>, <Autor>, <Sincronismo>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <Atividade>, <AR>, <Autorizacao> e <Valor> do pedido no espelho de pagamento em pdf
#    
#  Exemplos:
#      | NumeroPedidoInicial   | NumeroPedidoFinal   | Obra   | Autor   | Sincronismo   | Produto   | Episodio   | Capitulo   | DataExibicao   | Atividade   | AR   | Autorizacao   | Valor   | 
#      | "NumeroPedidoInicial" | "NumeroPedidoFinal" | "Obra" | "Autor" | "Sincronismo" | "Produto" | "Episodio" | "Capitulo" | "DataExibicao" | "Atividade" | "AR" | "Autorizacao" | "Valor" | 
#  
#Esquema do Cenario: Donwload do espelho de pagamento em EXCEL
#    Dado que tenha feito uma busca por <NumeroPedidoInicial> e <NumeroPedidoFinal>
#    Quando faco download do espelho de pagamento em excel
#    Entao visualizo <Obra>, <Autor>, <Sincronismo>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <Atividade>, <AR>, <Autorizacao> e <Valor> do pedido no espelho de pagamento em excel
#    
#  Exemplos:
#      | NumeroPedidoInicial   | NumeroPedidoFinal   | Obra   | Autor   | Sincronismo   | Produto   | Episodio   | Capitulo   | DataExibicao   | Atividade   | AR   | Autorizacao   | Valor   | 
#      | "NumeroPedidoInicial" | "NumeroPedidoFinal" | "Obra" | "Autor" | "Sincronismo" | "Produto" | "Episodio" | "Capitulo" | "DataExibicao" | "Atividade" | "AR" | "Autorizacao" | "Valor" | 
#  
#Esquema do Cenario: Enviar espelho de pagamento
#    Dado que tenha feito uma busca por <NumeroPedidoInicial> e <NumeroPedidoFinal>
#    Quando faco download do espelho de pagamento
#    Entao visualizo um <Arquivo> de envio de email com o espelho de pagamento em excel
#      
#  Exemplos:
#      | NumeroPedidoInicial   | NumeroPedidoFinal   | Arquivo   | 
#      | "NumeroPedidoInicial" | "NumeroPedidoFinal" | "Arquivo" | 
  