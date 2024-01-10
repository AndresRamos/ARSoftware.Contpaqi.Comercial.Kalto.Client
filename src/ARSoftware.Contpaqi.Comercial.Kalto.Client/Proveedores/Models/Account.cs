namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;

public class Account
{
    /// <summary>
    ///     Cuenta de proveedor a la cual dispersar pagos.
    /// </summary>
    public string AccountNumber { get; init; } = string.Empty;

    /// <summary>
    ///     Nombre corto de banco inferido del número de cuenta.
    /// </summary>
    public string BankName { get; init; } = string.Empty;
}
