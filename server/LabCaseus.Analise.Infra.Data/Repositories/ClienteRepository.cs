using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LabCaseus.Analise.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
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

        public async Task<List<Cliente>> BuscarClientesAsNoTrackingAsync(CancellationToken cancellationToken = default)
        {
            var clientes = await _context.Clientes
               .AsNoTracking()
               .ToListAsync(cancellationToken);

            return clientes;
        }
    }
}