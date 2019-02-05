#language:pt
#Author: Rodrigo Magno
#Date: 04/02/2019

@kill_Driver @Pedido @PagarParaAdministrador
Funcionalidade: Pagar para o Administrador

Contexto: 
    Dado que esteja logado no sistema SOM

@chrome @PagarParaAdministradorCT01
Esquema do Cenario: Seleção de DDAs que possuem Administrador associado
	Dado que tenha um pedido previamente cadastrado no sistema com apenas um autor e DDA na composição <Autor>, <DDA>
	Quando informo que o pagamento será feito ao Administrador do DDA do pedido <Autor>
	Então visualizo o item do pedido marcado para pagamento ao administrador com sucesso <Autor>
	  
  Exemplos:
      | Autor           | DDA      |
      | "Abe1166196360" | "KOBALT" |
  
@chrome @PagarParaAdministradorCT02
Esquema do Cenario: Marcar pagamento para o Administrador no detalhe do item de pedido - Positivo
    Dado que tenha um pedido previamente cadastrado no sistema com apenas um autor e DDA na composição <Autor>, <DDA>
	Quando informo que o pagamento será feito ao Administrador do DDA do pedido <Autor>
	Então visualizo o item do pedido marcado para pagamento ao administrador com sucesso <Autor>
	  
  Exemplos:
      | Autor           | DDA      |
      | "Abe1166196360" | "KOBALT" |
  
@chrome @PagarParaAdministradorCT03
Esquema do Cenario: Marcar pagamento para o administrador no detalhe do item de pedido - Negativo
	Dado que tenha um pedido previamente cadastrado no sistema com apenas um autor e DDA na composição <Autor>, <DDA>
	Mas nenhum item do pedido possui DDA com administrador
    Entao nao visualizo a opcao de pagar para o administrador <Autor>

  Exemplos:
      | Autor           | DDA                  |
      | "Abe1166196360" | "Zachariah361645809" |
  
        