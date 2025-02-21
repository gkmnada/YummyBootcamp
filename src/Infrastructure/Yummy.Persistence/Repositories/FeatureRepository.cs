using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(YummyContext context) : base(context)
        {
        }
    }
}
