#language:pt
#Author: Rodrigo Magno
#Date: 29/01/2019

@kill_Driver @Template @AlteracaoDeTemplateDeProduto
Funcionalidade: 4.1.10 - Alteração de Templates

Como usuário com permissão "Produto | Alterar"
Quero poder atualizar as informações de produto com uma mídia já cadastrada no sistema
Para utilizar esta informação no cadastro de uma cue-sheet associada ao produto

Contexto: 
    Dado que esteja logado no sistema SOM

@chrome @AlteracaoDeTemplateDeProdutoCT01
Esquema do Cenário: Alterar Template
	Dado que tenha um produto com template cadastrado
	Quando altero os dados do template <Titulo>
	Então visualizo a mensagem de alteração realizada com sucesso no template <Mensagem>
	  
  Exemplos:
      | Titulo            | Mensagem                                |
      | "TESTE INMETRICS" | "Item Template cadastrado com sucesso." |
  
@chrome @AlteracaoDeTemplateDeProdutoCT02
Esquema do Cenário: Alterar Template com informações de outro template previamente cadastrado
	Dado que tenha um produto com template cadastrado
	Quando cadastro um novo item de template para o produto <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
	E altero o item informando os mesmos dados do item de template previamente cadastrado <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
	Então visualizo a mensagem de alteração realizada com sucesso no template <Mensagem>

  Exemplos:
      | Ordem | Titulo            | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao | Mensagem                                |
      | "1"   | "TESTE INMETRICS" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    | "Item Template cadastrado com sucesso." |

@chrome @AlteracaoDeTemplateDeProdutoCT03
Cenário: Cancelar Alteração em item de template
	Dado que tenha um produto com template cadastrado
	Quando cancelo a alteração de um item do template 
	Então volto a visualizar o item previamente cadastrado sem alteração


@chrome @AlteracaoDeTemplateDeProdutoCT04
Cenário: Inclusão de item de template em bloco já criado
	Dado que tenho um produto cadastrado
	Então Cadastro um item em um bloco já criado

@chrome @AlteracaoDeTemplateDeProdutoCT05
Cenário: Inclusão de item de template em Matéria já criada
    Dado que tenho um produto cadastrado
	Então Cadastro um item em uma materia já criado

@chrome @AlteracaoDeTemplateDeProdutoCT06
Cenário: Retirar o item de template do bloco
    Dado que tenho um produto cadastrado
	E Cadastro um item em um bloco
	Então seleciono o bloco para ser excluido

