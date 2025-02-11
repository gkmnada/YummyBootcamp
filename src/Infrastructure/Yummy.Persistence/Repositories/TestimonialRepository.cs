using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(YummyContext context) : base(context)
        {
        }
    }
}
