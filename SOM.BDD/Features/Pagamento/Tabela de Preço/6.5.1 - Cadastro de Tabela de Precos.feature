#language:pt
#Author: Rodrigo Magno
#Date: 06/12/2018
#Version: 1.0

@kill_Driver @CadastroDeTabelaDePreco
Funcionalidade: 6.5.1 - Cadastro de Tabela de Preços

Contexto: 
	Dado que esteja logado no sistema SOM

@chrome @CadastroDeTabelaDePrecoCT01
Esquema do Cenário: Cadastrar nova tabela de preço com sucesso
	Dado que estou na tela de cadastro de Tabela de Preço
	Quando cadastro uma nova tabela de preço <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	Entao visualizo a mensagem de tabela de preço criada com sucesso <Mensagem>
	  
  Exemplos:
      | Nome               | InicioVigencia | FimVigencia  | Midia       | Padrao | Mensagem                    |
      | "Tabela Teste 100" | "01/01/2000"   | "01/01/2001" | "GLOBONEWS" | "Não"  | "Tabela criada com sucesso" |
  
@chrome @CadastroDeTabelaDePrecoCT02
Esquema do Cenário: Validar campos obrigatórios com sucesso
	Dado que estou na tela de cadastro de Tabela de Preço
	Quando cadastro uma nova tabela sem preencher os campos obrigatorios <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
    Então visualizo os campos destacados para preenchimento
	
  Exemplos:
      | Nome | InicioVigencia | FimVigencia | Midia | Padrao |
      | " "  | " "            | " "         | " "   | " "    |
  
@chrome @CadastroDeTabelaDePrecoCT03
Esquema do Cenário: Validar data inválida com sucesso
	Dado que estou na tela de cadastro de Tabela de Preço
    Quando cadastro uma nova tabela preenchendo os campos <InicioVigencia> e <FimVigencia> com datas inválidas
    Então visualizo os campos destacados para preenchimento
	 
    Exemplos:
       | InicioVigencia | FimVigencia   |
       | "31-31-8392"   | "90-90-21847" |

@chrome @CadastroDeTabelaDePrecoCT04
Esquema do Cenário: Validar mensagem de erro ao cadastrar tabelas iguais
	Dado que estou na tela de cadastro de Tabela de Preço
	Quando cadastro uma nova tabela de preço com o mesmo nome e periodo de vigencia de uma tabela previamente cadastrada <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
    Então visualizo a mensagem de critica ao tentar salvar a tabela <Mensagem>
	
  Exemplos:
      | Nome               | InicioVigencia | FimVigencia  | Midia | Padrao | Mensagem                                                            |
      | "Tabela Teste 100" | "01/01/2000"   | "01/01/2001" | "TV"  | "Não"  | "Já existe uma tabela cadastrada com este nome e data de vigência." |

@chrome @CadastroDeTabelaDePrecoCT05
Esquema do Cenário: Criar tabelas com o mesmo período de vigência
    Dado que estou na tela de cadastro de Tabela de Preço
	Quando cadastro uma nova tabela de preço com o mesmo periodo de vigencia de uma tabela previamente cadastrada <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
    Então visualizo a mensagem de critica ao tentar salvar a tabela <Mensagem>
	
  Exemplos:
      | Nome               | InicioVigencia | FimVigencia  | Midia | Padrao | Mensagem                                                                 |
      | "Tabela Teste 102" | "01/01/2000"   | "01/01/2001" | "TV"  | "Não"  | "Já existe uma tabela para esta mídia com a data de vigência informada." |

##A mensagem pode não ser exatamente assim. Não foi possível reproduzir este caso pois há um erro já reportado.
##É possível cadastrar duas tabelas com o mesmo período de vigência neste momento.
##Logo, não há como saber qual é a real mensagem.

@chrome @CadastroDeTabelaDePrecoCT06
Esquema do Cenário: Adicionar valor à aba Dramaturgia Diária da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando preencho com valor válido os tipos de sincronização <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero               | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT07
Esquema do Cenário: Adicionar valor à aba Dramaturgia Semanal da tabela nacional com sucesso
	Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando preencho com valor válido os tipos de sincronização <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero                | Mensagem                          |
      | "DRAMATURGIA SEMANAL" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT08
Esquema do Cenário: Adicionar valor à aba Esporte da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando preencho com valor válido os tipos de sincronização <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero    | Mensagem                          |
      | "ESPORTE" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT09
Esquema do Cenário: Adicionar valor à aba Jornalismo da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando preencho com valor válido os tipos de sincronização <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero       | Mensagem                          |
      | "JORNALISMO" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT10
Esquema do Cenário: Adicionar valor à aba Variedade Diária da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando preencho com valor válido os tipos de sincronização <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero             | Mensagem                          |
      | "VARIEDADE DIÁRIA" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT11
Esquema do Cenário: Adicionar valor à aba Variedade Semanal da tabela nacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço <Genero>
    Quando preencho com valor válido os tipos de sincronização <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero              | Mensagem                          |
      | "VARIEDADE SEMANAL" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT12
