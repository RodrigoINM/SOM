#language:pt
#Author: Rodrigo Magno
#Date: 27/01/2019

@kill_Driver @Template @CadastroDeTemplateDeProduto
Funcionalidade: 4.1.9 - Cadastro de Templates

Como usuário com permissão "Produto | Alterar"
Quero poder atualizar as informações de produto com uma mídia já cadastrada no sistema
Para utilizar esta informação no cadastro de uma cue-sheet associada ao produto

Contexto: Acessar a tela de cadastro de um Templates
    Dado que esteja logado no sistema SOM

@chrome @CadastroDeTemplateDeProdutoCT01
Esquema do Cenário: Cadastro de Templates
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
    Então visualizo os dados do item de template cadastrados com sucesso <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Tempo>, <Observacao>	
	  
  Exemplos:
      | Ordem | Titulo      | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao |
      | "1"   | "Aleatório" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |
  
@chrome @CadastroDeTemplateDeProdutoCT02
Cenário: Cadastrar um Template sem preenchimento de campo obrigatório
	Dado que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto sem preencher os campos obrigatorios
	Então visualizo os campos obrigatorios de cadastros de item de template em destaque
    
@chrome @CadastroDeTemplateDeProdutoCT03
Esquema do Cenário: Cadastrar um Template com informações iguais
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro dois itens de template identicos para o produto <Ordem>, <Titulo>, <Interprete>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
    Então visualizo os dados do item de template cadastrados com sucesso <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Tempo>, <Observacao>	
	  
  Exemplos:
      | Ordem | Titulo      | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao |
      | "1"   | "Aleatório" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |

@chrome @CadastroDeTemplateDeProdutoCT04
Cenário: Cancelar cadastro de Template
	Dado que tenha um produto cadastrado no sistema
	Quando cancelo a criação de um novo item de template
	Então visualizo a tela do produto sem ter criado um item de template

@chrome @CadastroDeTemplateDeProdutoCT05
Esquema do Cenario: Criação de Blocos para item de template
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
	E adiciono um bloco para o item de template criado <Bloco>
	Então visualizo o bloco criado para o item de template com sucesso <Bloco>
	  
  Exemplos:
      | Bloco            | Ordem | Titulo      | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao |
      | "Teste de Bloco" | "1"   | "Aleatório" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |

@chrome @CadastroDeTemplateDeProdutoCT06
Esquema do Cenario: Criação de Materia de para item de template
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
	E adiciono um bloco para o item de template criado <Bloco>
	E adiciono uma materia para o item de template criado <Materia>
	Então visualizo o bloco e a materia criada para o item de template com sucesso <Bloco>, <Materia>
	  
  Exemplos:
      | Materia            | Bloco            | Ordem | Titulo      | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao |
      | "Teste de Materia" | "Teste de Bloco" | "1"   | "Aleatório" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |

@chrome @CadastroDeTemplateDeProdutoCT07
Esquema do Cenario: Criação de Blocos para item de template não sequenciais
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro dois itens de template identicos para o produto <Ordem>, <Titulo>, <Interprete>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
	E adiciono um bloco para o segundo item de template criado <Bloco>, <Ordem>
	Então visualizo o bloco criado para o item de template com sucesso <Bloco>
	  
  Exemplos:
      | Bloco            | Ordem | Titulo      | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao |
      | "Teste de Bloco" | "1"   | "Aleatório" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |

@chrome @CadastroDeTemplateDeProdutoCT08
Esquema do Cenário: Adicionar uma matéria à outra matéria
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
	E adiciono um bloco para o item de template criado <Bloco>
	E adiciono uma materia para o item de template criado <Materia>
	E tento adicionar uma nova materia para a materia já criada
	Então visualizo uma mensagem de erro informando que o item selecionado já possui uma materia e bloco <Mensagem>
	  
  Exemplos:
      | Materia            | Bloco            | Ordem | Titulo      | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao | Mensagem                                              |
      | "Teste de Materia" | "Teste de Bloco" | "1"   | "Aleatório" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |"Todos os itens selecionados possuem matéria e bloco." |

@chrome @CadastroDeTemplateDeProdutoCT09
Esquema do Cenário: Inclusão de intérprete pelo Template
    Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto criando um novo interprete na tela de criação do item <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
    Então visualizo os dados do item de template cadastrados com sucesso <Ordem>, <Titulo>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Tempo>, <Observacao>	
	  
  Exemplos:
      | Ordem | Titulo      | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao |
      | "1"   | "Aleatório" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    |
  
@chrome @CadastroDeTemplateDeProdutoCT10
Esquema do Cenário: Inclusão de intérprete pelo Template já existente
	Dado que tenha uma obra cadastrada no sistema
	E que tenha um produto cadastrado no sistema
	Quando cadastro um novo item de template para o produto tentando cadastrar um interprete já existente na tela de criação do item <Ordem>, <Titulo>, <Interprete>, <Gravadora>, <TipoExibicao>, <TipoUtilizacao>, <SincronismoGlobo>, <Submix>, <Tempo>, <Observacao>
    Então visualizo uma mensagem de erro ao tentar cadastrar um interprete já existente <Mensagem>
	  
  Exemplos:
      | Ordem | Titulo      | Interprete   | Gravadora   | TipoExibicao | TipoUtilizacao     | SincronismoGlobo | Submix   | Tempo | Observacao | Mensagem                                                         |
      | "1"   | "Aleatório" | "ANAVITORIA" | "SOM LIVRE" | "Gravado"    | "PE – PERFORMANCE" | "ENCERRAMENTO"   | "Submix" | "12"  | "Teste"    | "Não foi possível realizar o cadastro. Intérprete já existente." |
