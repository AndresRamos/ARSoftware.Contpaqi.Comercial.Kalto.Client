namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;

public class AccountPayable
{
    /// <summary>
    ///     Identificador único de factura.
    /// </summary>
    public string Reference { get; set; } = string.Empty;

    /// <summary>
    ///     Referencia externa provista por cliente, único.
    /// </summary>
    public string CustomReference { get; set; } = string.Empty;

    /// <summary>
    ///     Señala si el account-payable es un adelanto o una bill .
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    ///     Solo disponible si el account payable es de tipo UPFRONT.
    /// </summary>
    public string upfrontApplication { get; set; } = string.Empty;

    /// <summary>
    ///     Solo soportado “MXN”(default).
    /// </summary>
    public string CurrencyCode { get; set; } = string.Empty;

    /// <summary>
    ///     Monto total (calculado en base a detalles en caso de agregar el detalle).
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    ///     Monto pendiente de pago de la cuenta por pagar.
    /// </summary>
    public decimal PendingAmount { get; set; }

    /// <summary>
    ///     Detalle de items de la factura, en caso de no agregarlos, es obligatorio el monto total.
    /// </summary>
    public List<AccountPayableDetail> Details { get; set; } = new();

    public bool Expired { get; set; }

    public string ProviderReference { get; set; } = string.Empty;

    /// <summary>
    ///     Fecha creacion.
    /// </summary>
    public string created { get; set; } = string.Empty;

    /// <summary>
    ///     Fecha ultima modificacion.
    /// </summary>
    public string updated { get; set; } = string.Empty;

    /// <summary>
    ///     Autogenerado en base al netTerms de proveedor.
    /// </summary>
    public string dueDate { get; set; } = string.Empty;

    /// <summary>
    ///     Uuid de SAT, en caso de ser una factura timbrada.
    /// </summary>
    public string UuidSat { get; set; } = string.Empty;

    /// <summary>
    ///     Webhook al que se notificarán modificaciones de la entidad.
    /// </summary>
    public string WebhookUrl { get; set; } = string.Empty;
}
