#language:pt
#Author: Rodrigo Magno
#Date: 26/01/2019

@kill_Driver @BuscarCueSheet
Funcionalidade: 5.2.4 - Buscar Cue-sheet

Contexto: 
    Dado que esteja logado no sistema SOM
	E que esteja na tela de consulta de Cue-Sheet

@chrome @BuscarCueSheetCT01
Cenário: Buscar sem preencher o campo de busca com sucesso
    Quando faço uma busca rápida de Cue-Sheet sem preencher nenhum filtro
	Então visualizo as Cue-Sheets cadastradas no resultado da busca com sucesso

@chrome @BuscarCueSheetCT02
Esquema do Cenário: Buscar pelo filtro Produto com sucesso com sucesso
    Quando faço uma busca de Cue-Sheet por Produto <Produto>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | Midia       | Produto                               | Episodio         | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao | 
      | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062" | "Dorie159726722" | "1"      | "26/12/2018" | " "             | "1"      | "Validada" | "100%"    | 
  
@chrome @BuscarCueSheetCT03
Esquema do Cenário: Buscar avançado com filtro Produto e Episódio com sucesso
    Quando faço uma busca de Cue-Sheet por Produto e Episodio <Produto>, <Episodio>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | Midia       | Produto                               | Episodio         | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao | 
      | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062" | "Dorie159726722" | "1"      | "26/12/2018" | " "             | "1"      | "Validada" | "100%"    | 
  
@chrome @BuscarCueSheetCT04
Esquema do Cenário: Buscar pelos filtros Produto, Episodio e Capítulo com sucesso
    Quando faço uma busca de Cue-Sheet por Produto, Episodio e Capítulo <Produto>, <Episodio>, <Capitulo>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | Midia       | Produto                               | Episodio         | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao | 
      | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062" | "Dorie159726722" | "1"      | "26/12/2018" | " "             | "1"      | "Validada" | "100%"    | 
  
@chrome @BuscarCueSheetCT05
Esquema do Cenário: Buscar pelo filtro Mídia e Produto com sucesso
    Quando faço uma busca de Cue-Sheet por Mídia e Produto <Midia>, <Produto>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | Midia       | Produto                               | Episodio         | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao | 
      | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062" | "Dorie159726722" | "1"      | "26/12/2018" | " "             | "1"      | "Validada" | "100%"    | 
  
@chrome @BuscarCueSheetCT06
Esquema do Cenário: Buscar pelo filtro Data de Exibição Inicial e Produto com sucesso
    Quando faço uma busca de Cue-Sheet por Data de Exibição Inicial e Produto <DataExibicao>, <Produto>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | Midia       | Produto                               | Episodio         | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao | 
      | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062" | "Dorie159726722" | "1"      | "26/12/2018" | " "             | "1"      | "Validada" | "100%"    | 
  
@chrome @BuscarCueSheetCT07
Esquema do Cenário: Buscar avançado com filtro Data de Exibição Final e Produto com sucesso
    Quando faço uma busca de Cue-Sheet por Data de Exibição Final e Produto <DataExibicao>, <Produto>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | Midia       | Produto                               | Episodio         | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao | 
      | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062" | "Dorie159726722" | "1"      | "26/12/2018" | " "             | "1"      | "Validada" | "100%"    | 
  
