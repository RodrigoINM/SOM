#language: pt-BR
#Author: Rodrigo Magno
#Date: 05/11/2018
#Version: 1.0

@kill_Driver @Produto @CadastroDeProduto
Funcionalidade: 4.1.6 - Cadastro de Produto

Contexto: Acessar a tela de Cadastro por produto
	Dado que esteja logado no sistema SOM
	E que esteja com a tela Cadastro de Produto aberta

@chrome @CadastroDeProdutoCT01
Esquema do Cenario: Cadastrar novo Produto
    Quando cadastro um novo Produto preenchendo os campos <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
    Então visualizo a <Mensagem> de cadastro de produto realizado com sucesso
	E visualizo os campos <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio> cadastrados no detalhe do produto
	  
  Exemplos:
      | Nome                    | Episodio                  | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                      |
      | "Titulo do Produto 500" | "Episodio do Produto 500" | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Registro salvo com sucesso." |
  
@chrome @CadastroDeProdutoCT02
Esquema do Cenario: Cadastrar Produto sem preenchimento de campo obrigatório
    Quando cadastro um Produto sem preenchimento dos campos <Nome>, <AR>, <GeneroDireitosMusicais>, <Atividade> ou <Midia>
	Entao visualizo os campos obrigatorios para cadastro de produto em destaque <Nome>, <AR>, <GeneroDireitosMusicais>, <Atividade> e <Midia>
	  
  Exemplos:
      | Nome | AR  | GeneroDireitosMusicais | Atividade | Midia |
      | " "  | " " | " "                    | " "       | " "   |
  
@chrome @CadastroDeProdutoCT03
Esquema do Cenario: Cancelar cadastro de Produto
    Quando cancelo o cadastro de um novo produto com todos os campos preenchidos <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
    Então visualizo a tela de busca de Produto
	
  Exemplos:
      | Nome                    | Episodio                  | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio |
      | "Titulo do Produto 501" | "Episodio do Produto 501" | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               |
  
@chrome @CadastroDeProdutoCT04
Esquema do Cenario: Cadastrar novo Produto com informações de outro produto previamente cadastrado
	Dado que tenha um produto cadastrado <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
    Quando tento cadastrar um novo Produto com as mesmas informações de um produto previamente cadastrado <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem> e <CapituloObrigatorio>
    Então visualizo a mensagem de que já existe um produto ativo cadastrado com esses dados <Nome>, <Mensagem>
	
  Exemplos:
      | Nome                    | Episodio                  | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias      | CapituloObrigatorio | Mensagem                                                    |
      | "Titulo do Produto 502" | "Episodio do Produto 502" | "Novela"       | "DRAMATURGIA SEMANAL"  | "4135" | "Sim"      | "Atividade" | "Não"          | "GLOBONEWS" | "Não"               | "Existe um registro com esses dados cadastrado no sistema." |
  