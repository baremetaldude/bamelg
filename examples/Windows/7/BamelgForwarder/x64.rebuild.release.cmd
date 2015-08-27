::
:: Created by Eugeny Grishul
::

pushd "%~dp0"
call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Rebuild /property:Configuration=Release;TargetCpu=X86_64 /v:d App.bmproj
popd