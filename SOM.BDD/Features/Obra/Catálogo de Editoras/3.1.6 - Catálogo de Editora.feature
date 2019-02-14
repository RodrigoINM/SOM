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
    Quando faço um upload de um <Arquivo> válido
    Então visualizo a grid com os seguintes colunas na aba Itens Válidos: <Linha>, <Titulo>, <Composicao>, <Nacionalidade>, <DominioPublico> e <Tipo>
    E é salva uma Obra com o <Titulo>

    Exemplos:
        | Arquivo         | Linha | Titulo          | Composicao      | Nacionalidade | DominioPublico | Tipo             |
        | "template.xlsx" | "1"   | "OBRA TEMPLATE" | "Produto Teste" | "Nacional"    | "Não"          | "TRILHA MUSICAL" |


#Esquema do Cenário: Fazer download de Template com sucesso
#    Quando faço um download de um ficheiro
#    Então visualizo um excel com as seguintes colunas vazias: <NomeArquivo>, <TituloObra>, <SubtituloObra>, <Autores>, <DDAOriginal>, <DDA>, <PercentuaisAutorais>, <ANO>, <NacionalidadeObra>, <ISWC>, <Interprete>, <Gravadora>, <Selo>, <ISRC>, <TagsMoods>, <SubMix>, <Blacklist>, <Album>, <TituloObraOriginal>, <AutoresOriginal>, <BibliotecaProduto>, <PaisOrigem>, <TipoObra>
#
#    Exemplos:
#        | NomeArquivo     | TituloObra   | SubtituloObra | Autores | DDAOriginal | DDA    | PercentuaisAutorais | ANO    | NacionalidadeObra | ISWC  | Interprete   | Gravadora   | Selo | ISRC  | TagsMoods | SubMix | Blacklist | Album   | TituloObraOriginal | AutoresOriginal | BibliotecaProduto | PaisOrigem | TipoObra         |
#        | "Arquivo Teste" | "Obra Teste" | "Obra Teste"  | "Teste" | "UBEM"      | "UBER" | "100%"              | "2018" | "Nacional"        | "123" | "Anavitoria" | "SOM LIVRE" | "12" | "123" | "Tags"    | "123"  | "Não"     | "Album" | "Obra Teste"       | "Autor Teste"   |  "Produto"        | "Brasil"   | "TRILHA MUSICAL" |
#
#
#Esquema do Cenário: Validar extensão correta do ficheiro
#    Quando faço um upload de um <Arquivo> válido
#    Então visualizo uma grid com o resultado do upload
#
#    Exemplos:
#          | Arquivo         |
#          | "template.xlsx" |
#
#
#Esquema do Cenário: Validar mensagem de extensao incorreta do ficheiro
#    Quando faço um upload de um <Arquivo> diferente da extensão ".xlsx"
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Arquivo        | Mensagem                                                  |
#        | "template.txt" | "Não foi possível executar importação, arquivo inválido." |
#
#
#Esquema do Cenário: Fazer upload de planilha com informações inválidas
#    Quando faço um upload de um <Arquivo> com informações inválidas
#    Então visualizo a grid na Itens Válidos vazias
#    E na aba Itens Inválidos, a relação com todos os itens da planilha que não estão corretos
#
#    Exemplos:
#        | Arquivo         |
#        | "template.xlsx" |
#
#
#Esquema do Cenário: Fazer upload de planilha com Autor não cadastrado
#    Quando faço um upload de um <Arquivo> com Autor não cadastrado
#    Então visualizo, na aba Itens Inválidos, o <Erro>
#
#    Exemplos:
#        | Arquivo         | Erro                          |
#        | "template.xlsx" | "AUTORES: O autor não existe" |
#
#
#Esquema do Cenário: Fazer upload de planilha com DDA não cadastrado
#      Quando faço um upload de um <Arquivo> com DDA não cadastrado
#      Então visualizo, na aba Itens Inválidos, o <Erro>
#
#      Exemplos:
#          | Arquivo         | Erro                    |
#          | "template.xlsx" | "DDA: O DDA não existe" |
#
#
#Esquema do Cenário: Validar mensagens na coluna Erro ao fazer upload de planilha vazia
#      Quando faço um upload de um <Arquivo> vazio
#      Então vizualizo a <Mensagem> na coluna Erro, na aba Itens Inválidos
#
#      Exemplos:
#          | Arquivo         | Erro                                                                                                                                                                                                                                                                                                        |
#          | "template.xlsx" | "TÍTULO DA OBRA: Campo não informado // AUTORES: Campo não informado // DDA: Campo não informado // PERCENTUAIS AUTORAIS: Campo não informado // NACIONALIDADE DA OBRA: Campo não informado // TIPO DE OBRA: Campo não informado // PERCENTUAIS AUTORAIS: O percentual da composição é menor que 100% - 0%" |
#
#
#Esquema do Cenário: Validar mensagem de upload sem Arquivo
#      Quando faço um upload sem nenhum Arquivo
#      Então visualizo a <Mensagem>
#
#      Exemplos:
#          | Mensagem                                                    |
#          | "Não foi possível executar importação, selecione o arquivo" |
#
#
#Esquema do Cenário: Cancelamento de Upload
#      Quando cancelo um upload de um <Arquivo>
#      Então visualizo a <Mensagem> para validação
#      E a tela de busca por Obra
#
#      Exemplos:
#          | Arquivo         | Mensagem                                                                  |
#          | "template.xlsx" | "Registro ainda não foi salvo no sistema, todos os dados serão perdidos." |
#
#
#Esquema do Cenário: Validar mensagem de importação em segundo plano
#    Dado que já foi feito um upload de um ficheiro
#    Quando faço novamente o upload de um <Arquivo>
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Arquivo         | Mensagem                                                                                    |
#        | "template.xlsx" | "A importação será realizada em segundo plano. Ao final será enviado e-mail com resultado." |
#
#
#Esquema do Cenário: Validar erros na importação de ficheiro com dados duplicados
#      Quando faço um upload de um <Arquivo> com <Obra> duplicada no arquivo
#      Então visualizo a <Mensagem> na coluna Erro, na aba Itens Inválidos
#
#      Exemplos:
#          | Arquivo         | Obra    | Mensagem                                                                            |
#          | "template.xlsx" | "TESTE" |"TÍTULO DA OBRA/AUTORES/DDA/PERCENTUAIS AUTORAIS: Obra duplicada no arquivo - TESTE" |
#
#
#Esquema do Cenário: Validar upload com sucesso de Ficheiro com muitos registros
#    Quando faço um upload de um <Arquivo>
#    Então visualizo a grid de resultado com todas as informações da planilha
#
#    Exemplos:
#        | Arquivos        |
#        | "template.xlsx" |
