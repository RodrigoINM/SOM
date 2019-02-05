#language:pt
#Author: Rodrigo Magno
#Date: 07/01/2019

@kill_Driver @StatusPav @Pedidos
Funcionalidade: Validar Status Pav de Pedidos Autorizados para Pagamento

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @StatusPavCT01 @Pedidos
Esquema do Cenario: Alterar nacionalidade da obra para pedido com Status PAV Autorizado
    #Dado que tenha um pedido com Status Pav Aprovado <Pedido>
    Quando faço uma busca pela obra associada ao pedido <Obra>
    E altero a nacionalidade da obra <Nacionalidade>, <Pais>, <Obra>
	E seleciono o pedido a ser afetado pela alteracao <Pedido>
	E faço uma busca pelo pedido afetado <Pedido>
    Então visualizo que o Status Pav do pedido continua como Aprovado <StatusPav>, <Nacionalidade>, <Pais>, <Obra>, <Pedido>
        
  Exemplos:
      | Pedido    | Obra                    | Nacionalidade   | Pais       | StatusPav  |
      | "1000449" | "MUSICA DE TESTE 4 INT" | "Internacional" | "Alemanha" | "Aprovado" |
  
@chrome @StatusPavCT02 @Pedidos
Esquema do Cenario: Alterar autor da composição para que possua duplicidade de uma obra para pedido com Status PAV Autorizado
    #Dado que tenha um pedido com Status Pav Autorizado <Pedido>
    Quando faço uma busca pela obra associada ao pedido <Obra>
    E altero um dos autores da composição para que esteja com duplicidade <Autor>
	E seleciono o pedido a ser afetado pela alteracao <Pedido>
	#E faço uma busca pelo pedido afetado <Pedido>
    Então visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do compositor para duplicidade <Autor>, <Obra>, <StatusPav>
          
  Exemplos:
      | Pedido    | Obra           | Autor           | StatusPav  |
      | "1000109" | "OBRA TESTE 2" | "AUTOR TESTE 2" | "Aprovado" |
  
@chrome @StatusPavCT03 @Pedidos
Esquema do Cenario: Alterar autor para pedido com Status PAV Autorizado
    #Dado que tenha um pedido com Status Pav Autorizado <Pedido>
    Quando faço uma busca pela obra associada ao pedido <Obra>
    E altero os autores da obra <Autor1>, <NovoAutor1>
	E seleciono o pedido a ser afetado pela alteracao <Pedido>
	#E faço uma busca pelo pedido afetado <Pedido>
    Então visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do Autor da composição <Autor1>, <NovoAutor1>, <StatusPav>, <Obra>, <Pedido>
        
  Exemplos:
      | Pedido    | Obra                    | NovoAutor1    | Autor1         | StatusPav  |
      | "1000150" | "TESTE DE CONHECIMENTO" | "ALYNE WAITE" | "ROSANA SILVA" | "Aprovado" |
  
@chrome @StatusPavCT04 @Pedidos
Esquema do Cenario: Alterar porcentagem dos autores da composição de uma obra para pedido com Status PAV Autorizado
    #Dado que tenha um pedido com Status Pav Autorizado <Pedido>
    Quando faço uma busca pela obra associada ao pedido <Obra>
    E altero a porcentagem dos autores da composição <Autor1>, <Autor2>, <Porcentagem1>, <Porcentagem2>
	E seleciono o pedido a ser afetado pela alteracao <Pedido>
	#E faço uma busca pelo pedido afetado <Pedido>
    Então visualizo que o Status Pav do pedido continua como Aprovado apos a alteração da porcentagem dos Autores da composição <Autor1>, <Porcentagem1>, <Autor2>, <Porcentagem2>, <Obra>, <Pedido>, <StatusPav>
        
  Exemplos:
      | Pedido    | Obra                 | Autor1              | Autor2         | Porcentagem1 | Porcentagem2 | StatusPav  |
      | "1000457" | "CVC Vasco 2018 INT" | "MARCELLE MENDONCA" | "LUAN SANTANA" | "20"         | "55"         | "Aprovado" |
  
@chrome @StatusPavCT05 @Pedidos
Esquema do Cenario: Alterar DDAs de uma obra para pedido com Status PAV Autorizado
    #Dado que tenha um pedido com Status Pav Autorizado <Pedido>
    Quando faço uma busca pela obra associada ao pedido <Obra>
    E altero os DDAs dos autores da composição <Autor>, <NovoDDA>
	E seleciono o pedido a ser afetado pela alteracao <Pedido>
	#E faço uma busca pelo pedido afetado <Pedido>
    Então visualizo que o Status Pav do pedido continua como Aprovado apos a alteração do DDA do Autor da composição <Autor>, <DDA>, <Obra>, <Pedido>, <StatusPav>
        
  Exemplos:
      | Pedido    | Obra       | Autor            | DDA    | NovoDDA | StatusPav  |
      | "1000143" | "DOMITILA" | "RAFAEL LANGONI" | "DECK" | "NOWA"  | "Aprovado" |
  
@chrome @StatusPavCT06 @Pedidos
Esquema do Cenario: Alterar quantidade de autores de uma obra para pedido com Status PAV Autorizado
    #Dado que tenha um pedido com Status Pav Autorizado <Pedido>
    Quando faço uma busca pela obra associada ao pedido <Obra>
	E diminuo a porcentagem de um Autor <Autor1>, <Porcentagem1>
    E acrescento um novo Autor a composição com o percentual restante <Autor2>, <DDA>, <Porcentagem2>
	E seleciono o pedido a ser afetado pela alteracao <Pedido>
	#E faço uma busca pelo pedido afetado <Pedido>
    Então visualizo que o Status Pav do pedido continua como Aprovado apos a adição de mais um compositor na obra <Autor1>, <Autor2>, <PorcentagemOriginal>, <Obra>, <Pedido>, <StatusPav>
          
  Exemplos:
      | Pedido    | Obra                | Autor1         | Autor2              | DDA               | Porcentagem1 | Porcentagem2 | PorcentagemOriginal | StatusPav  |
      | "1000448" | "MUSICA DE TESTE 2" | "LUAN SANTANA" | "MARCELLE MENDONCA" | "WARNER CHAPPELL" | "30"         | "30"         | "60"                | "Aprovado" |
  