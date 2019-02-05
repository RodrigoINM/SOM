#language:pt
#Author: Larissa Silva
#Date: 19/11/2018
#Version: 1.0

@kill_Driver @Obra @AlterarObra
Funcionalidade: 3.1.3 - Alterar Obra

Contexto: Acessar a tela alteracao da obra
    Dado que esteja logado no sistema SOM
    E que esteja na tela de Obras

@chrome @AlterarObraCT01
Esquema do Cenário: Alterar dados do campo Título da obra
	Quando faço uma busca simples por uma obra
    E altero e salvo os dados no campo titulo
    Então visualizo a mensagem de alterado obra com sucesso <Mensagem>

    Exemplos:
       | Mensagem                                            |
       | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT02
Esquema do Cenário: Alterar dados do campo Tipo da obra
    Dado que esteja na tela Edição de Obra
    Quando salvo a alteração no campo tipo da obra <Tipo>
    Então visualizo a mensagem de alteração da obra com sucesso <Mensagem>

    Exemplos:
        | Tipo                        | Mensagem                                            |
        | "BIBLIOTECA MUSICAL"        | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "MUSICA COMERCIAL"          | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "MUSICA COMERCIAL GRATUITA" | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "TRILHA MUSICAL"            | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT03
Esquema do Cenário: Alterar dados do campo Ano da obra
    Dado que esteja na tela Edição de Obra
    Quando salvo a alteração no campo Ano <Ano>
    Entao visualizo a mensagem de alteração do ano da obra com sucesso <Mensagem>

    Exemplos:
        | Ano    | Mensagem                                            |
        | "2019" | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT04
Esquema do Cenario: Alterar dados dos campos obrigatorios de Obra
	Dado que esteja na tela Edição de Obra
    E altero os dados obrigatorios Titulo, <Tipo> e <Nacionalidade> da obra
    Então visualizo a mensagem dos campos obrigatórios, alterado com sucesso <Mensagem>
    
    Exemplos: 
        | Tipo             | Nacionalidade | Mensagem                                            |
        | "TRILHA MUSICAL" | "Nacional"    | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT05
Esquema do Cenario: Alterar dados do campo Derivação
    Dado que esteja na tela Edição de Obra
    E salvo uma alteracao feita no campo de <Derivacao>
    Entao visualizo a mensagem de alteração <Mensagem> com sucesso

    Exemplos:
        | Derivacao           | Mensagem                                            |
        | "Adaptação"         | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "Mashup"            | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "Pot-pourri/Medley" | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "Sample"            | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "Versão"            | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT06
Esquema do Cenário: Alterar dados do campo Obra Original da obra que já possue a mesma informada
    Dado que esteja na tela Edição de Obra, que já possue Obra Origunal informada
    E altero o campo de <Derivacao> e salvo
    Entao visualizo a mensagem de alteração <Mensagem> com sucesso

    Exemplos:
        | Derivacao | Mensagem                                            |
        | "Mashup"  | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT07
Esquema do Cenário: Alterar dados do campo Institucional
    Dado que esteja na tela Edição de Obra
    Quando salvo a aletracao da flag <Institucional>
    Entao visualizo a mensagem de alteração <Mensagem> com sucesso

    Exemplos:
        | Institucional | Mensagem                                            |
        | "Sim"         | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "Não"         | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT08
Esquema do Cenário: Alterar dados do campo Emblemática
    Dado que esteja na tela Edição de Obra
    Quando salvo a aletracao da flag emblematica <Emblematica>
	Entao visualizo a mensagem de alteração <Mensagem> com sucesso

    Exemplos:
        | Emblematica | Mensagem                                            |
        | "Sim"       | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "Não"       | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT09
Esquema do Cenário: Alterar dados do campo Título Alternativo
    Dado que esteja na tela Edição de Obra
    Quando salvo a alteracao do <TituloAlternativo>
    Entao visualizo a mensagem de alteração <Mensagem> com sucesso

    Exemplos:
        | TituloAlternativo | Mensagem                                            |
        | "NovoTeste"       | "Dados alterados com sucesso e enviados ao GMUSIC." |
        | "NovoTitulo"      | "Dados alterados com sucesso e enviados ao GMUSIC." |

@chrome @AlterarObraCT10
Esquema do Cenário: Alterar dados da obra com criação de novo DDA com associacao
    Dado que esteja na tela Edição de Obra
    Quando salvo a alteracao de DDA com <Associacao>
    Então visualizo a mensagem de DDA <Mensagem> com sucesso

    Exemplos:
        | Associacao       | Mensagem                      |
        | "UBEM"           | "Registro salvo com sucesso." |
        | "SEM ASSOCIAÇÃO" | "Registro salvo com sucesso." |
