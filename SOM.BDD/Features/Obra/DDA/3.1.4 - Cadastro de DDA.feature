#language: pt-BR
#Author: Rodrigo Magno
#Date: 29/10/2018
#Version: 1.0

@chrome @kill_Driver @DDA @CadastroDeDDA
Funcionalidade: 3.1.4 - Cadastro de DDA

Contexto: Acessara a tela de cadastro de DDA
	Dado que esteja logado no sistema SOM
    E que estou com a tela Novo Cadastro de DDA

@chrome @CadastroDeDDACT01
Esquema do Cenario: Cadastro de DDA com sucesso
	Quando cadastro um novo DDA <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>
	E cadastro o contato do DDA <NOMECONTATO>, <TIPOCONTATO>, <CONTATO>, <AUTORIZACAO>
	Entao visualizo a mensagem de cadastro de DDA com sucesso <NOMEFANTASIA>, <MENSAGEM>

  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | NOMECONTATO         | TIPOCONTATO | CONTATO           | AUTORIZACAO | MENSAGEM                     |
      | "Teste INM 605" | "Teste INM 605" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Contato Teste 605" | "E-mail"    | "teste@teste.com" | "sim"       | "Registro salvo com sucesso" | 

@chrome @CadastroDeDDACT02
Esquema do Cenario: Cadastro de DDA sem Contato para autorização
	Quando cadastro um novo DDA <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>
	Entao visualizo uma mensagem de critica ao salvar a obra sem o contato <MENSAGEM>
	
  Exemplos:
      | NOMEFANTASIA    | NOMECOMPLETO    | CPF           | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO | MENSAGEM                                                                                           |
      | "Teste INM 606" | "Teste INM 606" | "54635356357" | "UBEM"     | "Sim"         | "10/10/1992"   | "Não é permitido o cadastro de um DDA sem pelo menos um contato de e-mail que receba autorização." |

@chrome @CadastroDeDDACT03
Esquema do Cenario: Cadastrar DDA sem preenchimento de campo obrigatório
    Quando cadastro um DDA sem preenchimento dos campos dos campos obrigatorios <NOMEFANTASIA>, <NOMECOMPLETO>, <CPF>, <ASSOCIACAO>, <ADMINISTRADOR>, <DATANASCIMENTO>
	Entao visualizo os campos obrigatorios em destaque
	
  Exemplos:
      | NOMEFANTASIA | NOMECOMPLETO | CPF | ASSOCIACAO | ADMINISTRADOR | DATANASCIMENTO |
      | " "          | " "          | " " | " "        | " "           | " "            |
