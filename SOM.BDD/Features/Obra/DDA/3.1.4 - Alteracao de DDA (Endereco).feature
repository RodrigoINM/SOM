#language: pt-BR
#Author: Larissa Silva
#Date: 29/01/2019
#Version: 1.0

@chrome @kill_Driver @DDA @AlteracaoDeEndereçoDDA
Funcionalidade: 3.1.4 - Alterações de DDA - Endereço

Contexto: Acessar a tela de Edição de DDA
    Dado que esteja logado no sistema SOM
    E que estou com a tela Novo Cadastro de DDA

@chrome @AlteracaoEnderecoDeDDACT01
Esquema do Cenário:  Alteração de endereço com sucesso
    Dado que tenho um DDA cadastrado
    E altero os campos de endereço do DDA <Logradouro>, <Bairro>, <Cidade>, <UF> e <CEP>
    Então visualizo a mensagem de enderço do DDA alterado com sucesso <Mensagem>

    Exemplos:
        | Logradouro        | Bairro         | Cidade  | UF   | CEP         | Mensagem                      |
        | "Rua Teste, n° 1" | "Bairro Teste" | "Teste" | "RJ" | "24546-787" | "Registro salvo com sucesso." |

@chrome @AlteracaoEnderecoDeDDACT02
Esquema do Cenário:  Alteracao de país
	Dado que tenho um DDA cadastrado
    E altero os campos de endereço internacional do DDA <Pais>, <Logradouro>, <Bairro>, <Cidade>, <UF> e <CEP>
    Então visualizo a mensagem de enderço do DDA alterado com sucesso <Mensagem>

    Exemplos:
      | Pais       | Logradouro        | Bairro         | Cidade  | UF   | CEP         | Mensagem                      |
      | "Portugal" | "Rua Teste, n° 1" | "Bairro Teste" | "Teste" | "RJ" | "24546-787" | "Registro salvo com sucesso." |
