#language: pt-BR
#Author: Larissa Silva
#Date: 09/02/2019
#Version: 1.0

@kill_Driver @RelatorioUBEM
Funcionalidade: 5.6.1 - Gerar Relatório UBEM
	Como um usuário com permissão "Gerar Relatório UBEM"
	Eu quero emitir um relatório em formato Excel conforme padrão
	De modo que reportar as utilizações de músicas nas produções da Globo à UBEM.

Critérios de aceite:
Sistema deverá ser capaz de reportar as utilizações de músicas nas produções da Globo à UBEM.

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
  Entao posso baixar o relatorio UBEM e verificar se as informacoes de <Programa>, <DataExibicao>, <Capitulo>, <Episodio>, <Genero>, <TituloDaMusica>, <TituloOriginal>, <Autor>, <DDA>, <PossuiDuplicidade>, <Sincronismo>, <Interpretes>, <Reprise>, <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao>, <Mes>, <Ano> escolhidos
    
  Exemplos:
      | Associacao | Mes       | Ano    | Programa          | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica | TituloOriginal | Autor          | DDA     | PossuiDuplicidade | Sincronismo | Interpretes    | Reprise | TituloRelatorio        |
      | "UBEM"     | "Outubro" | "2017" | "JORNAL NACIONAL" | "09/10/2017" | " "      | " "      | "JORNALISMO" | "NM SYNTH 2"   | "NM SYNTH 2"   | "SACHA AMBACK" | "SIGEM" | " "               | " "         | "SACHA AMBACK" | "NÃO"   | "Planilha Mensal UBEM" |
  
  @chrome	@RelatorioUBEMCT05
 Esquema do Cenario: Gerar relatório UBEM sem fechamento mensal
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao visualizo a mensagem de que não existe fechamento UBEM para o periodo selecionado <Mensagem>

    Exemplos:
        | Associacao | Mes        | Ano    | Mensagem                                            | 
        | "UBEM"     | "Dezembro" | "2018" | "Não existe fechamento para o período selecionado." |

 @chrome	@RelatorioUBEMCT06
Esquema do Cenario: Gerar relatório UBEM do tipo Associação todas sem fechamento mensal
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
      | Associacao | Mes        | Ano    | Programa     | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica           | TituloOriginal | Autor                  | DDA    | PossuiDuplicidade | Sincronismo | Interpretes                                             | Reprise | TituloRelatorio         |
      | "TODAS"    | "Novembro" | "2017" | "NOVO MUNDO" | "02/11/2017" | "700"    | " "      | "DRAMATURGIA DIÁRIA" | "CARIOCA PALACE THEME 2" | " "            | "RAFAEL LANGONI SMITH" | "DECK" | "NÃO"             | "FUNDO"     | "PEDRO EUGENIO ARAUJO,RAFAEL LANGONI SMITH,ROGERIO VAZ" | "NÃO"   | "Planilha Mensal TODAS" |

 @chrome	@RelatorioUBEMCT07
Esquema do Cenario: Gerar relatório UBEM do tipo Sem Associação sem fechamento mensal
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao       | Mes        | Ano    | Programa           | DataExibicao | Capitulo | Episodio | Genero              | TituloDaMusica          | TituloOriginal | Autor   | DDA             | PossuiDuplicidade | Sincronismo | Interpretes | Reprise | TituloRelatorio    |
	  | "SEM ASSOCIAÇÃO" | "Novembro" | "2017" | "TESTE VARIEDADES" | "05/11/2017" | "1"      | " "      | "VARIEDADE SEMANAL" | "MUSICA DE TESTE 5 INT" | " "            | "LUCCA" | "UNIVERSAL MGB" | "NÃO"             | "ADORNO"    | "ANITTA"    | "NÃO"   | "Planilha Mensal " |

 @chrome	@RelatorioUBEMCT08
