using LabCaseus.Analise.Application.DTOs;
using LabCaseus.Analise.Domain.Repositories;
using MediatR;

namespace LabCaseus.Analise.Application.Queries.BuscarCertificadoAnalisePeloUId
{
    public class BuscarCertificadoAnalisePeloUIdQueryHandler :
       IRequestHandler<BuscarCertificadoAnalisePeloUIdQuery, CertificadoAnaliseViewModel>
    {
        private readonly ICertificadoAnaliseRepository _certificadoAnaliseRepository;

        public BuscarCertificadoAnalisePeloUIdQueryHandler(
            ICertificadoAnaliseRepository certificadoAnaliseRepository)
        {
            _certificadoAnaliseRepository = certificadoAnaliseRepository;
        }

        public async Task<CertificadoAnaliseViewModel> Handle(BuscarCertificadoAnalisePeloUIdQuery request, CancellationToken cancellationToken)
        {
            var certificadosAnalise = await _certificadoAnaliseRepository.BuscarCertificadoAnalisePeloUIdAsNoTrackingAsync(request.CertificadoAnaliseUId, cancellationToken);

            var certificadosAnaliseViewModel = CertificadoAnaliseViewModel.FromEntity(certificadosAnalise);

            return certificadosAnaliseViewModel;
        }
    }
}