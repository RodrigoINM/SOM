#language:pt
#Author: Rodrigo Magno
#Date: 27/01/2019

@kill_Driver @ConsultaRapida
Funcionalidade: Consulta pelo menu Busca Rápida

Contexto: 
    Dado que esteja logado no sistema SOM

@chrome @ConsultaRapidaCT01
Esquema do Cenário: Buscar rapidamente com sucesso
    Quando faço uma consulta no menu de busca rápida <BuscaRapida>
	Então visualizo as obras e produtos no resultado da busca rápida com sucesso <Obra>, <MensagemObra>, <Produto>, <MensagemProduto>
	  
  Exemplos:
      | BuscaRapida | Obra        | MensagemObra                       | Produto     | MensagemProduto                       |
      | "Teste INM" | "Teste INM" | "Buscar mais obras com: Teste INM" | "Teste INM" | "Buscar mais produtos com: Teste INM" |
  
@chrome @ConsultaRapidaCT02
Esquema do Cenário: Acessar Consulta de Obra pela Busca Rápida com sucesso
	Quando faço uma consulta no menu de busca rápida <Obra>
	E acesso a Obra no resultado da busca rápida <Obra>
	Então visualizo a tela de detalhe da obra com sucesso <Obra>
	  
  Exemplos:
      | Obra              |
      | "Aletha920270007" |
  
@chrome @ConsultaRapidaCT03
Esquema do Cenário: Acessar Consulta de Produto pela Busca Rápida com sucesso
    Quando faço uma consulta no menu de busca rápida <Produto>
	E acesso o Produto no resultado da busca rápida <Produto>
	Então visualizo a tela de detalhe do Produto com sucesso <Produto>
	  
  Exemplos:
      | Produto                          |
      | "Jann313634060 Iarocci150695885" |
  
@chrome @ConsultaRapidaCT04
Esquema do Cenário: Buscar por título cadastrado apenas em Obra com sucesso
    Quando faço uma consulta no menu de busca rápida <Obra>
	Então visualizo a obra no resultado da busca rápida com sucesso <Obra>
	  
  Exemplos:
      | Obra              |
      | "Aletha920270007" |
  
@chrome @ConsultaRapidaCT05
Esquema do Cenário: Buscar por título cadastrado apenas em Produto com sucesso
    Quando faço uma consulta no menu de busca rápida <Produto>
	Então visualizo o produto no resultado da busca rápida com sucesso <Produto>
	  
  Exemplos:
      | Produto                          |
      | "Jann313634060 Iarocci150695885" |
  
@chrome @ConsultaRapidaCT06
Esquema do Cenário: Buscar por um título não cadastrado
	Quando faço uma consulta no menu de busca rápida por um título não cadastrado no sistema <BuscaRapida>
	Então visualizo a mensagem de dados não encontrados na busca rápida <Mensagem>
	   
  Exemplos:
      | BuscaRapida         | Mensagem                      | 
      | "Teste Inexistente" | "Nenhum resultado encontrado" | 
  