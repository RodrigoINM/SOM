#language: pt-BR
#Author: Rodrigo Magno
#Date: 25/09/2018
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
  Entao posso baixar o relatorio UBEM e verificar se as informacoes de <Programa> <DataExibicao> <Capitulo> <Episodio> <Genero> <TituloDaMusica> <TituloOriginal> <Autor> <DDA> <PossuiDuplicidade> <Sincronismo> <Interpretes> <Reprise> estao sendo exibidas corretamente para a <Associacao> <Mes> <Ano> escolhidos
    
  Exemplos:
      | Associacao | Mes       | Ano    | Programa          | DataExibicao | Capitulo | Episodio | Genero       | TituloDaMusica | TituloOriginal | Autor          | DDA     | PossuiDuplicidade | Sincronismo | Interpretes    | Reprise | 
      | "UBEM"     | "Outubro" | "2017" | "JORNAL NACIONAL" | "09/10/2017" | " "      | " "      | "JORNALISMO" | "NM SYNTH 2"   | "NM SYNTH 2"   | "SACHA AMBACK" | "SIGEM" | " "               | " "         | "SACHA AMBACK" | "NÃO"   | 
  