#language:pt
#Author: Rodrigo Magno
#Date: 08/02/2019

@kill_Driver @CadastroDeObraNaCueSheet
Funcionalidade: 5.2.18 - Cadastro de novas obras

Contexto: Cadastro de novas obras de transição
    Dado que esteja logado no sistema SOM

@chrome @CadastroDeObraNaCueSheetCT01
Esquema do Cenário: Cadastrar nova Música na cue-sheet com sucesso
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cadastro um item de Cue-Sheet com Musica de transição <Titulo>
	Então visualizo a Musica de Transição cadastrada com sucesso <Titulo>
	  
  Exemplos:
      | Titulo      |
      | "Aleatório" |

@chrome @CadastroDeObraNaCueSheetCT02
Esquema do Cenário: Cadastrar nova Música na cue-sheet com informações duplicadas
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando cadastro um item de Cue-Sheet com Musica de transição <Titulo>
	E cadastro um item de Cue-Sheet com Musica de transição repetida <Titulo>
	Então visualizo um mensagem de alerta
	  
  Exemplos:
      | Titulo      |
      | "Aleatório" |
