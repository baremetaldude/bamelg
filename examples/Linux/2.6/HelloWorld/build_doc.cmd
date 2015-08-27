::
:: Created by $USER
::

call ..\..\..\vs_environment.cmd
MSBuild.exe /property:GenerateCode=false;HtmlBuild=true /v:d App.bmproj
MSBuild.exe /property:GenerateCode=false;HtmlBuild=true;HtmlBuildPath=HtmlDocLight;HtmlTheme=Light /v:d App.bmproj
