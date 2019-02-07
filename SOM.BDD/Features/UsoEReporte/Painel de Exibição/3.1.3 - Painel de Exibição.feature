#language: pt-BR
#Author: Larissa Silva
#Date: 05/02/2019
#Version: 1.0

@kill_Driver @UsoeReport @PaineldeExibicao
Funcionalidade: 3.1.3 - Painel de Exibição

Contexto: Acessar a tela de Edição de DDA
    Dado que esteja logado no sistema SOM
	E a tela de painel de exibição esteja aberta

@chrome @PaineldeExibicaoCT01
Cenario: Realizar busca no painel de Exibição sem informar periodo.
    Quando realizo uma busca com o campo periodo em branco
    Então visualizo o campo periodo em destaque para o preenchimento

@chrome @PaineldeExibicaoCT02
Cenario: Realizar busca no painel de Exibição sem informar Genero Direitos Musicais.
    Quando realizo uma busca no painel de exibição sem preencher o campo Genero Direitos Musicais
    Então visualizo o campo Genero Direitos Musicais destacado para preenchimento.

@chrome @PaineldeExibicaoCT03
Cenario: Realizar busca no painel de Exibição sem informar Midia.
    Quando realizo uma busca no painel de exibição sem preencher o campo Midia
    Então visualizo o campo Genero Midia destacado para preenchimento.

@chrome @PaineldeExibicaoCT04
Esquema do Cenario: Realizar busca no painel de Exibição com Genero Direitos Musicais DRAMATURGIA DIÁRIA.
    Quando realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano <GeneroDireitosMusicais>, <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Genero Direitos Musicais DRAMATURGIA DIÁRIA

    Exemplos:
      | GeneroDireitosMusicais | Midia | Periodo   | Ano    |
      | "DRAMATURGIA DIÁRIA"   | "TV"  | "outubro" | "2018" |

@chrome @PaineldeExibicaoCT05
Esquema do Cenario: Realizar busca no painel de Exibição com Genero Direitos Musicais DRAMATURGIA SEMANAL.
    Quando realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano <GeneroDireitosMusicais>, <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Genero Direitos Musicais DRAMATURGIA SEMANAL

    Exemplos:
      | GeneroDireitosMusicais | Midia       | Periodo   | Ano    |
      | "DRAMATURGIA SEMANAL"  | "GLOBONEWS" | "outubro" | "2018" |

@chrome @PaineldeExibicaoCT06
Esquema do Cenario: Realizar busca no painel de Exibição com Genero Direitos Musicais ESPORTE.
    Quando realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano <GeneroDireitosMusicais>, <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Genero Direitos Musicais ESPORTE

    Exemplos:
        | GeneroDireitosMusicais | Midia | Periodo     | Ano    |
        | "ESPORTE"              | "TV"  | "fevereiro" | "2019" |

@chrome @PaineldeExibicaoCT07
Esquema do Cenario: Realizar busca no painel de Exibição com Genero Direitos Musicais JORNALISMO.
    Quando realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano <GeneroDireitosMusicais>, <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Genero Direitos Musicais JORNALISMO

    Exemplos:
        | GeneroDireitosMusicais | Midia | Periodo   | Ano    |
        | "JORNALISMO"           | "TV"  | "Outubro" | "2018" |

@chrome @PaineldeExibicaoCT08
Esquema do Cenario: Realizar busca no painel de Exibição com Genero Direitos Musicais VARIEDADE DIÁRIA.
    Quando realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano <GeneroDireitosMusicais>, <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Genero Direitos Musicais VARIEDADE DIÁRIA

    Exemplos:
      | GeneroDireitosMusicais | Midia | Periodo   | Ano    |
      | "VARIEDADE DIÁRIA"     | "TV"  | "Outubro" | "2018" |

