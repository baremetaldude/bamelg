IF EXIST "%VS140COMNTOOLS%vsvars32.bat" (
	call "%VS140COMNTOOLS%vsvars32.bat"
	goto EXIT
)

IF EXIST "%VS120COMNTOOLS%vsvars32.bat" (
	call "%VS120COMNTOOLS%vsvars32.bat"
	goto EXIT
)

IF EXIST "%VS110COMNTOOLS%vsvars32.bat" (
	call "%VS110COMNTOOLS%vsvars32.bat"
	goto EXIT
)

set PATH="%PATH%;%windir%\Microsoft.NET\Framework\v4.0.30319"

:EXIT
