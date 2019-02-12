#language:pt
#Author: Rodrigo Magno
#Date: 11/02/2019

@kill_Driver @AlterarCamposGravadoraESubmix
Funcionalidade: 5.2.19 - Alterar campos Gravadora e Submix

Contexto: Acessar a tela de edição da cue-sheet e alteraros campos Gravador e Submix
      Dado que esteja logado no sistema SOM

@chrome @AlterarCamposGravadoraESubmixCT01
Esquema do Cenário: Editar item da cue-sheet que tenha uma obra com sucesso
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	Quando altero a Gravadora e o Submix do item da Cue-Sheet <Gravadora>, <Submix>
	Então visualizo a Gravadora do item atualizada na grid da Cue-Sheet <Gravadora>
	  
  Exemplos:
      | Gravadora   | Submix    |
      | "SOM LIVRE" | "FULLMIX" |
  

#Esquema do Cenário: Editar item da cue-sheet que tenha uma musica de transição com sucesso
#    Quando altero os campos <Gravadora> e <Submix> um item da cue-sheet que tenha um <Titulo> de Transição com todos os campos obrigatórios preenchidos
#    Então visualizo a <Mensagem>
#    E a tela de detalhes da cue-sheet com a coluna Gravadora atualizada
#
#    Exemplos:
#        | Gravadora   | Submix    | Titulo      | Mensagem                    |
#        | "SOM LIVRE" | "FULLMIX" | "BANG BANG" | "Item alterado com sucesso" |
#
#
#Esquema do Cenário: Cadastrar item na cue-sheet com obra totalmente preenchidos
#    Quando cadastro um item na cue-sheet com um <Titulo> que preencha todos os campos
#    E altero os campos <Gravadora> e <Submix>
#    Então visualizo a <Mensagem>
#    E a tela de detalhes da cue-sheet com a coluna Gravadora atualizada
#
#    Exemplos:
#        | Gravadora   | Submix    | Titulo      | Mensagem                      |
#        | "SOM LIVRE" | "FULLMIX" | "BANG BANG" | "Item cadastrado com sucesso" |
#
#
#Esquema do Cenário: Cadastrar item na cue-sheet com musica de transição preenchidos
#    Quando cadastro os campos <Gravadora> e <Submix> um item da cue-sheet que tenha um <Titulo> de Transição com todos os campos obrigatórios preenchidos
#    Então visualizo a <Mensagem>
#    E a tela de detalhes da cue-sheet com a coluna Gravadora atualizada
#
#    Exemplos:
#        | Gravadora   | Submix    | Titulo      | Mensagem                      |
#        | "SOM LIVRE" | "FULLMIX" | "BANG BANG" | "Item cadastrado com sucesso" |
#
#
#Esquema do Cenário: Validar que não é possivel cadastrar musica com Título em branco
#    Quando tento cadastrar um item na cue-sheet sem preencher o campo <Titulo>
#    Então visualizo o campo destacado para preenchimento
#
#    Exemplos:
#        | Gravadora   | Submix    | Titulo |
#        | "SOM LIVRE" | "FULLMIX" | ""     |
#
#
#Esquema do Cenário: Validar que não é possivel cadastrar musica com Autores em branco
#    Quando tento cadastrar um item na cue-sheet sem preencher o campo <Autor>
#    Então visualizo o campo destacado para preenchimento
#
#    Exemplos:
#        | Gravadora   | Submix    | Autor |
#        | "SOM LIVRE" | "FULLMIX" | ""    |