Esquema do Cenário: Adicionar valor à aba Dramaturgia Diária da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor válido os tipos de sincronização internacionais <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero               | Mensagem                          |
      | "DRAMATURGIA DIÁRIA" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT13
Esquema do Cenário: Adicionar valor à aba Dramaturgia Semanal da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor válido os tipos de sincronização internacionais <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero                | Mensagem                          |
      | "DRAMATURGIA SEMANAL" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT14
Esquema do Cenário: Adicionar valor à aba Esporte da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor válido os tipos de sincronização internacionais <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero    | Mensagem                          |
      | "ESPORTE" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT15
Esquema do Cenário: Adicionar valor à aba Jornalismo da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor válido os tipos de sincronização internacionais <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero       | Mensagem                          |
      | "JORNALISMO" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT16
Esquema do Cenário: Adicionar valor à aba Variedade Diária da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor válido os tipos de sincronização internacionais <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero             | Mensagem                          |
      | "VARIEDADE DIÁRIA" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT17
Esquema do Cenário: Adicionar valor à aba Variedade Semanal da tabela internacional com sucesso
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor válido os tipos de sincronização internacionais <Genero>
    Então visualizo a mensagem de itens adicionados com sucesso à tabela de preço <Mensagem>
	
  Exemplos:
      | Genero              | Mensagem                          |
      | "VARIEDADE SEMANAL" | "Itens foram salvos com sucesso." |

@chrome @CadastroDeTabelaDePrecoCT18
Esquema do Cenário: Validar não aceitação de valores negativos na tabela nacional
	Dado que estou na tela de detalhes da tabela de preço <Genero>
	Quando preencho com valor negativo no tipo de sincronização <Genero>, <Abertura>
    Então visualizo o campo voltar a apresentar o ultimo valor valido da tabela de preço <Genero>, <Abertura>
	
  Exemplos:
      | Genero               | Abertura |
      | "DRAMATURGIA DIÁRIA" | "-1"     |

@chrome @CadastroDeTabelaDePrecoCT19
Esquema do Cenário: Validar não aceitação de valores negativos na tabela internacional
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor negativo no tipo de sincronização internacional <Genero>, <Abertura>
    Então visualizo o campo voltar a apresentar o ultimo valor valido da tabela de preço internacional <Genero>, <Abertura>
	
  Exemplos:
      | Genero               | Abertura |
      | "DRAMATURGIA DIÁRIA" | "-1"     |

@chrome @CadastroDeTabelaDePrecoCT20
Esquema do Cenário: Verificar mensagem de erro ao cadastrar valores da tabela nacional com valores muito altos
	Dado que estou na tela de detalhes da tabela de preço <Genero>
	Quando preencho com valor muito alto no tipo de sincronização <Genero>, <Abertura>
	Entao visualizo a mensagem de erro ao tentar salvar a tabela de preço <Mensagem>
	
  Exemplos:
      | Genero               | Abertura                         | Mensagem                            |
      | "DRAMATURGIA DIÁRIA" | "837402357383485742308674367409" | "Ocorreu um erro ao salvar o item." |

@chrome @CadastroDeTabelaDePrecoCT21
Esquema do Cenário: Verificar mensagem de erro ao cadastrar valores da tabela internacional com valores muito altos
    Dado que estou na tela de detalhes da tabela de preço internacional <Genero>
    Quando preencho com valor muito alto no tipo de sincronização internacional <Genero>, <Abertura>
	Entao visualizo a mensagem de erro ao tentar salvar a tabela de preço internacional <Mensagem>
	
  Exemplos:
      | Genero               | Abertura                         | Mensagem                            |
      | "DRAMATURGIA DIÁRIA" | "837402357383485742308674367409" | "Ocorreu um erro ao salvar o item." |

@chrome @CadastroDeTabelaDePrecoCT22
Esquema do Cenário: Sair da tela sem salvar cadastro de tabela
	Dado que estou na tela de cadastro de Tabela de Preço
	Quando cancelo o cadastro de uma nova tabela de preço <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	Então visualizo a tela de busca por tabela de preço
	
  Exemplos:
      | Nome               | InicioVigencia | FimVigencia  | Midia | Padrao | Mensagem                    |
      | "Tabela Teste 110" | "01/01/2000"   | "01/01/2001" | " "   | "Não"  | "Tabela criada com sucesso" |
  
@chrome @CadastroDeTabelaDePrecoCT23
Esquema do Cenário: Salvar tabela sem mídia com sucesso
    Dado que estou na tela de cadastro de Tabela de Preço
	Quando cadastro uma nova tabela de preço <Nome>, <InicioVigencia>, <FimVigencia>, <Midia>, <Padrao>
	Entao visualizo a mensagem de tabela de preço criada com sucesso <Mensagem>
	  
  Exemplos:
      | Nome               | InicioVigencia | FimVigencia  | Midia | Padrao | Mensagem                    |
      | "Tabela Teste 110" | "01/01/2000"   | "01/01/2001" | " "   | "Não"  | "Tabela criada com sucesso" |
  