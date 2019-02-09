#language:pt
#Author: Rodrigo Magno
#Date: 09/02/2019

@kill_Driver @AlteracaoDePedidoPorCueSheet
Funcionalidade: 5.2.22 - Implementar CT de alteração de pedido na cue-sheet

Contexto: Implementar CT de alteração de pedido na cue-sheet
        Dado que esteja logado no sistema SOM

@chrome @AlteracaoDePedidoPorCueSheetCT01
Cenário: Validar cancelamento de item de Pedido após mudança de título na cue-sheet
# Nome antigo do CT: Título - Pedido em andamento
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha acessado os detalhes do pedido gerado na Cue-Sheet
	Quando volto para a tela da Cue-Sheet e altero o titulo da obra do item da Cue-Sheet
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior foi cancelado com sucesso

@chrome @AlteracaoDePedidoPorCueSheetCT02
Cenário: Validar cancelamento de item de Pedido após mudança de Sincronismo Globo na cue-sheet
# Nome antigo do CT: Sincronismo Globo - Pedido em andamento
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha acessado os detalhes do pedido gerado na Cue-Sheet
	Quando volto para a tela da Cue-Sheet e altero o sincronismo do item da Cue-Sheet
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior foi cancelado com sucesso

@chrome @AlteracaoDePedidoPorCueSheetCT03
Cenário: Validar cancelamento de item de Pedido após mudança de Reprise na cue-sheet
# Nome antigo do CT: Reprise - Pedido em andamento
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha acessado os detalhes do pedido gerado na Cue-Sheet
	Quando volto para a tela da Cue-Sheet e altero o item da Cue-Sheet para Reprise
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior foi cancelado com sucesso

@chrome @AlteracaoDePedidoPorCueSheetCT04
Cenário: Validar cancelamento de item de Pedido após mudança de Fair Use na cue-sheet
# Nome antigo do CT: Fair Use - Pedido em andamento
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto do tipo Jornalismo cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha acessado os detalhes do pedido gerado na Cue-Sheet
	Quando volto para a tela da Cue-Sheet e altero o item da Cue-Sheet para Fair Use
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior foi cancelado com sucesso

@chrome @AlteracaoDePedidoPorCueSheetCT05
Cenário: Exclusão do item de cue-sheet
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto do tipo Jornalismo cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha acessado os detalhes do pedido gerado na Cue-Sheet
	Quando volto para a tela da Cue-Sheet e excluo o item da Cue-Sheet
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior foi cancelado com sucesso

@chrome @AlteracaoDePedidoPorCueSheetCT06
Cenário: Excluir, aprovar e Gerar pedido com sucesso
# Nome antigo do CT: Exclusão do item de cue-sheet 2
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha acessado os detalhes do pedido gerado na Cue-Sheet
	Quando volto para a tela da Cue-Sheet e excluo o item da Cue-Sheet
	E cadastro um novo item na Cue-Sheet
	E gero um novo pedido para o item de Cue-Sheet cadastrado
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior foi cancelado com sucesso
	
@chrome @AlteracaoDePedidoPorCueSheetCT07
Cenário: Validar que pedido com status concluido não é cancelado ao excluir item da Cue-Sheet
# Nome antigo do CT: Sincronismo Globo - Pedido concluído
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha um item da Cue-Sheet com pedido enviado para pagamento
	Quando volto para a tela da Cue-Sheet e excluo o item da Cue-Sheet
	E cadastro um novo item na Cue-Sheet
	E gero um novo pedido para o item de Cue-Sheet cadastrado
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior não foi cancelado

@chrome @AlteracaoDePedidoPorCueSheetCT08
Cenário: Validar que pedido com status concluido não é cancelado após mudança de Sincronismo Globo na cue-sheet
# Nome antigo do CT: Sincronismo Globo - Pedido concluído
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha um item da Cue-Sheet com pedido enviado para pagamento
	Quando volto para a tela da Cue-Sheet e altero o sincronismo do item da Cue-Sheet
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior não foi cancelado

@chrome @AlteracaoDePedidoPorCueSheetCT09
Cenário: Validar que pedido com status concluido não é cancelado após mudança de Reprise na cue-sheet
# Nome antigo do CT: Sincronismo Globo - Pedido concluído
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	E que tenha uma cue-sheet cadastrada no sistema
	E que tenha um item cadastrado na cue-sheet
	E que tenha gerado um pedido para o item cadastrado na Cue-Sheet
	E que tenha um item da Cue-Sheet com pedido enviado para pagamento
	Quando volto para a tela da Cue-Sheet e altero o item da Cue-Sheet para Reprise
	E volto para a tela de detalhes do pedido anterior
	Então visualizo que o pedido anterior não foi cancelado
