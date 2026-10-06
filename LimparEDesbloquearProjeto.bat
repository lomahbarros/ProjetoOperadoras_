@echo off
chcp 65001 >nul
setlocal enabledelayedexpansion

cd /d "%~dp0"

:MENU
cls
echo Pasta do projeto: %CD%
echo.
echo ==================================
echo    LIMPAR E DESBLOQUEAR PROJETO
echo ==================================
echo.
echo [1] Desbloquear arquivos .resx
echo [2] Limpar pastas bin, obj e .vs
echo [3] Fazer ambos
echo [4] Sair
echo.
set /p "choice=Escolha uma opção: "

if "%choice%"=="1" goto DESBLOQUEAR_WRAPPER
if "%choice%"=="2" goto LIMPAR_WRAPPER
if "%choice%"=="3" goto AMBOS_WRAPPER
if "%choice%"=="4" goto FIM_SCRIPT
goto MENU

:: ==================================================================
:: WRAPPERS
:: ==================================================================
:DESBLOQUEAR_WRAPPER
call :DESBLOQUEAR
goto PERGUNTA_FINAL

:LIMPAR_WRAPPER
call :LIMPAR
goto PERGUNTA_FINAL

:AMBOS_WRAPPER
call :AMBOS
goto PERGUNTA_FINAL

:: ==================================================================
:: FUNÇÃO: DESBLOQUEAR (remove Mark of the Web REAL)
:: ==================================================================
:DESBLOQUEAR
cls
echo Pasta do projeto: %CD%
echo.
echo Desbloqueando arquivos .resx...
echo.

set /a total_found=0
set /a total_unblocked=0

for /R "%CD%" %%F in (*.resx) do (
    set /a total_found+=1

    rem Verifica se o ADS Zone.Identifier existe
    powershell -NoProfile -Command ^
        "$s = Get-Item -LiteralPath '%%~fF' -Stream Zone.Identifier -ErrorAction SilentlyContinue; if ($s) { Remove-Item -LiteralPath '%%~fF' -Stream Zone.Identifier -ErrorAction SilentlyContinue; exit 1 } else { exit 0 }"

    if !errorlevel! EQU 1 (
        echo Desbloqueado: %%~nxF
        set /a total_unblocked+=1
    )
)

if !total_found! EQU 0 (
    echo Nenhum arquivo .resx encontrado.
) else if !total_unblocked! EQU 0 (
    echo Todos os arquivos .resx já estavam desbloqueados.
) else (
    echo.
    echo Total de arquivos desbloqueados: !total_unblocked!
)

echo.
echo Pressione qualquer tecla para continuar...
pause >nul
goto :eof

:: ==================================================================
:: FUNÇÃO: LIMPAR
:: ==================================================================
:LIMPAR
cls
echo Pasta do projeto: %CD%
echo.
echo Limpando pastas bin, obj e .vs...
echo.

echo Limpando bin...
set "found_bin=0"
for /f "delims=" %%D in ('dir /b /s /ad bin 2^>nul') do (
    echo     Removido: %%~nxD
    rmdir /s /q "%%D" 2>nul
    set "found_bin=1"
)
if "!found_bin!"=="0" echo     Nenhuma pasta 'bin' encontrada.

echo.
echo Limpando obj...
set "found_obj=0"
for /f "delims=" %%D in ('dir /b /s /ad obj 2^>nul') do (
    echo     Removido: %%~nxD
    rmdir /s /q "%%D" 2>nul
    set "found_obj=1"
)
if "!found_obj!"=="0" echo     Nenhuma pasta 'obj' encontrada.

echo.
echo Limpando .vs...
set "found_vs=0"
set "vs_removed_any=0"

rem percorre todas as pastas .vs encontradas (apenas uma vez o título acima)
for /f "delims=" %%D in ('dir /b /s /ad .vs 2^>nul') do (
    set "found_vs=1"
    rem percorre subpastas IMEDIATAS dentro de cada .vs
    for /f "delims=" %%X in ('dir /b /ad "%%D\*" 2^>nul') do (
        echo     Removido: %%~nxX
        rmdir /s /q "%%D\%%X" 2>nul
        set "vs_removed_any=1"
    )
)

if "!found_vs!"=="0" (
    echo     Nenhuma pasta '.vs' encontrada.
) else (
    if "!vs_removed_any!"=="0" echo     ^(nenhum item para remover^)
)

