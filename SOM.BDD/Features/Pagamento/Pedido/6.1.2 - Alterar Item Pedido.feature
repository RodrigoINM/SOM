#language:pt
#Author: Rodrigo Magno
#Date: 12/12/2018
#Version: 1.0

@kill_Driver @AlterarItensDePedido @Pedidos
Funcionalidade: 6.1.2 - Alterar itens de pedido

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @AlterarItensDePedidoCT01 @Pedidos
Esquema do Cenario: Alterar valor a pagar para um item de pedido
    Dado que tenha um pedido previamente cadastrado no sistema
	E que esteja na aba de pagamento
	Quando altero o valor do pagamento, a moeda e a taxa de conversão de um item do pedido <ValorPagamento>, <Moeda>, <TaxaDeConversao>, <Autor>
	Então visualizo o novo valor a ser pago para o DDA do Autor na aba de pagamento <NovoValor>
      
  Exemplos:
      | ValorPagamento | Moeda   | TaxaDeConversao | NovoValor  | Autor     |
      | "300,00"       | "Dólar" | "3,8"           | "1.140,00" | "Rodrigo" |
  
@chrome @AlterarItensDePedidoCT02 @Pedidos
Esquema do Cenario: Validar item bloqueado para edição quando já estiver Aprovado
    Dado que tenha um pedido previamente cadastrado no sistema <Obra>
	E que possua um item com status de aguardando aprovacao <Status>, <Autor>
    Quando tento editar esse item <Autor>
    Entao visualizo os campos de <ValorPagamento>, <Moeda> e <TaxaDeConversao> bloqueados para edicao
	   
  Exemplos:
      | ValorPagamento | Moeda   | TaxaDeConversao | Status                 | Autor         | Obra             |
      | "300,00"       | "Dólar" | "3,8"           | "Aguardando Aprovação" | "ALYNE WAITE" | "TESTE DE 500MB" |
  
@chrome @AlterarItensDePedidoCT03 @Pedidos
Esquema do Cenario: Registrar Autorização
    Dado que tenha um pedido previamente cadastrado no sistema
    Quando regsitro a autorizacao para um item do pedido <Autor>
    Entao visualizo o pop up de confirmação para o DDA selecionado <Autor>
    E a mensagem de sucesso apos confirmar a autorizacao do item do pedido <Mensagem>
    E visualizo o status de autorizado para o item selecionado <Status>
      
  Exemplos:
      | Mensagem                                | Status       | Autor         |
      | "1 item(ns) registrado(s) com sucesso." | "Autorizado" | "ALYNE WAITE" |
  
@chrome @AlterarItensDePedidoCT04 @Pedidos
Esquema do Cenário: Validar o pagamento para o Administrador com sucesso
    Dado que tenha um pedido previamente cadastrado no sistema <Obra>
    Quando faço o pagamento ao Administrador <Autor>
    Então visualizo a mensagem de sucesso após confirmar o pagamento ao administrador <Mensagem>
    E visualizo o campo de pagar ao administrador preenchido <Autor>, <PagarAdministrador>
	  
  Exemplos:
      | PagarAdministrador | Mensagem                                   | Autor         | Obra             | 
      | "Sim"              | "Itens do pedido atualizados com sucesso!" | "ALYNE WAITE" | "TESTE DE 500MB" | 

@chrome @AlterarItensDePedidoCT05 @Pedidos
Esquema do Cenário: Alterar o valor do DNI com sucesso
	Dado que tenha um pedido previamente cadastrado no sistema <Obra>
	Quando adiciono um item de DNI no pedido
	E insiro um valor para o campo de pagamento do DNI <Midia>, <ValorPagamento>
	Então o valor do item de DNI atualizado <Mensagem>, <Midia>, <ValorPagamento>
	  
  Exemplos:
      | ValorPagamento | Mensagem                               | Midia | Obra             |
      | "300,00"       | "Item de pedido alterado com sucesso." | "DNI" | "TESTE DE 500MB" |

