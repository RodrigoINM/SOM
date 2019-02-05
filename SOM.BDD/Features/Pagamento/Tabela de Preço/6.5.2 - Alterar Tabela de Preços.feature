#language:pt
#Author: Rodrigo Magno
#Date: 10/12/2018
#Version: 1.0

@kill_Driver @EdicaoDeTabelaDePreco
Funcionalidade: 6.5.2 - Alteração da tabela de preço

Contexto: 
	Dado que esteja logado no sistema SOM

#    Nenhuma alteração feita na tabela de preço vai afetar os pedidos pendentes
#    Só na criação de novos pedidos, após a alteração na tabela de preço

@chrome @EdicaoDeTabelaDePrecoCT01
Esquema do Cenário: Editar valor na aba Dramaturgia Diária da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero os valores dos tipos de sincronização <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero               | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT02
Esquema do Cenário: Editar valor na aba Dramaturgia Semanal da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero os valores dos tipos de sincronização <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero                | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "DRAMATURGIA SEMANAL" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT03
Esquema do Cenário: Editar valor na aba Esporte da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero os valores dos tipos de sincronização <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero    | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "ESPORTE" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT04
Esquema do Cenário: Editar valor na aba Jornalismo da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero os valores dos tipos de sincronização <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero       | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "JORNALISMO" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT05
Esquema do Cenário: Editar valor na aba Variedade Diária da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero os valores dos tipos de sincronização <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero             | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "VARIEDADE DIÁRIA" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT06
Esquema do Cenário: Editar valor na aba Variedade Semanal da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero os valores dos tipos de sincronização <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero              | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "VARIEDADE SEMANAL" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT07
Esquema do Cenário: Editar valor na aba Dramaturgia Diária da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero os valores dos tipos de sincronização internacional <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero               | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT08
Esquema do Cenário: Editar valor na aba Dramaturgia Semanal da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero os valores dos tipos de sincronização internacional <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero                | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "DRAMATURGIA SEMANAL" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT09
Esquema do Cenário: Editar valor na aba Esporte da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero os valores dos tipos de sincronização internacional <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero    | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "ESPORTE" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT10
Esquema do Cenário: Editar valor na aba Jornalismo da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero os valores dos tipos de sincronização internacional <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero       | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "JORNALISMO" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT11
Esquema do Cenário: Editar valor na aba Variedade Diária da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero os valores dos tipos de sincronização internacional <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero             | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "VARIEDADE DIÁRIA" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT12
Esquema do Cenário: Editar valor na aba Variedade Semanal da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero os valores dos tipos de sincronização internacional <Genero>, <Abertura>, <AberturaPontual>, <Adorno>, <AoVivoAdorno>, <AoVivoFundo>, <AoVivoFundoJornalismo>, <AoVivoPerformance>, <Encerramento>, <EncerramentoPontual>, <Fundo>, <FundoJornalismo>, <Performance>, <Tema>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero              | Abertura | AberturaPontual | Adorno  | AoVivoAdorno | AoVivoFundo | AoVivoFundoJornalismo | AoVivoPerformance | Encerramento | EncerramentoPontual | Fundo   | FundoJornalismo | Performance | Tema     | Mensagem                          |
      | "VARIEDADE SEMANAL" | "10,00"  | "10,00"         | "10,00" | "10,00 "     | "10,00"     | "10,00"               | "10,00"           | "10,00"      | "10,00"             | "10,00" | "10,00 "        | "10,00 "    | "10,00 " | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT13
Cenário: Sair da tela sem salvar alterações de valores
	Dado que estou na tela de edição da tabela de preços
	Quando cancelo a alteração do nome da tabela
	Então visualizo a tela de busca por tabela de preço

@chrome @EdicaoDeTabelaDePrecoCT14
Esquema do Cenário: Verificar mensagem de erro ao alterar valores da tabela nacional para valores muito altos
    Dado que estou na tela de detalhes da tabela de preço <Genero>
	Quando preencho com valor muito alto no tipo de sincronização <Genero>, <Abertura>
	Entao visualizo a mensagem de erro ao tentar salvar a tabela de preço <Mensagem>
	
  Exemplos:
      | Genero               | Abertura                         | Mensagem                            |
      | "DRAMATURGIA DIÁRIA" | "837402357383485742308674367409" | "Ocorreu um erro ao salvar o item." |

