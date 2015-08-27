::
:: Copyright © Eugeny Grishul
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /clp:ErrorsOnly /maxcpucount /verbosity:q /t:BuildRelease all.proj
