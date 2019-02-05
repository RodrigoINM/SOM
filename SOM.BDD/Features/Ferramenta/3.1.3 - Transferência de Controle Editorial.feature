#language: pt-BR
#Author: Larissa Silva
#Date: 01/02/2019
#Version: 1.0

@kill_Driver @Ferramentas @TransferenciaDePara
Funcionalidade: 3.1.3 - Transferência de Controle Editorial (De/Para)

Contexto: Acessar a tela de Transferência de Controle Editorial (De/Para)
    Dado que esteja logado no sistema SOM
    E a tela Transferência de Controle Editorial (De/Para) esteja aberta

@chrome @TransferenciaDeParaCT01
Esquema do Cenário: Realizar uma Transferência de Controle Editorial (De/Para) com todos os campos em branco
    Quando realizo uma Transferência sem preencher os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara <NomeAutorDe>, <NomeAutorPara>, <NomeDDAPara> e <NomeDDADe>
    Então visualizo os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara em destaque para preenchimento.

    Exemplos:
        | NomeAutorDe | NomeAutorPara | NomeDDADe | NomeDDAPara |
        | " "         | " "           | " "       | " "         |

@chrome @TransferenciaDeParaCT02
Esquema do Cenário: Realizar uma Transferência de Controle Editorial (De/Para) com todos os campos preenchidos
    Quando realizo uma Transferência sem preencher os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara <NomeAutorDe>, <NomeAutorPara>, <NomeDDAPara> e <NomeDDADe>
    Então visualizo a mensagem de confirmação de trasnferencia de Controle Editorial <Mensagem>

    Exemplos:
		| NomeAutorDe    | NomeAutorPara  | NomeDDADe | NomeDDAPara | Mensagem                                                              |
		| "RICARDO LEAO" | "WILL HOLLAND" | "DECK"    | "A DESCO"   | "Controles editoriais transferidos com sucesso e enviados ao GMUSIC." |

@chrome @TransferenciaDeParaCT03
Esquema do Cenário: Realizar uma Transferência de Controle Editorial (De/Para) com Autor que não possiu obras no DDA informado
      Quando realizo uma Transferência sem preencher os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara <NomeAutorDe>, <NomeAutorPara>, <NomeDDAPara> e <NomeDDADe>
      Entao visualizo a mensagem que o autor não possue obras no DDA informado <Mensagem>

      Exemplos:
        | NomeAutorDe   | NomeAutorPara     | NomeDDADe        | NomeDDAPara | Mensagem                                   |
        | "Teste Autor" | "TESTE INM Autor" | "Aaron319736623" | "A DESCO"   | "Autor não possui Obras no DDA informado." |

@chrome @TransferenciaDeParaCT04
Esquema do Cenário: Realizar uma Transferência de Controle Editorial (De/Para) com (De/Para) iguais
      Quando realizo uma Transferência sem preencher os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara <NomeAutorDe>, <NomeAutorPara>, <NomeDDAPara> e <NomeDDADe>
      Entao visualizo a mensagem de operação cancelada <Mensagem>

      Exemplos:
        | NomeAutorDe    | NomeAutorPara  | NomeDDAPara | NomeDDADe | Mensagem                                                                                  |
        | "RICARDO LEAO" | "RICARDO LEAO" | "DECK"      | "DECK"    | "Operação cancelada, não permitido fazer a transferência para o mesmo autor e mesmo DDA." |

@chrome @TransferenciaDeParaCT05
Esquema do Cenário:Realizar uma Transferência de Controle Editorial (De/Para) com Autor inexistente
      Quando realizo uma Transferência sem preencher os campos NomeAutorDe, NomeAutorPara, NomeAutorDe, NomeDDADe, NomeDDAPara <NomeAutorDe>, <NomeAutorPara>, <NomeDDAPara> e <NomeDDADe>
      Entao visualizo a campo AutorDe em destaque para preenchimento

      Exemplos:
        | NomeAutorDe           | NomeAutorPara     | NomeDDADe        | NomeDDAPara |
        | "Teste Transferencia" | "TESTE INM Autor" | "Aaron319736623" | "A DESCO"   |
