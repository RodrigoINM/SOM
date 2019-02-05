#language: pt-BR
#Author: Rodrigo Magno
#Date: 05/11/2018
#Version: 1.0

@kill_Driver @Produto @ExclusaoDeProduto
Funcionalidade: 4.1.8 - Excluir Produto

Contexto: Acessar a tela de Busca por produto
	Dado que esteja logado no sistema SOM

@chrome @ExclusaoDeProdutoCT01
Esquema do Cenario: Excluir Produto
	Dado que tenha um produto cadastrado no sistema sem possuir um capitulo relacionado
	E que tenha feito uma busca pelo produto
	Quando excluo o produto
	Entao visualizo a mensagem <Mensagem> de exclusao do produto

  Exemplos:
      | Mensagem                         |
      | "Registro excluído com sucesso." |
  
@chrome @ExclusaoDeProdutoCT02
Cenário: Cancelar Exclusão de Produto
	Dado que tenha um produto cadastrado no sistema
	E que tenha feito uma busca pelo produto
	Quando cancelo a exclusão do produto
	Então visualizo o produto no resultado da busca com sucesso