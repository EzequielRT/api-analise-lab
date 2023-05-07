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

        public UnitOfWork(ApplicationDbContext context, ICertificadoAnaliseRepository certificadoAnaliseRepository)
        {
            _context = context;
            CertificadosAnalises = certificadoAnaliseRepository;
        }

        public async Task<bool> CompleteAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await _transaction.RollbackAsync();
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