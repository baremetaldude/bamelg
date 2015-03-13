::
:: Created by Eugeny Grishul
::

pushd "%~dp0"
"%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" /t:Rebuild /property:Configuration=Release /v:d App.bmproj
popd