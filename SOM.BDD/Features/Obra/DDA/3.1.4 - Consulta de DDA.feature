#language: pt-BR
#Author: Rodrigo Magno
#Date: 29/10/2018
#Version: 1.0

@kill_Driver @DDA @ConsultaDeDDA
Funcionalidade: 3.1.4 - Consulta de DDA

Contexto: Acessar a tela de Busca por DDA
	Dado que esteja logado no sistema SOM

@chrome @ConsultaDeDDACT01
Esquema do Cenario: Busca Simples por DDA com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
	Quando faco uma busca simples por DDA <NOMEFANTASIA>
	Entao visualizo os dados do DDA no resultado da busca <NOMEFANTASIA>, <NOMECOMPLETO>, <DOCUMENTO>, <ASSOCIACAO>, <TIPO>
	  
  Exemplos:
      | NOMEFANTASIA         | NOMECOMPLETO         | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO            | TIPOCONTATO | CONTATO           | AUTORIZACAO | TIPO            | DOCUMENTO        |
      | "Teste INM 607"      | "Teste INM 607"      | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 607"    | "E-mail"    | "teste@teste.com" | "Sim"       | "Administrador" | "546.353.563-57" |
      | "Teste NOMEFANTASIA" | "Teste NOMEFANTASIA" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato NOMEFANTASIA" | "E-mail"    | "teste@teste.com" | "Sim"       | "Administrador" | "546.353.563-57" |

@chrome @ConsultaDeDDACT02
Esquema do Cenario: Busca avançada por Nome Fantasia com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
    Quando faço uma busca avançada por nome fantasia de DDA <NOMEFANTASIA>
	Entao visualizo os dados do DDA no resultado da busca <NOMEFANTASIA>, <NOMECOMPLETO>, <DOCUMENTO>, <ASSOCIACAO>, <TIPO>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | TIPO            | DOCUMENTO        |
      | "Teste INM 608" | "Teste INM 608" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 608" | "E-mail"    | "teste@teste.com" | "Sim"       | "Administrador" | "546.353.563-57" |

@chrome @ConsultaDeDDACT03
Esquema do Cenario: Busca avançada por Tipo com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
    Quando faço uma busca avançada por nome fantasia e tipo de DDA <NOMEFANTASIA>, <FILTROTIPO>
	Entao visualizo os dados do DDA no resultado da busca <NOMEFANTASIA>, <NOMECOMPLETO>, <DOCUMENTO>, <ASSOCIACAO>, <TIPO>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | TIPO            | DOCUMENTO        | FILTROTIPO        |
      | "Teste INM 609" | "Teste INM 609" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 609" | "E-mail"    | "teste@teste.com" | "Sim"       | "Administrador" | "546.353.563-57" | "Grupo Editorial" |

@chrome @ConsultaDeDDACT04
Esquema do Cenario: Busca avançada por Associação com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
    Quando faço uma busca avançada por nome fantasia e associação <NOMEFANTASIA>, <ASSOCIACAO>
	Entao visualizo os dados do DDA no resultado da busca <NOMEFANTASIA>, <NOMECOMPLETO>, <DOCUMENTO>, <ASSOCIACAO>, <TIPO>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | TIPO            | DOCUMENTO        |
      | "Teste INM 610" | "Teste INM 610" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 610" | "E-mail"    | "teste@teste.com" | "Sim"       | "Administrador" | "546.353.563-57" |

@chrome @ConsultaDeDDACT05
Esquema do Cenario: Busca avançada por Nome Completo / Razão social com sucesso com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
	Quando faço uma busca avançada por nome fantasia e nome completo <NOMEFANTASIA>, <NOMECOMPLETO>
	Entao visualizo os dados do DDA no resultado da busca <NOMEFANTASIA>, <NOMECOMPLETO>, <DOCUMENTO>, <ASSOCIACAO>, <TIPO>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | TIPO            | DOCUMENTO        |
      | "Teste INM 611" | "Teste INM 611" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 611" | "E-mail"    | "teste@teste.com" | "Sim"       | "Administrador" | "546.353.563-57" |

@chrome @ConsultaDeDDACT06
Esquema do Cenario: Busca por DDA não cadastrados
	Dado que esteja com a tela de Busca de DDA aberta
	Quando faço uma busca avançada por um DDA que não esteja cadastrado no sistema <NOMEFANTASIA>
	Entao visualizo uma mensagem de dados não encontrados no resultado da busca <MENSAGEM>
	
  Exemplos:
      | NOMEFANTASIA    | MENSAGEM                |
      | "Teste 9999999" | "Dados não encontratos" |

@chrome @ConsultaDeDDACT07
Esquema do Cenario: Busca por Campos não associados
	Dado que esteja com a tela de Busca de DDA aberta
	Quando faço uma busca avançada de DDA por dados não relacionados entre si <NOMEFANTASIA>, <NOMECOMPLETO>
	Entao visualizo uma mensagem de dados não encontrados no resultado da busca <MENSAGEM>
	  
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | MENSAGEM                | 
      | "Teste INM 611" | "Teste INM 610" | "Dados não encontratos" | 
  
@chrome @ConsultaDeDDACT08
Esquema do Cenario: Gerar relatório DDA em Excel com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
	Quando faço uma busca avançada por nome fantasia e nome completo <NOMEFANTASIA>, <NOMECOMPLETO>
	E faço download do relatório em excel do resultado da busca
    Então visualizo o download da planilha excel com resultado da busca por DDA <NOMEFANTASIA>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO |
      | "Teste INM 612" | "Teste INM 612" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 612" | "E-mail"    | "teste@teste.com" | "Sim"       |

@chrome @ConsultaDeDDA
Esquema do Cenario: Gerar relatório DDA em PDF com sucesso
	Dado que esteja com a tela de Busca de DDA aberta
	Quando faço uma busca avançada por nome fantasia e nome completo <NOMEFANTASIA>, <NOMECOMPLETO>
    E faço download do relatório em pdf do resultado da busca
	
  Exemplos:
      | NOMEFANTASIA  | NOMECOMPLETO  |
      | "A DESCOBRIR" | "A DESCOBRIR" |