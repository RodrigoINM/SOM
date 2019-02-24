#language: pt-BR
#Author: Rodrigo Magno
#Date: 06/11/2018
#Version: 1.0

@kill_Driver @Autor @CadastrarAutor
Funcionalidade: 3.1.5 - Cadastrar Autor

Contexto: Acesso à tela de Autor
    Dado que esteja logado no sistema SOM
	E que esteja na tela de cadastro Autor

@chrome @excluirAutor @CadastrarAutorCT01
 Esquema do Cenario: Incluir Autor
    Quando cadastro um novo autor com os campos <NomeArtistico> e <NomeCompleto>
    E informo os dados de endereco: <Logradouro>, <Bairro>, <Cidade> e <CEP>
    E informo os dados de contato: <Nome>, <TipoContato> e <Telefone>
    Então visualizo a <Mensagem> do Autor cadastrado com sucesso para o <NomeArtistico>

  Exemplos:
      | NomeArtistico            | NomeCompleto                  | Logradouro         | Bairro       | Cidade        | CEP        | Nome               | TipoContato | Telefone     | Mensagem                        |
      | "Teste de Autor INM"     | "Teste de Autor INM Completo" | "Teste Logradouro" | "Teste"      | "Teste"       | "11111111" | "Teste INM"        | "Telefone"  | "2133445566" | "Registro ativado com sucesso." |
      | "Teste de NomeArtistico" | "Teste de NomeCompleto"       | "Logradouro"       | "NovoBairro" | "CidadeTeste" | "21220560" | "Teste de Contato" | "Telefone"  | "2133445566" | "Registro ativado com sucesso." |

@chrome @CadastrarAutorCT02
Esquema do Cenario: Incluir Autor sem preenchimento dos campos obrigatorios
    Quando tento cadastrar um autor sem informar o <NomeArtistico>
    Entao visualizo o campo em destaque do cadastro de autor

  Exemplos:
      | NomeArtistico |
      | ""            |

@chrome @excluirAutor @CadastrarAutorCT03
Esquema do Cenario: Incluir dois autores com dados iguais
    Quando cadastro um autor com <NomeArtistico> e <NomeCompleto>
    E tento cadastrar um novo autor com os mesmos dados de <NomeArtistico> e <NomeCompleto>
    Entao visualizo a <Mensagem> que ja existe um autor <NomeArtistico> cadastrados com esses dados

  Exemplos:
      | NomeArtistico        | NomeCompleto                  | Mensagem                                                    |
      | "Teste de Autor INM" | "Teste de Autor INM Completo" | "Existe um registro com esses dados cadastrado no sistema." |

@chrome @CadastrarAutorCT04
Esquema do Cenario: Incluir um endereco sem preenchimento de campos obrigatórios
    Quando realizo um cadastro de autor com os campos <NomeArtistico> e <NomeCompleto>
    E tento adicionar um endereco sem preencher os campos <Logradouro>, <Bairro>, <Cidade> e <Cep>
    Entao visualizo os campos em destaque

  Exemplos:
      | NomeArtistico    | NomeCompleto | Logradouro | Bairro | Cidade | Cep |
      | "Teste de Autor" | "Teste Nome" | " "        | " "    | " "    | " " |

@chrome @CadastrarAutorCT05
Esquema do Cenario: Incluir um contato sem preenchimento de campos obrigatórios
    Quando cadastro um novo autor com <NomeArtistico> e <NomeCompleto>
    E tento adicionar um contato sem preencher o campos <NomeContato>
    Entao visualizo o campo Nome da aba de contato em destaque

  Exemplos:
      | NomeArtistico    | NomeCompleto | NomeContato  |
      | "Teste de Autor" | "Teste Nome" | " "		   |

@chrome @excluirAutor @CadastrarAutorCT06
Esquema do Cenario: Incluir tipos de contato
    Quando cadastro um autor preenchendo os campos de <NomeArtistico> e <NomeCompleto>
    Quando incluir um novo contato com <Nome>,<TipoContato> e <Contato>
    Então visualizo a <Mensagem> do Autor cadastrado com sucesso para o <NomeArtistico>


  Exemplos:
      | NomeArtistico        | NomeCompleto | Nome    | TipoContato | Contato              | Mensagem                        |
      | "Teste de Autor INM" | "Teste Nome" | "Nome1" | "Telefone"  | "2134352617"         | "Registro ativado com sucesso." |
      | "Teste de Autor INM" | "Teste Nome" | "Nome2" | "Celular"   | "21824262728"        | "Registro ativado com sucesso." |
      | "Teste de Autor INM" | "Teste Nome" | "Nome3" | "Email"     | "Teste@teste.com.br" | "Registro ativado com sucesso." |

@chrome @CadastrarAutorCT07
Esquema do Cenario: Incluir mais de um contato
    Dado que no cadastramento de um novo autor preencho os campo <NomeArtistico> e <NomeCompleto>
    Quando incluir um contato com <NomeContato>,<TipoContato1> e <Contato1>
    E incluir mais um contato <TipoContato2> e <Contato2>
    Entao visualizo os <NomeContato> cadastrados com sucesso na aba de contatos do autor

  Exemplos:
      | NomeArtistico         | NomeCompleto | NomeContato | TipoContato1 | Contato1     | TipoContato2 | Contato2      |
      | "Teste De Contato 01" | "Teste Nome" | "Contato"   | "Telefone"   | "2134352617" | "Celular"    | "21824262728" |

@chrome @CadastrarAutorCT08
Esquema do Cenario: Incluir mais de um endereco
    Dado que no cadastro de um autor preencho os seguintes campos <NomeArtistico> e <NomeCompleto>
    Quando incluir um novo endereco informando os campos <Logradouro1>, <Bairro1>, <Cidade1> e <Cep1>
    E incluir mais um endereco informando os campos <Logradouro2>, <Bairro2>, <Cidade2> e <Cep2>
    Entao visualizo os endereços <Logradouro1> e <Logradouro2> cadastrados com sucesso 

  Exemplos:
      | NomeArtistico         | NomeCompleto | Logradouro1    | Bairro1        | Cidade1   | Cep1       | Logradouro2    | Bairro2   | Cidade2   | Cep2       |
      | "Teste De Contato 01" | "Teste Nome" | "Logradouro 1" | "Bairro Teste" | "Cidade"  | "21220000" | "Logradouro 2" | "Bairro2" | "Cidade2" | "22202999" |

@chrome @excluirAutor @CadastrarAutorCT09
Esquema do Cenario: Incluir Autor falecido há 70 anos
    Quando crio um Autor informando <NomeAutor> e <NomeCompleto>
	E preencho o campo de Ano Falecimento <AnoFalecimento> igual a 70 anos
	Entao visualizo o ano de falecimento do autor cadastrado como não

  Exemplos:
      | NomeAutor            | NomeCompleto                  | AnoFalecimento |
      | "Teste de Autor INM" | "Teste de Autor INM Completo" | "1948"         |

@chrome @excluirAutor @CadastrarAutorCT10
Esquema do Cenario: Incluir Autor falecido há mais de 70 anos
    Quando crio um Autor informando <NomeAutor> e <NomeCompleto>
	E preencho o campo de Ano Falecimento <AnoFalecimento> acima de 70 anos
	Entao visualizo o ano de falecimento do autor cadastrado como sim

  Exemplos:
      | NomeAutor            | NomeCompleto                  | AnoFalecimento |
      | "Teste de Autor INM" | "Teste de Autor INM Completo" | "1946"         |
