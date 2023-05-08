using LabCaseus.Analise.Domain.Entities;

namespace LabCaseus.Analise.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task AdicionarClienteAsync(Cliente cliente, CancellationToken cancellationToken = default);
        Task<List<Cliente>> BuscarClientesAsNoTrackingAsync(CancellationToken cancellationToken = default);
    }
}