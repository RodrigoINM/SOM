﻿#language:pt
#Author: Rodrigo Magno
#Date: 23/11/2018
#Version: 1.0

@kill_Driver @Obra @ExcluirObraEComposicao
Funcionalidade: 3.1.3 - Excluir Obra

Contexto: Acessar a tela Obra
    Dado que esteja logado no sistema SOM

@chrome @ExcluirObraEComposicaoCT01
Esquema do Cenário: Excluir Obra
	Dado que tenha uma obra cadastrada no sistema <TIPO>, <TITULOALTERNATIVO>, <ISWC>, <ANO>, <OBRAORIGINAL>, <NACIONALIDADE>, <PAIS>, <DOMINIOPUBLICO>, <INSTITUCIONAL>, <BLACKLIST>, <EMBLEMATICA>
	Quando excluo essa obra
	Entao visualizo a mensagem de obra excluida com sucesso <MENSAGEM>
	
  Exemplos:
      | TIPO               | TITULOALTERNATIVO            | ISWC | ANO    | OBRAORIGINAL | NACIONALIDADE | PAIS | DOMINIOPUBLICO | INSTITUCIONAL | BLACKLIST | EMBLEMATICA | MENSAGEM                         |
      | "MUSICA COMERCIAL" | "TITULOALTERNATIVO OBRA 507" | " "  | "2018" | "Sim"        | "Nacional"    | " "  | "Não"          | "Não"         | "Não"     | "Não"       | "Registro excluído com sucesso." |
 