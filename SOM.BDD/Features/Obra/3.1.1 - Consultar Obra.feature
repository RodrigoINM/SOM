#language:pt
#Author: Rodrigo Magno
#Date: 19/11/2018
#Version: 1.0

@kill_Driver @Obra @ConsultarObraEComposicao
Funcionalidade: 3.1.1 - Consultar detalhe da Obra

Contexto: Acesso a tela de Detalhe da Obra
	Dado que esteja logado no sistema SOM
    E que esteja na tela de Obras

@chrome @ConsultarObraEComposicaoCT01
Esquema do Cenario: Consulta Avançada por Obra cadastrada no sistema
	Quando faço uma busca avancada por uma obra <TITULO>, <SUBTITULO>, <AUTOR>, <TITULOALTERNATIVO>, <TIPO>, <DDA>
	Entao visualizo a obra cadastrada no resultado da busca com sucesso <TITULO>, <AUTOR>, <DDA>, <NACIONALIDADE>, <TIPO>, <DOMINIOPUBLICO>
	  
  Exemplos:
      | TITULO                    | SUBTITULO                    | AUTOR             | TITULOALTERNATIVO | TIPO                 | DDA            | NACIONALIDADE | DOMINIOPUBLICO |
      | "TITULO CONSULTA SIMPLES" | "SUBTITULO CONSULTA SIMPLES" | "TESTE INM Autor" | " "               | "BIBLIOTECA MUSICAL" | "KOBALT MUSIC" | "Nacional"    | "Não"          |
      | "COAST OFF"               | "COAST OFF"                  | "KEITH KENNIFF"   | " "               | "MUSICA COMERCIAL"   | "A DESCOBRIR"  | "Nacional"    | "Não"          |
	  
@chrome @ConsultarObraEComposicaoCT02
Esquema do Cenario: Consulta Simples por Obra cadastrada no sistema
	Quando faço uma busca simples por uma obra <TITULO>
	Entao visualizo a obra cadastrada no resultado da busca com sucesso <TITULO>, <AUTOR>, <DDA>, <NACIONALIDADE>, <TIPO>, <DOMINIOPUBLICO>
	  
  Exemplos:
      | TITULO                    | AUTOR             | TIPO                 | DDA            | NACIONALIDADE | DOMINIOPUBLICO |
      | "TITULO CONSULTA SIMPLES" | "TESTE INM Autor" | "BIBLIOTECA MUSICAL" | "KOBALT MUSIC" | "Nacional"    | "Não"          |
	  | "COAST OFF"               | "KEITH KENNIFF"   | "MUSICA COMERCIAL"   | "A DESCOBRIR"  | "Nacional"    | "Não"          |

@chrome @ConsultarObraEComposicaoCT03
Esquema do Cenario: Consultar detalhe de obra com fonograma
	Quando faço uma busca simples por uma obra <Obra>
    Entao visualizo a grid preenchido com os dados do fonograma <Obra>

  Exemplos:
      | Obra               |
      | "MUSICA DA HELEN1" |
      | "COAST OFF"        |
