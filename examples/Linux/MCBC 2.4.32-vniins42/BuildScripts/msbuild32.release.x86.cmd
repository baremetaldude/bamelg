::
:: Created by %USERNAME%
::

cd /d "%~dp0\.."
call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /t:Build /property:Configuration=Release /v:d App.bmproj
popd