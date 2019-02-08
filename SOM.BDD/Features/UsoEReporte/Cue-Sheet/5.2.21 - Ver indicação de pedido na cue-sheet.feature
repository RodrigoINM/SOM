#language:pt
#Author: Rodrigo Magno
#Date: 08/02/2019

@kill_Driver @VerIndicacaoDePedidoNaCueSheet
Funcionalidade: 5.2.21 - Ver indicação de pedido na cue-sheet

Contexto: Ver indicação de pedido na cue-sheet
    Dado que esteja logado no sistema SOM

@chrome @VerIndicacaoDePedidoNaCueSheetCT01
Cenário: Consultar o pedido com sucesso
	Dado que tenha uma Cue-Sheet cadastrada com dois pedidos gerados
	Quando acesso o icone do pedido na Cue-Sheet
	Então visualizo a tela de detalhes do pedido cadastrado com sucesso