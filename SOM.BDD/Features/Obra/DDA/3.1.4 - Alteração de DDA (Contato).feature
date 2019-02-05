#language: pt-BR
#Author: Larissa Silva
#Date: 27/01/2019
#Version: 1.0

@chrome @kill_Driver @DDA @AlteracaoDeContatoDDA
Funcionalidade: 3.1.4 - Alterações de DDA - Contato

Contexto: Acessar a tela de Edição de DDA
    Dado que esteja logado no sistema SOM
    E que estou com a tela Novo Cadastro de DDA

@chrome @AlteracaoContatoDeDDACT01
Esquema do Cenário: Alteração Telefone de contato com sucesso
      Dado que tenho um DDA cadastrado
	  E altero o telefone <Telefone>
      Então visualizo a mensagem do DDA alterado com sucesso <Mensagem>

      Exemplos:
          | Telefone     | Mensagem                        |
          | "2227017569" | "Registro editado com sucesso." |

@chrome @AlteracaoContatoDeDDACT02
Esquema do Cenário: Alteração do email de autorizacao de contato com sucesso
      Dado que tenho um DDA cadastrado
	  E altero o email <Email>
	  Então visualizo a mensagem do DDA alterado com sucesso <Mensagem>

      Exemplos:
          | Email             | Mensagem                        |
          | "teste@teste.com" | "Registro editado com sucesso." |

@chrome @AlteracaoContatoDeDDACT03
Esquema do Cenário: Alteracao da flag de Autorizacao de E-mail
      Dado que tenho um DDA cadastrado
      E altero o a flag
      Então visualizo a mensagem do DDA alterado com sucesso <Mensagem>

      Exemplos:
          | Mensagem                        |
          | "Registro editado com sucesso." |
