namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;

/// <summary>
///     Modelo para crear una cuenta por pagar.
/// </summary>
public record CreateAccountPayable
{
    public required string CustomReference { get; init; }

    public required string CurrencyCode { get; init; }

    public required string Type { get; init; }

    public decimal TotalAmount { get; init; }

    public required string ProviderReference { get; init; }

    public List<CreateAccountPayableDetail>? Details { get; init; }
}
