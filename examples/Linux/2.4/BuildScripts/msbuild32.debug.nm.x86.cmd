::
:: Created by %USERNAME%
::

cd /d "%~dp0\.."
call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /t:Build /property:Configuration=Debug;ModularBuild=false /v:d App.bmproj
popd