@chrome @AlterarItensDePedidoCT06 @Pedidos
Esquema do Cenário: Cancelar um item de pedido no detelhe do pedido
	Dado que tenha um pedido previamente cadastrado no sistema
	Quando cancelo um item de pedido para um autor <Mensagem>, <StatusDeAprovacao>, <Autor>
    Então visualizo o item do pedido com o status de cancelado <StatusFinal>, <Autor>
       
  Exemplos:
      | StatusDeAprovacao        | StatusFinal | Mensagem                       | Autor    |
      | "Pendente"               | "Cancelado" | "Total de itens cancelados: 1" | "Autor"  |
      | "Aguardando Autorização" | "Cancelado" | "Total de itens cancelados: 1" | "Autor2" |
	
@chrome @AlterarItensDePedidoCT07 @Pedidos
Esquema do Cenário: Cancelar um item de pedido na busca por pedido
	Dado que tenha um pedido previamente cadastrado no sistema
	Quando cancelo um item de pedido para um autor na busca de pedido <Mensagem>, <StatusDeAprovacao>, <Autor>
    Então visualizo o item do pedido com o status de cancelado na busca de pedido <StatusFinal>, <Autor>
       
  Exemplos:
      | StatusDeAprovacao        | StatusFinal | Mensagem                       | Autor    |
      | "Pendente"               | "Cancelado" | "Total de itens cancelados: 1" | "Autor"  |
      | "Aguardando Autorização" | "Cancelado" | "Total de itens cancelados: 1" | "Autor2" |
  
@chrome @AlterarItensDePedidoCT08 @Pedidos    
Esquema do Cenário: Remover registro de Pagamento Ao Administrador com sucesso
	Dado que tenha um pedido previamente cadastrado no sistema <Obra>
	Quando removo o registro de pagamento ao administrador <Autor>, <Mensagem>
	Então visualizo a mensagem de alteração realizada com sucesso ao remover o registro de pagamento ao administrador <Mensagem>

  Exemplos:
      | Mensagem                                   | Autor         | Obra             |
      | "Itens do pedido atualizados com sucesso!" | "ALYNE WAITE" | "TESTE DE 500MB" |
	
#@Obra
##É bom que todos os cenários que envolvem alteração de pedido sejam testados status diferentes de pagamento (A Pagar, Aguardando Aprovação, Aprovado e Cancelado).
@chrome @AlterarItensDePedidoCT09 @Obra
Esquema do Cenário: Alterar nacionalidade para obras com pedido pendente
	Dado que tenha um pedido previamente cadastrado no sistema para uma obra nacional <Tipo>, <TitutloAlternativo>, <Iswc>, <Ano>, <ObraOriginal>, <Nacionalidade>, <Pais>, <DominioPublico>, <Institucional>, <BlackList>, <Emblematica>
	Quando altero a nacionalidade da obra para internacional <NovaNacionalidade>, <NovoPais>
	E seleciono o pedido a ser afetado pela alteracao
	Entao visualizo que os itens do pedido foram cancelados
    E visualizo que foram criados outros itens com o valor referente a tabela de preco internacional
	
  Exemplos:
      | Tipo               | TitutloAlternativo | Iswc | Ano    | ObraOriginal | Nacionalidade | Pais | DominioPublico | Institucional | BlackList | Emblematica | NovaNacionalidade | NovoPais   | Autor   |
      | "MUSICA COMERCIAL" | " "                | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Internacional"   | "Alemanha" | "Autor" |
	
@chrome @AlterarItensDePedidoCT10 @Obra
Esquema do Cenário: Alterar obra para Dominio Publico com pedido pendente
	Dado que tenha um pedido previamente cadastrado no sistema para uma obra nacional <Tipo>, <TitutloAlternativo>, <Iswc>, <Ano>, <ObraOriginal>, <Nacionalidade>, <Pais>, <DominioPublico>, <Institucional>, <BlackList>, <Emblematica>
	Quando altero a obra para dominio publico
	E seleciono o pedido a ser afetado pela alteracao
	Entao visualizo que os itens do pedido foram cancelados <Autor1>, <Autor2>
	
  Exemplos:
      | Tipo               | TitutloAlternativo | Iswc | Ano    | ObraOriginal | Nacionalidade | Pais | DominioPublico | Institucional | BlackList | Emblematica | Autor1  | Autor2   |
      | "MUSICA COMERCIAL" | " "                | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Autor" | "Autor2" |
	
