::
:: Created by $USER
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Rebuild /property:Configuration=Release /v:d App.bmproj