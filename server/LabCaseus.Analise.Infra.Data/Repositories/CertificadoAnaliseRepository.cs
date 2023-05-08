using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Domain.ValueObjects;
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

        public async Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsNoTrackingAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default)
        {
            var certificadoAnalise = await _context.CertificadosAnalises
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
                .FirstOrDefaultAsync(x => x.UId == certificadoAnaliseUId, cancellationToken);

            return certificadoAnalise;
        }

        public async Task<CertificadoAnalise> BuscarCertificadoAnalisePeloUIdAsync(Guid certificadoAnaliseUId, CancellationToken cancellationToken = default)
        {
            var certificadoAnalise = await _context.CertificadosAnalises
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
                .FirstOrDefaultAsync(x => x.UId == certificadoAnaliseUId, cancellationToken);

            return certificadoAnalise;
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

        public async Task<List<EspecificacaoMetodologia>> BuscarEspecificacoesMetodologiaAsNoTrackingAsync(CancellationToken cancellationToken = default)
        {
            var especificacoesMetodologia = await _context.EspecificacoesMetodologias
               .AsNoTracking()
               .ToListAsync(cancellationToken);

            return especificacoesMetodologia;
        }

        public async Task AdicionarFarmaceuticoResponsavelAsync(FarmaceuticoResponsavel farmaceuticoResponsavel, CancellationToken cancellationToken = default)
        {
            await _context.FarmaceuticosResponsaveis.AddAsync(farmaceuticoResponsavel, cancellationToken);
        }

        public async Task AdicionarPhAsync(Ph ph, CancellationToken cancellationToken = default)
        {
            await _context.Phs.AddAsync(ph, cancellationToken);
        }

        public async Task AdicionarFerroAsync(Ferro ferro, CancellationToken cancellationToken = default)
        {
            await _context.Ferros.AddAsync(ferro, cancellationToken);
        }
    }
}