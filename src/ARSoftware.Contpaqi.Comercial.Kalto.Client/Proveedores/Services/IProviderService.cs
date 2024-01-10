using ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Services;

public interface IProviderService
{
    Task<Provider> Create(CreateProviderModel provider);
}
