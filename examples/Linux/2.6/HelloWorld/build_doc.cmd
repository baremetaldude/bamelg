::
:: Created by $USER
::

"%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" /property:GenerateCode=false;HtmlBuild=true /v:d App.bmproj
"%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" /property:GenerateCode=false;HtmlBuild=true;HtmlBuildPath=HtmlDocLight;HtmlTheme=Light /v:d App.bmproj

pause