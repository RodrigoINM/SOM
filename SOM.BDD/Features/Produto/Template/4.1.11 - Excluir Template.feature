#language:pt
#Author: Rodrigo Magno
#Date: 30/01/2019

@kill_Driver @Template @ExclusaoDeTemplateDeProduto
Funcionalidade: 4.1.11 - Excluir Template

Como usuário com permissão para excluir tempplate
Quero poder excluir as informações do template do produto já cadastrada no sistema
Para indisponibilizar esta informação no cadastro de uma cue-sheet

Contexto: Acessar a tela de Busca por produto
    Dado que esteja logado no sistema SOM

@chrome @ExclusaoDeTemplateDeProdutoCT01
Esquema do Cenário: Excluir Item de Template
	Dado que tenha um produto com template cadastrado
	Quando excluo o item de template cadastrado
	Então visualizo uma mensagem de item de template excluido com sucesso <Mensagem>
	  
  Exemplos:
      | Mensagem                           |
      | "Registros excluídos com sucesso." |
  
@chrome @ExclusaoDeTemplateDeProdutoCT02
Esquema do Cenário: Excluir Item de Template dentro de um Bloco
	Dado que tenha um produto com template cadastrado
	E adiciono um bloco para o item de template criado <Bloco>
	Quando excluo o item de template cadastrado
	Então visualizo uma mensagem de item de template excluido com sucesso <Mensagem>
	  
  Exemplos:
      | Bloco            | Mensagem                           | 
      | "Teste de Bloco" | "Registros excluídos com sucesso." | 
  
@chrome @ExclusaoDeTemplateDeProdutoCT03
Esquema do Cenário: Excluir Item de Template dentro de uma Materia
	Dado que tenha um produto com template cadastrado
	E adiciono um bloco para o item de template criado <Bloco>
	E adiciono uma materia para o item de template criado <Materia>
	Quando excluo o item de template cadastrado
	Então visualizo uma mensagem de item de template excluido com sucesso <Mensagem>
	    
  Exemplos:
      | Bloco            | Materia            | Mensagem                           | 
      | "Teste de Bloco" | "Teste de Materia" | "Registros excluídos com sucesso." | 
  
@chrome @ExclusaoDeTemplateDeProdutoCT04
Esquema do Cenário: Excluir uma matéria
	Dado que tenha um produto com template cadastrado
	E adiciono um bloco para o item de template criado <Bloco>
	E adiciono uma materia para o item de template criado <Materia>
	Quando excluo a materia dentro de um bloco <Materia>, <MensagemExclusaoMateria>
	Então visualizo uma mensagem de materia excluida com sucesso <Mensagem>
	    
  Exemplos:
      | Bloco   | Materia   | MensagemExclusaoMateria                              | Mensagem                        |
      | "Bloco" | "Materia" | "A matéria Materia será excluída. Deseja continuar?" | "Matéria excluída com sucesso." |
  
@chrome @ExclusaoDeTemplateDeProdutoCT05
Esquema do Cenário: Excluir um Bloco
	Dado que tenha um produto com template cadastrado
	E adiciono um bloco para o item de template criado <Bloco>
	Quando excluo um bloco do template <Bloco>, <MensagemExclusaoBloco>
	Então visualizo uma mensagem de bloco excluido com sucesso <Mensagem>
	    
  Exemplos:
      | Bloco   | MensagemExclusaoBloco                            | Mensagem                      |
      | "Bloco" | "O bloco Bloco será excluído. Deseja continuar?" | "Bloco excluído com sucesso." |
  
@chrome @ExclusaoDeTemplateDeProdutoCT06
Esquema do Cenário: Cancelar exclusão de uma matéria
	Dado que tenha um produto com template cadastrado
	E adiciono um bloco para o item de template criado <Bloco>
	E adiciono uma materia para o item de template criado <Materia>
	Quando cancelo a exclusão da materia dentro de um bloco <Materia>, <MensagemExclusaoMateria>
	Então visualizo a Materia e o Bloco na grid de template com sucesso <Bloco>, <Materia>
	    
  Exemplos:
      | Bloco   | Materia   | MensagemExclusaoMateria                              |
      | "Bloco" | "Materia" | "A matéria Materia será excluída. Deseja continuar?" |
  
@chrome @ExclusaoDeTemplateDeProdutoCT07
Esquema do Cenário: Cancelar exclusão de um Bloco
    Dado que tenha um produto com template cadastrado
	E adiciono um bloco para o item de template criado <Bloco>
	Quando cancelo a exclusão da materia dentro de um bloco <Bloco>, <MensagemExclusaoBloco>
	Então visualizo o Bloco na grid de template com sucesso <Bloco>
	    
  Exemplos:
      | Bloco   | MensagemExclusaoBloco                            |
      | "Bloco" | "O bloco Bloco será excluído. Deseja continuar?" |
  