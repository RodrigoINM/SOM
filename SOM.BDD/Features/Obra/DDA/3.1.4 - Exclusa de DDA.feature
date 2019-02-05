#language: pt-BR
#Author: Rodrigo Magno
#Date: 31/10/2018
#Version: 1.0

@kill_Driver @DDA @Exclusao_DDA
Funcionalidade: 3.1.4 - Exclusa de DDA

Contexto: Acessar a Tela de Busca de DDA para exclusão
	Dado que esteja logado no sistema SOM

@chrome @Exclusao_DDACT01
Esquema do Cenario: Exclusão de um DDA com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
	Quando faco uma busca simples por DDA <NOMEFANTASIA>
    E excluo o DDA <NOMEFANTASIA>
	Entao visualizo a mensagem de DDA excluido com sucesso <MENSAGEM>
	  
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | MENSAGEM                         | 
      | "Teste INM 600" | "Teste INM 600" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 600" | "E-mail"    | "teste@teste.com" | "sim"       | "Registro excluído com sucesso." | 

@chrome @Exclusao_DDACT02
Esquema do Cenário: Cancelar a exclusão do DDA com sucesso
	Dado que tenha um DDA cadastrado <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
	Quando faco uma busca simples por DDA <NOMEFANTASIA>
    E cancelo a exclusão um DDA com <NOMEFANTASIA>
    Então visualizo o DDA no resultado da busca com sucesso <NOMEFANTASIA>
	  
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO |
      | "Teste INM 601" | "Teste INM 601" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 601" | "E-mail"    | "teste@teste.com" | "sim"       |
  
@chrome @Exclusao_DDACT03
Esquema do Cenário: Exclusão de Endereço com sucesso
    Dado que tenha um DDA cadastrado com endereço completo <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <LOGRADOURO>, <BAIRRO>, <CIDADE>, <UF>, <CEP>
    Quando excluo um endereço do DDA <LOGRADOURO>
    Então visualizo a mensagem de endereço excluido com sucesso <MENSAGEM>
	 
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | LOGRADOURO | BAIRRO   | CIDADE  | UF   | CEP        | MENSAGEM                         |
      | "Teste INM 602" | "Teste INM 602" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Rua 10"   | "Centro" | "Bahia" | "BA" | "23847238" | "Registro excluído com sucesso." |
  
@chrome @Exclusao_DDACT04
Esquema do Cenário: Exclusão de Contato com sucesso
	Dado que tenha um DDA cadastrado com um contato <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
    Quando excluo um contato do DDA <NOMECONTATO>
    Então visualizo a mensagem de contato excluido com sucesso <MENSAGEM>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | MENSAGEM                         | 
      | "Teste INM 603" | "Teste INM 603" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 603" | "E-mail"    | "teste@teste.com" | "sim"       | "Registro excluído com sucesso." | 
  
@chrome @Exclusao_DDACT05
Esquema do Cenário: Exclusão de Contato que recebe autorização
    Dado que tenha um DDA cadastrado com um contato <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>, <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
    Quando excluo um contato do DDA <NOMECONTATO>
	Entao visualizo uma mesnagem de critica ao tentar salvar a obra sem o contato <MENSAGEM>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | MENSAGEM                                                                                           |
      | "Teste INM 604" | "Teste INM 604" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 604" | "E-mail"    | "teste@teste.com" | "Não"       | "Não é permitido o cadastro de um DDA sem pelo menos um contato de e-mail que receba autorização." |
  