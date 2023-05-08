using LabCaseus.Analise.Domain.Entities;

namespace LabCaseus.Analise.Domain.Repositories
{
    public interface IFarmaceuticoRepository
    {
        Task<List<Farmaceutico>> BuscarFarmaceuticosAsNoTrackingAsync(CancellationToken cancellationToken = default);
    }
}