#language:pt
#Author: Larissa Silva
#Date: 14/02/2018
#Version: 1.0

@kill_Driver @Obra @CatalagodeEditora
Funcionalidade: 3.1.6 - Importação de Biblioteca de Catálogo de Editora

Contexto: Acessar a tela de Catálogo de Editora
      Dado que esteja logado no sistema SOM
      E a tela de de Catálogo de editora esteja aberto

@chrome @CatalagodeEditoraCt01
Esquema do Cenário: Importar Biblioteca com sucesso
    Quando faço um upload de um arquivo válido  <Arquivo>
    E visualizo a grid com as seguintes colunas, na aba de Itens Válidos: <Linha>, <Titulo>, <Composicao>, <Nacionalidade>, <DominioPublico> e <Tipo>
    Então salvo a importação do catálogo e visualizo a mensagem <Mensagem>

    Exemplos:
        | Arquivo                              | Linha | Titulo       | Composicao                           | Nacionalidade | DominioPublico | Tipo             | Mensagem                                                                                    |
        | "TEMPLATE Catálogo de Editoras.xlsx" | "2"   | "A AGRESSAO" | "ROGER HENRI - ROGER HENRI - (100%)" | "NACIONAL"    | "Não"          | "TRILHA MUSICAL" | "A importação será realizada em segundo plano. Ao final será enviado e-mail com resultado." |

@chrome @CatalagodeEditoraCt02
Cenário: Fazer download de Template com sucesso
    Quando clico para fazer o dowload no template
    Então visualizo o download com sucesso

@chrome @CatalagodeEditoraCt03
Esquema do Cenário: Validar extensão correta do ficheiro
    Quando faço um upload de um arquivo válido  <Arquivo>
    E visualizo a grid com as seguintes colunas, na aba de Itens Válidos: <Linha>, <Titulo>, <Composicao>, <Nacionalidade>, <DominioPublico> e <Tipo>
    Então salvo a importação do catálogo e visualizo a mensagem <Mensagem>

    Exemplos:
        | Arquivo                              | Linha | Titulo       | Composicao                           | Nacionalidade | DominioPublico | Tipo             | Mensagem                                                                                    |
        | "TEMPLATE Catálogo de Editoras.xlsx" | "2"   | "A AGRESSAO" | "ROGER HENRI - ROGER HENRI - (100%)" | "NACIONAL"    | "Não"          | "TRILHA MUSICAL" | "A importação será realizada em segundo plano. Ao final será enviado e-mail com resultado." |

@chrome @CatalagodeEditoraCt04
Esquema do Cenário: Validar mensagem de extensao incorreta do ficheiro
    Quando faço um upload de um arquivo <Arquivo>
    Então visualizo a mensagem de importação incorreta <Mensagem>

    Exemplos:
        | Arquivo     | Mensagem                                                  |
        | "Text.docx" | "Não foi possível executar importação, arquivo inválido." |

@chrome @CatalagodeEditoraCt05
Esquema do Cenário: Fazer upload de planilha com informações inválidas
    Quando faço um upload de um <Arquivo> com Autor não cadastrado
    Então visualizo, na aba Itens Inválidos, o erro <Erro>

    Exemplos:
        | Arquivo                                  | Erro                                      |
        | "Catálogo de Editoras Autor - Erro.xlsx" | "- AUTORES: O autor não existe - HSNWEUE" |

@chrome @CatalagodeEditoraCt06
Esquema do Cenário: Fazer upload de planilha com Autor não cadastrado
    Quando faço um upload de um <Arquivo> com Autor não cadastrado
    Então visualizo, na aba Itens Inválidos, o erro <Erro>

    Exemplos:
        | Arquivo                                  | Erro                                      |
        | "Catálogo de Editoras Autor - Erro.xlsx" | "- AUTORES: O autor não existe - HSNWEUE" |

@chrome @CatalagodeEditoraCt07
Esquema do Cenário: Fazer upload de planilha com DDA não cadastrado
    Quando faço um upload de um <Arquivo> com DDA não cadastrado
    Então visualizo, na aba Itens Inválidos, o erro de DDA <Erro>

      Exemplos:
          | Arquivo                                  | Erro                                   |
          | "Catálogo de Editoras - DDA - Erro.xlsx" | "- DDA: O DDA não existe - JDYTDBFJCV" |