@chrome @AlterarItensDePedidoCT11 @Obra
Esquema do Cenário: Alterar obra para Blacklist com pedido pendente
    Dado que tenha um pedido previamente cadastrado no sistema para uma obra nacional <Tipo>, <TitutloAlternativo>, <Iswc>, <Ano>, <ObraOriginal>, <Nacionalidade>, <Pais>, <DominioPublico>, <Institucional>, <BlackList>, <Emblematica>
	Quando altero a obra para blacklist
	Entao visualizo que os itens do pedido não foram afetados pela alteração <Autor1>, <Autor2>
	
  Exemplos:
      | Tipo               | TitutloAlternativo | Iswc | Ano    | ObraOriginal | Nacionalidade | Pais | DominioPublico | Institucional | BlackList | Emblematica | Autor1  | Autor2   |
      | "MUSICA COMERCIAL" | " "                | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Autor" | "Autor2" |

@chrome @AlterarItensDePedidoCT12 @Obra	
Esquema do Cenario: Alterar porcentagem dos autores da composição de uma obra com pedido pendente
    Dado que tenha um pedido previamente cadastrado no sistema para uma obra nacional <Tipo>, <TitutloAlternativo>, <Iswc>, <Ano>, <ObraOriginal>, <Nacionalidade>, <Pais>, <DominioPublico>, <Institucional>, <BlackList>, <Emblematica>
	Quando faço uma busca pela obra associada ao pedido <Obra>
	E altero a porcentagem dos autores da composição <Autor1>, <Autor2>, <Porcentagem1>, <Porcentagem2>
	E seleciono o pedido a ser afetado pela alteração através do produto associado <Produto>
	E faço uma busca pelo pedido através do nome da obra associada <Obra>
	Entao visualizo que os itens anteriores foram cancelados na tela de pagamento <Autor1>, <Autor2>, <StatusItem>
	E visualizo que existem novos itens a pagar com valores diferentes <Autor1>, <Autor2>, <StatusFinalItem>
    
  Exemplos:
      | Tipo               | TitutloAlternativo | Iswc | Ano    | ObraOriginal | Nacionalidade | Pais | DominioPublico | Institucional | BlackList | Emblematica | Autor1  | Autor2   | StatusItem  | StatusFinalItem | Obra   | Produto   | Porcentagem1 | Porcentagem2 |
      | "MUSICA COMERCIAL" | " "                | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Autor" | "Autor2" | "Cancelado" | "A Pagar"       | "Obra" | "Produto" | "30"         | "70"         |

@chrome @AlterarItensDePedidoCT13 @Obra
Esquema do Cenario: Alterar os Autores da composição de uma obra com pedido pendente
	Dado que tenha um pedido previamente cadastrado no sistema para uma obra nacional <Tipo>, <TitutloAlternativo>, <Iswc>, <Ano>, <ObraOriginal>, <Nacionalidade>, <Pais>, <DominioPublico>, <Institucional>, <BlackList>, <Emblematica>
	Quando faço uma busca pela obra associada ao pedido <Obra>
	E altero todos os autores da composicao <Autor1>, <Autor2>
	E seleciono o pedido a ser afetado pela alteração através do produto associado <Produto>
	E faço uma busca pelo pedido através do nome da obra associada <Obra>
	Entao visualizo que os itens anteriores foram cancelados na tela de pagamento e gerados novos itens para os novos compositores <Autor1>, <Autor2>, <StatusNovoItem>
    
  Exemplos:
      | Tipo               | TitutloAlternativo | Iswc | Ano    | ObraOriginal | Nacionalidade | Pais | DominioPublico | Institucional | BlackList | Emblematica | Autor1  | Autor2   | StatusNovoItem | Obra   | Produto   |
      | "MUSICA COMERCIAL" | " "                | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Autor" | "Autor2" | "A Pagar"      | "Obra" | "Produto" |

