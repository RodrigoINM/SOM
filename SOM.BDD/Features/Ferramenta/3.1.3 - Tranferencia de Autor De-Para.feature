#language: pt-BR
#Author: Larissa Silva
#Date: 31/01/2019
#Version: 1.0

@kill_Driver @Ferramentas @TransferenciaDePara
Funcionalidade: 3.1.3 - Transferencia de Autor (De/Para)


Contexto: Acessar a tela de Edição de DDA
    Dado que esteja logado no sistema SOM

@chrome @TransferenciaDeParaCT01
Esquema do Cenário: Transferencia de Autor (De/Para) com sucesso.
	Dado a tela transferencia de autor (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos <NomeAutorDe> e <NomeAutorPara>
    Então visualizo a mensagem de confirmação de transferência <Mensagem>
    
    Exemplos:
      | NomeAutorDe         | NomeAutorPara | Mensagem                                            |
      | "Teste Autor Teste" | "NOVO SOM"    | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @TransferenciaDeParaCT02
Esquema do Cenário: Transferencia de Autor (De/Para) com todos os campos em branco.
	Dado a tela transferencia de autor (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos <NomeAutorDe> e <NomeAutorPara>
    Então visualizo os campos NomeAutorDE e NomeAutorPara em destaque para preenchimento 

    Exemplos:
        | NomeAutorDe | NomeAutorPara |
        | ""          | ""            |

@chrome @TransferenciaDeParaCT03
Esquema do Cenário: Transferencia de Autor (De/Para) com Nome Autor(De) inexistente.
	Dado a tela transferencia de autor (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos <NomeAutorDe> e <NomeAutorPara>
    Então visualizo o campo NomeAutorDe em destaque para preenchimento.

    Exemplos:
        | NomeAutorDe | NomeAutorPara |
        | "Inmetrics" | "NOVO SOM"    |

@chrome @TransferenciaDeParaCT04
Esquema do Cenário: Transferencia de Autor (De/Para) com Nome Autor(Para) inexistente.
	Dado a tela transferencia de autor (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos <NomeAutorDe> e <NomeAutorPara>
    Então visualizo o campo NomeAutorPara em destaque para preenchimento.

    Exemplos:
        | NomeAutorDe | NomeAutorPara |
        | "NOVO SOM"  | "Inmetrics"   |

@chrome @TransferenciaDeParaCT05
Esquema do Cenário: transferencia de autor (De/Para) com nome Autor(De) sem obras.
	Dado a tela transferencia de autor (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos <NomeAutorDe> e <NomeAutorPara>
    Então visualizo a mensagem que o Autor não possui obras <Mensagem>

    Exemplos:
        | NomeAutorDe | NomeAutorPara       | Mensagem                  |
        | "NOVO SOM"  | "Teste Autor Teste" | "Autor não possui Obras." |

@chrome @TransferenciaDeParaCT06
Esquema do Cenário: Transferencia de Autor (De/Para) com Nome Autor (De/Para) iguais.
	Dado a tela transferencia de autor (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos <NomeAutorDe> e <NomeAutorPara>
    E visualizo a mensagem de Autor DePara não permitido <Mensagem>

    Exemplos:
	   | NomeAutorDe | NomeAutorPara | Mensagem                                                                      |
	   | "NOVO SOM"  | "NOVO SOM"    | "Operação cancelada, não permitido fazer a transferência para o mesmo autor." |

@chrome @TransferenciaDeParaCT07
Esquema do Cenário: Transferencia de Autor (De/Para) selecionando checkBox Excluir
    Quando realizo uma Transferência de autor preenchendo o campos AutorDe e AutorPara <NomeAutorPara>
    E seleciono o checkbox de excluir AutorDe
	Então visualizo a mensagem de confirmação da exclusão do autor <Mensagem>

    Exemplos:
	   | NomeAutorPara | Mensagem                     |
	   | "NOVO SOM"    | "Autor excluído com sucesso" |
