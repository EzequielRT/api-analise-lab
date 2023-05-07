using LabCaseus.Analise.Application.Mediator;
using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Domain.Repositories;
using MediatR;

namespace LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise
{
    public class BuscarTodosCertificadosAnaliseQueryHandler : CommandHandler,
        IRequestHandler<BuscarTodosCertificadosAnaliseQuery, bool>
    {
        private readonly ICertificadoAnaliseRepository _certificadoAnaliseRepository;

        public BuscarTodosCertificadosAnaliseQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            ICertificadoAnaliseRepository certificadoAnaliseRepository) : base(mediator, notifications)
        {
            _certificadoAnaliseRepository = certificadoAnaliseRepository;
        }

        public async Task<bool> Handle(BuscarTodosCertificadosAnaliseQuery request, CancellationToken cancellationToken)
        {
            var certificadosAnalise = await _certificadoAnaliseRepository.BuscarTodosCertificadosAnaliseAsync(cancellationToken);

            var certificadosAnaliseViewModel = certificadosAnalise
                .Select(x => CertificadoAnaliseViewModel.FromEntity(x))
                .ToList();

            request.SetResponse(certificadosAnaliseViewModel);

            return true;
        }
    }
}