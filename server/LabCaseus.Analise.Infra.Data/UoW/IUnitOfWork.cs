using LabCaseus.Analise.Domain.Repositories;

namespace LabCaseus.Analise.Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        ICertificadoAnaliseRepository CertificadosAnalises { get; }
        IFarmaceuticoRepository Farmaceuticos { get; }
        IClienteRepository Clientes { get; }
        Task<bool> CompleteAsync(CancellationToken cancellationToken = default);
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task CommitAsync(CancellationToken cancellationToken = default);
    }
}