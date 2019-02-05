#language:pt
#Author: Rodrigo Magno
#Date: 30/11/2018
#Version: 1.0

@kill_Driver @CriarPedidoManual @Pedidos
Funcionalidade: 6.1.7 - Criar Pedido Manualmente

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @CriarPedidoManualCT01
Esquema do Cenario: Gerar pedido manual para todos os tipos de sincronismo
	Dado que tenha um produto e uma obra cadastrada no sistema
	E que estou na tela de criação de pedidos
	Quando crio um novo pedido manualmente <DataExibicao>, <Tempo>, <MidiaADebitar> <Sincronismo>
	Entao visualizo o pedido gerado com sucesso <MidiaADebitar>, <Sincronismo>, <Status>, <StatusPav>, <Reprise>
       
  Exemplos:
      | Sincronismo                   | DataExibicao | Interprete | Tempo | MidiaADebitar | Status         | StatusPav       | Reprise |
      | "ABERTURA"                    | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "ABERTURA PONTUAL"            | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "ADORNO"                      | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "AO VIVO ADORNO"              | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "AO VIVO FUNDO"               | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "AO VIVO FUNDO EM JORNALISMO" | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "AO VIVO PERFORMANCE"         | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "ENCERRAMENTO"                | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
      | "ENCERRAMENTO PONTUAL"        | "10/10/2018" | "ANITTA"   | "10"  | "GLOBONEWS"   | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @CriarPedidoManualCT02
Esquema do Cenario: Gerar pedido manual para todos os tipos de midia a debitar
    Dado que tenha um produto e uma obra cadastrada no sistema
	E que estou na tela de criação de pedidos
	Quando crio um novo pedido manualmente <DataExibicao>, <Tempo>, <MidiaADebitar> <Sincronismo>
	Entao visualizo o pedido gerado com sucesso <MidiaADebitar>, <Sincronismo>, <Status>, <StatusPav>, <Reprise>
          
  Exemplos:
      | MidiaADebitar         | Sincronismo                   | DataExibicao | Interprete | Tempo | Status         | StatusPav       | Reprise |
      | "GLOBONEWS"           | "ABERTURA"                    | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "CANAL VIVA"          | "ABERTURA PONTUAL"            | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "DNI"                 | "ADORNO"                      | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "TV"                  | "AO VIVO ADORNO"              | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "GLOBOPLAY"           | "AO VIVO FUNDO"               | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "GLOOB"               | "AO VIVO FUNDO EM JORNALISMO" | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "INTERNET"            | "AO VIVO PERFORMANCE"         | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "MULTISHOW"           | "ENCERRAMENTO"                | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "SPORTV"              | "ENCERRAMENTO PONTUAL"        | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
      | "CANAL INTERNACIONAL" | "ENCERRAMENTO PONTUAL"        | "10/10/2018" | "ANITTA"   | "10"  | "Em andamento" | "Não requerido" | "Não"   |
  
@chrome @CriarPedidoManualCT03
Esquema do Cenario: Criar Pedido sem Tabela Vigente
	Dado que tenha um produto e uma obra cadastrada no sistema
	E que estou na tela de criação de pedidos
	Quando crio um novo pedido manualmente <DataExibicao>, <Tempo>, <MidiaADebitar> <Sincronismo>
	Entao eu visualizo a mensagem de critica informando que o pedido não pode ser criado para essa data <Mensagem>
		        
  Exemplos:
      | MidiaADebitar         | Sincronismo | DataExibicao | Tempo | Mensagem                                                                         |
      | "CANAL INTERNACIONAL" | "ABERTURA"  | "10/10/2030" | "10"  | "O pedido não pode ser gerado pois não foi encontrada tabela padrão no sistema." |

@chrome @CriarPedidoManualCT04
Esquema do Cenario: Todos os itens com autores contratados
	Dado que tenha um produto e uma obra cadastrada no sistema com autores contratados
	E que estou na tela de criação de pedidos
	Quando crio um novo pedido manualmente para uma obra com autores contratados
	Entao eu visualizo a mensagem de critica informando que o pedido não pode ser criado para essa obra <Mensagem>
	
  Exemplos:
      | Mensagem                                                                                                         |
      | "Não foi possível gerar o pedido, pois todos os autores da obra são contratados ou falecidos a mais de 70 anos." |

@chrome @CriarPedidoManualCT05
Esquema do Cenario: Obra de domínio público
	Dado que tenha um produto e uma obra de dominio publico cadastrada no sistema
	E que estou na tela de criação de pedidos
	Quando crio um novo pedido manualmente para uma obra de dominio publico
	Entao eu visualizo a mensagem de critica informando que o pedido não pode ser criado para essa obra <Mensagem>

  Exemplos:
      | Mensagem                                                           |
      | "Não é possível gerar pedido pois esta obra é de Domínio Público." |

@chrome @CriarPedidoManualCT06
Cenario: Cadastro de Intérprete
	Dado que estou na tela de criação de pedidos
	Quando cadastro um novo interprete
    Então visualizo a mensagem de Intérprete cadastrado com sucesso
