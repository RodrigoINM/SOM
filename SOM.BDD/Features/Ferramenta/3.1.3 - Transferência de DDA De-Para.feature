#language: pt-BR
#Author: Larissa Silva
#Date: 04/01/2019
#Version: 1.0

@kill_Driver @Ferramentas @TransferenciaDeParaDDA
Funcionalidade: 3.1.3 - Transferencia de DDA (De/Para)

Contexto: Acessar a tela de Transferência de Controle Editorial (De/Para)
    Dado que esteja logado no sistema SOM

@chrome @TransferenciaDeParaDDACT01
Esquema do Cenário: Transferência de DDA (De/Para)
	Dado que a tela Transferência de DDA (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    Então visualizo a mensagem de confirmação de trasferencia de DDA <Mensagem>
    
	Exemplos:
       | NomeDDADe | NomeDDAPara   | Mensagem                                            |
       | "AMORINA" | "JU MEDEIROS" | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @TransferenciaDeParaDDACT02
Esquema do Cenário: Transferencia de DDA (De/Para) com todos os campos em branco.
	Dado que a tela Transferência de DDA (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    Então visualizo os campos NomeDDADe e NomeDDAPara em destaque para preenchimento

    Exemplos:
	   | NomeDDADe | NomeDDAPara |
       | " "       | " "         |

@chrome @TransferenciaDeParaDDACT03
Esquema do Cenário: Transferencia de DDA (De/Para) com Nome DDA(De) inexistente.
	Dado que a tela Transferência de DDA (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    Então visualizo os campos NomeDDADe em destaque para preenchimento

    Exemplos:
       | NomeDDADe | NomeDDAPara |
       | "kdjsj"   | "NOWA"      |

@chrome @TransferenciaDeParaDDACT04
Esquema do Cenário: Transferencia de DDA (De/Para) com Nome DDA(Para) inexistente.
	Dado que a tela Transferência de DDA (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    Então visualizo os campos NomeDDAPara em destaque para preenchimento

    Exemplos:
       | NomeDDADe | NomeDDAPara |
       | "NOWA"    | "jfjfj"     |

@chrome @TransferenciaDeParaDDACT05
Esquema do Cenário: Transferencia de DDA (De/Para) seleciono a CheckBox Excluir
	Dado que a tenho um DDA disponivel para exclusão
    Quando realizo uma transferência de DDA preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    E seleciono a CheckBox de exclusão de DDADe
	Então visualizo a mensagem de confirmação de exclusão de DDADe <Mensagem>

	Exemplos:
       | NomeDDAPara | Mensagem                                            |
       | "NOWA"      | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @TransferenciaDeParaDDACT06
Esquema do Cenário: Transferencia de DDA (De/Para) com Nome DDA(De) sem Obras.
	Dado que tenho um DDA sem obras
    Quando realizo uma Transferência DDA sem obras preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    Então visualizo a mensagem de DDA não possui obras <Mensagem>

    Exemplos:
	   | NomeDDADe | NomeDDAPara | Mensagem                |
	   | " "       | "NOWA"      | "DDA não possui Obras." |

@chrome @TransferenciaDeParaDDACT07
Esquema do Cenário: Transferencia de DDA (De/Para) com Nome DDA (De/Para) iguais.
	Dado que a tela Transferência de DDA (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos NomeDDADe e NomeDDAPara <NomeDDADe> , <NomeDDAPara>
    Então visualizo a mensagem de DDA, operação cancelada <Mensagem>

    Exemplos:
        | NomeDDADe | NomeDDAPara | Mensagem                                                                    |
        | "AMORINA" | "AMORINA"   | "Operação cancelada, não permitido fazer a transferência para o mesmo DDA." |
