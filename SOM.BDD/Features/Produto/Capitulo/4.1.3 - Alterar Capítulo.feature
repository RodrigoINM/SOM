#language:pt
#Author: Rodrigo Magno
#Date: 30/01/2019

@kill_Driver @Capitulo @AlteracaoDeCapitulo
Funcionalidade: 4.1.3 - Alterar capítulos
Como um usuário com permissão para alterar pedido
Eu quero poder atualizar as informações de capítulo para um produto já cadastrado
Para que possa utilizar os dados no cadastro associada ao produto

Critérios de aceite:
Sistema deverá utilizar os dados cadastrados de capítulo associada ao produto

Contexto: Acessar a tela de Edição de Capitulo
    Dado que esteja logado no sistema SOM

@chrome @AlteracaoDeCapituloCT01
Esquema do Cenário: Alterar capítulo
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de consulta de capitulos
    Quando faço uma busca de capítulo por nome do Produto <NomeProduto>
	E altero o número do capítulo do produto cadastrado <NomeProduto>, <Capitulo>
	Então visualizo a mensagem de que o capítulo foi alterado com sucesso <Mensagem>
	  
  Exemplos:
      | NomeProduto | Capitulo | Mensagem                           | 
      | "Aleatório" | "54"     | "Registro adicionado com sucesso." | 
  
@chrome @AlteracaoDeCapituloCT02
Esquema do Cenário: Alterar Capítulo para um número de capítulo já existente para o Produto associado
	Dado que tenha um produto cadastrado no sistema com dois capitulos cadastrados <Capitulo1>, <Capitulo2>
	E que esteja na tela de consulta de capitulos
    Quando faço uma busca de capítulo por nome do Produto e capitulos inicial e final <NomeProduto>, <CapituloInicial>, <CapituloFinal>
	E altero o valor de um capitulo para o mesmo valor do outro já cadastrado <Capitulo1>, <Capitulo2>
	Então visualizo a mensagem de que já existe um capitulo cadastrado com esses dados no produto <Mensagem>
	  
	  
  Exemplos:
      | NomeProduto | CapituloInicial | CapituloFinal | Capitulo1 | Capitulo2 | Mensagem                                                    |
      | "Aleatório" | "10"            | "10"          | "10"      | "22"      | "Existe um registro com esses dados cadastrado no sistema." |
