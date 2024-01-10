using ARSoftware.Contpaqi.Comercial.Sql;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Factories;
using Ejemplos.Jobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ejemplos;

public static class DependencyInjection
{
    public static IServiceCollection AddEjemploServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddContpaqiComercialServices(configuration);
        services.AddEjemplos();

        return services;
    }

    private static IServiceCollection AddContpaqiComercialServices(this IServiceCollection services, IConfiguration configuration)
    {
        var contpaqiConnection = configuration.GetConnectionString("ContpaqiConnection");

        services.AddDbContext<ContpaqiComercialEmpresaDbContext>(options =>
        {
            var connectionString =
                ContpaqiComercialSqlConnectionStringFactory.CreateContpaqiComercialEmpresaConnectionString(contpaqiConnection,
                    "adUNIVERSIDAD_ROBOTICA");
            options.UseSqlServer(connectionString);
        });

        services.AddContpaqiComercialSqlRepositories();

        return services;
    }

    private static void AddEjemplos(this IServiceCollection services)
    {
        services.AddTransient<CrearProveedor>();
        services.AddTransient<CrearCuentaPorPagar>();
    }
}
