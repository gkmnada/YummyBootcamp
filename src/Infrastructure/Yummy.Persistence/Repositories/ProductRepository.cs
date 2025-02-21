using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(YummyContext context) : base(context)
        {
        }
    }
}
