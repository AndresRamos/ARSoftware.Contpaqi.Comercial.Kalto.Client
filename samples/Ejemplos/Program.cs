using System.Reflection;
using ARSoftware.Contpaqi.Comercial.Kalto.Client;
using Ejemplos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var host = Host.CreateDefaultBuilder(args)
    .UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddEjemploServices(hostContext.Configuration);
        services.AddKaltoServices(hostContext.Configuration);
    })
    .UseSerilog((hostingContext, loggerConfiguration) =>
    {
        loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration).Enrich.FromLogContext();
    })
    .Build();

var serviceScope = host.Services.CreateScope();

var services = serviceScope.ServiceProvider;

var logger = services.GetRequiredService<ILogger>();

try
{
}
catch (Exception e)
{
    logger.Error(e, "Error al ejecutar el ejemplo");
}