@chrome @PaineldeExibicaoCT09
Esquema do Cenario: Realizar busca no painel de Exibição com Genero Direitos Musicais VARIEDADE SEMANAL.
    Quando realizo uma busca no painel de exibição preenchendo os campos GeneroDireitosMusicais, Midia, Periodo e ano <GeneroDireitosMusicais>, <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Genero Direitos Musicais VARIEDADE SEMANAL

    Exemplos:
      | GeneroDireitosMusicais | Midia | Periodo | Ano    |
      | "VARIEDADE SEMANAL"    | "TV"  | "abril" | "2014" |

@chrome @PaineldeExibicaoCT10
Esquema do Cenario: Realizar busca no painel de Exibição com Mídia TV.
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa de Midia TV

    Exemplos:
      | Midia | Periodo   | Ano    |
      | "TV"  | "Outubro" | "2018" |

@chrome @PaineldeExibicaoCT11
Esquema do Cenario: Realizar busca no painel de Exibição com CANAL VIVA.
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
	Então visualiso o resultado da pesquisa do CANAL VIVA

    Exemplos:
      | Midia        | Periodo   | Ano    |
      | "CANAL VIVA" | "janeiro" | "2019" |

@chrome @PaineldeExibicaoCT12
Esquema do Cenario: Realizar busca no painel de Exibição com MULTSHOW.
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa do MULTSHOW

    Exemplos:
      | Midia      | Periodo     | Ano    |
      | "MULTSHOW" | "fevereiro" | "2019" |

@chrome @PaineldeExibicaoCT13
Esquema do Cenario: Realizar busca no painel de Exibição com GLOBOPLAY.
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa do GLOBOPLAY

    Exemplos:
      | Midia       | Periodo    | Ano    |
      | "GLOBOPLAY" | "setembro" | "2018" |

@chrome @PaineldeExibicaoCT14
Esquema do Cenario: Realizar busca no painel de Exibição com INTERNET.
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa da INTERNET

    Exemplos:
      | Midia      | Periodo | Ano    |
      | "INTERNET" | "junho" | "2018" |

@chrome @PaineldeExibicaoCT15
Esquema do Cenario: Validar a cor do status "FINALIZADA" da cue-sheet
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa com a cue-sheet FINALIZADA na cor azul

    Exemplos:
      | Midia      | Periodo | Ano    |
      | "INTERNET" | "junho" | "2018" |

@chrome @PaineldeExibicaoCT16
Esquema do Cenario: Validar a cor do status "PARCIALMENTE VALIDADA" da cue-sheet
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa com a cue-sheet PARCIALMENTE VALIDADA na cor amarela

    Exemplos:
      | Midia       | Periodo | Ano    |
      | "GLOBONEWS" | "julho" | "2018" |

@chrome @PaineldeExibicaoCT17
Esquema do Cenario: Validar a cor do status "VALIDADA" da cue-sheet
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa com a cue-sheet VALIDADA na cor Verde

    Exemplos:
      | Midia        | Periodo    | Ano    |
      | "CANAL VIVA" | "setembro" | "2018" |

@chrome @PaineldeExibicaoCT18
Esquema do Cenario: Validar a cor do status "EM ABERTO" da cue-sheet
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa com a cue-sheet EM ABERTO na cor CINZA 

    Exemplos:
      | Midia       | Periodo    | Ano    |
      | "GLOBOPLAY" | "setembro" | "2018" |

@chrome @PaineldeExibicaoCT19
Esquema do Cenario: Validar a cor do status "CRIADA" da cue-sheet
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa com a cue-sheet CRIADA na cor VERMELHO

    Exemplos:
      | Midia    | Periodo   | Ano    |
      | "SPORTV" | "outubro" | "2018" |

@chrome @PaineldeExibicaoCT20
Esquema do Cenario: Validar a cor do status "LIBERADA" da cue-sheet
    Quando realizo uma busca no painel de exibição preenchendo os campos Midia, Periodo e ano <Midia> , <Periodo> , <Ano>
    Então visualiso o resultado da pesquisa com a cue-sheet LIBERADA na cor LARANJA

    Exemplos:
      | Midia       | Periodo    | Ano    |
      | "GLOBONEWS" | "novembro" | "2018" |
