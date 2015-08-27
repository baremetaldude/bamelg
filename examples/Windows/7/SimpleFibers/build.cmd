::
:: Created by %USERNAME%
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Rebuild /property:Configuration=Release /v:d App.bmproj