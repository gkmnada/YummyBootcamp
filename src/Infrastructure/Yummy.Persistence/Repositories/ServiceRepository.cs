using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(YummyContext context) : base(context)
        {
        }
    }
}