@chrome @CatalagodeEditoraCt08
Esquema do Cenário: Validar mensagens na coluna Erro ao fazer upload de planilha vazia
    Quando faço um upload de um <Arquivo> com em branco
    Então visualizo, na aba Itens Inválidos, o Erro da planilha em branco

      Exemplos:
          | Arquivo                |
          | "Teste em branco.xlsx" |

@chrome @CatalagodeEditoraCt09
Esquema do Cenário: Validar mensagem de upload sem Arquivo
      Quando faço um upload sem nenhum Arquivo
      Então visualizo a mesagem de erro da importação <Mensagem>

      Exemplos:
          | Mensagem                                                     |
          | "Não foi possível executar importação, selecione o arquivo." |

@chrome @CatalagodeEditoraCt10
Esquema do Cenário: Cancelamento de Upload
    Quando faço um upload de um arquivo válido  <Arquivo>
    E visualizo a grid das colunas <Linha>, <Titulo>, <Composicao>, <Nacionalidade>, <DominioPublico>, <Tipo>
    Então confirmo o cancelamento do Upload do aquivo.

    Exemplos:
        | Arquivo                              | Linha | Titulo       | Composicao                           | Nacionalidade | DominioPublico | Tipo             |
        | "TEMPLATE Catálogo de Editoras.xlsx" | "2"   | "A AGRESSAO" | "ROGER HENRI - ROGER HENRI - (100%)" | "NACIONAL"    | "Não"          | "TRILHA MUSICAL" |

@chrome @CatalagodeEditoraCt11
Esquema do Cenário: Validar mensagem de importação em segundo plano
    Quando faço um upload de um arquivo válido  <Arquivo>
    E visualizo a grid com as seguintes colunas, na aba de Itens Válidos: <Linha>, <Titulo>, <Composicao>, <Nacionalidade>, <DominioPublico> e <Tipo>
    Então salvo a importação do catálogo e visualizo a mensagem <Mensagem>

    Exemplos:
        | Arquivo                              | Linha | Titulo       | Composicao                           | Nacionalidade | DominioPublico | Tipo             | Mensagem                                                                                    |
        | "TEMPLATE Catálogo de Editoras.xlsx" | "2"   | "A AGRESSAO" | "ROGER HENRI - ROGER HENRI - (100%)" | "NACIONAL"    | "Não"          | "TRILHA MUSICAL" | "A importação será realizada em segundo plano. Ao final será enviado e-mail com resultado." |

@chrome @CatalagodeEditoraCt12
Esquema do Cenário: Validar erros na importação de ficheiro com dados duplicados
     Quando faço um upload de um arquivo duplicado <Arquivo>
     Então visualizo, na aba Itens Inválidos, o erro <Erro>

     Exemplos:
         | Arquivo                                | Erro                                                                                        |
         | "Catálogo de Editoras - Duplicar.xlsx" | "- TÍTULO DA OBRA/AUTORES/DDA/PERCENTUAIS AUTORAIS: Obra duplicada no arquivo - A AGRESSAO" |

@chrome @CatalagodeEditoraCt13
Esquema do Cenário: Validar upload com sucesso de Ficheiro com muitos registros
    Quando faço um upload de um arquivo válido  <Arquivo>
    E visualizo a grid com as seguintes colunas, na aba de Itens Válidos: <Linha>, <Titulo>, <Composicao>, <Nacionalidade>, <DominioPublico> e <Tipo>
    Então salvo a importação do catálogo e visualizo a mensagem <Mensagem>

    Exemplos:
        | Arquivo                              | Linha | Titulo       | Composicao                           | Nacionalidade | DominioPublico | Tipo             | Mensagem                                                                                    |
        | "TEMPLATE Catálogo de Editoras.xlsx" | "2"   | "A AGRESSAO" | "ROGER HENRI - ROGER HENRI - (100%)" | "NACIONAL"    | "Não"          | "TRILHA MUSICAL" | "A importação será realizada em segundo plano. Ao final será enviado e-mail com resultado." |
