@echo off
setlocal enabledelayedexpansion

set pre=Microsoft.VisualStudio.Product.
set ids=%pre%Community %pre%Professional %pre%Enterprise %pre%BuildTools
for /f "usebackq tokens=1* delims=: " %%i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15.0^,16.0^) -products %ids% -requires Microsoft.Component.MSBuild`) do (
  if /i "%%i"=="installationPath" set InstallDir=%%j
)

if not exist "%InstallDir%\MSBuild\15.0\Bin\MSBuild.exe" (
 exit 1
)

"%InstallDir%\MSBuild\15.0\Bin\MSBuild.exe" %*