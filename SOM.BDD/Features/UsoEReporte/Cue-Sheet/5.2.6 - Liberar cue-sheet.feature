#language:pt
#Author: Rodrigo Magno
#Date: 31/01/2019

@kill_Driver @CueSheet @LiberarCueSheet
Funcionalidade: 5.2.6 - Liberar a Cue-sheet

Contexto: Liberar a Cue-sheet
    Dado que esteja logado no sistema SOM

@chrome @LiberarCueSheetCT01
Esquema do Cenário: Liberar cue-sheet com sucesso
	Dado que tenha uma obra cadastrada no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	Quando libero a cue-sheet
	Então visualizo uma mensagem de cue-sheet liberada com sucesso <Mensagem>
      
  Exemplos:
      | Mensagem                                                                                                                | 
      | "Cue-sheet liberada com sucesso! Caso seja necessária alguma correção entre em contato com a área de Direitos Musicais" | 
  