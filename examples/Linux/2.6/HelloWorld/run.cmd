::
:: Created by $USER
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /t:Run /property:Configuration=Release /v:d App.bmproj