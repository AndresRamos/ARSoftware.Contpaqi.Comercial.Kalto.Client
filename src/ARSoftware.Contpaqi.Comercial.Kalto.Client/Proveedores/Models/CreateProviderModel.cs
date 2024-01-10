namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;

public record CreateProviderModel
{
    /// <summary>
    ///     Identificador externo para el proveedor.
    /// </summary>
    public string CustomReference { get; init; } = string.Empty;

    /// <summary>
    ///     RFC - tax id.
    /// </summary>
    public string TaxId { get; init; } = string.Empty;

    /// <summary>
    ///     Mail principal, a donde se enviarán los comprobantes de las dispersiones.
    /// </summary>
    public string Email { get; init; } = string.Empty;

    /// <summary>
    ///     Nombre comercial.
    /// </summary>
    public string CommercialName { get; init; } = string.Empty;

    /// <summary>
    ///     Razón social.
    /// </summary>
    public string BusinessName { get; init; } = string.Empty;

    /// <summary>
    ///     Plazo de pago para ordenes de pago.
    /// </summary>
    public int NetTerms { get; init; }

    /// <summary>
    ///     Cuenta de proveedor a la cual dispersar pagos.
    /// </summary>
    public string DisbursementAccount { get; init; } = string.Empty;
}
