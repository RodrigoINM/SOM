#language:pt
#Author: Rodrigo Magno
#Date: 08/02/2019

@kill_Driver @CadastroDeObraNaCueSheet
Funcionalidade: 5.2.18 - Cadastro de novas obras

Contexto: Cadastro de novas obras de transição
    Dado que esteja logado no sistema SOM
#
#@chrome @CadastroDeObraNaCueSheetCT01
#Esquema do Cenário: Cadastrar nova Música na cue-sheet com sucesso
#    Quando cadastro uma nova obra preenchendo os campos: <Titulo>, <Tipo>, <ObraOriginal> e <Nacionalidade>
#    E incluo uma composicao com um unico ator com percentual de 100% <Autor> <DDA> <Percentual> <DDAOriginal> <Versionista>
#    Então visualizo o item da cue-sheet com <TituloAnterior> e <NovoStatus>
#    E a porcentagem da cue-sheet proporcional ao número de autores cadastrados
#
#    Exemplos:
#        | Titulo      | Subtitulo   | Tipo             | ObraOriginal | TituloAlternativo | ISWC | Ano    | Nacionalidade | Pais | DominioPublico | Institucional | Blacklist | Emblematica | Observacao | Autor      | DDA             | Percentual | Versionista | TituloAnterior | NovoStatus  |
#        | "TESTE INM" | "INMETRICS" | "TRILHA MUSICAL" | "SIM"        | "TESTE INMETRICS" | ""   | "2018" | "NACIONAL"    | ""   | ""             | ""            | ""        | ""          | "TESTE"    | "TesteHel" | "Teste ANA 123" | "100"      | "Não"       | "Titulo Teste" | "Pendencia" |
#
#
#Esquema do Cenário: Cadastrar nova Música na cue-sheet com informações duplicadas
#    Quando cadastro uma nova obra preenchendo os campos: <Titulo>, <Tipo>, <ObraOriginal> e <Nacionalidade> de outra obra previamente cadastrada
#    E incluo uma composicao com um unico ator com percentual de 100% <Autor> <DDA> <Percentual> <DDAOriginal> <Versionista>
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Titulo      | Subtitulo   | Tipo             | ObraOriginal | TituloAlternativo | ISWC | Ano    | Nacionalidade | Pais | DominioPublico | Institucional | Blacklist | Emblematica | Observacao | Autor      | DDA             | Percentual | Versionista | Mensagem                                               |
#        | "TESTE INM" | "INMETRICS" | "TRILHA MUSICAL" | "SIM"        | "TESTE INMETRICS" | ""   | "2018" | "NACIONAL"    | ""   | ""             | ""            | ""        | ""          | "TESTE"    | "TesteHel" | "Teste ANA 123" | "100"      | "Não"       | "Já existe uma música cadastrada com esta informações" |
