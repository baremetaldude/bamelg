::
:: Created by $USER
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /maxcpucount /t:Reformat all.proj
