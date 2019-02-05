#language:pt
#Author: Rodrigo Magno
#Date: 26/01/2019

@kill_Driver @TabelaDePrecoFeatures
Funcionalidade: 6.5.4 - Tabelas de Preço - Fatores

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @TabelaDePrecoFeaturesCT01
Esquema do Cenário: Criar um fator com sucesso
	Dado que estou na tela de detalhes da tabela de preço desejada <TabelaDePreco>
	Quando cadastro um novo fator para a tabela de preço <Midia>, <Fator>
	Então visualizo a mensagem de fator incluido com sucesso na tabela de preço <Mensagem>, <Midia>
	  
  Exemplos:
      | TabelaDePreco | Midia | Fator   | Mensagem                     |
      | "UBEM - 2012" | "TV"  | "Fator" | "Fator incluído com sucesso" |
  
@chrome @TabelaDePrecoFeaturesCT02
Esquema do Cenário: Excluir um fator com sucesso
	Dado que estou na tela de detalhes da tabela de preço desejada <TabelaDePreco>
	Quando cadastro um novo fator para a tabela de preço <Midia>, <Fator>
	E excluo o fator cadastrado <Midia>
	Então visualizo a mensagem de fator excluido com sucesso na tabela de preço <Mensagem>
	  
  Exemplos:
      | TabelaDePreco | Midia | Fator   | Mensagem                     |
      | "UBEM - 2012" | "TV"  | "Fator" | "Fator excluído com sucesso" |
  
@chrome @TabelaDePrecoFeaturesCT03
Esquema do Cenário: Criar mais de um fator para a mesma mídia
	Dado que estou na tela de detalhes da tabela de preço desejada <TabelaDePreco>
	Quando cadastro um novo fator para a tabela de preço <Midia>, <Fator>
	E cadastro um fator igual ao já existente <Midia>, <Fator>
	Então visualizo a mensagem de que já existe um fator para essa midia na tabela de preço <Mensagem>, <Midia>
	  
  Exemplos:
      | TabelaDePreco | Midia | Fator   | Mensagem                              |
      | "UBEM - 2012" | "TV"  | "Fator" | "Já existe um fator para esta mídia." |
  
@chrome @TabelaDePrecoFeaturesCT04
Esquema do Cenário: Criar fatores com números muito altos
	Dado que estou na tela de detalhes da tabela de preço desejada <TabelaDePreco>
	Quando cadastro um novo fator para a tabela de preço <Midia>, <Fator>
	Então visualizo a mensagem de erro ao tentar incluir um fator com valor muito alto na tabela de preço <Mensagem>
	  
  Exemplos:
      | TabelaDePreco | Midia | Fator                     | Mensagem                            |
      | "UBEM - 2012" | "TV"  | "11111111111111111111111" | "Ocorreu um erro ao salvar o item." |
  
@chrome @TabelaDePrecoFeaturesCT05
Esquema do Cenário: Criar fatores com números negativos
	Dado que estou na tela de detalhes da tabela de preço desejada <TabelaDePreco>
	Quando cadastro um novo fator para a tabela de preço <Midia>, <Fator>
	Então visualizo a mensagem de erro ao tentar incluir um fator com valor negativo na tabela de preço <Mensagem>
	  
  Exemplos:
      | TabelaDePreco | Midia | Fator   | Mensagem                            |
      | "UBEM - 2012" | "TV"  | "-9999" | "Ocorreu um erro ao salvar o item." |
  