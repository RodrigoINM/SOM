REM ARMAZENANDO O CAMINHO DO BAT NA VARII�VEL PATH
@SET "curpath=%~dp0"

REM REMOVE A �LTIMA BARRA DO PAT
@IF %curpath:~-1%==\ SET curpath=%curpath:~0,-1%

REM SE HOUVER ERRO FINALIA
@IF ERRORLEVEL 1 GOTO end

REM ALTERANDO PARA O DIRETORIO ONDE EST� O EXECUT�VEL DO SpecRun
@cd SpecFlowPlusRunner\

REM SETANDO UM PROFILE DE EXECU��O
@SET profile=%1

REM CASO N�O TENHA UM DEFINIDO UTILIZA O PADR�O
@IF "%profile%" == "" SET profile=Default

REM EXECU��O DO SpecRun COM UM PROFILE E O DIRETORIO ONDE EST� A DLL DO PROJETO DE TESTES 
SpecRun.exe run %profile%.srprofile "/baseFolder: %curpath%" 

:end

@POPD
