::
:: Created by Eugeny Grishul
::

pushd "%~dp0"
call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Rebuild /property:Configuration=Distribution;GenerateMapFile=true;GenerateMapFile=true;GenerateAssemblySource=true;MapExports=true /v:d App.bmproj
popd