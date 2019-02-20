#language: pt-BR
#Author: Larissa Silva
#Date: 12/02/2019
#Version: 1.0

@kill_Driver @RelatorioECAD
Funcionalidade: 5.6.1 - Gerar Relatório ECAD

Contexto: Acessar sistema SOM
	Dado que esteja logado no sistema SOM
	E a tela de Relatorio ECAD esteja aberta

@chrome	@RelatorioECADCT01
Esquema do Cenario: Gerar download relatório ECAD sem fechamento mensal
    Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Então visualizo que a mensagem do relatorio que não possue fechamento mensal <Mensagem>

    Exemplos:
        | Tipo     | Mes        | Ano    | Mensagem                                            |
        | "Mensal" | "Dezembro" | "2018" | "Não existe fechamento para o período selecionado." |

@chrome	@RelatorioECADCT02
Esquema do Cenário: Gerar Novo relatório mensal ECAD em Excel
    Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT03
Esquema do Cenario: Gerar Novo relatório Complemento ECAD em Excel
    Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo          | Mes       | Ano    | Programa          | DataExibicao | Capitulo   | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica   | TipodeMusica       | Autor                                                 | Interprete    | Segundos | Classificacao | Compositores | Editora                           | Gravadora | Submix     | NomePlanilha           |
		| "Complemento" | "Outubro" | "2018" | "ANTENA PAULISTA" | "25/10/2018" | "10012010" | "REPRISE"      | " "     | "1"           | "MUSICA DA MARCELLE" | "MUSICA COMERCIAL" | "MARCELLE MENDONCA,MARCELLE MENDONCA,SHAKIRA MEBARAK" | "DANIEL MUSY" | "40"     | "TA"          | ""           | "EMI SONGS,SOM E LUZ,A DESCOBRIR" | "RGE"     | "FULL MIX" | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT04
Esquema do Cenário: Gerar relatório ECAD mensal pelo filtro Produto.
    Quando filtro um relatorio ECAD preenchendo o campo tipo periodo <Tipo>, <Mes> , <Ano> e produto
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |


@chrome	@RelatorioECADCT05
Esquema do Cenário: Gerar relatório ECAD Complemento pelo filtro Produto.
    Quando filtro um relatorio ECAD complemento preenchendo o campo tipo periodo <Tipo>, <Mes> , <Ano> e produto
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo          | Mes       | Ano    | Programa          | DataExibicao | Capitulo   | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica   | TipodeMusica       | Autor                                                 | Interprete    | Segundos | Classificacao | Compositores | Editora                           | Gravadora | Submix     | NomePlanilha           |
		| "Complemento" | "Outubro" | "2018" | "ANTENA PAULISTA" | "25/10/2018" | "10012010" | "REPRISE"      | " "     | "1"           | "MUSICA DA MARCELLE" | "MUSICA COMERCIAL" | "MARCELLE MENDONCA,MARCELLE MENDONCA,SHAKIRA MEBARAK" | "DANIEL MUSY" | "40"     | "TA"          | ""           | "EMI SONGS,SOM E LUZ,A DESCOBRIR" | "RGE"     | "FULL MIX" | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT06
Esquema do Cenário: Validar histórico do relatorio ECAD
Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos
	E valido o historico do reletorio ECAD

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT07
Esquema do Cenário: Gerar relatório ECAD mensal pelo filtro mídia.
    Quando filtro um relatorio ECAD preenchendo o campo tipo , periodo <Tipo>, <Mes> , <Ano> e midia
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"           | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT08
Esquema do Cenário: Gerar relatório ECAD Complemento pelo filtro mídia.
	Quando filtro um relatorio ECAD complemento preenchendo o campo tipo periodo <Tipo>, <Mes> , <Ano> e midia
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo          | Mes       | Ano    | Programa          | DataExibicao | Capitulo   | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica   | TipodeMusica       | Autor                                                 | Interprete    | Segundos | Classificacao | Compositores | Editora                           | Gravadora | Submix     | NomePlanilha           |
		| "Complemento" | "Outubro" | "2018" | "ANTENA PAULISTA" | "25/10/2018" | "10012010" | "REPRISE"      | " "     | "1"           | "MUSICA DA MARCELLE" | "MUSICA COMERCIAL" | "MARCELLE MENDONCA,MARCELLE MENDONCA,SHAKIRA MEBARAK" | "DANIEL MUSY" | "40"     | "TA"          | ""           | "EMI SONGS,SOM E LUZ,A DESCOBRIR" | "RGE"     | "FULL MIX" | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT09
