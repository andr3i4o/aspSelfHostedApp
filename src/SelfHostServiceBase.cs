using AspNetSelfHostDemo;
using Microsoft.Owin.Hosting;
using System;
using System.ServiceProcess;

public partial class SelfHostServiceBase : ServiceBase
{
    private IDisposable _webapp;

    public SelfHostServiceBase()
    {
        
    }    

    protected override void OnStart(string[] args)
    {
        _webapp = WebApp.Start<Startup>("http://localhost:8080");
    }

    protected override void OnStop()
    {
        _webapp?.Dispose();
    }
}