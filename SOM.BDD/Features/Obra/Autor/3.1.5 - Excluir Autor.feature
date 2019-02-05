#language: pt-BR
#Author: Rodrigo Magno
#Date: 29/10/2018
#Version: 1.0

@kill_Driver @Autor @ExcluirAutor
Funcionalidade: 3.1.5 - Excluir Autor

Contexto: Acesso a tela de Autor
    Dado que esteja logado no sistema SOM
    E que tenha um Autor previamente cadastrado

@chrome @ExcluirAutorCT01
Esquema do Cenario: Excluir Autor
    Dado que faço uma busca por <NomeArtistico>
    Quando faco a exclusao do autor <NomeArtistico>
    Entao visualizo a <Mensagem> de exclusao com sucesso

  Exemplos:
      | NomeArtistico | Mensagem                         |
      | "TESTE INM"   | "Registro excluído com sucesso." |
