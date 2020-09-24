::
:: Created by %USERNAME%
::

pushd "%~dp0\.."
call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /t:Build /property:Configuration=Distribution;TargetCpu=X86_64;GenerateMapFile=true;IntermediateOutput=true /v:d App.bmproj
popd