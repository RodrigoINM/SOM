#language:pt
#Author: Rodrigo Magno
#Date: 31/01/2019

@kill_Driver @Capitulo @CadastroDeCapituloNaTelaDeDetalhes
Funcionalidade: 4.1.2 - Cadastrar capítulos na tela de detalhes do produto
Como um usuário com permissão de cadastrar capítulos
Eu quero poder cadastrar as informações de capítulo para um produto já cadastrado
Para que possa utilizar os dados no cadastro associada ao produto

Contexto: Acessar a tela de Novo Cadastro de Capitulo na tela de detalhes do Produto
    Dado que esteja logado no sistema SOM

@chrome @CadastroDeCapituloNaTelaDeDetalhesCT01
Esquema do Cenário: Cadastrar capítulo na tela de detalhes de produto
	Dado que esteja na tela de detalhes de um produto cadastrado no sistema 
	Quando cadastro um novo capitulo através da tela de detalhes do produto <Capitulo>
	Então visualizo o capitulo cadastrado no produto com sucesso <Capitulo>
	  
  Exemplos:
      | Capitulo |
      | "45"     |

@chrome @CadastroDeCapituloNaTelaDeDetalhesCT02  
Esquema do Cenário: Cadastrar capítulo em lote na tela de detalhes do Produto
	Dado que esteja na tela de detalhes de um produto cadastrado no sistema 
	Quando cadastrado capitulos em lote através da tela de detalhes do produto <Capitulo>, <GeracaoLote>, <QuantidadeCapitulos>
	Então visualizo o capitulo cadastrado no produto com sucesso <Capitulo>
	  
  Exemplos:
      | Capitulo | GeracaoLote | QuantidadeCapitulos |
      | "20"     | "Sim"       | "5"                 |
  
@chrome @CadastroDeCapituloNaTelaDeDetalhesCT03
Cenário: Cadastrar capítulo sem preenchimento de campo obrigatório na tela de detalhes do Produto
	Dado que esteja na tela de detalhes de um produto cadastrado no sistema 
	Quando tento cadastrar um capitulo sem preencher os campos obrigatórios
	Então visualizo o campo obrigatório para cadastro de capitulo em destaque

@chrome @CadastroDeCapituloNaTelaDeDetalhesCT04
Cenário: Cancelar cadastro de Capítulo na tela de detalhes do Produto
	Dado que esteja na tela de detalhes de um produto cadastrado no sistema 
	Quando cancelo o cadastro de um novo capitulo na tela de detalhes do produto
	Então eu visualizo a tela de detalhes do produto sem o capitulo criado com sucesso