@chrome @BuscarCueSheetCT08
Esquema do Cenário: Buscar pelo filtro Status
    Quando faço uma busca de Cue-Sheet por Status, Produto e Episodio <FiltroStatus>, <Produto>, <Episodio>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | FiltroStatus            | Midia       | Produto                                | Episodio            | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status                  | Aprovacao |
      | "Validada"              | "GLOBONEWS" | "Roxanne363758581 Amoriello632419062"  | "Dorie159726722"    | "1"      | "26/12/2018" | " "             | "1"      | "Validada"              | "100%"    |
      | "Em aberto"             | "GLOBONEWS" | "Heidy1354618437 Strazzullo1756282572" | "Tad347951632"      | "1"      | "11/11/2018" | " "             | "2"      | "Em Aberto"             | "0%"      |
      | "Liberada"              | "TV"        | "MISTER BRAU"                          | "A VOLTA DE ROSITA" | "1"      | "13/06/2017" | " "             | "37"     | "Liberada"              | "0%"      |
      | "Parcialmente Validada" | "TV"        | "TESTE ESPORTE OU JORNALISMO"          | "TESTE"             | "3"      | "06/11/2020" | " "             | "20"     | "Parcialmente Validada" | "15%"     |
      | "Criada"                | "GLOBONEWS" | "Linn510024834 Pomerance1333079357"    | "Glen675215125"     | "01"     | "11/11/2018" | " "             | "0"      | "Criada"                | "0%"      |
      | "Finalizada"            | "TV"        | "O ALBUM DA GRANDE FAMILIA"            | "A GRANDE GENTALIA" | "1"      | "04/04/2017" | " "             | "11"     | "Finalizada"            | "100%"    |
  
@chrome @BuscarCueSheetCT09
Esquema do Cenário: Buscar por cue-sheets sem reprises ou rebatidas com sucesso
    Quando faço uma busca de Cue-Sheet por Reprise/Rebatida <FiltroRepriseRebatida>, <Produto>, <Episodio>
	Então visualizo os dados da Cue-Sheet no resultado da busca <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao>
	  
  Exemplos:
      | FiltroRepriseRebatida | Midia       | Produto                       | Episodio               | Capitulo   | DataExibicao | RepriseRebatida | QtdItens | Status       | Aprovacao |
      | "Não"                 | "TV"        | "MISTER BRAU"                 | "A MAE DO BRAU"        | "1"        | "09/05/2017" | " "             | "37"     | "Finalizada" | "100%"    |
      | "Reprise"             | "TV"        | "TESTE ESPORTE OU JORNALISMO" | "TESTE"                | "1"        | "12/11/2018" | "Reprise - 0"   | "1"      | "Validada"   | "100%"    |
      | "Rebatida"            | "GLOBONEWS" | "ROBERTO D AVILA"             | "LUIS ROBERTO BARROSO" | "280617R5" | "02/07/2017" | "Rebatida - 1"  | "5"      | "Em Aberto"  | "0%"      |
   
@chrome @BuscarCueSheetCT10
Esquema do Cenário: Buscar por dados não associados
	Quando faço uma busca de Cue-Sheet por Produto e Data de Exibição não associados entre si <Produto>, <DataExibicao>
	Entao visualizo a mensagem de que não foram encontradas Cue-Sheets com os dados informados na busca <Mensagem>
	  
  Exemplos:
      | Produto                               | DataExibicao | Mensagem                |
      | "Roxanne363758581 Amoriello632419062" | "01/01/2019" | "Dados não encontratos" |
  
@chrome @BuscarCueSheetCT11
Esquema do Cenário: Buscar pelos filtro Episódio sem Produto
      Quando faço uma busca de Cue-Sheet por Episódio sem informar o Produto <Episodio>
	  Então visualizo que o campo Episódio é limpo automaticamente ao clicar em pesquisar
	    
  Exemplos:
      | Episodio | 
      | "TESTE"  | 
  
#Esquema do Cenário: Buscar pelo filtro Obras e Fonograma com sucesso
#    Quando faço uma busca por <ObraFonogramaDesejado>
#    Então visualizo a tela de busca por obra para seleção
#    E a grid com os campos <Midia>, <Produto>, <Episodio>, <Capitulo>, <DataExibicao>, <RepriseRebatida>, <QtdItens>, <Status>, <Aprovacao> preenchidos com o resultados da busca por Obra ou Fonograma
#
#    Exemplos:
#        | ObraFonogramaDesejado | Midia | Produto           | Episodio | Capitulo | DataExibicao | RepriseRebatida | QtdItens | Status     | Aprovacao |
#        | "Teste INM"           | "TV"  | "JORNAL NACIONAL" | "1"      | "12"     | "12-03-2018" | "Rebatida"      | "10"     | "Validada" | "100%"    |
#
#