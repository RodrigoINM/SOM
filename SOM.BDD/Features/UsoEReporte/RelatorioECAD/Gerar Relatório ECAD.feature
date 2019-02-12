#language: pt-BR
#Author: Larissa Silva
#Date: 09/02/2019
#Version: 1.0

@kill_Driver @RelatorioUBEM
Funcionalidade: 5.6.1 - Gerar Relatório ECAD
exto: Acessar sistema SOM
	Dado que esteja logado no sistema SOM
	E que esteja na tela de Relatorio ECAD esteja aberta
#
#Esquema do Cenario: Gerar relatório ECAD sem fechamento mensal
#    Quando realizo um relatorio ECAD preenchendo o campo <Tipo> e <Periodo>
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Tipo     | Periodo            | Mensagem                                            |
#        | "Mensal" | "Dezembro de 2019" | "Não existe fechamento para o periodo selecionado." |
#
#
#Esquema do Cenario: Gerar Novo relatório mensal ECAD em PDF
#    Quando realizo um relatorio ECAD preenchendo o campo <TipoMensal> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações.
#
#    Exemplos:
#      | Programa      | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica     | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "NOVA NOVELA" | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL" | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#
#Esquema do Cenário: Gerar Novo relatório mensal ECAD em Excel
#    Quando realizo um relatório ECAD preenchendo o campo <TipoMensal> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações.
#
#    Exemplos:
#      | Programa      | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica     | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "NOVA NOVELA" | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL" | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenario: Gerar Novo relatório Complemento ECAD em PDF
#    Quando realizo um relatorio ECAD preenchendo o campo <TipoComplemento> e <Periodo>
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações.
#
#    Exemplos:
#      | Programa      | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica     | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "NOVA NOVELA" | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL" | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenario: Gerar Novo relatório Complemento ECAD em Excel
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
#Esquema do Cenário: Gerar relatório ECAD mensal pelo filtro Produto.
#    Quando realizo um relatório ECAD preenchendo o campo <TipoMensal>, <Periodo> e <Produto>.
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#      | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Gerar relatório ECAD Complemento pelo filtro Produto.
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Produto>.
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#      | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Validar histórico do relatorio ECAD
#    Quando valido o <Historico>
#    Então visualizo a grid com os campos <Campo> e <NovoValor>.
#
#    Exemplos:
#      | Campo     | NovoValor |
#      | "Período" | "09/2018" |
#
#
#Esquema do Cenário: Gerar relatório ECAD mensal pelo filtro mídia.
#    Quando realizo um relatório ECAD preenchendo o campo <TipoMensal>, <Periodo> e <Midia>.
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#        | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#        | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Gerar relatório ECAD Complemento pelo filtro mídia.
#      Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Midia>.
#      Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#      Exemplos:
#        | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#        | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Gerar relatório ECAD Mensal pelo filtro DDA.
#    Quando realizo um relatório ECAD preenchendo o campo <TipoMensal>, <Periodo> e <Midia>.
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#      | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Gerar relatório ECAD Complemento pelo filtro DDA.
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Midia>.
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#      | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#
#Esquema do Cenário: Gerar relatório ECAD com campo segundos superior a Zero.
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Midia>.
#    Então valido o campo <Segundos> com valor superior a zero.
#
#    Exemplos:
#      | Segundos |
#      | " 1 "    |
#
#
#Esquema do Cenário: Validar duplicidade de itens no relatório ECAD
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Midia>.
#    Então visualizo o relatório com o os campos <Programa>, <DataExibicao>, <HorariodeExibicao>, <Capitulo>, <Temporada>, <NomedoEpisodio>, <Produtor>, <Diretor>, <OrdemExecucao>, <TitulodaObraMusical>, <TipodeMusica>, <Autor>, <Interprete>, <Segundos>, <Classificação>, <CompositorTrilha>, <Editora>, <Gravadora>, <ISRC> e <Submix> com todas as informações em ordem alfabetica.
#
#    Exemplos:
#      | Programa          | DataExibicao | HorariodeExibicao | Capitulo | Temporada | NomedoEpisodio | Produtor | Diretor | OrdemExecucao | TitulodaObraMusical | TipodeMusica       | Autor            | Interprete | Segundos | Classificação | CompositorTrilha | Editora | Gravadora | ISRC | Submix |
#      | "JORNAL NACIONAL" | "02/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "PROBLEMA SEU"      | "MUSICA COMERCIAL" | "CARLOS EDUARDO" | "ANITTA"   | "10"     | ""            | ""               | "DUBAS" | ""        | ""   | ""     |
#      | "NOVA NOVELA"     | "03/09/2018" | ""                | "9"      | ""        | ""             | ""       | ""      | "1"           | "DOMITILA"          | "TRILHA MUSICAL"   | "RAFAEL LANGONI" | "ANITTA"   | "10"     | ""            | ""               | "SIGEM" | ""        | ""   | ""     |
#
#
#Esquema do Cenário: Fechar periodo mensal com periodo fechado do relatorio ECAD
#    Quando realizo um relatório ECAD preenchendo o campo <TipoMensal>, <Periodo> e <Midia>.
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#        | Tipo     | Periodo           | Mensagem                                         |
#        | "Mensal" | "Outubro de 2018" | "Já foi realizado fechamento para este período." |
#
#
#Esquema do Cenário: Fechar periodo Complemento com periodo fechado do relatorio ECAD
#    Quando realizo um relatório ECAD preenchendo o campo <TipoComplemento>, <Periodo> e <Midia>.
#    Então visualizo a <Mensagem>
#
#    Exemplos:
#      | Tipo           | Periodo           | Mensagem                                         |
#      | "Complemento>" | "Outubro de 2018" | "Já foi realizado fechamento para este período." |
