#language: pt-BR
#Author: Rodrigo Magno
#Date: 28/01/2019

@kill_Driver @Produto @AlteracaoDeProduto
Funcionalidade: 4.1.7 - Alteração de Produto

Como usuário com permissão para alterar produtos cadastrados
Quero poder alterar as informações de produto com uma mídia já cadastrada no sistema
Para utilzar esta informação no cadastro de uma cue-sheet associada ao produto

Contexto: Acessar a tela de Alteração por produto
    Dado que esteja logado no sistema SOM

@chrome @AlteracaoDeProdutoCCT01
Esquema do Cenário: Alterar Produto
	Dado que tenha um produto cadastrado no sistema sem possuir um capitulo relacionado
	Quando altero os dados desse produto <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
    Então visualizo os dados alterados com sucesso na tela do produto <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
	  
  Exemplos:
      | Nome        | Episodio    | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias   | CapituloObrigatorio |
      | "Aleatório" | "Aleatório" | "Minissérie"   | "ESPORTE"              | "4135" | "Sim"      | "Atividade" | "Não"          | "SPORTV" | "Não"               |
  
@chrome @AlteracaoDeProdutoCCT02
Esquema do Cenário: Alterar Produto com informações de outro produto previamente cadastrado
	Dado que tenha um produto cadastrado no sistema sem possuir um capitulo relacionado
	E que tenha cadastrado mais um produto no sistema
	Quando altero os dados desse produto para que possua os mesmos dados de um produto previamente cadastrado <Nome>, <Episodio>, <GeneroOriginal>, <GeneroDireitosMusicais>, <AR>, <GradeAtual>, <Midias>, <Atividade>, <AtualizaOrigem>, <CapituloObrigatorio>
    Então visualizo uma mensagem de erro informando que já existe um produto cadastrado com essas informações <Mensagem> 
	  
  Exemplos:
      | Nome        | Episodio    | GeneroOriginal | GeneroDireitosMusicais | AR     | GradeAtual | Atividade   | AtualizaOrigem | Midias   | CapituloObrigatorio | Mensagem                                                    |
      | "Aleatório" | "Aleatório" | "Minissérie"   | "ESPORTE"              | "4135" | "Sim"      | "Atividade" | "Não"          | "SPORTV" | "Não"               | "Existe um registro com esses dados cadastrado no sistema." |
  