#language:pt
#Author: Rodrigo Magno
#Date: 22/11/2018
#Version: 1.0

@kill_Driver @Obra @CadastroDeObra
Funcionalidade: 3.1.3 - Cadastrar Obra e Composição

Contexto: Acessar a tela de cadastro de Obras
	Dado que esteja logado no sistema SOM
    E que esteja com a tela de cadastro de Obras aberta

@chrome @CadastroDeObraCT01
Esquema do Cenário: Inclusão de Obra sem composição
	Quando tento cadastrar uma obra sem informar uma composição <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	Entao visualizo a mensagem de que ao menos uma composição da obra deve ser cadastrada <TITULO>, <MENSAGEM>, <SUBTITULO>, <TIPO>, <ISWC>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>
 
  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | MENSAGEM                                               |
      | "TITULO OBRA 500" | "SUBTITULO OBRA 500" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 500" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Ao menos uma composição da obra deve ser cadastrada." |
  
@chrome @CadastroDeObraCT02
Esquema do Cenário: Inclusão de Obra com um percentual de composição 100%
	Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E incluo uma composicao com um unico autor com percentual de 100% <AUTOR>, <DDA>, <PERCENTUAL> 
	Entao visualizo todas as informacoes cadastradas de obra com sucesso <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>, <AUTOR>, <DDA>, <PERCENTUAL> 

  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | AUTOR             | DDA                       | PERCENTUAL | 
      | "TITULO OBRA 501" | "SUBTITULO OBRA 501" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 501" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "TESTE INM Autor" | "Teste DDA Administrador" | "100"      | 
  
@chrome @CadastroDeObraCT03
Esquema do Cenário: Inclusão de Obra sem preencher os campos obrigatorios de obra
	Quando tento cadastrar uma obra sem preencher os campos obriatórios <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
    Entao visualizo os campos obrigatorios em destaque na tela do sistema com sucesso

  Exemplos:
      | TITULO | SUBTITULO | TIPO | TITULOALTERNATIVO | ISWC | ANO | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA |
      | " "    | " "       | " "  | " "               | " "  | " " | "Sim"        | " "           | " "  | "Não"          | "Não"         | "Não"     | "Não"       |
  
@chrome @CadastroDeObraCT04
Esquema do Cenário: Inclusão de Obra com um percentual de composição inferior a 100%
	Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E cadastro uma nova composição com percentual inferior a 100% <AUTOR>, <DDA>, <PERCENTUAL> 
    Então visualizo a mensagem de Percentual inferior a 100% ao salvar a obra <TITULO>, <MENSAGEM>
	
  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | AUTOR             | DDA                       | PERCENTUAL | MENSAGEM                      |
      | "TITULO OBRA 502" | "SUBTITULO OBRA 502" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 502" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "TESTE INM Autor" | "Teste DDA Administrador" | "90"       | "Percentual inferior a 100%." |
  
@chrome @CadastroDeObraCT05
Esquema do Cenário: Inclusão de Obra com percentual de composição acima de 100%
    Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E cadastro uma nova composição com percentual superior a 100% <AUTOR>, <DDA>, <PERCENTUAL> 
	Então visualizo a mensagem de Percentual superior a 100% ao salvar a obra <MENSAGEM>
	
  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | AUTOR             | DDA                       | PERCENTUAL | MENSAGEM                      |
      | "TITULO OBRA 503" | "SUBTITULO OBRA 503" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 503" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "TESTE INM Autor" | "Teste DDA Administrador" | "110"      | "Percentual superior a 100%." |
  
@chrome @CadastroDeObraCT06
Esquema do Cenário: Inclusão de Obra com somatorio de percentual de composicao acima de 100%
	Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E cadastro uma nova composição com percentual inferior a 100% <AUTOR>, <DDA>, <PERCENTUAL> 
	E cadastro uma nova composição com percentual inferior a 100% <AUTOR2>, <DDA>, <PERCENTUAL> 
    Então visualizo a mensagem de Percentual superior a 100% com sucesso ao incluir a segunda composicao <MENSAGEM>
	
  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | AUTOR             | AUTOR2           | DDA                       | PERCENTUAL | MENSAGEM                      |
      | "TITULO OBRA 504" | "SUBTITULO OBRA 504" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 504" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "TESTE INM Autor" | "Teste de Autor" | "Teste DDA Administrador" | "60"       | "Percentual superior a 100%." |
  
@chrome @CadastroDeObraCT007
Esquema do Cenário: Validar criação dos tipos de DDA na tela de composição
    Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E cadastro um novo DDA pela tela de composição <TIPODDA>, <PERCENTUAL>
	Entao visualizo todas as informacoes cadastradas de obra com sucesso <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>, <AUTOR>, <DDA>, <PERCENTUAL> 
	
  Exemplos:
      | TIPODDA        | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | AUTOR | DDA | PERCENTUAL |
      | "DDA"          | "TITULO OBRA 520" | "SUBTITULO OBRA 520" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 520" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | " "   | " " | "100"      |
      | "DDA ORIGINAL" | "TITULO OBRA 521" | "SUBTITULO OBRA 521" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 521" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | " "   | " " | "100"      |

@chrome @CadastroDeObraCT008
Esquema do Cenário: Validar criação de Autor na tela de composição
    Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E cadastro um novo autor pela tela de composição <PERCENTUAL>
	Entao visualizo todas as informacoes cadastradas de obra com sucesso <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>, <AUTOR>, <DDA>, <PERCENTUAL> 

  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | AUTOR | DDA | PERCENTUAL |
      | "TITULO OBRA 505" | "SUBTITULO OBRA 505" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 505" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | " "   | " " | "100"      |
  
@chrome @CadastroDeObraCT009
Esquema do Cenário: Validar criação de Duplicidade na composição
	Quando cadastro uma nova obra preenchendo os campos <TITULO>, <SUBTITULO>, <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	E incluo uma composição com duplicidade
	Entao visualizo os dados da composição em vermelho ao salvar a obra <TITULO>
	
  Exemplos:
      | TITULO            | SUBTITULO            | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA |
      | "TITULO OBRA 506" | "SUBTITULO OBRA 506" | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 506" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       |
  