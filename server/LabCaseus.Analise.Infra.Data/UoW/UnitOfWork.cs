using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace LabCaseus.Analise.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction _transaction;

        public ICertificadoAnaliseRepository CertificadosAnalises { get; }
        public IFarmaceuticoRepository Farmaceuticos { get; }
        public IClienteRepository Clientes { get; }


        public UnitOfWork(
            ApplicationDbContext context,
            ICertificadoAnaliseRepository certificadoAnaliseRepository,
            IClienteRepository clienteRepository,
            IFarmaceuticoRepository farmaceuticoRepository)
        {
            _context = context;
            CertificadosAnalises = certificadoAnaliseRepository;
            Clientes = clienteRepository;
            Farmaceuticos = farmaceuticoRepository;
        }

        public async Task<bool> CompleteAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }

        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            _transaction = await _context.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _transaction.CommitAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                await _transaction.RollbackAsync(cancellationToken);
                throw ex;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();
        }
    }
}