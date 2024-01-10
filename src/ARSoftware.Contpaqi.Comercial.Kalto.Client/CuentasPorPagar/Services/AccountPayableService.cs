using System.Net.Http.Json;
using System.Text.Json;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Common;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Services;

public class AccountPayableService : IAccountPayableService
{
    private readonly HttpClient _httpClient;

    public AccountPayableService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient(Constants.KaltoApiClientName);
    }

    public async Task<AccountPayable> Create(CreateAccountPayable accountPayable)
    {
        var response =
            await _httpClient.PostAsJsonAsync("accounts-payable", accountPayable, new JsonSerializerOptions(JsonSerializerDefaults.Web));

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AccountPayable>() ?? throw new InvalidOperationException();
    }
}