@chrome @AlterarItensDePedidoCT14 @Obra
Esquema do Cenario: Excluir Obra tendo pedido pendente
	Dado que tenha um pedido previamente cadastrado no sistema para uma obra nacional <Tipo>, <TitutloAlternativo>, <Iswc>, <Ano>, <ObraOriginal>, <Nacionalidade>, <Pais>, <DominioPublico>, <Institucional>, <BlackList>, <Emblematica>
	Quando faço uma busca pela obra associada ao pedido <Obra>
	E excluo a obra associada a esse pedido <Obra>
	#E seleciono o pedido a ser afetado pela alteração através do produto associado <Produto>
	E faço uma busca pelo pedido através do nome da obra associada <Obra>
	Entao visualizo que o pedido e seus itens estão cancelados na tela de busca por pedido <Autor1>, <Autor2>, <StatusItem>
    
  Exemplos:
      | Tipo               | TitutloAlternativo | Iswc | Ano    | ObraOriginal | Nacionalidade | Pais | DominioPublico | Institucional | BlackList | Emblematica | Autor1  | Autor2   | StatusItem  | Obra   | Produto   |
      | "MUSICA COMERCIAL" | " "                | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Autor" | "Autor2" | "Cancelado" | "Obra" | "Produto" |

#@Cue-sheet
#  Cenario: Validar alteração em pedido pendente para alteração de Reprise para cue-sheet
#      Dado que tenha um pedido pendente de autorizacao dentro de uma cue-sheet
#      Quando altero a cue-sheet para "Reprise"
#      Entao visualizo os novos valores a serem pagos dos itens do pedido
#
#@DePara
#  Esquema do Cenario: Alterar pedido pendente ao fazer transferencia de uma obra para outra
#      Dado que tenha um pedido pendente de autorizacao
#      E que esteja na tela de transferencia de obra
#      Quando faco uma transferencia da <Obra> desse pedido para uma outra <NovaObra>
#      Entao visualizo a <Mensagem> de que os pedidos em aberto dessa obra serão cancelados e serão criados novos pedidos
#      E visualizo que os itens <DDA> e <Autor>, pendentes do pedido selecionado foram cancelados
#      E visualizo que foram adicionados os itens <NovoDDA> e <NovoAutor> referentes a <NovaObra> nos detalhes do pedido
#        
#    Exemplos:
#        | Obra                 | NovaObra             | DDA         | Autor          | NovoDDA | NovoAutor | Mensagem                                                                                                                                                                                         | 
#        | "MUSICA DE TESTE 13" | "MUSICA DE TESTE 14" | "SOM LIVRE" | "LUAN SANTANA" | "DECK"  | "TESTE"   | "Todos os fonogramas e itens de cue-sheet da BANG BANG serão transferidos para a Obra MUSICA DE TESTE 1. Os pedidos em aberto serão cancelados e serão criados novos pedidos. Deseja continuar?" | 
#    
#  Esquema do Cenario: Alterar pedido ao fazer transferencia de DDAs
#      Dado que tenha um pedido pendente de autorizacao
#      E que esteja na tela de transferencia de DDAs
#      Quando faco uma transferencia do <DDA> da obra desse pedido para outro <NovoDDA>
#      Entao visualizo que o o <DDA> do pedido foi alterado para o <NovoDDA>
#
#    Exemplos:
#        |  DDA         |  NovoDDA |
#        |  "SOM LIVRE" |  "DECK"  |
#
#  #Cenário: De/Para de autor
#  #Cenário: Alterar duplicidade com item de pedido "a pagar"
#  #Cenário: Alterar duplicidade com item de pedido "a pagar" e "aguardando aprovação"
#
#  Esquema do Cenario: Alterar Autor para contratado com pedido pendente
#      Dado que tenha um pedido pendente de autorizacao
#      E que esteja na tela de alteracao de <Autor>
#      Quando altero o <Autor> para contratado
#      Entao visualizo que o item do pedido pendente foi cancelado para esse <Autor>
#
#    Exemplos:
#        | Autor       |
#        | "Teste INM" |
#    #Hoje a alteração do autor não está impactando o pedido, mas o cenário existe pois no entendimento do cliente deveria, mas apenas quando todos os autores da Obra forem falecidos a mais de 70 anos. Nesse caso o comportamento seria colocar a Obra em "Domínio Público" e realizar o cancelamento do pedido e dos itens A Pagar.
#
#  Esquema do Cenario: Alterar Autor para falecido a mais de 70 anos
#      Dado que tenha um pedido pendente de autorizacao
#      E que esteja na tela de alteracao de <Autor>
#      Quando altero o <Autor> para falecido a mais de 70 anos
#      Entao visualizo que o item do pedido pendente foi cancelado para esse <Autor>
#      
#    Exemplos:
#        | Autor       |
#        | "Teste INM" |
#