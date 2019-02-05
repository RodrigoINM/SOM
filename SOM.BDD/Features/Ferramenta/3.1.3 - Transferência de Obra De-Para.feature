#language: pt-BR
#Author: Larissa Silva
#Date: 04/02/2019
#Version: 1.0

@kill_Driver @Ferramentas @TransferenciaDeObra
Funcionalidade: 3.1.3 - Transferência de Obra (De/Para)


Contexto: Acessar a tela de Edição de DDA
    Dado que esteja logado no sistema SOM
    

@chrome @TransferenciaDeObraCT01
Esquema do Cenário: Transferência de Obra (De/Para)
	Dado a tela transferência de Obra (De/Para) esteja aberta
    Quando realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObraPara <TituloObraDe> , <TituloObraPara>
    Então visualizo a mensagem de transferencia de obra concluida <Mensagem>

   Exemplos:
       | TituloObraDe    | TituloObraPara   | Mensagem                                            |
       | "ANTES DA AULA" | "NOVO AMANHECER" | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @TransferenciaDeObraCT02
Esquema do Cenário: Transferencia de Autor (De/Para) com todos os campos em branco.
	Dado a tela transferência de Obra (De/Para) esteja aberta
    Quando realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObraPara <TituloObraDe> , <TituloObraPara>
    Então visualizo os campos TituloObraDe e TituloObraPara em destaque para preenchimento

    Exemplos:
       | TituloObraDe | TituloObraPara |
       | ""           | ""             |

@chrome @TransferenciaDeObraCT03
Esquema do Cenário: Transferência de Obra (De/Para) com Título Obra inexistente
	Dado a tela transferência de Obra (De/Para) esteja aberta
	Quando realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObraPara <TituloObraDe> , <TituloObraPara>
    Então visualizo os campos TituloObraDe em destaque para preenchimento

    Exemplos:
       | TituloObraDe | TituloObraPara   |
       | "kdhjf"      | "NOVO AMANHECER" |

@chrome @TransferenciaDeObraCT04
Esquema do Cenário: Transferencia de DDA (De/Para) com Nome DDA(Para) inexistente.
	Dado a tela transferência de Obra (De/Para) esteja aberta
	Quando realizo uma Transferência de obra preenchendo os campos TituloObraDe e TituloObraPara <TituloObraDe> , <TituloObraPara>
    Então visualizo os campos TituloObraPara em destaque para preenchimento

    Exemplos:
       | TituloObraDe     | TituloObraPara |
       | "NOVO AMANHECER" | "kdhjf"        |

@chrome @TransferenciaDeObraCT05
Esquema do Cenário: Transferencia de DDA (De/Para) selecionando a checkbox excluir
	Dado que a tenho uma Obra disponivel para exclusão
	Quando realizo uma Transferência preenchendo os campos TituloObraDe e TituloObraPara <TituloObraDe> , <TituloObraPara>
    E seleciono a CheckBox de exclusão de ObraDe
	Então visualizo a mensagem de confirmação de exclusão da ObraDe <Mensagem>   

    Exemplos:
		| TituloObraPara   | Mensagem                                            |
		| "NOVO AMANHECER" | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @TransferenciaDeObraCT06
Esquema do Cenário: Transferencia de DDA (De/Para) com Nome DDA (De/Para) iguais.
	Dado a tela transferência de Obra (De/Para) esteja aberta
    Quando realizo uma Transferência preenchendo os campos TituloObraDe e TituloObraPara <TituloObraDe> , <TituloObraPara>
    Então visualizo a mensagem de Obra, operação cancelada <Mensagem>

   Exemplos:
      | TituloObraDe     | TituloObraPara   | Mensagem                                                                    |
      | "NOVO AMANHECER" | "NOVO AMANHECER" | "Operação cancelada, não permitido fazer a transferência para o mesmo DDA." |
