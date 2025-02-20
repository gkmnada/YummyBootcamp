using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Yummy.Application.Features.Booking.Validators;

namespace Yummy.Application.Common.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });

            services.AddScoped<CreateBookingValidator>();
            services.AddScoped<UpdateBookingValidator>();
        }
    }
}
