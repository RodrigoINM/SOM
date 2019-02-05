#language:pt
#Author: Larissa Silva
#Date: 29/01/2019
#Version: 1.0

@kill_Driver @Midia @CadastrarMidia
Funcionalidade: 3.1.3 - Cadastrar Mídia


Contexto: Acessar a tela alteracao da obra
    Dado que esteja logado no sistema SOM
    E que esteja na tela de cadastrar midia

@chrome @CadastrarMidiaCT01
Esquema do Cenario: Cadastrar Mídia já cadastrada.
    Quando cadastrar um Mídia preenchendo o campo <MidiaNome>
    Então visualizo a mensagem de Midia já cadastrada <Mensagem>

    Exemplos:
      | MidiaNome | Mensagem               |
      | "TV"      | "Mídia já cadastrada." |

@chrome @CadastrarMidiaCT02
Esquema do Cenario: Cadastrar Mídia Ativa.
    Quando cadastrar uma Mídia preenchendo o campo <MidiaNome>
    Então seleciono o campo ativar midia

    Exemplos:
      | MidiaNome    |
      | "NOVO TESTE" |

