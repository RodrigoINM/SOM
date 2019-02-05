#language:pt
#Author: Rodrigo Magno
#Date: 04/02/2019

@kill_Driver @Pedido @BloquearEdicaoDePedido
Funcionalidade: Bloquear edição de item de pedido

Contexto: 
    Dado que esteja logado no sistema SOM

@chrome @BloquearEdicaoDePedidoCT01
Cenario: Bloquear alteração de pedidos que estão aguardando aprovação quando é alterado o DDA da Obra
	Dado que tenha um pedido previamente cadastrado no sistema com apenas um autor na composição
	E que possua um item que esteja aguardando aprovação para pagamento
	Quando altero o DDA da Obra que possui um pedido que esteja aguardando aprovação 
	Entao nao visualizo o pedido aguardando aprovacao na lista de pedidos a serem afetados pela auteração

@chrome @BloquearEdicaoDePedidoCT02
Cenario: Bloquear alteração de pedidos que estão aguardando aprovação quando é alterado o Autor da Obra
	Dado que tenha um pedido previamente cadastrado no sistema com apenas um autor na composição
	E que possua um item que esteja aguardando aprovação para pagamento
	Quando altero o Autor da Obra que possui um pedido que esteja aguardando aprovação 
	Entao nao visualizo o pedido aguardando aprovacao na lista de pedidos a serem afetados pela auteração
	
@chrome @BloquearEdicaoDePedidoCT03
Cenario: Bloquear alteração de pedidos que estão aguardando aprovação quando tentar incluir itens para DNI
	Dado que tenha um pedido previamente cadastrado no sistema com apenas um autor na composição
	E que possua um item que esteja aguardando aprovação para pagamento
	Quando tento cadastrar novos itens de DNI para o pedido
	Então visualizo apenas o item do pedido na tela de detalhes

#Esquema do Cenario: Bloquear alteração de pedidos que estão aguardando aprovação quando é feita transferencia De / Para de Obra
#    Dado que esteja editando a composicao de uma <Obra> que possua um <Pedido> aguardando aprovacao
#    Quando faco transferencia da <Obra> para <SegundaObra>
#    Entao nao visualizo o <Pedido> aguardando aprovacao na lista de pedidos a serem afetados pela auteracao
#      
#  Exemplos:
#      | Obra    | Pedido    | SegundaObra | 
#      | "Teste" | "1000498" | "Teste 2"   | 
#  
