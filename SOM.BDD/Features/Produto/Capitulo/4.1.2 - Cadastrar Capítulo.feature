#language:pt
#Author: Rodrigo Magno
#Date: 30/01/2019

@kill_Driver @Capitulo @CadastroDeCapitulo
Funcionalidade: 4.1.2 - Cadastrar capítulos na criação do produto
Como um usuário com permissão de cadastrar capítulos
Eu quero poder cadastrar as informações de capítulo para um produto já cadastrado
Para que possa utilizar os dados no cadastro associada ao produto

Contexto: Acessar a tela de Cadastro de Capítulo
    Dado que esteja logado no sistema SOM

@chrome @CadastroDeCapituloCT01
Esquema do Cenário: Cadastrar capítulo
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de cadastro de capitulos
	Quando cadastro um novo capitulo para o produto existente <Produto>, <Capitulo>
	Então visualizo a mensagem de capitulo cadastrado com sucesso <Mensagem>
	  
  Exemplos:
      | Produto     | Capitulo | Mensagem                           |
      | "Aleatório" | "10"     | "Registro adicionado com sucesso." |
      | "Aleatório" | "99"     | "Registro adicionado com sucesso." |

  
@chrome @CadastroDeCapituloCT02
Esquema do Cenário: Cadastar capítulo em lote
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de cadastro de capitulos
	Quando cadastro capitulos em lote para o produto existente <Produto>, <Capitulo>, <GeracaoLote>, <QuantidadeCapitulos>
	Então visualizo a mensagem de capitulo cadastrado com sucesso <Mensagem>
	  
  Exemplos:
      | Produto     | Capitulo | GeracaoLote | QuantidadeCapitulos | Mensagem                           |
      | "Aleatório" | "10"     | "Sim"       | "2"                 | "Registro adicionado com sucesso." |
      | "Aleatório" | "10"     | "Sim"       | "20"                | "Registro adicionado com sucesso." |
      | "Aleatório" | "10"     | "Sim"       | "50"                | "Registro adicionado com sucesso." |
      | "Aleatório" | "10"     | "Sim"       | "100"               | "Registro adicionado com sucesso." |

  
@chrome @CadastroDeCapituloCT03
Esquema do Cenário: Cancelar cadastro de Capítulo
    Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de cadastro de capitulos
	Quando cancelo o cadastro de um novo capitulo para o produto existente <Produto>, <Capitulo>
	Então visualizo a tela de busca de capitulo com sucesso
	  
  Exemplos:
      | Produto     | Capitulo |
      | "Aleatório" | "10"     |
	  | "Aleatório" | "99"     |
  
@chrome @CadastroDeCapituloCT04
Cenário: Cadastrar capítulo sem preenchimento de campo obrigatório
	Dado que esteja na tela de cadastro de capitulos
	Quando tento cadastrar um capítulo sem preencher os campos obrigatórios
	Então visualizo os campos obrigatórios de cadastro de capítulo em destaque
