namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;

public record CreateAccountPayableDetail
{
    public required string ItemName { get; init; }

    public required decimal Quantity { get; init; }

    public required decimal UnitPrice { get; init; }
}
