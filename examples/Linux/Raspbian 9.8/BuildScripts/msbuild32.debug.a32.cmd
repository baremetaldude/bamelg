::
:: Created by %USERNAME%
::

pushd "%~dp0\.."
call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /t:Build /property:Configuration=Debug /v:d App.bmproj
popd