﻿using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Application.Mediator;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LabCaseus.Analise.Application.Commands.RegistrarCertificadoAnalise;
using LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise;

namespace LabCaseus.Analise.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/")]
    public class AnaliseController : ApiController
    {
        private readonly IMediatorHandler _mediator;

        public AnaliseController(
             ILogger<AnaliseController> logger,
             INotificationHandler<DomainNotification> notifications,
             IMediatorHandler mediator) : base(logger, notifications)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("certificados-analises/registrar")]
        public async Task<ActionResult> RegistrarCertificadoAnalise([FromBody] RegistrarCertificadoAnaliseCommand command, CancellationToken cancellationToken)
        {
            await _mediator.SendCommand(command, cancellationToken);

            return ResponseApiCreatedAtAction(nameof(BuscarCertificadoAnalisePeloUId), new { certificadoAnaliseUId = command }, command);
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
            return ResponseApiOk();
        }
    }
}