Esquema do Cenario: Gerar Novo relatório UBEM Mensal tipo UBEM
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT09
Esquema do Cenario: Gerar Novo relatório UBEM Mensal tipo Sem Associação
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao       | Mes        | Ano    | Programa  | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica       | TituloOriginal | Autor               | DDA         | PossuiDuplicidade | Sincronismo | Interpretes | Reprise | TituloRelatorio    |
	  | "SEM ASSOCIAÇÃO" | "Novembro" | "2018" | "O CLONE" | "08/11/2018" | "44"     | " "      | "DRAMATURGIA DIÁRIA" | "MUSICA DA MARCELLE" | " "            | "MARCELLE MENDONCA" | "EMI SONGS" | "NÃO"             | "FUNDO"     | "INACIO"    | "NÃO"   | "Planilha Mensal " |

 @chrome	@RelatorioUBEMCT10
Esquema do Cenario: Gerar Novo relatório UBEM Mensal tipo Todos
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica          | TituloOriginal | Autor                          | DDA                             | PossuiDuplicidade | Sincronismo    | Interpretes | Reprise | TituloRelatorio         |
	  | "TODAS"    | "Janeiro" | "2019" | "AUTO_PROD_0" | "01/01/2019" | " "      | " "      | "JORNALISMO" | "TESTE DE CONHECIMENTO" | " "            | "CLAUDEMIR,DINEY,ROSANA SILVA" | "UNIVERSAL MGB,A DESCO,A DESCO" | "NÃO"             | "ENCERRAMENTO" | "ANA"       | "NÃO"   | "Planilha Mensal TODAS" |

 @chrome	@RelatorioUBEMCT11
Esquema do Cenario: Gerar Novo relatório UBEM Complemento UBEM
    Quando faco um filtro complemento para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT12
Esquema do Cenario: Gerar Novo relatório UBEM Complemento tipo Sem Associação
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao       | Mes        | Ano    | Programa  | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica       | TituloOriginal | Autor               | DDA         | PossuiDuplicidade | Sincronismo | Interpretes | Reprise | TituloRelatorio    |
	  | "SEM ASSOCIAÇÃO" | "Novembro" | "2018" | "O CLONE" | "08/11/2018" | "44"     | " "      | "DRAMATURGIA DIÁRIA" | "MUSICA DA MARCELLE" | " "            | "MARCELLE MENDONCA" | "EMI SONGS" | "NÃO"             | "FUNDO"     | "INACIO"    | "NÃO"   | "Planilha Mensal " |

 @chrome	@RelatorioUBEMCT13
Esquema do Cenario: Gerar Novo relatório UBEM Complemento tipo Todos
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica          | TituloOriginal | Autor                          | DDA                             | PossuiDuplicidade | Sincronismo    | Interpretes | Reprise | TituloRelatorio         |
	  | "TODAS"    | "Janeiro" | "2019" | "AUTO_PROD_0" | "01/01/2019" | " "      | " "      | "JORNALISMO" | "TESTE DE CONHECIMENTO" | " "            | "CLAUDEMIR,DINEY,ROSANA SILVA" | "UNIVERSAL MGB,A DESCO,A DESCO" | "NÃO"             | "ENCERRAMENTO" | "ANA"       | "NÃO"   | "Planilha Mensal TODAS" |

 @chrome	@RelatorioUBEMCT14
Esquema do Cenario: Gerar Novo relatório UBEM mensal com DDA em branco.
    Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT15
Esquema do Cenario: Gerar Novo relatório UBEM mensal com DDA associado.
    Quando faco um filtro para um periodo <Mes> <Ano> associacao <Associacao> e DDA
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT16
Esquema do Cenario: Gerar Novo relatório UBEM Complemento com DDA associado.
	Quando faco um filtro complemento para um periodo <Mes> <Ano> associacao <Associacao> e DDA
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT17
Esquema do Cenario: Gerar Novo relatório UBEM sem associação mensal com DDA
    Quando faco um filtro para um periodo sem associação <Mes> <Ano> associacao <Associacao> e DDA
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao       | Mes        | Ano    | Programa  | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica       | TituloOriginal | Autor               | DDA         | PossuiDuplicidade | Sincronismo | Interpretes | Reprise | TituloRelatorio    |
	  | "SEM ASSOCIAÇÃO" | "Novembro" | "2018" | "O CLONE" | "08/11/2018" | "44"     | " "      | "DRAMATURGIA DIÁRIA" | "MUSICA DA MARCELLE" | " "            | "MARCELLE MENDONCA" | "EMI SONGS" | "NÃO"             | "FUNDO"     | "INACIO"    | "NÃO"   | "Planilha Mensal " |

 @chrome	@RelatorioUBEMCT18
