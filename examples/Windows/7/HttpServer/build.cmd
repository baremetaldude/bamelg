::
:: Created by %USERNAME%
::

pushd "%~dp0"
call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Build /property:Configuration=Release /v:d App.bmproj
popd