::
:: Created by %USERNAME%
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Run /property:Configuration=Release /v:d App.bmproj