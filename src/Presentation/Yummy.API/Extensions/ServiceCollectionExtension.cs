using Yummy.Application.Interfaces.Repositories;
using Yummy.Persistence.Repositories;

namespace Yummy.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IBookingRepository, BookingRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
