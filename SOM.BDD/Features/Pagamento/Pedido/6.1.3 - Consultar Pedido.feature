#language:pt
#Author: Rodrigo Magno
#Date: 22/01/2018

@kill_Driver @ConsultarPedido @Pedidos
Funcionalidade: 6.1.3 - Consultar Pedido

Contexto: 
	Dado que esteja logado no sistema SOM
	E que esteja na tela de consulta de pedidos

@chrome @ConsultarPedidoCT01
Esquema do Cenario: Busca simples por numero
    Quando faco um busca simples por numero de pedido <Numero>
	Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
    
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @ConsultarPedidoCT02
Esquema do Cenario: Busca por Obra
    Quando faço uma busca avançada de pedido por obra <Obra>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @ConsultarPedidoCT03
Esquema do Cenario: Busca por Número
	Quando faço uma busca avançada de pedido por número <Numero>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @ConsultarPedidoCT04
Esquema do Cenario: Busca por Produto
    Quando faço uma busca avançada de pedido por produto <Produto>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @ConsultarPedidoCT05
Esquema do Cenario: Busca Periodo de Exibição
    Quando faço uma busca avançada de pedido por periodo de exibição <Produto>, <DataInicial>, <DataFinal>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise | DataInicial  | DataFinal    |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   | "10/10/2018" | "10/10/2018" |
  
@chrome @ConsultarPedidoCT06
Esquema do Cenario: Busca por Data início
    Quando faço uma busca avançada de pedido por data inicial <Produto>, <DataInicial>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise | DataInicial  | DataFinal    |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   | "10/10/2018" | "10/10/2018" |
  
@chrome @ConsultarPedidoCT07
Esquema do Cenario: Busca por autor
    Quando faço uma busca avançada de pedido por autor <Autor>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise | Autor             |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   | "Hiram1326096162" |
  
@chrome @ConsultarPedidoCT08
Esquema do Cenario: Busca por DDA
    Quando faço uma busca avançada de pedido por DDA <DDA>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise | DDA                   |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   | "Hildegard1167235435" |
  
@chrome @ConsultarPedidoCT09
Esquema do Cenario: Busca por Mídia a Debitar
    Quando faço uma busca avançada de pedido por Midia a Debitar <Numero>, <MidiaADebitar>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @ConsultarPedidoCT10
Esquema do Cenario: Busca por Sincronismo Globo
    Quando faço uma busca avançada de pedido por Sincronismo <Numero>, <Sincronismo>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @ConsultarPedidoCT11
Esquema do Cenario: Busca por Status
    Quando faço uma busca avançada de pedido por status e numero <Numero>, <Status>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
 
@chrome @ConsultarPedidoCT12
Esquema do Cenario: Busca por Mídia Autorizada
    Quando faço uma busca avançada de pedido por Midia Autorizada <Numero>, <MidiaAutorizada>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
  
  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise | MidiaAutorizada |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   | "GLOBONEWS"     |
  
@chrome @ConsultarPedidoCT13
Esquema do Cenario: Busca por Valor Negociado
	Quando faço uma busca avançada de pedido por Valor Negociado e Número <Numero>, <ValorNegociado>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
    
  Exemplos:
      | ValorNegociado | Numero    | Produto           | Episodio | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal  | Status         | StatusPav       | Reprise |
      #| "Sim"          | "1000554" | "JORNAL NACIONAL" | ""       | "999"    | "BANG BANG"         | "TV"          | "FUNDO"     | "R$ 50,00"  | "Em andamento" | "Não requerido" | "Sim"   |
      | "Não"          | "1000565" | "JORNAL NACIONAL" | ""       | "999"    | "MUSICA DE TESTE 1" | "TV"          | "ABERTURA"  | "R$ 800,00" | "Em andamento" | "Não requerido" | "Não"   |
  
#Esquema do Cenario: Visualização de Relatório de Pedido
#    Quando informo e seleciono o <Numero> do pedido
#    E faco download do relatorio de pagamento do resultado da busca
#    Entao visualizo o relatorio de status sobre autorizacoes de uso de musicas do pedido pesquisado
#   
#  Exemplos:
#      | Numero    |
#      | "1000565" |

@chrome @ConsultarPedidoCT14
Esquema do Cenario: Visualização de Histórico
	Quando faço uma busca avançada de pedido por número <Numero>
    Entao visualizo os dados do pedido no resultado da busca <Numero>, <Produto>, <Episodio>, <Capitulo>, <Obra>, <MidiaADebitar>, <Sincronismo>, <ValorTotal>, <Status>, <StatusPav>, <Reprise>
	E visualizo as alterações feitas nos pedido ao acessar o historico

  Exemplos:
      | Numero    | Produto                          | Episodio            | Capitulo | Obra                | MidiaADebitar | Sincronismo | ValorTotal | Status         | StatusPav       | Reprise |
      | "1001404" | "Avis1816412639 Ozane1633164760" | "Paulette436942029" | "01"     | "Jonelle1677499510" | "GLOBONEWS"   | "ABERTURA"  | "R$ 67,50" | "Em andamento" | "Não requerido" | "Não"   |
  

@chrome @ConsultarPedidoCT15
Esquema do Cenario: Melhorias na busca de pedido - campo produto
    Quando faço uma busca avançada de pedido por produto <Produto>
	Entao visualizo todos os pedidos que estejam vinculado ao produto buscado <Produto>
  
  Exemplos:
      | Produto                          |
      | "JORNAL NACIONAL"                |
      | "Avis1816412639 Ozane1633164760" |

@chrome @ConsultarPedidoCT16
Esquema do Cenario: Melhorias na busca de pedido - campo obra
    Quando faço uma busca avançada de pedido por obra <Obra>
	Entao visualizo todos os pedidos que estejam vinculado a obra buscada <Obra>
  
  Exemplos:
      | Obra                |
      | "MUSICA DE TESTE 1" |
      | "Jonelle1677499510" |
  
#Cenario: Melhorias na busca de pedido - Ordenação
#    Dado a tela de busca de pedido esteja aberta e faço uma busca simples
#    Quando clico nas colunas da grid
#    E visualizo a ordenação decrescente por padrão

@chrome @ConsultarPedidoCT17
Esquema do Cenario: Melhorias na busca de pedido - Status
    Quando faço uma busca avançada de pedido por status e numero <Numero>, <Status>
    Entao visualizo todos os pedidos que estejam com status buscado <Status>
  
  Exemplos:
      | Status         | Numero    |
      | "Em andamento" | "1001451" |
      | "Cancelado"    | "1001450" |
      | "Concluído"    | "1000106" |
  
 @chrome @ConsultarPedidoCT18
Esquema do Cenario: Melhorias na busca de pedido - Status Pav
    Quando faço uma busca avançada de pedido por status pav e numero <Numero>, <StatusPav>
    Entao visualizo todos os pedidos que estejam com status pav buscado <StatusPav>
	
  Exemplos:
      | Numero    | StatusPav  |
      | "1000109" | "Aprovado" |
  
 @chrome @ConsultarPedidoCT19
Esquema do Cenario: Informação não localizada
	Quando faço uma busca avançada de pedido por um número que não existe no sistema <Numero>
	Entao visualizo a mensagem de que não foram encontrados pedidos com os dados informados na busca <Mensagem>
    
  Exemplos:
      | Numero    | Mensagem                |
      | "1099999" | "Dados não encontratos" |
  