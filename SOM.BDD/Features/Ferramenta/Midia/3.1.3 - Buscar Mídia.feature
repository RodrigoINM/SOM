#language:pt
#Author: Larissa Silva
#Date: 29/01/2019
#Version: 1.0

@kill_Driver @Midia @BuscarMidia
Funcionalidade: 3.1.3 - Buscar Mídia

Contexto: Acessar a tela alteracao da obra
    Dado que esteja logado no sistema SOM
    E que esteja na tela consultar mídia

@chrome @BuscarMidiaCT01
Cenario: Buscar Mídia com campo em branco.
    Quando realizo uma pesquisa sem preencher o campo buscar midia
    Então visualizo a grid com os campos Midia, Ar e Ativa preenchidos com todas as mídias.

@chrome @BuscarMidiaCT02
Esquema do Cenario: Buscar Mídia inexistente.
      Quando realizo uma busca preenchendo o campo <BuscarMidia>
      Então visualizo a mensagem de dados encontrados <Mensagem>

      Exemplos:
        | BuscarMidia  | Mensagem                 |
        | "Novo Teste" | "Dados não encontratos"  |

@chrome @BuscarMidiaCT03
Cenario: Buscar Mídia pelo filtro Ativa.
      Quando realizo uma busca com filtro Ativa
      Então visualizo a grid com os campos Midia, Ar e Ativa preenchidos com todas as mídias.

@chrome @BuscarMidiaCT04
Esquema do Cenario: Buscar Mídia pelo filtro AR com sucesso.
      Quando realizo uma busca selecionando o campo Ar <AR>
      Então visualizo a grid com os campos Midia, Ar e Ativa preenchidos com todas as mídias.

      Exemplos:
          | AR       |
          | "450005" |

@chrome @BuscarMidiaCT05
Esquema do Cenario: Buscar Mídia pelo filtro AR inexistente.
      Quando realizo uma busca selecionando o campo Ar <AR>
      Então visualizo a mensagem de dados encontrados <Mensagem>

      Exemplos:
        | AR        | Mensagem                 |
        | "123456"  | "Dados não encontratos"  |
