using ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Services;

public interface IAccountPayableService
{
    Task<AccountPayable> Create(CreateAccountPayable accountPayable);
}
