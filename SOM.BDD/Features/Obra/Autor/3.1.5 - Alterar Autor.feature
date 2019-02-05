#language: pt-BR
#Author: Rodrigo Magno
#Date: 29/10/2018
#Version: 1.0

@kill_Driver @Autor @AlterarAutor
Funcionalidade: 3.1.5 - Alterar Autor

Contexto: Acesso à tela de Autor
	Dado que esteja logado no sistema SOM

@chrome @AlterarAutorCT01
Esquema do Cenario: Alterar Autor cadastrado
	Quando faco uma busca por <NomeDeAlterarAutor>
    E altero os dados <NomeArtistico>, <NomeCompleto> do autor
	Entao a <MensagemdeAlteracao> e apresentada conforme alteracao do <NomeArtistico>

  Exemplos:
    | NomeDeAlterarAutor   | NomeArtistico                 | NomeCompleto                           | MensagemdeAlteracao                                 |
    | "Teste Automatizado" | "Teste Automatizado ALTERADO" | "Teste Automatizado COMPLETO ALTERADO" | "Dados alterados com sucesso e enviados ao GMUSIC." |
