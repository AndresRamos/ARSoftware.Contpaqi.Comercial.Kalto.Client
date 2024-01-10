using System.Net.Http.Json;
using System.Text.Json;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Common;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Services;

public class ProviderService : IProviderService
{
    private readonly HttpClient _httpClient;

    public ProviderService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient(Constants.KaltoApiClientName);
    }

    public async Task<Provider> Create(CreateProviderModel provider)
    {
        var response = await _httpClient.PostAsJsonAsync("providers", provider, new JsonSerializerOptions(JsonSerializerDefaults.Web));

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Provider>() ?? throw new InvalidOperationException();
    }
}
