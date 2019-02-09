#language: pt-BR
#Author: Rodrigo Magno
#Date: 25/09/2018
#Version: 1.0

@kill_Driver @RelatorioUBEM
Funcionalidade: 5.6.1 - Gerar Relatório UBEM
	Como um usuário com permissão "Gerar Relatório UBEM"
	Eu quero emitir um relatório em formato Excel conforme padrão
	De modo que reportar as utilizações de músicas nas produções da Globo à UBEM.

Contexto: Acessar sistema SOM
	Dado que esteja logado no sistema SOM
	E que esteja na tela de Relatorio Ubem
	E que possua um periodo que tenha sido fechado

@chrome	@RelatorioUBEMCT01
Esquema do Cenário: Gerar download sem fechamento mensal relatório UBEM
	Quando faco um filtro para um periodo <Mes> <Ano> que ainda nao possua fechamento
	Entao visualizo a mensagem de que não existe fechamento UBEM para o periodo selecionado <Mensagem>
    
	Exemplos: 
      | Mes        | Ano    | Mensagem                                            | 
      | "Dezembro" | "2018" | "Não existe fechamento para o período selecionado." | 
  
@chrome	@RelatorioUBEMCT02
Esquema do Cenário: Consultar relatório de fechamento UBEM
	Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
	Entao visualizo o link de download do relatorio de fechamento UBEM com sucesso <Associacao> <Mes> <Ano>
    
	Exemplos:
      | Associacao       | Mes       | Ano    | 
      | "UBEM"           | "Outubro" | "2017" | 
  
@chrome	@RelatorioUBEMCT03
Esquema do Cenário: Gerar download relatório UBEM
	Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
	Entao realizo o download do relatorio UBEM com sucesso para a <Associacao> <Mes> <Ano> escolhidos
    
	Exemplos:
      | Associacao       | Mes       | Ano    | 
      | "UBEM"           | "Outubro" | "2017" | 
      | "SEM ASSOCIAÇÃO" | "Outubro" | "2017" | 
      | "TODAS"          | "Outubro" | "2017" | 
  
@chrome	@RelatorioUBEMCT04
Esquema do Cenário: Validar as informações do relatório UBEM
	Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
	Entao posso baixar o relatorio UBEM e verificar se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos
    
	Exemplos:
      | Associacao | Mes       | Ano    | Programa          | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica | TituloOriginal | Autor          | DDA     | PossuiDuplicidade | Sincronismo | Interpretes    | Reprise | TituloPlanilha         |
      | "UBEM"     | "Outubro" | "2017" | "JORNAL NACIONAL" | "09/10/2017" | " "      | " "      | "JORNALISMO" | "NM SYNTH 2"   | "NM SYNTH 2"   | "SACHA AMBACK" | "SIGEM" | " "               | " "         | "SACHA AMBACK" | "NÃO"   | "Planilha Mensal UBEM" |
  
@chrome	@RelatorioUBEMCT05
Esquema do Cenario: Gerar relatório UBEM sem fechamento mensal
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao visualizo a mensagem de que não existe fechamento UBEM para o periodo selecionado <Mensagem>

	Exemplos: 
      | Associacao | Mes         | Ano    | Mensagem                                            |
      | "UBEM"     | "Fevereiro" | "2019" | "Não existe fechamento para o período selecionado." | 

@chrome	@RelatorioUBEMCT06
Esquema do Cenario: Gerar relatório UBEM do tipo Sem Associação sem fechamento mensal
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

	Exemplos: 
      | Associacao       | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor               | DDA         | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha    |
      | "SEM ASSOCIAÇÃO" | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "09/10/2017" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA" | "EMI SONGS" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal" |

@chrome	@RelatorioUBEMCT07
Esquema do Cenario: Gerar Novo relatório UBEM Mensal tipo UBEM
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
	Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

	Exemplos: 
      | Associacao | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor                               | DDA                 | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha         |
      | "UBEM"     | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "23/01/2019" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA,SHAKIRA MEBARAK" | "SOM E LUZ,A DESCO" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal UBEM" |

