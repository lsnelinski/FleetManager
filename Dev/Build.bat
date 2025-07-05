@echo off
setlocal

set SOLUTION_PATH=..\Source\FleetManager.sln
set BUILD_CONFIG=Debug

for /f "tokens=* delims=" %%i in ('vswhere.exe -latest -products * -requires Microsoft.Component.MSBuild -property installationPath') do (
    set "VSINSTALLDIR=%%i"
)

if "%VSINSTALLDIR%"=="" (
    echo [ERROR] Visual Studio installation not found.
    goto :eof
)

set "MSBUILD_PATH=%VSINSTALLDIR%\MSBuild\Current\Bin\MSBuild.exe"

if not exist "%MSBUILD_PATH%" (
    echo [ERROR] MSBuild.exe not found at: %MSBUILD_PATH%
    goto :eof
)

nuget restore "%SOLUTION_PATH%" -configFile ..\nuget.config
if errorlevel 1 (
    echo [ERROR] NuGet restore failed.
    goto :eof
)

"%MSBUILD_PATH%" "%SOLUTION_PATH%" /m /p:Configuration=%BUILD_CONFIG% /nologo /v:minimal
if errorlevel 1 (
    echo [ERROR] Build failed.
    goto :eof
)

endlocal
pause
