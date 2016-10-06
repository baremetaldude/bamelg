::
:: Created by %USERNAME%
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Build /property:Configuration=Release /v:d App.bmproj