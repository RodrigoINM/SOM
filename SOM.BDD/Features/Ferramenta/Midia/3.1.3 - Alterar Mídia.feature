#language:pt
#Author: Larissa Silva
#Date: 29/01/2019
#Version: 1.0

@kill_Driver @Midia @AlterarMidia
Funcionalidade: 3.1.3 - Alterar Mídia

Contexto: Acessar a tela alteracao da obra
    Dado que esteja logado no sistema SOM
    E que esteja na tela consultar mídia

@chrome @AlterarMidiaCT01
Esquema do Cenario: Alterar Mídia com nome em branco.
    Quando altero uma midia cadastrada, limpando o nome <MidiaNome>
    Então visualizo o campo Midia Nome em destaque para preenchimento.

    Exemplos:
      | MidiaNome |
      | ""        |
