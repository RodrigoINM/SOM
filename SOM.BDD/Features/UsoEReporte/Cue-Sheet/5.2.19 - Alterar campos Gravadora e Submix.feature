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
  
@chrome @AlterarCamposGravadoraESubmixCT02
Esquema do Cenário: Cadastrar item na cue-sheet com obra totalmente preenchidos
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	Quando altero a Gravadora e o Submix do item da Cue-Sheet <Gravadora>, <Submix>
	Então visualizo a Gravadora do item atualizada na grid da Cue-Sheet <Gravadora>
	  
  Exemplos:
      | Gravadora   | Submix    |
      | "SOM LIVRE" | "FULLMIX" |

@chrome @AlterarCamposGravadoraESubmixCT03
Esquema do Cenário: Validar que não é possivel cadastrar musica com Título em branco
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando tento cadastrar um item de Cue-Sheet sem preencher o titulo da musica <Titulo>, <Gravadora>, <Submix>
	Então visualizo o campo de Título da obra em destaque

  Exemplos:
      | Titulo | Gravadora   | Submix    |
      | " "    | "SOM LIVRE" | "FULLMIX" |

@chrome @AlterarCamposGravadoraESubmixCT04
Esquema do Cenário: Editar item da cue-sheet que tenha uma musica de transição com sucesso
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item de Cue-Sheet cadastrado com Musica de transição <Titulo>
	Quando altero a Gravadora e o Submix do item da Cue-Sheet <Gravadora>, <Submix>
	Então visualizo a Gravadora do item atualizada na grid da Cue-Sheet <Gravadora>
	  
  Exemplos:
      | Titulo      | Gravadora   | Submix    |
      | "Aleatório" | "SOM LIVRE" | "FULLMIX" |

@chrome @AlterarCamposGravadoraESubmixCT05
Esquema do Cenário: Cadastrar item na cue-sheet com musica de transição preenchidos
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item de Cue-Sheet cadastrado com Musica de transição <Titulo>
	Quando altero a Gravadora e o Submix do item da Cue-Sheet <Gravadora>, <Submix>
	Então visualizo a Gravadora do item atualizada na grid da Cue-Sheet <Gravadora>
	  
  Exemplos:
      | Titulo      | Gravadora   | Submix    |
      | "Aleatório" | "SOM LIVRE" | "FULLMIX" |

@chrome @AlterarCamposGravadoraESubmixCT06
Cenário: Validar que não é possivel cadastrar musica com Autores em branco
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	Quando tento cadastrar uma Musica de transição sem informar o Titulo
	Então visualizo o campo de Titulo em destaque