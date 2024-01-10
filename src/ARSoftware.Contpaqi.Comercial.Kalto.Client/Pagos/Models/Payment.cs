namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Pagos.Models;

public class Payment
{
    /// <summary>
    ///     Id del pago.
    /// </summary>
    public string reference { get; set; }

    /// <summary>
    ///     Monto del pago.
    /// </summary>
    public decimal amount { get; set; }

    /// <summary>
    ///     Estatus del pago.
    /// </summary>
    public string status { get; set; }

    /// <summary>
    ///     Identificador de la cuenta por pagar
    /// </summary>
    public string accountPayableReference { get; set; }

    /// <summary>
    ///     Metodo de pago utilizado
    /// </summary>
    public string paymentMethod { get; set; }

    /// <summary>
    ///     Fecha de pago
    /// </summary>
    public string paymentDate { get; set; }

    /// <summary>
    ///     Fecha de creación
    /// </summary>
    public string created { get; set; }

    /// <summary>
    ///     Fecha de última modificación
    /// </summary>
    public string updated { get; set; }
}
