using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LabCaseus.Analise.Infra.Data.Repositories
{
    public class FarmaceuticoRepository : IFarmaceuticoRepository
    {
        private readonly ApplicationDbContext _context;

        public FarmaceuticoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Farmaceutico>> BuscarFarmaceuticosAsNoTrackingAsync(CancellationToken cancellationToken = default)
        {
            var farmaceuticos = await _context.Farmaceuticos
               .AsNoTracking()
               .ToListAsync(cancellationToken);

            return farmaceuticos;
        }
    }
}