using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LabCaseus.Analise.Infra.Data.Repositories
{
    public class CertificadoAnaliseRepository : ICertificadoAnaliseRepository
    {
        private readonly ApplicationDbContext _context;

        public CertificadoAnaliseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsNoTrackingAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CertificadoAnalise>> BuscarTodosCertificadosAnaliseAsync(CancellationToken cancellationToken = default)
        {
            var certificadosAnalise = await _context.CertificadosAnalises
                .AsNoTracking()
                .Include(x => x.Cliente)
                .Include(x => x.FarmaceuticoResponsavel)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.Ph)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.Ferro)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.Turbidez)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.Cloreto)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.CorAparente)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.AspectoVisual)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.CloroResidualLivre)
                .Include(x => x.AnaliseFisicoQuimica)
                    .ThenInclude(x => x.SolidosTotaisDissolvidos)
                .Include(x => x.EspecificacaosMetodologiasAnalise)
                    .ThenInclude(x => x.EspecificacaoMetodologia)
                .Include(x => x.AnaliseMicrobiologica)
                    .ThenInclude(x => x.ColiformeTermotolerante)
                .ToListAsync(cancellationToken);

            return certificadosAnalise;
        }
    }
}