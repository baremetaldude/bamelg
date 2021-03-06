::
:: Created by Eugeny Grishul
::

@IF NOT DEFINED INCLUDE GOTO SETENV
@IF NOT DEFINED LIB GOTO SETENV
@IF NOT DEFINED LIBPATH GOTO SETENV
@goto EXIT

:SETENV

@IF EXIST "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsDevCmd.bat" (
	pushd .
	call "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsDevCmd.bat"
	popd
	@goto EXIT
)

@IF EXIST "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\Common7\Tools\VsDevCmd.bat" (
	pushd .
	call "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\Common7\Tools\VsDevCmd.bat"
	popd
	@goto EXIT
)

@IF EXIST "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat" (
	pushd .
	call "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"
	popd
	@goto EXIT
)

@IF EXIST "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat" (
	pushd .
	call "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat"
	popd
	@goto EXIT
)

@IF EXIST "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Professional\Common7\Tools\VsDevCmd.bat" (
	pushd .
	call "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Professional\Common7\Tools\VsDevCmd.bat"
	popd
	@goto EXIT
)

@IF EXIST "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat" (
	pushd .
	call "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat"
	popd
	@goto EXIT
)

@IF EXIST "%VS140COMNTOOLS%vsvars32.bat" (
	@call "%VS140COMNTOOLS%vsvars32.bat"
	@goto EXIT
)

@IF EXIST "%VS120COMNTOOLS%vsvars32.bat" (
	@call "%VS120COMNTOOLS%vsvars32.bat"
	@goto EXIT
)

@IF EXIST "%VS110COMNTOOLS%vsvars32.bat" (
	@call "%VS110COMNTOOLS%vsvars32.bat"
	@goto EXIT
)

@set PATH="%PATH%;%windir%\Microsoft.NET\Framework\v4.0.30319"

:EXIT