Esquema do Cenário: Gerar relatório ECAD Mensal pelo filtro DDA.
    Quando filtro um relatorio ECAD preenchendo o campo tipo , periodo <Tipo>, <Mes> , <Ano> e DDA
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT10
Esquema do Cenário: Gerar relatório ECAD Complemento pelo filtro DDA.
	Quando filtro um relatorio ECAD complemento preenchendo o campo tipo periodo <Tipo>, <Mes> , <Ano> e DDA
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo          | Mes       | Ano    | Programa          | DataExibicao | Capitulo   | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica   | TipodeMusica       | Autor                                                 | Interprete    | Segundos | Classificacao | Compositores | Editora                           | Gravadora | Submix     | NomePlanilha           |
		| "Complemento" | "Outubro" | "2018" | "ANTENA PAULISTA" | "25/10/2018" | "10012010" | "REPRISE"      | " "     | "1"           | "MUSICA DA MARCELLE" | "MUSICA COMERCIAL" | "MARCELLE MENDONCA,MARCELLE MENDONCA,SHAKIRA MEBARAK" | "DANIEL MUSY" | "40"     | "TA"          | ""           | "EMI SONGS,SOM E LUZ,A DESCOBRIR" | "RGE"     | "FULL MIX" | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT11
Esquema do Cenário: Gerar relatório ECAD com campo segundos superior a Zero.
    Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT12
Esquema do Cenário: Validar duplicidade de itens no relatório ECAD
    Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Entao gero um relatorio ECAD e verifico as informações <Programa>, <DataExibicao>, <Capitulo>, <NomedoEpisodio>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusica>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificacao>, <Compositores>, <Editora>, <Gravadora>, <Submix>, <NomePlanilha> estao sendo exibidas corretamente para o filtro <Mes>, <Ano> escolhidos

    Exemplos:
		| Tipo     | Mes       | Ano    | Programa      | DataExibicao | Capitulo | NomedoEpisodio | Diretor | OrdemExecucao | TitulodaObraMusica  | TipodeMusica         | Autor   | Interprete | Segundos | Classificacao | Compositores | Editora           | Gravadora | Submix | NomePlanilha           |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |
		| "Mensal" | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "            | " "     | "1"           | "NOVA MUSICA HELEN" | "BIBLIOTECA MUSICAL" | "TESTA" | "ANITTA"   | "10"     | "TM"          | " "          | "HELEN PRODUCOES" | " "       | " "    | "Planilha Mensal ECAD" |

@chrome	@RelatorioECADCT13
Esquema do Cenário: Fechar periodo mensal com periodo fechado do relatorio ECAD
    Quando realizo um fechamento mensal do relatório ECAD preenchendo o campo periodo <Mes>, <Ano> 
    Então visualizo a mensagem de fechamento em destaque <Mensagem>

    Exemplos:
        | Mes       | Ano    | Mensagem                                         |
        | "Outubro" | "2017" | "Já foi realizado fechamento para este período." |

@chrome	@RelatorioECADCT14
Esquema do Cenario: Gerar Novo relatório mensal ECAD em PDF
    Quando filtro um relatorio ECAD preenchendo o campo tipo e o periodo <Tipo>, <Mes> , <Ano>
	Então valido a tela apresentando o aquivo em PDF

	Exemplos:
		| Tipo     | Mes       | Ano    |
		| "Mensal" | "Outubro" | "2017" |

#Esquema do Cenario: Gerar Novo relatório Complemento ECAD em PDF
#    Quando realizo um relatorio ECAD preenchendo o campo <TipoComplemento> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações.
#
#    Exemplos:
#      | Programa      | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica     | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "NOVA NOVELA" | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL" | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Gerar fechamento de relatório ECAD Mensal
#    Quando realizo um relatório ECAD preenchendo o campo <TipoMensal> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações.
#
#    Exemplos:
#      | Programa      | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica     | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "NOVA NOVELA" | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL" | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Gerar fechamento de relatório ECAD Complemento
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações.
#
#    Exemplos:
#      | Programa      | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica     | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "NOVA NOVELA" | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL" | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Validar formato dos campos ordem alfabetica
#    Quando realizo um relatório ECAD preenchendo o campo <Tipo> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#      | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#      | "NOVA NOVELA"     | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL"   | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Fechar periodo Complemento com periodo fechado do relatorio ECAD
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Midia>.
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#      | Tipo           | Periodo           | Mensagem                                         |
#      | "Complemento>" | "Outubro de 2018" | "Já foi realizado fechamento para este período." |
