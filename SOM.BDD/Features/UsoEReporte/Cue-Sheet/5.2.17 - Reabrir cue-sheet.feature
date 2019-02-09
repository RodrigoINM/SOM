#language:pt
#Author: Rodrigo Magno
#Date: 08/02/2019

@kill_Driver @ReabrirCueSheet
Funcionalidade: 5.2.17 - Reabrir cue-sheet

Contexto: Reabrir uma cue-sheet
    Dado que esteja logado no sistema SOM

@chrome @ReabrirCueSheetCT01
Esquema do Cenário: Reabrir Cue-sheet com status Liberada
	Dado que tenha uma obra cadastrada no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	Quando libero a cue-sheet
	E reabro a cue-sheet
	Então visualizo a mensagem de cues-cheet reaberta com sucesso <Mensagem>
	  
  Exemplos:
      | Mensagem                          | 
      | "Cue-sheet reaberta com sucesso!" | 
  
@chrome @ReabrirCueSheetCT02
Cenário: Reabrir Cue-sheet com status Em aberto
    Dado que tenha uma obra cadastrada no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que a cue-sheet esteja aberta
	Então visualizo apenas o botão para liberar a cue-sheet