@chrome	@RelatorioUBEMCT08
Esquema do Cenario: Gerar Novo relatório UBEM Mensal tipo Sem Associação
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

	Exemplos: 
      | Associacao       | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor               | DDA         | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha    |
      | "SEM ASSOCIAÇÃO" | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "09/10/2017" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA" | "EMI SONGS" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal" |

@chrome	@RelatorioUBEMCT09
Esquema do Cenario: Gerar Novo relatório UBEM Mensal tipo Todos
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
      | Associacao | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor                                                 | DDA                           | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha          |
      | "TODAS"    | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "23/01/2019" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA,MARCELLE MENDONCA,SHAKIRA MEBARAK" | "EMI SONGS,SOM E LUZ,A DESCO" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal TODAS" |

@chrome	@RelatorioUBEMCT10
Esquema do Cenario: Gerar Novo relatório UBEM Complemento UBEM
	Quando faco um filtro para um periodo complemento <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos: 
      | Associacao | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor                               | DDA                 | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha         |
      | "UBEM"     | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "23/01/2019" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA,SHAKIRA MEBARAK" | "SOM E LUZ,A DESCO" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal UBEM" |

@chrome	@RelatorioUBEMCT11
Esquema do Cenario: Gerar Novo relatório UBEM Complemento tipo Sem Associação
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

	Exemplos: 
      | Associacao       | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor               | DDA         | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha    |
      | "SEM ASSOCIAÇÃO" | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "09/10/2017" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA" | "EMI SONGS" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal" |

@chrome	@RelatorioUBEMCT12
Esquema do Cenario: Gerar Novo relatório UBEM Complemento tipo Todos
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
      | Associacao | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor                                                 | DDA                           | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha          |
      | "TODAS"    | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "23/01/2019" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA,MARCELLE MENDONCA,SHAKIRA MEBARAK" | "EMI SONGS,SOM E LUZ,A DESCO" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal TODAS" |

#@chrome	@RelatorioUBEMCT13
#Esquema do Cenario: Gerar Fechamento de relatório UBEM mensal tipo UBEM
#    Dado que tenha um periodo sem fechamento na tela "Relatório UBEM"
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa     | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "NOVO MUNDO" | "07/06/2018"     | "888"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |


#Esquema do Cenario: Gerar Fechamento de relatório UBEM Mensal tipo Sem Associação
#    Dado que tenha um periodo sem fechamento na tela "Relatório UBEM"
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenario: Gerar Fechamento de relatório UBEM Mensal tipo Todos
#    Dado que tenha um periodo sem fechamento na tela "Relatório UBEM"
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste01"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |

@chrome	@RelatorioUBEMCT13
Esquema do Cenario: Gerar Novo relatório UBEM mensal com DDA sem obras.
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao visualizo a mensagem de que não existe fechamento UBEM para o periodo selecionado <Mensagem>

	Exemplos: 
      | Associacao | Mes         | Ano    | Mensagem                                            |
      | "UBEM"     | "Fevereiro" | "2019" | "Não existe fechamento para o período selecionado." |

@chrome	@RelatorioUBEMCT14
Esquema do Cenario: Gerar Novo relatório UBEM mensal com DDA associado.
    Quando faco um filtro para um periodo <Mes> <Ano> , associacao <Associacao> e DDA
    Entao gero o relatorio e verifico se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloPlanilha> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

	 Exemplos:  
      | Associacao | Mes       | Ano    | Programa             | DataExibicao | Capitulo | Episodio | Genero                | TituloDaMusica       | TituloOriginal       | Autor                               | DDA                 | PossuiDuplicidade | Sincronismo      | Interpretes   | Reprise | TituloPlanilha         |
      | "UBEM"     | "Janeiro" | "2019" | "NOVELA TESTE CVC02" | "23/01/2019" | " "      | " "      | "DRAMATURGIA SEMANAL" | "MUSICA DA MARCELLE" | "MUSICA DA MARCELLE" | "MARCELLE MENDONCA,SHAKIRA MEBARAK" | "SOM E LUZ,A DESCO" | "NÃO"             | "AO VIVO ADORNO" | "DANIEL MUSY" | "NÃO"   | "Planilha Mensal UBEM" |



