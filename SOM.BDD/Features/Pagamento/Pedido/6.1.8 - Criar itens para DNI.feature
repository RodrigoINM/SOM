#language:pt
#Author: Rodrigo Magno
#Date: 01/02/2019

@kill_Driver @Pedido @GerarItensParaDNI
Funcionalidade: 6.1.8 - Gerar itens para DNI

Contexto: 
    Dado que esteja logado no sistema SOM

@chrome @GerarItensParaDNICT01
Cenario: Gerar item de DNI
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que esteja na tela de detalhes de um pedido criado manualmente
	Quando cadastrar um item de DNI para o pedido
	Entao visualizo os novos itens de DNI cadastrados no detalhe do pedido com sucesso

@chrome @GerarItensParaDNICT02
Cenario: Cancelar geração de itens de DNI
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que esteja na tela de detalhes de um pedido criado manualmente
	Quando cancelo o cadastro de um item de DNI para o pedido
	Então visualizo apenas o item do pedido na tela de detalhes
	
@chrome @GerarItensParaDNICT03
Esquema do Cenario: Gerar mais de um itens para DNI
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que esteja na tela de detalhes de um pedido criado manualmente
	E que o pedido já possua itens de DNI cadastrados
	Quando tento cadastrar novos itens de DNI para o pedido
	Então visualizo uma mensagem de que o peido já possui itens de DNI cadastrados <Mensagem>
	  
  Exemplos: 
      | Mensagem                                        |
      | "Este pedido já possui itens para a mídia DNI." |
  