using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Infra.Data.Context;

namespace LabCaseus.Analise.Infra.Data.Repositories
{
    internal class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async  Task AdicionarClienteAsync(Cliente cliente, CancellationToken cancellationToken = default)
        {
            await _context.Clientes.AddAsync(cliente, cancellationToken);
        }
    }
}