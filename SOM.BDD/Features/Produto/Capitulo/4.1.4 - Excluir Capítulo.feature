#language:pt
#Author: Rodrigo Magno
#Date: 30/01/2019

@kill_Driver @Capitulo @ExclusaoDeCapitulo
Funcionalidade: 4.1.4 - Excluir capítulos
Como um usuário com permissão para excluir capítulo
Eu quero poder excluir capítulo
Para que o mesmo não seja apresentado no sistema

Contexto: Excluir capítulo
    Dado que esteja logado no sistema SOM

@chrome @ExclusaoDeCapituloCT01
Esquema do Cenário: Excluir capítulo
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de consulta de capitulos
	Quando faço uma busca de capítulo por nome do Produto <NomeProduto>
	E excluo o capitulo do produto cadastrado <NomeProduto>
	Então visualizo a mensagem de capítulo excluido com sucesso <Mensagem>

  Exemplos: 
      | NomeProduto | Mensagem                         |
      | "Aleatório" | "Registro excluído com sucesso." |

@chrome @ExclusaoDeCapituloCT02
Esquema do Cenário: Cancelar Exclusão de capítulo
	Dado que tenha um produto cadastrado no sistema
	E que esteja na tela de consulta de capitulos
	Quando faço uma busca de capítulo por nome do Produto <NomeProduto>
	E cancelo a exclusão do capitulo do produto cadastrado <NomeProduto>
	Então visualizo os dados do produto e capítulo cadastrados no sistema no resultado da busca <NomeProduto>, <Episodio>, <Capitulo>
	
  Exemplos: 
      | NomeProduto | Episodio    | Capitulo |
      | "Aleatório" | "Aleatório" | "01"     |