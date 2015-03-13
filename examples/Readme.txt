Setup SSH
1.0 Copy contents of 'example.public.rsa' to '~/.ssh/authorized_keys' on your [Linux|FreeBSD] test machine for root account

1.1 Use exising or generate new RSA keys
By default user name is '<SshUser Condition=" '$(SshUser)' == '' ">root</SshUser>'
You can change it by creating App.%USERNAME%.user file in project directory with following content:
	<?xml version="1.0" encoding="utf-8"?>
	<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
		<PropertyGroup>
			<SshUser>some_other_user</SshUser>
			<SshKeyFile>SshKeys\other.private.rsa</SshKeyFile>
		</PropertyGroup>
	</Project>

Most of setting can be overriden in per-user file %LOCALAPPDATA%/Bamelg/Defaults.build:
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
	<PropertyGroup>
		<PlatformToolset>v120</PlatformToolset>
		<SshKeyFile>c:\somekey.rsa</SshKeyFile>
		<SshPrefferedEncryptionAlgorithm>none,arcfour</SshPrefferedEncryptionAlgorithm>
	</PropertyGroup>
</Project>