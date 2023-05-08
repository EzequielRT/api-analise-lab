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
        public async Task AdicionarAsync(CertificadoAnalise certificadoAnalise, CancellationToken cancellationToken = default)
        {
            await _context.CertificadosAnalises.AddAsync(certificadoAnalise, cancellationToken);
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

        public async Task AdicionarPhAsync(Ph ph, CancellationToken cancellationToken = default)
        {
            await _context.Phs.AddAsync(ph, cancellationToken);
        }

        public async Task AdicionarFerroAsync(Ferro ferro, CancellationToken cancellationToken = default)
        {
            await _context.Ferros.AddAsync(ferro, cancellationToken);
        }

        public async Task AdicionarTurbidezAsync(Turbidez turbidez, CancellationToken cancellationToken = default)
        {
            await _context.Turbidez.AddAsync(turbidez, cancellationToken);
        }

        public async Task AdicionarCloretoAsync(Cloreto cloreto, CancellationToken cancellationToken = default)
        {
            await _context.Cloretos.AddAsync(cloreto, cancellationToken);
        }

        public async Task AdicionarCorAparenteAsync(CorAparente corAparente, CancellationToken cancellationToken = default)
        {
            await _context.CoresAparentes.AddAsync(corAparente, cancellationToken);
        }

        public async Task AdicionarAspectoVisualAsync(AspectoVisual aspectoVisual, CancellationToken cancellationToken = default)
        {
            await _context.AspectosVisuais.AddAsync(aspectoVisual, cancellationToken);
        }

        public async Task AdicionarCloroResidualLivreAsync(CloroResidualLivre cloroResidualLivre, CancellationToken cancellationToken = default)
        {
            await _context.ClorosResiduaisLivres.AddAsync(cloroResidualLivre, cancellationToken);
        }

        public async Task AdicionarSolidosTotaisDissolvidosAsync(SolidosTotaisDissolvidos solidosTotaisDissolvidos, CancellationToken cancellationToken = default)
        {
            await _context.SolidosTotaisDissolvidos.AddAsync(solidosTotaisDissolvidos, cancellationToken);
        }

        public async Task AdicionarColiformeTermotoleranteAsync(ColiformeTermotolerante coliformeTermotolerante, CancellationToken cancellationToken = default)
        {
            await _context.ColiformesTermotolerantes.AddAsync(coliformeTermotolerante, cancellationToken);
        }

        public async Task VincularAnaliseFisicoQuimicaAsync(AnaliseFisicoQuimica analiseFisicoQuimica, CancellationToken cancellationToken = default)
        {
            await _context.AnalisesFisicoQuimicas.AddAsync(analiseFisicoQuimica, cancellationToken);
        }

        public async Task VincularAnaliseMicrobiologicaAsync(AnaliseMicrobiologica analiseMicrobiologica, CancellationToken cancellationToken = default)
        {
            await _context.AnalisesMicrobiologicas.AddAsync(analiseMicrobiologica, cancellationToken);
        }

        public async Task VincularEspecificacoesMetodologiasAnaliseAsync(List<EspecificacaoMetodologiaAnalise> especificacoesMetodologiasAnalise, CancellationToken cancellationToken = default)
        {
            await _context.EspecificacoesMetodologiaAnalise.AddRangeAsync(especificacoesMetodologiasAnalise, cancellationToken);
        }
    }
}