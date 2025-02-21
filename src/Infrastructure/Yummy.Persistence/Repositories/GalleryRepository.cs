using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class GalleryRepository : GenericRepository<Gallery>, IGalleryRepository
    {
        public GalleryRepository(YummyContext context) : base(context)
        {
        }
    }
}
