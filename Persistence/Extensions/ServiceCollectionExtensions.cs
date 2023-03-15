using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MsSql") ?? 
                throw new Exception("Connection string \"MsSql\" was not set to appsettings.json.");

            services.AddDbContext<EfAppDbContext>(cfg => cfg.UseSqlServer(connectionString, 
                opts => opts.MigrationsAssembly(typeof(EfAppDbContext).Assembly.GetName().Name)));

            return services;
        }
    }
}
