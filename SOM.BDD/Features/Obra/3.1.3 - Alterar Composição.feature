#language:pt
#Author: Larissa Silva
#Date: 19/11/2018
#Version: 1.0

@kill_Driver @Obra @AlterarComposicao
Funcionalidade: 3.1.3 - Alterar Composição

Contexto: Acessar a tela alteracao da obra
    Dado que esteja logado no sistema SOM
    E que esteja na tela de Obras

@chrome @ConsultarComposicaoCT01
Esquema do Cenário: Validar alteração de Autor, DDA e Versionista da composição
	Dado que esteja na tela Edição de Obra
    Quando altero os valores de Autor, DDA , Versionista e salvo a composicao <Autor>, <DDA> e <Versionista>
    Então visualizo a mensagem de alteração da obra com sucesso <Mensagem>

  Exemplos:
      | Autor			    | DDA         | Versionista | Mensagem											  |
      | "Teste Autor Teste" | "SOM LIVRE" | "Sim"       | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @ConsultarComposicaoCT02
Esquema do Cenário: validar a mensagem de percentual da composição superior a 100%
    Dado que esteja na tela Edição de Obra
	Quando altero e salvo o percentual da composição superior ao permitido <Percentual>
	Então visualizo a mensagem Percentual <Mensagem>

  Exemplos:
      | Percentual | Mensagem					   |
      | "110"      | "Percentual superior a 100%." |

@chrome @ConsultarComposicaoCT03
Esquema do Cenário: Validar a mensagem de percentual da composição inferior a 100%
	Dado que esteja na tela Edição de Obra
    Quando altero e salvo o percentual da composição inferior ao permitido <Percentual>
    Então visualizo a mensagem Percentual <Mensagem>

  Exemplos:
      | Percentual | Mensagem                              |
      | "0"        | "Percentual precisa ser maior que 0%" |

@chrome @ConsultarComposicaoCT04
Cenário: validar alteração de duplicidade na composição
    Dado que esteja na tela Edição de Obra
    Quando altero e salvo o a duplicidade da obra
    Então visualizo o icone em destaque

@chrome @ConsultarComposicaoCT05
Esquema do Cenário: Alterar dados da obra com criação de novo DDA com associação
    Dado que esteja na tela Edição de Obra
    Quando salvo a alteracao de DDA com <Associacao>
    Então visualizo a mensagem de DDA <Mensagem> com sucesso

    Exemplos:
        | Associacao       | Mensagem                      |
        | "UBEM"           | "Registro salvo com sucesso." |
        | "SEM ASSOCIAÇÃO" | "Registro salvo com sucesso." |
