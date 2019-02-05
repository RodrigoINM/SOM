#language: pt-BR
#Author: Larissa Silva
#Date: 28/01/2019
#Version: 1.0

@chrome @kill_Driver @DDA @CadastroDeEnderecoDDA
Funcionalidade: 3.1.4 - Cadastro Endereço de DDA

Contexto: Acessara a tela de cadastro de DDA
	Dado que esteja logado no sistema SOM
    E que estou com a tela Novo Cadastro de DDA

@chrome @CadastroDeEnderecoDDACT01
Esquema do Cenário: Cadastro de Endereço
    Quando cadastro um DDA com os campos de endereço <Logradouro>, <Bairro>, <Cidade>, <UF> e <CEP>
    Então visualizo a mensagem de endereço de DDA <Mensagem>

    Exemplos:
        | Logradouro        | Bairro         | Cidade  | UF   | CEP         | Mensagem                      |
        | "Rua Teste, n° 1" | "Bairro Teste" | "Teste" | "RJ" | "24546-787" | "Registro salvo com sucesso." |

@chrome @CadastroDeEnderecoDDACT02
Esquema do Cenário: Cancelar cadastro de Endereço
    Quando cadastro um DDA com os campos de endereço <Logradouro>, <Bairro>, <Cidade>, <UF> e <CEP>
    E cancelo o cadasto de Endereço
    Então visualizo a mensagem de endereço de DDA <Mensagem>

    Exemplos:
        | Logradouro        | Bairro         | Cidade  | UF   | CEP         | Mensagem                         |
        | "Rua Teste, n° 2" | "Bairro Teste" | "Teste" | "RJ" | "24546-787" | "Registro excluído com sucesso." |

@chrome @CadastroDeEnderecoDDACT03
Esquema do Cenário: Cancelar cadastro de Endereço para um DDA Internacional
    Quando cadastro um DDA com os campos de endereço internacional <Pais>, <Logradouro>, <Bairro>, <Cidade>, <UF> e <CEP>
    E cancelo o cadasto de Endereço
    Então visualizo a mensagem de endereço de DDA <Mensagem>

    Exemplos:
        | Pais       | Logradouro                    | Bairro      | Cidade        | UF   | CEP         | Mensagem                         |
        | "Portugal" | "R. Leal da Camara 31 RL ESQ" | "ALGUEIRÃO" | "MEM MARTINS" | "RJ" | "24546-787" | "Registro excluído com sucesso." |

@chrome @CadastroDeEnderecoDDACT04
Esquema do Cenário: Cancelar cadastro de Endereço para um DDA Nacional com sucesso
    Quando cadastro um novo endereço preenchendo os campos <Pais>, <Logradouro>, <Bairro>, <Cidade>, <UF> e <CEP>
    E cancelo o cadasto de Endereço
	Então visualizo a mensagem de endereço de DDA <Mensagem>

    Exemplos:
        | Pais     | Logradouro                 | Bairro     | Cidade     | UF   | CEP         | Mensagem                         |
        | "Brasil" | "Boulevard das Flores 255" | "Barbalho" | "SALVADOR" | "BA" | "40301–110" | "Registro excluído com sucesso." |
