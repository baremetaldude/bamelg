::
:: Created by %USERNAME%
::

pushd "%~dp0\.."
call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /t:Build /property:Configuration=Debug;ModularBuild=false;TargetCpu=ARM_64 /v:d App.bmproj
popd