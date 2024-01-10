namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;

public class ProviderPreferences
{
    /// <summary>
    ///     Plazo de pago para ordenes de pago.
    /// </summary>
    public int NetTerms { get; init; }

    public Account DisbursementAccount { get; init; } = new();
}