echo.
echo Limpeza concluída!
echo.
echo Pressione qualquer tecla para continuar...
pause >nul
goto :eof

:: ==================================================================
:: FUNÇÃO: AMBOS
:: ==================================================================
:AMBOS
cls
echo Pasta do projeto: %CD%
echo.
echo Executando todas as tarefas...
echo.
echo --- [1/2] Desbloqueando ---
echo.
call :DESBLOQUEAR_SEM_CLS
echo.
echo --- [2/2] Limpando ---
echo.
call :LIMPAR_SEM_CLS
echo.
echo Todas as tarefas concluídas!
echo.
echo Pressione qualquer tecla para continuar...
pause >nul
goto :eof

:: ==================================================================
:: DESBLOQUEAR SEM CLS
:: ==================================================================
:DESBLOQUEAR_SEM_CLS
set /a total_found=0
set /a total_unblocked=0
for /R "%CD%" %%F in (*.resx) do (
    set /a total_found+=1

    powershell -NoProfile -Command ^
        "$s = Get-Item -LiteralPath '%%~fF' -Stream Zone.Identifier -ErrorAction SilentlyContinue; if ($s) { Remove-Item -LiteralPath '%%~fF' -Stream Zone.Identifier -ErrorAction SilentlyContinue; exit 1 } else { exit 0 }"

    if !errorlevel! EQU 1 (
        echo    Desbloqueado: %%~nxF
        set /a total_unblocked+=1
    )
)

if !total_found! EQU 0 (
    echo    Nenhum arquivo .resx encontrado.
) else if !total_unblocked! EQU 0 (
    echo    Todos os arquivos .resx já estavam desbloqueados.
) else (
    echo.
    echo    Total de arquivos desbloqueados: !total_unblocked!
)
goto :eof

:: ==================================================================
:: LIMPAR SEM CLS
:: ==================================================================
:LIMPAR_SEM_CLS
echo    Limpando bin...
set "found_bin=0"
for /f "delims=" %%D in ('dir /b /s /ad bin 2^>nul') do (
    echo        Removido: %%~nxD
    rmdir /s /q "%%D" 2>nul
    set "found_bin=1"
)
if "!found_bin!"=="0" echo        Nenhuma pasta 'bin' encontrada.

echo.
echo    Limpando obj...
set "found_obj=0"
for /f "delims=" %%D in ('dir /b /s /ad obj 2^>nul') do (
    echo        Removido: %%~nxD
    rmdir /s /q "%%D" 2>nul
    set "found_obj=1"
)
if "!found_obj!"=="0" echo        Nenhuma pasta 'obj' encontrada.

echo.
echo    Limpando .vs...
set "found_vs=0"
set "vs_removed_any=0"

for /f "delims=" %%D in ('dir /b /s /ad .vs 2^>nul') do (
    set "found_vs=1"
    for /f "delims=" %%X in ('dir /b /ad "%%D\*" 2^>nul') do (
        echo        Removido: %%~nxX
        rmdir /s /q "%%D\%%X" 2>nul
        set "vs_removed_any=1"
    )
)

if "!found_vs!"=="0" (
    echo        Nenhuma pasta '.vs' encontrada.
) else (
    if "!vs_removed_any!"=="0" echo        ^(nenhum item para remover^)
)

goto :eof

:: ==================================================================
:: PERGUNTA FINAL
:: ==================================================================
:PERGUNTA_FINAL
cls

set "SLN="
set "SLN_NAME="

for /R "%CD%" %%S in (*.sln) do (
    set "SLN=%%~fS"
    set "SLN_NAME=%%~nxS"
    goto ENCONTROU_SLN
)

echo.
echo Nenhuma solucao (.sln) encontrada nesta pasta ou subpastas.
echo.
echo Pressione qualquer tecla para fechar...
pause >nul
goto FIM_SCRIPT

:ENCONTROU_SLN
cls
echo Pasta do projeto: %CD%
echo.
echo Solução encontrada: !SLN_NAME!
echo.
set /p "abrir=Deseja abrir o projeto agora? (s/n): "
if /I "!abrir!"=="s" (
    start "" "!SLN!"
)
goto FIM_SCRIPT

:FIM_SCRIPT
endlocal
exit /b
