::
:: Created by $USER
::

cd /d "%~dp0\.."
call ..\..\..\vs_environment.cmd
MSBuild.exe /nologo /property:GenerateCode=false;HtmlBuild=true /v:d App.bmproj
MSBuild.exe /nologo /property:GenerateCode=false;HtmlBuild=true;HtmlBuildPath=HtmlDocLight;HtmlTheme=Light /v:d App.bmproj
popd