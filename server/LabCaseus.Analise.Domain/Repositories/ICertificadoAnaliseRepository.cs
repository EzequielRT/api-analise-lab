using LabCaseus.Analise.Domain.Entities;

namespace LabCaseus.Analise.Domain.Repositories
{
    public interface ICertificadoAnaliseRepository
    {
        Task<List<CertificadoAnalise>> BuscarTodosCertificadosAnaliseAsync(CancellationToken cancellationToken = default);
        Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default);
        Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsNoTrackingAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default);
    }
}