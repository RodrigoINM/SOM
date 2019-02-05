#language:pt
#Author: Rodrigo Magno
#Date: 26/01/2019

@kill_Driver @ConsultaDeTabelaDePreco
Funcionalidade: 6.5.3 - Consultar Tabela de Preços

Contexto: 
	Dado que esteja logado no sistema SOM
	E que esteja na tela de consulta de tabela de preço

@chrome @ConsultaDeTabelaDePrecoCT01
Esquema do Cenário: Buscar Tabela por um campo em branco com sucesso
	Quando faço uma busca rápida sem preencher nenhum campo
	Então visualizo uma grid com as tabelas cadastradas por ordem alfabetica no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome        | InicioVigencia | FimVigencia  | Midia | Padrao |
      | "UBEM 2020" | "01/01/2020"   | "31/12/2020" | " "   | "Sim"  |
  
@chrome @ConsultaDeTabelaDePrecoCT02
Esquema do Cenário: Buscar por uma tabela de preço com sucesso
    Quando faço uma busca de tabela de preço por nome <Nome>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome        | InicioVigencia | FimVigencia  | Midia | Padrao |
      | "UBEM 2020" | "01/01/2020"   | "31/12/2020" | " "   | "Sim"  |
  
@chrome @ConsultaDeTabelaDePrecoCT03
Esquema do Cenário: Buscar com informação não cadastrada
	Quando faço uma busca por uma tabela de preço que não está cadastrada no sistema <Nome>
	Então visualizo a mensagem de dados não encontrados no resultado da busca por tabela de preço inexistente <Mensagem>
	  
  Exemplos:
      | Nome                   | Mensagem                |
      | "Tabela De Teste 2000" | "Dados não encontratos" |
  
@chrome @ConsultaDeTabelaDePrecoCT04
Esquema do Cenário: Buscar com combinação de filtros com sucesso
	Quando faço uma busca de tabela de preço por nome e midia <Nome>, <Midia>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT05
Esquema do Cenário: Buscar por Nome com sucesso
    Quando faço uma busca de tabela de preço por nome <Nome>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT06
Esquema do Cenário: Buscar por por período com sucesso
	Quando faço uma busca de tabela de preço por inicio e fim de vigencia <InicioVigencia>, <FimVigencia>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT07
Esquema do Cenário: Buscar por inicio de vigência com sucesso
    Quando faço uma busca de tabela de preço por inicio de vigencia <InicioVigencia>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT08
Esquema do Cenário: Buscar por fim de vigência com sucesso
    Quando faço uma busca de tabela de preço por fim de vigencia <FimVigencia>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT09
Esquema do Cenário: Buscar por Padrão com sucesso
    Quando faço uma busca de tabela de preço por padrão <Padrao>
	Então visualizo os dados da tabela de preço no resultado da busca <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT10
Esquema do Cenário: Limpar campos de busca com sucesso
    Quando que preencho os campos de busca por tabela de preço <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
    E limpo os campos da consulta
    Então visualizo os campos de busca sem preenchimento
	  
  Exemplos:
      | Nome          | InicioVigencia | FimVigencia  | Midia        | Padrao |
      | "UBEM - 2017" | "01/01/2017"   | "31/03/2018" | "CANAL VIVA" | "Não"  |
  
@chrome @ConsultaDeTabelaDePrecoCT11
Esquema do Cenário: Buscar por Campos não associados
    Quando faço uma busca de tabela de preço por nome e midia não associados entre si <Nome>, <Midia>
	Então visualizo a mensagem de dados não encontrados no resultado da busca por tabela de preço por campos não associados entre si <Mensagem>
	  
  Exemplos:
      | Nome          | Midia | Mensagem                |
      | "UBEM - 2017" | "DNI" | "Dados não encontratos" |
  