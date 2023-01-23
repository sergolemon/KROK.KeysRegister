using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Extensions;

namespace WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistence(configuration);

            return services;
        }
    }
}