Esquema do Cenario: Gerar Novo relatório UBEM sem informar o periodo.
    Quando faco um filtro sem informar o periodo <Mes> <Ano>
    Então visualizo o campo Periodo em destaque para preenchimento

    Exemplos:
      | Mes | Ano |
      | " " | " " |

 @chrome	@RelatorioUBEMCT19
Esquema do Cenário: Validar histórico do relatorio UBEM
	Quando faco um filtro complemento para um periodo <Mes> <Ano> associacao <Associacao> e DDA
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos
	E valido o historico do reletorio UBEM

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT20
Esquema do Cenário: Validar filtro Produto no relatório UBEM mensal
	Quando faco um filtro para um periodo <Mes> <Ano> associacao <Associacao> e produto
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa          | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica | TituloOriginal | Autor                                                                         | DDA                                                          | PossuiDuplicidade | Sincronismo | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "JORNAL NACIONAL" | "15/10/2018" | "999"    | " "      | "JORNALISMO" | "BANG BANG"    | " "            | "MARCELLE MENDONCA,MAX MARTIN,MYRON BIRDSONG,RICKARD GORANSSON,SAVAN KOTECHA" | "SOM E LUZ,KOBALT MUSIC,SOM E LUZ,KOBALT MUSIC,KOBALT MUSIC" | "NÃO"             | "ADORNO"    | "ANITTA"    | "SIM"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT21
Esquema do Cenário: Validar filtro Produto no relatório UBEM Complemento
	Quando faco um filtro com complemento para um periodo <Mes> <Ano> associacao <Associacao> e produto
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa          | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica | TituloOriginal | Autor                                                                         | DDA                                                          | PossuiDuplicidade | Sincronismo | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "JORNAL NACIONAL" | "15/10/2018" | "999"    | " "      | "JORNALISMO" | "BANG BANG"    | " "            | "MARCELLE MENDONCA,MAX MARTIN,MYRON BIRDSONG,RICKARD GORANSSON,SAVAN KOTECHA" | "SOM E LUZ,KOBALT MUSIC,SOM E LUZ,KOBALT MUSIC,KOBALT MUSIC" | "NÃO"             | "ADORNO"    | "ANITTA"    | "SIM"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT22
Esquema do Cenário: Validar filtro Mídia com flag Sim no relatório UBEM mensal
	Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
	E seleciono a flag de sim
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT23
Esquema do Cenário: Validar filtro Mídia com flag Não no relatório UBEM mensal
	Quando faco um filtro para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT24
Esquema do Cenário: Validar filtro Mídia com flag Sim no relatório UBEM complemento
    Quando faco um filtro complemento para um periodo <Mes> <Ano> e associacao <Associacao>
	E seleciono a flag de sim
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT25
Esquema do Cenário: Validar filtro Mídia com flag Não no relatório UBEM complemento
    Quando faco um filtro complemento para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |

 @chrome	@RelatorioUBEMCT26
Esquema do Cenário: Validar duplicidade no relatorio UBEM
    Quando faco um filtro complemento para um periodo <Mes> <Ano> e associacao <Associacao>
    Entao gero o relatorio UBEM e verifica se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> <TituloRelatorio> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos

    Exemplos:
	  | Associacao | Mes       | Ano    | Programa      | DataExibicao | Capitulo | Episodio | Genero               | TituloDaMusica      | TituloOriginal | Autor   | DDA               | PossuiDuplicidade | Sincronismo                   | Interpretes | Reprise | TituloRelatorio        |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |
	  | "UBEM"     | "Outubro" | "2018" | "NOVA NOVELA" | "03/10/2018" | "2"      | " "      | "DRAMATURGIA DIÁRIA" | "NOVA MUSICA HELEN" | " "            | "TESTA" | "HELEN PRODUCOES" | "NÃO"             | "AO VIVO FUNDO EM JORNALISMO" | "ANITTA"    | "NÃO"   | "Planilha Mensal UBEM" |
