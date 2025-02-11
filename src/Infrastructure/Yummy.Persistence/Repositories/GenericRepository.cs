using Microsoft.EntityFrameworkCore;
using Yummy.Application.Interfaces.Repositories;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly YummyContext _context;

        public GenericRepository(YummyContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await Task.CompletedTask;
        }

        public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FindAsync(id, cancellationToken) ?? throw new Exception("Entity not found");
        }

        public async Task<ICollection<T>> ListAsync(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await Task.CompletedTask;
        }
    }
}
