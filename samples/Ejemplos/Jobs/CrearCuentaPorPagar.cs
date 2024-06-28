using ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Models;
using ARSoftware.Contpaqi.Comercial.Kalto.Client.CuentasPorPagar.Services;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Ejemplos.Jobs;

public class CrearCuentaPorPagar
{
    private readonly IAccountPayableService _accountPayableService;
    private readonly IDocumentoRepository<DocumentoDto> _documentoRepository;
    private readonly ILogger<CrearCuentaPorPagar> _logger;
    private readonly IMapper _mapper;
    private readonly IMovimientoRepository<MovimientoDto> _movimientoRepository;

    public CrearCuentaPorPagar(IDocumentoRepository<DocumentoDto> documentoRepository, IAccountPayableService accountPayableService,
        IMapper mapper, ILogger<CrearCuentaPorPagar> logger, IMovimientoRepository<MovimientoDto> movimientoRepository)
    {
        _documentoRepository = documentoRepository;
        _accountPayableService = accountPayableService;
        _mapper = mapper;
        _logger = logger;
        _movimientoRepository = movimientoRepository;
    }

    public async Task Run(string proveedorReference, string codigoConcepto, string serie, int folio)
    {
        var documentoDto = _documentoRepository.BuscarPorLlave(codigoConcepto, serie, folio);

        var documento = _mapper.Map<Documento>(documentoDto);

        _logger.LogInformation("Documento: {@Documento}", documento);

        var createAccountPayable = new CreateAccountPayable
        {
            CustomReference = "6",
            CurrencyCode = "MXN",
            Type = "BILL",
            TotalAmount = documento.Total,
            ProviderReference = proveedorReference
        };

        var accountPayable = await _accountPayableService.Create(createAccountPayable);

        _logger.LogInformation("Cuenta por pagar creada: {@AccountPayable}", accountPayable);
    }
}
