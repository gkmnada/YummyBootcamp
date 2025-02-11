using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public class ChefRepository : GenericRepository<Chef>, IChefRepository
    {
        public ChefRepository(YummyContext context) : base(context)
        {
        }
    }
}
