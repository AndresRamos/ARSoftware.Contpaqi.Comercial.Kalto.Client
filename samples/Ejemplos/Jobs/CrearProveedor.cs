using ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Models;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.Proveedores.Services;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Ejemplos.Jobs;

public class CrearProveedor
{
    private readonly IClienteProveedorRepository<ClienteProveedorDto> _clienteRepository;
    private readonly ILogger<CrearProveedor> _logger;
    private readonly IMapper _mapper;
    private readonly IProviderService _providerService;

    public CrearProveedor(IProviderService providerService, IClienteProveedorRepository<ClienteProveedorDto> clienteRepository,
        IMapper mapper, ILogger<CrearProveedor> logger)
    {
        _providerService = providerService;
        _clienteRepository = clienteRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task Run()
    {
        var proveedorDto = _clienteRepository.BuscarPorCodigo("PROVKALTO");

        var proveedor = _mapper.Map<ClienteProveedor>(proveedorDto);

        _logger.LogInformation("Proveedor: {@Proveedor}", proveedor);

        var createProvider = new CreateProviderModel
        {
            BusinessName = proveedor.RazonSocial,
            CommercialName = proveedor.RazonSocial,
            CustomReference = proveedor.Codigo,
            TaxId = proveedor.Rfc,
            DisbursementAccount = "112545676894213551",
            Email = "cliente4@myemail.com",
            NetTerms = 15
        };

        var provider = await _providerService.Create(createProvider);

        _logger.LogInformation("Proveedor creado: {@Proveedor}", provider);
    }
}
