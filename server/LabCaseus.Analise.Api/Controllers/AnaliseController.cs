using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Application.Mediator;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LabCaseus.Analise.Application.Commands.RegistrarCertificadoAnalise;
using LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise;
using LabCaseus.Analise.Application.Queries.BuscarCertificadoAnalisePeloUId;
using LabCaseus.Analise.Domain.Repositories;

namespace LabCaseus.Analise.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/")]
    public class AnaliseController : ApiController
    {
        private readonly IMediatorHandler _mediator;
        private readonly ICertificadoAnaliseRepository _certificadoAnaliseRepository;
        private readonly IFarmaceuticoRepository _farmaceuticoRepository;
        private readonly IClienteRepository _clienteRepository;

        public AnaliseController(
             ILogger<AnaliseController> logger,
             INotificationHandler<DomainNotification> notifications,
             IMediatorHandler mediator,
             ICertificadoAnaliseRepository certificadoAnaliseRepository,
             IFarmaceuticoRepository farmaceuticoRepository,
             IClienteRepository clienteRepository) : base(logger, notifications)
        {
            _mediator = mediator;
            _certificadoAnaliseRepository = certificadoAnaliseRepository;
            _farmaceuticoRepository = farmaceuticoRepository;
            _clienteRepository = clienteRepository;
        }

        [HttpPost]
        [Route("certificados-analises/registrar")]
        public async Task<ActionResult> RegistrarCertificadoAnalise([FromBody] RegistrarCertificadoAnaliseCommand command, CancellationToken cancellationToken)
        {
            await _mediator.SendCommand(command, cancellationToken);

            return ResponseApiCreatedAtAction(nameof(BuscarCertificadoAnalisePeloUId), new { certificadoAnaliseUId = command.CertificadoAnaliseUId }, command);
        }

        [HttpGet]
        [Route("certificados-analises/buscar-todos")]
        public async Task<ActionResult> BuscarTodosCertificadosAnalise(CancellationToken cancellationToken)
        {
            var query = new BuscarTodosCertificadosAnaliseQuery();

            await _mediator.SendCommand(query, cancellationToken);

            return ResponseApiOk(query.GetResponse());
        }

        [HttpGet]
        [Route("certificados-analises/buscar-pelo-uid/{certificadoAnaliseUId}")]
        public async Task<ActionResult> BuscarCertificadoAnalisePeloUId([FromRoute] Guid certificadoAnaliseUId, CancellationToken cancellationToken)
        {
            var query = new BuscarCertificadoAnalisePeloUIdQuery(certificadoAnaliseUId);

            await _mediator.SendCommand(query, cancellationToken);

            if (query.GetResponse() == null) return ResponseApiNotFound();

            return ResponseApiOk(query.GetResponse());
        }

        [HttpGet]
        [Route("certificados-analises/buscar-especificacoes-metodologias")]
        public async Task<ActionResult> BuscarEspecificacoesMetodologia(CancellationToken cancellationToken)
        {
            return ResponseApiOk(await _certificadoAnaliseRepository.BuscarEspecificacoesMetodologiaAsNoTrackingAsync(cancellationToken));
        }

        [HttpGet]
        [Route("certificados-analises/buscar-farmaceuticos")]
        public async Task<ActionResult> BuscarFarmaceuticosResponsaveis(CancellationToken cancellationToken)
        {
            return ResponseApiOk(await _farmaceuticoRepository.BuscarFarmaceuticosAsNoTrackingAsync(cancellationToken));
        }

        [HttpGet]
        [Route("certificados-analises/buscar-clientes")]
        public async Task<ActionResult> BuscarClientes(CancellationToken cancellationToken)
        {
            return ResponseApiOk(await _clienteRepository.BuscarClientesAsNoTrackingAsync(cancellationToken));
        }
    }
}