using LabCaseus.Analise.Application.DTOs;
using LabCaseus.Analise.Application.Mediator;
using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Domain.Repositories;
using MediatR;

namespace LabCaseus.Analise.Application.Queries.BuscarCertificadoAnalisePeloUId
{
    public class BuscarCertificadoAnalisePeloUIdQueryHandler : CommandHandler,
       IRequestHandler<BuscarCertificadoAnalisePeloUIdQuery, bool>
    {
        private readonly ICertificadoAnaliseRepository _certificadoAnaliseRepository;

        public BuscarCertificadoAnalisePeloUIdQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            ICertificadoAnaliseRepository certificadoAnaliseRepository) : base(mediator, notifications)
        {
            _certificadoAnaliseRepository = certificadoAnaliseRepository;
        }

        public async Task<bool> Handle(BuscarCertificadoAnalisePeloUIdQuery request, CancellationToken cancellationToken)
        {
            var certificadosAnalise = await _certificadoAnaliseRepository.BuscarCertificadoAnalisePeloUIdAsNoTrackingAsync(request.CertificadoAnaliseUId, cancellationToken);

            var certificadosAnaliseViewModel = CertificadoAnaliseViewModel.FromEntity(certificadosAnalise);

            request.SetResponse(certificadosAnaliseViewModel);

            return true;
        }
    }
}