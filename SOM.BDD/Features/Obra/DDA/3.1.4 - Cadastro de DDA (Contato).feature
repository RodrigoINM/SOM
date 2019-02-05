#language: pt-BR
#Author: Larissa Silva
#Date: 28/01/2019
#Version: 1.0

@chrome @kill_Driver @DDA @CadastroDeDDAContato
Funcionalidade: 3.1.4 - Cadastro de DDA (Contato)

Contexto: Acessara a tela de cadastro de DDA
	Dado que esteja logado no sistema SOM
    E que estou com a tela Novo Cadastro de DDA

@chrome @CadastroDeDDAContatoCT01
Esquema do Cenário: Cadastro de Contato Telefone com sucesso
    Quando cadastro um novo DDA com o contato telefone <CONTATO>
	Entao visualizo a mensagem de cadastro de contato do DDA com sucesso <MENSAGEM>

	Exemplos:
		 | CONTATO      | MENSAGEM                      |
		 | "2133356372" | "Registro salvo com sucesso." | 

@chrome @CadastroDeDDAContatoCT02
Esquema do Cenário: Cadastro de contato E-mail 
	Quando cadastro um novo DDA com o contato Email <CONTATO>
    Entao visualizo a mensagem de cadastro de contato do DDA com sucesso <MENSAGEM>

    Exemplos:
		 | CONTATO                     | MENSAGEM                      |
		 | "razevedo@inmetrics.com.br" | "Registro salvo com sucesso." | 

@chrome @CadastroDeDDAContatoCT03
Esquema do Cenário: Cadastro contato Celular
    Quando cadastro um novo DDA com o contato Celular <CONTATO>
    Entao visualizo a mensagem de cadastro de contato do DDA com sucesso <MENSAGEM>

    Exemplos:
		 | CONTATO       | MENSAGEM                      |
		 | "21983625482" | "Registro salvo com sucesso." | 

@chrome @CadastroDeDDAContatoCT04
Esquema do Cenário: Cadastro de novo contato e-mail que receba autorização
    Quando cadastro um novo DDA com o contato Email <CONTATO>
    Entao visualizo a mensagem de cadastro de contato do DDA com sucesso <MENSAGEM>

    Exemplos:
		 | CONTATO                     | MENSAGEM                      |
		 | "razevedo@inmetrics.com.br" | "Registro salvo com sucesso." |

@chrome @CadastroDeDDAContatoCT05
Esquema do Cenário: Cancelar cadastro de novo contato E-mail 
    Quando cadastro um novo DDA com o contato Email <CONTATO>
	E cancelo o cadasto de contato de email
	Então ao salvar, visualizo a mensagem de cadastro de contato do DDA com sucesso <MENSAGEM>

    Exemplos:
		| CONTATO                     | MENSAGEM                         |
		| "razevedo@inmetrics.com.br" | "Registro excluído com sucesso." |

@chrome @CadastroDeDDAContatoCT06
Esquema do Cenário: Cadastrar contato sem preenchimento de campo obrigatório
    Quando cadastro um novo DDA com o contato em branco <CONTATO>
    Entao visualizo os campos obrigatorios em destaque

    Exemplos:
        | CONTATO |
        | ""      |
