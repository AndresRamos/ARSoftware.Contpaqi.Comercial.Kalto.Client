namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;

public class Provider
{
    /// <summary>
    ///     Identificador único.
    /// </summary>
    public string Reference { get; init; } = string.Empty;

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
    ///     Preferencias.
    /// </summary>
    public ProviderPreferences Preferences { get; init; } = new();
}
