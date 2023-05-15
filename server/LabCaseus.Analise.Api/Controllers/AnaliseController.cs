using LabCaseus.Analise.Application.Commands.RegistrarCertificadoAnalise;
using LabCaseus.Analise.Application.Mediator;
using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Application.Queries.BuscarCertificadoAnalisePeloUId;
using LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise;
using LabCaseus.Analise.Domain;
using LabCaseus.Analise.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
             IClienteRepository clienteRepository): base(logger, notifications)
        {
            _mediator = mediator;
            _certificadoAnaliseRepository = certificadoAnaliseRepository;
            _farmaceuticoRepository = farmaceuticoRepository;
            _clienteRepository = clienteRepository;
        }

        [HttpPost]
        [Route("certificados-analises/registrar")]
        //[Authorize(Roles = UserRoles.Admin)]
        public async Task<ActionResult> RegistrarCertificadoAnaliseAsync([FromBody] RegistrarCertificadoAnaliseCommand command, CancellationToken cancellationToken)
        {
            await _mediator.SendCommand(command, cancellationToken);

            return ResponseApiCreatedAtAction(nameof(BuscarCertificadoAnalisePeloUIdAsync), new { certificadoAnaliseUId = command.CertificadoAnaliseUId }, command);
        }

        [HttpGet]
        [Route("certificados-analises/buscar-todos")]
        //[Authorize]
        public async Task<ActionResult> BuscarTodosCertificadosAnaliseAsync(CancellationToken cancellationToken)
        {
            var query = new BuscarTodosCertificadosAnaliseQuery();

            await _mediator.SendCommand(query, cancellationToken);

            return ResponseApiOk(query.GetResponse());
        }

        [HttpGet]
        [Route("certificados-analises/buscar-pelo-uid/{certificadoAnaliseUId}")]
        //[Authorize]
        public async Task<ActionResult> BuscarCertificadoAnalisePeloUIdAsync([FromRoute] Guid certificadoAnaliseUId, CancellationToken cancellationToken)
        {
            var query = new BuscarCertificadoAnalisePeloUIdQuery(certificadoAnaliseUId);

            await _mediator.SendCommand(query, cancellationToken);

            if (query.GetResponse() == null) return ResponseApiNotFound();

            return ResponseApiOk(query.GetResponse());
        }

        [HttpGet]
        [Route("certificados-analises/buscar-especificacoes-metodologias")]
        //[Authorize]
        public async Task<ActionResult> BuscarEspecificacoesMetodologiaAsync(CancellationToken cancellationToken)
        {
            return ResponseApiOk(await _certificadoAnaliseRepository.BuscarEspecificacoesMetodologiaAsNoTrackingAsync(cancellationToken));
        }

        [HttpGet]
        [Route("certificados-analises/buscar-farmaceuticos")]
        //[Authorize]
        public async Task<ActionResult> BuscarFarmaceuticosResponsaveisAsync(CancellationToken cancellationToken)
        {
            return ResponseApiOk(await _farmaceuticoRepository.BuscarFarmaceuticosAsNoTrackingAsync(cancellationToken));
        }

        [HttpGet]
        [Route("certificados-analises/buscar-clientes")]
        //[Authorize]
        public async Task<ActionResult> BuscarClientesAsync(CancellationToken cancellationToken)
        {
            return ResponseApiOk(await _clienteRepository.BuscarClientesAsNoTrackingAsync(cancellationToken));
        }
    }
}