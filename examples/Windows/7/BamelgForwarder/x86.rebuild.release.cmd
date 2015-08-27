::
:: Created by Eugeny Grishul
::

pushd "%~dp0"
call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Rebuild /property:Configuration=Release /v:d App.bmproj
popd