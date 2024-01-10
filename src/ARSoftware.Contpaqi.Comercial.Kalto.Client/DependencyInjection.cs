using System.Net.Http.Headers;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Common;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Services;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client;

public static class DependencyInjection
{
    public static IServiceCollection AddKaltoServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<KaltoConfig>(configuration.GetSection(nameof(KaltoConfig)));

        services.AddHttpClient(Constants.KaltoApiClientName, (provider, client) =>
        {
            var kaltoConfigOptions = provider.GetRequiredService<IOptions<KaltoConfig>>();
            var kaltoConfig = kaltoConfigOptions.Value;
            client.BaseAddress = new Uri("https://api-sbx.kalto.la/kalto/api/v1/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("X-Merchant-Key", kaltoConfig.MerchantKey);
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", Utils.EncodeBasicAuth(kaltoConfig.UserName, kaltoConfig.Password));
        });

        services.AddTransient<IProviderService, ProviderService>();
        services.AddTransient<IAccountPayableService, AccountPayableService>();

        return services;
    }
}
