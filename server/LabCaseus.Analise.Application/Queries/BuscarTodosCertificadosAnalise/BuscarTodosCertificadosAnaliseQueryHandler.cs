using LabCaseus.Analise.Application.DTOs;
using LabCaseus.Analise.Domain.Repositories;
using MediatR;

namespace LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise
{
    public class BuscarTodosCertificadosAnaliseQueryHandler :
        IRequestHandler<BuscarTodosCertificadosAnaliseQuery, List<CertificadoAnaliseViewModel>>
    {
        private readonly ICertificadoAnaliseRepository _certificadoAnaliseRepository;

        public BuscarTodosCertificadosAnaliseQueryHandler(
            ICertificadoAnaliseRepository certificadoAnaliseRepository)
        {
            _certificadoAnaliseRepository = certificadoAnaliseRepository;
        }

        public async Task<List<CertificadoAnaliseViewModel>> Handle(BuscarTodosCertificadosAnaliseQuery request, CancellationToken cancellationToken)
        {
            var certificadosAnalise = await _certificadoAnaliseRepository.BuscarTodosCertificadosAnaliseAsync(cancellationToken);

            var certificadosAnaliseViewModel = certificadosAnalise
                .Select(x => CertificadoAnaliseViewModel.FromEntity(x))
                .ToList();

            return certificadosAnaliseViewModel;
        }
    }
}