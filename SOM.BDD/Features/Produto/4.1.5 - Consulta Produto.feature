#language: pt-BR
#Author: Rodrigo Magno
#Date: 05/11/2018
#Version: 1.0

@kill_Driver @Produto @ConsultaDeProduto
Funcionalidade: 4.1.5 - Consulta Produto

Contexto: Acessar a tela de Busca por produto
	Dado que esteja logado no sistema SOM

@chrome	@ConsultaDeProdutoCT01
Esquema do Cenario: Busca Simples por produto Produto
	Dado que eu tenha um produto cadastrado <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
    Quando faço uma busca simples pelo produto
	Entao visualizo o produto no resultado da busca <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
	   
  Exemplos:
      | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                      |
      | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Registro salvo com sucesso." |
  
@chrome	@ConsultaDeProdutoCT02
Esquema do Cenario: Busca avançada por Nome do Produto
	Dado que eu tenha um produto cadastrado <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
	Quando faço uma busca avançada por Produto 
    Entao visualizo o produto no resultado da busca <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
	 
  Exemplos:
      | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                      |
      | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Registro salvo com sucesso." |
  
@chrome	@ConsultaDeProdutoCT03
Esquema do Cenario: Busca avançada por Episódio
	Dado que eu tenha um produto cadastrado <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
	Quando faço uma busca avançada por Produto e Episódio
    Entao visualizo o produto no resultado da busca <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
	 
  Exemplos:
      | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                      |
      | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Registro salvo com sucesso." |
  
@chrome	@ConsultaDeProdutoCT04
Esquema do Cenario: Busca avançada por Gênero Original
	Dado que eu tenha um produto cadastrado <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
	Quando faço uma busca avançada por Produto e Gênero Original <GeneroOriginal>
    Entao visualizo o produto no resultado da busca <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
	
  Exemplos:
      | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                      |
      | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Registro salvo com sucesso." |
  
@chrome	@ConsultaDeProdutoCT05
Esquema do Cenario: Busca avançada por Gênero Direitos Musicais
	Dado que eu tenha um produto cadastrado <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
    Quando faço uma busca avançada por Produto e Direitos Musicais <GeneroDireitosMusicais>
    Entao visualizo o produto no resultado da busca <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
	
  Exemplos:
      | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                      |
      | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Registro salvo com sucesso." |
  
@chrome	@ConsultaDeProdutoCT06
Esquema do Cenario: Busca por produtos não cadastrados
    Quando faço uma busca avançada por Produto 
    Então visualizo a <Mensagem> de dados nao encontrados na busca pelo produto informado
	  
  Exemplos:
      | Nome                  | Mensagem                |
      | "Produto Inexistente" | "Dados não encontratos" |
      | "Produto nome"        | "Dados não encontratos" |
  
@chrome	@ConsultaDeProdutoCT07
Esquema do Cenario: Busca por Produto e Episódios não associados
    Quando faço uma busca avançada por Produto e Episódio <Nome>, <Episodio>
    Então visualizo a <Mensagem> de dados nao encontrados na busca pelo produto informado
	  
  Exemplos:
      | Nome        | Episodio       | Mensagem                | 
      | "Teste INM" | "Episodio 120" | "Dados não encontratos" | 
  