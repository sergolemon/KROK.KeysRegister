using Application.Extensions;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Extensions;

namespace WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplication();
            services.AddPersistence(configuration);

            services.AddSwaggerDocument();
            services.AddControllers();

            return services;
        }
    }
}
