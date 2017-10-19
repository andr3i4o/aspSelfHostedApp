# ASP.NET Self Host Demo Application
Basic self host demo POC with Topshelf framework

In order to install the api as Service write cmd in the Start menu. Right click and open it as Administrator. copy and paste:

cd C:\Windows\Microsoft.NET\Framework\v4.0.30319

hit Enter.

then paste:
installutil {PATH_TO_THE_FILE}\WindowsService_HostAPI\WindowsService_HostAPI\bin\Debug\WindowsService_HostAPI.exe

hit Enter.

Open Start menu and write Services.
Find Self Host Web API Demo, click with right button and press start.