::
:: Created by $USER
::

call vs_environment.cmd
MSBuild.exe /nologo /clp:ErrorsOnly /v:q /maxcpucount /t:Validate all.proj
