#language:pt
#Author: Rodrigo Magno
#Date: 01/02/2019

@kill_Driver @Pedido @VisualizarDetalhesDePedido
Funcionalidade: 6.1.6 - Visualização e consulta de Pedidos

Contexto: Acessar tela de detalhes do pedido
    Dado que esteja logado no sistema SOM

@chrome @VisualizarDetalhesDePedidoCT01
Cenário: Visualização de Pagamento
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que esteja na tela de detalhes de um pedido criado manualmente
	Quando acesso a aba de pagamento na tela de detalhes do pedido
	Então visualizo os dados do pedido na aba de pagamento com sucesso

@chrome @VisualizarDetalhesDePedidoCT02
Cenario: Visualização de Autorização
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que esteja na tela de detalhes de um pedido criado manualmente
	Quando acesso a aba de autorização na tela de detalhes do pedido
	Então visualizo os dados do pedido na aba de autorização com sucesso