#Esquema do Cenario: Gerar Novo relatório UBEM Complemento com DDA associado.
#    Quando faco um filtro para um periodo complemento <Mes> <Ano> e associacao <Associacao>
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoComplemento> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste03"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenario: Gerar Novo relatório UBEM sem associação mensal com DDA
#    Dado que tenha um periodo sem fechamento na tela "Relatório UBEM"
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste67"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenario: Gerar Novo relatório UBEM sem informar o periodo.
#    Dado que tenha um periodo sem fechamento na tela "Relatório UBEM"
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao> e <TipoMensal>.
#    Então visualizo o campo <Periodo> em destaque para preenchimento.
#
#    Exemplos:
#      | TipoAssociacao | TipoComplemento | Periodo |
#      | "UBEM"         | "Mensal"        | ""      |
#
#
#Esquema do Cenário: Validar histórico do relatorio UBEM
#    Quando valido o <Historico>
#    Então visualizo a grid com os campos <Campo> e <NovoValor>.
#
#    Exemplos:
#      | Campo     | NovoValor |
#      | "Período" | "09/2018" |
#
#
#Esquema do Cenário: Validar filtro Produto no relatório UBEM mensal
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao  | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste55"  | "07/06/2018"  | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar filtro Produto no relatório UBEM Complemento
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoComplemento> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao  | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste17"  | "07/06/2018"  | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar filtro Mídia com flag Sim no relatório UBEM mensal
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal>, <Periodo> e <FlagSim>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <Midia>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste78"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar filtro Mídia com flag Não no relatório UBEM mensal
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal>, <Periodo> e <FlagNao>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao     | Capitulo | Episodio | Genero               | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste001" | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar filtro Mídia com flag Sim no relatório UBEM complemento
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal>, <Periodo> e <FlagSim>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa       | DataExibicao     | Capitulo | Episodio | Genero               | Midia        | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "TesteSimples" | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar filtro Mídia com flag Não no relatório UBEM complemento
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal>, <Periodo> e <FlagNao>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa     | DataExibicao     | Capitulo | Episodio | Genero               | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "TesteNovo"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar duplicidade no relatorio UBEM
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa   | DataExibicao     | Capitulo | Episodio | Genero               | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste67"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#      | "Teste67"  | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#
#
#Esquema do Cenário: Validar Ordem alfabetica no relatorio UBEM
#    Quando realizo um relatorio UBEM preenchendo o campo <TipoAssociacao>, <TipoMensal> e <Periodo>
#    Então visualizo a planilha com os campos <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <TitulodaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDucplicidade>, <Sincronismo>, <Interprete> e <Reprise> com todos os comapos preenchidos.
#
#    Exemplos:
#      | Programa     | DataExibicao     | Capitulo | Episodio | Genero               | TitulodaMusica | TituloOriginal | Autor      | DDA         | PossuiDucplicidade | Sincronismo | Interprete         | Reprise |
#      | "Teste67"    | "07/06/2018"     | "821"    | ""       | "DRAMATURGIA DIÁRIA" | "DARWIN"       | "DARWIN"       | "MARCELLE" | "SOM E LUZ" | "NÃO"              | "FUNDO"     | "MARION LEMONNIER" | "NÃO"   |
#      | "NOVO MUNDO" | "07/06/2018"     | "888"    | ""       | "DRAMATURGIA DIÁRIA" | "CANAL VIVA"   | "DARWIN"       | "DARWIN"   | "MARCELLE"  | "SOM E LUZ"        | "NÃO"       | "FUNDO"            |"NÃO"   |
