using LabCaseus.Analise.Domain.Repositories;

namespace LabCaseus.Analise.Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        ICertificadoAnaliseRepository CertificadosAnalises { get; }
        Task<bool> CompleteAsync();
        Task BeginTransactionAsync();
        Task CommitAsync();
    }
}