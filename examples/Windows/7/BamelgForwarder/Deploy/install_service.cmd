::
:: Created by Eugeny Grishul
::

SET CURRENT_DIR=%~dp0
sc create "BamelgForwarder" binPath= "\"%CURRENT_DIR%BamelgForwarder.exe\" /service" start= delayed-auto obj= "NT AUTHORITY\NetworkService" DisplayName= "@%CURRENT_DIR%BamelgForwarder.exe,-100" depend= Tcpip && sc failure "BamelgForwarder" reset= 0 actions= restart/5000 && sc description "BamelgForwarder" "@%CURRENT_DIR%BamelgForwarder.exe,-101"
icacls BamelgForwarder.exe /grant "NT AUTHORITY\NetworkService":RX