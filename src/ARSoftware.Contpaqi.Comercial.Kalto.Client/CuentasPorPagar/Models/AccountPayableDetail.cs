namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;

public class AccountPayableDetail
{
    /// <summary>
    ///     Concepto - descripción.
    /// </summary>
    public string ItemName { get; set; } = string.Empty;

    /// <summary>
    ///     Cantidad.
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    ///     Precio unitario.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    ///     Resultado Quantity * UnitPrice.
    /// </summary>
    public decimal TotalAmount { get; set; }
}
