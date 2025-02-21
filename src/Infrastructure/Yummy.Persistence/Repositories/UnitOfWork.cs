using Yummy.Application.Interfaces.Repositories;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly YummyContext _context;

        public UnitOfWork(YummyContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
