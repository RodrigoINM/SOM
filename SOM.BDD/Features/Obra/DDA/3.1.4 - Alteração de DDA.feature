#language: pt-BR
#Author: Larissa Silva
#Date: 27/01/2019
#Version: 1.0

@chrome @kill_Driver @DDA @AlteracaoDeDDA
Funcionalidade: 3.1.4 - Alterações de DDA

Contexto: Acessar a tela de Edição de DDA
    Dado que esteja logado no sistema SOM
    E que estou com a tela Novo Cadastro de DDA

@chrome @AlteracaoDeDDACT01
Cenário: Alteração de Nome Fantasia com sucesso
	Dado que tenho um DDA cadastrado
    Quando altero e salvo o campo Nome Fantasia
    Então visualizo o DDA alterado

@chrome @AlteracaoDeDDACT02
Esquema do Cenário: Alteração de Razão Social do DDA
	Dado que tenho um DDA cadastrado
    Quando altero e salvo o campo Razão Social <RazaoSocial>
    Então visualizo o DDA alterado

	Exemplos:
	| RazaoSocial |
	| "Teste INM" |

@chrome @AlteracaoDeDDACT03
Cenário: Alterar DDA que não esteja sendo utilizado em obras
    Dado que tenho um DDA cadastrado
    Quando altero e salvo o DDA sem obras
    Então visualizo o DDA alterado

@chrome @AlteracaoDeDDACT04
Cenário: Alterar DDA associado a uma obra sem fonograma
    Dado que tenho um DDA cadastrado
    Quando altero e salvo o DDA sem fonograma
    Então visualizo o DDA alterado

@chrome @AlteracaoDeDDACT05
Cenário: Validar alteração de DDA na pesquisa
      Dado que tenho um DDA cadastrado
	  Quando altero os campos obrigatorios de DDA e salvo
	  Então visualizo o DDA alterado

@chrome @AlteracaoDeDDACT06
Esquema do Cenário: Cancelar alteração
	Dado que tenho um DDA cadastrado
    Quando altero a Razão Social, e realizo o cancelamento da edição <RazaoSocial>
    Então visualizo a confirmação de cancelamento de edição do DDA

    Exemplos:
          | RazaoSocial |
          | "Teste 012" |

@chrome @AlteracaoDeDDACT07
Esquema do Cenário: Alteração da Associação do DDA para Sem associação
      Dado que tenho um DDA cadastrado
      Quando altero e salvo o campo associação do DDA <Associacao>
      Então visualizo o DDA alterado

      Exemplos:
          | Associacao       |
          | "SEM ASSOCIAÇÃO" | 
