#language:pt
#Author: Rodrigo Magno
#Date: 30/01/2019

@kill_Driver @Capitulo @ConsultaDeCapitulo
Funcionalidade: 4.1.1 - Consulta de capítulos
Como um usuário com permissão de consultar
Eu quero poder consultar as informações de capítulo para um produto já cadastrado
Para que possa conferir os dados no cadastro associada ao produto

Contexto: Consulta dos capítulos
    Dado que esteja logado no sistema SOM

@chrome @ConsultaDeCapituloCT01
Esquema do Cenario: Busca pelo Nome do Produto
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de consulta de capitulos
    Quando faço uma busca de capítulo por nome do Produto <NomeProduto>
	Então visualizo os dados do produto e capítulo cadastrados no sistema no resultado da busca <NomeProduto>, <Episodio>, <Capitulo>
 
  Exemplos: 
      | NomeProduto | Episodio    | Capitulo |
      | "Aleatório" | "Aleatório" | "01"     |

@chrome @ConsultaDeCapituloCT02
Esquema do Cenario: Busca pelo Episódio
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de consulta de capitulos
    Quando faço uma busca de capítulo por episodio <Episodio>
	Então visualizo os dados do produto e capítulo cadastrados no sistema no resultado da busca <NomeProduto>, <Episodio>, <Capitulo>
 
  Exemplos: 
      | NomeProduto | Episodio    | Capitulo |
      | "Aleatório" | "Aleatório" | "01"     |

@chrome @ConsultaDeCapituloCT03
Esquema do Cenario: Busca pelo Capítulo Início e Fim
	Dado que esteja na tela de consulta de capitulos
    Quando faço uma busca de capítulo por capitulo inicial e final <CapituloInicio>, <CapituloFim>
	Então visualizo uma mensagem de critica pedindo para informar ao menos um produto ou episodio <Mensagem>
 
  Exemplos: 
      | CapituloInicio | CapituloFim | Mensagem                                   |
      | "01"           | "22"        | "Informe ao menos um produto ou episódio." |

@chrome @ConsultaDeCapituloCT04
Esquema do Cenario: Busca sem preenchimento de nenhum dos campos
	Dado que esteja na tela de consulta de capitulos
	Quando faço um busca por capitulo sem preencher nenhum campo da consulta
	Então visualizo uma mensagem de critica pedindo para informar ao menos um produto ou episodio <Mensagem>
 
  Exemplos: 
      | Mensagem                                   |
      | "Informe ao menos um produto ou episódio." |

@chrome @ConsultaDeCapituloCT05
Esquema do Cenario: Busca por produtos não cadastrados
	Dado que esteja na tela de consulta de capitulos
	Quando faço um busca por capitulo informando um produto que não foi cadastrado no sistema <NomeProduto>
	Então visualizo uma mensagem que não existe dados cadastrados no resultado da busca por capítulo <Mensagem>
	  
  Exemplos:
      | NomeProduto           | Mensagem                |
      | "Produto Inexistente" | "Dados não encontratos" |
  
@chrome @ConsultaDeCapituloCT06
Esquema do Cenario: Busca por Produto e Episódios não associados
	Dado que esteja na tela de consulta de capitulos
	Quando faço um busca por capitulo informando um produto e um episodio que não são associados <NomeProduto>, <Episodio>
	Então visualizo uma mensagem que não existe dados cadastrados no resultado da busca por capítulo <Mensagem>
	  
  Exemplos:
      | NomeProduto | Episodio       | Mensagem                | 
      | "Teste INM" | "Episodio 120" | "Dados não encontratos" | 
  