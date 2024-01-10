using System.Net.Http.Json;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Common;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Pagos.Models;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Pagos.Services;

public class PaymentService
{
    private readonly HttpClient _httpClient;

    public PaymentService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient(Constants.KaltoApiClientName);
    }

    public async Task<IReadOnlyCollection<Payment>> BuscarPorCuentaPorPagarIdAsync(string cuentaPorPagarId)
    {
        var response = await _httpClient.GetAsync($"accounts-payable/payments:search?accountPayableReference={cuentaPorPagarId}");

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<PaymentSearchResponse>() ?? throw new InvalidOperationException();

        return result.Results.ToList();
    }

    public class PaymentSearchResponse
    {
        public IEnumerable<Payment> Results { get; set; } = default!;

        public Page Page { get; set; } = default!;
    }

    public class Page
    {
        public int Number { get; set; }
        public int Size { get; set; }
        public int TotalElements { get; set; }
        public int TotalPages { get; set; }
    }
}
