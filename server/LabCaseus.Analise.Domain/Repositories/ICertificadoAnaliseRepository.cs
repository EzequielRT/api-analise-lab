using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Domain.Repositories
{
    public interface ICertificadoAnaliseRepository
    {
        Task<List<CertificadoAnalise>> BuscarTodosCertificadosAnaliseAsync(CancellationToken cancellationToken = default);
        Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default);
        Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsNoTrackingAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default);
        Task<List<EspecificacaoMetodologia>> BuscarEspecificacoesMetodologiaAsNoTrackingAsync(CancellationToken cancellationToken = default);
        Task AdicionarFarmaceuticoResponsavelAsync(FarmaceuticoResponsavel farmaceuticoResponsavel, CancellationToken cancellationToken = default);
        Task AdicionarPhAsync(Ph ph, CancellationToken cancellationToken = default);
        Task AdicionarFerroAsync(Ferro ferro, CancellationToken cancellationToken = default);
        Task AdicionarTurbidezAsync(Turbidez turbidez, CancellationToken cancellationToken = default);
        Task AdicionarCloretoAsync(Cloreto cloreto, CancellationToken cancellationToken = default);
        Task AdicionarCorAparenteAsync(CorAparente corAparente, CancellationToken cancellationToken = default);
        Task AdicionarAspectoVisualAsync(AspectoVisual aspectoVisual, CancellationToken cancellationToken = default);
        Task AdicionarCloroResidualLivreAsync(CloroResidualLivre cloroResidualLivre, CancellationToken cancellationToken = default);
        Task AdicionarSolidosTotaisDissolvidosAsync(SolidosTotaisDissolvidos solidosTotaisDissolvidos, CancellationToken cancellationToken = default);
        Task AdicionarColiformeTermotoleranteAsync(ColiformeTermotolerante coliformeTermotolerante, CancellationToken cancellationToken = default);
    }
}