@chrome @EdicaoDeTabelaDePrecoCT15
Esquema do Cenário: Verificar mensagem de erro ao alterar valores da tabela internacional para valores muito altos
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor muito alto no tipo de sincronização internacional <Genero>, <Abertura>
	Entao visualizo a mensagem de erro ao tentar salvar a tabela de preço internacional <Mensagem>
	
  Exemplos:
      | Genero               | Abertura                         | Mensagem                            |
      | "DRAMATURGIA DIÁRIA" | "837402357383485742308674367409" | "Ocorreu um erro ao salvar o item." |

@chrome @EdicaoDeTabelaDePrecoCT16
Esquema do Cenário: Validar não aceitação de valores negativos ao alterar campos na tabela nacional
    Dado que estou na tela de detalhes da tabela de preço <Genero>
	Quando preencho com valor negativo no tipo de sincronização <Genero>, <Abertura>
    Então visualizo o campo voltar a apresentar o ultimo valor valido da tabela de preço <Genero>, <Abertura>
	
  Exemplos:
      | Genero               | Abertura |
      | "DRAMATURGIA DIÁRIA" | "-1"     |

@chrome @EdicaoDeTabelaDePrecoCT17
Esquema do Cenário: Validar não aceitação de valores negativos ao alterar campos na tabela internacional
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor negativo no tipo de sincronização internacional <Genero>, <Abertura>
    Então visualizo o campo voltar a apresentar o ultimo valor valido da tabela de preço internacional <Genero>, <Abertura>
	
  Exemplos:
      | Genero               | Abertura |
      | "DRAMATURGIA DIÁRIA" | "-1"     |

@chrome @EdicaoDeTabelaDePrecoCT18
Esquema do Cenário: Alterar um fator com sucesso
	Dado que estou na tela de detalhes da tabela de preço
	Quando altero o valor do fator desejado da tabela de preço <Fator>, <ValorFator>
	Então visualizo que o fator da tabela de preço foi alterado com sucesso <Mensagem>
	  
  Exemplos:
      | Fator     | ValorFator | Mensagem                     |
      | "Reprise" | "0,6"      | "Fator alterado com sucesso" |
  
@chrome @EdicaoDeTabelaDePrecoCT19 
Esquema do Cenário: Alterar uma tabela com sucesso
	Dado que estou na tela de edição de uma tabela de preço <Tabela>
	Quando altero o nome da tabela de preço <Tabela2>
	Entao visualizo a mensagem de tabela de preço alterada com sucesso <Mensagem>, <Tabela>, <Tabela2>
	  
  Exemplos:
      | Tabela        | Tabela2                        | Mensagem                      | 
      | "UBEM - 2012" | "Tabela de Teste de Alteração" | "Tabela alterada com sucesso" | 
  
@chrome @EdicaoDeTabelaDePrecoCT20
Esquema do Cenário: Editar o fator Reprise com sucesso
	Dado que estou na tela de detalhes da tabela de preço
	Quando altero o valor do fator desejado da tabela de preço <Fator>, <ValorFator>
	Então visualizo que o fator da tabela de preço foi alterado com sucesso <Mensagem>
	  
  Exemplos:
      | Fator     | ValorFator | Mensagem                     |
      | "Reprise" | "Valor"      | "Fator alterado com sucesso" |

@chrome @EdicaoDeTabelaDePrecoCT21
Esquema do Cenário: Editar valores da tabela nacional com sucesso
	Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero o valor do tipo de sincronização <Genero>, <Abertura>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero               | Abertura | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "10,00"  | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT22
Esquema do Cenário: Editar valores da tabela internacional com sucesso
	Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero o valor do tipo de sincronização internacional <Genero>, <Abertura>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero               | Abertura | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "10,00"  | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT23
Esquema do Cenário: Editar um valor da tabela vigente nacional e verificar se esta alteração refletiu no pedido com status Pendente
	Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando altero o valor do tipo de sincronização <Genero>, <Abertura>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço sem que sejam afetados os pedidos pendentes <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero               | Abertura | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "10,00"  | "Itens foram salvos com sucesso." |
  
@chrome @EdicaoDeTabelaDePrecoCT24
Esquema do Cenário: Editar um valor da tabela vigente internacional e verificar se esta alteração refletiu no pedido com status Pendente
	Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando altero o valor do tipo de sincronização internacional <Genero>, <Abertura>
    Então visualizo a mensagem de itens alterados com sucesso da tabela de preço internacional sem que sejam afetados os pedidos pendentes <Genero>, <Mensagem>
	  
  Exemplos:
      | Genero               | Abertura | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "10,00"  | "Itens foram salvos com sucesso." |