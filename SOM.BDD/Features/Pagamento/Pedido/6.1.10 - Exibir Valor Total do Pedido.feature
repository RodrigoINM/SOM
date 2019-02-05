#language:pt
#Author: Rodrigo Magno
#Date: 04/12/2018
#Version: 1.0

@kill_Driver @CriarPedidoManual @Pedidos
Funcionalidade: 6.1.10 - Seleção de itens e atualização do Valor Total

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @CriarPedidoManualCT01
Cenario: Seleção de um item
	Dado que tenha um pedido previamente cadastrado no sistema
	E que esteja na aba de pagamento
	Quando seleciono um item do pedido
	Entao visualizo o valor total do item selecionado

@chrome @CriarPedidoManualCT02
Cenario: Soma de itens no detalhe do pedido
    Dado que tenha um pedido previamente cadastrado no sistema
	E que esteja na aba de pagamento
	Quando seleciono dois itens do pedido
	Entao visualizo o valor total da soma dos itens selecionados

@chrome @CriarPedidoManualCT03
Cenario: Subtração de itens no detalhe do pedido
    Dado que tenha um pedido previamente cadastrado no sistema
	E que esteja na aba de pagamento
    Quando seleciono todos os itens do pedido
    E retiro da selecao um item
    Entao visualizo o valor total menos o valor do item nao selecionado

@chrome @CriarPedidoManualCT04
Cenario: Soma de itens na busca por pedido
	Dado que tenha um pedido previamente cadastrado no sistema
	E realizo uma consulta pelo numero do pedido
	Quando seleciono todos os itens do pedido na aba de pagamento
	Entao visualizo o valor total da soma dos itens selecionados no resultado da busca

@chrome @CriarPedidoManualCT05
Cenario: Subtração de itens na busca por pedido
    Dado que tenha um pedido previamente cadastrado no sistema
    E realizo uma consulta pelo numero do pedido
	Quando seleciono todos os itens do pedido na aba de pagamento
	E retiro da selecao um item do pedido
	Entao visualizo o valor total menos o valor do item não selecionado no resultado da busca