::
:: Created by $USER
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Build /property:Configuration=Release /v:d App.bmproj